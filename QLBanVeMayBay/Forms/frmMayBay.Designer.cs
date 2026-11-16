namespace QLBanVeMayBay.Forms
{
    partial class frmMayBay
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
            this.lblSoHieu = new System.Windows.Forms.Label();
            this.txtSoHieu = new System.Windows.Forms.TextBox();
            this.lblLoaiMayBay = new System.Windows.Forms.Label();
            this.txtLoaiMayBay = new System.Windows.Forms.TextBox();
            this.lblSoHangGhe = new System.Windows.Forms.Label();
            this.nudSoHangGhe = new System.Windows.Forms.NumericUpDown();
            this.lblTongGhe = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvMayBay = new System.Windows.Forms.DataGridView();
            this.colMaMayBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiMayBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoHangGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoHangGhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.lblTieuDe.Location = new System.Drawing.Point(18, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(112, 20);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ MÁY BAY";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(20, 50);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(580, 15);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Mỗi hàng 6 ghế (A - F). Hàng 1 - 2 là Thương gia, các hàng còn lại là Phổ thông.";
            // 
            // lblSoHieu
            // 
            this.lblSoHieu.AutoSize = true;
            this.lblSoHieu.Location = new System.Drawing.Point(20, 88);
            this.lblSoHieu.Name = "lblSoHieu";
            this.lblSoHieu.Size = new System.Drawing.Size(61, 15);
            this.lblSoHieu.TabIndex = 2;
            this.lblSoHieu.Text = "Số hiệu:";
            // 
            // txtSoHieu
            // 
            this.txtSoHieu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoHieu.Location = new System.Drawing.Point(130, 85);
            this.txtSoHieu.MaxLength = 20;
            this.txtSoHieu.Name = "txtSoHieu";
            this.txtSoHieu.Size = new System.Drawing.Size(230, 23);
            this.txtSoHieu.TabIndex = 3;
            // 
            // lblLoaiMayBay
            // 
            this.lblLoaiMayBay.AutoSize = true;
            this.lblLoaiMayBay.Location = new System.Drawing.Point(390, 88);
            this.lblLoaiMayBay.Name = "lblLoaiMayBay";
            this.lblLoaiMayBay.Size = new System.Drawing.Size(97, 15);
            this.lblLoaiMayBay.TabIndex = 4;
            this.lblLoaiMayBay.Text = "Loại máy bay:";
            // 
            // txtLoaiMayBay
            // 
            this.txtLoaiMayBay.Location = new System.Drawing.Point(500, 85);
            this.txtLoaiMayBay.Name = "txtLoaiMayBay";
            this.txtLoaiMayBay.Size = new System.Drawing.Size(250, 23);
            this.txtLoaiMayBay.TabIndex = 5;
            // 
            // lblSoHangGhe
            // 
            this.lblSoHangGhe.AutoSize = true;
            this.lblSoHangGhe.Location = new System.Drawing.Point(20, 123);
            this.lblSoHangGhe.Name = "lblSoHangGhe";
            this.lblSoHangGhe.Size = new System.Drawing.Size(90, 15);
            this.lblSoHangGhe.TabIndex = 6;
            this.lblSoHangGhe.Text = "Số hàng ghế:";
            // 
            // nudSoHangGhe
            // 
            this.nudSoHangGhe.Location = new System.Drawing.Point(130, 120);
            this.nudSoHangGhe.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudSoHangGhe.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSoHangGhe.Name = "nudSoHangGhe";
            this.nudSoHangGhe.Size = new System.Drawing.Size(100, 23);
            this.nudSoHangGhe.TabIndex = 7;
            this.nudSoHangGhe.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSoHangGhe.ValueChanged += new System.EventHandler(this.nudSoHangGhe_ValueChanged);
            // 
            // lblTongGhe
            // 
            this.lblTongGhe.AutoSize = true;
            this.lblTongGhe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGhe.Location = new System.Drawing.Point(240, 123);
            this.lblTongGhe.Name = "lblTongGhe";
            this.lblTongGhe.Size = new System.Drawing.Size(61, 20);
            this.lblTongGhe.TabIndex = 8;
            this.lblTongGhe.Text = "= 60 ghế";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(128, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(236, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(344, 165);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(18, 215);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(126, 20);
            this.lblDanhSach.TabIndex = 13;
            this.lblDanhSach.Text = "DANH SÁCH MÁY BAY";
            // 
            // dgvMayBay
            // 
            this.dgvMayBay.AllowUserToAddRows = false;
            this.dgvMayBay.AllowUserToDeleteRows = false;
            this.dgvMayBay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMayBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMayBay.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMayBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMayBay,
            this.colSoHieu,
            this.colLoaiMayBay,
            this.colSoHangGhe,
            this.colTongGhe});
            this.dgvMayBay.Location = new System.Drawing.Point(20, 245);
            this.dgvMayBay.MultiSelect = false;
            this.dgvMayBay.Name = "dgvMayBay";
            this.dgvMayBay.ReadOnly = true;
            this.dgvMayBay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMayBay.Size = new System.Drawing.Size(740, 295);
            this.dgvMayBay.TabIndex = 14;
            this.dgvMayBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMayBay_CellClick);
            // 
            // colMaMayBay
            // 
            this.colMaMayBay.DataPropertyName = "MaMayBay";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaMayBay.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMaMayBay.FillWeight = 40F;
            this.colMaMayBay.HeaderText = "Mã";
            this.colMaMayBay.Name = "colMaMayBay";
            this.colMaMayBay.ReadOnly = true;
            // 
            // colSoHieu
            // 
            this.colSoHieu.DataPropertyName = "SoHieu";
            this.colSoHieu.FillWeight = 90F;
            this.colSoHieu.HeaderText = "Số hiệu";
            this.colSoHieu.Name = "colSoHieu";
            this.colSoHieu.ReadOnly = true;
            // 
            // colLoaiMayBay
            // 
            this.colLoaiMayBay.DataPropertyName = "LoaiMayBay";
            this.colLoaiMayBay.FillWeight = 120F;
            this.colLoaiMayBay.HeaderText = "Loại máy bay";
            this.colLoaiMayBay.Name = "colLoaiMayBay";
            this.colLoaiMayBay.ReadOnly = true;
            // 
            // colSoHangGhe
            // 
            this.colSoHangGhe.DataPropertyName = "SoHangGhe";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoHangGhe.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSoHangGhe.FillWeight = 70F;
            this.colSoHangGhe.HeaderText = "Số hàng ghế";
            this.colSoHangGhe.Name = "colSoHangGhe";
            this.colSoHangGhe.ReadOnly = true;
            // 
            // colTongGhe
            // 
            this.colTongGhe.DataPropertyName = "TongGhe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTongGhe.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTongGhe.FillWeight = 70F;
            this.colTongGhe.HeaderText = "Tổng số ghế";
            this.colTongGhe.Name = "colTongGhe";
            this.colTongGhe.ReadOnly = true;
            // 
            // frmMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.dgvMayBay);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblTongGhe);
            this.Controls.Add(this.nudSoHangGhe);
            this.Controls.Add(this.lblSoHangGhe);
            this.Controls.Add(this.txtLoaiMayBay);
            this.Controls.Add(this.lblLoaiMayBay);
            this.Controls.Add(this.txtSoHieu);
            this.Controls.Add(this.lblSoHieu);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmMayBay";
            this.Text = "Quản lý máy bay";
            this.Load += new System.EventHandler(this.frmMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoHangGhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblSoHieu;
        private System.Windows.Forms.TextBox txtSoHieu;
        private System.Windows.Forms.Label lblLoaiMayBay;
        private System.Windows.Forms.TextBox txtLoaiMayBay;
        private System.Windows.Forms.Label lblSoHangGhe;
        private System.Windows.Forms.NumericUpDown nudSoHangGhe;
        private System.Windows.Forms.Label lblTongGhe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvMayBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMayBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiMayBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHangGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongGhe;
    }
}
