using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TapHoa.DAL;

namespace TapHoa
{
    public partial class frmQuanLyNhanVien : Form
    {
        private DataTable dtNhanVien;
        private string action = "";
        private int selectedMaNhanVien = 0;

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadVaiTro();
            EnableInput(false);
        }

        private void LoadNhanVien()
        {
            try
            {
                string query = @"SELECT nv.MaNhanVien, nv.TenNhanVien, nv.TenDangNhap, 
                                nv.GioiTinh, nv.DiaChi, nv.SdtNhanVien, vt.TenVaiTro
                                FROM NHANVIEN nv
                                INNER JOIN VAITRO vt ON nv.MaVaiTro = vt.MaVaiTro";
                dtNhanVien = DataAccess.ExecuteQuery(query);
                dgvNhanVien.DataSource = dtNhanVien;

                if (dgvNhanVien.Columns.Count > 0)
                {
                    dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã NV";
                    dgvNhanVien.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                    dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                    dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                    dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
                    dgvNhanVien.Columns["SdtNhanVien"].HeaderText = "Số điện thoại";
                    dgvNhanVien.Columns["TenVaiTro"].HeaderText = "Vai trò";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadVaiTro()
        {
            try
            {
                string query = "SELECT MaVaiTro, TenVaiTro FROM VAITRO";
                DataTable dt = DataAccess.ExecuteQuery(query);
                cboVaiTro.DataSource = dt;
                cboVaiTro.DisplayMember = "TenVaiTro";
                cboVaiTro.ValueMember = "MaVaiTro";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải vai trò: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "ADD";
            EnableInput(true);
            ClearInput();
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            action = "EDIT";
            EnableInput(true);
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM NHANVIEN WHERE MaNhanVien = @MaNhanVien";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaNhanVien", selectedMaNhanVien)
                };

                try
                {
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                if (action == "ADD")
                {
                    string query = @"INSERT INTO NHANVIEN (TenNhanVien, TenDangNhap, MatKhau, 
                                   GioiTinh, DiaChi, SdtNhanVien, MaVaiTro) 
                                   VALUES (@TenNhanVien, @TenDangNhap, @MatKhau, 
                                   @GioiTinh, @DiaChi, @SdtNhanVien, @MaVaiTro)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@TenNhanVien", txtTenNhanVien.Text.Trim()),
                        new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()),
                        new SqlParameter("@MatKhau", txtMatKhau.Text.Trim()),
                        new SqlParameter("@GioiTinh", cboGioiTinh.Text),
                        new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                        new SqlParameter("@SdtNhanVien", txtSoDienThoai.Text.Trim()),
                        new SqlParameter("@MaVaiTro", cboVaiTro.SelectedValue)
                    };

                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (action == "EDIT")
                {
                    // Nếu mật khẩu trống, không cập nhật mật khẩu
                    string query;
                    SqlParameter[] parameters;

                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                    {
                        query = @"UPDATE NHANVIEN SET TenNhanVien = @TenNhanVien, 
                                TenDangNhap = @TenDangNhap, GioiTinh = @GioiTinh, 
                                DiaChi = @DiaChi, SdtNhanVien = @SdtNhanVien, 
                                MaVaiTro = @MaVaiTro 
                                WHERE MaNhanVien = @MaNhanVien";
                        parameters = new SqlParameter[] {
                            new SqlParameter("@TenNhanVien", txtTenNhanVien.Text.Trim()),
                            new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()),
                            new SqlParameter("@GioiTinh", cboGioiTinh.Text),
                            new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                            new SqlParameter("@SdtNhanVien", txtSoDienThoai.Text.Trim()),
                            new SqlParameter("@MaVaiTro", cboVaiTro.SelectedValue),
                            new SqlParameter("@MaNhanVien", selectedMaNhanVien)
                        };
                    }
                    else
                    {
                        query = @"UPDATE NHANVIEN SET TenNhanVien = @TenNhanVien, 
                                TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, 
                                GioiTinh = @GioiTinh, DiaChi = @DiaChi, 
                                SdtNhanVien = @SdtNhanVien, MaVaiTro = @MaVaiTro 
                                WHERE MaNhanVien = @MaNhanVien";
                        parameters = new SqlParameter[] {
                            new SqlParameter("@TenNhanVien", txtTenNhanVien.Text.Trim()),
                            new SqlParameter("@TenDangNhap", txtTenDangNhap.Text.Trim()),
                            new SqlParameter("@MatKhau", txtMatKhau.Text.Trim()),
                            new SqlParameter("@GioiTinh", cboGioiTinh.Text),
                            new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                            new SqlParameter("@SdtNhanVien", txtSoDienThoai.Text.Trim()),
                            new SqlParameter("@MaVaiTro", cboVaiTro.SelectedValue),
                            new SqlParameter("@MaNhanVien", selectedMaNhanVien)
                        };
                    }

                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadNhanVien();
                btnBoQua_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            action = "";
            EnableInput(false);
            ClearInput();
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && action == "")
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                selectedMaNhanVien = Convert.ToInt32(row.Cells["MaNhanVien"].Value);
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                
                // Để trống mật khẩu khi hiển thị
                txtMatKhau.Clear();
                
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
                txtSoDienThoai.Text = row.Cells["SdtNhanVien"].Value?.ToString() ?? "";

                // Lấy MaVaiTro từ database
                string query = "SELECT MaVaiTro FROM NHANVIEN WHERE MaNhanVien = @MaNhanVien";
                SqlParameter[] parameters = { new SqlParameter("@MaNhanVien", selectedMaNhanVien) };
                object result = DataAccess.ExecuteScalar(query, parameters);
                if (result != null)
                {
                    cboVaiTro.SelectedValue = Convert.ToInt32(result);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.ForeColor == System.Drawing.Color.Gray) return;

            if (dtNhanVien != null)
            {
                DataView dv = dtNhanVien.DefaultView;
                dv.RowFilter = $"TenNhanVien LIKE '%{txtTimKiem.Text.Trim()}%'";
                dgvNhanVien.DataSource = dv;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "🔍 Tìm kiếm nhân viên...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "🔍 Tìm kiếm nhân viên...";
                txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return false;
            }

            // Chỉ kiểm tra mật khẩu khi thêm mới
            if (action == "ADD" && string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }

            return true;
        }

        private void EnableInput(bool enabled)
        {
            txtTenNhanVien.Enabled = enabled;
            txtTenDangNhap.Enabled = enabled;
            txtMatKhau.Enabled = enabled;
            cboGioiTinh.Enabled = enabled;
            txtDiaChi.Enabled = enabled;
            txtSoDienThoai.Enabled = enabled;
            cboVaiTro.Enabled = enabled;
        }

        private void ClearInput()
        {
            txtTenNhanVien.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            if (cboGioiTinh.Items.Count > 0) cboGioiTinh.SelectedIndex = 0;
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            if (cboVaiTro.Items.Count > 0) cboVaiTro.SelectedIndex = 0;
            selectedMaNhanVien = 0;
        }
    }
}
