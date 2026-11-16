using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmChuyenBay : Form
    {
        public frmChuyenBay()
        {
            InitializeComponent();
            GiaoDien.LuoiMuot(dgvChuyenBay);
        }

        private void frmChuyenBay_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMayBay();

                DataTable sanBay = KetNoiCSDL.LayDuLieu("sp_SanBay_DanhSach");
                cboSanBayDi.DisplayMember = "ThongTin";
                cboSanBayDi.ValueMember = "MaSanBay";
                cboSanBayDi.DataSource = sanBay;
                cboSanBayDen.DisplayMember = "ThongTin";
                cboSanBayDen.ValueMember = "MaSanBay";
                cboSanBayDen.DataSource = sanBay.Copy();

                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMayBay()
        {
            cboMayBay.DisplayMember = "SoHieu";
            cboMayBay.ValueMember = "MaMayBay";
            cboMayBay.DataSource = KetNoiCSDL.LayDuLieu("sp_MayBay_DanhSach");
        }

        private void LoadData()
        {
            dgvChuyenBay.AutoGenerateColumns = false;
            dgvChuyenBay.DataSource = KetNoiCSDL.LayDuLieu("sp_ChuyenBay_DanhSach");
        }

        // Ghép ngày (ô ngày) và giờ (ô giờ) thành ngày giờ bay, bỏ phần giây
        private DateTime NgayGioBay()
        {
            DateTime gio = dtpGioBay.Value;
            return dtpNgayBay.Value.Date.AddHours(gio.Hour).AddMinutes(gio.Minute);
        }

        private void HienNgayGioBay(DateTime ngayGio)
        {
            dtpNgayBay.Value = ngayGio.Date;
            dtpGioBay.Value = ngayGio;
        }

        // Giờ đến = giờ bay + thời gian bay
        private void ThoiGian_ValueChanged(object sender, EventArgs e)
        {
            lblGioDen.Text = NgayGioBay().AddMinutes((double)nudThoiGianBay.Value).ToString("dd/MM/yyyy HH:mm");
        }

        private void LamMoi()
        {
            txtMaChuyenBay.Clear();
            txtMaChuyenBay.Enabled = true;
            cboTrangThai.SelectedIndex = 0;
            HienNgayGioBay(DateTime.Today.AddDays(1).AddHours(8));
            nudThoiGianBay.Value = 120;
            nudGiaPhoThong.Value = 1000000;
            nudGiaThuongGia.Value = 2500000;
            txtMaChuyenBay.Focus();
        }

        private bool KiemTra()
        {
            if (txtMaChuyenBay.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã chuyến bay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboMayBay.SelectedValue == null || cboSanBayDi.SelectedValue == null || cboSanBayDen.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn máy bay, sân bay đi và sân bay đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nudGiaPhoThong.Value <= 0 || nudGiaThuongGia.Value <= 0)
            {
                MessageBox.Show("Giá vé phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private SqlParameter[] ThamSo()
        {
            return new SqlParameter[]
            {
                new SqlParameter("@MaChuyenBay", txtMaChuyenBay.Text.Trim()),
                new SqlParameter("@MaMayBay", cboMayBay.SelectedValue),
                new SqlParameter("@SanBayDi", cboSanBayDi.SelectedValue),
                new SqlParameter("@SanBayDen", cboSanBayDen.SelectedValue),
                new SqlParameter("@NgayGioBay", NgayGioBay()),
                new SqlParameter("@ThoiGianBay", (int)nudThoiGianBay.Value),
                new SqlParameter("@GiaPhoThong", nudGiaPhoThong.Value),
                new SqlParameter("@GiaThuongGia", nudGiaThuongGia.Value),
                new SqlParameter("@TrangThai", cboTrangThai.Text)
            };
        }

        private void dgvChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvChuyenBay.Rows[e.RowIndex];
            txtMaChuyenBay.Text = row.Cells["colMaChuyenBay"].Value.ToString();
            cboMayBay.SelectedValue = row.Cells["colMaMayBay"].Value;
            cboSanBayDi.SelectedValue = row.Cells["colSanBayDi"].Value;
            cboSanBayDen.SelectedValue = row.Cells["colSanBayDen"].Value;
            HienNgayGioBay(Convert.ToDateTime(row.Cells["colNgayGioBay"].Value));
            nudThoiGianBay.Value = Convert.ToInt32(row.Cells["colThoiGianBay"].Value);
            nudGiaPhoThong.Value = Convert.ToDecimal(row.Cells["colGiaPhoThong"].Value);
            nudGiaThuongGia.Value = Convert.ToDecimal(row.Cells["colGiaThuongGia"].Value);
            cboTrangThai.Text = row.Cells["colTrangThai"].Value.ToString();
            txtMaChuyenBay.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;

            if (NgayGioBay() <= DateTime.Now)
            {
                MessageBox.Show("Ngày giờ bay phải sau thời điểm hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KetNoiCSDL.ThucThi("sp_ChuyenBay_Them", ThamSo());
                MessageBox.Show("Thêm chuyến bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenBay.Enabled)
            {
                MessageBox.Show("Vui lòng chọn chuyến bay cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra()) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_ChuyenBay_Sua", ThamSo());
                MessageBox.Show("Cập nhật chuyến bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenBay.Enabled)
            {
                MessageBox.Show("Vui lòng chọn chuyến bay cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa chuyến bay " + txtMaChuyenBay.Text + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_ChuyenBay_Xoa", new SqlParameter("@MaChuyenBay", txtMaChuyenBay.Text.Trim()));
                MessageBox.Show("Xóa chuyến bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        // Mở form máy bay để thêm nhanh, đóng lại thì chọn máy bay vừa thêm (mã lớn nhất)
        private void btnThemMayBay_Click(object sender, EventArgs e)
        {
            frmMayBay f = new frmMayBay();
            f.ShowDialog();

            try
            {
                object maCu = cboMayBay.SelectedValue;
                int soCu = cboMayBay.Items.Count;
                LoadMayBay();

                if (cboMayBay.Items.Count > soCu)
                    cboMayBay.SelectedIndex = cboMayBay.Items.Count - 1;
                else if (maCu != null)
                    cboMayBay.SelectedValue = maCu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenBay.Enabled)
            {
                MessageBox.Show("Vui lòng chọn chuyến bay cần in danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = KetNoiCSDL.LayDuLieu("sp_BaoCao_HanhKhach", new SqlParameter("@MaChuyenBay", txtMaChuyenBay.Text.Trim()));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Chuyến bay này chưa có hành khách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frmBaoCao f = new frmBaoCao("rptHanhKhach.rpt", dt);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
