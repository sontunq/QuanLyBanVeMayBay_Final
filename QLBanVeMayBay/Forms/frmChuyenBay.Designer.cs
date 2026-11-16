namespace QLBanVeMayBay.Forms
{
    partial class frmChuyenBay
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
            this.lblMaChuyenBay = new System.Windows.Forms.Label();
            this.txtMaChuyenBay = new System.Windows.Forms.TextBox();
            this.lblMayBay = new System.Windows.Forms.Label();
            this.cboMayBay = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblSanBayDi = new System.Windows.Forms.Label();
            this.cboSanBayDi = new System.Windows.Forms.ComboBox();
            this.lblSanBayDen = new System.Windows.Forms.Label();
            this.cboSanBayDen = new System.Windows.Forms.ComboBox();
            this.lblNgayGioBay = new System.Windows.Forms.Label();
            this.dtpNgayGioBay = new System.Windows.Forms.DateTimePicker();
            this.lblGiaPhoThong = new System.Windows.Forms.Label();
            this.nudGiaPhoThong = new System.Windows.Forms.NumericUpDown();
            this.lblGiaThuongGia = new System.Windows.Forms.Label();
            this.nudGiaThuongGia = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnInDanhSach = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvChuyenBay = new System.Windows.Forms.DataGridView();
            this.colMaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMayBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGioBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaPhoThong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaThuongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoVeDaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaPhoThong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaThuongGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenBay)).BeginInit();
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
            this.lblTieuDe.Text = "QUẢN LÝ CHUYẾN BAY";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(20, 50);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(464, 15);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Thêm, sửa, xóa chuyến bay và in danh sách hành khách của chuyến.";
            // 
            // lblMaChuyenBay
            // 
            this.lblMaChuyenBay.AutoSize = true;
            this.lblMaChuyenBay.Location = new System.Drawing.Point(20, 88);
            this.lblMaChuyenBay.Name = "lblMaChuyenBay";
            this.lblMaChuyenBay.Size = new System.Drawing.Size(104, 15);
            this.lblMaChuyenBay.TabIndex = 2;
            this.lblMaChuyenBay.Text = "Mã chuyến bay:";
            // 
            // txtMaChuyenBay
            // 
            this.txtMaChuyenBay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaChuyenBay.Location = new System.Drawing.Point(130, 85);
            this.txtMaChuyenBay.MaxLength = 10;
            this.txtMaChuyenBay.Name = "txtMaChuyenBay";
            this.txtMaChuyenBay.Size = new System.Drawing.Size(190, 23);
            this.txtMaChuyenBay.TabIndex = 3;
            // 
            // lblMayBay
            // 
            this.lblMayBay.AutoSize = true;
            this.lblMayBay.Location = new System.Drawing.Point(350, 88);
            this.lblMayBay.Name = "lblMayBay";
            this.lblMayBay.Size = new System.Drawing.Size(61, 15);
            this.lblMayBay.TabIndex = 4;
            this.lblMayBay.Text = "Máy bay:";
            // 
            // cboMayBay
            // 
            this.cboMayBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMayBay.FormattingEnabled = true;
            this.cboMayBay.Location = new System.Drawing.Point(450, 85);
            this.cboMayBay.Name = "cboMayBay";
            this.cboMayBay.Size = new System.Drawing.Size(190, 23);
            this.cboMayBay.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(670, 88);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(83, 15);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Mở bán",
            "Đã đóng",
            "Đã bay",
            "Đã hủy"});
            this.cboTrangThai.Location = new System.Drawing.Point(770, 85);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(200, 23);
            this.cboTrangThai.TabIndex = 7;
            // 
            // lblSanBayDi
            // 
            this.lblSanBayDi.AutoSize = true;
            this.lblSanBayDi.Location = new System.Drawing.Point(20, 123);
            this.lblSanBayDi.Name = "lblSanBayDi";
            this.lblSanBayDi.Size = new System.Drawing.Size(83, 15);
            this.lblSanBayDi.TabIndex = 8;
            this.lblSanBayDi.Text = "Sân bay đi:";
            // 
            // cboSanBayDi
            // 
            this.cboSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanBayDi.FormattingEnabled = true;
            this.cboSanBayDi.Location = new System.Drawing.Point(130, 120);
            this.cboSanBayDi.Name = "cboSanBayDi";
            this.cboSanBayDi.Size = new System.Drawing.Size(190, 23);
            this.cboSanBayDi.TabIndex = 9;
            // 
            // lblSanBayDen
            // 
            this.lblSanBayDen.AutoSize = true;
            this.lblSanBayDen.Location = new System.Drawing.Point(350, 123);
            this.lblSanBayDen.Name = "lblSanBayDen";
            this.lblSanBayDen.Size = new System.Drawing.Size(90, 15);
            this.lblSanBayDen.TabIndex = 10;
            this.lblSanBayDen.Text = "Sân bay đến:";
            // 
            // cboSanBayDen
            // 
            this.cboSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanBayDen.FormattingEnabled = true;
            this.cboSanBayDen.Location = new System.Drawing.Point(450, 120);
            this.cboSanBayDen.Name = "cboSanBayDen";
            this.cboSanBayDen.Size = new System.Drawing.Size(190, 23);
            this.cboSanBayDen.TabIndex = 11;
            // 
            // lblNgayGioBay
            // 
            this.lblNgayGioBay.AutoSize = true;
            this.lblNgayGioBay.Location = new System.Drawing.Point(670, 123);
            this.lblNgayGioBay.Name = "lblNgayGioBay";
            this.lblNgayGioBay.Size = new System.Drawing.Size(97, 15);
            this.lblNgayGioBay.TabIndex = 12;
            this.lblNgayGioBay.Text = "Ngày giờ bay:";
            // 
            // dtpNgayGioBay
            // 
            this.dtpNgayGioBay.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayGioBay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGioBay.Location = new System.Drawing.Point(770, 120);
            this.dtpNgayGioBay.Name = "dtpNgayGioBay";
            this.dtpNgayGioBay.Size = new System.Drawing.Size(200, 23);
            this.dtpNgayGioBay.TabIndex = 13;
            // 
            // lblGiaPhoThong
            // 
            this.lblGiaPhoThong.AutoSize = true;
            this.lblGiaPhoThong.Location = new System.Drawing.Point(20, 158);
            this.lblGiaPhoThong.Name = "lblGiaPhoThong";
            this.lblGiaPhoThong.Size = new System.Drawing.Size(104, 15);
            this.lblGiaPhoThong.TabIndex = 14;
            this.lblGiaPhoThong.Text = "Giá phổ thông:";
            // 
            // nudGiaPhoThong
            // 
            this.nudGiaPhoThong.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudGiaPhoThong.Location = new System.Drawing.Point(130, 155);
            this.nudGiaPhoThong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudGiaPhoThong.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudGiaPhoThong.Name = "nudGiaPhoThong";
            this.nudGiaPhoThong.Size = new System.Drawing.Size(190, 23);
            this.nudGiaPhoThong.TabIndex = 15;
            this.nudGiaPhoThong.ThousandsSeparator = true;
            this.nudGiaPhoThong.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // lblGiaThuongGia
            // 
            this.lblGiaThuongGia.AutoSize = true;
            this.lblGiaThuongGia.Location = new System.Drawing.Point(350, 158);
            this.lblGiaThuongGia.Name = "lblGiaThuongGia";
            this.lblGiaThuongGia.Size = new System.Drawing.Size(112, 15);
            this.lblGiaThuongGia.TabIndex = 16;
            this.lblGiaThuongGia.Text = "Giá thương gia:";
            // 
            // nudGiaThuongGia
            // 
            this.nudGiaThuongGia.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudGiaThuongGia.Location = new System.Drawing.Point(450, 155);
            this.nudGiaThuongGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudGiaThuongGia.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudGiaThuongGia.Name = "nudGiaThuongGia";
            this.nudGiaThuongGia.Size = new System.Drawing.Size(190, 23);
            this.nudGiaThuongGia.TabIndex = 17;
            this.nudGiaThuongGia.ThousandsSeparator = true;
            this.nudGiaThuongGia.Value = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(128, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(236, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(344, 200);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 21;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Location = new System.Drawing.Point(452, 200);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(110, 32);
            this.btnInDanhSach.TabIndex = 22;
            this.btnInDanhSach.Text = "In DS hành khách";
            this.btnInDanhSach.UseVisualStyleBackColor = true;
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(18, 250);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(148, 20);
            this.lblDanhSach.TabIndex = 23;
            this.lblDanhSach.Text = "DANH SÁCH CHUYẾN BAY";
            // 
            // dgvChuyenBay
            // 
            this.dgvChuyenBay.AllowUserToAddRows = false;
            this.dgvChuyenBay.AllowUserToDeleteRows = false;
            this.dgvChuyenBay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChuyenBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenBay.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaChuyenBay,
            this.colMaMayBay,
            this.colSoHieu,
            this.colSanBayDi,
            this.colSanBayDen,
            this.colNgayGioBay,
            this.colGiaPhoThong,
            this.colGiaThuongGia,
            this.colTrangThai,
            this.colSoVeDaBan});
            this.dgvChuyenBay.Location = new System.Drawing.Point(20, 280);
            this.dgvChuyenBay.MultiSelect = false;
            this.dgvChuyenBay.Name = "dgvChuyenBay";
            this.dgvChuyenBay.ReadOnly = true;
            this.dgvChuyenBay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenBay.Size = new System.Drawing.Size(960, 320);
            this.dgvChuyenBay.TabIndex = 24;
            this.dgvChuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenBay_CellClick);
            // 
            // colMaChuyenBay
            // 
            this.colMaChuyenBay.DataPropertyName = "MaChuyenBay";
            this.colMaChuyenBay.FillWeight = 70F;
            this.colMaChuyenBay.HeaderText = "Mã chuyến";
            this.colMaChuyenBay.Name = "colMaChuyenBay";
            this.colMaChuyenBay.ReadOnly = true;
            // 
            // colMaMayBay
            // 
            this.colMaMayBay.DataPropertyName = "MaMayBay";
            this.colMaMayBay.HeaderText = "MaMayBay";
            this.colMaMayBay.Name = "colMaMayBay";
            this.colMaMayBay.ReadOnly = true;
            this.colMaMayBay.Visible = false;
            // 
            // colSoHieu
            // 
            this.colSoHieu.DataPropertyName = "SoHieu";
            this.colSoHieu.FillWeight = 75F;
            this.colSoHieu.HeaderText = "Máy bay";
            this.colSoHieu.Name = "colSoHieu";
            this.colSoHieu.ReadOnly = true;
            // 
            // colSanBayDi
            // 
            this.colSanBayDi.DataPropertyName = "SanBayDi";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSanBayDi.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSanBayDi.FillWeight = 45F;
            this.colSanBayDi.HeaderText = "Đi";
            this.colSanBayDi.Name = "colSanBayDi";
            this.colSanBayDi.ReadOnly = true;
            // 
            // colSanBayDen
            // 
            this.colSanBayDen.DataPropertyName = "SanBayDen";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSanBayDen.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSanBayDen.FillWeight = 45F;
            this.colSanBayDen.HeaderText = "Đến";
            this.colSanBayDen.Name = "colSanBayDen";
            this.colSanBayDen.ReadOnly = true;
            // 
            // colNgayGioBay
            // 
            this.colNgayGioBay.DataPropertyName = "NgayGioBay";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy HH:mm";
            this.colNgayGioBay.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNgayGioBay.HeaderText = "Ngày giờ bay";
            this.colNgayGioBay.Name = "colNgayGioBay";
            this.colNgayGioBay.ReadOnly = true;
            // 
            // colGiaPhoThong
            // 
            this.colGiaPhoThong.DataPropertyName = "GiaPhoThong";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.colGiaPhoThong.DefaultCellStyle = dataGridViewCellStyle4;
            this.colGiaPhoThong.FillWeight = 85F;
            this.colGiaPhoThong.HeaderText = "Giá phổ thông";
            this.colGiaPhoThong.Name = "colGiaPhoThong";
            this.colGiaPhoThong.ReadOnly = true;
            // 
            // colGiaThuongGia
            // 
            this.colGiaThuongGia.DataPropertyName = "GiaThuongGia";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.colGiaThuongGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.colGiaThuongGia.FillWeight = 85F;
            this.colGiaThuongGia.HeaderText = "Giá thương gia";
            this.colGiaThuongGia.Name = "colGiaThuongGia";
            this.colGiaThuongGia.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.FillWeight = 70F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // colSoVeDaBan
            // 
            this.colSoVeDaBan.DataPropertyName = "SoVeDaBan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoVeDaBan.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSoVeDaBan.FillWeight = 60F;
            this.colSoVeDaBan.HeaderText = "Vé đã bán";
            this.colSoVeDaBan.Name = "colSoVeDaBan";
            this.colSoVeDaBan.ReadOnly = true;
            // 
            // frmChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.dgvChuyenBay);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnInDanhSach);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.nudGiaThuongGia);
            this.Controls.Add(this.lblGiaThuongGia);
            this.Controls.Add(this.nudGiaPhoThong);
            this.Controls.Add(this.lblGiaPhoThong);
            this.Controls.Add(this.dtpNgayGioBay);
            this.Controls.Add(this.lblNgayGioBay);
            this.Controls.Add(this.cboSanBayDen);
            this.Controls.Add(this.lblSanBayDen);
            this.Controls.Add(this.cboSanBayDi);
            this.Controls.Add(this.lblSanBayDi);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.cboMayBay);
            this.Controls.Add(this.lblMayBay);
            this.Controls.Add(this.txtMaChuyenBay);
            this.Controls.Add(this.lblMaChuyenBay);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmChuyenBay";
            this.Text = "Quản lý chuyến bay";
            this.Load += new System.EventHandler(this.frmChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaPhoThong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaThuongGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblMaChuyenBay;
        private System.Windows.Forms.TextBox txtMaChuyenBay;
        private System.Windows.Forms.Label lblMayBay;
        private System.Windows.Forms.ComboBox cboMayBay;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblSanBayDi;
        private System.Windows.Forms.ComboBox cboSanBayDi;
        private System.Windows.Forms.Label lblSanBayDen;
        private System.Windows.Forms.ComboBox cboSanBayDen;
        private System.Windows.Forms.Label lblNgayGioBay;
        private System.Windows.Forms.DateTimePicker dtpNgayGioBay;
        private System.Windows.Forms.Label lblGiaPhoThong;
        private System.Windows.Forms.NumericUpDown nudGiaPhoThong;
        private System.Windows.Forms.Label lblGiaThuongGia;
        private System.Windows.Forms.NumericUpDown nudGiaThuongGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnInDanhSach;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMayBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGioBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaPhoThong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaThuongGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoVeDaBan;
    }
}
