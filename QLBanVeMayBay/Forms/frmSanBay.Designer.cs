namespace QLBanVeMayBay.Forms
{
    partial class frmSanBay
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblMaSanBay = new System.Windows.Forms.Label();
            this.txtMaSanBay = new System.Windows.Forms.TextBox();
            this.lblTenSanBay = new System.Windows.Forms.Label();
            this.txtTenSanBay = new System.Windows.Forms.TextBox();
            this.lblThanhPho = new System.Windows.Forms.Label();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvSanBay = new System.Windows.Forms.DataGridView();
            this.colMaSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanBay)).BeginInit();
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
            this.lblTieuDe.Text = "QUẢN LÝ SÂN BAY";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(20, 50);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(270, 15);
            this.lblMoTa.TabIndex = 1;
            this.lblMoTa.Text = "Thêm, sửa, xóa thông tin các sân bay.";
            // 
            // lblMaSanBay
            // 
            this.lblMaSanBay.AutoSize = true;
            this.lblMaSanBay.Location = new System.Drawing.Point(20, 88);
            this.lblMaSanBay.Name = "lblMaSanBay";
            this.lblMaSanBay.Size = new System.Drawing.Size(83, 15);
            this.lblMaSanBay.TabIndex = 2;
            this.lblMaSanBay.Text = "Mã sân bay:";
            // 
            // txtMaSanBay
            // 
            this.txtMaSanBay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaSanBay.Location = new System.Drawing.Point(130, 85);
            this.txtMaSanBay.MaxLength = 5;
            this.txtMaSanBay.Name = "txtMaSanBay";
            this.txtMaSanBay.Size = new System.Drawing.Size(230, 23);
            this.txtMaSanBay.TabIndex = 3;
            // 
            // lblTenSanBay
            // 
            this.lblTenSanBay.AutoSize = true;
            this.lblTenSanBay.Location = new System.Drawing.Point(390, 88);
            this.lblTenSanBay.Name = "lblTenSanBay";
            this.lblTenSanBay.Size = new System.Drawing.Size(90, 15);
            this.lblTenSanBay.TabIndex = 4;
            this.lblTenSanBay.Text = "Tên sân bay:";
            // 
            // txtTenSanBay
            // 
            this.txtTenSanBay.Location = new System.Drawing.Point(500, 85);
            this.txtTenSanBay.Name = "txtTenSanBay";
            this.txtTenSanBay.Size = new System.Drawing.Size(250, 23);
            this.txtTenSanBay.TabIndex = 5;
            // 
            // lblThanhPho
            // 
            this.lblThanhPho.AutoSize = true;
            this.lblThanhPho.Location = new System.Drawing.Point(20, 123);
            this.lblThanhPho.Name = "lblThanhPho";
            this.lblThanhPho.Size = new System.Drawing.Size(76, 15);
            this.lblThanhPho.TabIndex = 6;
            this.lblThanhPho.Text = "Thành phố:";
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Location = new System.Drawing.Point(130, 120);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(230, 23);
            this.txtThanhPho.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(160)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(128, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(236, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(344, 165);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(175)))), ((int)(((byte)(200)))));
            this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(18, 215);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(126, 20);
            this.lblDanhSach.TabIndex = 12;
            this.lblDanhSach.Text = "DANH SÁCH SÂN BAY";
            // 
            // dgvSanBay
            // 
            this.dgvSanBay.AllowUserToAddRows = false;
            this.dgvSanBay.AllowUserToDeleteRows = false;
            this.dgvSanBay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyleDongLe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.dgvSanBay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyleDongLe1;
            this.dgvSanBay.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanBay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvSanBay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyleTieuDe1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleTieuDe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyleTieuDe1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyleTieuDe1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleTieuDe1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            dataGridViewCellStyleTieuDe1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyleTieuDe1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleTieuDe1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanBay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleTieuDe1;
            dataGridViewCellStyleO1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyleO1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleO1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleO1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            dataGridViewCellStyleO1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleO1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanBay.DefaultCellStyle = dataGridViewCellStyleO1;
            this.dgvSanBay.EnableHeadersVisualStyles = false;
            this.dgvSanBay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.dgvSanBay.RowHeadersVisible = false;
            this.dgvSanBay.RowTemplate.Height = 26;
            this.dgvSanBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSanBay,
            this.colTenSanBay,
            this.colThanhPho});
            this.dgvSanBay.Location = new System.Drawing.Point(20, 245);
            this.dgvSanBay.MultiSelect = false;
            this.dgvSanBay.Name = "dgvSanBay";
            this.dgvSanBay.ReadOnly = true;
            this.dgvSanBay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanBay.Size = new System.Drawing.Size(740, 275);
            this.dgvSanBay.TabIndex = 13;
            this.dgvSanBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanBay_CellClick);
            // 
            // colMaSanBay
            // 
            this.colMaSanBay.DataPropertyName = "MaSanBay";
            this.colMaSanBay.FillWeight = 60F;
            this.colMaSanBay.HeaderText = "Mã sân bay";
            this.colMaSanBay.Name = "colMaSanBay";
            this.colMaSanBay.ReadOnly = true;
            // 
            // colTenSanBay
            // 
            this.colTenSanBay.DataPropertyName = "TenSanBay";
            this.colTenSanBay.FillWeight = 160F;
            this.colTenSanBay.HeaderText = "Tên sân bay";
            this.colTenSanBay.Name = "colTenSanBay";
            this.colTenSanBay.ReadOnly = true;
            // 
            // colThanhPho
            // 
            this.colThanhPho.DataPropertyName = "ThanhPho";
            this.colThanhPho.HeaderText = "Thành phố";
            this.colThanhPho.Name = "colThanhPho";
            this.colThanhPho.ReadOnly = true;
            // 
            // frmSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.MinimumSize = new System.Drawing.Size(796, 579);
            this.Controls.Add(this.dgvSanBay);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtThanhPho);
            this.Controls.Add(this.lblThanhPho);
            this.Controls.Add(this.txtTenSanBay);
            this.Controls.Add(this.lblTenSanBay);
            this.Controls.Add(this.txtMaSanBay);
            this.Controls.Add(this.lblMaSanBay);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmSanBay";
            this.Text = "Quản lý sân bay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSanBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblMaSanBay;
        private System.Windows.Forms.TextBox txtMaSanBay;
        private System.Windows.Forms.Label lblTenSanBay;
        private System.Windows.Forms.TextBox txtTenSanBay;
        private System.Windows.Forms.Label lblThanhPho;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.DataGridView dgvSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhPho;
    }
}
