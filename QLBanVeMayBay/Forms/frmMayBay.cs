using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanVeMayBay.Forms
{
    public partial class frmMayBay : Form
    {
        private int maMayBay = 0; // 0 = chưa chọn máy bay nào

        public frmMayBay()
        {
            InitializeComponent();
            GiaoDien.LuoiMuot(dgvMayBay);
        }

        private void frmMayBay_Load(object sender, EventArgs e)
        {
            LoadData();
            nudSoHangGhe_ValueChanged(null, null);
        }

        private void LoadData()
        {
            dgvMayBay.AutoGenerateColumns = false;
            dgvMayBay.DataSource = KetNoiCSDL.LayDuLieu("sp_MayBay_DanhSach");
        }

        private void LamMoi()
        {
            maMayBay = 0;
            txtSoHieu.Clear();
            txtLoaiMayBay.Clear();
            nudSoHangGhe.Value = 10;
            nudSoHangGhe.Enabled = true;
            txtSoHieu.Focus();
        }

        private void nudSoHangGhe_ValueChanged(object sender, EventArgs e)
        {
            lblTongGhe.Text = "= " + (nudSoHangGhe.Value * 6) + " ghế";
        }

        private bool KiemTra()
        {
            if (txtSoHieu.Text.Trim() == "" || txtLoaiMayBay.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số hiệu và loại máy bay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvMayBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvMayBay.Rows[e.RowIndex];
            maMayBay = Convert.ToInt32(row.Cells["colMaMayBay"].Value);
            txtSoHieu.Text = row.Cells["colSoHieu"].Value.ToString();
            txtLoaiMayBay.Text = row.Cells["colLoaiMayBay"].Value.ToString();
            nudSoHangGhe.Value = Convert.ToInt32(row.Cells["colSoHangGhe"].Value);
            nudSoHangGhe.Enabled = false; // Không đổi số ghế sau khi đã tạo
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_MayBay_Them",
                    new SqlParameter("@SoHieu", txtSoHieu.Text.Trim()),
                    new SqlParameter("@LoaiMayBay", txtLoaiMayBay.Text.Trim()),
                    new SqlParameter("@SoHangGhe", (int)nudSoHangGhe.Value));

                MessageBox.Show("Thêm máy bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (maMayBay == 0)
            {
                MessageBox.Show("Vui lòng chọn máy bay cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTra()) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_MayBay_Sua",
                    new SqlParameter("@MaMayBay", maMayBay),
                    new SqlParameter("@SoHieu", txtSoHieu.Text.Trim()),
                    new SqlParameter("@LoaiMayBay", txtLoaiMayBay.Text.Trim()));

                MessageBox.Show("Cập nhật máy bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (maMayBay == 0)
            {
                MessageBox.Show("Vui lòng chọn máy bay cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa máy bay " + txtSoHieu.Text + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            try
            {
                KetNoiCSDL.ThucThi("sp_MayBay_Xoa", new SqlParameter("@MaMayBay", maMayBay));
                MessageBox.Show("Xóa máy bay thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
