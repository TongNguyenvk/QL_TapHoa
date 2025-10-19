namespace TapHoa
{
    partial class frmNhapKho
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
            this.pnlThongTinPhieu = new System.Windows.Forms.Panel();
            this.tblThongTinPhieu = new System.Windows.Forms.TableLayoutPanel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.dgvKetQuaTimKiem = new System.Windows.Forms.DataGridView();
            this.txtTimKiemSP = new System.Windows.Forms.TextBox();
            this.lblTimKiemSP = new System.Windows.Forms.Label();
            this.pnlPhieuNhap = new System.Windows.Forms.Panel();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.lblPhieuNhap = new System.Windows.Forms.Label();
            this.pnlTongKet = new System.Windows.Forms.Panel();
            this.tblTongKet = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGhiChu = new System.Windows.Forms.Panel();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.pnlTongTien = new System.Windows.Forms.Panel();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuPhieuNhap = new System.Windows.Forms.Button();
            this.lblTongTienNhap = new System.Windows.Forms.Label();
            this.lblTongTienTitle = new System.Windows.Forms.Label();
            this.mainTableLayout.SuspendLayout();
            this.pnlThongTinPhieu.SuspendLayout();
            this.tblThongTinPhieu.SuspendLayout();
            this.pnlChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).BeginInit();
            this.pnlPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.pnlTongKet.SuspendLayout();
            this.tblTongKet.SuspendLayout();
            this.pnlGhiChu.SuspendLayout();
            this.pnlTongTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.pnlThongTinPhieu, 0, 0);
            this.mainTableLayout.Controls.Add(this.pnlChiTiet, 0, 1);
            this.mainTableLayout.Controls.Add(this.pnlTongKet, 0, 2);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 3;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.mainTableLayout.Size = new System.Drawing.Size(1200, 700);
            this.mainTableLayout.TabIndex = 0;
            // 
            // pnlThongTinPhieu
            // 
            this.pnlThongTinPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlThongTinPhieu.Controls.Add(this.tblThongTinPhieu);
            this.pnlThongTinPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTinPhieu.Location = new System.Drawing.Point(3, 3);
            this.pnlThongTinPhieu.Name = "pnlThongTinPhieu";
            this.pnlThongTinPhieu.Padding = new System.Windows.Forms.Padding(10);
            this.pnlThongTinPhieu.Size = new System.Drawing.Size(1194, 114);
            this.pnlThongTinPhieu.TabIndex = 0;
            // 
            // tblThongTinPhieu
            // 
            this.tblThongTinPhieu.ColumnCount = 4;
            this.tblThongTinPhieu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblThongTinPhieu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongTinPhieu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblThongTinPhieu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongTinPhieu.Controls.Add(this.lblNhanVien, 0, 0);
            this.tblThongTinPhieu.Controls.Add(this.txtNhanVien, 1, 0);
            this.tblThongTinPhieu.Controls.Add(this.lblNhaCungCap, 2, 0);
            this.tblThongTinPhieu.Controls.Add(this.cboNhaCungCap, 3, 0);
            this.tblThongTinPhieu.Controls.Add(this.lblNgayNhap, 0, 1);
            this.tblThongTinPhieu.Controls.Add(this.dtpNgayNhap, 1, 1);
            this.tblThongTinPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblThongTinPhieu.Location = new System.Drawing.Point(10, 10);
            this.tblThongTinPhieu.Name = "tblThongTinPhieu";
            this.tblThongTinPhieu.RowCount = 2;
            this.tblThongTinPhieu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongTinPhieu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongTinPhieu.Size = new System.Drawing.Size(1174, 94);
            this.tblThongTinPhieu.TabIndex = 0;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhanVien.Location = new System.Drawing.Point(3, 11);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(135, 23);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "👤 Nhân viên nhập:";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNhanVien.Location = new System.Drawing.Point(153, 8);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(431, 30);
            this.txtNhanVien.TabIndex = 1;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhaCungCap.Location = new System.Drawing.Point(590, 11);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(133, 23);
            this.lblNhaCungCap.TabIndex = 2;
            this.lblNhaCungCap.Text = "🏢 Nhà cung cấp:";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(740, 7);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(431, 31);
            this.cboNhaCungCap.TabIndex = 3;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayNhap.Location = new System.Drawing.Point(3, 58);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(105, 23);
            this.lblNgayNhap.TabIndex = 4;
            this.lblNgayNhap.Text = "📅 Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(153, 55);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(431, 30);
            this.dtpNgayNhap.TabIndex = 5;
            // 
            // pnlChiTiet
            // 
            this.pnlChiTiet.Controls.Add(this.splitContainer);
            this.pnlChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChiTiet.Location = new System.Drawing.Point(3, 123);
            this.pnlChiTiet.Name = "pnlChiTiet";
            this.pnlChiTiet.Size = new System.Drawing.Size(1194, 454);
            this.pnlChiTiet.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pnlTimKiem);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlPhieuNhap);
            this.splitContainer.Size = new System.Drawing.Size(1194, 454);
            this.splitContainer.SplitterDistance = 400;
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
            this.pnlTimKiem.Size = new System.Drawing.Size(400, 454);
            this.pnlTimKiem.TabIndex = 0;
            // 
            // dgvKetQuaTimKiem
            // 
            this.dgvKetQuaTimKiem.AllowUserToAddRows = false;
            this.dgvKetQuaTimKiem.AllowUserToDeleteRows = false;
            this.dgvKetQuaTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQuaTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQuaTimKiem.Location = new System.Drawing.Point(10, 83);
            this.dgvKetQuaTimKiem.Name = "dgvKetQuaTimKiem";
            this.dgvKetQuaTimKiem.ReadOnly = true;
            this.dgvKetQuaTimKiem.RowHeadersWidth = 51;
            this.dgvKetQuaTimKiem.RowTemplate.Height = 29;
            this.dgvKetQuaTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQuaTimKiem.Size = new System.Drawing.Size(380, 361);
            this.dgvKetQuaTimKiem.TabIndex = 2;
            this.dgvKetQuaTimKiem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQuaTimKiem_CellDoubleClick);
            // 
            // txtTimKiemSP
            // 
            this.txtTimKiemSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiemSP.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiemSP.Location = new System.Drawing.Point(10, 43);
            this.txtTimKiemSP.Name = "txtTimKiemSP";
            this.txtTimKiemSP.Size = new System.Drawing.Size(380, 30);
            this.txtTimKiemSP.TabIndex = 1;
            this.txtTimKiemSP.Text = "🔍 Nhập tên sản phẩm...";
            this.txtTimKiemSP.TextChanged += new System.EventHandler(this.txtTimKiemSP_TextChanged);
            this.txtTimKiemSP.Enter += new System.EventHandler(this.txtTimKiemSP_Enter);
            this.txtTimKiemSP.Leave += new System.EventHandler(this.txtTimKiemSP_Leave);
            // 
            // lblTimKiemSP
            // 
            this.lblTimKiemSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimKiemSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblTimKiemSP.Location = new System.Drawing.Point(10, 10);
            this.lblTimKiemSP.Name = "lblTimKiemSP";
            this.lblTimKiemSP.Size = new System.Drawing.Size(380, 33);
            this.lblTimKiemSP.TabIndex = 0;
            this.lblTimKiemSP.Text = "🔍 Tìm kiếm sản phẩm";
            // 
            // pnlPhieuNhap
            // 
            this.pnlPhieuNhap.BackColor = System.Drawing.Color.White;
            this.pnlPhieuNhap.Controls.Add(this.dgvPhieuNhap);
            this.pnlPhieuNhap.Controls.Add(this.lblPhieuNhap);
            this.pnlPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlPhieuNhap.Name = "pnlPhieuNhap";
            this.pnlPhieuNhap.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPhieuNhap.Size = new System.Drawing.Size(790, 454);
            this.pnlPhieuNhap.TabIndex = 0;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(10, 43);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.RowTemplate.Height = 29;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(770, 401);
            this.dgvPhieuNhap.TabIndex = 1;
            this.dgvPhieuNhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellValueChanged);
            this.dgvPhieuNhap.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvPhieuNhap_UserDeletingRow);
            // 
            // lblPhieuNhap
            // 
            this.lblPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhieuNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblPhieuNhap.Location = new System.Drawing.Point(10, 10);
            this.lblPhieuNhap.Name = "lblPhieuNhap";
            this.lblPhieuNhap.Size = new System.Drawing.Size(770, 33);
            this.lblPhieuNhap.TabIndex = 0;
            this.lblPhieuNhap.Text = "📋 Chi tiết phiếu nhập";
            // 
            // pnlTongKet
            // 
            this.pnlTongKet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlTongKet.Controls.Add(this.tblTongKet);
            this.pnlTongKet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTongKet.Location = new System.Drawing.Point(3, 583);
            this.pnlTongKet.Name = "pnlTongKet";
            this.pnlTongKet.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTongKet.Size = new System.Drawing.Size(1194, 114);
            this.pnlTongKet.TabIndex = 2;
            // 
            // tblTongKet
            // 
            this.tblTongKet.ColumnCount = 2;
            this.tblTongKet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTongKet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTongKet.Controls.Add(this.pnlGhiChu, 0, 0);
            this.tblTongKet.Controls.Add(this.pnlTongTien, 1, 0);
            this.tblTongKet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTongKet.Location = new System.Drawing.Point(10, 10);
            this.tblTongKet.Name = "tblTongKet";
            this.tblTongKet.RowCount = 1;
            this.tblTongKet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTongKet.Size = new System.Drawing.Size(1174, 94);
            this.tblTongKet.TabIndex = 0;
            // 
            // pnlGhiChu
            // 
            this.pnlGhiChu.Controls.Add(this.txtGhiChu);
            this.pnlGhiChu.Controls.Add(this.lblGhiChu);
            this.pnlGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGhiChu.Location = new System.Drawing.Point(3, 3);
            this.pnlGhiChu.Name = "pnlGhiChu";
            this.pnlGhiChu.Size = new System.Drawing.Size(581, 88);
            this.pnlGhiChu.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.Location = new System.Drawing.Point(0, 33);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(581, 55);
            this.txtGhiChu.TabIndex = 1;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGhiChu.Location = new System.Drawing.Point(0, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(581, 33);
            this.lblGhiChu.TabIndex = 0;
            this.lblGhiChu.Text = "📝 Ghi chú phiếu nhập:";
            this.lblGhiChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTongTien
            // 
            this.pnlTongTien.Controls.Add(this.btnLichSu);
            this.pnlTongTien.Controls.Add(this.btnHuy);
            this.pnlTongTien.Controls.Add(this.btnLuuPhieuNhap);
            this.pnlTongTien.Controls.Add(this.lblTongTienNhap);
            this.pnlTongTien.Controls.Add(this.lblTongTienTitle);
            this.pnlTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTongTien.Location = new System.Drawing.Point(590, 3);
            this.pnlTongTien.Name = "pnlTongTien";
            this.pnlTongTien.Size = new System.Drawing.Size(581, 88);
            this.pnlTongTien.TabIndex = 1;
            // 
            // btnLichSu
            // 
            this.btnLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLichSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLichSu.ForeColor = System.Drawing.Color.White;
            this.btnLichSu.Location = new System.Drawing.Point(446, 0);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(120, 35);
            this.btnLichSu.TabIndex = 4;
            this.btnLichSu.Text = "📋 Lịch sử";
            this.btnLichSu.UseVisualStyleBackColor = false;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(446, 40);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "❌ Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuuPhieuNhap
            // 
            this.btnLuuPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnLuuPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieuNhap.Location = new System.Drawing.Point(300, 40);
            this.btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            this.btnLuuPhieuNhap.Size = new System.Drawing.Size(140, 40);
            this.btnLuuPhieuNhap.TabIndex = 2;
            this.btnLuuPhieuNhap.Text = "💾 Lưu phiếu";
            this.btnLuuPhieuNhap.UseVisualStyleBackColor = false;
            this.btnLuuPhieuNhap.Click += new System.EventHandler(this.btnLuuPhieuNhap_Click);
            // 
            // lblTongTienNhap
            // 
            this.lblTongTienNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTienNhap.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTienNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTongTienNhap.Location = new System.Drawing.Point(300, 0);
            this.lblTongTienNhap.Name = "lblTongTienNhap";
            this.lblTongTienNhap.Size = new System.Drawing.Size(266, 37);
            this.lblTongTienNhap.TabIndex = 1;
            this.lblTongTienNhap.Text = "0 đ";
            this.lblTongTienNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTienTitle
            // 
            this.lblTongTienTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTienTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongTienTitle.Location = new System.Drawing.Point(150, 0);
            this.lblTongTienTitle.Name = "lblTongTienTitle";
            this.lblTongTienTitle.Size = new System.Drawing.Size(144, 37);
            this.lblTongTienTitle.TabIndex = 0;
            this.lblTongTienTitle.Text = "💰 Tổng tiền nhập:";
            this.lblTongTienTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.mainTableLayout);
            this.Name = "frmNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📦 Quản lý Nhập kho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            this.mainTableLayout.ResumeLayout(false);
            this.pnlThongTinPhieu.ResumeLayout(false);
            this.tblThongTinPhieu.ResumeLayout(false);
            this.tblThongTinPhieu.PerformLayout();
            this.pnlChiTiet.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).EndInit();
            this.pnlPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.pnlTongKet.ResumeLayout(false);
            this.tblTongKet.ResumeLayout(false);
            this.pnlGhiChu.ResumeLayout(false);
            this.pnlGhiChu.PerformLayout();
            this.pnlTongTien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Panel pnlThongTinPhieu;
        private System.Windows.Forms.TableLayoutPanel tblThongTinPhieu;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Panel pnlChiTiet;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.DataGridView dgvKetQuaTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemSP;
        private System.Windows.Forms.Label lblTimKiemSP;
        private System.Windows.Forms.Panel pnlPhieuNhap;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Label lblPhieuNhap;
        private System.Windows.Forms.Panel pnlTongKet;
        private System.Windows.Forms.TableLayoutPanel tblTongKet;
        private System.Windows.Forms.Panel pnlGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Panel pnlTongTien;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuPhieuNhap;
        private System.Windows.Forms.Label lblTongTienNhap;
        private System.Windows.Forms.Label lblTongTienTitle;
    }
}
