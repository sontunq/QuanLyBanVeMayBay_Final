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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleTieuDe1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleDongLe1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleO1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblVeChon = new System.Windows.Forms.Label();
            this.lblLyDoHuy = new System.Windows.Forms.Label();
            this.txtLyDoHuy = new System.Windows.Forms.TextBox();
            this.lblPhiHuy = new System.Windows.Forms.Label();
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
            this.colPhiHuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienHoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDoHuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(160)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(468, 81);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnLamMoi.UseVisualStyleBackColor = false;
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
            // lblLyDoHuy
            //
            this.lblLyDoHuy.AutoSize = true;
            this.lblLyDoHuy.Location = new System.Drawing.Point(20, 163);
            this.lblLyDoHuy.Name = "lblLyDoHuy";
            this.lblLyDoHuy.Size = new System.Drawing.Size(65, 15);
            this.lblLyDoHuy.TabIndex = 11;
            this.lblLyDoHuy.Text = "Lý do hủy:";
            //
            // txtLyDoHuy
            //
            this.txtLyDoHuy.Location = new System.Drawing.Point(100, 160);
            this.txtLyDoHuy.MaxLength = 200;
            this.txtLyDoHuy.Name = "txtLyDoHuy";
            this.txtLyDoHuy.Size = new System.Drawing.Size(468, 23);
            this.txtLyDoHuy.TabIndex = 12;
            //
            // lblPhiHuy
            //
            this.lblPhiHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhiHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblPhiHuy.Location = new System.Drawing.Point(590, 163);
            this.lblPhiHuy.Name = "lblPhiHuy";
            this.lblPhiHuy.Size = new System.Drawing.Size(690, 40);
            this.lblPhiHuy.TabIndex = 13;
            this.lblPhiHuy.Text = "Phí hủy: -";
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.Location = new System.Drawing.Point(20, 200);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(120, 34);
            this.btnHuyVe.TabIndex = 6;
            this.btnHuyVe.Text = "Hủy vé";
            this.btnHuyVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHuyVe.FlatAppearance.BorderSize = 0;
            this.btnHuyVe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnHuyVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyVe.ForeColor = System.Drawing.Color.White;
            this.btnHuyVe.UseVisualStyleBackColor = false;
            this.btnHuyVe.Click += new System.EventHandler(this.btnHuyVe_Click);
            // 
            // btnInVe
            // 
            this.btnInVe.Location = new System.Drawing.Point(148, 200);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.Size = new System.Drawing.Size(100, 34);
            this.btnInVe.TabIndex = 7;
            this.btnInVe.Text = "In vé";
            this.btnInVe.BackColor = System.Drawing.Color.White;
            this.btnInVe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.btnInVe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnInVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnInVe.UseVisualStyleBackColor = false;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(256, 200);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 34);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.btnDong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(18, 250);
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
            dataGridViewCellStyleDongLe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.dgvVe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyleDongLe1;
            this.dgvVe.BackgroundColor = System.Drawing.Color.White;
            this.dgvVe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvVe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyleTieuDe1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleTieuDe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyleTieuDe1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyleTieuDe1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleTieuDe1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            dataGridViewCellStyleTieuDe1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyleTieuDe1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleTieuDe1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleTieuDe1;
            dataGridViewCellStyleO1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyleO1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleO1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleO1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            dataGridViewCellStyleO1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleO1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVe.DefaultCellStyle = dataGridViewCellStyleO1;
            this.dgvVe.EnableHeadersVisualStyles = false;
            this.dgvVe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.dgvVe.RowHeadersVisible = false;
            this.dgvVe.RowTemplate.Height = 26;
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
            this.colTrangThai,
            this.colPhiHuy,
            this.colTienHoan,
            this.colLyDoHuy});
            this.dgvVe.Location = new System.Drawing.Point(20, 280);
            this.dgvVe.MultiSelect = false;
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.ReadOnly = true;
            this.dgvVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVe.Size = new System.Drawing.Size(1260, 300);
            this.dgvVe.TabIndex = 10;
            this.dgvVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVe_CellClick);
            // 
            // colMaVe
            // 
            this.colMaVe.DataPropertyName = "MaVe";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaVe.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMaVe.FillWeight = 40F;
            this.colMaVe.HeaderText = "Mã vé";
            this.colMaVe.Name = "colMaVe";
            this.colMaVe.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 125F;
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colCCCD
            // 
            this.colCCCD.DataPropertyName = "CCCD";
            this.colCCCD.FillWeight = 95F;
            this.colCCCD.HeaderText = "CCCD";
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.ReadOnly = true;
            // 
            // colMaChuyenBay
            // 
            this.colMaChuyenBay.DataPropertyName = "MaChuyenBay";
            this.colMaChuyenBay.FillWeight = 60F;
            this.colMaChuyenBay.HeaderText = "Chuyến bay";
            this.colMaChuyenBay.Name = "colMaChuyenBay";
            this.colMaChuyenBay.ReadOnly = true;
            // 
            // colChangBay
            // 
            this.colChangBay.DataPropertyName = "ChangBay";
            this.colChangBay.FillWeight = 290F;
            this.colChangBay.HeaderText = "Chặng bay";
            this.colChangBay.Name = "colChangBay";
            this.colChangBay.ReadOnly = true;
            // 
            // colNgayGioBay
            // 
            this.colNgayGioBay.DataPropertyName = "NgayGioBay";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
            this.colNgayGioBay.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNgayGioBay.FillWeight = 110F;
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
            this.colHangVe.FillWeight = 80F;
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
            this.colGiaVe.FillWeight = 80F;
            this.colGiaVe.HeaderText = "Giá vé";
            this.colGiaVe.Name = "colGiaVe";
            this.colGiaVe.ReadOnly = true;
            // 
            // colNgayDat
            // 
            this.colNgayDat.DataPropertyName = "NgayDat";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy HH:mm";
            this.colNgayDat.DefaultCellStyle = dataGridViewCellStyle5;
            this.colNgayDat.FillWeight = 110F;
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
            // colPhiHuy
            //
            this.colPhiHuy.DataPropertyName = "PhiHuy";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.colPhiHuy.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPhiHuy.FillWeight = 75F;
            this.colPhiHuy.HeaderText = "Phí hủy";
            this.colPhiHuy.Name = "colPhiHuy";
            this.colPhiHuy.ReadOnly = true;
            //
            // colTienHoan
            //
            this.colTienHoan.DataPropertyName = "TienHoan";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.colTienHoan.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTienHoan.FillWeight = 75F;
            this.colTienHoan.HeaderText = "Tiền hoàn";
            this.colTienHoan.Name = "colTienHoan";
            this.colTienHoan.ReadOnly = true;
            //
            // colLyDoHuy
            //
            this.colLyDoHuy.DataPropertyName = "LyDoHuy";
            this.colLyDoHuy.HeaderText = "LyDoHuy";
            this.colLyDoHuy.Name = "colLyDoHuy";
            this.colLyDoHuy.ReadOnly = true;
            this.colLyDoHuy.Visible = false;
            // 
            // frmHuyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.MinimumSize = new System.Drawing.Size(1316, 639);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnInVe);
            this.Controls.Add(this.btnHuyVe);
            this.Controls.Add(this.lblPhiHuy);
            this.Controls.Add(this.txtLyDoHuy);
            this.Controls.Add(this.lblLyDoHuy);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label lblLyDoHuy;
        private System.Windows.Forms.TextBox txtLyDoHuy;
        private System.Windows.Forms.Label lblPhiHuy;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhiHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienHoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDoHuy;
    }
}
