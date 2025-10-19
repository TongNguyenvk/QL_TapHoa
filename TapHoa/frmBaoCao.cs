using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using TapHoa.DAL;
using ClosedXML.Excel;

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
            
            // Khởi tạo biểu đồ
            InitializeCharts();
            
            // Load dữ liệu Dashboard ngay khi form mở (vì tab Dashboard là tab đầu tiên)
            LoadDashboardData();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi chuyển sang tab Dashboard, load dữ liệu biểu đồ
            if (tabControl.SelectedTab == tabDashboard)
            {
                LoadDashboardData();
            }
        }

        private void InitializeCharts()
        {
            // Cấu hình biểu đồ Doanh thu theo tháng
            chartDoanhThuTheoThang.Titles.Clear();
            chartDoanhThuTheoThang.Titles.Add("Doanh thu theo Tháng (Năm nay)");
            chartDoanhThuTheoThang.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);
            chartDoanhThuTheoThang.Titles[0].ForeColor = Color.FromArgb(40, 167, 69);
            
            chartDoanhThuTheoThang.ChartAreas[0].AxisX.Title = "Tháng";
            chartDoanhThuTheoThang.ChartAreas[0].AxisY.Title = "Doanh thu (VNĐ)";
            chartDoanhThuTheoThang.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            
            // Cấu hình biểu đồ Top sản phẩm
            chartTopSanPham.Titles.Clear();
            chartTopSanPham.Titles.Add("Top 5 Sản phẩm Bán chạy nhất (Tháng này)");
            chartTopSanPham.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);
            chartTopSanPham.Titles[0].ForeColor = Color.FromArgb(40, 167, 69);
            
            // Màu sắc cho biểu đồ tròn (Green Harmony theme)
            chartTopSanPham.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chartTopSanPham.PaletteCustomColors = new Color[] {
                Color.FromArgb(40, 167, 69),   // Green
                Color.FromArgb(25, 135, 84),   // Dark Green
                Color.FromArgb(108, 117, 125), // Gray
                Color.FromArgb(255, 193, 7),   // Yellow
                Color.FromArgb(23, 162, 184)   // Cyan
            };
        }

        private void LoadDashboardData()
        {
            LoadDoanhThuTheoThang();
            LoadTopSanPham();
        }

        private void LoadDoanhThuTheoThang()
        {
            try
            {
                int currentYear = DateTime.Now.Year;
                string query = @"SELECT MONTH(NgayBan) AS Thang, SUM(TongTien) AS TongDoanhThu
                                FROM HOADON
                                WHERE YEAR(NgayBan) = @Nam
                                GROUP BY MONTH(NgayBan)
                                ORDER BY MONTH(NgayBan)";

                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@Nam", currentYear)
                };

                DataTable dt = DataAccess.ExecuteQuery(query, parameters);

                // Xóa dữ liệu cũ
                chartDoanhThuTheoThang.Series[0].Points.Clear();

                // Thêm dữ liệu cho tất cả 12 tháng
                for (int thang = 1; thang <= 12; thang++)
                {
                    decimal doanhThu = 0;
                    DataRow[] rows = dt.Select($"Thang = {thang}");
                    if (rows.Length > 0)
                    {
                        doanhThu = Convert.ToDecimal(rows[0]["TongDoanhThu"]);
                    }

                    var point = chartDoanhThuTheoThang.Series[0].Points.AddXY($"Tháng {thang}", doanhThu);
                    chartDoanhThuTheoThang.Series[0].Points[point].ToolTip = 
                        $"Tháng {thang}: {doanhThu:N0} đ";
                }

                // Tùy chỉnh màu sắc
                chartDoanhThuTheoThang.Series[0].Color = Color.FromArgb(40, 167, 69);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải biểu đồ doanh thu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTopSanPham()
        {
            try
            {
                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;
                
                string query = @"SELECT TOP 5 h.TenHang, SUM(b.SoLuongBan * b.DonGia) AS DoanhThu
                                FROM BAN b
                                INNER JOIN HOADON hd ON b.MaHoaDon = hd.MaHoaDon
                                INNER JOIN HANGHOA h ON b.MaHang = h.MaHang
                                WHERE MONTH(hd.NgayBan) = @Thang AND YEAR(hd.NgayBan) = @Nam
                                GROUP BY h.TenHang
                                ORDER BY DoanhThu DESC";

                SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@Thang", currentMonth),
                    new SqlParameter("@Nam", currentYear)
                };

                DataTable dt = DataAccess.ExecuteQuery(query, parameters);

                // Xóa dữ liệu cũ
                chartTopSanPham.Series[0].Points.Clear();

                if (dt.Rows.Count == 0)
                {
                    chartTopSanPham.Titles[0].Text = "Top 5 Sản phẩm Bán chạy nhất (Tháng này)\n(Chưa có dữ liệu)";
                    return;
                }

                // Tính tổng doanh thu để tính phần trăm
                decimal tongDoanhThu = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongDoanhThu += Convert.ToDecimal(row["DoanhThu"]);
                }

                // Thêm dữ liệu vào biểu đồ
                foreach (DataRow row in dt.Rows)
                {
                    string tenHang = row["TenHang"].ToString();
                    decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);
                    decimal phanTram = (doanhThu / tongDoanhThu) * 100;

                    var point = chartTopSanPham.Series[0].Points.AddXY(tenHang, doanhThu);
                    chartTopSanPham.Series[0].Points[point].LegendText = tenHang;
                    chartTopSanPham.Series[0].Points[point].Label = $"{phanTram:F1}%";
                    chartTopSanPham.Series[0].Points[point].ToolTip = 
                        $"{tenHang}\nDoanh thu: {doanhThu:N0} đ\nTỷ lệ: {phanTram:F1}%";
                }

                // Cấu hình hiển thị
                chartTopSanPham.Series[0]["PieLabelStyle"] = "Outside";
                chartTopSanPham.Series[0]["PieLineColor"] = "Black";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải biểu đồ top sản phẩm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            ExportToExcel(dgvDoanhThu, "Báo cáo doanh thu");
        }

        private void btnKetXuatTonKho_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvTonKho, "Báo cáo tồn kho");
        }

        private void ExportToExcel(DataGridView dgv, string tenSheet)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Lưu file Excel",
                FileName = $"{tenSheet}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add(tenSheet);
                        int currentRow = 1;

                        // ===== PHẦN TIÊU ĐỀ =====
                        // Tên cửa hàng
                        worksheet.Cell(currentRow, 1).Value = "CỬA HÀNG TẠP HÓA";
                        worksheet.Cell(currentRow, 1).Style.Font.Bold = true;
                        worksheet.Cell(currentRow, 1).Style.Font.FontSize = 16;
                        worksheet.Cell(currentRow, 1).Style.Font.FontColor = XLColor.FromArgb(40, 167, 69);
                        currentRow++;

                        // Địa chỉ
                        worksheet.Cell(currentRow, 1).Value = "Địa chỉ: 123 Đường ABC, Quận XYZ, TP.HCM";
                        worksheet.Cell(currentRow, 1).Style.Font.FontSize = 10;
                        currentRow++;

                        // Điện thoại
                        worksheet.Cell(currentRow, 1).Value = "Điện thoại: 0123-456-789";
                        worksheet.Cell(currentRow, 1).Style.Font.FontSize = 10;
                        currentRow++;

                        // Dòng trống
                        currentRow++;

                        // Tên báo cáo
                        worksheet.Cell(currentRow, 1).Value = tenSheet.ToUpper();
                        worksheet.Cell(currentRow, 1).Style.Font.Bold = true;
                        worksheet.Cell(currentRow, 1).Style.Font.FontSize = 14;
                        worksheet.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet.Range(currentRow, 1, currentRow, dgv.Columns.Count).Merge();
                        currentRow++;

                        // Thông tin thời gian
                        if (tenSheet.Contains("doanh thu"))
                        {
                            worksheet.Cell(currentRow, 1).Value = $"Từ ngày: {dtpTuNgay.Value:dd/MM/yyyy} - Đến ngày: {dtpDenNgay.Value:dd/MM/yyyy}";
                            worksheet.Cell(currentRow, 1).Style.Font.Italic = true;
                            worksheet.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet.Range(currentRow, 1, currentRow, dgv.Columns.Count).Merge();
                            currentRow++;

                            // Nhân viên (nếu có lọc)
                            int maNhanVien = Convert.ToInt32(cboNhanVien.SelectedValue);
                            if (maNhanVien > 0)
                            {
                                worksheet.Cell(currentRow, 1).Value = $"Nhân viên: {cboNhanVien.Text}";
                                worksheet.Cell(currentRow, 1).Style.Font.Italic = true;
                                worksheet.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                worksheet.Range(currentRow, 1, currentRow, dgv.Columns.Count).Merge();
                                currentRow++;
                            }
                        }
                        else if (tenSheet.Contains("tồn kho"))
                        {
                            worksheet.Cell(currentRow, 1).Value = $"Ngày xuất báo cáo: {DateTime.Now:dd/MM/yyyy HH:mm}";
                            worksheet.Cell(currentRow, 1).Style.Font.Italic = true;
                            worksheet.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet.Range(currentRow, 1, currentRow, dgv.Columns.Count).Merge();
                            currentRow++;

                            // Loại hàng (nếu có lọc)
                            int maLoaiHang = Convert.ToInt32(cboLoaiHang.SelectedValue);
                            if (maLoaiHang > 0)
                            {
                                worksheet.Cell(currentRow, 1).Value = $"Loại hàng: {cboLoaiHang.Text}";
                                worksheet.Cell(currentRow, 1).Style.Font.Italic = true;
                                worksheet.Cell(currentRow, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                worksheet.Range(currentRow, 1, currentRow, dgv.Columns.Count).Merge();
                                currentRow++;
                            }
                        }

                        // Dòng trống
                        currentRow++;

                        // ===== PHẦN BẢNG DỮ LIỆU =====
                        int headerRow = currentRow;

                        // Ghi header
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            worksheet.Cell(headerRow, i + 1).Value = dgv.Columns[i].HeaderText;
                        }

                        // Định dạng header
                        var headerRange = worksheet.Range(headerRow, 1, headerRow, dgv.Columns.Count);
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.BackgroundColor = XLColor.FromArgb(40, 167, 69);
                        headerRange.Style.Font.FontColor = XLColor.White;
                        headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        currentRow++;

                        // Ghi dữ liệu
                        int dataStartRow = currentRow;
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv.Columns.Count; j++)
                            {
                                var cellValue = dgv.Rows[i].Cells[j].Value;
                                if (cellValue != null)
                                {
                                    var cell = worksheet.Cell(currentRow, j + 1);
                                    
                                    // Xử lý kiểu dữ liệu
                                    if (cellValue is DateTime)
                                    {
                                        cell.Value = (DateTime)cellValue;
                                        cell.Style.DateFormat.Format = "dd/MM/yyyy HH:mm";
                                    }
                                    else if (cellValue is decimal || cellValue is double || cellValue is int)
                                    {
                                        cell.Value = Convert.ToDouble(cellValue);
                                        cell.Style.NumberFormat.Format = "#,##0";
                                    }
                                    else
                                    {
                                        cell.Value = cellValue.ToString();
                                    }
                                }
                            }
                            currentRow++;
                        }

                        // ===== PHẦN TỔNG KẾT =====
                        currentRow++;
                        
                        // Tính tổng cho báo cáo doanh thu
                        if (tenSheet.Contains("doanh thu"))
                        {
                            decimal tongDoanhThu = 0;
                            for (int i = 0; i < dgv.Rows.Count; i++)
                            {
                                if (dgv.Rows[i].Cells["TongTien"].Value != null)
                                {
                                    tongDoanhThu += Convert.ToDecimal(dgv.Rows[i].Cells["TongTien"].Value);
                                }
                            }

                            worksheet.Cell(currentRow, dgv.Columns.Count - 1).Value = "TỔNG DOANH THU:";
                            worksheet.Cell(currentRow, dgv.Columns.Count - 1).Style.Font.Bold = true;
                            worksheet.Cell(currentRow, dgv.Columns.Count - 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                            
                            worksheet.Cell(currentRow, dgv.Columns.Count).Value = tongDoanhThu;
                            worksheet.Cell(currentRow, dgv.Columns.Count).Style.Font.Bold = true;
                            worksheet.Cell(currentRow, dgv.Columns.Count).Style.NumberFormat.Format = "#,##0";
                            worksheet.Cell(currentRow, dgv.Columns.Count).Style.Fill.BackgroundColor = XLColor.FromArgb(255, 255, 200);
                        }

                        // Tự động điều chỉnh độ rộng cột
                        worksheet.Columns().AdjustToContents();

                        // Thêm border cho bảng dữ liệu
                        var dataRange = worksheet.Range(headerRow, 1, currentRow - 1, dgv.Columns.Count);
                        dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                        // Lưu file
                        workbook.SaveAs(saveDialog.FileName);
                    }

                    var result = MessageBox.Show(
                        "Xuất file Excel thành công!\n\nBạn có muốn mở file vừa tạo không?",
                        "Thành công",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Process.Start(saveDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất file Excel:\n{ex.Message}",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
