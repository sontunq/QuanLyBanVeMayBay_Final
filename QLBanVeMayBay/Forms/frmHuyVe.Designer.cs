namespace QLBanVeMayBay.Forms
{
    partial class frmHuyVe
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblVeChon = new System.Windows.Forms.Label();
            this.btnHuyVe = new System.Windows.Forms.Button();
            this.btnInVe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.colMaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChangBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGioBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHangVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblTieuDe.Location = new System.Drawing.Point(18, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(119, 20);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "TRA CỨU - HỦY VÉ";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(20, 50);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(349, 15);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Tìm theo mã vé, họ tên, CCCD hoặc mã chuyến bay.";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(20, 85);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(330, 23);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(360, 81);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(468, 81);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblVeChon
            // 
            this.lblVeChon.AutoSize = true;
            this.lblVeChon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeChon.Location = new System.Drawing.Point(20, 130);
            this.lblVeChon.Name = "lblVeChon";
            this.lblVeChon.Size = new System.Drawing.Size(97, 20);
            this.lblVeChon.TabIndex = 5;
            this.lblVeChon.Text = "Chưa chọn vé.";
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.Location = new System.Drawing.Point(20, 160);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(120, 34);
            this.btnHuyVe.TabIndex = 6;
            this.btnHuyVe.Text = "Hủy vé";
            this.btnHuyVe.UseVisualStyleBackColor = true;
            this.btnHuyVe.Click += new System.EventHandler(this.btnHuyVe_Click);
            // 
            // btnInVe
            // 
            this.btnInVe.Location = new System.Drawing.Point(148, 160);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.Size = new System.Drawing.Size(100, 34);
            this.btnInVe.TabIndex = 7;
            this.btnInVe.Text = "In vé";
            this.btnInVe.UseVisualStyleBackColor = true;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(256, 160);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 34);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(18, 215);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(90, 20);
            this.lblDanhSach.TabIndex = 9;
            this.lblDanhSach.Text = "DANH SÁCH VÉ";
            // 
            // dgvVe
            // 
            this.dgvVe.AllowUserToAddRows = false;
            this.dgvVe.AllowUserToDeleteRows = false;
            this.dgvVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaVe,
            this.colHoTen,
            this.colCCCD,
            this.colMaChuyenBay,
            this.colChangBay,
            this.colNgayGioBay,
            this.colSoGhe,
            this.colHangVe,
            this.colGiaVe,
            this.colNgayDat,
            this.colTrangThai});
            this.dgvVe.Location = new System.Drawing.Point(20, 245);
            this.dgvVe.MultiSelect = false;
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.ReadOnly = true;
            this.dgvVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVe.Size = new System.Drawing.Size(1060, 335);
            this.dgvVe.TabIndex = 10;
            this.dgvVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVe_CellClick);
            // 
            // colMaVe
            // 
            this.colMaVe.DataPropertyName = "MaVe";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaVe.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMaVe.FillWeight = 45F;
            this.colMaVe.HeaderText = "Mã vé";
            this.colMaVe.Name = "colMaVe";
            this.colMaVe.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 130F;
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colCCCD
            // 
            this.colCCCD.DataPropertyName = "CCCD";
            this.colCCCD.FillWeight = 90F;
            this.colCCCD.HeaderText = "CCCD";
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.ReadOnly = true;
            // 
            // colMaChuyenBay
            // 
            this.colMaChuyenBay.DataPropertyName = "MaChuyenBay";
            this.colMaChuyenBay.FillWeight = 65F;
            this.colMaChuyenBay.HeaderText = "Chuyến bay";
            this.colMaChuyenBay.Name = "colMaChuyenBay";
            this.colMaChuyenBay.ReadOnly = true;
            // 
            // colChangBay
            // 
            this.colChangBay.DataPropertyName = "ChangBay";
            this.colChangBay.FillWeight = 70F;
            this.colChangBay.HeaderText = "Chặng bay";
            this.colChangBay.Name = "colChangBay";
            this.colChangBay.ReadOnly = true;
            // 
            // colNgayGioBay
            // 
            this.colNgayGioBay.DataPropertyName = "NgayGioBay";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
            this.colNgayGioBay.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNgayGioBay.HeaderText = "Ngày giờ bay";
            this.colNgayGioBay.Name = "colNgayGioBay";
            this.colNgayGioBay.ReadOnly = true;
            // 
            // colSoGhe
            // 
            this.colSoGhe.DataPropertyName = "SoGhe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoGhe.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSoGhe.FillWeight = 40F;
            this.colSoGhe.HeaderText = "Ghế";
            this.colSoGhe.Name = "colSoGhe";
            this.colSoGhe.ReadOnly = true;
            // 
            // colHangVe
            // 
            this.colHangVe.DataPropertyName = "HangVe";
            this.colHangVe.FillWeight = 70F;
            this.colHangVe.HeaderText = "Hạng vé";
            this.colHangVe.Name = "colHangVe";
            this.colHangVe.ReadOnly = true;
            // 
            // colGiaVe
            // 
            this.colGiaVe.DataPropertyName = "GiaVe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.colGiaVe.DefaultCellStyle = dataGridViewCellStyle4;
            this.colGiaVe.FillWeight = 75F;
            this.colGiaVe.HeaderText = "Giá vé";
            this.colGiaVe.Name = "colGiaVe";
            this.colGiaVe.ReadOnly = true;
            // 
            // colNgayDat
            // 
            this.colNgayDat.DataPropertyName = "NgayDat";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy HH:mm";
            this.colNgayDat.DefaultCellStyle = dataGridViewCellStyle5;
            this.colNgayDat.HeaderText = "Ngày đặt";
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.FillWeight = 65F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // frmHuyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnInVe);
            this.Controls.Add(this.btnHuyVe);
            this.Controls.Add(this.lblVeChon);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmHuyVe";
            this.Text = "Tra cứu - Hủy vé";
            this.Load += new System.EventHandler(this.frmHuyVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblVeChon;
        private System.Windows.Forms.Button btnHuyVe;
        private System.Windows.Forms.Button btnInVe;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChangBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGioBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
