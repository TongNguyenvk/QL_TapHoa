using System;
using System.Drawing;
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
            
            // Thiết lập custom renderer cho MenuStrip để fix màu dropdown
            menuStrip1.Renderer = new CustomMenuRenderer();
            
            // Đảm bảo màu chữ menu chính là trắng
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.White;
            }
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

        private void menuXemLichLamViec_Click(object sender, EventArgs e)
        {
            frmXemLichLamViec form = new frmXemLichLamViec(currentUser.MaNhanVien);
            form.MdiParent = this;
            form.Show();
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


// Custom Renderer để fix màu chữ dropdown menu
public class CustomMenuRenderer : ToolStripProfessionalRenderer
{
    public CustomMenuRenderer() : base(new CustomColorTable()) { }

    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
        // Dropdown items (menu con) - màu đen
        if (e.Item.OwnerItem != null)
        {
            e.TextColor = Color.FromArgb(33, 37, 41);
        }
        // Top level items (menu chính) - màu trắng
        else
        {
            e.TextColor = Color.White;
        }
        base.OnRenderItemText(e);
    }
}

public class CustomColorTable : ProfessionalColorTable
{
    public override Color MenuItemSelected
    {
        get { return Color.FromArgb(212, 237, 218); } // Light green khi hover
    }

    public override Color MenuItemSelectedGradientBegin
    {
        get { return Color.FromArgb(212, 237, 218); }
    }

    public override Color MenuItemSelectedGradientEnd
    {
        get { return Color.FromArgb(212, 237, 218); }
    }

    public override Color MenuItemBorder
    {
        get { return Color.FromArgb(40, 167, 69); }
    }
}
