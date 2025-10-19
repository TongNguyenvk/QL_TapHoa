# 📈 Hướng dẫn Dashboard Trực quan

## Tổng quan
Module Dashboard cung cấp các biểu đồ trực quan giúp Quản lý có cái nhìn tổng quan nhanh chóng về tình hình kinh doanh.

## Tính năng

### 1. Tab Dashboard Trực quan
- Được đặt làm tab đầu tiên trong form Báo cáo
- Tự động load dữ liệu khi người dùng chuyển sang tab này
- Giao diện chia làm 2 phần: Trái và Phải

### 2. Biểu đồ Doanh thu theo Tháng (Bên trái)
**Mô tả:**
- Biểu đồ cột hiển thị doanh thu của 12 tháng trong năm hiện tại
- Trục X: Các tháng (Tháng 1 đến Tháng 12)
- Trục Y: Tổng doanh thu (VNĐ)

**Tính năng:**
- Hiển thị đầy đủ 12 tháng, kể cả tháng chưa có dữ liệu (giá trị = 0)
- Tooltip: Khi di chuột qua cột sẽ hiển thị chi tiết "Tháng X: XXX,XXX đ"
- Màu sắc: Xanh lá (#28A745) theo theme Green Harmony

**Dữ liệu:**
```sql
SELECT MONTH(NgayBan) AS Thang, SUM(TongTien) AS TongDoanhThu
FROM HOADON
WHERE YEAR(NgayBan) = @Nam
GROUP BY MONTH(NgayBan)
ORDER BY MONTH(NgayBan)
```

### 3. Biểu đồ Top 5 Sản phẩm Bán chạy (Bên phải)
**Mô tả:**
- Biểu đồ tròn (Pie Chart) hiển thị 5 sản phẩm có doanh thu cao nhất trong tháng hiện tại
- Mỗi "miếng bánh" đại diện cho một sản phẩm

**Tính năng:**
- Label hiển thị phần trăm doanh thu của từng sản phẩm
- Legend hiển thị tên sản phẩm
- Tooltip: Khi di chuột qua sẽ hiển thị:
  - Tên sản phẩm
  - Doanh thu (VNĐ)
  - Tỷ lệ phần trăm
- Màu sắc: Bảng màu Green Harmony với 5 màu khác nhau

**Dữ liệu:**
```sql
SELECT TOP 5 h.TenHang, SUM(b.SoLuongBan * b.DonGia) AS DoanhThu
FROM BAN b
INNER JOIN HOADON hd ON b.MaHoaDon = hd.MaHoaDon
INNER JOIN HANGHOA h ON b.MaHang = h.MaHang
WHERE MONTH(hd.NgayBan) = @Thang AND YEAR(hd.NgayBan) = @Nam
GROUP BY h.TenHang
ORDER BY DoanhThu DESC
```

## Cách sử dụng

### Xem Dashboard
1. Mở form "Báo cáo" từ menu chính
2. Chọn tab "📈 Dashboard Trực quan"
3. Hệ thống sẽ tự động load và hiển thị:
   - Biểu đồ doanh thu theo tháng (năm hiện tại)
   - Biểu đồ top 5 sản phẩm bán chạy (tháng hiện tại)

### Xem chi tiết
- Di chuột qua các cột hoặc miếng bánh để xem thông tin chi tiết
- Tooltip sẽ hiển thị số liệu chính xác

### Làm mới dữ liệu
- Chuyển sang tab khác rồi quay lại tab Dashboard để làm mới dữ liệu

## Màu sắc (Green Harmony Theme)
- Màu chính: #28A745 (Green)
- Màu phụ 1: #198754 (Dark Green)
- Màu phụ 2: #6C757D (Gray)
- Màu phụ 3: #FFC107 (Yellow)
- Màu phụ 4: #17A2B8 (Cyan)

## Lưu ý kỹ thuật

### Thư viện sử dụng
- `System.Windows.Forms.DataVisualization.Charting` (có sẵn trong .NET Framework)
- Không cần cài đặt thêm package

### Cấu trúc code
**frmBaoCao.cs:**
- `InitializeCharts()`: Khởi tạo cấu hình biểu đồ
- `LoadDashboardData()`: Load dữ liệu cho cả 2 biểu đồ
- `LoadDoanhThuTheoThang()`: Load dữ liệu biểu đồ cột
- `LoadTopSanPham()`: Load dữ liệu biểu đồ tròn
- `tabControl_SelectedIndexChanged()`: Event khi chuyển tab

**frmBaoCao.Designer.cs:**
- Thêm `tabDashboard` (TabPage)
- Thêm `chartDoanhThuTheoThang` (Chart control)
- Thêm `chartTopSanPham` (Chart control)

### Xử lý trường hợp đặc biệt
1. **Không có dữ liệu:**
   - Biểu đồ cột: Hiển thị tất cả tháng với giá trị 0
   - Biểu đồ tròn: Hiển thị thông báo "(Chưa có dữ liệu)"

2. **Tháng chưa có giao dịch:**
   - Vẫn hiển thị tháng đó với giá trị 0

3. **Ít hơn 5 sản phẩm:**
   - Hiển thị số sản phẩm thực tế có trong tháng

## Lợi ích
- ✅ Cái nhìn tổng quan nhanh chóng về doanh thu
- ✅ Nhận biết xu hướng kinh doanh theo tháng
- ✅ Xác định sản phẩm bán chạy để tối ưu kho hàng
- ✅ Hỗ trợ ra quyết định kinh doanh dựa trên dữ liệu
- ✅ Giao diện trực quan, dễ hiểu

## Mở rộng trong tương lai
- Thêm bộ lọc theo năm cho biểu đồ doanh thu
- Thêm biểu đồ so sánh doanh thu giữa các năm
- Thêm biểu đồ phân tích theo loại hàng
- Thêm biểu đồ hiệu suất nhân viên
- Export biểu đồ ra file ảnh
