using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmDatVe : Form
    {
        private int maVeVuaDat = 0;

        public frmDatVe()
        {
            InitializeComponent();
        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHanhKhach.AutoGenerateColumns = false;
                cboPhuongThuc.SelectedIndex = 0;
                LoadKhachHang();

                cboChuyenBay.DisplayMember = "ThongTin";
                cboChuyenBay.ValueMember = "MaChuyenBay";
                cboChuyenBay.DataSource = KetNoiCSDL.LayDuLieu("sp_ChuyenBay_ConBan");

                cboHangVe.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKhachHang()
        {
            cboKhachHang.DisplayMember = "ThongTin";
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.DataSource = KetNoiCSDL.LayDuLieu("sp_KhachHang_ChonLua");
        }

        private string MaChuyenBay()
        {
            if (cboChuyenBay.SelectedIndex < 0) return "";
            return cboChuyenBay.SelectedValue.ToString();
        }

        // Nạp ghế trống, giá vé và danh sách hành khách của chuyến đang chọn
        private void LoadChuyenBay()
        {
            if (MaChuyenBay() == "" || cboHangVe.SelectedIndex < 0)
            {
                cboGhe.DataSource = null;
                lblGiaVe.Text = "0 đ";
                return;
            }

            DataTable ghe = KetNoiCSDL.LayDuLieu("sp_Ghe_ConTrong",
                new SqlParameter("@MaChuyenBay", MaChuyenBay()),
                new SqlParameter("@HangVe", cboHangVe.Text));
            cboGhe.DisplayMember = "SoGhe";
            cboGhe.ValueMember = "MaGhe";
            cboGhe.DataSource = ghe;
            lblConTrong.Text = "Số ghế " + cboHangVe.Text.ToLower() + " còn trống: " + ghe.Rows.Count;

            DataRowView chuyen = (DataRowView)cboChuyenBay.SelectedItem;
            decimal gia = cboHangVe.Text == "Thương gia"
                ? Convert.ToDecimal(chuyen["GiaThuongGia"])
                : Convert.ToDecimal(chuyen["GiaPhoThong"]);
            lblGiaVe.Text = gia.ToString("N0") + " đ";

            dgvHanhKhach.DataSource = KetNoiCSDL.LayDuLieu("sp_BaoCao_HanhKhach",
                new SqlParameter("@MaChuyenBay", MaChuyenBay()));
        }

        private void cboChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChuyenBay();
        }

        private void cboHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChuyenBay();
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
            LoadKhachHang();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (MaChuyenBay() == "")
            {
                MessageBox.Show("Không có chuyến bay nào đang mở bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboKhachHang.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboGhe.SelectedIndex < 0)
            {
                MessageBox.Show("Hạng vé này đã hết ghế trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string xacNhan = "Đặt vé chuyến " + MaChuyenBay() + ", ghế " + cboGhe.Text + " cho khách " + cboKhachHang.Text
                           + "?\nGiá vé: " + lblGiaVe.Text + " - Thanh toán: " + cboPhuongThuc.Text;
            if (MessageBox.Show(xacNhan, "Xác nhận đặt vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                DataTable kq = KetNoiCSDL.LayDuLieu("sp_Ve_Dat",
                    new SqlParameter("@MaChuyenBay", MaChuyenBay()),
                    new SqlParameter("@MaKH", cboKhachHang.SelectedValue),
                    new SqlParameter("@MaGhe", cboGhe.SelectedValue),
                    new SqlParameter("@PhuongThuc", cboPhuongThuc.Text),
                    new SqlParameter("@MaNV", PhienDangNhap.MaNV));

                maVeVuaDat = Convert.ToInt32(kq.Rows[0]["MaVe"]);
                btnInVe.Enabled = true;
                LoadChuyenBay();

                if (MessageBox.Show("Đặt vé thành công. Mã vé: " + maVeVuaDat + "\nBạn có muốn in vé không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    InVe(maVeVuaDat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InVe(int maVe)
        {
            DataTable dt = KetNoiCSDL.LayDuLieu("sp_BaoCao_Ve", new SqlParameter("@MaVe", maVe));
            frmBaoCao f = new frmBaoCao("rptVe.rpt", dt);
            f.ShowDialog();
        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            try
            {
                InVe(maVeVuaDat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmDatVe_Load(sender, e);
            maVeVuaDat = 0;
            btnInVe.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
