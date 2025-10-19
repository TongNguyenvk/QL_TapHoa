using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TapHoa.DAL;
using TapHoa.DTO;

namespace TapHoa
{
    public partial class frmDoiMatKhau : Form
    {
        private NhanVien currentUser;

        public frmDoiMatKhau(NhanVien user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                // Kiểm tra mật khẩu cũ
                string queryCheck = "SELECT COUNT(*) FROM NHANVIEN WHERE MaNhanVien = @MaNhanVien AND MatKhau = @MatKhau";
                SqlParameter[] checkParams = {
                    new SqlParameter("@MaNhanVien", currentUser.MaNhanVien),
                    new SqlParameter("@MatKhau", txtMatKhauCu.Text.Trim())
                };

                int count = Convert.ToInt32(DataAccess.ExecuteScalar(queryCheck, checkParams));
                
                if (count == 0)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauCu.Focus();
                    txtMatKhauCu.SelectAll();
                    return;
                }

                // Cập nhật mật khẩu mới
                string queryUpdate = "UPDATE NHANVIEN SET MatKhau = @MatKhauMoi WHERE MaNhanVien = @MaNhanVien";
                SqlParameter[] updateParams = {
                    new SqlParameter("@MatKhauMoi", txtMatKhauMoi.Text.Trim()),
                    new SqlParameter("@MaNhanVien", currentUser.MaNhanVien)
                };

                DataAccess.ExecuteNonQuery(queryUpdate, updateParams);

                MessageBox.Show("Đổi mật khẩu thành công!\nVui lòng đăng nhập lại với mật khẩu mới.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauCu.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return false;
            }

            if (txtMatKhauMoi.Text.Length < 3)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 3 ký tự!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtXacNhan.Text))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu mới!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhan.Focus();
                return false;
            }

            if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận không khớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhan.Focus();
                txtXacNhan.SelectAll();
                return false;
            }

            if (txtMatKhauCu.Text == txtMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return false;
            }

            return true;
        }
    }
}
