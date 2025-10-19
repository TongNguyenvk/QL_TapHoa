using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TapHoa.DAL;
using TapHoa.DTO;

namespace TapHoa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Enable drag form
            this.MouseDown += LoginForm_MouseDown;
            panelLeft.MouseDown += LoginForm_MouseDown;
        }

        private Point mouseOffset;
        private bool isMouseDown = false;

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
                this.MouseMove += LoginForm_MouseMove;
                this.MouseUp += LoginForm_MouseUp;
            }
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
                this.MouseMove -= LoginForm_MouseMove;
                this.MouseUp -= LoginForm_MouseUp;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVien nv = CheckLogin(username, password);
            if (nv != null)
            {
                MainForm mainForm = new MainForm(nv);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private NhanVien CheckLogin(string username, string password)
        {
            try
            {
                string query = @"SELECT nv.MaNhanVien, nv.TenNhanVien, nv.TenDangNhap, nv.MatKhau, 
                                nv.GioiTinh, nv.DiaChi, nv.SdtNhanVien, nv.MaVaiTro, vt.TenVaiTro
                                 FROM NHANVIEN nv
                                 INNER JOIN VAITRO vt ON nv.MaVaiTro = vt.MaVaiTro
                                 WHERE nv.TenDangNhap = @Username AND nv.MatKhau = @Password";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password)
                };

                DataTable dt = DataAccess.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new NhanVien
                    {
                        MaNhanVien = Convert.ToInt32(row["MaNhanVien"]),
                        TenNhanVien = row["TenNhanVien"].ToString(),
                        TenDangNhap = row["TenDangNhap"].ToString(),
                        MatKhau = row["MatKhau"].ToString(),
                        GioiTinh = row["GioiTinh"].ToString(),
                        DiaChi = row["DiaChi"].ToString(),
                        SdtNhanVien = row["SdtNhanVien"].ToString(),
                        MaVaiTro = Convert.ToInt32(row["MaVaiTro"]),
                        TenVaiTro = row["TenVaiTro"].ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}