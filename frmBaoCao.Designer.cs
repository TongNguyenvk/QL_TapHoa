namespace TapHoa
{
    partial class frmBaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.pnlDoanhThu = new System.Windows.Forms.Panel();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.pnlTongDoanhThu = new System.Windows.Forms.Panel();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTongDoanhThuTitle = new System.Windows.Forms.Label();
            this.pnlFilterDoanhThu = new System.Windows.Forms.Panel();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.btnKetXuatDoanhThu = new System.Windows.Forms.Button();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.pnlTonKho = new System.Windows.Forms.Panel();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.pnlFilterTonKho = new System.Windows.Forms.Panel();
            this.btnKetXuatTonKho = new System.Windows.Forms.Button();
            this.btnXemTonKho = new System.Windows.Forms.Button();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.chartTopSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoanhThuTheoThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            
            this.tabControl.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            this.pnlDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.pnlTongDoanhThu.SuspendLayout();
            this.pnlFilterDoanhThu.SuspendLayout();
            this.tabTonKho.SuspendLayout();
            this.pnlTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.pnlFilterTonKho.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuTheoThang)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDashboard);
            this.tabControl.Controls.Add(this.tabDoanhThu);
            this.tabControl.Controls.Add(this.tabTonKho);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1180, 680);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);

            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.tabDoanhThu.Controls.Add(this.pnlDoanhThu);
            this.tabDoanhThu.Controls.Add(this.pnlTongDoanhThu);
            this.tabDoanhThu.Controls.Add(this.pnlFilterDoanhThu);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 26);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(10);
            this.tabDoanhThu.Size = new System.Drawing.Size(1172, 650);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "📊 Báo cáo Doanh thu";

            // 
            // pnlFilterDoanhThu
            // 
            this.pnlFilterDoanhThu.BackColor = System.Drawing.Color.White;
            this.pnlFilterDoanhThu.Controls.Add(this.btnKetXuatDoanhThu);
            this.pnlFilterDoanhThu.Controls.Add(this.btnXemBaoCao);
            this.pnlFilterDoanhThu.Controls.Add(this.cboNhanVien);
            this.pnlFilterDoanhThu.Controls.Add(this.lblNhanVien);
            this.pnlFilterDoanhThu.Controls.Add(this.dtpDenNgay);
            this.pnlFilterDoanhThu.Controls.Add(this.lblDenNgay);
            this.pnlFilterDoanhThu.Controls.Add(this.dtpTuNgay);
            this.pnlFilterDoanhThu.Controls.Add(this.lblTuNgay);
            this.pnlFilterDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterDoanhThu.Location = new System.Drawing.Point(10, 10);
            this.pnlFilterDoanhThu.Name = "pnlFilterDoanhThu";
            this.pnlFilterDoanhThu.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFilterDoanhThu.Size = new System.Drawing.Size(1152, 100);
            this.pnlFilterDoanhThu.TabIndex = 0;

            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblTuNgay.Location = new System.Drawing.Point(13, 15);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(56, 15);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";

            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(13, 35);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 23);
            this.dtpTuNgay.TabIndex = 1;

            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblDenNgay.Location = new System.Drawing.Point(230, 15);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(64, 15);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";

            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(230, 35);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 23);
            this.dtpDenNgay.TabIndex = 3;

            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblNhanVien.Location = new System.Drawing.Point(447, 15);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(105, 15);
            this.lblNhanVien.TabIndex = 4;
            this.lblNhanVien.Text = "Chọn nhân viên:";

            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(447, 35);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(250, 23);
            this.cboNhanVien.TabIndex = 5;

            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnXemBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(715, 30);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(150, 32);
            this.btnXemBaoCao.TabIndex = 6;
            this.btnXemBaoCao.Text = "📊 Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);

            // 
            // btnKetXuatDoanhThu
            // 
            this.btnKetXuatDoanhThu.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnKetXuatDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKetXuatDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetXuatDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnKetXuatDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKetXuatDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnKetXuatDoanhThu.Location = new System.Drawing.Point(880, 30);
            this.btnKetXuatDoanhThu.Name = "btnKetXuatDoanhThu";
            this.btnKetXuatDoanhThu.Size = new System.Drawing.Size(150, 32);
            this.btnKetXuatDoanhThu.TabIndex = 7;
            this.btnKetXuatDoanhThu.Text = "📄 Kết xuất Excel";
            this.btnKetXuatDoanhThu.UseVisualStyleBackColor = false;
            this.btnKetXuatDoanhThu.Click += new System.EventHandler(this.btnKetXuatDoanhThu_Click);

            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.BackColor = System.Drawing.Color.White;
            this.pnlDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.pnlDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoanhThu.Location = new System.Drawing.Point(10, 110);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDoanhThu.Size = new System.Drawing.Size(1152, 460);
            this.pnlDoanhThu.TabIndex = 1;

            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvDoanhThu.ColumnHeadersHeight = 40;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.EnableHeadersVisualStyles = false;
            this.dgvDoanhThu.Location = new System.Drawing.Point(10, 10);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersVisible = false;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(212, 237, 218);
            this.dgvDoanhThu.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvDoanhThu.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvDoanhThu.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvDoanhThu.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvDoanhThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoanhThu.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvDoanhThu.RowTemplate.Height = 35;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1132, 440);
            this.dgvDoanhThu.TabIndex = 0;

            // 
            // pnlTongDoanhThu
            // 
            this.pnlTongDoanhThu.BackColor = System.Drawing.Color.White;
            this.pnlTongDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.pnlTongDoanhThu.Controls.Add(this.lblTongDoanhThuTitle);
            this.pnlTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTongDoanhThu.Location = new System.Drawing.Point(10, 570);
            this.pnlTongDoanhThu.Name = "pnlTongDoanhThu";
            this.pnlTongDoanhThu.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTongDoanhThu.Size = new System.Drawing.Size(1152, 70);
            this.pnlTongDoanhThu.TabIndex = 2;

            // 
            // lblTongDoanhThuTitle
            // 
            this.lblTongDoanhThuTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTongDoanhThuTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThuTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTongDoanhThuTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTongDoanhThuTitle.Name = "lblTongDoanhThuTitle";
            this.lblTongDoanhThuTitle.Size = new System.Drawing.Size(200, 50);
            this.lblTongDoanhThuTitle.TabIndex = 0;
            this.lblTongDoanhThuTitle.Text = "TỔNG DOANH THU:";
            this.lblTongDoanhThuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblTongDoanhThu.Location = new System.Drawing.Point(210, 10);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(932, 50);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "0 đ";
            this.lblTongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // tabTonKho
            // 
            this.tabTonKho.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.tabTonKho.Controls.Add(this.pnlTonKho);
            this.tabTonKho.Controls.Add(this.pnlFilterTonKho);
            this.tabTonKho.Location = new System.Drawing.Point(4, 26);
            this.tabTonKho.Name = "tabTonKho";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(10);
            this.tabTonKho.Size = new System.Drawing.Size(1172, 650);
            this.tabTonKho.TabIndex = 1;
            this.tabTonKho.Text = "📦 Báo cáo Tồn kho";

            // 
            // pnlFilterTonKho
            // 
            this.pnlFilterTonKho.BackColor = System.Drawing.Color.White;
            this.pnlFilterTonKho.Controls.Add(this.btnKetXuatTonKho);
            this.pnlFilterTonKho.Controls.Add(this.btnXemTonKho);
            this.pnlFilterTonKho.Controls.Add(this.cboLoaiHang);
            this.pnlFilterTonKho.Controls.Add(this.lblLoaiHang);
            this.pnlFilterTonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterTonKho.Location = new System.Drawing.Point(10, 10);
            this.pnlFilterTonKho.Name = "pnlFilterTonKho";
            this.pnlFilterTonKho.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFilterTonKho.Size = new System.Drawing.Size(1152, 80);
            this.pnlFilterTonKho.TabIndex = 0;

            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoaiHang.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblLoaiHang.Location = new System.Drawing.Point(13, 15);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(68, 15);
            this.lblLoaiHang.TabIndex = 0;
            this.lblLoaiHang.Text = "Loại hàng:";

            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(13, 35);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(300, 23);
            this.cboLoaiHang.TabIndex = 1;

            // 
            // btnXemTonKho
            // 
            this.btnXemTonKho.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnXemTonKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemTonKho.FlatAppearance.BorderSize = 0;
            this.btnXemTonKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXemTonKho.ForeColor = System.Drawing.Color.White;
            this.btnXemTonKho.Location = new System.Drawing.Point(330, 30);
            this.btnXemTonKho.Name = "btnXemTonKho";
            this.btnXemTonKho.Size = new System.Drawing.Size(150, 32);
            this.btnXemTonKho.TabIndex = 2;
            this.btnXemTonKho.Text = "📊 Xem báo cáo";
            this.btnXemTonKho.UseVisualStyleBackColor = false;
            this.btnXemTonKho.Click += new System.EventHandler(this.btnXemTonKho_Click);

            // 
            // btnKetXuatTonKho
            // 
            this.btnKetXuatTonKho.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnKetXuatTonKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKetXuatTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetXuatTonKho.FlatAppearance.BorderSize = 0;
            this.btnKetXuatTonKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKetXuatTonKho.ForeColor = System.Drawing.Color.White;
            this.btnKetXuatTonKho.Location = new System.Drawing.Point(495, 30);
            this.btnKetXuatTonKho.Name = "btnKetXuatTonKho";
            this.btnKetXuatTonKho.Size = new System.Drawing.Size(150, 32);
            this.btnKetXuatTonKho.TabIndex = 3;
            this.btnKetXuatTonKho.Text = "📄 Kết xuất Excel";
            this.btnKetXuatTonKho.UseVisualStyleBackColor = false;
            this.btnKetXuatTonKho.Click += new System.EventHandler(this.btnKetXuatTonKho_Click);

            // 
            // pnlTonKho
            // 
            this.pnlTonKho.BackColor = System.Drawing.Color.White;
            this.pnlTonKho.Controls.Add(this.dgvTonKho);
            this.pnlTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTonKho.Location = new System.Drawing.Point(10, 90);
            this.pnlTonKho.Name = "pnlTonKho";
            this.pnlTonKho.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTonKho.Size = new System.Drawing.Size(1152, 550);
            this.pnlTonKho.TabIndex = 1;

            // 
            // dgvTonKho
            // 
            this.dgvTonKho.AllowUserToAddRows = false;
            this.dgvTonKho.AllowUserToDeleteRows = false;
            this.dgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvTonKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTonKho.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.dgvTonKho.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTonKho.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTonKho.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvTonKho.ColumnHeadersHeight = 40;
            this.dgvTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTonKho.EnableHeadersVisualStyles = false;
            this.dgvTonKho.Location = new System.Drawing.Point(10, 10);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.ReadOnly = true;
            this.dgvTonKho.RowHeadersVisible = false;
            this.dgvTonKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTonKho.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(212, 237, 218);
            this.dgvTonKho.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvTonKho.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvTonKho.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvTonKho.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvTonKho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTonKho.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvTonKho.RowTemplate.Height = 35;
            this.dgvTonKho.Size = new System.Drawing.Size(1132, 530);
            this.dgvTonKho.TabIndex = 0;

            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.tabDashboard.Controls.Add(this.pnlDashboard);
            this.tabDashboard.Location = new System.Drawing.Point(4, 26);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.tabDashboard.Size = new System.Drawing.Size(1172, 650);
            this.tabDashboard.TabIndex = 2;
            this.tabDashboard.Text = "📈 Dashboard Trực quan";

            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.White;
            this.pnlDashboard.Controls.Add(this.chartTopSanPham);
            this.pnlDashboard.Controls.Add(this.chartDoanhThuTheoThang);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(10, 10);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDashboard.Size = new System.Drawing.Size(1152, 630);
            this.pnlDashboard.TabIndex = 0;

            // 
            // chartDoanhThuTheoThang
            // 
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chartDoanhThuTheoThang.ChartAreas.Add(chartArea1);
            this.chartDoanhThuTheoThang.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            legend1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chartDoanhThuTheoThang.Legends.Add(legend1);
            this.chartDoanhThuTheoThang.Location = new System.Drawing.Point(10, 10);
            this.chartDoanhThuTheoThang.Name = "chartDoanhThuTheoThang";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            series1.Color = System.Drawing.Color.FromArgb(40, 167, 69);
            this.chartDoanhThuTheoThang.Series.Add(series1);
            this.chartDoanhThuTheoThang.Size = new System.Drawing.Size(570, 610);
            this.chartDoanhThuTheoThang.TabIndex = 0;
            this.chartDoanhThuTheoThang.Text = "chartDoanhThuTheoThang";

            // 
            // chartTopSanPham
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTopSanPham.ChartAreas.Add(chartArea2);
            this.chartTopSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            legend2.Font = new System.Drawing.Font("Segoe UI", 9F);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            this.chartTopSanPham.Legends.Add(legend2);
            this.chartTopSanPham.Location = new System.Drawing.Point(580, 10);
            this.chartTopSanPham.Name = "chartTopSanPham";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Top sản phẩm";
            series2.IsValueShownAsLabel = true;
            series2.Label = "#PERCENT{P1}";
            series2.LegendText = "#VALX";
            this.chartTopSanPham.Series.Add(series2);
            this.chartTopSanPham.Size = new System.Drawing.Size(562, 610);
            this.chartTopSanPham.TabIndex = 1;
            this.chartTopSanPham.Text = "chartTopSanPham";

            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmBaoCao";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            this.pnlDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.pnlTongDoanhThu.ResumeLayout(false);
            this.pnlFilterDoanhThu.ResumeLayout(false);
            this.pnlFilterDoanhThu.PerformLayout();
            this.tabTonKho.ResumeLayout(false);
            this.pnlTonKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.pnlFilterTonKho.ResumeLayout(false);
            this.pnlFilterTonKho.PerformLayout();
            this.tabDashboard.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuTheoThang)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.Panel pnlFilterDoanhThu;
        private System.Windows.Forms.Button btnKetXuatDoanhThu;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Panel pnlDoanhThu;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Panel pnlTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThuTitle;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.Panel pnlTonKho;
        private System.Windows.Forms.DataGridView dgvTonKho;
        private System.Windows.Forms.Panel pnlFilterTonKho;
        private System.Windows.Forms.Button btnKetXuatTonKho;
        private System.Windows.Forms.Button btnXemTonKho;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThuTheoThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopSanPham;
    }
}
