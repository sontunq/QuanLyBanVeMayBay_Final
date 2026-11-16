using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmSanBay : Form
    {
        public frmSanBay()
        {
            InitializeComponent();
        }

        private void frmSanBay_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvSanBay.AutoGenerateColumns = false;
            dgvSanBay.DataSource = KetNoiCSDL.LayDuLieu("sp_SanBay_DanhSach");
        }

        private void LamMoi()
        {
            txtMaSanBay.Clear();
            txtTenSanBay.Clear();
            txtThanhPho.Clear();
            txtMaSanBay.Enabled = true;
            txtMaSanBay.Focus();
        }

        private bool KiemTra()
        {
            if (txtMaSanBay.Text.Trim() == "" || txtTenSanBay.Text.Trim() == "" || txtThanhPho.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvSanBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSanBay.Rows[e.RowIndex];
            txtMaSanBay.Text = row.Cells["colMaSanBay"].Value.ToString();
            txtTenSanBay.Text = row.Cells["colTenSanBay"].Value.ToString();
            txtThanhPho.Text = row.Cells["colThanhPho"].Value.ToString();
            txtMaSanBay.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_SanBay_Them",
                    new SqlParameter("@MaSanBay", txtMaSanBay.Text.Trim()),
                    new SqlParameter("@TenSanBay", txtTenSanBay.Text.Trim()),
                    new SqlParameter("@ThanhPho", txtThanhPho.Text.Trim()));

                MessageBox.Show("Thêm sân bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtMaSanBay.Enabled)
            {
                MessageBox.Show("Vui lòng chọn sân bay cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra()) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_SanBay_Sua",
                    new SqlParameter("@MaSanBay", txtMaSanBay.Text.Trim()),
                    new SqlParameter("@TenSanBay", txtTenSanBay.Text.Trim()),
                    new SqlParameter("@ThanhPho", txtThanhPho.Text.Trim()));

                MessageBox.Show("Cập nhật sân bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtMaSanBay.Enabled)
            {
                MessageBox.Show("Vui lòng chọn sân bay cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sân bay " + txtMaSanBay.Text + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_SanBay_Xoa", new SqlParameter("@MaSanBay", txtMaSanBay.Text.Trim()));
                MessageBox.Show("Xóa sân bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
