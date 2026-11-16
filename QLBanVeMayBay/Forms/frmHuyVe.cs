using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmHuyVe : Form
    {
        private int maVe = 0; // 0 = chưa chọn vé nào

        public frmHuyVe()
        {
            InitializeComponent();
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
                lblVeChon.Text = "Chưa chọn vé.";
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

            if (MessageBox.Show("Bạn có chắc muốn hủy vé #" + maVe + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_Ve_Huy", new SqlParameter("@MaVe", maVe));
                MessageBox.Show("Hủy vé thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
