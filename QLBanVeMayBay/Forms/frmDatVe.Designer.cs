namespace QLBanVeMayBay.Forms
{
    partial class frmDatVe
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblChuyenBay = new System.Windows.Forms.Label();
            this.cboChuyenBay = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.lblHangVe = new System.Windows.Forms.Label();
            this.cboHangVe = new System.Windows.Forms.ComboBox();
            this.lblGhe = new System.Windows.Forms.Label();
            this.cboGhe = new System.Windows.Forms.ComboBox();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.cboPhuongThuc = new System.Windows.Forms.ComboBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.lblTieuDeGia = new System.Windows.Forms.Label();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.lblConTrong = new System.Windows.Forms.Label();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnInVe = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvHanhKhach = new System.Windows.Forms.DataGridView();
            this.colMaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHangVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblTieuDe.Location = new System.Drawing.Point(18, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(104, 20);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "ĐẶT VÉ MÁY BAY";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(20, 50);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(392, 15);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Chọn chuyến bay, hành khách, hạng vé và ghế còn trống.";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(18, 80);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(119, 20);
            this.lblThongTin.TabIndex = 2;
            this.lblThongTin.Text = "THÔNG TIN ĐẶT VÉ";
            // 
            // lblChuyenBay
            // 
            this.lblChuyenBay.AutoSize = true;
            this.lblChuyenBay.Location = new System.Drawing.Point(20, 118);
            this.lblChuyenBay.Name = "lblChuyenBay";
            this.lblChuyenBay.Size = new System.Drawing.Size(83, 15);
            this.lblChuyenBay.TabIndex = 3;
            this.lblChuyenBay.Text = "Chuyến bay:";
            // 
            // cboChuyenBay
            // 
            this.cboChuyenBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenBay.FormattingEnabled = true;
            this.cboChuyenBay.Location = new System.Drawing.Point(130, 115);
            this.cboChuyenBay.Name = "cboChuyenBay";
            this.cboChuyenBay.Size = new System.Drawing.Size(330, 23);
            this.cboChuyenBay.TabIndex = 4;
            this.cboChuyenBay.SelectedIndexChanged += new System.EventHandler(this.cboChuyenBay_SelectedIndexChanged);
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(20, 153);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(83, 15);
            this.lblKhachHang.TabIndex = 5;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(130, 150);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(290, 23);
            this.cboKhachHang.TabIndex = 6;
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(425, 149);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(35, 25);
            this.btnThemKhach.TabIndex = 7;
            this.btnThemKhach.Text = "+";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // lblHangVe
            // 
            this.lblHangVe.AutoSize = true;
            this.lblHangVe.Location = new System.Drawing.Point(20, 188);
            this.lblHangVe.Name = "lblHangVe";
            this.lblHangVe.Size = new System.Drawing.Size(61, 15);
            this.lblHangVe.TabIndex = 8;
            this.lblHangVe.Text = "Hạng vé:";
            // 
            // cboHangVe
            // 
            this.cboHangVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHangVe.FormattingEnabled = true;
            this.cboHangVe.Items.AddRange(new object[] {
            "Phổ thông",
            "Thương gia"});
            this.cboHangVe.Location = new System.Drawing.Point(130, 185);
            this.cboHangVe.Name = "cboHangVe";
            this.cboHangVe.Size = new System.Drawing.Size(150, 23);
            this.cboHangVe.TabIndex = 9;
            this.cboHangVe.SelectedIndexChanged += new System.EventHandler(this.cboHangVe_SelectedIndexChanged);
            // 
            // lblGhe
            // 
            this.lblGhe.AutoSize = true;
            this.lblGhe.Location = new System.Drawing.Point(300, 188);
            this.lblGhe.Name = "lblGhe";
            this.lblGhe.Size = new System.Drawing.Size(32, 15);
            this.lblGhe.TabIndex = 10;
            this.lblGhe.Text = "Ghế:";
            // 
            // cboGhe
            // 
            this.cboGhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGhe.FormattingEnabled = true;
            this.cboGhe.Location = new System.Drawing.Point(345, 185);
            this.cboGhe.Name = "cboGhe";
            this.cboGhe.Size = new System.Drawing.Size(115, 23);
            this.cboGhe.TabIndex = 11;
            // 
            // lblPhuongThuc
            // 
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Location = new System.Drawing.Point(20, 223);
            this.lblPhuongThuc.Name = "lblPhuongThuc";
            this.lblPhuongThuc.Size = new System.Drawing.Size(83, 15);
            this.lblPhuongThuc.TabIndex = 12;
            this.lblPhuongThuc.Text = "Thanh toán:";
            // 
            // cboPhuongThuc
            // 
            this.cboPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongThuc.FormattingEnabled = true;
            this.cboPhuongThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ"});
            this.cboPhuongThuc.Location = new System.Drawing.Point(130, 220);
            this.cboPhuongThuc.Name = "cboPhuongThuc";
            this.cboPhuongThuc.Size = new System.Drawing.Size(150, 23);
            this.cboPhuongThuc.TabIndex = 13;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.Location = new System.Drawing.Point(520, 80);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(76, 20);
            this.lblThanhToan.TabIndex = 14;
            this.lblThanhToan.Text = "THANH TOÁN";
            // 
            // lblTieuDeGia
            // 
            this.lblTieuDeGia.AutoSize = true;
            this.lblTieuDeGia.Location = new System.Drawing.Point(522, 123);
            this.lblTieuDeGia.Name = "lblTieuDeGia";
            this.lblTieuDeGia.Size = new System.Drawing.Size(54, 15);
            this.lblTieuDeGia.TabIndex = 15;
            this.lblTieuDeGia.Text = "Giá vé:";
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.AutoSize = true;
            this.lblGiaVe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaVe.ForeColor = System.Drawing.Color.Red;
            this.lblGiaVe.Location = new System.Drawing.Point(590, 113);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(30, 20);
            this.lblGiaVe.TabIndex = 16;
            this.lblGiaVe.Text = "0 đ";
            // 
            // lblConTrong
            // 
            this.lblConTrong.AutoSize = true;
            this.lblConTrong.ForeColor = System.Drawing.Color.DimGray;
            this.lblConTrong.Location = new System.Drawing.Point(522, 163);
            this.lblConTrong.Name = "lblConTrong";
            this.lblConTrong.Size = new System.Drawing.Size(126, 15);
            this.lblConTrong.TabIndex = 17;
            this.lblConTrong.Text = "Số ghế còn trống:";
            // 
            // btnDatVe
            // 
            this.btnDatVe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.Location = new System.Drawing.Point(20, 265);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(140, 40);
            this.btnDatVe.TabIndex = 18;
            this.btnDatVe.Text = "ĐẶT VÉ";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnInVe
            // 
            this.btnInVe.Enabled = false;
            this.btnInVe.Location = new System.Drawing.Point(170, 265);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.Size = new System.Drawing.Size(100, 40);
            this.btnInVe.TabIndex = 19;
            this.btnInVe.Text = "In vé";
            this.btnInVe.UseVisualStyleBackColor = true;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(280, 265);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 20;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(390, 265);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 40);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(18, 325);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(212, 20);
            this.lblDanhSach.TabIndex = 22;
            this.lblDanhSach.Text = "HÀNH KHÁCH ĐÃ ĐẶT TRÊN CHUYẾN";
            // 
            // dgvHanhKhach
            // 
            this.dgvHanhKhach.AllowUserToAddRows = false;
            this.dgvHanhKhach.AllowUserToDeleteRows = false;
            this.dgvHanhKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHanhKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHanhKhach.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHanhKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaVe,
            this.colHoTen,
            this.colCCCD,
            this.colSoDienThoai,
            this.colSoGhe,
            this.colHangVe,
            this.colGiaVe});
            this.dgvHanhKhach.Location = new System.Drawing.Point(20, 355);
            this.dgvHanhKhach.MultiSelect = false;
            this.dgvHanhKhach.Name = "dgvHanhKhach";
            this.dgvHanhKhach.ReadOnly = true;
            this.dgvHanhKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHanhKhach.Size = new System.Drawing.Size(960, 265);
            this.dgvHanhKhach.TabIndex = 23;
            // 
            // colMaVe
            // 
            this.colMaVe.DataPropertyName = "MaVe";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaVe.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMaVe.FillWeight = 50F;
            this.colMaVe.HeaderText = "Mã vé";
            this.colMaVe.Name = "colMaVe";
            this.colMaVe.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 140F;
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
            // colSoDienThoai
            // 
            this.colSoDienThoai.DataPropertyName = "SoDienThoai";
            this.colSoDienThoai.FillWeight = 85F;
            this.colSoDienThoai.HeaderText = "Điện thoại";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            // 
            // colSoGhe
            // 
            this.colSoGhe.DataPropertyName = "SoGhe";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSoGhe.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSoGhe.FillWeight = 45F;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.colGiaVe.DefaultCellStyle = dataGridViewCellStyle3;
            this.colGiaVe.FillWeight = 80F;
            this.colGiaVe.HeaderText = "Giá vé";
            this.colGiaVe.Name = "colGiaVe";
            this.colGiaVe.ReadOnly = true;
            // 
            // frmDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.dgvHanhKhach);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnInVe);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.lblConTrong);
            this.Controls.Add(this.lblGiaVe);
            this.Controls.Add(this.lblTieuDeGia);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.cboPhuongThuc);
            this.Controls.Add(this.lblPhuongThuc);
            this.Controls.Add(this.cboGhe);
            this.Controls.Add(this.lblGhe);
            this.Controls.Add(this.cboHangVe);
            this.Controls.Add(this.lblHangVe);
            this.Controls.Add(this.btnThemKhach);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.cboChuyenBay);
            this.Controls.Add(this.lblChuyenBay);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmDatVe";
            this.Text = "Đặt vé";
            this.Load += new System.EventHandler(this.frmDatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblChuyenBay;
        private System.Windows.Forms.ComboBox cboChuyenBay;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.Label lblHangVe;
        private System.Windows.Forms.ComboBox cboHangVe;
        private System.Windows.Forms.Label lblGhe;
        private System.Windows.Forms.ComboBox cboGhe;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Label lblTieuDeGia;
        private System.Windows.Forms.Label lblGiaVe;
        private System.Windows.Forms.Label lblConTrong;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnInVe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvHanhKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaVe;
    }
}
