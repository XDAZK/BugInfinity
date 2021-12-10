
namespace App_Pharmacy
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.pnTop = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.pnThongTin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboTinhTrang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboBangCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDTNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.pnlistview = new System.Windows.Forms.Panel();
            this.pbUpDown = new FontAwesome.Sharp.IconPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lsvDanhSachThongTin = new System.Windows.Forms.ListView();
            this.MA_NHANVIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TEN_NHANVIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GIOI_TINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NV_NGAYSINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT_NHANVIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BANG_CAP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TINH_TRANG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnNVDaNghi = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.pnTop.SuspendLayout();
            this.pnThongTin.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.pnlistview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.txtTimKiem);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Controls.Add(this.lblTong);
            this.pnTop.CustomBorderColor = System.Drawing.Color.Silver;
            this.pnTop.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.Name = "pnTop";
            this.pnTop.ShadowDecoration.Parent = this.pnTop;
            this.pnTop.Size = new System.Drawing.Size(1620, 75);
            this.pnTop.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.AutoRoundedCorners = true;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderRadius = 21;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.IconLeft")));
            this.txtTimKiem.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtTimKiem.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtTimKiem.Location = new System.Drawing.Point(1306, 12);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Nhập tên nhân viên cần tìm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(300, 45);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.TextOffset = new System.Drawing.Point(5, 0);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân Viên";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTong.Location = new System.Drawing.Point(32, 21);
            this.lblTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(51, 36);
            this.lblTong.TabIndex = 0;
            this.lblTong.Text = "76";
            // 
            // pnThongTin
            // 
            this.pnThongTin.Controls.Add(this.guna2GroupBox1);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnThongTin.Location = new System.Drawing.Point(0, 565);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.ShadowDecoration.Parent = this.pnThongTin;
            this.pnThongTin.Size = new System.Drawing.Size(1620, 450);
            this.pnThongTin.TabIndex = 4;
            this.pnThongTin.Visible = false;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cboTinhTrang);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.cboBangCap);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.dtNgaySinh);
            this.guna2GroupBox1.Controls.Add(this.rbtnNu);
            this.guna2GroupBox1.Controls.Add(this.rbtnNam);
            this.guna2GroupBox1.Controls.Add(this.txtMaNV);
            this.guna2GroupBox1.Controls.Add(this.txtTenNV);
            this.guna2GroupBox1.Controls.Add(this.txtSDTNV);
            this.guna2GroupBox1.Controls.Add(this.btnLuu);
            this.guna2GroupBox1.Controls.Add(this.btnHuy);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1620, 450);
            this.guna2GroupBox1.TabIndex = 7;
            this.guna2GroupBox1.Text = "Thông Tin Chi Tiết Nhân Viên";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.cboTinhTrang.BorderColor = System.Drawing.Color.Gray;
            this.cboTinhTrang.BorderRadius = 5;
            this.cboTinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FocusedColor = System.Drawing.Color.Empty;
            this.cboTinhTrang.FocusedState.Parent = this.cboTinhTrang;
            this.cboTinhTrang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinhTrang.ForeColor = System.Drawing.Color.Black;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.HoverState.Parent = this.cboTinhTrang;
            this.cboTinhTrang.ItemHeight = 30;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Hoạt động",
            "Đã nghỉ"});
            this.cboTinhTrang.ItemsAppearance.Parent = this.cboTinhTrang;
            this.cboTinhTrang.Location = new System.Drawing.Point(920, 270);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.ShadowDecoration.Parent = this.cboTinhTrang;
            this.cboTinhTrang.Size = new System.Drawing.Size(271, 36);
            this.cboTinhTrang.TabIndex = 30;
            this.cboTinhTrang.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(732, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tình Trạng";
            // 
            // cboBangCap
            // 
            this.cboBangCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboBangCap.BackColor = System.Drawing.Color.Transparent;
            this.cboBangCap.BorderColor = System.Drawing.Color.Gray;
            this.cboBangCap.BorderRadius = 5;
            this.cboBangCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBangCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBangCap.FocusedColor = System.Drawing.Color.Empty;
            this.cboBangCap.FocusedState.Parent = this.cboBangCap;
            this.cboBangCap.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBangCap.ForeColor = System.Drawing.Color.Black;
            this.cboBangCap.FormattingEnabled = true;
            this.cboBangCap.HoverState.Parent = this.cboBangCap;
            this.cboBangCap.ItemHeight = 30;
            this.cboBangCap.Items.AddRange(new object[] {
            "Dược Sĩ",
            "Dược Tá",
            "Thạc Sĩ",
            "Cao Đẳng",
            "Trung Cấp"});
            this.cboBangCap.ItemsAppearance.Parent = this.cboBangCap;
            this.cboBangCap.Location = new System.Drawing.Point(316, 360);
            this.cboBangCap.Name = "cboBangCap";
            this.cboBangCap.ShadowDecoration.Parent = this.cboBangCap;
            this.cboBangCap.Size = new System.Drawing.Size(334, 36);
            this.cboBangCap.TabIndex = 30;
            this.cboBangCap.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Bằng Cấp";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "SDT Nhân Viên";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(732, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(732, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ngày Sinh";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtNgaySinh.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dtNgaySinh.CustomFormat = "    dd/MM/yyyy";
            this.dtNgaySinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(920, 176);
            this.dtNgaySinh.MaxDate = new System.DateTime(2021, 10, 27, 0, 0, 0, 0);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(271, 30);
            this.dtNgaySinh.TabIndex = 23;
            this.dtNgaySinh.Value = new System.DateTime(2021, 10, 27, 0, 0, 0, 0);
            // 
            // rbtnNu
            // 
            this.rbtnNu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.rbtnNu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNu.ForeColor = System.Drawing.Color.Black;
            this.rbtnNu.Location = new System.Drawing.Point(1031, 89);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(55, 27);
            this.rbtnNu.TabIndex = 21;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = false;
            // 
            // rbtnNam
            // 
            this.rbtnNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.rbtnNam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNam.ForeColor = System.Drawing.Color.Black;
            this.rbtnNam.Location = new System.Drawing.Point(920, 89);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(68, 27);
            this.rbtnNam.TabIndex = 22;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaNV.BorderColor = System.Drawing.Color.Gray;
            this.txtMaNV.BorderRadius = 5;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.Parent = this.txtMaNV;
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtMaNV.FocusedState.Parent = this.txtMaNV;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.HoverState.Parent = this.txtMaNV;
            this.txtMaNV.Location = new System.Drawing.Point(316, 76);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaNV.PlaceholderText = "Nhập mã khách hàng";
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.ShadowDecoration.Parent = this.txtMaNV;
            this.txtMaNV.Size = new System.Drawing.Size(334, 40);
            this.txtMaNV.TabIndex = 18;
            this.txtMaNV.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenNV.BorderColor = System.Drawing.Color.Gray;
            this.txtTenNV.BorderRadius = 5;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.Parent = this.txtTenNV;
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTenNV.FocusedState.Parent = this.txtTenNV;
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Black;
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.HoverState.Parent = this.txtTenNV;
            this.txtTenNV.Location = new System.Drawing.Point(316, 166);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTenNV.PlaceholderText = "Nhập tên khách hàng";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.ShadowDecoration.Parent = this.txtTenNV;
            this.txtTenNV.Size = new System.Drawing.Size(334, 40);
            this.txtTenNV.TabIndex = 19;
            this.txtTenNV.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSDTNV.BorderColor = System.Drawing.Color.Gray;
            this.txtSDTNV.BorderRadius = 5;
            this.txtSDTNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDTNV.DefaultText = "";
            this.txtSDTNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDTNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDTNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDTNV.DisabledState.Parent = this.txtSDTNV;
            this.txtSDTNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDTNV.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtSDTNV.FocusedState.Parent = this.txtSDTNV;
            this.txtSDTNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNV.ForeColor = System.Drawing.Color.Black;
            this.txtSDTNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDTNV.HoverState.Parent = this.txtSDTNV;
            this.txtSDTNV.Location = new System.Drawing.Point(316, 266);
            this.txtSDTNV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.PasswordChar = '\0';
            this.txtSDTNV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSDTNV.PlaceholderText = "Nhập sdt khách hàng";
            this.txtSDTNV.SelectedText = "";
            this.txtSDTNV.ShadowDecoration.Parent = this.txtSDTNV;
            this.txtSDTNV.Size = new System.Drawing.Size(334, 40);
            this.txtSDTNV.TabIndex = 20;
            this.txtSDTNV.TextOffset = new System.Drawing.Point(8, 0);
            this.txtSDTNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTNV_KeyPress);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnLuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.BorderRadius = 5;
            this.btnLuu.BorderThickness = 1;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.Transparent;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnLuu.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Location = new System.Drawing.Point(1431, 156);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(112, 50);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.BorderThickness = 1;
            this.btnHuy.CheckedState.Parent = this.btnHuy;
            this.btnHuy.CustomImages.Parent = this.btnHuy;
            this.btnHuy.FillColor = System.Drawing.Color.Transparent;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnHuy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.HoverState.Parent = this.btnHuy;
            this.btnHuy.Location = new System.Drawing.Point(1431, 256);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ShadowDecoration.Parent = this.btnHuy;
            this.btnHuy.Size = new System.Drawing.Size(112, 50);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pnlistview
            // 
            this.pnlistview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlistview.Controls.Add(this.pbUpDown);
            this.pnlistview.Controls.Add(this.button1);
            this.pnlistview.Controls.Add(this.lsvDanhSachThongTin);
            this.pnlistview.Controls.Add(this.btnSua);
            this.pnlistview.Controls.Add(this.btnNVDaNghi);
            this.pnlistview.Controls.Add(this.btnThem);
            this.pnlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlistview.Location = new System.Drawing.Point(0, 75);
            this.pnlistview.Name = "pnlistview";
            this.pnlistview.Size = new System.Drawing.Size(1620, 490);
            this.pnlistview.TabIndex = 5;
            // 
            // pbUpDown
            // 
            this.pbUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pbUpDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbUpDown.IconChar = FontAwesome.Sharp.IconChar.AngleUp;
            this.pbUpDown.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbUpDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbUpDown.IconSize = 40;
            this.pbUpDown.Location = new System.Drawing.Point(1556, 403);
            this.pbUpDown.Name = "pbUpDown";
            this.pbUpDown.Size = new System.Drawing.Size(40, 50);
            this.pbUpDown.TabIndex = 6;
            this.pbUpDown.TabStop = false;
            this.pbUpDown.Click += new System.EventHandler(this.pbUpDown_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Click đúp để xem thông tin chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lsvDanhSachThongTin
            // 
            this.lsvDanhSachThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvDanhSachThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lsvDanhSachThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvDanhSachThongTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MA_NHANVIEN,
            this.TEN_NHANVIEN,
            this.GIOI_TINH,
            this.NV_NGAYSINH,
            this.SDT_NHANVIEN,
            this.BANG_CAP,
            this.TINH_TRANG});
            this.lsvDanhSachThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSachThongTin.FullRowSelect = true;
            this.lsvDanhSachThongTin.HideSelection = false;
            this.lsvDanhSachThongTin.Location = new System.Drawing.Point(12, 7);
            this.lsvDanhSachThongTin.Name = "lsvDanhSachThongTin";
            this.lsvDanhSachThongTin.Size = new System.Drawing.Size(1596, 355);
            this.lsvDanhSachThongTin.TabIndex = 0;
            this.lsvDanhSachThongTin.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachThongTin.View = System.Windows.Forms.View.Details;
            this.lsvDanhSachThongTin.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSachThongTin_SelectedIndexChanged);
            this.lsvDanhSachThongTin.DoubleClick += new System.EventHandler(this.lsvDanhSachThongTin_DoubleClick);
            // 
            // MA_NHANVIEN
            // 
            this.MA_NHANVIEN.Text = "Mã Nhân Viên";
            this.MA_NHANVIEN.Width = 200;
            // 
            // TEN_NHANVIEN
            // 
            this.TEN_NHANVIEN.Text = "Tên Nhân Viên";
            this.TEN_NHANVIEN.Width = 400;
            // 
            // GIOI_TINH
            // 
            this.GIOI_TINH.Text = "Giới Tính";
            this.GIOI_TINH.Width = 200;
            // 
            // NV_NGAYSINH
            // 
            this.NV_NGAYSINH.Text = "Ngày Sinh";
            this.NV_NGAYSINH.Width = 200;
            // 
            // SDT_NHANVIEN
            // 
            this.SDT_NHANVIEN.Text = "SDT";
            this.SDT_NHANVIEN.Width = 200;
            // 
            // BANG_CAP
            // 
            this.BANG_CAP.Text = "Bằng Cấp";
            this.BANG_CAP.Width = 200;
            // 
            // TINH_TRANG
            // 
            this.TINH_TRANG.Text = "Tình Trạng";
            this.TINH_TRANG.Width = 200;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.BorderRadius = 5;
            this.btnSua.BorderThickness = 1;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnSua.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(1275, 403);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(112, 50);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnNVDaNghi
            // 
            this.btnNVDaNghi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNVDaNghi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNVDaNghi.BorderRadius = 5;
            this.btnNVDaNghi.BorderThickness = 1;
            this.btnNVDaNghi.CheckedState.Parent = this.btnNVDaNghi;
            this.btnNVDaNghi.CustomImages.Parent = this.btnNVDaNghi;
            this.btnNVDaNghi.FillColor = System.Drawing.Color.Transparent;
            this.btnNVDaNghi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNVDaNghi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNVDaNghi.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnNVDaNghi.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNVDaNghi.HoverState.Parent = this.btnNVDaNghi;
            this.btnNVDaNghi.Location = new System.Drawing.Point(502, 403);
            this.btnNVDaNghi.Margin = new System.Windows.Forms.Padding(4);
            this.btnNVDaNghi.Name = "btnNVDaNghi";
            this.btnNVDaNghi.ShadowDecoration.Parent = this.btnNVDaNghi;
            this.btnNVDaNghi.Size = new System.Drawing.Size(321, 50);
            this.btnNVDaNghi.TabIndex = 3;
            this.btnNVDaNghi.Text = "Nhân Viên Đã Nghỉ";
            this.btnNVDaNghi.TextChanged += new System.EventHandler(this.btnNVDaNghi_TextChanged);
            this.btnNVDaNghi.Click += new System.EventHandler(this.btnNVDaNghi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.BorderRadius = 5;
            this.btnThem.BorderThickness = 1;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnThem.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(1130, 403);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(112, 50);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1015);
            this.Controls.Add(this.pnlistview);
            this.Controls.Add(this.pnThongTin);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnThongTin.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.pnlistview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnTop;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTong;
        private Guna.UI2.WinForms.Guna2Panel pnThongTin;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private System.Windows.Forms.Panel pnlistview;
        private FontAwesome.Sharp.IconPictureBox pbUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lsvDanhSachThongTin;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtSDTNV;
        private Guna.UI2.WinForms.Guna2ComboBox cboBangCap;
        private Guna.UI2.WinForms.Guna2ComboBox cboTinhTrang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader MA_NHANVIEN;
        private System.Windows.Forms.ColumnHeader TEN_NHANVIEN;
        private System.Windows.Forms.ColumnHeader GIOI_TINH;
        private System.Windows.Forms.ColumnHeader NV_NGAYSINH;
        private System.Windows.Forms.ColumnHeader SDT_NHANVIEN;
        private System.Windows.Forms.ColumnHeader BANG_CAP;
        private System.Windows.Forms.ColumnHeader TINH_TRANG;
        private Guna.UI2.WinForms.Guna2Button btnNVDaNghi;
    }
}