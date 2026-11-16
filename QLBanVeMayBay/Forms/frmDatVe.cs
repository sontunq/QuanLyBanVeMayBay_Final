using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmDatVe : Form
    {
        private int maVeVuaDat = 0;
        private decimal giaGoc = 0;   // Giá theo hạng vé của chuyến đang chọn
        private DataTable gheTrong;   // Toàn bộ ghế trống của chuyến + hạng vé đang chọn
        private int tyLeGiam = 0;     // % ưu đãi của khách đang chọn

        public frmDatVe()
        {
            InitializeComponent();
            GiaoDien.LuoiMuot(dgvHanhKhach);
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

                rdoTatCa.Checked = true;
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
                gheTrong = null;
                LocGhe();
                giaGoc = 0;
                TinhTien();
                lblHanhTrinh.Text = "Hành trình:";
                return;
            }

            gheTrong = KetNoiCSDL.LayDuLieu("sp_Ghe_ConTrong",
                new SqlParameter("@MaChuyenBay", MaChuyenBay()),
                new SqlParameter("@HangVe", cboHangVe.Text));
            LocGhe();

            DataRowView chuyen = (DataRowView)cboChuyenBay.SelectedItem;
            giaGoc = cboHangVe.Text == "Thương gia"
                ? Convert.ToDecimal(chuyen["GiaThuongGia"])
                : Convert.ToDecimal(chuyen["GiaPhoThong"]);
            TinhTien();

            lblHanhTrinh.Text = "Hành trình: " + chuyen["TenSanBayDi"] + " → " + chuyen["TenSanBayDen"]
                + "\nGiờ bay: " + Convert.ToDateTime(chuyen["NgayGioBay"]).ToString("dd/MM/yyyy HH:mm")
                + "   -   Giờ đến: " + Convert.ToDateTime(chuyen["NgayGioDen"]).ToString("dd/MM/yyyy HH:mm");

            dgvHanhKhach.DataSource = KetNoiCSDL.LayDuLieu("sp_BaoCao_HanhKhach",
                new SqlParameter("@MaChuyenBay", MaChuyenBay()));
        }

        // Lấy hạng thành viên và % ưu đãi của khách đang chọn (quy tắc nằm trong vw_UuDaiKhachHang)
        private void LoadUuDai()
        {
            tyLeGiam = 0;

            if (!(cboKhachHang.SelectedValue is int))
            {
                lblUuDai.Text = "Chưa chọn khách hàng";
                TinhTien();
                return;
            }

            DataTable dt = KetNoiCSDL.LayDuLieu("sp_KhachHang_UuDai",
                new SqlParameter("@MaKH", cboKhachHang.SelectedValue));
            if (dt.Rows.Count == 0)
            {
                lblUuDai.Text = "Chưa chọn khách hàng";
                TinhTien();
                return;
            }

            DataRow r = dt.Rows[0];
            int tyLeHang = Convert.ToInt32(r["TyLeHang"]);
            int tyLeKhachMoi = Convert.ToInt32(r["TyLeKhachMoi"]);
            tyLeGiam = Convert.ToInt32(r["TyLeGiam"]);

            // Ưu đãi được cộng dồn, ví dụ: "Hạng Bạc (-4%) + Khách mới (-10%)"
            string uuDai = "";
            if (tyLeHang > 0)
                uuDai = "Hạng " + r["TenHang"] + " (-" + tyLeHang + "%)";
            if (tyLeKhachMoi > 0)
                uuDai += (uuDai == "" ? "" : " + ") + "Khách mới (-" + tyLeKhachMoi + "%)";
            if (uuDai == "")
                uuDai = "Hạng " + r["TenHang"] + " (không giảm)";

            lblUuDai.Text = uuDai;
            TinhTien();
        }

        // Thành tiền = giá gốc trừ % ưu đãi, làm tròn như ROUND trong sp_Ve_Dat
        private decimal ThanhTien()
        {
            return Math.Round(giaGoc * (100 - tyLeGiam) / 100, 0, MidpointRounding.AwayFromZero);
        }

        private void TinhTien()
        {
            lblGiaGoc.Text = giaGoc.ToString("N0") + " đ";
            lblGiaVe.Text = ThanhTien().ToString("N0") + " đ";
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadUuDai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Vị trí đang chọn ở nhóm "Vị trí"; "" nghĩa là tất cả
        private string ViTriDangChon()
        {
            if (rdoCuaSo.Checked) return "Cửa sổ";
            if (rdoLoiDi.Checked) return "Lối đi";
            if (rdoGheGiua.Checked) return "Ghế giữa";
            return "";
        }

        // Hiện ghế trống theo vị trí đang chọn (ThongTin có dạng "5C - Lối đi")
        private void LocGhe()
        {
            if (gheTrong == null)
            {
                cboGhe.DataSource = null;
                lblConTrong.Text = "Số ghế còn trống: 0";
                return;
            }

            DataView ds = new DataView(gheTrong);
            string viTri = ViTriDangChon();
            if (viTri != "")
                ds.RowFilter = "ThongTin LIKE '%- " + viTri + "'";

            cboGhe.DisplayMember = "ThongTin";
            cboGhe.ValueMember = "MaGhe";
            cboGhe.DataSource = ds;

            lblConTrong.Text = "Số ghế " + cboHangVe.Text.ToLower() + " còn trống: " + gheTrong.Rows.Count
                             + (viTri != "" ? "  (" + viTri.ToLower() + ": " + ds.Count + ")" : "");
        }

        private void rdoViTri_CheckedChanged(object sender, EventArgs e)
        {
            // Mỗi lần đổi chọn có 2 nút thay đổi, chỉ xử lý ở nút vừa được chọn
            if (((RadioButton)sender).Checked)
                LocGhe();
        }

        // Tự chọn ghế trống gần đầu máy bay nhất.
        // Nếu đang để "Tất cả" thì ưu tiên cửa sổ, rồi lối đi, rồi ghế giữa.
        private void btnTuChonGhe_Click(object sender, EventArgs e)
        {
            if (cboGhe.Items.Count == 0)
            {
                MessageBox.Show("Không còn ghế trống phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ViTriDangChon() == "")
            {
                foreach (string viTri in new string[] { "Cửa sổ", "Lối đi", "Ghế giữa" })
                {
                    DataRow[] ghe = gheTrong.Select("ThongTin LIKE '%- " + viTri + "'", "MaGhe");
                    if (ghe.Length > 0)
                    {
                        cboGhe.SelectedValue = ghe[0]["MaGhe"];
                        return;
                    }
                }
            }

            cboGhe.SelectedIndex = 0;
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
            f.ThemNhanh = true;
            f.ShowDialog();

            try
            {
                object maCu = cboKhachHang.SelectedValue;
                LoadKhachHang();

                // Chọn sẵn khách vừa thêm, nếu không thêm thì giữ khách đang chọn
                if (f.MaKHVuaThem > 0)
                    cboKhachHang.SelectedValue = f.MaKHVuaThem;
                else if (maCu != null)
                    cboKhachHang.SelectedValue = maCu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (MaChuyenBay() == "")
            {
                MessageBox.Show("Không có chuyến bay nào đang mở bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Ô khách hàng cho phép gõ để tìm, nên phải kiểm tra chữ đang hiện đúng là một khách trong danh sách
            if (cboKhachHang.SelectedIndex < 0 || cboKhachHang.Text != cboKhachHang.GetItemText(cboKhachHang.SelectedItem))
            {
                MessageBox.Show("Vui lòng chọn khách hàng trong danh sách (hoặc bấm + để thêm khách mới).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboGhe.SelectedIndex < 0)
            {
                MessageBox.Show("Không còn ghế trống phù hợp với hạng vé và vị trí đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string xacNhan = "Đặt vé chuyến " + MaChuyenBay() + ", ghế " + cboGhe.Text + " cho khách " + cboKhachHang.Text
                           + "?\nGiá gốc: " + lblGiaGoc.Text
                           + "\nƯu đãi: " + lblUuDai.Text
                           + "\nThành tiền: " + lblGiaVe.Text + " - Thanh toán: " + cboPhuongThuc.Text;
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
                LoadUuDai(); // Khách vừa mua vé nên không còn là khách mới, tổng chi tiêu cũng thay đổi

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
