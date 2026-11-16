using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmHuyVe : Form
    {
        private int maVe = 0; // 0 = chưa chọn vé nào
        private bool coTheHuy = false; // vé đang chọn còn hủy được không (chưa hủy, chuyến chưa bay)

        public frmHuyVe()
        {
            InitializeComponent();
            GiaoDien.LuoiMuot(dgvVe);
        }

        private void frmHuyVe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvVe.AutoGenerateColumns = false;
                dgvVe.DataSource = KetNoiCSDL.LayDuLieu("sp_Ve_DanhSach",
                    new SqlParameter("@TuKhoa", txtTimKiem.Text.Trim()));
                maVe = 0;
                coTheHuy = false;
                lblVeChon.Text = "Chưa chọn vé.";
                lblPhiHuy.Text = "Phí hủy: -";
                txtLyDoHuy.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvVe.Rows[e.RowIndex];
            maVe = Convert.ToInt32(row.Cells["colMaVe"].Value);
            lblVeChon.Text = "Vé đang chọn: #" + maVe + " - " + row.Cells["colHoTen"].Value
                           + " - Chuyến " + row.Cells["colMaChuyenBay"].Value
                           + " - Ghế " + row.Cells["colSoGhe"].Value
                           + " (" + row.Cells["colTrangThai"].Value + ")";
            coTheHuy = false;

            try
            {
                if (row.Cells["colTrangThai"].Value.ToString() == "Đã hủy")
                {
                    // Vé đã hủy: hiện lại phí, tiền hoàn và lý do đã lưu
                    lblPhiHuy.Text = "Đã hủy - Phí hủy: " + TienTe(row.Cells["colPhiHuy"].Value)
                                   + " - Hoàn lại: " + TienTe(row.Cells["colTienHoan"].Value)
                                   + "\nLý do: " + row.Cells["colLyDoHuy"].Value;
                    return;
                }

                // Vé còn hiệu lực: xem trước phí hủy nếu hủy ngay bây giờ
                DataRow r = KetNoiCSDL.LayDuLieu("sp_Ve_TinhPhiHuy", new SqlParameter("@MaVe", maVe)).Rows[0];
                int soPhut = Convert.ToInt32(r["SoPhutConLai"]);
                if (soPhut <= 0)
                {
                    lblPhiHuy.Text = "Chuyến bay đã khởi hành, không thể hủy vé.";
                    return;
                }

                lblPhiHuy.Text = "Còn " + ThoiGianConLai(soPhut) + " trước giờ bay - Phí hủy " + r["TyLePhi"] + "%: "
                               + TienTe(r["PhiHuy"]) + "\nTiền hoàn cho khách: " + TienTe(r["TienHoan"]);
                coTheHuy = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string TienTe(object giaTri)
        {
            if (giaTri == null || giaTri == DBNull.Value) return "0 đ";
            return Convert.ToDecimal(giaTri).ToString("N0") + " đ";
        }

        private string ThoiGianConLai(int soPhut)
        {
            if (soPhut >= 1440)
                return (soPhut / 1440) + " ngày " + (soPhut % 1440 / 60) + " giờ";
            return (soPhut / 60) + " giờ " + (soPhut % 60) + " phút";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadData();
        }

        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            if (maVe == 0)
            {
                MessageBox.Show("Vui lòng chọn vé cần hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!coTheHuy)
            {
                MessageBox.Show("Vé này đã hủy hoặc chuyến bay đã khởi hành, không thể hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtLyDoHuy.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập lý do hủy vé.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLyDoHuy.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn hủy vé #" + maVe + "?\n\n" + lblPhiHuy.Text
                + "\nLý do: " + txtLyDoHuy.Text.Trim(), "Xác nhận hủy vé",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                // Phí hủy được tính lại trong sp_Ve_Huy tại thời điểm hủy
                DataRow kq = KetNoiCSDL.LayDuLieu("sp_Ve_Huy",
                    new SqlParameter("@MaVe", maVe),
                    new SqlParameter("@LyDoHuy", txtLyDoHuy.Text.Trim())).Rows[0];

                MessageBox.Show("Hủy vé thành công.\nPhí hủy (" + kq["TyLePhiHuy"] + "%): " + TienTe(kq["PhiHuy"])
                    + "\nTiền hoàn cho khách: " + TienTe(kq["TienHoan"]),
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            if (maVe == 0)
            {
                MessageBox.Show("Vui lòng chọn vé cần in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = KetNoiCSDL.LayDuLieu("sp_BaoCao_Ve", new SqlParameter("@MaVe", maVe));
                frmBaoCao f = new frmBaoCao("rptVe.rpt", dt);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
