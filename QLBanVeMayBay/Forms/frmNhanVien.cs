using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmNhanVien : Form
    {
        private int maNV = 0; // 0 = chưa chọn nhân viên nào

        public frmNhanVien()
        {
            InitializeComponent();
            GiaoDien.LuoiMuot(dgvNhanVien);
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LamMoi();
        }

        private void LoadData()
        {
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = KetNoiCSDL.LayDuLieu("sp_NhanVien_DanhSach");
        }

        private void LamMoi()
        {
            maNV = 0;
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboVaiTro.SelectedIndex = 1;
            txtHoTen.Focus();
        }

        private bool KiemTra()
        {
            if (txtHoTen.Text.Trim() == "" || txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên và tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            maNV = Convert.ToInt32(row.Cells["colMaNV"].Value);
            txtHoTen.Text = row.Cells["colHoTen"].Value.ToString();
            txtTenDangNhap.Text = row.Cells["colTenDangNhap"].Value.ToString();
            txtMatKhau.Clear();
            cboVaiTro.Text = row.Cells["colVaiTro"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                KetNoiCSDL.ThucThi("sp_NhanVien_Them",
                    new SqlParameter("@HoTen", txtHoTen.Text.Trim()),
                    new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()),
                    new SqlParameter("@MatKhau", txtMatKhau.Text),
                    new SqlParameter("@VaiTro", cboVaiTro.Text));

                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (maNV == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra()) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_NhanVien_Sua",
                    new SqlParameter("@MaNV", maNV),
                    new SqlParameter("@HoTen", txtHoTen.Text.Trim()),
                    new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()),
                    new SqlParameter("@MatKhau", txtMatKhau.Text),
                    new SqlParameter("@VaiTro", cboVaiTro.Text));

                MessageBox.Show("Cập nhật nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (maNV == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (maNV == PhienDangNhap.MaNV)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên " + txtHoTen.Text + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_NhanVien_Xoa", new SqlParameter("@MaNV", maNV));
                MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
