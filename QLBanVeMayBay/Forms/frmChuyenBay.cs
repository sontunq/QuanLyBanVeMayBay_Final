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
        }

        private void frmChuyenBay_Load(object sender, EventArgs e)
        {
            try
            {
                cboMayBay.DisplayMember = "SoHieu";
                cboMayBay.ValueMember = "MaMayBay";
                cboMayBay.DataSource = KetNoiCSDL.LayDuLieu("sp_MayBay_DanhSach");

                DataTable sanBay = KetNoiCSDL.LayDuLieu("sp_SanBay_DanhSach");
                cboSanBayDi.DisplayMember = "MaSanBay";
                cboSanBayDi.ValueMember = "MaSanBay";
                cboSanBayDi.DataSource = sanBay;
                cboSanBayDen.DisplayMember = "MaSanBay";
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

        private void LoadData()
        {
            dgvChuyenBay.AutoGenerateColumns = false;
            dgvChuyenBay.DataSource = KetNoiCSDL.LayDuLieu("sp_ChuyenBay_DanhSach");
        }

        private void LamMoi()
        {
            txtMaChuyenBay.Clear();
            txtMaChuyenBay.Enabled = true;
            cboTrangThai.SelectedIndex = 0;
            dtpNgayGioBay.Value = DateTime.Today.AddDays(1).AddHours(8);
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
                new SqlParameter("@NgayGioBay", dtpNgayGioBay.Value),
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
            dtpNgayGioBay.Value = Convert.ToDateTime(row.Cells["colNgayGioBay"].Value);
            nudGiaPhoThong.Value = Convert.ToDecimal(row.Cells["colGiaPhoThong"].Value);
            nudGiaThuongGia.Value = Convert.ToDecimal(row.Cells["colGiaThuongGia"].Value);
            cboTrangThai.Text = row.Cells["colTrangThai"].Value.ToString();
            txtMaChuyenBay.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;

            if (dtpNgayGioBay.Value <= DateTime.Now)
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
