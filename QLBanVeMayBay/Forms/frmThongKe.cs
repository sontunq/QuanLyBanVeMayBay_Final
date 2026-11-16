using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            GiaoDien.LuoiMuot(dgvTheoThang);
            GiaoDien.LuoiMuot(dgvTheoChuyen);
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dgvTheoThang.AutoGenerateColumns = false;
            dgvTheoChuyen.AutoGenerateColumns = false;
            nudNam.Value = DateTime.Now.Year;
            XemThongKe();
        }

        private void XemThongKe()
        {
            try
            {
                SqlParameter nam = new SqlParameter("@Nam", (int)nudNam.Value);
                DataTable dt;

                if (rdoTheoThang.Checked)
                {
                    dt = KetNoiCSDL.LayDuLieu("sp_ThongKe_TheoThang", nam);
                    dgvTheoThang.DataSource = dt;
                }
                else
                {
                    dt = KetNoiCSDL.LayDuLieu("sp_ThongKe_TheoChuyen", nam);
                    dgvTheoChuyen.DataSource = dt;
                }

                dgvTheoThang.Visible = rdoTheoThang.Checked;
                dgvTheoChuyen.Visible = rdoTheoChuyen.Checked;
                btnInBaoCao.Enabled = rdoTheoThang.Checked;

                // Cộng tổng số vé và doanh thu
                int tongVe = 0;
                decimal tongDoanhThu = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongVe += Convert.ToInt32(row["SoVe"]);
                    tongDoanhThu += Convert.ToDecimal(row["DoanhThu"]);
                }
                lblTongVe.Text = tongVe.ToString();
                lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            XemThongKe();
        }

        private void rdoTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoThang.Checked) XemThongKe();
        }

        private void rdoTheoChuyen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoChuyen.Checked) XemThongKe();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = KetNoiCSDL.LayDuLieu("sp_ThongKe_TheoThang", new SqlParameter("@Nam", (int)nudNam.Value));

                // Proc luôn trả đủ 12 tháng, nên kiểm tra tổng doanh thu thay vì số dòng
                decimal tong = 0;
                foreach (DataRow row in dt.Rows)
                    tong += Convert.ToDecimal(row["DoanhThu"]);
                if (tong == 0)
                {
                    MessageBox.Show("Năm " + nudNam.Value + " chưa có doanh thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Người lập và ngày lập hiện ở phần ký tên cuối báo cáo
                DateTime homNay = DateTime.Now;
                dt.Columns.Add("NguoiLap", typeof(string));
                dt.Columns.Add("NgayLap", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    row["NguoiLap"] = PhienDangNhap.HoTen;
                    row["NgayLap"] = "Ngày " + homNay.Day + " tháng " + homNay.Month + " năm " + homNay.Year;
                }

                frmBaoCao f = new frmBaoCao("rptDoanhThuThang.rpt", dt);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
