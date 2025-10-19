using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TapHoa.DAL;

namespace TapHoa
{
    public partial class frmBanHang : Form
    {
        private DataTable dtSanPham;
        private DataTable dtGioHang;
        private string tenNhanVien;
        private int maNhanVien;

        public frmBanHang(string tenNV, int maNV)
        {
            InitializeComponent();
            this.tenNhanVien = tenNV;
            this.maNhanVien = maNV;
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            txtNhanVien.Text = tenNhanVien;
            dtpNgayBan.Value = DateTime.Now;
            
            LoadSanPham();
            InitGioHang();
        }

        private void LoadSanPham()
        {
            try
            {
                string query = @"SELECT MaHang, TenHang, SoLuong, GiaBan 
                                FROM HANGHOA 
                                WHERE SoLuong > 0
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

        private void InitGioHang()
        {
            dtGioHang = new DataTable();
            dtGioHang.Columns.Add("MaHang", typeof(int));
            dtGioHang.Columns.Add("TenHang", typeof(string));
            dtGioHang.Columns.Add("SoLuong", typeof(int));
            dtGioHang.Columns.Add("DonGia", typeof(decimal));
            dtGioHang.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * DonGia");
            dtGioHang.Columns.Add("TonKho", typeof(int));

            dgvGioHang.DataSource = dtGioHang;

            if (dgvGioHang.Columns.Count > 0)
            {
                dgvGioHang.Columns["MaHang"].Visible = false;
                dgvGioHang.Columns["TonKho"].Visible = false;
                dgvGioHang.Columns["TenHang"].HeaderText = "Tên sản phẩm";
                dgvGioHang.Columns["TenHang"].ReadOnly = true;
                dgvGioHang.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvGioHang.Columns["SoLuong"].Width = 80;
                dgvGioHang.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvGioHang.Columns["DonGia"].ReadOnly = true;
                dgvGioHang.Columns["DonGia"].Width = 100;
                dgvGioHang.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvGioHang.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvGioHang.Columns["ThanhTien"].ReadOnly = true;
                dgvGioHang.Columns["ThanhTien"].Width = 120;
                dgvGioHang.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
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
                int tonKho = Convert.ToInt32(row.Cells["SoLuong"].Value);
                decimal giaBan = Convert.ToDecimal(row.Cells["GiaBan"].Value);

                ThemVaoGioHang(maHang, tenHang, tonKho, giaBan);
            }
        }

        private void ThemVaoGioHang(int maHang, string tenHang, int tonKho, decimal giaBan)
        {
            // Kiểm tra sản phẩm đã có trong giỏ hàng chưa
            DataRow[] existingRows = dtGioHang.Select($"MaHang = {maHang}");
            
            if (existingRows.Length > 0)
            {
                // Tăng số lượng
                int soLuongHienTai = Convert.ToInt32(existingRows[0]["SoLuong"]);
                if (soLuongHienTai + 1 > tonKho)
                {
                    MessageBox.Show($"Không đủ hàng trong kho! Tồn kho: {tonKho}", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existingRows[0]["SoLuong"] = soLuongHienTai + 1;
            }
            else
            {
                // Thêm mới
                DataRow newRow = dtGioHang.NewRow();
                newRow["MaHang"] = maHang;
                newRow["TenHang"] = tenHang;
                newRow["SoLuong"] = 1;
                newRow["DonGia"] = giaBan;
                newRow["TonKho"] = tonKho;
                dtGioHang.Rows.Add(newRow);
            }

            TinhTongTien();
        }

        private void dgvGioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvGioHang.Columns[e.ColumnIndex].Name == "SoLuong")
                {
                    DataGridViewRow row = dgvGioHang.Rows[e.RowIndex];
                    int soLuong = 0;
                    int tonKho = Convert.ToInt32(row.Cells["TonKho"].Value);

                    if (int.TryParse(row.Cells["SoLuong"].Value?.ToString(), out soLuong))
                    {
                        if (soLuong <= 0)
                        {
                            MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            row.Cells["SoLuong"].Value = 1;
                            return;
                        }

                        if (soLuong > tonKho)
                        {
                            MessageBox.Show($"Không đủ hàng trong kho! Tồn kho: {tonKho}", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            row.Cells["SoLuong"].Value = tonKho;
                            return;
                        }
                    }
                    else
                    {
                        row.Cells["SoLuong"].Value = 1;
                    }

                    TinhTongTien();
                }
            }
        }

        private void dgvGioHang_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này khỏi giỏ hàng?",
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
            foreach (DataRow row in dtGioHang.Rows)
            {
                tongTien += Convert.ToDecimal(row["ThanhTien"]);
            }
            lblTongTien.Text = tongTien.ToString("N0") + " đ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống! Vui lòng thêm sản phẩm.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Xác nhận thanh toán hóa đơn?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ThanhToan();
            }
        }

        private void ThanhToan()
        {
            SqlConnection conn = null;
            SqlTransaction transaction = null;

            try
            {
                conn = DataAccess.GetConnection();
                conn.Open();
                transaction = conn.BeginTransaction();

                // Tính tổng tiền
                decimal tongTien = 0;
                foreach (DataRow row in dtGioHang.Rows)
                {
                    tongTien += Convert.ToDecimal(row["ThanhTien"]);
                }

                // Thêm hóa đơn
                string queryHoaDon = @"INSERT INTO HOADON (MaNhanVien, NgayBan, TongTien) 
                                      OUTPUT INSERTED.MaHoaDon
                                      VALUES (@MaNhanVien, @NgayBan, @TongTien)";
                SqlCommand cmdHoaDon = new SqlCommand(queryHoaDon, conn, transaction);
                cmdHoaDon.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                cmdHoaDon.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
                cmdHoaDon.Parameters.AddWithValue("@TongTien", tongTien);

                int maHoaDon = (int)cmdHoaDon.ExecuteScalar();

                // Thêm chi tiết hóa đơn và cập nhật tồn kho
                foreach (DataRow row in dtGioHang.Rows)
                {
                    int maHang = Convert.ToInt32(row["MaHang"]);
                    int soLuong = Convert.ToInt32(row["SoLuong"]);
                    decimal donGia = Convert.ToDecimal(row["DonGia"]);

                    // Thêm chi tiết
                    string queryChiTiet = @"INSERT INTO BAN (MaHoaDon, MaHang, SoLuongBan, DonGia) 
                                           VALUES (@MaHoaDon, @MaHang, @SoLuongBan, @DonGia)";
                    SqlCommand cmdChiTiet = new SqlCommand(queryChiTiet, conn, transaction);
                    cmdChiTiet.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    cmdChiTiet.Parameters.AddWithValue("@MaHang", maHang);
                    cmdChiTiet.Parameters.AddWithValue("@SoLuongBan", soLuong);
                    cmdChiTiet.Parameters.AddWithValue("@DonGia", donGia);
                    cmdChiTiet.ExecuteNonQuery();

                    // Cập nhật tồn kho
                    string queryUpdateKho = @"UPDATE HANGHOA 
                                             SET SoLuong = SoLuong - @SoLuong 
                                             WHERE MaHang = @MaHang";
                    SqlCommand cmdUpdateKho = new SqlCommand(queryUpdateKho, conn, transaction);
                    cmdUpdateKho.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmdUpdateKho.Parameters.AddWithValue("@MaHang", maHang);
                    cmdUpdateKho.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show($"Thanh toán thành công!\nMã hóa đơn: {maHoaDon}\nTổng tiền: {tongTien:N0} đ",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form
                dtGioHang.Clear();
                txtGhiChu.Clear();
                TinhTongTien();
                LoadSanPham();
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn?.Close();
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (dtGioHang.Rows.Count == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy đơn hàng này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dtGioHang.Clear();
                txtGhiChu.Clear();
                TinhTongTien();
                MessageBox.Show("Đã hủy đơn hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
