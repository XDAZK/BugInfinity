
namespace App_Pharmacy
{
    partial class FrmDDT
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
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.SO_LUONG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TEN_THUOC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.lsvCTDD = new System.Windows.Forms.ListView();
            this.gbCTDD = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnXoaThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.cboThuoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiemThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbHoaDon = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaoDD = new Guna.UI2.WinForms.Guna2Button();
            this.cboNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiemNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvDonDat = new System.Windows.Forms.ListView();
            this.MA_DONDAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TEN_NHANVIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MA_NCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAY_LAP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.gbCTDD.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
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
            this.btnSua.Location = new System.Drawing.Point(220, 259);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(105, 41);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.CustomFormat = "    dd/MM/yyyy  HH:mm:ss";
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLap.Location = new System.Drawing.Point(217, 95);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(265, 26);
            this.dtNgayLap.TabIndex = 46;
            // 
            // SO_LUONG
            // 
            this.SO_LUONG.Text = "Số Lượng";
            this.SO_LUONG.Width = 210;
            // 
            // TEN_THUOC
            // 
            this.TEN_THUOC.Text = "Thuốc";
            this.TEN_THUOC.Width = 260;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(64, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 21);
            this.label10.TabIndex = 52;
            this.label10.Text = "Thuốc";
            // 
            // lsvCTDD
            // 
            this.lsvCTDD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvCTDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lsvCTDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvCTDD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TEN_THUOC,
            this.SO_LUONG});
            this.lsvCTDD.FullRowSelect = true;
            this.lsvCTDD.GridLines = true;
            this.lsvCTDD.HideSelection = false;
            this.lsvCTDD.Location = new System.Drawing.Point(0, 363);
            this.lsvCTDD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvCTDD.Name = "lsvCTDD";
            this.lsvCTDD.Size = new System.Drawing.Size(646, 462);
            this.lsvCTDD.TabIndex = 2;
            this.lsvCTDD.UseCompatibleStateImageBehavior = false;
            this.lsvCTDD.View = System.Windows.Forms.View.Details;
            this.lsvCTDD.SelectedIndexChanged += new System.EventHandler(this.lsvCTDD_SelectedIndexChanged);
            // 
            // gbCTDD
            // 
            this.gbCTDD.BorderColor = System.Drawing.Color.Black;
            this.gbCTDD.Controls.Add(this.btnXoaThuoc);
            this.gbCTDD.Controls.Add(this.btnSua);
            this.gbCTDD.Controls.Add(this.btnThemThuoc);
            this.gbCTDD.Controls.Add(this.cboThuoc);
            this.gbCTDD.Controls.Add(this.label6);
            this.gbCTDD.Controls.Add(this.txtSoLuong);
            this.gbCTDD.Controls.Add(this.label8);
            this.gbCTDD.Controls.Add(this.txtTimKiemThuoc);
            this.gbCTDD.Controls.Add(this.label10);
            this.gbCTDD.Controls.Add(this.lsvCTDD);
            this.gbCTDD.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbCTDD.Enabled = false;
            this.gbCTDD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gbCTDD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCTDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbCTDD.Location = new System.Drawing.Point(570, 0);
            this.gbCTDD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCTDD.Name = "gbCTDD";
            this.gbCTDD.ShadowDecoration.Parent = this.gbCTDD;
            this.gbCTDD.Size = new System.Drawing.Size(645, 825);
            this.gbCTDD.TabIndex = 45;
            this.gbCTDD.Text = "Chi Tiết Đơn Đặt Thuốc";
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.BackColor = System.Drawing.Color.White;
            this.btnXoaThuoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoaThuoc.BorderRadius = 5;
            this.btnXoaThuoc.BorderThickness = 1;
            this.btnXoaThuoc.CheckedState.Parent = this.btnXoaThuoc;
            this.btnXoaThuoc.CustomImages.Parent = this.btnXoaThuoc;
            this.btnXoaThuoc.FillColor = System.Drawing.Color.Transparent;
            this.btnXoaThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoaThuoc.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoaThuoc.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoaThuoc.HoverState.Parent = this.btnXoaThuoc;
            this.btnXoaThuoc.Location = new System.Drawing.Point(365, 259);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.ShadowDecoration.Parent = this.btnXoaThuoc;
            this.btnXoaThuoc.Size = new System.Drawing.Size(105, 41);
            this.btnXoaThuoc.TabIndex = 54;
            this.btnXoaThuoc.Text = "Xóa";
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.White;
            this.btnThemThuoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemThuoc.BorderRadius = 5;
            this.btnThemThuoc.BorderThickness = 1;
            this.btnThemThuoc.CheckedState.Parent = this.btnThemThuoc;
            this.btnThemThuoc.CustomImages.Parent = this.btnThemThuoc;
            this.btnThemThuoc.FillColor = System.Drawing.Color.Transparent;
            this.btnThemThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemThuoc.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnThemThuoc.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemThuoc.HoverState.Parent = this.btnThemThuoc;
            this.btnThemThuoc.Location = new System.Drawing.Point(68, 259);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.ShadowDecoration.Parent = this.btnThemThuoc;
            this.btnThemThuoc.Size = new System.Drawing.Size(105, 41);
            this.btnThemThuoc.TabIndex = 55;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // cboThuoc
            // 
            this.cboThuoc.BackColor = System.Drawing.Color.Transparent;
            this.cboThuoc.BorderColor = System.Drawing.Color.Gray;
            this.cboThuoc.BorderRadius = 5;
            this.cboThuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuoc.FocusedColor = System.Drawing.Color.Empty;
            this.cboThuoc.FocusedState.Parent = this.cboThuoc;
            this.cboThuoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThuoc.FormattingEnabled = true;
            this.cboThuoc.HoverState.Parent = this.cboThuoc;
            this.cboThuoc.ItemHeight = 30;
            this.cboThuoc.ItemsAppearance.Parent = this.cboThuoc;
            this.cboThuoc.Location = new System.Drawing.Point(206, 98);
            this.cboThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboThuoc.Name = "cboThuoc";
            this.cboThuoc.ShadowDecoration.Parent = this.cboThuoc;
            this.cboThuoc.Size = new System.Drawing.Size(265, 36);
            this.cboThuoc.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(64, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderColor = System.Drawing.Color.Gray;
            this.txtSoLuong.BorderRadius = 5;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.Parent = this.txtSoLuong;
            this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtSoLuong.FocusedState.Parent = this.txtSoLuong;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.HoverState.Parent = this.txtSoLuong;
            this.txtSoLuong.Location = new System.Drawing.Point(206, 150);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSoLuong.PlaceholderText = "Nhập Số Lượng";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.ShadowDecoration.Parent = this.txtSoLuong;
            this.txtSoLuong.Size = new System.Drawing.Size(264, 30);
            this.txtSoLuong.TabIndex = 45;
            this.txtSoLuong.TextOffset = new System.Drawing.Point(8, 0);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(64, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tìm Kiếm";
            // 
            // txtTimKiemThuoc
            // 
            this.txtTimKiemThuoc.BackColor = System.Drawing.Color.White;
            this.txtTimKiemThuoc.BorderColor = System.Drawing.Color.Gray;
            this.txtTimKiemThuoc.BorderRadius = 5;
            this.txtTimKiemThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemThuoc.DefaultText = "";
            this.txtTimKiemThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemThuoc.DisabledState.Parent = this.txtTimKiemThuoc;
            this.txtTimKiemThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemThuoc.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiemThuoc.FocusedState.Parent = this.txtTimKiemThuoc;
            this.txtTimKiemThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemThuoc.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemThuoc.HoverState.Parent = this.txtTimKiemThuoc;
            this.txtTimKiemThuoc.Location = new System.Drawing.Point(206, 50);
            this.txtTimKiemThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiemThuoc.Name = "txtTimKiemThuoc";
            this.txtTimKiemThuoc.PasswordChar = '\0';
            this.txtTimKiemThuoc.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemThuoc.PlaceholderText = "Nhập Thuốc Cần Tìm";
            this.txtTimKiemThuoc.SelectedText = "";
            this.txtTimKiemThuoc.ShadowDecoration.Parent = this.txtTimKiemThuoc;
            this.txtTimKiemThuoc.Size = new System.Drawing.Size(264, 30);
            this.txtTimKiemThuoc.TabIndex = 47;
            this.txtTimKiemThuoc.TextOffset = new System.Drawing.Point(8, 0);
            this.txtTimKiemThuoc.TextChanged += new System.EventHandler(this.txtTimKiemThuoc_TextChanged);
            this.txtTimKiemThuoc.Leave += new System.EventHandler(this.txtTimKiemThuoc_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.gbHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 825);
            this.panel1.TabIndex = 1;
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.BorderColor = System.Drawing.Color.Black;
            this.gbHoaDon.Controls.Add(this.dtNgayLap);
            this.gbHoaDon.Controls.Add(this.gbCTDD);
            this.gbHoaDon.Controls.Add(this.btnHuy);
            this.gbHoaDon.Controls.Add(this.btnLuu);
            this.gbHoaDon.Controls.Add(this.btnIn);
            this.gbHoaDon.Controls.Add(this.btnTaoDD);
            this.gbHoaDon.Controls.Add(this.cboNCC);
            this.gbHoaDon.Controls.Add(this.label4);
            this.gbHoaDon.Controls.Add(this.label3);
            this.gbHoaDon.Controls.Add(this.txtTimKiemNCC);
            this.gbHoaDon.Controls.Add(this.txtNhanVien);
            this.gbHoaDon.Controls.Add(this.label5);
            this.gbHoaDon.Controls.Add(this.label1);
            this.gbHoaDon.Controls.Add(this.txtMaDDT);
            this.gbHoaDon.Controls.Add(this.label2);
            this.gbHoaDon.Controls.Add(this.lsvDonDat);
            this.gbHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.gbHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbHoaDon.Location = new System.Drawing.Point(0, 0);
            this.gbHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.ShadowDecoration.Parent = this.gbHoaDon;
            this.gbHoaDon.Size = new System.Drawing.Size(1215, 825);
            this.gbHoaDon.TabIndex = 0;
            this.gbHoaDon.Text = "Đơn Đặt Thuốc";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
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
            this.btnHuy.Location = new System.Drawing.Point(376, 259);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ShadowDecoration.Parent = this.btnHuy;
            this.btnHuy.Size = new System.Drawing.Size(105, 41);
            this.btnHuy.TabIndex = 42;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
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
            this.btnLuu.Location = new System.Drawing.Point(217, 259);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(105, 41);
            this.btnLuu.TabIndex = 43;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaoDD
            // 
            this.btnTaoDD.BackColor = System.Drawing.Color.White;
            this.btnTaoDD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTaoDD.BorderRadius = 5;
            this.btnTaoDD.BorderThickness = 1;
            this.btnTaoDD.CheckedState.Parent = this.btnTaoDD;
            this.btnTaoDD.CustomImages.Parent = this.btnTaoDD;
            this.btnTaoDD.FillColor = System.Drawing.Color.Transparent;
            this.btnTaoDD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaoDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTaoDD.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnTaoDD.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTaoDD.HoverState.Parent = this.btnTaoDD;
            this.btnTaoDD.Location = new System.Drawing.Point(552, 50);
            this.btnTaoDD.Name = "btnTaoDD";
            this.btnTaoDD.ShadowDecoration.Parent = this.btnTaoDD;
            this.btnTaoDD.Size = new System.Drawing.Size(105, 41);
            this.btnTaoDD.TabIndex = 41;
            this.btnTaoDD.Text = "Tạo Đơn Đặt";
            this.btnTaoDD.Click += new System.EventHandler(this.btnTaoDD_Click);
            // 
            // cboNCC
            // 
            this.cboNCC.BackColor = System.Drawing.Color.Transparent;
            this.cboNCC.BorderColor = System.Drawing.Color.Gray;
            this.cboNCC.BorderRadius = 5;
            this.cboNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FocusedColor = System.Drawing.Color.Empty;
            this.cboNCC.FocusedState.Parent = this.cboNCC;
            this.cboNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.HoverState.Parent = this.cboNCC;
            this.cboNCC.ItemHeight = 30;
            this.cboNCC.ItemsAppearance.Parent = this.cboNCC;
            this.cboNCC.Location = new System.Drawing.Point(217, 206);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.ShadowDecoration.Parent = this.cboNCC;
            this.cboNCC.Size = new System.Drawing.Size(265, 36);
            this.cboNCC.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(49, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày Lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nhà Cung Cấp";
            // 
            // txtTimKiemNCC
            // 
            this.txtTimKiemNCC.BackColor = System.Drawing.Color.White;
            this.txtTimKiemNCC.BorderColor = System.Drawing.Color.Gray;
            this.txtTimKiemNCC.BorderRadius = 5;
            this.txtTimKiemNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNCC.DefaultText = "";
            this.txtTimKiemNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemNCC.DisabledState.Parent = this.txtTimKiemNCC;
            this.txtTimKiemNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemNCC.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiemNCC.FocusedState.Parent = this.txtTimKiemNCC;
            this.txtTimKiemNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNCC.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemNCC.HoverState.Parent = this.txtTimKiemNCC;
            this.txtTimKiemNCC.Location = new System.Drawing.Point(217, 169);
            this.txtTimKiemNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiemNCC.Name = "txtTimKiemNCC";
            this.txtTimKiemNCC.PasswordChar = '\0';
            this.txtTimKiemNCC.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemNCC.PlaceholderText = "Nhập Nhà Cung Cấp Cần Tìm";
            this.txtTimKiemNCC.SelectedText = "";
            this.txtTimKiemNCC.ShadowDecoration.Parent = this.txtTimKiemNCC;
            this.txtTimKiemNCC.Size = new System.Drawing.Size(264, 30);
            this.txtTimKiemNCC.TabIndex = 31;
            this.txtTimKiemNCC.TextOffset = new System.Drawing.Point(8, 0);
            this.txtTimKiemNCC.TextChanged += new System.EventHandler(this.txtTimKiemNCC_TextChanged);
            this.txtTimKiemNCC.Leave += new System.EventHandler(this.txtTimKiemNCC_Leave);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.BackColor = System.Drawing.Color.White;
            this.txtNhanVien.BorderColor = System.Drawing.Color.Gray;
            this.txtNhanVien.BorderRadius = 5;
            this.txtNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhanVien.DefaultText = "";
            this.txtNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhanVien.DisabledState.Parent = this.txtNhanVien;
            this.txtNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhanVien.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtNhanVien.FocusedState.Parent = this.txtNhanVien;
            this.txtNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhanVien.HoverState.Parent = this.txtNhanVien;
            this.txtNhanVien.Location = new System.Drawing.Point(217, 129);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.PasswordChar = '\0';
            this.txtNhanVien.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNhanVien.PlaceholderText = "Nhân Viên Lập";
            this.txtNhanVien.SelectedText = "";
            this.txtNhanVien.ShadowDecoration.Parent = this.txtNhanVien;
            this.txtNhanVien.Size = new System.Drawing.Size(264, 30);
            this.txtNhanVien.TabIndex = 31;
            this.txtNhanVien.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(49, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nhân Viên Lập";
            // 
            // txtMaDDT
            // 
            this.txtMaDDT.BackColor = System.Drawing.Color.White;
            this.txtMaDDT.BorderColor = System.Drawing.Color.Gray;
            this.txtMaDDT.BorderRadius = 5;
            this.txtMaDDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDDT.DefaultText = "";
            this.txtMaDDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDDT.DisabledState.Parent = this.txtMaDDT;
            this.txtMaDDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDDT.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtMaDDT.FocusedState.Parent = this.txtMaDDT;
            this.txtMaDDT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDDT.ForeColor = System.Drawing.Color.Black;
            this.txtMaDDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDDT.HoverState.Parent = this.txtMaDDT;
            this.txtMaDDT.Location = new System.Drawing.Point(217, 50);
            this.txtMaDDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDDT.Name = "txtMaDDT";
            this.txtMaDDT.PasswordChar = '\0';
            this.txtMaDDT.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaDDT.PlaceholderText = "Mã Đơn Đặt";
            this.txtMaDDT.SelectedText = "";
            this.txtMaDDT.ShadowDecoration.Parent = this.txtMaDDT;
            this.txtMaDDT.Size = new System.Drawing.Size(264, 30);
            this.txtMaDDT.TabIndex = 33;
            this.txtMaDDT.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã Đơn Đặt";
            // 
            // lsvDonDat
            // 
            this.lsvDonDat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvDonDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.lsvDonDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvDonDat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MA_DONDAT,
            this.TEN_NHANVIEN,
            this.MA_NCC,
            this.NGAY_LAP});
            this.lsvDonDat.FullRowSelect = true;
            this.lsvDonDat.GridLines = true;
            this.lsvDonDat.HideSelection = false;
            this.lsvDonDat.Location = new System.Drawing.Point(0, 363);
            this.lsvDonDat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvDonDat.Name = "lsvDonDat";
            this.lsvDonDat.Size = new System.Drawing.Size(736, 459);
            this.lsvDonDat.TabIndex = 2;
            this.lsvDonDat.UseCompatibleStateImageBehavior = false;
            this.lsvDonDat.View = System.Windows.Forms.View.Details;
            this.lsvDonDat.SelectedIndexChanged += new System.EventHandler(this.lsvDonDat_SelectedIndexChanged);
            // 
            // MA_DONDAT
            // 
            this.MA_DONDAT.Text = "Mã Đơn Đặt";
            this.MA_DONDAT.Width = 200;
            // 
            // TEN_NHANVIEN
            // 
            this.TEN_NHANVIEN.Text = "Tên Nhân Viên";
            this.TEN_NHANVIEN.Width = 200;
            // 
            // MA_NCC
            // 
            this.MA_NCC.Text = "Mã Nhà Cung Cấp";
            this.MA_NCC.Width = 200;
            // 
            // NGAY_LAP
            // 
            this.NGAY_LAP.Text = "Ngày Lập";
            this.NGAY_LAP.Width = 200;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.White;
            this.btnIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIn.BorderRadius = 5;
            this.btnIn.BorderThickness = 1;
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.Enabled = false;
            this.btnIn.FillColor = System.Drawing.Color.Transparent;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIn.HoverState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnIn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIn.HoverState.Parent = this.btnIn;
            this.btnIn.Location = new System.Drawing.Point(552, 259);
            this.btnIn.Name = "btnIn";
            this.btnIn.ShadowDecoration.Parent = this.btnIn;
            this.btnIn.Size = new System.Drawing.Size(105, 41);
            this.btnIn.TabIndex = 41;
            this.btnIn.Text = "In Đơn Đặt";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FrmDDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 825);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDDT";
            this.Text = "Đơn Đặt Thuốc";
            this.Load += new System.EventHandler(this.FrmDDT_Load);
            this.gbCTDD.ResumeLayout(false);
            this.gbCTDD.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbHoaDon.ResumeLayout(false);
            this.gbHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSua;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.ColumnHeader SO_LUONG;
        private System.Windows.Forms.ColumnHeader TEN_THUOC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lsvCTDD;
        private Guna.UI2.WinForms.Guna2GroupBox gbCTDD;
        private Guna.UI2.WinForms.Guna2Button btnXoaThuoc;
        private Guna.UI2.WinForms.Guna2Button btnThemThuoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboThuoc;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemThuoc;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox gbHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnTaoDD;
        private Guna.UI2.WinForms.Guna2ComboBox cboNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvDonDat;
        private System.Windows.Forms.ColumnHeader MA_DONDAT;
        private System.Windows.Forms.ColumnHeader TEN_NHANVIEN;
        private System.Windows.Forms.ColumnHeader MA_NCC;
        private System.Windows.Forms.ColumnHeader NGAY_LAP;
        private Guna.UI2.WinForms.Guna2Button btnIn;
    }
}