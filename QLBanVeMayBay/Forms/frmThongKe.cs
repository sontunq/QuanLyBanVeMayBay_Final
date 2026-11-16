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
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Năm " + nudNam.Value + " chưa có doanh thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
