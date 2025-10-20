namespace TapHoa
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXemLichLamViec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLichLamViec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuNghiepVu,
            this.menuDanhMuc,
            this.menuQuanTri,
            this.menuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 0;
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuXemLichLamViec,
            this.menuDoiMatKhau,
            this.menuDangXuat,
            this.menuThoat});
            this.menuHeThong.ForeColor = System.Drawing.Color.White;
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(85, 23);
            this.menuHeThong.Text = "Hệ thống";
            // 
            // menuXemLichLamViec
            // 
            this.menuXemLichLamViec.Name = "menuXemLichLamViec";
            this.menuXemLichLamViec.Size = new System.Drawing.Size(220, 24);
            this.menuXemLichLamViec.Text = "📅 Xem Lịch làm việc";
            this.menuXemLichLamViec.Click += new System.EventHandler(this.menuXemLichLamViec_Click);
            // 
            // menuDoiMatKhau
            // 
            this.menuDoiMatKhau.Name = "menuDoiMatKhau";
            this.menuDoiMatKhau.Size = new System.Drawing.Size(220, 24);
            this.menuDoiMatKhau.Text = "🔒 Đổi mật khẩu";
            this.menuDoiMatKhau.Click += new System.EventHandler(this.menuDoiMatKhau_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(220, 24);
            this.menuDangXuat.Text = "🚪 Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(220, 24);
            this.menuThoat.Text = "❌ Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // menuNghiepVu
            // 
            this.menuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBanHang,
            this.menuNhapKho});
            this.menuNghiepVu.ForeColor = System.Drawing.Color.White;
            this.menuNghiepVu.Name = "menuNghiepVu";
            this.menuNghiepVu.Size = new System.Drawing.Size(89, 23);
            this.menuNghiepVu.Text = "Nghiệp vụ";
            // 
            // menuBanHang
            // 
            this.menuBanHang.Name = "menuBanHang";
            this.menuBanHang.Size = new System.Drawing.Size(150, 24);
            this.menuBanHang.Text = "Bán hàng";
            this.menuBanHang.Click += new System.EventHandler(this.menuBanHang_Click);
            // 
            // menuNhapKho
            // 
            this.menuNhapKho.Name = "menuNhapKho";
            this.menuNhapKho.Size = new System.Drawing.Size(150, 24);
            this.menuNhapKho.Text = "Nhập kho";
            this.menuNhapKho.Click += new System.EventHandler(this.menuNhapKho_Click);
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.ForeColor = System.Drawing.Color.White;
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(90, 23);
            this.menuDanhMuc.Text = "Danh mục";
            this.menuDanhMuc.Click += new System.EventHandler(this.menuDanhMuc_Click);
            // 
            // menuQuanTri
            // 
            this.menuQuanTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanVien,
            this.menuLichLamViec});
            this.menuQuanTri.ForeColor = System.Drawing.Color.White;
            this.menuQuanTri.Name = "menuQuanTri";
            this.menuQuanTri.Size = new System.Drawing.Size(78, 23);
            this.menuQuanTri.Text = "Quản trị";
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(170, 24);
            this.menuNhanVien.Text = "Nhân viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // menuLichLamViec
            // 
            this.menuLichLamViec.Name = "menuLichLamViec";
            this.menuLichLamViec.Size = new System.Drawing.Size(170, 24);
            this.menuLichLamViec.Text = "Lịch làm việc";
            this.menuLichLamViec.Click += new System.EventHandler(this.menuLichLamViec_Click);
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.ForeColor = System.Drawing.Color.White;
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(77, 23);
            this.menuBaoCao.Text = "Báo cáo";
            this.menuBaoCao.Click += new System.EventHandler(this.menuBaoCao_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng tạp hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuXemLichLamViec;
        private System.Windows.Forms.ToolStripMenuItem menuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem menuBanHang;
        private System.Windows.Forms.ToolStripMenuItem menuNhapKho;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuQuanTri;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuLichLamViec;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}