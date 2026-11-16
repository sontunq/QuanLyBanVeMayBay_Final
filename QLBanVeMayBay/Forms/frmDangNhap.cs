using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = KetNoiCSDL.LayDuLieu("sp_DangNhap",
                    new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()),
                    new SqlParameter("@MatKhau", txtMatKhau.Text));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                PhienDangNhap.MaNV = Convert.ToInt32(dt.Rows[0]["MaNV"]);
                PhienDangNhap.HoTen = dt.Rows[0]["HoTen"].ToString();
                PhienDangNhap.VaiTro = dt.Rows[0]["VaiTro"].ToString();

                this.Hide();
                frmMain f = new frmMain();
                f.ShowDialog();

                // Đăng xuất thì quay lại màn hình đăng nhập
                txtMatKhau.Clear();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được cơ sở dữ liệu.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
