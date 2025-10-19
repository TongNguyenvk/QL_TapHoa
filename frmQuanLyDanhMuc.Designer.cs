namespace TapHoa
{
    partial class frmQuanLyDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.tabLoaiHang = new System.Windows.Forms.TabPage();
            this.tabNhaCungCap = new System.Windows.Forms.TabPage();
            
            // Tab Sản phẩm controls
            this.panelLeftSP = new System.Windows.Forms.Panel();
            this.panelRightSP = new System.Windows.Forms.Panel();
            this.grpThongTinSP = new System.Windows.Forms.GroupBox();
            this.grpChucNangSP = new System.Windows.Forms.GroupBox();
            
            this.lblTenHang = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.numDonGiaBan = new System.Windows.Forms.NumericUpDown();
            this.lblMoTaSP = new System.Windows.Forms.Label();
            this.txtMoTaSP = new System.Windows.Forms.TextBox();
            
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnLuuSP = new System.Windows.Forms.Button();
            this.btnBoQuaSP = new System.Windows.Forms.Button();
            
            this.txtTimKiemSP = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            
            // Tab Loại hàng controls
            this.panelLeftLH = new System.Windows.Forms.Panel();
            this.panelRightLH = new System.Windows.Forms.Panel();
            this.grpThongTinLH = new System.Windows.Forms.GroupBox();
            this.grpChucNangLH = new System.Windows.Forms.GroupBox();
            
            this.lblTenLoaiHang = new System.Windows.Forms.Label();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.lblMoTaLH = new System.Windows.Forms.Label();
            this.txtMoTaLH = new System.Windows.Forms.TextBox();
            
            this.btnThemLH = new System.Windows.Forms.Button();
            this.btnSuaLH = new System.Windows.Forms.Button();
            this.btnXoaLH = new System.Windows.Forms.Button();
            this.btnLuuLH = new System.Windows.Forms.Button();
            this.btnBoQuaLH = new System.Windows.Forms.Button();
            
            this.txtTimKiemLH = new System.Windows.Forms.TextBox();
            this.dgvLoaiHang = new System.Windows.Forms.DataGridView();
            
            // Tab Nhà cung cấp controls
            this.panelLeftNCC = new System.Windows.Forms.Panel();
            this.panelRightNCC = new System.Windows.Forms.Panel();
            this.grpThongTinNCC = new System.Windows.Forms.GroupBox();
            this.grpChucNangNCC = new System.Windows.Forms.GroupBox();
            
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnLuuNCC = new System.Windows.Forms.Button();
            this.btnBoQuaNCC = new System.Windows.Forms.Button();
            
            this.txtTimKiemNCC = new System.Windows.Forms.TextBox();
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            
            this.tabControl.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            this.tabLoaiHang.SuspendLayout();
            this.tabNhaCungCap.SuspendLayout();
            this.panelLeftSP.SuspendLayout();
            this.panelRightSP.SuspendLayout();
            this.grpThongTinSP.SuspendLayout();
            this.grpChucNangSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panelLeftLH.SuspendLayout();
            this.panelRightLH.SuspendLayout();
            this.grpThongTinLH.SuspendLayout();
            this.grpChucNangLH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).BeginInit();
            this.panelLeftNCC.SuspendLayout();
            this.panelRightNCC.SuspendLayout();
            this.grpThongTinNCC.SuspendLayout();
            this.grpChucNangNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.SuspendLayout();
            
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSanPham);
            this.tabControl.Controls.Add(this.tabLoaiHang);
            this.tabControl.Controls.Add(this.tabNhaCungCap);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1200, 700);
            this.tabControl.TabIndex = 0;
            
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.panelRightSP);
            this.tabSanPham.Controls.Add(this.panelLeftSP);
            this.tabSanPham.Location = new System.Drawing.Point(4, 26);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(10);
            this.tabSanPham.Size = new System.Drawing.Size(1192, 670);
            this.tabSanPham.TabIndex = 0;
            this.tabSanPham.Text = "Quản lý Sản phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            
            // 
            // panelLeftSP
            // 
            this.panelLeftSP.Controls.Add(this.grpChucNangSP);
            this.panelLeftSP.Controls.Add(this.grpThongTinSP);
            this.panelLeftSP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSP.Location = new System.Drawing.Point(10, 10);
            this.panelLeftSP.Name = "panelLeftSP";
            this.panelLeftSP.Size = new System.Drawing.Size(350, 650);
            this.panelLeftSP.TabIndex = 0;
            
            // 
            // grpThongTinSP
            // 
            this.grpThongTinSP.Controls.Add(this.lblTenHang);
            this.grpThongTinSP.Controls.Add(this.txtTenHang);
            this.grpThongTinSP.Controls.Add(this.lblLoaiHang);
            this.grpThongTinSP.Controls.Add(this.cboLoaiHang);
            this.grpThongTinSP.Controls.Add(this.lblSoLuong);
            this.grpThongTinSP.Controls.Add(this.numSoLuong);
            this.grpThongTinSP.Controls.Add(this.lblDonGiaBan);
            this.grpThongTinSP.Controls.Add(this.numDonGiaBan);
            this.grpThongTinSP.Controls.Add(this.lblMoTaSP);
            this.grpThongTinSP.Controls.Add(this.txtMoTaSP);
            this.grpThongTinSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTinSP.BackColor = System.Drawing.Color.White;
            this.grpThongTinSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpThongTinSP.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.grpThongTinSP.Location = new System.Drawing.Point(0, 0);
            this.grpThongTinSP.Name = "grpThongTinSP";
            this.grpThongTinSP.Padding = new System.Windows.Forms.Padding(15);
            this.grpThongTinSP.Size = new System.Drawing.Size(350, 380);
            this.grpThongTinSP.TabIndex = 0;
            this.grpThongTinSP.TabStop = false;
            this.grpThongTinSP.Text = "Thông tin chi tiết";
            
            // lblTenHang
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTenHang.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblTenHang.Location = new System.Drawing.Point(18, 35);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(70, 17);
            this.lblTenHang.TabIndex = 0;
            this.lblTenHang.Text = "Tên hàng:";
            
            // txtTenHang
            this.txtTenHang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenHang.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtTenHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenHang.Location = new System.Drawing.Point(18, 55);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(314, 25);
            this.txtTenHang.TabIndex = 1;
            
            // lblLoaiHang
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLoaiHang.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblLoaiHang.Location = new System.Drawing.Point(18, 90);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(73, 17);
            this.lblLoaiHang.TabIndex = 2;
            this.lblLoaiHang.Text = "Loại hàng:";
            
            // cboLoaiHang
            this.cboLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboLoaiHang.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(18, 110);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(314, 25);
            this.cboLoaiHang.TabIndex = 3;
            
            // lblSoLuong
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblSoLuong.Location = new System.Drawing.Point(18, 145);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(68, 17);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng:";
            
            // numSoLuong
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numSoLuong.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.numSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSoLuong.Location = new System.Drawing.Point(18, 165);
            this.numSoLuong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(314, 25);
            this.numSoLuong.TabIndex = 5;
            
            // lblDonGiaBan
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDonGiaBan.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblDonGiaBan.Location = new System.Drawing.Point(18, 200);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(60, 17);
            this.lblDonGiaBan.TabIndex = 6;
            this.lblDonGiaBan.Text = "Giá bán:";
            
            // numDonGiaBan
            this.numDonGiaBan.DecimalPlaces = 0;
            this.numDonGiaBan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numDonGiaBan.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.numDonGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDonGiaBan.Location = new System.Drawing.Point(18, 220);
            this.numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numDonGiaBan.Name = "numDonGiaBan";
            this.numDonGiaBan.Size = new System.Drawing.Size(314, 25);
            this.numDonGiaBan.TabIndex = 7;
            this.numDonGiaBan.ThousandsSeparator = true;
            
            // lblMoTaSP
            this.lblMoTaSP.AutoSize = true;
            this.lblMoTaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMoTaSP.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblMoTaSP.Location = new System.Drawing.Point(18, 255);
            this.lblMoTaSP.Name = "lblMoTaSP";
            this.lblMoTaSP.Size = new System.Drawing.Size(50, 17);
            this.lblMoTaSP.TabIndex = 8;
            this.lblMoTaSP.Text = "Mô tả:";
            
            // txtMoTaSP
            this.txtMoTaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMoTaSP.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtMoTaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTaSP.Location = new System.Drawing.Point(18, 275);
            this.txtMoTaSP.Multiline = true;
            this.txtMoTaSP.Name = "txtMoTaSP";
            this.txtMoTaSP.Size = new System.Drawing.Size(314, 80);
            this.txtMoTaSP.TabIndex = 9;
            
            // 
            // grpChucNangSP
            // 
            this.grpChucNangSP.Controls.Add(this.btnThemSP);
            this.grpChucNangSP.Controls.Add(this.btnSuaSP);
            this.grpChucNangSP.Controls.Add(this.btnXoaSP);
            this.grpChucNangSP.Controls.Add(this.btnLuuSP);
            this.grpChucNangSP.Controls.Add(this.btnBoQuaSP);
            this.grpChucNangSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChucNangSP.Location = new System.Drawing.Point(0, 390);
            this.grpChucNangSP.Name = "grpChucNangSP";
            this.grpChucNangSP.Padding = new System.Windows.Forms.Padding(10);
            this.grpChucNangSP.Size = new System.Drawing.Size(350, 170);
            this.grpChucNangSP.TabIndex = 1;
            this.grpChucNangSP.TabStop = false;
            this.grpChucNangSP.Text = "Chức năng";
            
            // btnThemSP
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(15, 30);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(320, 38);
            this.btnThemSP.TabIndex = 0;
            this.btnThemSP.Text = "➕ Thêm";
            this.btnThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            
            // btnSuaSP
            this.btnSuaSP.BackColor = System.Drawing.Color.FromArgb(90, 98, 104);
            this.btnSuaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSP.FlatAppearance.BorderSize = 0;
            this.btnSuaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSuaSP.ForeColor = System.Drawing.Color.White;
            this.btnSuaSP.Location = new System.Drawing.Point(15, 75);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(155, 38);
            this.btnSuaSP.TabIndex = 1;
            this.btnSuaSP.Text = "✏️ Sửa";
            this.btnSuaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            
            // btnXoaSP
            this.btnXoaSP.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.FlatAppearance.BorderSize = 0;
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(180, 75);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(155, 38);
            this.btnXoaSP.TabIndex = 2;
            this.btnXoaSP.Text = "🗑️ Xóa";
            this.btnXoaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            
            // btnLuuSP
            this.btnLuuSP.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnLuuSP.Enabled = false;
            this.btnLuuSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuSP.FlatAppearance.BorderSize = 0;
            this.btnLuuSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuuSP.ForeColor = System.Drawing.Color.White;
            this.btnLuuSP.Location = new System.Drawing.Point(15, 120);
            this.btnLuuSP.Name = "btnLuuSP";
            this.btnLuuSP.Size = new System.Drawing.Size(155, 38);
            this.btnLuuSP.TabIndex = 3;
            this.btnLuuSP.Text = "💾 Lưu";
            this.btnLuuSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuSP.UseVisualStyleBackColor = false;
            this.btnLuuSP.Click += new System.EventHandler(this.btnLuuSP_Click);
            
            // btnBoQuaSP
            this.btnBoQuaSP.BackColor = System.Drawing.Color.FromArgb(90, 98, 104);
            this.btnBoQuaSP.Enabled = false;
            this.btnBoQuaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQuaSP.FlatAppearance.BorderSize = 0;
            this.btnBoQuaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBoQuaSP.ForeColor = System.Drawing.Color.White;
            this.btnBoQuaSP.Location = new System.Drawing.Point(180, 120);
            this.btnBoQuaSP.Name = "btnBoQuaSP";
            this.btnBoQuaSP.Size = new System.Drawing.Size(155, 38);
            this.btnBoQuaSP.TabIndex = 4;
            this.btnBoQuaSP.Text = "↩️ Bỏ qua";
            this.btnBoQuaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoQuaSP.UseVisualStyleBackColor = false;
            this.btnBoQuaSP.Click += new System.EventHandler(this.btnBoQuaSP_Click);
            
            // 
            // panelRightSP
            // 
            this.panelRightSP.Controls.Add(this.dgvSanPham);
            this.panelRightSP.Controls.Add(this.txtTimKiemSP);
            this.panelRightSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSP.Location = new System.Drawing.Point(360, 10);
            this.panelRightSP.Name = "panelRightSP";
            this.panelRightSP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelRightSP.Size = new System.Drawing.Size(822, 650);
            this.panelRightSP.TabIndex = 1;
            
            // txtTimKiemSP
            this.txtTimKiemSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiemSP.Location = new System.Drawing.Point(10, 0);
            this.txtTimKiemSP.Name = "txtTimKiemSP";
            this.txtTimKiemSP.Size = new System.Drawing.Size(812, 25);
            this.txtTimKiemSP.TabIndex = 0;
            this.txtTimKiemSP.Text = "🔍 Tìm kiếm sản phẩm...";
            this.txtTimKiemSP.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemSP.Enter += new System.EventHandler(this.txtTimKiemSP_Enter);
            this.txtTimKiemSP.Leave += new System.EventHandler(this.txtTimKiemSP_Leave);
            this.txtTimKiemSP.TextChanged += new System.EventHandler(this.txtTimKiemSP_TextChanged);
            
            // dgvSanPham
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.dgvSanPham.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSanPham.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvSanPham.ColumnHeadersHeight = 40;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.Location = new System.Drawing.Point(10, 25);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(212, 237, 218);
            this.dgvSanPham.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvSanPham.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvSanPham.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvSanPham.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvSanPham.RowTemplate.Height = 35;
            this.dgvSanPham.Size = new System.Drawing.Size(812, 625);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            
            // 
            // tabLoaiHang
            // 
            this.tabLoaiHang.Controls.Add(this.panelRightLH);
            this.tabLoaiHang.Controls.Add(this.panelLeftLH);
            this.tabLoaiHang.Location = new System.Drawing.Point(4, 26);
            this.tabLoaiHang.Name = "tabLoaiHang";
            this.tabLoaiHang.Padding = new System.Windows.Forms.Padding(10);
            this.tabLoaiHang.Size = new System.Drawing.Size(1192, 670);
            this.tabLoaiHang.TabIndex = 1;
            this.tabLoaiHang.Text = "Quản lý Loại hàng";
            this.tabLoaiHang.UseVisualStyleBackColor = true;
            
            // panelLeftLH
            this.panelLeftLH.Controls.Add(this.grpChucNangLH);
            this.panelLeftLH.Controls.Add(this.grpThongTinLH);
            this.panelLeftLH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftLH.Location = new System.Drawing.Point(10, 10);
            this.panelLeftLH.Name = "panelLeftLH";
            this.panelLeftLH.Size = new System.Drawing.Size(350, 650);
            this.panelLeftLH.TabIndex = 0;
            
            // grpThongTinLH
            this.grpThongTinLH.Controls.Add(this.lblTenLoaiHang);
            this.grpThongTinLH.Controls.Add(this.txtTenLoaiHang);
            this.grpThongTinLH.Controls.Add(this.lblMoTaLH);
            this.grpThongTinLH.Controls.Add(this.txtMoTaLH);
            this.grpThongTinLH.BackColor = System.Drawing.Color.White;
            this.grpThongTinLH.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTinLH.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpThongTinLH.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.grpThongTinLH.Location = new System.Drawing.Point(0, 0);
            this.grpThongTinLH.Name = "grpThongTinLH";
            this.grpThongTinLH.Padding = new System.Windows.Forms.Padding(15);
            this.grpThongTinLH.Size = new System.Drawing.Size(350, 250);
            this.grpThongTinLH.TabIndex = 0;
            this.grpThongTinLH.TabStop = false;
            this.grpThongTinLH.Text = "Thông tin chi tiết";
            
            // lblTenLoaiHang
            this.lblTenLoaiHang.AutoSize = true;
            this.lblTenLoaiHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTenLoaiHang.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblTenLoaiHang.Location = new System.Drawing.Point(18, 35);
            this.lblTenLoaiHang.Name = "lblTenLoaiHang";
            this.lblTenLoaiHang.Size = new System.Drawing.Size(96, 17);
            this.lblTenLoaiHang.TabIndex = 0;
            this.lblTenLoaiHang.Text = "Tên loại hàng:";
            
            // txtTenLoaiHang
            this.txtTenLoaiHang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenLoaiHang.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtTenLoaiHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiHang.Location = new System.Drawing.Point(18, 55);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(314, 25);
            this.txtTenLoaiHang.TabIndex = 1;
            
            // lblMoTaLH
            this.lblMoTaLH.AutoSize = true;
            this.lblMoTaLH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMoTaLH.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblMoTaLH.Location = new System.Drawing.Point(18, 90);
            this.lblMoTaLH.Name = "lblMoTaLH";
            this.lblMoTaLH.Size = new System.Drawing.Size(50, 17);
            this.lblMoTaLH.TabIndex = 2;
            this.lblMoTaLH.Text = "Mô tả:";
            
            // txtMoTaLH
            this.txtMoTaLH.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMoTaLH.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtMoTaLH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTaLH.Location = new System.Drawing.Point(18, 110);
            this.txtMoTaLH.Multiline = true;
            this.txtMoTaLH.Name = "txtMoTaLH";
            this.txtMoTaLH.Size = new System.Drawing.Size(314, 110);
            this.txtMoTaLH.TabIndex = 3;
            
            // grpChucNangLH
            this.grpChucNangLH.Controls.Add(this.btnThemLH);
            this.grpChucNangLH.Controls.Add(this.btnSuaLH);
            this.grpChucNangLH.Controls.Add(this.btnXoaLH);
            this.grpChucNangLH.Controls.Add(this.btnLuuLH);
            this.grpChucNangLH.Controls.Add(this.btnBoQuaLH);
            this.grpChucNangLH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChucNangLH.Location = new System.Drawing.Point(0, 260);
            this.grpChucNangLH.Name = "grpChucNangLH";
            this.grpChucNangLH.Padding = new System.Windows.Forms.Padding(10);
            this.grpChucNangLH.Size = new System.Drawing.Size(350, 170);
            this.grpChucNangLH.TabIndex = 1;
            this.grpChucNangLH.TabStop = false;
            this.grpChucNangLH.Text = "Chức năng";
            
            // btnThemLH
            this.btnThemLH.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnThemLH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemLH.ForeColor = System.Drawing.Color.White;
            this.btnThemLH.Location = new System.Drawing.Point(15, 30);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(320, 38);
            this.btnThemLH.TabIndex = 0;
            this.btnThemLH.Text = "➕ Thêm";
            this.btnThemLH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThemLH.FlatAppearance.BorderSize = 0;
            this.btnThemLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLH.UseVisualStyleBackColor = false;
            this.btnThemLH.Click += new System.EventHandler(this.btnThemLH_Click);
            
            // btnSuaLH
            this.btnSuaLH.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnSuaLH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaLH.ForeColor = System.Drawing.Color.White;
            this.btnSuaLH.Location = new System.Drawing.Point(15, 70);
            this.btnSuaLH.Name = "btnSuaLH";
            this.btnSuaLH.Size = new System.Drawing.Size(155, 38);
            this.btnSuaLH.TabIndex = 1;
            this.btnSuaLH.Text = "✏️ Sửa";
            this.btnSuaLH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSuaLH.BackColor = System.Drawing.Color.FromArgb(90, 98, 104);
            this.btnSuaLH.FlatAppearance.BorderSize = 0;
            this.btnSuaLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaLH.UseVisualStyleBackColor = false;
            this.btnSuaLH.Click += new System.EventHandler(this.btnSuaLH_Click);
            
            // btnXoaLH
            this.btnXoaLH.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnXoaLH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaLH.ForeColor = System.Drawing.Color.White;
            this.btnXoaLH.Location = new System.Drawing.Point(180, 70);
            this.btnXoaLH.Name = "btnXoaLH";
            this.btnXoaLH.Size = new System.Drawing.Size(155, 38);
            this.btnXoaLH.TabIndex = 2;
            this.btnXoaLH.Text = "🗑️ Xóa";
            this.btnXoaLH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaLH.FlatAppearance.BorderSize = 0;
            this.btnXoaLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLH.UseVisualStyleBackColor = false;
            this.btnXoaLH.Click += new System.EventHandler(this.btnXoaLH_Click);
            
            // btnLuuLH
            this.btnLuuLH.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnLuuLH.Enabled = false;
            this.btnLuuLH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuLH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuLH.ForeColor = System.Drawing.Color.White;
            this.btnLuuLH.Location = new System.Drawing.Point(15, 110);
            this.btnLuuLH.Name = "btnLuuLH";
            this.btnLuuLH.Size = new System.Drawing.Size(155, 38);
            this.btnLuuLH.TabIndex = 3;
            this.btnLuuLH.Text = "💾 Lưu";
            this.btnLuuLH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuuLH.FlatAppearance.BorderSize = 0;
            this.btnLuuLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuLH.UseVisualStyleBackColor = false;
            this.btnLuuLH.Click += new System.EventHandler(this.btnLuuLH_Click);
            
            // btnBoQuaLH
            this.btnBoQuaLH.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnBoQuaLH.Enabled = false;
            this.btnBoQuaLH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQuaLH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBoQuaLH.ForeColor = System.Drawing.Color.White;
            this.btnBoQuaLH.Location = new System.Drawing.Point(180, 110);
            this.btnBoQuaLH.Name = "btnBoQuaLH";
            this.btnBoQuaLH.Size = new System.Drawing.Size(155, 38);
            this.btnBoQuaLH.TabIndex = 4;
            this.btnBoQuaLH.Text = "↩️ Bỏ qua";
            this.btnBoQuaLH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBoQuaLH.BackColor = System.Drawing.Color.FromArgb(90, 98, 104);
            this.btnBoQuaLH.FlatAppearance.BorderSize = 0;
            this.btnBoQuaLH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoQuaLH.UseVisualStyleBackColor = false;
            this.btnBoQuaLH.Click += new System.EventHandler(this.btnBoQuaLH_Click);
            
            // panelRightLH
            this.panelRightLH.Controls.Add(this.dgvLoaiHang);
            this.panelRightLH.Controls.Add(this.txtTimKiemLH);
            this.panelRightLH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightLH.Location = new System.Drawing.Point(360, 10);
            this.panelRightLH.Name = "panelRightLH";
            this.panelRightLH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelRightLH.Size = new System.Drawing.Size(822, 650);
            this.panelRightLH.TabIndex = 1;
            
            // txtTimKiemLH
            this.txtTimKiemLH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTimKiemLH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiemLH.Location = new System.Drawing.Point(10, 0);
            this.txtTimKiemLH.Name = "txtTimKiemLH";
            this.txtTimKiemLH.Size = new System.Drawing.Size(812, 25);
            this.txtTimKiemLH.TabIndex = 0;
            this.txtTimKiemLH.Text = "🔍 Tìm kiếm loại hàng...";
            this.txtTimKiemLH.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemLH.Enter += new System.EventHandler(this.txtTimKiemLH_Enter);
            this.txtTimKiemLH.Leave += new System.EventHandler(this.txtTimKiemLH_Leave);
            this.txtTimKiemLH.TextChanged += new System.EventHandler(this.txtTimKiemLH_TextChanged);
            
            // dgvLoaiHang
            this.dgvLoaiHang.AllowUserToAddRows = false;
            this.dgvLoaiHang.AllowUserToDeleteRows = false;
            this.dgvLoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiHang.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.dgvLoaiHang.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLoaiHang.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvLoaiHang.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvLoaiHang.ColumnHeadersHeight = 40;
            this.dgvLoaiHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiHang.EnableHeadersVisualStyles = false;
            this.dgvLoaiHang.Location = new System.Drawing.Point(10, 25);
            this.dgvLoaiHang.MultiSelect = false;
            this.dgvLoaiHang.Name = "dgvLoaiHang";
            this.dgvLoaiHang.ReadOnly = true;
            this.dgvLoaiHang.RowHeadersVisible = false;
            this.dgvLoaiHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiHang.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(212, 237, 218);
            this.dgvLoaiHang.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvLoaiHang.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvLoaiHang.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvLoaiHang.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvLoaiHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoaiHang.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvLoaiHang.RowTemplate.Height = 35;
            this.dgvLoaiHang.Size = new System.Drawing.Size(812, 625);
            this.dgvLoaiHang.TabIndex = 1;
            this.dgvLoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiHang_CellClick);
            
            // 
            // tabNhaCungCap
            // 
            this.tabNhaCungCap.Controls.Add(this.panelRightNCC);
            this.tabNhaCungCap.Controls.Add(this.panelLeftNCC);
            this.tabNhaCungCap.Location = new System.Drawing.Point(4, 26);
            this.tabNhaCungCap.Name = "tabNhaCungCap";
            this.tabNhaCungCap.Padding = new System.Windows.Forms.Padding(10);
            this.tabNhaCungCap.Size = new System.Drawing.Size(1192, 670);
            this.tabNhaCungCap.TabIndex = 2;
            this.tabNhaCungCap.Text = "Quản lý Nhà cung cấp";
            this.tabNhaCungCap.UseVisualStyleBackColor = true;
            
            // panelLeftNCC
            this.panelLeftNCC.Controls.Add(this.grpChucNangNCC);
            this.panelLeftNCC.Controls.Add(this.grpThongTinNCC);
            this.panelLeftNCC.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNCC.Location = new System.Drawing.Point(10, 10);
            this.panelLeftNCC.Name = "panelLeftNCC";
            this.panelLeftNCC.Size = new System.Drawing.Size(350, 650);
            this.panelLeftNCC.TabIndex = 0;
            
            // grpThongTinNCC
            this.grpThongTinNCC.Controls.Add(this.lblTenNCC);
            this.grpThongTinNCC.Controls.Add(this.txtTenNCC);
            this.grpThongTinNCC.Controls.Add(this.lblDiaChi);
            this.grpThongTinNCC.Controls.Add(this.txtDiaChi);
            this.grpThongTinNCC.Controls.Add(this.lblSDT);
            this.grpThongTinNCC.Controls.Add(this.txtSDT);
            this.grpThongTinNCC.BackColor = System.Drawing.Color.White;
            this.grpThongTinNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTinNCC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpThongTinNCC.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.grpThongTinNCC.Location = new System.Drawing.Point(0, 0);
            this.grpThongTinNCC.Name = "grpThongTinNCC";
            this.grpThongTinNCC.Padding = new System.Windows.Forms.Padding(15);
            this.grpThongTinNCC.Size = new System.Drawing.Size(350, 300);
            this.grpThongTinNCC.TabIndex = 0;
            this.grpThongTinNCC.TabStop = false;
            this.grpThongTinNCC.Text = "Thông tin chi tiết";
            
            // lblTenNCC
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTenNCC.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblTenNCC.Location = new System.Drawing.Point(18, 35);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(125, 17);
            this.lblTenNCC.TabIndex = 0;
            this.lblTenNCC.Text = "Tên nhà cung cấp:";
            
            // txtTenNCC
            this.txtTenNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTenNCC.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtTenNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNCC.Location = new System.Drawing.Point(18, 55);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(314, 25);
            this.txtTenNCC.TabIndex = 1;
            
            // lblDiaChi
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblDiaChi.Location = new System.Drawing.Point(18, 90);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(54, 17);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ:";
            
            // txtDiaChi
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Location = new System.Drawing.Point(18, 110);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(314, 60);
            this.txtDiaChi.TabIndex = 3;
            
            // lblSDT
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSDT.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblSDT.Location = new System.Drawing.Point(18, 180);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 17);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số điện thoại:";
            
            // txtSDT
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Location = new System.Drawing.Point(18, 200);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(314, 25);
            this.txtSDT.TabIndex = 5;
            
            // grpChucNangNCC
            this.grpChucNangNCC.Controls.Add(this.btnThemNCC);
            this.grpChucNangNCC.Controls.Add(this.btnSuaNCC);
            this.grpChucNangNCC.Controls.Add(this.btnXoaNCC);
            this.grpChucNangNCC.Controls.Add(this.btnLuuNCC);
            this.grpChucNangNCC.Controls.Add(this.btnBoQuaNCC);
            this.grpChucNangNCC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChucNangNCC.Location = new System.Drawing.Point(0, 310);
            this.grpChucNangNCC.Name = "grpChucNangNCC";
            this.grpChucNangNCC.Padding = new System.Windows.Forms.Padding(10);
            this.grpChucNangNCC.Size = new System.Drawing.Size(350, 170);
            this.grpChucNangNCC.TabIndex = 1;
            this.grpChucNangNCC.TabStop = false;
            this.grpChucNangNCC.Text = "Chức năng";
            
            // btnThemNCC
            this.btnThemNCC.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNCC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemNCC.ForeColor = System.Drawing.Color.White;
            this.btnThemNCC.Location = new System.Drawing.Point(15, 30);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(320, 38);
            this.btnThemNCC.TabIndex = 0;
            this.btnThemNCC.Text = "➕ Thêm";
            this.btnThemNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThemNCC.FlatAppearance.BorderSize = 0;
            this.btnThemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            
            // btnSuaNCC
            this.btnSuaNCC.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnSuaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNCC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSuaNCC.ForeColor = System.Drawing.Color.White;
            this.btnSuaNCC.Location = new System.Drawing.Point(15, 70);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(155, 38);
            this.btnSuaNCC.TabIndex = 1;
            this.btnSuaNCC.Text = "✏️ Sửa";
            this.btnSuaNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSuaNCC.BackColor = System.Drawing.Color.FromArgb(90, 98, 104);
            this.btnSuaNCC.FlatAppearance.BorderSize = 0;
            this.btnSuaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNCC.UseVisualStyleBackColor = false;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSuaNCC_Click);
            
            // btnXoaNCC
            this.btnXoaNCC.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnXoaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNCC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaNCC.ForeColor = System.Drawing.Color.White;
            this.btnXoaNCC.Location = new System.Drawing.Point(180, 70);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(155, 38);
            this.btnXoaNCC.TabIndex = 2;
            this.btnXoaNCC.Text = "🗑️ Xóa";
            this.btnXoaNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaNCC.FlatAppearance.BorderSize = 0;
            this.btnXoaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNCC.UseVisualStyleBackColor = false;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            
            // btnLuuNCC
            this.btnLuuNCC.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnLuuNCC.Enabled = false;
            this.btnLuuNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuNCC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuNCC.ForeColor = System.Drawing.Color.White;
            this.btnLuuNCC.Location = new System.Drawing.Point(15, 110);
            this.btnLuuNCC.Name = "btnLuuNCC";
            this.btnLuuNCC.Size = new System.Drawing.Size(155, 38);
            this.btnLuuNCC.TabIndex = 3;
            this.btnLuuNCC.Text = "💾 Lưu";
            this.btnLuuNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuuNCC.FlatAppearance.BorderSize = 0;
            this.btnLuuNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuNCC.UseVisualStyleBackColor = false;
            this.btnLuuNCC.Click += new System.EventHandler(this.btnLuuNCC_Click);
            
            // btnBoQuaNCC
            this.btnBoQuaNCC.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnBoQuaNCC.Enabled = false;
            this.btnBoQuaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQuaNCC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBoQuaNCC.ForeColor = System.Drawing.Color.White;
            this.btnBoQuaNCC.Location = new System.Drawing.Point(180, 110);
            this.btnBoQuaNCC.Name = "btnBoQuaNCC";
            this.btnBoQuaNCC.Size = new System.Drawing.Size(155, 38);
            this.btnBoQuaNCC.TabIndex = 4;
            this.btnBoQuaNCC.Text = "↩️ Bỏ qua";
            this.btnBoQuaNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBoQuaNCC.BackColor = System.Drawing.Color.FromArgb(90, 98, 104);
            this.btnBoQuaNCC.FlatAppearance.BorderSize = 0;
            this.btnBoQuaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoQuaNCC.UseVisualStyleBackColor = false;
            this.btnBoQuaNCC.Click += new System.EventHandler(this.btnBoQuaNCC_Click);
            
            // panelRightNCC
            this.panelRightNCC.Controls.Add(this.dgvNhaCungCap);
            this.panelRightNCC.Controls.Add(this.txtTimKiemNCC);
            this.panelRightNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightNCC.Location = new System.Drawing.Point(360, 10);
            this.panelRightNCC.Name = "panelRightNCC";
            this.panelRightNCC.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelRightNCC.Size = new System.Drawing.Size(822, 650);
            this.panelRightNCC.TabIndex = 1;
            
            // txtTimKiemNCC
            this.txtTimKiemNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTimKiemNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiemNCC.Location = new System.Drawing.Point(10, 0);
            this.txtTimKiemNCC.Name = "txtTimKiemNCC";
            this.txtTimKiemNCC.Size = new System.Drawing.Size(812, 25);
            this.txtTimKiemNCC.TabIndex = 0;
            this.txtTimKiemNCC.Text = "🔍 Tìm kiếm nhà cung cấp...";
            this.txtTimKiemNCC.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemNCC.Enter += new System.EventHandler(this.txtTimKiemNCC_Enter);
            this.txtTimKiemNCC.Leave += new System.EventHandler(this.txtTimKiemNCC_Leave);
            this.txtTimKiemNCC.TextChanged += new System.EventHandler(this.txtTimKiemNCC_TextChanged);
            
            // dgvNhaCungCap
            this.dgvNhaCungCap.AllowUserToAddRows = false;
            this.dgvNhaCungCap.AllowUserToDeleteRows = false;
            this.dgvNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaCungCap.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhaCungCap.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhaCungCap.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.dgvNhaCungCap.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhaCungCap.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNhaCungCap.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvNhaCungCap.ColumnHeadersHeight = 40;
            this.dgvNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhaCungCap.EnableHeadersVisualStyles = false;
            this.dgvNhaCungCap.Location = new System.Drawing.Point(10, 25);
            this.dgvNhaCungCap.MultiSelect = false;
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.ReadOnly = true;
            this.dgvNhaCungCap.RowHeadersVisible = false;
            this.dgvNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaCungCap.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(212, 237, 218);
            this.dgvNhaCungCap.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvNhaCungCap.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvNhaCungCap.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvNhaCungCap.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvNhaCungCap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhaCungCap.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvNhaCungCap.RowTemplate.Height = 35;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(812, 625);
            this.dgvNhaCungCap.TabIndex = 1;
            this.dgvNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCap_CellClick);
            
            // 
            // frmQuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "frmQuanLyDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Danh mục";
            this.Load += new System.EventHandler(this.frmQuanLyDanhMuc_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            this.tabLoaiHang.ResumeLayout(false);
            this.tabNhaCungCap.ResumeLayout(false);
            this.panelLeftSP.ResumeLayout(false);
            this.panelRightSP.ResumeLayout(false);
            this.panelRightSP.PerformLayout();
            this.grpThongTinSP.ResumeLayout(false);
            this.grpThongTinSP.PerformLayout();
            this.grpChucNangSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panelLeftLH.ResumeLayout(false);
            this.panelRightLH.ResumeLayout(false);
            this.panelRightLH.PerformLayout();
            this.grpThongTinLH.ResumeLayout(false);
            this.grpThongTinLH.PerformLayout();
            this.grpChucNangLH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).EndInit();
            this.panelLeftNCC.ResumeLayout(false);
            this.panelRightNCC.ResumeLayout(false);
            this.panelRightNCC.PerformLayout();
            this.grpThongTinNCC.ResumeLayout(false);
            this.grpThongTinNCC.PerformLayout();
            this.grpChucNangNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabLoaiHang;
        private System.Windows.Forms.TabPage tabNhaCungCap;
        
        // Tab Sản phẩm
        private System.Windows.Forms.Panel panelLeftSP;
        private System.Windows.Forms.Panel panelRightSP;
        private System.Windows.Forms.GroupBox grpThongTinSP;
        private System.Windows.Forms.GroupBox grpChucNangSP;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.NumericUpDown numDonGiaBan;
        private System.Windows.Forms.Label lblMoTaSP;
        private System.Windows.Forms.TextBox txtMoTaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnLuuSP;
        private System.Windows.Forms.Button btnBoQuaSP;
        private System.Windows.Forms.TextBox txtTimKiemSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
        
        // Tab Loại hàng
        private System.Windows.Forms.Panel panelLeftLH;
        private System.Windows.Forms.Panel panelRightLH;
        private System.Windows.Forms.GroupBox grpThongTinLH;
        private System.Windows.Forms.GroupBox grpChucNangLH;
        private System.Windows.Forms.Label lblTenLoaiHang;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.Label lblMoTaLH;
        private System.Windows.Forms.TextBox txtMoTaLH;
        private System.Windows.Forms.Button btnThemLH;
        private System.Windows.Forms.Button btnSuaLH;
        private System.Windows.Forms.Button btnXoaLH;
        private System.Windows.Forms.Button btnLuuLH;
        private System.Windows.Forms.Button btnBoQuaLH;
        private System.Windows.Forms.TextBox txtTimKiemLH;
        private System.Windows.Forms.DataGridView dgvLoaiHang;
        
        // Tab Nhà cung cấp
        private System.Windows.Forms.Panel panelLeftNCC;
        private System.Windows.Forms.Panel panelRightNCC;
        private System.Windows.Forms.GroupBox grpThongTinNCC;
        private System.Windows.Forms.GroupBox grpChucNangNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Button btnSuaNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnLuuNCC;
        private System.Windows.Forms.Button btnBoQuaNCC;
        private System.Windows.Forms.TextBox txtTimKiemNCC;
        private System.Windows.Forms.DataGridView dgvNhaCungCap;
    }
}
