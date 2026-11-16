using System;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblXinChao.Text = "Xin chào, " + PhienDangNhap.HoTen;
            lblNguoiDung.Text = "Nhân viên: " + PhienDangNhap.HoTen + "   |   Vai trò: " + PhienDangNhap.VaiTro;
            lblNgay.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");

            // Căn giữa tiêu đề
            lblTieuDe.Left = (this.ClientSize.Width - lblTieuDe.Width) / 2;
            lblXinChao.Left = (this.ClientSize.Width - lblXinChao.Width) / 2;

            // Chỉ Admin mới quản lý được nhân viên
            mnuQuanTri.Visible = PhienDangNhap.VaiTro == "Admin";
        }

        private void MoForm(Form f)
        {
            f.ShowDialog();
        }

        // ===== Menu =====
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSanBay_Click(object sender, EventArgs e)
        {
            MoForm(new frmSanBay());
        }

        private void mnuMayBay_Click(object sender, EventArgs e)
        {
            MoForm(new frmMayBay());
        }

        private void mnuChuyenBay_Click(object sender, EventArgs e)
        {
            MoForm(new frmChuyenBay());
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            MoForm(new frmKhachHang());
        }

        private void mnuDatVe_Click(object sender, EventArgs e)
        {
            MoForm(new frmDatVe());
        }

        private void mnuHuyVe_Click(object sender, EventArgs e)
        {
            MoForm(new frmHuyVe());
        }

        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            MoForm(new frmThongKe());
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            MoForm(new frmNhanVien());
        }

        // ===== Nút chức năng nhanh =====
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            MoForm(new frmDatVe());
        }

        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            MoForm(new frmHuyVe());
        }

        private void btnChuyenBay_Click(object sender, EventArgs e)
        {
            MoForm(new frmChuyenBay());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            MoForm(new frmKhachHang());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            MoForm(new frmThongKe());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
