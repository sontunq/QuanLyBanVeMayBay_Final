namespace QLBanVeMayBay.Forms
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.rdoTheoThang = new System.Windows.Forms.RadioButton();
            this.rdoTheoChuyen = new System.Windows.Forms.RadioButton();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.lblTieuDeTongVe = new System.Windows.Forms.Label();
            this.lblTongVe = new System.Windows.Forms.Label();
            this.lblTieuDeDoanhThu = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.dgvTheoThang = new System.Windows.Forms.DataGridView();
            this.colThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTheoChuyen = new System.Windows.Forms.DataGridView();
            this.colMaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChangBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGioBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoVeChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThuChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheoThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheoChuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblTieuDe.Location = new System.Drawing.Point(18, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(133, 20);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THỐNG KÊ DOANH THU";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(20, 50);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(407, 15);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Chỉ tính các vé đang có hiệu lực (không tính vé đã hủy).";
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(20, 88);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(32, 15);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Năm:";
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(70, 85);
            this.nudNam.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(90, 23);
            this.nudNam.TabIndex = 3;
            this.nudNam.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // rdoTheoThang
            // 
            this.rdoTheoThang.AutoSize = true;
            this.rdoTheoThang.Checked = true;
            this.rdoTheoThang.Location = new System.Drawing.Point(190, 86);
            this.rdoTheoThang.Name = "rdoTheoThang";
            this.rdoTheoThang.Size = new System.Drawing.Size(95, 19);
            this.rdoTheoThang.TabIndex = 4;
            this.rdoTheoThang.TabStop = true;
            this.rdoTheoThang.Text = "Theo tháng";
            this.rdoTheoThang.UseVisualStyleBackColor = true;
            this.rdoTheoThang.CheckedChanged += new System.EventHandler(this.rdoTheoThang_CheckedChanged);
            // 
            // rdoTheoChuyen
            // 
            this.rdoTheoChuyen.AutoSize = true;
            this.rdoTheoChuyen.Location = new System.Drawing.Point(300, 86);
            this.rdoTheoChuyen.Name = "rdoTheoChuyen";
            this.rdoTheoChuyen.Size = new System.Drawing.Size(132, 19);
            this.rdoTheoChuyen.TabIndex = 5;
            this.rdoTheoChuyen.Text = "Theo chuyến bay";
            this.rdoTheoChuyen.UseVisualStyleBackColor = true;
            this.rdoTheoChuyen.CheckedChanged += new System.EventHandler(this.rdoTheoChuyen_CheckedChanged);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(450, 81);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 30);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(558, 81);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(110, 30);
            this.btnInBaoCao.TabIndex = 7;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // lblTieuDeTongVe
            // 
            this.lblTieuDeTongVe.AutoSize = true;
            this.lblTieuDeTongVe.Location = new System.Drawing.Point(20, 135);
            this.lblTieuDeTongVe.Name = "lblTieuDeTongVe";
            this.lblTieuDeTongVe.Size = new System.Drawing.Size(83, 15);
            this.lblTieuDeTongVe.TabIndex = 8;
            this.lblTieuDeTongVe.Text = "Tổng số vé:";
            // 
            // lblTongVe
            // 
            this.lblTongVe.AutoSize = true;
            this.lblTongVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblTongVe.Location = new System.Drawing.Point(110, 132);
            this.lblTongVe.Name = "lblTongVe";
            this.lblTongVe.Size = new System.Drawing.Size(30, 20);
            this.lblTongVe.TabIndex = 9;
            this.lblTongVe.Text = "0";
            // 
            // lblTieuDeDoanhThu
            // 
            this.lblTieuDeDoanhThu.AutoSize = true;
            this.lblTieuDeDoanhThu.Location = new System.Drawing.Point(250, 135);
            this.lblTieuDeDoanhThu.Name = "lblTieuDeDoanhThu";
            this.lblTieuDeDoanhThu.Size = new System.Drawing.Size(112, 15);
            this.lblTieuDeDoanhThu.TabIndex = 10;
            this.lblTieuDeDoanhThu.Text = "Tổng doanh thu:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(360, 130);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(30, 20);
            this.lblTongDoanhThu.TabIndex = 11;
            this.lblTongDoanhThu.Text = "0 đ";
            // 
            // dgvTheoThang
            // 
            this.dgvTheoThang.AllowUserToAddRows = false;
            this.dgvTheoThang.AllowUserToDeleteRows = false;
            this.dgvTheoThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTheoThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheoThang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTheoThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheoThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThang,
            this.colSoVe,
            this.colDoanhThu});
            this.dgvTheoThang.Location = new System.Drawing.Point(20, 175);
            this.dgvTheoThang.MultiSelect = false;
            this.dgvTheoThang.Name = "dgvTheoThang";
            this.dgvTheoThang.ReadOnly = true;
            this.dgvTheoThang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheoThang.Size = new System.Drawing.Size(860, 385);
            this.dgvTheoThang.TabIndex = 12;
            // 
            // colThang
            // 
            this.colThang.DataPropertyName = "Thang";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colThang.DefaultCellStyle = dataGridViewCellStyle1;
            this.colThang.FillWeight = 60F;
            this.colThang.HeaderText = "Tháng";
            this.colThang.Name = "colThang";
            this.colThang.ReadOnly = true;
            // 
            // colSoVe
            // 
            this.colSoVe.DataPropertyName = "SoVe";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoVe.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSoVe.FillWeight = 80F;
            this.colSoVe.HeaderText = "Số vé bán";
            this.colSoVe.Name = "colSoVe";
            this.colSoVe.ReadOnly = true;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.DataPropertyName = "DoanhThu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.colDoanhThu.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDoanhThu.FillWeight = 120F;
            this.colDoanhThu.HeaderText = "Doanh thu (VNĐ)";
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.ReadOnly = true;
            // 
            // dgvTheoChuyen
            // 
            this.dgvTheoChuyen.AllowUserToAddRows = false;
            this.dgvTheoChuyen.AllowUserToDeleteRows = false;
            this.dgvTheoChuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTheoChuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheoChuyen.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTheoChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheoChuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChuyenBay,
            this.colChangBay,
            this.colNgayGioBay,
            this.colSoVeChuyen,
            this.colDoanhThuChuyen});
            this.dgvTheoChuyen.Location = new System.Drawing.Point(20, 175);
            this.dgvTheoChuyen.MultiSelect = false;
            this.dgvTheoChuyen.Name = "dgvTheoChuyen";
            this.dgvTheoChuyen.ReadOnly = true;
            this.dgvTheoChuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheoChuyen.Size = new System.Drawing.Size(860, 385);
            this.dgvTheoChuyen.TabIndex = 13;
            this.dgvTheoChuyen.Visible = false;
            // 
            // colMaChuyenBay
            // 
            this.colMaChuyenBay.DataPropertyName = "MaChuyenBay";
            this.colMaChuyenBay.FillWeight = 70F;
            this.colMaChuyenBay.HeaderText = "Chuyến bay";
            this.colMaChuyenBay.Name = "colMaChuyenBay";
            this.colMaChuyenBay.ReadOnly = true;
            // 
            // colChangBay
            // 
            this.colChangBay.DataPropertyName = "ChangBay";
            this.colChangBay.FillWeight = 80F;
            this.colChangBay.HeaderText = "Chặng bay";
            this.colChangBay.Name = "colChangBay";
            this.colChangBay.ReadOnly = true;
            // 
            // colNgayGioBay
            // 
            this.colNgayGioBay.DataPropertyName = "NgayGioBay";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy HH:mm";
            this.colNgayGioBay.DefaultCellStyle = dataGridViewCellStyle4;
            this.colNgayGioBay.HeaderText = "Ngày giờ bay";
            this.colNgayGioBay.Name = "colNgayGioBay";
            this.colNgayGioBay.ReadOnly = true;
            // 
            // colSoVeChuyen
            // 
            this.colSoVeChuyen.DataPropertyName = "SoVe";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoVeChuyen.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSoVeChuyen.FillWeight = 70F;
            this.colSoVeChuyen.HeaderText = "Số vé bán";
            this.colSoVeChuyen.Name = "colSoVeChuyen";
            this.colSoVeChuyen.ReadOnly = true;
            // 
            // colDoanhThuChuyen
            // 
            this.colDoanhThuChuyen.DataPropertyName = "DoanhThu";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.colDoanhThuChuyen.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDoanhThuChuyen.FillWeight = 110F;
            this.colDoanhThuChuyen.HeaderText = "Doanh thu (VNĐ)";
            this.colDoanhThuChuyen.Name = "colDoanhThuChuyen";
            this.colDoanhThuChuyen.ReadOnly = true;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.dgvTheoChuyen);
            this.Controls.Add(this.dgvTheoThang);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.lblTieuDeDoanhThu);
            this.Controls.Add(this.lblTongVe);
            this.Controls.Add(this.lblTieuDeTongVe);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.rdoTheoChuyen);
            this.Controls.Add(this.rdoTheoThang);
            this.Controls.Add(this.nudNam);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmThongKe";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheoThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheoChuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.RadioButton rdoTheoThang;
        private System.Windows.Forms.RadioButton rdoTheoChuyen;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Label lblTieuDeTongVe;
        private System.Windows.Forms.Label lblTongVe;
        private System.Windows.Forms.Label lblTieuDeDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.DataGridView dgvTheoThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
        private System.Windows.Forms.DataGridView dgvTheoChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChangBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGioBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoVeChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThuChuyen;
    }
}
