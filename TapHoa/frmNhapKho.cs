using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TapHoa.DAL;

namespace TapHoa
{
    public partial class frmNhapKho : Form
    {
        private DataTable dtSanPham;
        private DataTable dtPhieuNhap;
        private string tenNhanVien;
        private int maNhanVien;

        public frmNhapKho(string tenNV, int maNV)
        {
            InitializeComponent();
            this.tenNhanVien = tenNV;
            this.maNhanVien = maNV;
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            txtNhanVien.Text = tenNhanVien;
            dtpNgayNhap.Value = DateTime.Now;
            
            // Chỉ cho phép chọn ngày hiện tại
            dtpNgayNhap.MinDate = DateTime.Today;
            dtpNgayNhap.MaxDate = DateTime.Today;
            
            LoadNhaCungCap();
            LoadSanPham();
            InitPhieuNhap();
        }

        private void LoadNhaCungCap()
        {
            try
            {
                string query = "SELECT MaNhaCungCap, TenNhaCungCap FROM NHACUNGCAP ORDER BY TenNhaCungCap";
                DataTable dt = DataAccess.ExecuteQuery(query);
                
                cboNhaCungCap.DataSource = dt;
                cboNhaCungCap.DisplayMember = "TenNhaCungCap";
                cboNhaCungCap.ValueMember = "MaNhaCungCap";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhà cung cấp: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSanPham()
        {
            try
            {
                string query = @"SELECT MaHang, TenHang, SoLuong, GiaBan 
                                FROM HANGHOA 
                                ORDER BY TenHang";
                dtSanPham = DataAccess.ExecuteQuery(query);
                dgvKetQuaTimKiem.DataSource = dtSanPham;

                if (dgvKetQuaTimKiem.Columns.Count > 0)
                {
                    dgvKetQuaTimKiem.Columns["MaHang"].HeaderText = "Mã";
                    dgvKetQuaTimKiem.Columns["MaHang"].Width = 50;
                    dgvKetQuaTimKiem.Columns["TenHang"].HeaderText = "Tên sản phẩm";
                    dgvKetQuaTimKiem.Columns["SoLuong"].HeaderText = "Tồn kho";
                    dgvKetQuaTimKiem.Columns["SoLuong"].Width = 70;
                    dgvKetQuaTimKiem.Columns["GiaBan"].HeaderText = "Giá bán";
                    dgvKetQuaTimKiem.Columns["GiaBan"].Width = 90;
                    dgvKetQuaTimKiem.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sản phẩm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitPhieuNhap()
        {
            dtPhieuNhap = new DataTable();
            dtPhieuNhap.Columns.Add("MaHang", typeof(int));
            dtPhieuNhap.Columns.Add("TenHang", typeof(string));
            dtPhieuNhap.Columns.Add("SoLuongNhap", typeof(int));
            dtPhieuNhap.Columns.Add("GiaNhap", typeof(decimal));
            dtPhieuNhap.Columns.Add("ThanhTien", typeof(decimal), "SoLuongNhap * GiaNhap");

            dgvPhieuNhap.DataSource = dtPhieuNhap;

            if (dgvPhieuNhap.Columns.Count > 0)
            {
                dgvPhieuNhap.Columns["MaHang"].Visible = false;
                dgvPhieuNhap.Columns["TenHang"].HeaderText = "Tên sản phẩm";
                dgvPhieuNhap.Columns["TenHang"].ReadOnly = true;
                dgvPhieuNhap.Columns["SoLuongNhap"].HeaderText = "Số lượng nhập";
                dgvPhieuNhap.Columns["SoLuongNhap"].Width = 100;
                dgvPhieuNhap.Columns["GiaNhap"].HeaderText = "Giá nhập";
                dgvPhieuNhap.Columns["GiaNhap"].Width = 120;
                dgvPhieuNhap.Columns["GiaNhap"].DefaultCellStyle.Format = "N0";
                dgvPhieuNhap.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvPhieuNhap.Columns["ThanhTien"].ReadOnly = true;
                dgvPhieuNhap.Columns["ThanhTien"].Width = 140;
                dgvPhieuNhap.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            }
        }

        private void txtTimKiemSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemSP.ForeColor == System.Drawing.Color.Gray) return;

            if (dtSanPham != null)
            {
                DataView dv = dtSanPham.DefaultView;
                dv.RowFilter = $"TenHang LIKE '%{txtTimKiemSP.Text.Trim()}%'";
                dgvKetQuaTimKiem.DataSource = dv;
            }
        }

        private void txtTimKiemSP_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemSP.Text == "🔍 Nhập tên sản phẩm...")
            {
                txtTimKiemSP.Text = "";
                txtTimKiemSP.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTimKiemSP_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemSP.Text))
            {
                txtTimKiemSP.Text = "🔍 Nhập tên sản phẩm...";
                txtTimKiemSP.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void dgvKetQuaTimKiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKetQuaTimKiem.Rows[e.RowIndex];
                int maHang = Convert.ToInt32(row.Cells["MaHang"].Value);
                string tenHang = row.Cells["TenHang"].Value.ToString();
                decimal giaBan = Convert.ToDecimal(row.Cells["GiaBan"].Value);

                ThemVaoPhieuNhap(maHang, tenHang, giaBan);
            }
        }

        private void ThemVaoPhieuNhap(int maHang, string tenHang, decimal giaBan)
        {
            DataRow[] existingRows = dtPhieuNhap.Select($"MaHang = {maHang}");
            
            if (existingRows.Length > 0)
            {
                int soLuongHienTai = Convert.ToInt32(existingRows[0]["SoLuongNhap"]);
                existingRows[0]["SoLuongNhap"] = soLuongHienTai + 1;
            }
            else
            {
                DataRow newRow = dtPhieuNhap.NewRow();
                newRow["MaHang"] = maHang;
                newRow["TenHang"] = tenHang;
                newRow["SoLuongNhap"] = 1;
                newRow["GiaNhap"] = giaBan * 0.7m;
                dtPhieuNhap.Rows.Add(newRow);
            }

            TinhTongTien();
        }

        private void dgvPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dgvPhieuNhap.Columns[e.ColumnIndex].Name;
                
                if (columnName == "SoLuongNhap" || columnName == "GiaNhap")
                {
                    DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];
                    
                    if (columnName == "SoLuongNhap")
                    {
                        int soLuong = 0;
                        if (int.TryParse(row.Cells["SoLuongNhap"].Value?.ToString(), out soLuong))
                        {
                            if (soLuong <= 0)
                            {
                                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                row.Cells["SoLuongNhap"].Value = 1;
                                return;
                            }
                        }
                        else
                        {
                            row.Cells["SoLuongNhap"].Value = 1;
                        }
                    }
                    
                    if (columnName == "GiaNhap")
                    {
                        decimal giaNhap = 0;
                        if (decimal.TryParse(row.Cells["GiaNhap"].Value?.ToString(), out giaNhap))
                        {
                            if (giaNhap <= 0)
                            {
                                MessageBox.Show("Giá nhập phải lớn hơn 0!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                row.Cells["GiaNhap"].Value = 1000;
                                return;
                            }
                        }
                        else
                        {
                            row.Cells["GiaNhap"].Value = 1000;
                        }
                    }

                    TinhTongTien();
                }
            }
        }

        private void dgvPhieuNhap_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này khỏi phiếu nhập?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                TinhTongTien();
            }
        }

        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataRow row in dtPhieuNhap.Rows)
            {
                tongTien += Convert.ToDecimal(row["ThanhTien"]);
            }
            lblTongTienNhap.Text = tongTien.ToString("N0") + " đ";
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dtPhieuNhap.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu nhập trống! Vui lòng thêm sản phẩm.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Xác nhận lưu phiếu nhập?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LuuPhieuNhap();
            }
        }

        private void LuuPhieuNhap()
        {
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                conn = DataAccess.GetConnection();
                conn.Open();
                transaction = conn.BeginTransaction();

                decimal tongTien = 0;
                foreach (DataRow row in dtPhieuNhap.Rows)
                {
                    tongTien += Convert.ToDecimal(row["ThanhTien"]);
                }

                string queryPhieuNhap = @"INSERT INTO PHIEUNHAP (MaNhanVien, MaNhaCungCap, NgayNhap, TongTienNhap) 
                                         OUTPUT INSERTED.MaPhieuNhap
                                         VALUES (@MaNhanVien, @MaNhaCungCap, @NgayNhap, @TongTienNhap)";
                SqlCommand cmdPhieuNhap = new SqlCommand(queryPhieuNhap, conn, transaction);
                cmdPhieuNhap.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                cmdPhieuNhap.Parameters.AddWithValue("@MaNhaCungCap", cboNhaCungCap.SelectedValue);
                cmdPhieuNhap.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                cmdPhieuNhap.Parameters.AddWithValue("@TongTienNhap", tongTien);

                int maPhieuNhap = (int)cmdPhieuNhap.ExecuteScalar();

                foreach (DataRow row in dtPhieuNhap.Rows)
                {
                    int maHang = Convert.ToInt32(row["MaHang"]);
                    int soLuong = Convert.ToInt32(row["SoLuongNhap"]);
                    decimal giaNhap = Convert.ToDecimal(row["GiaNhap"]);

                    string queryChiTiet = @"INSERT INTO NHAP (MaPhieuNhap, MaHang, SoLuongNhap, GiaNhap) 
                                           VALUES (@MaPhieuNhap, @MaHang, @SoLuongNhap, @GiaNhap)";
                    SqlCommand cmdChiTiet = new SqlCommand(queryChiTiet, conn, transaction);
                    cmdChiTiet.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                    cmdChiTiet.Parameters.AddWithValue("@MaHang", maHang);
                    cmdChiTiet.Parameters.AddWithValue("@SoLuongNhap", soLuong);
                    cmdChiTiet.Parameters.AddWithValue("@GiaNhap", giaNhap);
                    cmdChiTiet.ExecuteNonQuery();

                    string queryUpdateKho = @"UPDATE HANGHOA 
                                             SET SoLuong = SoLuong + @SoLuong 
                                             WHERE MaHang = @MaHang";
                    SqlCommand cmdUpdateKho = new SqlCommand(queryUpdateKho, conn, transaction);
                    cmdUpdateKho.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmdUpdateKho.Parameters.AddWithValue("@MaHang", maHang);
                    cmdUpdateKho.ExecuteNonQuery();
                }

                transaction.Commit();
                
                // Hỏi người dùng có muốn in phiếu nhập không
                DialogResult resultIn = MessageBox.Show(
                    $"Lưu phiếu nhập thành công!\nMã phiếu nhập: {maPhieuNhap}\nTổng tiền: {tongTien:N0} đ\n\nBạn có muốn in phiếu nhập không?",
                    "Thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultIn == DialogResult.Yes)
                {
                    frmXemTruocIn formIn = new frmXemTruocIn(maPhieuNhap, "PhieuNhap");
                    formIn.ShowDialog();
                }

                dtPhieuNhap.Clear();
                txtGhiChu.Clear();
                TinhTongTien();
                LoadSanPham();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Lỗi lưu phiếu nhập: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn?.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dtPhieuNhap.Rows.Count == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy phiếu nhập này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dtPhieuNhap.Clear();
                txtGhiChu.Clear();
                TinhTongTien();
                MessageBox.Show("Đã hủy phiếu nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            frmLichSuPhieuNhap form = new frmLichSuPhieuNhap();
            form.ShowDialog();
        }
    }
}
