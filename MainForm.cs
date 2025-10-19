using System;
using System.Windows.Forms;
using TapHoa.DTO;

namespace TapHoa
{
    public partial class MainForm : Form
    {
        private NhanVien currentUser;

        public MainForm(NhanVien nv)
        {
            InitializeComponent();
            currentUser = nv;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Xin chào, {currentUser.TenNhanVien} - Vai trò: {currentUser.TenVaiTro}";
            PhanQuyen();
        }

        private void PhanQuyen()
        {
            menuNghiepVu.Visible = false;
            menuDanhMuc.Visible = false;
            menuQuanTri.Visible = false;
            menuBaoCao.Visible = false;

            switch (currentUser.MaVaiTro)
            {
                case 1: // Quản lý
                    menuNghiepVu.Visible = true;
                    menuDanhMuc.Visible = true;
                    menuQuanTri.Visible = true;
                    menuBaoCao.Visible = true;
                    break;
                case 2: // Nhân viên Bán hàng
                    menuNghiepVu.Visible = true;
                    menuBanHang.Visible = true;
                    menuNhapKho.Visible = false;
                    break;
                case 3: // Nhân viên Kho
                    menuNghiepVu.Visible = true;
                    menuBanHang.Visible = false;
                    menuNhapKho.Visible = true;
                    break;
            }
        }

        private void menuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau form = new frmDoiMatKhau(currentUser);
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Đăng xuất sau khi đổi mật khẩu thành công
                MessageBox.Show("Vui lòng đăng nhập lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang form = new frmBanHang(currentUser.TenNhanVien, currentUser.MaNhanVien);
            form.MdiParent = this;
            form.Show();
        }

        private void menuNhapKho_Click(object sender, EventArgs e)
        {
            frmNhapKho form = new frmNhapKho(currentUser.TenNhanVien, currentUser.MaNhanVien);
            form.MdiParent = this;
            form.Show();
        }

        private void menuDanhMuc_Click(object sender, EventArgs e)
        {
            frmQuanLyDanhMuc form = new frmQuanLyDanhMuc();
            form.MdiParent = this;
            form.Show();
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien form = new frmQuanLyNhanVien();
            form.MdiParent = this;
            form.Show();
        }

        private void menuLichLamViec_Click(object sender, EventArgs e)
        {
            frmQuanLyLichLamViec form = new frmQuanLyLichLamViec();
            form.MdiParent = this;
            form.Show();
        }

        private void menuBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao form = new frmBaoCao();
            form.MdiParent = this;
            form.Show();
        }
    }
}