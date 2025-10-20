namespace TapHoa
{
    partial class frmXemLichLamViec
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnChonThangHienTai = new System.Windows.Forms.Button();
            this.btnChonTuanHienTai = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblChonNgay = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvLichCaNhan = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichCaNhan)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pnlTop.Controls.Add(this.lblVaiTro);
            this.pnlTop.Controls.Add(this.lblTenNhanVien);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlTop.Size = new System.Drawing.Size(1000, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(960, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📅 LỊCH LÀM VIỆC CỦA TÔI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblTenNhanVien.Location = new System.Drawing.Point(20, 50);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(960, 20);
            this.lblTenNhanVien.TabIndex = 1;
            this.lblTenNhanVien.Text = "Nhân viên: [Tên]";
            this.lblTenNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblVaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.lblVaiTro.Location = new System.Drawing.Point(20, 70);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(960, 18);
            this.lblVaiTro.TabIndex = 2;
            this.lblVaiTro.Text = "Vai trò: [Vai trò]";
            this.lblVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.btnChonThangHienTai);
            this.pnlLeft.Controls.Add(this.btnChonTuanHienTai);
            this.pnlLeft.Controls.Add(this.monthCalendar);
            this.pnlLeft.Controls.Add(this.lblChonNgay);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 100);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(15);
            this.pnlLeft.Size = new System.Drawing.Size(300, 500);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblChonNgay
            // 
            this.lblChonNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChonNgay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChonNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblChonNgay.Location = new System.Drawing.Point(15, 15);
            this.lblChonNgay.Name = "lblChonNgay";
            this.lblChonNgay.Size = new System.Drawing.Size(270, 30);
            this.lblChonNgay.TabIndex = 0;
            this.lblChonNgay.Text = "Chọn ngày xem lịch:";
            this.lblChonNgay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monthCalendar.Location = new System.Drawing.Point(15, 45);
            this.monthCalendar.MaxSelectionCount = 31;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // btnChonTuanHienTai
            // 
            this.btnChonTuanHienTai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnChonTuanHienTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonTuanHienTai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonTuanHienTai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChonTuanHienTai.ForeColor = System.Drawing.Color.White;
            this.btnChonTuanHienTai.Location = new System.Drawing.Point(15, 230);
            this.btnChonTuanHienTai.Name = "btnChonTuanHienTai";
            this.btnChonTuanHienTai.Size = new System.Drawing.Size(270, 35);
            this.btnChonTuanHienTai.TabIndex = 2;
            this.btnChonTuanHienTai.Text = "📅 Tuần này";
            this.btnChonTuanHienTai.UseVisualStyleBackColor = false;
            this.btnChonTuanHienTai.Click += new System.EventHandler(this.btnChonTuanHienTai_Click);
            // 
            // btnChonThangHienTai
            // 
            this.btnChonThangHienTai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnChonThangHienTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonThangHienTai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonThangHienTai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChonThangHienTai.ForeColor = System.Drawing.Color.White;
            this.btnChonThangHienTai.Location = new System.Drawing.Point(15, 275);
            this.btnChonThangHienTai.Name = "btnChonThangHienTai";
            this.btnChonThangHienTai.Size = new System.Drawing.Size(270, 35);
            this.btnChonThangHienTai.TabIndex = 3;
            this.btnChonThangHienTai.Text = "📆 Tháng này";
            this.btnChonThangHienTai.UseVisualStyleBackColor = false;
            this.btnChonThangHienTai.Click += new System.EventHandler(this.btnChonThangHienTai_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.dgvLichCaNhan);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(300, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMain.Size = new System.Drawing.Size(700, 500);
            this.pnlMain.TabIndex = 2;
            // 
            // dgvLichCaNhan
            // 
            this.dgvLichCaNhan.AllowUserToAddRows = false;
            this.dgvLichCaNhan.AllowUserToDeleteRows = false;
            this.dgvLichCaNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichCaNhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichCaNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichCaNhan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.dgvLichCaNhan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvLichCaNhan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLichCaNhan.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvLichCaNhan.ColumnHeadersHeight = 40;
            this.dgvLichCaNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichCaNhan.EnableHeadersVisualStyles = false;
            this.dgvLichCaNhan.Location = new System.Drawing.Point(15, 15);
            this.dgvLichCaNhan.Name = "dgvLichCaNhan";
            this.dgvLichCaNhan.ReadOnly = true;
            this.dgvLichCaNhan.RowHeadersVisible = false;
            this.dgvLichCaNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichCaNhan.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.dgvLichCaNhan.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvLichCaNhan.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvLichCaNhan.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvLichCaNhan.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvLichCaNhan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichCaNhan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvLichCaNhan.RowTemplate.Height = 35;
            this.dgvLichCaNhan.Size = new System.Drawing.Size(670, 470);
            this.dgvLichCaNhan.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlBottom.Controls.Add(this.btnDong);
            this.pnlBottom.Controls.Add(this.lblThongKe);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 600);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(15);
            this.pnlBottom.Size = new System.Drawing.Size(1000, 70);
            this.pnlBottom.TabIndex = 3;
            // 
            // lblThongKe
            // 
            this.lblThongKe.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lblThongKe.Location = new System.Drawing.Point(15, 15);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(700, 40);
            this.lblThongKe.TabIndex = 0;
            this.lblThongKe.Text = "Tìm thấy 0 ca làm việc";
            this.lblThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(865, 15);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmXemLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmXemLichLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Lịch làm việc";
            this.Load += new System.EventHandler(this.frmXemLichLamViec_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichCaNhan)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnChonThangHienTai;
        private System.Windows.Forms.Button btnChonTuanHienTai;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lblChonNgay;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvLichCaNhan;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblThongKe;
    }
}
