using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TapHoa.DAL;

namespace TapHoa
{
    public partial class frmQuanLyDanhMuc : Form
    {
        private DataTable dtSanPham, dtLoaiHang, dtNhaCungCap;
        private string actionSP = "", actionLH = "", actionNCC = "";
        private int selectedMaHang = 0, selectedMaLoaiHang = 0, selectedMaNCC = 0;

        public frmQuanLyDanhMuc()
        {
            InitializeComponent();
        }

        private void frmQuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadLoaiHang();
            LoadNhaCungCap();
            LoadComboBoxLoaiHang();
        }

        #region Tab Sản phẩm
        
        private void LoadSanPham()
        {
            try
            {
                string query = @"SELECT h.MaHang, h.TenHang, lh.TenLoaiHang, h.SoLuong, 
                                h.GiaBan, h.MoTa 
                                FROM HANGHOA h 
                                INNER JOIN LOAIHANG lh ON h.MaLoaiHang = lh.MaLoaiHang";
                dtSanPham = DataAccess.ExecuteQuery(query);
                dgvSanPham.DataSource = dtSanPham;
            
            if (dgvSanPham.Columns.Count > 0)
            {
                dgvSanPham.Columns["MaHang"].HeaderText = "Mã hàng";
                dgvSanPham.Columns["TenHang"].HeaderText = "Tên hàng";
                dgvSanPham.Columns["TenLoaiHang"].HeaderText = "Loại hàng";
                dgvSanPham.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvSanPham.Columns["GiaBan"].HeaderText = "Giá bán";
                dgvSanPham.Columns["MoTa"].HeaderText = "Mô tả";
                
                dgvSanPham.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu sản phẩm: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxLoaiHang()
        {
            try
            {
                string query = "SELECT MaLoaiHang, TenLoaiHang FROM LOAIHANG";
                DataTable dt = DataAccess.ExecuteQuery(query);
                cboLoaiHang.DataSource = dt;
                cboLoaiHang.DisplayMember = "TenLoaiHang";
                cboLoaiHang.ValueMember = "MaLoaiHang";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại hàng: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            actionSP = "ADD";
            EnableInputSP(true);
            ClearInputSP();
            btnLuuSP.Enabled = true;
            btnBoQuaSP.Enabled = true;
            btnThemSP.Enabled = false;
            btnSuaSP.Enabled = false;
            btnXoaSP.Enabled = false;
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            actionSP = "EDIT";
            EnableInputSP(true);
            btnLuuSP.Enabled = true;
            btnBoQuaSP.Enabled = true;
            btnThemSP.Enabled = false;
            btnSuaSP.Enabled = false;
            btnXoaSP.Enabled = false;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", 
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM HANGHOA WHERE MaHang = @MaHang";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaHang", selectedMaHang)
                };
                
                try
                {
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSanPham();
                    ClearInputSP();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            if (!ValidateSanPham()) return;

            try
            {
                if (actionSP == "ADD")
                {
                    string query = @"INSERT INTO HANGHOA (TenHang, MaLoaiHang, SoLuong, GiaBan, MoTa) 
                                   VALUES (@TenHang, @MaLoaiHang, @SoLuong, @GiaBan, @MoTa)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@TenHang", txtTenHang.Text.Trim()),
                        new SqlParameter("@MaLoaiHang", cboLoaiHang.SelectedValue),
                        new SqlParameter("@SoLuong", numSoLuong.Value),
                        new SqlParameter("@GiaBan", numDonGiaBan.Value),
                        new SqlParameter("@MoTa", txtMoTaSP.Text.Trim())
                    };
                    
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (actionSP == "EDIT")
                {
                    string query = @"UPDATE HANGHOA SET TenHang = @TenHang, MaLoaiHang = @MaLoaiHang, 
                                   SoLuong = @SoLuong, GiaBan = @GiaBan, MoTa = @MoTa 
                                   WHERE MaHang = @MaHang";
                    SqlParameter[] parameters = {
                        new SqlParameter("@TenHang", txtTenHang.Text.Trim()),
                        new SqlParameter("@MaLoaiHang", cboLoaiHang.SelectedValue),
                        new SqlParameter("@SoLuong", numSoLuong.Value),
                        new SqlParameter("@GiaBan", numDonGiaBan.Value),
                        new SqlParameter("@MoTa", txtMoTaSP.Text.Trim()),
                        new SqlParameter("@MaHang", selectedMaHang)
                    };
                    
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                LoadSanPham();
                btnBoQuaSP_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoQuaSP_Click(object sender, EventArgs e)
        {
            actionSP = "";
            EnableInputSP(false);
            ClearInputSP();
            btnLuuSP.Enabled = false;
            btnBoQuaSP.Enabled = false;
            btnThemSP.Enabled = true;
            btnSuaSP.Enabled = true;
            btnXoaSP.Enabled = true;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && actionSP == "")
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                selectedMaHang = Convert.ToInt32(row.Cells["MaHang"].Value);
                txtTenHang.Text = row.Cells["TenHang"].Value.ToString();
                
                string query = "SELECT MaLoaiHang FROM HANGHOA WHERE MaHang = @MaHang";
                SqlParameter[] parameters = { new SqlParameter("@MaHang", selectedMaHang) };
                object result = DataAccess.ExecuteScalar(query, parameters);
                if (result != null)
                {
                    cboLoaiHang.SelectedValue = Convert.ToInt32(result);
                }
                
                numSoLuong.Value = Convert.ToDecimal(row.Cells["SoLuong"].Value);
                numDonGiaBan.Value = Convert.ToDecimal(row.Cells["GiaBan"].Value);
                txtMoTaSP.Text = row.Cells["MoTa"].Value?.ToString() ?? "";
            }
        }

        private void txtTimKiemSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemSP.ForeColor == System.Drawing.Color.Gray) return;
            
            if (dtSanPham != null)
            {
                DataView dv = dtSanPham.DefaultView;
                dv.RowFilter = $"TenHang LIKE '%{txtTimKiemSP.Text.Trim()}%'";
                dgvSanPham.DataSource = dv;
            }
        }

        private void txtTimKiemSP_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemSP.Text == "🔍 Tìm kiếm sản phẩm...")
            {
                txtTimKiemSP.Text = "";
                txtTimKiemSP.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTimKiemSP_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemSP.Text))
            {
                txtTimKiemSP.Text = "🔍 Tìm kiếm sản phẩm...";
                txtTimKiemSP.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private bool ValidateSanPham()
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hàng!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return false;
            }

            if (numDonGiaBan.Value <= 0)
            {
                MessageBox.Show("Giá bán phải lớn hơn 0!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numDonGiaBan.Focus();
                return false;
            }

            return true;
        }

        private void EnableInputSP(bool enabled)
        {
            txtTenHang.Enabled = enabled;
            cboLoaiHang.Enabled = enabled;
            numSoLuong.Enabled = enabled;
            numDonGiaBan.Enabled = enabled;
            txtMoTaSP.Enabled = enabled;
        }

        private void ClearInputSP()
        {
            txtTenHang.Clear();
            if (cboLoaiHang.Items.Count > 0) cboLoaiHang.SelectedIndex = 0;
            numSoLuong.Value = 0;
            numDonGiaBan.Value = 0;
            txtMoTaSP.Clear();
            selectedMaHang = 0;
        }

        #endregion

        #region Tab Loại hàng

        private void LoadLoaiHang()
        {
            try
            {
                string query = "SELECT MaLoaiHang, TenLoaiHang, MoTa FROM LOAIHANG";
                dtLoaiHang = DataAccess.ExecuteQuery(query);
                dgvLoaiHang.DataSource = dtLoaiHang;
            
            if (dgvLoaiHang.Columns.Count > 0)
            {
                dgvLoaiHang.Columns["MaLoaiHang"].HeaderText = "Mã loại hàng";
                dgvLoaiHang.Columns["TenLoaiHang"].HeaderText = "Tên loại hàng";
                dgvLoaiHang.Columns["MoTa"].HeaderText = "Mô tả";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại hàng: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemLH_Click(object sender, EventArgs e)
        {
            actionLH = "ADD";
            EnableInputLH(true);
            ClearInputLH();
            btnLuuLH.Enabled = true;
            btnBoQuaLH.Enabled = true;
            btnThemLH.Enabled = false;
            btnSuaLH.Enabled = false;
            btnXoaLH.Enabled = false;
        }

        private void btnSuaLH_Click(object sender, EventArgs e)
        {
            if (dgvLoaiHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn loại hàng cần sửa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            actionLH = "EDIT";
            EnableInputLH(true);
            btnLuuLH.Enabled = true;
            btnBoQuaLH.Enabled = true;
            btnThemLH.Enabled = false;
            btnSuaLH.Enabled = false;
            btnXoaLH.Enabled = false;
        }

        private void btnXoaLH_Click(object sender, EventArgs e)
        {
            if (dgvLoaiHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn loại hàng cần xóa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại hàng này?", 
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM LOAIHANG WHERE MaLoaiHang = @MaLoaiHang";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaLoaiHang", selectedMaLoaiHang)
                };
                
                try
                {
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Xóa loại hàng thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoaiHang();
                    LoadComboBoxLoaiHang();
                    ClearInputLH();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuuLH_Click(object sender, EventArgs e)
        {
            if (!ValidateLoaiHang()) return;

            try
            {
                if (actionLH == "ADD")
                {
                    string query = "INSERT INTO LOAIHANG (TenLoaiHang, MoTa) VALUES (@TenLoaiHang, @MoTa)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@TenLoaiHang", txtTenLoaiHang.Text.Trim()),
                        new SqlParameter("@MoTa", txtMoTaLH.Text.Trim())
                    };
                    
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Thêm loại hàng thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (actionLH == "EDIT")
                {
                    string query = @"UPDATE LOAIHANG SET TenLoaiHang = @TenLoaiHang, MoTa = @MoTa 
                                   WHERE MaLoaiHang = @MaLoaiHang";
                    SqlParameter[] parameters = {
                        new SqlParameter("@TenLoaiHang", txtTenLoaiHang.Text.Trim()),
                        new SqlParameter("@MoTa", txtMoTaLH.Text.Trim()),
                        new SqlParameter("@MaLoaiHang", selectedMaLoaiHang)
                    };
                    
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Cập nhật loại hàng thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                LoadLoaiHang();
                LoadComboBoxLoaiHang();
                btnBoQuaLH_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoQuaLH_Click(object sender, EventArgs e)
        {
            actionLH = "";
            EnableInputLH(false);
            ClearInputLH();
            btnLuuLH.Enabled = false;
            btnBoQuaLH.Enabled = false;
            btnThemLH.Enabled = true;
            btnSuaLH.Enabled = true;
            btnXoaLH.Enabled = true;
        }

        private void dgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && actionLH == "")
            {
                DataGridViewRow row = dgvLoaiHang.Rows[e.RowIndex];
                selectedMaLoaiHang = Convert.ToInt32(row.Cells["MaLoaiHang"].Value);
                txtTenLoaiHang.Text = row.Cells["TenLoaiHang"].Value.ToString();
                txtMoTaLH.Text = row.Cells["MoTa"].Value?.ToString() ?? "";
            }
        }

        private void txtTimKiemLH_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemLH.ForeColor == System.Drawing.Color.Gray) return;
            
            if (dtLoaiHang != null)
            {
                DataView dv = dtLoaiHang.DefaultView;
                dv.RowFilter = $"TenLoaiHang LIKE '%{txtTimKiemLH.Text.Trim()}%'";
                dgvLoaiHang.DataSource = dv;
            }
        }

        private void txtTimKiemLH_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemLH.Text == "🔍 Tìm kiếm loại hàng...")
            {
                txtTimKiemLH.Text = "";
                txtTimKiemLH.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTimKiemLH_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemLH.Text))
            {
                txtTimKiemLH.Text = "🔍 Tìm kiếm loại hàng...";
                txtTimKiemLH.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private bool ValidateLoaiHang()
        {
            if (string.IsNullOrWhiteSpace(txtTenLoaiHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại hàng!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoaiHang.Focus();
                return false;
            }
            return true;
        }

        private void EnableInputLH(bool enabled)
        {
            txtTenLoaiHang.Enabled = enabled;
            txtMoTaLH.Enabled = enabled;
        }

        private void ClearInputLH()
        {
            txtTenLoaiHang.Clear();
            txtMoTaLH.Clear();
            selectedMaLoaiHang = 0;
        }

        #endregion

        #region Tab Nhà cung cấp

        private void LoadNhaCungCap()
        {
            try
            {
                string query = "SELECT MaNhaCungCap, TenNhaCungCap, DiaChi, Sdt FROM NHACUNGCAP";
                dtNhaCungCap = DataAccess.ExecuteQuery(query);
                dgvNhaCungCap.DataSource = dtNhaCungCap;
            
            if (dgvNhaCungCap.Columns.Count > 0)
            {
                dgvNhaCungCap.Columns["MaNhaCungCap"].HeaderText = "Mã NCC";
                dgvNhaCungCap.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
                dgvNhaCungCap.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvNhaCungCap.Columns["Sdt"].HeaderText = "Số điện thoại";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhà cung cấp: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            actionNCC = "ADD";
            EnableInputNCC(true);
            ClearInputNCC();
            btnLuuNCC.Enabled = true;
            btnBoQuaNCC.Enabled = true;
            btnThemNCC.Enabled = false;
            btnSuaNCC.Enabled = false;
            btnXoaNCC.Enabled = false;
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            actionNCC = "EDIT";
            EnableInputNCC(true);
            btnLuuNCC.Enabled = true;
            btnBoQuaNCC.Enabled = true;
            btnThemNCC.Enabled = false;
            btnSuaNCC.Enabled = false;
            btnXoaNCC.Enabled = false;
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", 
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM NHACUNGCAP WHERE MaNhaCungCap = @MaNhaCungCap";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaNhaCungCap", selectedMaNCC)
                };
                
                try
                {
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhaCungCap();
                    ClearInputNCC();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuuNCC_Click(object sender, EventArgs e)
        {
            if (!ValidateNhaCungCap()) return;

            try
            {
                if (actionNCC == "ADD")
                {
                    string query = @"INSERT INTO NHACUNGCAP (TenNhaCungCap, DiaChi, Sdt) 
                                   VALUES (@TenNhaCungCap, @DiaChi, @Sdt)";
                    SqlParameter[] parameters = {
                        new SqlParameter("@TenNhaCungCap", txtTenNCC.Text.Trim()),
                        new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                        new SqlParameter("@Sdt", txtSDT.Text.Trim())
                    };
                    
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (actionNCC == "EDIT")
                {
                    string query = @"UPDATE NHACUNGCAP SET TenNhaCungCap = @TenNhaCungCap, 
                                   DiaChi = @DiaChi, Sdt = @Sdt 
                                   WHERE MaNhaCungCap = @MaNhaCungCap";
                    SqlParameter[] parameters = {
                        new SqlParameter("@TenNhaCungCap", txtTenNCC.Text.Trim()),
                        new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                        new SqlParameter("@Sdt", txtSDT.Text.Trim()),
                        new SqlParameter("@MaNhaCungCap", selectedMaNCC)
                    };
                    
                    DataAccess.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                LoadNhaCungCap();
                btnBoQuaNCC_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoQuaNCC_Click(object sender, EventArgs e)
        {
            actionNCC = "";
            EnableInputNCC(false);
            ClearInputNCC();
            btnLuuNCC.Enabled = false;
            btnBoQuaNCC.Enabled = false;
            btnThemNCC.Enabled = true;
            btnSuaNCC.Enabled = true;
            btnXoaNCC.Enabled = true;
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && actionNCC == "")
            {
                DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];
                selectedMaNCC = Convert.ToInt32(row.Cells["MaNhaCungCap"].Value);
                txtTenNCC.Text = row.Cells["TenNhaCungCap"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["Sdt"].Value?.ToString() ?? "";
            }
        }

        private void txtTimKiemNCC_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemNCC.ForeColor == System.Drawing.Color.Gray) return;
            
            if (dtNhaCungCap != null)
            {
                DataView dv = dtNhaCungCap.DefaultView;
                dv.RowFilter = $"TenNhaCungCap LIKE '%{txtTimKiemNCC.Text.Trim()}%'";
                dgvNhaCungCap.DataSource = dv;
            }
        }

        private void txtTimKiemNCC_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemNCC.Text == "🔍 Tìm kiếm nhà cung cấp...")
            {
                txtTimKiemNCC.Text = "";
                txtTimKiemNCC.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTimKiemNCC_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemNCC.Text))
            {
                txtTimKiemNCC.Text = "🔍 Tìm kiếm nhà cung cấp...";
                txtTimKiemNCC.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private bool ValidateNhaCungCap()
        {
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return false;
            }
            return true;
        }

        private void EnableInputNCC(bool enabled)
        {
            txtTenNCC.Enabled = enabled;
            txtDiaChi.Enabled = enabled;
            txtSDT.Enabled = enabled;
        }

        private void ClearInputNCC()
        {
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            selectedMaNCC = 0;
        }

        #endregion
    }
}
