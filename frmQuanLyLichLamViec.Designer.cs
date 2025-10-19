namespace TapHoa
{
    partial class frmQuanLyLichLamViec
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grpNhanVien = new System.Windows.Forms.GroupBox();
            this.lstNhanVien = new System.Windows.Forms.CheckedListBox();
            this.grpCalendar = new System.Windows.Forms.GroupBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVienTrongCa = new System.Windows.Forms.ComboBox();
            this.lblNgayLam = new System.Windows.Forms.Label();
            this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
            this.lblGioBatDau = new System.Windows.Forms.Label();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblGioKetThuc = new System.Windows.Forms.Label();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThemCa = new System.Windows.Forms.Button();
            this.btnLuuCa = new System.Windows.Forms.Button();
            this.btnXoaCa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            
            this.pnlLeft.SuspendLayout();
            this.grpNhanVien.SuspendLayout();
            this.grpCalendar.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.grpChiTiet.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.grpNhanVien);
            this.pnlLeft.Controls.Add(this.grpCalendar);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(10, 10);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLeft.Size = new System.Drawing.Size(280, 680);
            this.pnlLeft.TabIndex = 0;

            // 
            // grpCalendar
            // 
            this.grpCalendar.Controls.Add(this.monthCalendar);
            this.grpCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCalendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCalendar.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.grpCalendar.Location = new System.Drawing.Point(10, 10);
            this.grpCalendar.Name = "grpCalendar";
            this.grpCalendar.Padding = new System.Windows.Forms.Padding(10);
            this.grpCalendar.Size = new System.Drawing.Size(260, 220);
            this.grpCalendar.TabIndex = 0;
            this.grpCalendar.TabStop = false;
            this.grpCalendar.Text = "📅 Chọn ngày";

            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(13, 30);
            this.monthCalendar.MaxSelectionCount = 7;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);

            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.lstNhanVien);
            this.grpNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpNhanVien.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.grpNhanVien.Location = new System.Drawing.Point(10, 230);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Padding = new System.Windows.Forms.Padding(10);
            this.grpNhanVien.Size = new System.Drawing.Size(260, 440);
            this.grpNhanVien.TabIndex = 1;
            this.grpNhanVien.TabStop = false;
            this.grpNhanVien.Text = "👥 Nhân viên";

            // 
            // lstNhanVien
            // 
            this.lstNhanVien.CheckOnClick = true;
            this.lstNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstNhanVien.FormattingEnabled = true;
            this.lstNhanVien.Location = new System.Drawing.Point(10, 26);
            this.lstNhanVien.Name = "lstNhanVien";
            this.lstNhanVien.Size = new System.Drawing.Size(240, 404);
            this.lstNhanVien.TabIndex = 0;
            this.lstNhanVien.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstNhanVien_ItemCheck);

            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.White;
            this.pnlCenter.Controls.Add(this.dgvLichLamViec);
            this.pnlCenter.Controls.Add(this.lblTitle);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(290, 10);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCenter.Size = new System.Drawing.Size(560, 680);
            this.pnlCenter.TabIndex = 1;

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(540, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📋 Lịch làm việc";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.AllowUserToAddRows = false;
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichLamViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichLamViec.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.dgvLichLamViec.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLichLamViec.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvLichLamViec.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvLichLamViec.ColumnHeadersHeight = 40;
            this.dgvLichLamViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichLamViec.EnableHeadersVisualStyles = false;
            this.dgvLichLamViec.Location = new System.Drawing.Point(10, 40);
            this.dgvLichLamViec.MultiSelect = false;
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.ReadOnly = true;
            this.dgvLichLamViec.RowHeadersVisible = false;
            this.dgvLichLamViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichLamViec.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(212, 237, 218);
            this.dgvLichLamViec.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvLichLamViec.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.dgvLichLamViec.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvLichLamViec.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvLichLamViec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichLamViec.GridColor = System.Drawing.Color.FromArgb(222, 226, 230);
            this.dgvLichLamViec.RowTemplate.Height = 35;
            this.dgvLichLamViec.Size = new System.Drawing.Size(540, 630);
            this.dgvLichLamViec.TabIndex = 1;
            this.dgvLichLamViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichLamViec_CellClick);

            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.grpChiTiet);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(850, 10);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRight.Size = new System.Drawing.Size(350, 680);
            this.pnlRight.TabIndex = 2;

            // 
            // grpChiTiet
            // 
            this.grpChiTiet.Controls.Add(this.btnBoQua);
            this.grpChiTiet.Controls.Add(this.btnXoaCa);
            this.grpChiTiet.Controls.Add(this.btnLuuCa);
            this.grpChiTiet.Controls.Add(this.btnThemCa);
            this.grpChiTiet.Controls.Add(this.txtGhiChu);
            this.grpChiTiet.Controls.Add(this.lblGhiChu);
            this.grpChiTiet.Controls.Add(this.dtpGioKetThuc);
            this.grpChiTiet.Controls.Add(this.lblGioKetThuc);
            this.grpChiTiet.Controls.Add(this.dtpGioBatDau);
            this.grpChiTiet.Controls.Add(this.lblGioBatDau);
            this.grpChiTiet.Controls.Add(this.dtpNgayLam);
            this.grpChiTiet.Controls.Add(this.lblNgayLam);
            this.grpChiTiet.Controls.Add(this.cboNhanVienTrongCa);
            this.grpChiTiet.Controls.Add(this.lblNhanVien);
            this.grpChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTiet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpChiTiet.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.grpChiTiet.Location = new System.Drawing.Point(10, 10);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Padding = new System.Windows.Forms.Padding(10);
            this.grpChiTiet.Size = new System.Drawing.Size(330, 660);
            this.grpChiTiet.TabIndex = 0;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "✏️ Chi tiết ca làm việc";

            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblNhanVien.Location = new System.Drawing.Point(13, 35);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(105, 15);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Chọn nhân viên:";

            // 
            // cboNhanVienTrongCa
            // 
            this.cboNhanVienTrongCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienTrongCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNhanVienTrongCa.FormattingEnabled = true;
            this.cboNhanVienTrongCa.Location = new System.Drawing.Point(13, 55);
            this.cboNhanVienTrongCa.Name = "cboNhanVienTrongCa";
            this.cboNhanVienTrongCa.Size = new System.Drawing.Size(304, 23);
            this.cboNhanVienTrongCa.TabIndex = 1;

            // 
            // lblNgayLam
            // 
            this.lblNgayLam.AutoSize = true;
            this.lblNgayLam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNgayLam.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblNgayLam.Location = new System.Drawing.Point(13, 90);
            this.lblNgayLam.Name = "lblNgayLam";
            this.lblNgayLam.Size = new System.Drawing.Size(63, 15);
            this.lblNgayLam.TabIndex = 2;
            this.lblNgayLam.Text = "Ngày làm:";

            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLam.Location = new System.Drawing.Point(13, 110);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(304, 23);
            this.dtpNgayLam.TabIndex = 3;

            // 
            // lblGioBatDau
            // 
            this.lblGioBatDau.AutoSize = true;
            this.lblGioBatDau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGioBatDau.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblGioBatDau.Location = new System.Drawing.Point(13, 145);
            this.lblGioBatDau.Name = "lblGioBatDau";
            this.lblGioBatDau.Size = new System.Drawing.Size(79, 15);
            this.lblGioBatDau.TabIndex = 4;
            this.lblGioBatDau.Text = "Giờ bắt đầu:";

            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioBatDau.Location = new System.Drawing.Point(13, 165);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Size = new System.Drawing.Size(304, 23);
            this.dtpGioBatDau.TabIndex = 5;

            // 
            // lblGioKetThuc
            // 
            this.lblGioKetThuc.AutoSize = true;
            this.lblGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGioKetThuc.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblGioKetThuc.Location = new System.Drawing.Point(13, 200);
            this.lblGioKetThuc.Name = "lblGioKetThuc";
            this.lblGioKetThuc.Size = new System.Drawing.Size(82, 15);
            this.lblGioKetThuc.TabIndex = 6;
            this.lblGioKetThuc.Text = "Giờ kết thúc:";

            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(13, 220);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Size = new System.Drawing.Size(304, 23);
            this.dtpGioKetThuc.TabIndex = 7;

            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(73, 80, 87);
            this.lblGhiChu.Location = new System.Drawing.Point(13, 255);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(53, 15);
            this.lblGhiChu.TabIndex = 8;
            this.lblGhiChu.Text = "Ghi chú:";

            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.Location = new System.Drawing.Point(13, 275);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(304, 80);
            this.txtGhiChu.TabIndex = 9;

            // 
            // btnThemCa
            // 
            this.btnThemCa.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnThemCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCa.FlatAppearance.BorderSize = 0;
            this.btnThemCa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThemCa.ForeColor = System.Drawing.Color.White;
            this.btnThemCa.Location = new System.Drawing.Point(13, 370);
            this.btnThemCa.Name = "btnThemCa";
            this.btnThemCa.Size = new System.Drawing.Size(304, 38);
            this.btnThemCa.TabIndex = 10;
            this.btnThemCa.Text = "➕ Thêm ca mới";
            this.btnThemCa.UseVisualStyleBackColor = false;
            this.btnThemCa.Click += new System.EventHandler(this.btnThemCa_Click);

            // 
            // btnLuuCa
            // 
            this.btnLuuCa.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnLuuCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuCa.Enabled = false;
            this.btnLuuCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuCa.FlatAppearance.BorderSize = 0;
            this.btnLuuCa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuuCa.ForeColor = System.Drawing.Color.White;
            this.btnLuuCa.Location = new System.Drawing.Point(13, 415);
            this.btnLuuCa.Name = "btnLuuCa";
            this.btnLuuCa.Size = new System.Drawing.Size(147, 38);
            this.btnLuuCa.TabIndex = 11;
            this.btnLuuCa.Text = "💾 Lưu";
            this.btnLuuCa.UseVisualStyleBackColor = false;
            this.btnLuuCa.Click += new System.EventHandler(this.btnLuuCa_Click);

            // 
            // btnXoaCa
            // 
            this.btnXoaCa.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnXoaCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCa.FlatAppearance.BorderSize = 0;
            this.btnXoaCa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoaCa.ForeColor = System.Drawing.Color.White;
            this.btnXoaCa.Location = new System.Drawing.Point(13, 460);
            this.btnXoaCa.Name = "btnXoaCa";
            this.btnXoaCa.Size = new System.Drawing.Size(304, 38);
            this.btnXoaCa.TabIndex = 12;
            this.btnXoaCa.Text = "🗑️ Xóa ca";
            this.btnXoaCa.UseVisualStyleBackColor = false;
            this.btnXoaCa.Click += new System.EventHandler(this.btnXoaCa_Click);

            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.FromArgb(90, 98, 104);
            this.btnBoQua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoQua.Enabled = false;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.FlatAppearance.BorderSize = 0;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.ForeColor = System.Drawing.Color.White;
            this.btnBoQua.Location = new System.Drawing.Point(170, 415);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(147, 38);
            this.btnBoQua.TabIndex = 13;
            this.btnBoQua.Text = "↩️ Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);

            // 
            // frmQuanLyLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmQuanLyLichLamViec";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Lịch làm việc";
            this.Load += new System.EventHandler(this.frmQuanLyLichLamViec_Load);
            this.pnlLeft.ResumeLayout(false);
            this.grpNhanVien.ResumeLayout(false);
            this.grpCalendar.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.GroupBox grpNhanVien;
        private System.Windows.Forms.CheckedListBox lstNhanVien;
        private System.Windows.Forms.GroupBox grpCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DataGridView dgvLichLamViec;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVienTrongCa;
        private System.Windows.Forms.Label lblNgayLam;
        private System.Windows.Forms.DateTimePicker dtpNgayLam;
        private System.Windows.Forms.Label lblGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.Label lblGioKetThuc;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThemCa;
        private System.Windows.Forms.Button btnLuuCa;
        private System.Windows.Forms.Button btnXoaCa;
        private System.Windows.Forms.Button btnBoQua;
    }
}
