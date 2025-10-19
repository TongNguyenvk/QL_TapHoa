using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using TapHoa.DAL;

namespace TapHoa
{
    public partial class frmXemTruocIn : Form
    {
        private int maGiaoDich;
        private string loaiPhieu; // "HoaDon" hoặc "PhieuNhap"
        private DataTable dtChiTiet;
        private DataRow drHeader;
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;

        public frmXemTruocIn(int maGiaoDich, string loaiPhieu)
        {
            InitializeComponent();
            this.maGiaoDich = maGiaoDich;
            this.loaiPhieu = loaiPhieu;
            
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            
            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
        }

        private void frmXemTruocIn_Load(object sender, EventArgs e)
        {
            LoadData();
            HienThiXemTruoc();
        }

        private void LoadData()
        {
            try
            {
                if (loaiPhieu == "HoaDon")
                {
                    // Lấy thông tin hóa đơn
                    string queryHeader = @"SELECT HD.MaHoaDon, HD.NgayBan, HD.TongTien, 
                                          NV.TenNhanVien
                                          FROM HOADON HD
                                          INNER JOIN NHANVIEN NV ON HD.MaNhanVien = NV.MaNhanVien
                                          WHERE HD.MaHoaDon = @Ma";
                    DataTable dtHeader = DataAccess.ExecuteQuery(queryHeader, 
                        new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Ma", maGiaoDich) });
                    
                    if (dtHeader.Rows.Count > 0)
                        drHeader = dtHeader.Rows[0];

                    // Lấy chi tiết hóa đơn
                    string queryDetail = @"SELECT HH.TenHang, B.SoLuongBan AS SoLuong, 
                                          B.DonGia, (B.SoLuongBan * B.DonGia) AS ThanhTien
                                          FROM BAN B
                                          INNER JOIN HANGHOA HH ON B.MaHang = HH.MaHang
                                          WHERE B.MaHoaDon = @Ma";
                    dtChiTiet = DataAccess.ExecuteQuery(queryDetail,
                        new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Ma", maGiaoDich) });
                }
                else // PhieuNhap
                {
                    // Lấy thông tin phiếu nhập
                    string queryHeader = @"SELECT PN.MaPhieuNhap, PN.NgayNhap, PN.TongTienNhap, 
                                          NV.TenNhanVien, NCC.TenNhaCungCap
                                          FROM PHIEUNHAP PN
                                          INNER JOIN NHANVIEN NV ON PN.MaNhanVien = NV.MaNhanVien
                                          INNER JOIN NHACUNGCAP NCC ON PN.MaNhaCungCap = NCC.MaNhaCungCap
                                          WHERE PN.MaPhieuNhap = @Ma";
                    DataTable dtHeader = DataAccess.ExecuteQuery(queryHeader,
                        new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Ma", maGiaoDich) });
                    
                    if (dtHeader.Rows.Count > 0)
                        drHeader = dtHeader.Rows[0];

                    // Lấy chi tiết phiếu nhập
                    string queryDetail = @"SELECT HH.TenHang, N.SoLuongNhap AS SoLuong, 
                                          N.GiaNhap AS DonGia, (N.SoLuongNhap * N.GiaNhap) AS ThanhTien
                                          FROM NHAP N
                                          INNER JOIN HANGHOA HH ON N.MaHang = HH.MaHang
                                          WHERE N.MaPhieuNhap = @Ma";
                    dtChiTiet = DataAccess.ExecuteQuery(queryDetail,
                        new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Ma", maGiaoDich) });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiXemTruoc()
        {
            if (drHeader == null || dtChiTiet == null)
            {
                lblThongTin.Text = "Không có dữ liệu để hiển thị";
                return;
            }

            string thongTin = "";
            
            if (loaiPhieu == "HoaDon")
            {
                thongTin = $@"
═══════════════════════════════════════════════════════════

                    🏪 CỬA HÀNG TẠP HÓA ABC
              Địa chỉ: 123 Đường ABC, TP.HCM
                    SĐT: 0123-456-789

═══════════════════════════════════════════════════════════
                      HÓA ĐƠN BÁN LẺ
═══════════════════════════════════════════════════════════

  Số HĐ:        {drHeader["MaHoaDon"]}
  Ngày bán:     {Convert.ToDateTime(drHeader["NgayBan"]):dd/MM/yyyy HH:mm}
  Nhân viên:    {drHeader["TenNhanVien"]}

───────────────────────────────────────────────────────────
";
            }
            else
            {
                thongTin = $@"
═══════════════════════════════════════════════════════════

                    🏪 CỬA HÀNG TẠP HÓA ABC
              Địa chỉ: 123 Đường ABC, TP.HCM
                    SĐT: 0123-456-789

═══════════════════════════════════════════════════════════
                      PHIẾU NHẬP KHO
═══════════════════════════════════════════════════════════

  Số PN:           {drHeader["MaPhieuNhap"]}
  Ngày nhập:       {Convert.ToDateTime(drHeader["NgayNhap"]):dd/MM/yyyy HH:mm}
  Nhân viên:       {drHeader["TenNhanVien"]}
  Nhà cung cấp:    {drHeader["TenNhaCungCap"]}

───────────────────────────────────────────────────────────
";
            }

            lblThongTin.Text = thongTin;

            // Hiển thị chi tiết
            dgvChiTiet.DataSource = dtChiTiet;
            
            if (dgvChiTiet.Columns.Count > 0)
            {
                dgvChiTiet.Columns["TenHang"].HeaderText = "Tên hàng";
                dgvChiTiet.Columns["TenHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvChiTiet.Columns["SoLuong"].HeaderText = "SL";
                dgvChiTiet.Columns["SoLuong"].Width = 50;
                dgvChiTiet.Columns["DonGia"].HeaderText = "Đơn giá";
                dgvChiTiet.Columns["DonGia"].Width = 100;
                dgvChiTiet.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dgvChiTiet.Columns["ThanhTien"].Width = 120;
                dgvChiTiet.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            }

            // Hiển thị tổng tiền
            decimal tongTien = loaiPhieu == "HoaDon" 
                ? Convert.ToDecimal(drHeader["TongTien"]) 
                : Convert.ToDecimal(drHeader["TongTienNhap"]);
            
            lblTongTien.Text = $"TỔNG TIỀN: {tongTien:N0} đ";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 12, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 10);
            Font fontSmall = new Font("Arial", 9);
            
            float yPos = 50;
            float leftMargin = 50;
            float rightMargin = e.PageBounds.Width - 50;

            // Tiêu đề cửa hàng
            string tenCuaHang = "CỬA HÀNG TẠP HÓA ABC";
            SizeF sizeTitle = g.MeasureString(tenCuaHang, fontTitle);
            g.DrawString(tenCuaHang, fontTitle, Brushes.Black, 
                (e.PageBounds.Width - sizeTitle.Width) / 2, yPos);
            yPos += sizeTitle.Height + 5;

            // Địa chỉ và SĐT
            string diaChi = "Địa chỉ: 123 Đường ABC, TP.HCM - SĐT: 0123-456-789";
            SizeF sizeDiaChi = g.MeasureString(diaChi, fontSmall);
            g.DrawString(diaChi, fontSmall, Brushes.Black,
                (e.PageBounds.Width - sizeDiaChi.Width) / 2, yPos);
            yPos += sizeDiaChi.Height + 10;

            // Tiêu đề phiếu
            string tieuDe = loaiPhieu == "HoaDon" ? "HÓA ĐƠN BÁN LẺ" : "PHIẾU NHẬP KHO";
            SizeF sizeTieuDe = g.MeasureString(tieuDe, fontHeader);
            g.DrawString(tieuDe, fontHeader, Brushes.Black,
                (e.PageBounds.Width - sizeTieuDe.Width) / 2, yPos);
            yPos += sizeTieuDe.Height + 15;

            // Thông tin phiếu
            if (loaiPhieu == "HoaDon")
            {
                g.DrawString($"Số HĐ: {drHeader["MaHoaDon"]}", fontNormal, Brushes.Black, leftMargin, yPos);
                yPos += 20;
                g.DrawString($"Ngày bán: {Convert.ToDateTime(drHeader["NgayBan"]):dd/MM/yyyy HH:mm}", 
                    fontNormal, Brushes.Black, leftMargin, yPos);
                yPos += 20;
                g.DrawString($"Nhân viên: {drHeader["TenNhanVien"]}", fontNormal, Brushes.Black, leftMargin, yPos);
                yPos += 25;
            }
            else
            {
                g.DrawString($"Số PN: {drHeader["MaPhieuNhap"]}", fontNormal, Brushes.Black, leftMargin, yPos);
                yPos += 20;
                g.DrawString($"Ngày nhập: {Convert.ToDateTime(drHeader["NgayNhap"]):dd/MM/yyyy HH:mm}", 
                    fontNormal, Brushes.Black, leftMargin, yPos);
                yPos += 20;
                g.DrawString($"Nhân viên: {drHeader["TenNhanVien"]}", fontNormal, Brushes.Black, leftMargin, yPos);
                yPos += 20;
                g.DrawString($"Nhà cung cấp: {drHeader["TenNhaCungCap"]}", fontNormal, Brushes.Black, leftMargin, yPos);
                yPos += 25;
            }

            // Đường kẻ
            g.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 10;

            // Header bảng
            g.DrawString("Tên hàng", fontNormal, Brushes.Black, leftMargin, yPos);
            g.DrawString("SL", fontNormal, Brushes.Black, leftMargin + 300, yPos);
            g.DrawString("Đơn giá", fontNormal, Brushes.Black, leftMargin + 350, yPos);
            g.DrawString("Thành tiền", fontNormal, Brushes.Black, leftMargin + 480, yPos);
            yPos += 20;

            g.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 10;

            // Chi tiết
            foreach (DataRow row in dtChiTiet.Rows)
            {
                g.DrawString(row["TenHang"].ToString(), fontNormal, Brushes.Black, leftMargin, yPos);
                g.DrawString(row["SoLuong"].ToString(), fontNormal, Brushes.Black, leftMargin + 300, yPos);
                g.DrawString(Convert.ToDecimal(row["DonGia"]).ToString("N0"), fontNormal, Brushes.Black, leftMargin + 350, yPos);
                g.DrawString(Convert.ToDecimal(row["ThanhTien"]).ToString("N0"), fontNormal, Brushes.Black, leftMargin + 480, yPos);
                yPos += 20;
            }

            // Đường kẻ
            yPos += 5;
            g.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 15;

            // Tổng tiền
            decimal tongTien = loaiPhieu == "HoaDon"
                ? Convert.ToDecimal(drHeader["TongTien"])
                : Convert.ToDecimal(drHeader["TongTienNhap"]);
            
            g.DrawString($"TỔNG TIỀN: {tongTien:N0} đ", fontHeader, Brushes.Black, leftMargin + 350, yPos);
            yPos += 40;

            // Lời cảm ơn
            string camOn = loaiPhieu == "HoaDon" ? "Cảm ơn quý khách! Hẹn gặp lại!" : "Đã nhập kho thành công!";
            SizeF sizeCamOn = g.MeasureString(camOn, fontNormal);
            g.DrawString(camOn, fontNormal, Brushes.Black,
                (e.PageBounds.Width - sizeCamOn.Width) / 2, yPos);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
