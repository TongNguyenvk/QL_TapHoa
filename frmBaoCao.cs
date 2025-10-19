using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TapHoa.DAL;

namespace TapHoa
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
            
            LoadNhanVien();
            LoadLoaiHang();
            LoadBaoCaoDoanhThu();
            LoadBaoCaoTonKho();
        }

        private void LoadNhanVien()
        {
            try
            {
                string query = "SELECT MaNhanVien, TenNhanVien FROM NHANVIEN ORDER BY TenNhanVien";
                DataTable dt = DataAccess.ExecuteQuery(query);

                DataRow allRow = dt.NewRow();
                allRow["MaNhanVien"] = 0;
                allRow["TenNhanVien"] = "-- Tất cả nhân viên --";
                dt.Rows.InsertAt(allRow, 0);

                cboNhanVien.DataSource = dt;
                cboNhanVien.DisplayMember = "TenNhanVien";
                cboNhanVien.ValueMember = "MaNhanVien";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLoaiHang()
        {
            try
            {
                string query = "SELECT MaLoaiHang, TenLoaiHang FROM LOAIHANG ORDER BY TenLoaiHang";
                DataTable dt = DataAccess.ExecuteQuery(query);

                DataRow allRow = dt.NewRow();
                allRow["MaLoaiHang"] = 0;
                allRow["TenLoaiHang"] = "-- Tất cả loại hàng --";
                dt.Rows.InsertAt(allRow, 0);

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

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            LoadBaoCaoDoanhThu();
        }

        private void LoadBaoCaoDoanhThu()
        {
            try
            {
                string query = @"SELECT h.MaHoaDon, h.NgayBan, nv.TenNhanVien, h.TongTien
                                FROM HOADON h
                                INNER JOIN NHANVIEN nv ON h.MaNhanVien = nv.MaNhanVien
                                WHERE h.NgayBan BETWEEN @TuNgay AND @DenNgay";

                int maNhanVien = Convert.ToInt32(cboNhanVien.SelectedValue);
                if (maNhanVien > 0)
                {
                    query += " AND h.MaNhanVien = @MaNhanVien";
                }

                query += " ORDER BY h.NgayBan DESC";

                SqlParameter[] parameters = maNhanVien > 0 
                    ? new SqlParameter[] {
                        new SqlParameter("@TuNgay", dtpTuNgay.Value.Date),
                        new SqlParameter("@DenNgay", dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1)),
                        new SqlParameter("@MaNhanVien", maNhanVien)
                    }
                    : new SqlParameter[] {
                        new SqlParameter("@TuNgay", dtpTuNgay.Value.Date),
                        new SqlParameter("@DenNgay", dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1))
                    };

                DataTable dt = DataAccess.ExecuteQuery(query, parameters);
                dgvDoanhThu.DataSource = dt;

                if (dgvDoanhThu.Columns.Count > 0)
                {
                    dgvDoanhThu.Columns["MaHoaDon"].HeaderText = "Mã HĐ";
                    dgvDoanhThu.Columns["MaHoaDon"].Width = 80;
                    dgvDoanhThu.Columns["NgayBan"].HeaderText = "Ngày bán";
                    dgvDoanhThu.Columns["NgayBan"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvDoanhThu.Columns["TenNhanVien"].HeaderText = "Nhân viên";
                    dgvDoanhThu.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgvDoanhThu.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                    dgvDoanhThu.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                decimal tongDoanhThu = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongDoanhThu += Convert.ToDecimal(row["TongTien"]);
                }
                lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo doanh thu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemTonKho_Click(object sender, EventArgs e)
        {
            LoadBaoCaoTonKho();
        }

        private void LoadBaoCaoTonKho()
        {
            try
            {
                string query = @"SELECT h.MaHang, h.TenHang, lh.TenLoaiHang, h.SoLuong, h.GiaBan,
                                (h.SoLuong * h.GiaBan) AS GiaTriTonKho
                                FROM HANGHOA h
                                INNER JOIN LOAIHANG lh ON h.MaLoaiHang = lh.MaLoaiHang";

                int maLoaiHang = Convert.ToInt32(cboLoaiHang.SelectedValue);
                if (maLoaiHang > 0)
                {
                    query += " WHERE h.MaLoaiHang = @MaLoaiHang";
                }

                query += " ORDER BY h.TenHang";

                SqlParameter[] parameters = maLoaiHang > 0
                    ? new SqlParameter[] { new SqlParameter("@MaLoaiHang", maLoaiHang) }
                    : null;

                DataTable dt = DataAccess.ExecuteQuery(query, parameters);
                dgvTonKho.DataSource = dt;

                if (dgvTonKho.Columns.Count > 0)
                {
                    dgvTonKho.Columns["MaHang"].HeaderText = "Mã";
                    dgvTonKho.Columns["MaHang"].Width = 60;
                    dgvTonKho.Columns["TenHang"].HeaderText = "Tên sản phẩm";
                    dgvTonKho.Columns["TenLoaiHang"].HeaderText = "Loại hàng";
                    dgvTonKho.Columns["TenLoaiHang"].Width = 150;
                    dgvTonKho.Columns["SoLuong"].HeaderText = "Tồn kho";
                    dgvTonKho.Columns["SoLuong"].Width = 100;
                    dgvTonKho.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvTonKho.Columns["GiaBan"].HeaderText = "Giá bán";
                    dgvTonKho.Columns["GiaBan"].Width = 120;
                    dgvTonKho.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
                    dgvTonKho.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvTonKho.Columns["GiaTriTonKho"].HeaderText = "Giá trị tồn";
                    dgvTonKho.Columns["GiaTriTonKho"].Width = 150;
                    dgvTonKho.Columns["GiaTriTonKho"].DefaultCellStyle.Format = "N0";
                    dgvTonKho.Columns["GiaTriTonKho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo tồn kho: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKetXuatDoanhThu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng kết xuất Excel đang được phát triển.\n\n" +
                "Bạn có thể sử dụng thư viện EPPlus hoặc ClosedXML để xuất dữ liệu ra Excel.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKetXuatTonKho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng kết xuất Excel đang được phát triển.\n\n" +
                "Bạn có thể sử dụng thư viện EPPlus hoặc ClosedXML để xuất dữ liệu ra Excel.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
