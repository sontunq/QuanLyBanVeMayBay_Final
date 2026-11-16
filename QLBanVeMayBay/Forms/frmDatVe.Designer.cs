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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleTieuDe1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleDongLe1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleO1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblViTri = new System.Windows.Forms.Label();
            this.rdoTatCa = new System.Windows.Forms.RadioButton();
            this.rdoCuaSo = new System.Windows.Forms.RadioButton();
            this.rdoLoiDi = new System.Windows.Forms.RadioButton();
            this.rdoGheGiua = new System.Windows.Forms.RadioButton();
            this.btnTuChonGhe = new System.Windows.Forms.Button();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.cboPhuongThuc = new System.Windows.Forms.ComboBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.lblTieuDeGia = new System.Windows.Forms.Label();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.lblTieuDeUuDai = new System.Windows.Forms.Label();
            this.lblUuDai = new System.Windows.Forms.Label();
            this.lblTieuDeThanhTien = new System.Windows.Forms.Label();
            this.lblConTrong = new System.Windows.Forms.Label();
            this.lblHanhTrinh = new System.Windows.Forms.Label();
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
            this.cboChuyenBay.DropDownWidth = 640;
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
            this.cboKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(130, 150);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(290, 23);
            this.cboKhachHang.TabIndex = 6;
            this.cboKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboKhachHang_SelectedIndexChanged);
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(425, 149);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(35, 25);
            this.btnThemKhach.TabIndex = 7;
            this.btnThemKhach.Text = "+";
            this.btnThemKhach.BackColor = System.Drawing.Color.White;
            this.btnThemKhach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.btnThemKhach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnThemKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnThemKhach.UseVisualStyleBackColor = false;
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
            this.lblGhe.Location = new System.Drawing.Point(20, 258);
            this.lblGhe.Name = "lblGhe";
            this.lblGhe.Size = new System.Drawing.Size(32, 15);
            this.lblGhe.TabIndex = 10;
            this.lblGhe.Text = "Ghế:";
            // 
            // cboGhe
            // 
            this.cboGhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGhe.FormattingEnabled = true;
            this.cboGhe.DropDownHeight = 260;
            this.cboGhe.IntegralHeight = false;
            this.cboGhe.Location = new System.Drawing.Point(130, 255);
            this.cboGhe.Name = "cboGhe";
            this.cboGhe.Size = new System.Drawing.Size(200, 23);
            this.cboGhe.TabIndex = 11;
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(20, 223);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(45, 15);
            this.lblViTri.TabIndex = 30;
            this.lblViTri.Text = "Vị trí:";
            // 
            // rdoTatCa
            // 
            this.rdoTatCa.AutoSize = true;
            this.rdoTatCa.Checked = true;
            this.rdoTatCa.Location = new System.Drawing.Point(130, 221);
            this.rdoTatCa.Name = "rdoTatCa";
            this.rdoTatCa.Size = new System.Drawing.Size(70, 19);
            this.rdoTatCa.TabIndex = 31;
            this.rdoTatCa.TabStop = true;
            this.rdoTatCa.Text = "Tất cả";
            this.rdoTatCa.UseVisualStyleBackColor = true;
            this.rdoTatCa.CheckedChanged += new System.EventHandler(this.rdoViTri_CheckedChanged);
            // 
            // rdoCuaSo
            // 
            this.rdoCuaSo.AutoSize = true;
            this.rdoCuaSo.Location = new System.Drawing.Point(205, 221);
            this.rdoCuaSo.Name = "rdoCuaSo";
            this.rdoCuaSo.Size = new System.Drawing.Size(70, 19);
            this.rdoCuaSo.TabIndex = 32;
            this.rdoCuaSo.Text = "Cửa sổ";
            this.rdoCuaSo.UseVisualStyleBackColor = true;
            this.rdoCuaSo.CheckedChanged += new System.EventHandler(this.rdoViTri_CheckedChanged);
            // 
            // rdoLoiDi
            // 
            this.rdoLoiDi.AutoSize = true;
            this.rdoLoiDi.Location = new System.Drawing.Point(285, 221);
            this.rdoLoiDi.Name = "rdoLoiDi";
            this.rdoLoiDi.Size = new System.Drawing.Size(70, 19);
            this.rdoLoiDi.TabIndex = 33;
            this.rdoLoiDi.Text = "Lối đi";
            this.rdoLoiDi.UseVisualStyleBackColor = true;
            this.rdoLoiDi.CheckedChanged += new System.EventHandler(this.rdoViTri_CheckedChanged);
            // 
            // rdoGheGiua
            // 
            this.rdoGheGiua.AutoSize = true;
            this.rdoGheGiua.Location = new System.Drawing.Point(360, 221);
            this.rdoGheGiua.Name = "rdoGheGiua";
            this.rdoGheGiua.Size = new System.Drawing.Size(70, 19);
            this.rdoGheGiua.TabIndex = 34;
            this.rdoGheGiua.Text = "Ghế giữa";
            this.rdoGheGiua.UseVisualStyleBackColor = true;
            this.rdoGheGiua.CheckedChanged += new System.EventHandler(this.rdoViTri_CheckedChanged);
            // 
            // btnTuChonGhe
            // 
            this.btnTuChonGhe.BackColor = System.Drawing.Color.White;
            this.btnTuChonGhe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.btnTuChonGhe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnTuChonGhe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuChonGhe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnTuChonGhe.Location = new System.Drawing.Point(340, 254);
            this.btnTuChonGhe.Name = "btnTuChonGhe";
            this.btnTuChonGhe.Size = new System.Drawing.Size(120, 25);
            this.btnTuChonGhe.TabIndex = 35;
            this.btnTuChonGhe.Text = "Tự chọn ghế";
            this.btnTuChonGhe.UseVisualStyleBackColor = false;
            this.btnTuChonGhe.Click += new System.EventHandler(this.btnTuChonGhe_Click);
            // 
            // lblPhuongThuc
            // 
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Location = new System.Drawing.Point(20, 293);
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
            this.cboPhuongThuc.Location = new System.Drawing.Point(130, 290);
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
            this.lblTieuDeGia.Location = new System.Drawing.Point(522, 118);
            this.lblTieuDeGia.Name = "lblTieuDeGia";
            this.lblTieuDeGia.Size = new System.Drawing.Size(54, 15);
            this.lblTieuDeGia.TabIndex = 15;
            this.lblTieuDeGia.Text = "Giá gốc:";
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.AutoSize = true;
            this.lblGiaGoc.Location = new System.Drawing.Point(605, 118);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(22, 15);
            this.lblGiaGoc.TabIndex = 19;
            this.lblGiaGoc.Text = "0 đ";
            // 
            // lblTieuDeUuDai
            // 
            this.lblTieuDeUuDai.AutoSize = true;
            this.lblTieuDeUuDai.Location = new System.Drawing.Point(522, 143);
            this.lblTieuDeUuDai.Name = "lblTieuDeUuDai";
            this.lblTieuDeUuDai.Size = new System.Drawing.Size(46, 15);
            this.lblTieuDeUuDai.TabIndex = 20;
            this.lblTieuDeUuDai.Text = "Ưu đãi:";
            // 
            // lblUuDai
            // 
            this.lblUuDai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblUuDai.Location = new System.Drawing.Point(605, 143);
            this.lblUuDai.Name = "lblUuDai";
            this.lblUuDai.Size = new System.Drawing.Size(375, 15);
            this.lblUuDai.TabIndex = 21;
            this.lblUuDai.Text = "Không có";
            // 
            // lblTieuDeThanhTien
            // 
            this.lblTieuDeThanhTien.AutoSize = true;
            this.lblTieuDeThanhTien.Location = new System.Drawing.Point(522, 177);
            this.lblTieuDeThanhTien.Name = "lblTieuDeThanhTien";
            this.lblTieuDeThanhTien.Size = new System.Drawing.Size(70, 15);
            this.lblTieuDeThanhTien.TabIndex = 22;
            this.lblTieuDeThanhTien.Text = "Thành tiền:";
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.AutoSize = true;
            this.lblGiaVe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaVe.ForeColor = System.Drawing.Color.Red;
            this.lblGiaVe.Location = new System.Drawing.Point(600, 167);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(30, 20);
            this.lblGiaVe.TabIndex = 16;
            this.lblGiaVe.Text = "0 đ";
            // 
            // lblConTrong
            // 
            this.lblConTrong.AutoSize = true;
            this.lblConTrong.ForeColor = System.Drawing.Color.DimGray;
            this.lblConTrong.Location = new System.Drawing.Point(522, 210);
            this.lblConTrong.Name = "lblConTrong";
            this.lblConTrong.Size = new System.Drawing.Size(126, 15);
            this.lblConTrong.TabIndex = 17;
            this.lblConTrong.Text = "Số ghế còn trống:";
            //
            // lblHanhTrinh
            //
            this.lblHanhTrinh.Location = new System.Drawing.Point(522, 233);
            this.lblHanhTrinh.Name = "lblHanhTrinh";
            this.lblHanhTrinh.Size = new System.Drawing.Size(458, 40);
            this.lblHanhTrinh.TabIndex = 18;
            this.lblHanhTrinh.Text = "Hành trình:";
            //
            // btnDatVe
            // 
            this.btnDatVe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.Location = new System.Drawing.Point(20, 335);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(140, 40);
            this.btnDatVe.TabIndex = 18;
            this.btnDatVe.Text = "ĐẶT VÉ";
            this.btnDatVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnDatVe.FlatAppearance.BorderSize = 0;
            this.btnDatVe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(160)))));
            this.btnDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatVe.ForeColor = System.Drawing.Color.White;
            this.btnDatVe.UseVisualStyleBackColor = false;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnInVe
            // 
            this.btnInVe.Enabled = false;
            this.btnInVe.Location = new System.Drawing.Point(170, 335);
            this.btnInVe.Name = "btnInVe";
            this.btnInVe.Size = new System.Drawing.Size(100, 40);
            this.btnInVe.TabIndex = 19;
            this.btnInVe.Text = "In vé";
            this.btnInVe.BackColor = System.Drawing.Color.White;
            this.btnInVe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.btnInVe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnInVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnInVe.UseVisualStyleBackColor = false;
            this.btnInVe.Click += new System.EventHandler(this.btnInVe_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(280, 335);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 20;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(390, 335);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 40);
            this.btnDong.TabIndex = 21;
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
            this.lblDanhSach.Location = new System.Drawing.Point(18, 400);
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
            dataGridViewCellStyleDongLe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.dgvHanhKhach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyleDongLe1;
            this.dgvHanhKhach.BackgroundColor = System.Drawing.Color.White;
            this.dgvHanhKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvHanhKhach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyleTieuDe1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleTieuDe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyleTieuDe1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyleTieuDe1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleTieuDe1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            dataGridViewCellStyleTieuDe1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyleTieuDe1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleTieuDe1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHanhKhach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleTieuDe1;
            dataGridViewCellStyleO1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyleO1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleO1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleO1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            dataGridViewCellStyleO1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleO1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHanhKhach.DefaultCellStyle = dataGridViewCellStyleO1;
            this.dgvHanhKhach.EnableHeadersVisualStyles = false;
            this.dgvHanhKhach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.dgvHanhKhach.RowHeadersVisible = false;
            this.dgvHanhKhach.RowTemplate.Height = 26;
            this.dgvHanhKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaVe,
            this.colHoTen,
            this.colCCCD,
            this.colSoDienThoai,
            this.colSoGhe,
            this.colHangVe,
            this.colGiaVe});
            this.dgvHanhKhach.Location = new System.Drawing.Point(20, 430);
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.MinimumSize = new System.Drawing.Size(1016, 759);
            this.Controls.Add(this.dgvHanhKhach);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnInVe);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.lblHanhTrinh);
            this.Controls.Add(this.lblConTrong);
            this.Controls.Add(this.lblGiaVe);
            this.Controls.Add(this.lblTieuDeThanhTien);
            this.Controls.Add(this.lblUuDai);
            this.Controls.Add(this.lblTieuDeUuDai);
            this.Controls.Add(this.lblGiaGoc);
            this.Controls.Add(this.lblTieuDeGia);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.cboPhuongThuc);
            this.Controls.Add(this.btnTuChonGhe);
            this.Controls.Add(this.rdoGheGiua);
            this.Controls.Add(this.rdoLoiDi);
            this.Controls.Add(this.rdoCuaSo);
            this.Controls.Add(this.rdoTatCa);
            this.Controls.Add(this.lblViTri);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.RadioButton rdoTatCa;
        private System.Windows.Forms.RadioButton rdoCuaSo;
        private System.Windows.Forms.RadioButton rdoLoiDi;
        private System.Windows.Forms.RadioButton rdoGheGiua;
        private System.Windows.Forms.Button btnTuChonGhe;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Label lblTieuDeGia;
        private System.Windows.Forms.Label lblGiaVe;
        private System.Windows.Forms.Label lblGiaGoc;
        private System.Windows.Forms.Label lblTieuDeUuDai;
        private System.Windows.Forms.Label lblUuDai;
        private System.Windows.Forms.Label lblTieuDeThanhTien;
        private System.Windows.Forms.Label lblConTrong;
        private System.Windows.Forms.Label lblHanhTrinh;
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
