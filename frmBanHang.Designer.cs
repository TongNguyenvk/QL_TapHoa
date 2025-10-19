namespace TapHoa
{
    partial class frmBanHang
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
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlThongTinHoaDon = new System.Windows.Forms.Panel();
            this.tblThongTinHoaDon = new System.Windows.Forms.TableLayoutPanel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.dgvKetQuaTimKiem = new System.Windows.Forms.DataGridView();
            this.txtTimKiemSP = new System.Windows.Forms.TextBox();
            this.lblTimKiemSP = new System.Windows.Forms.Label();
            this.pnlGioHang = new System.Windows.Forms.Panel();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lblGioHang = new System.Windows.Forms.Label();
            this.pnlThanhToan = new System.Windows.Forms.Panel();
            this.tblThanhToan = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGhiChu = new System.Windows.Forms.Panel();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.pnlTongTien = new System.Windows.Forms.Panel();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienTitle = new System.Windows.Forms.Label();
            
            this.mainTableLayout.SuspendLayout();
            this.pnlThongTinHoaDon.SuspendLayout();
            this.tblThongTinHoaDon.SuspendLayout();
            this.pnlChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).BeginInit();
            this.pnlGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlThanhToan.SuspendLayout();
            this.tblThanhToan.SuspendLayout();
            this.pnlGhiChu.SuspendLayout();
            this.pnlTongTien.SuspendLayout();
            this.SuspendLayout();

            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.pnlThongTinHoaDon, 0, 0);
            this.mainTableLayout.Controls.Add(this.pnlChiTiet, 0, 1);
            this.mainTableLayout.Controls.Add(this.pnlThanhToan, 0, 2);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(10, 10);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.mainTableLayout.Size = new System.Drawing.Size(1180, 680);
            this.mainTableLayout.TabIndex = 0;

            // 
            // pnlThongTinHoaDon
            // 
            this.pnlThongTinHoaDon.BackColor = System.Drawing.Color.White;
            this.pnlThongTinHoaDon.Controls.Add(this.tblThongTinHoaDon);
            this.pnlThongTinHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTinHoaDon.Location = new System.Drawing.Point(3, 3);
            this.pnlThongTinHoaDon.Name = "pnlThongTinHoaDon";
            this.pnlThongTinHoaDon.Padding = new System.Windows.Forms.Padding(10);
            this.pnlThongTinHoaDon.Size = new System.Drawing.Size(1174, 74);
            this.pnlThongTinHoaDon.TabIndex = 0;

            // 
            // tblThongTinHoaDon
            // 
            this.tblThongTinHoaDon.ColumnCount = 2;
            this.tblThongTinHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongTinHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongTinHoaDon.Controls.Add(this.lblNhanVien, 0, 0);
            this.tblThongTinHoaDon.Controls.Add(this.txtNhanVien, 0, 1);
            this.tblThongTinHoaDon.Controls.Add(this.lblNgayBan, 1, 0);
            this.tblThongTinHoaDon.Controls.Add(this.dtpNgayBan, 1, 1);
            this.tblThongTinHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblThongTinHoaDon.Location = new System.Drawing.Point(10, 10);
            this.tblThongTinHoaDon.Name = "tblThongTinHoaDon";
            this.tblThongTinHoaDon.RowCount = 2;
            this.tblThongTinHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblThongTinHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblThongTinHoaDon.Size = new System.Drawing.Size(1154, 54);
            this.tblThongTinHoaDon.TabIndex = 0;

            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblNhanVien.Location = new System.Drawing.Point(3, 3);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(70, 15);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Nhân viên:";

            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNhanVien.Location = new System.Drawing.Point(3, 25);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(571, 25);
            this.txtNhanVien.TabIndex = 1;
            this.txtNhanVien.BackColor = System.Drawing.Color.FromArgb(233, 236, 239);

            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNgayBan.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblNgayBan.Location = new System.Drawing.Point(580, 3);
            this.lblNgayBan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(65, 15);
            this.lblNgayBan.TabIndex = 2;
            this.lblNgayBan.Text = "Ngày bán:";

            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(580, 25);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(571, 25);
            this.dtpNgayBan.TabIndex = 3;

            // 
            // pnlChiTiet
            // 
            this.pnlChiTiet.Controls.Add(this.splitContainer);
            this.pnlChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChiTiet.Location = new System.Drawing.Point(3, 83);
            this.pnlChiTiet.Name = "pnlChiTiet";
            this.pnlChiTiet.Size = new System.Drawing.Size(1174, 454);
            this.pnlChiTiet.TabIndex = 1;

            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.pnlTimKiem);
            this.splitContainer.Panel2.Controls.Add(this.pnlGioHang);
            this.splitContainer.Size = new System.Drawing.Size(1174, 454);
            this.splitContainer.SplitterDistance = 450;
            this.splitContainer.TabIndex = 0;

            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.BackColor = System.Drawing.Color.White;
            this.pnlTimKiem.Controls.Add(this.dgvKetQuaTimKiem);
            this.pnlTimKiem.Controls.Add(this.txtTimKiemSP);
            this.pnlTimKiem.Controls.Add(this.lblTimKiemSP);
            this.pnlTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimKiem.Location = new System.Drawing.Point(0, 0);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTimKiem.Size = new System.Drawing.Size(450, 454);
            this.pnlTimKiem.TabIndex = 0;

            // 
            // lblTimKiemSP
            // 
            this.lblTimKiemSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTimKiemSP.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTimKiemSP.Location = new System.Drawing.Point(10, 10);
            this.lblTimKiemSP.Name = "lblTimKiemSP";
            this.lblTimKiemSP.Size = new System.Drawing.Size(430, 25);
            this.lblTimKiemSP.TabIndex = 0;
            this.lblTimKiemSP.Text = "Tìm kiếm sản phẩm";

            // 
            // txtTimKiemSP
            // 
            this.txtTimKiemSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiemSP.Location = new System.Drawing.Point(10, 35);
            this.txtTimKiemSP.Name = "txtTimKiemSP";
            this.txtTimKiemSP.Size = new System.Drawing.Size(430, 25);
            this.txtTimKiemSP.TabIndex = 1;
            this.txtTimKiemSP.Text = "🔍 Nhập tên sản phẩm...";
            this.txtTimKiemSP.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemSP.TextChanged += new System.EventHandler(this.txtTimKiemSP_TextChanged);
            this.txtTimKiemSP.Enter += new System.EventHandler(this.txtTimKiemSP_Enter);
            this.txtTimKiemSP.Leave += new System.EventHandler(this.txtTimKiemSP_Leave);

            // 
            // dgvKetQuaTimKiem
            // 
            this.dgvKetQuaTimKiem.AllowUserToAddRows = false;
            this.dgvKetQuaTimKiem.AllowUserToDeleteRows = false;
            this.dgvKetQuaTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQuaTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKetQuaTimKiem.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.dgvKetQuaTimKiem.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKetQuaTimKiem.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvKetQuaTimKiem.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvKetQuaTimKiem.ColumnHeadersHeight = 35;
            this.dgvKetQuaTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQuaTimKiem.EnableHeadersVisualStyles = false;
            this.dgvKetQuaTimKiem.Location = new System.Drawing.Point(10, 60);
            this.dgvKetQuaTimKiem.MultiSelect = false;
            this.dgvKetQuaTimKiem.Name = "dgvKetQuaTimKiem";
            this.dgvKetQuaTimKiem.ReadOnly = true;
            this.dgvKetQuaTimKiem.RowHeadersVisible = false;
            this.dgvKetQuaTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQuaTimKiem.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(212, 237, 218);
            this.dgvKetQuaTimKiem.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvKetQuaTimKiem.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvKetQuaTimKiem.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvKetQuaTimKiem.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvKetQuaTimKiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKetQuaTimKiem.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvKetQuaTimKiem.RowTemplate.Height = 30;
            this.dgvKetQuaTimKiem.Size = new System.Drawing.Size(430, 384);
            this.dgvKetQuaTimKiem.TabIndex = 2;
            this.dgvKetQuaTimKiem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQuaTimKiem_CellDoubleClick);

            // 
            // pnlGioHang
            // 
            this.pnlGioHang.BackColor = System.Drawing.Color.White;
            this.pnlGioHang.Controls.Add(this.dgvGioHang);
            this.pnlGioHang.Controls.Add(this.lblGioHang);
            this.pnlGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGioHang.Location = new System.Drawing.Point(0, 0);
            this.pnlGioHang.Name = "pnlGioHang";
            this.pnlGioHang.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGioHang.Size = new System.Drawing.Size(720, 454);
            this.pnlGioHang.TabIndex = 0;

            // 
            // lblGioHang
            // 
            this.lblGioHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGioHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGioHang.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblGioHang.Location = new System.Drawing.Point(10, 10);
            this.lblGioHang.Name = "lblGioHang";
            this.lblGioHang.Size = new System.Drawing.Size(700, 25);
            this.lblGioHang.TabIndex = 0;
            this.lblGioHang.Text = "🛒 Giỏ hàng";

            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGioHang.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.dgvGioHang.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGioHang.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvGioHang.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvGioHang.ColumnHeadersHeight = 35;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.EnableHeadersVisualStyles = false;
            this.dgvGioHang.Location = new System.Drawing.Point(10, 35);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(212, 237, 218);
            this.dgvGioHang.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvGioHang.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvGioHang.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvGioHang.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgvGioHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGioHang.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvGioHang.RowTemplate.Height = 30;
            this.dgvGioHang.Size = new System.Drawing.Size(700, 409);
            this.dgvGioHang.TabIndex = 1;
            this.dgvGioHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellValueChanged);
            this.dgvGioHang.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvGioHang_UserDeletingRow);

            // 
            // pnlThanhToan
            // 
            this.pnlThanhToan.BackColor = System.Drawing.Color.White;
            this.pnlThanhToan.Controls.Add(this.tblThanhToan);
            this.pnlThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThanhToan.Location = new System.Drawing.Point(3, 543);
            this.pnlThanhToan.Name = "pnlThanhToan";
            this.pnlThanhToan.Padding = new System.Windows.Forms.Padding(10);
            this.pnlThanhToan.Size = new System.Drawing.Size(1174, 134);
            this.pnlThanhToan.TabIndex = 2;

            // 
            // tblThanhToan
            // 
            this.tblThanhToan.ColumnCount = 2;
            this.tblThanhToan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThanhToan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThanhToan.Controls.Add(this.pnlGhiChu, 0, 0);
            this.tblThanhToan.Controls.Add(this.pnlTongTien, 1, 0);
            this.tblThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblThanhToan.Location = new System.Drawing.Point(10, 10);
            this.tblThanhToan.Name = "tblThanhToan";
            this.tblThanhToan.RowCount = 1;
            this.tblThanhToan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblThanhToan.Size = new System.Drawing.Size(1154, 114);
            this.tblThanhToan.TabIndex = 0;

            // 
            // pnlGhiChu
            // 
            this.pnlGhiChu.Controls.Add(this.txtGhiChu);
            this.pnlGhiChu.Controls.Add(this.lblGhiChu);
            this.pnlGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGhiChu.Location = new System.Drawing.Point(3, 3);
            this.pnlGhiChu.Name = "pnlGhiChu";
            this.pnlGhiChu.Size = new System.Drawing.Size(571, 108);
            this.pnlGhiChu.TabIndex = 0;

            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblGhiChu.Location = new System.Drawing.Point(0, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(571, 20);
            this.lblGhiChu.TabIndex = 0;
            this.lblGhiChu.Text = "Ghi chú hóa đơn:";

            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.Location = new System.Drawing.Point(0, 20);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(571, 88);
            this.txtGhiChu.TabIndex = 1;

            // 
            // pnlTongTien
            // 
            this.pnlTongTien.Controls.Add(this.btnHuyDon);
            this.pnlTongTien.Controls.Add(this.btnThanhToan);
            this.pnlTongTien.Controls.Add(this.lblTongTien);
            this.pnlTongTien.Controls.Add(this.lblTongTienTitle);
            this.pnlTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTongTien.Location = new System.Drawing.Point(580, 3);
            this.pnlTongTien.Name = "pnlTongTien";
            this.pnlTongTien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlTongTien.Size = new System.Drawing.Size(571, 108);
            this.pnlTongTien.TabIndex = 1;

            // 
            // lblTongTienTitle
            // 
            this.lblTongTienTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTongTienTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTienTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTongTienTitle.Location = new System.Drawing.Point(10, 0);
            this.lblTongTienTitle.Name = "lblTongTienTitle";
            this.lblTongTienTitle.Size = new System.Drawing.Size(561, 25);
            this.lblTongTienTitle.TabIndex = 0;
            this.lblTongTienTitle.Text = "TỔNG TIỀN";
            this.lblTongTienTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblTongTien
            // 
            this.lblTongTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblTongTien.Location = new System.Drawing.Point(10, 25);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(561, 35);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "0 đ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(10, 65);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(370, 40);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "💳 THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            // 
            // btnHuyDon
            // 
            this.btnHuyDon.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnHuyDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDon.FlatAppearance.BorderSize = 0;
            this.btnHuyDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuyDon.ForeColor = System.Drawing.Color.White;
            this.btnHuyDon.Location = new System.Drawing.Point(390, 65);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(180, 40);
            this.btnHuyDon.TabIndex = 3;
            this.btnHuyDon.Text = "🗑️ HỦY ĐƠN";
            this.btnHuyDon.UseVisualStyleBackColor = false;
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);

            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.mainTableLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmBanHang";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.mainTableLayout.ResumeLayout(false);
            this.pnlThongTinHoaDon.ResumeLayout(false);
            this.tblThongTinHoaDon.ResumeLayout(false);
            this.tblThongTinHoaDon.PerformLayout();
            this.pnlChiTiet.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).EndInit();
            this.pnlGioHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlThanhToan.ResumeLayout(false);
            this.tblThanhToan.ResumeLayout(false);
            this.pnlGhiChu.ResumeLayout(false);
            this.pnlGhiChu.PerformLayout();
            this.pnlTongTien.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Panel pnlThongTinHoaDon;
        private System.Windows.Forms.TableLayoutPanel tblThongTinHoaDon;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Panel pnlChiTiet;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.DataGridView dgvKetQuaTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemSP;
        private System.Windows.Forms.Label lblTimKiemSP;
        private System.Windows.Forms.Panel pnlGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label lblGioHang;
        private System.Windows.Forms.Panel pnlThanhToan;
        private System.Windows.Forms.TableLayoutPanel tblThanhToan;
        private System.Windows.Forms.Panel pnlGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Panel pnlTongTien;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongTienTitle;
    }
}
