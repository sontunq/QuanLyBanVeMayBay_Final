using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmKhachHang : Form
    {
        private int maKH = 0; // 0 = chưa chọn khách hàng nào

        // Dùng khi mở từ màn hình đặt vé: thêm xong thì đóng form và trả về mã khách vừa thêm
        public bool ThemNhanh = false;
        public int MaKHVuaThem = 0;

        public frmKhachHang()
        {
            InitializeComponent();
            GiaoDien.LuoiMuot(dgvKhachHang);
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            LamMoi();

            if (ThemNhanh)
                this.Text = "Thêm nhanh khách hàng";
        }

        private void LoadData()
        {
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = KetNoiCSDL.LayDuLieu("sp_KhachHang_DanhSach",
                new SqlParameter("@TuKhoa", txtTimKiem.Text.Trim()));
        }

        private void LamMoi()
        {
            maKH = 0;
            txtHoTen.Clear();
            txtCCCD.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            dtpNgaySinh.Value = new DateTime(1995, 1, 1);
            cboGioiTinh.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        private bool KiemTra()
        {
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Regex.IsMatch(txtCCCD.Text.Trim(), @"^\d{12}$"))
            {
                MessageBox.Show("Số CCCD phải gồm đúng 12 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSoDienThoai.Text.Trim() != "" && !Regex.IsMatch(txtSoDienThoai.Text.Trim(), @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtEmail.Text.Trim() != "" && !Regex.IsMatch(txtEmail.Text.Trim(), @"^[\w.]+@[\w-]+(\.[\w-]+)+$"))
            {
                MessageBox.Show("Email không hợp lệ (ví dụ: ten@gmail.com).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpNgaySinh.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            maKH = Convert.ToInt32(row.Cells["colMaKH"].Value);
            txtHoTen.Text = row.Cells["colHoTen"].Value.ToString();
            txtCCCD.Text = row.Cells["colCCCD"].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["colNgaySinh"].Value);
            cboGioiTinh.Text = row.Cells["colGioiTinh"].Value.ToString();
            txtSoDienThoai.Text = row.Cells["colSoDienThoai"].Value.ToString();
            txtEmail.Text = row.Cells["colEmail"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;

            try
            {
                DataTable kq = KetNoiCSDL.LayDuLieu("sp_KhachHang_Them",
                    new SqlParameter("@HoTen", txtHoTen.Text.Trim()),
                    new SqlParameter("@CCCD", txtCCCD.Text.Trim()),
                    new SqlParameter("@NgaySinh", dtpNgaySinh.Value.Date),
                    new SqlParameter("@GioiTinh", cboGioiTinh.Text),
                    new SqlParameter("@SoDienThoai", txtSoDienThoai.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()));

                MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ThemNhanh)
                {
                    MaKHVuaThem = Convert.ToInt32(kq.Rows[0]["MaKH"]);
                    this.Close();
                    return;
                }

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
            if (maKH == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra()) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_KhachHang_Sua",
                    new SqlParameter("@MaKH", maKH),
                    new SqlParameter("@HoTen", txtHoTen.Text.Trim()),
                    new SqlParameter("@CCCD", txtCCCD.Text.Trim()),
                    new SqlParameter("@NgaySinh", dtpNgaySinh.Value.Date),
                    new SqlParameter("@GioiTinh", cboGioiTinh.Text),
                    new SqlParameter("@SoDienThoai", txtSoDienThoai.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()));

                MessageBox.Show("Cập nhật khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (maKH == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng " + txtHoTen.Text + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_KhachHang_Xoa", new SqlParameter("@MaKH", maKH));
                MessageBox.Show("Xóa khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtTimKiem.Clear();
            LoadData();
            LamMoi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
