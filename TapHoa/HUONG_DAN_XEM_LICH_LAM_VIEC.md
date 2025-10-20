# 📅 Hướng dẫn Xem Lịch làm việc

## Tổng quan
Form **Xem Lịch làm việc** là chức năng cho phép nhân viên xem lịch làm việc cá nhân của mình. Đây là form **chỉ đọc (read-only)**, nhân viên không thể thêm, sửa hoặc xóa lịch.

## Đối tượng sử dụng
- ✅ **Quản lý** - Có thể xem lịch của chính mình
- ✅ **Nhân viên Bán hàng** - Có thể xem lịch của chính mình
- ✅ **Nhân viên Kho** - Có thể xem lịch của chính mình

## Cách truy cập
1. Đăng nhập vào hệ thống
2. Chọn menu **Hệ thống** → **📅 Xem Lịch làm việc**
3. Form sẽ hiển thị lịch làm việc của nhân viên đang đăng nhập

## Giao diện

### 1. Panel Trên (Header)
- **Tiêu đề:** "📅 LỊCH LÀM VIỆC CỦA TÔI"
- **Thông tin nhân viên:**
  - Tên nhân viên
  - Vai trò
- **Màu nền:** Xanh lá #28A745 (Green Harmony)

### 2. Panel Trái (Calendar)
**MonthCalendar Control:**
- Cho phép chọn ngày, tuần hoặc tháng
- Hỗ trợ chọn nhiều ngày (tối đa 31 ngày)
- Tự động highlight ngày hiện tại

**Nút chức năng:**
- **📅 Tuần này:** Chọn nhanh tuần hiện tại (Thứ 2 → Chủ nhật)
- **📆 Tháng này:** Chọn nhanh tháng hiện tại

### 3. Panel Chính (DataGridView)
**Hiển thị lịch làm việc:**
- **Ngày làm việc:** Format "dd/MM/yyyy (dddd)" - Ví dụ: "20/10/2025 (Thứ Hai)"
- **Giờ bắt đầu:** Format "HH:mm" - Ví dụ: "08:00"
- **Giờ kết thúc:** Format "HH:mm" - Ví dụ: "17:00"
- **Ghi chú:** Mô tả ca làm việc

**Đặc điểm:**
- Read-only (không thể chỉnh sửa)
- Sắp xếp theo ngày và giờ bắt đầu
- Màu sắc theo theme Green Harmony

### 4. Panel Dưới (Footer)
- **Label thống kê:** Hiển thị số ca làm việc và khoảng thời gian
  - Ví dụ: "Tìm thấy 5 ca làm việc từ 14/10/2025 đến 20/10/2025"
- **Nút Đóng:** Đóng form

## Tính năng

### 1. Load lịch tự động
- Khi form mở, tự động load lịch làm việc của **tuần hiện tại**
- Tuần được tính từ Thứ 2 đến Chủ nhật

### 2. Chọn ngày trên Calendar
- Click vào một ngày: Xem lịch của ngày đó
- Kéo chọn nhiều ngày: Xem lịch của khoảng thời gian đó
- Mỗi lần thay đổi selection, DataGridView tự động cập nhật

### 3. Nút "Tuần này"
- Click để chọn nhanh tuần hiện tại
- Tuần bắt đầu từ Thứ 2 và kết thúc Chủ nhật
- Tự động load lịch của tuần

### 4. Nút "Tháng này"
- Click để chọn nhanh tháng hiện tại
- Từ ngày 1 đến ngày cuối tháng
- Tự động load lịch của tháng

## Quy trình sử dụng

### Xem lịch tuần này
1. Mở form "Xem Lịch làm việc"
2. Form tự động hiển thị lịch tuần hiện tại
3. Xem thông tin ca làm việc trong DataGridView

### Xem lịch ngày cụ thể
1. Click vào ngày muốn xem trên MonthCalendar
2. DataGridView tự động cập nhật lịch của ngày đó

### Xem lịch khoảng thời gian
1. Click và kéo trên MonthCalendar để chọn nhiều ngày
2. DataGridView hiển thị tất cả ca làm việc trong khoảng thời gian đó

### Xem lịch tháng
1. Click nút "📆 Tháng này"
2. Xem toàn bộ lịch làm việc trong tháng

## Dữ liệu hiển thị

### SQL Query
```sql
SELECT NgayLamViec, GioBatDau, GioKetThuc, MoTa
FROM LICHLAMVIEC
WHERE MaNhanVien = @MaNhanVien 
AND NgayLamViec BETWEEN @TuNgay AND @DenNgay
ORDER BY NgayLamViec, GioBatDau
```

### Thông tin nhân viên
```sql
SELECT TenNhanVien, vt.TenVaiTro 
FROM NHANVIEN nv
INNER JOIN VAITRO vt ON nv.MaVaiTro = vt.MaVaiTro
WHERE MaNhanVien = @MaNhanVien
```

## Thiết kế UI/UX

### Màu sắc (Green Harmony Theme)
- **Header:** #28A745 (Green)
- **Button chính:** #28A745 (Green)
- **Button phụ:** #198754 (Dark Green)
- **DataGridView header:** #28A745 (Green)
- **Selection:** #D4EDDA (Light Green)
- **Background:** #F8F9FA (Light Gray)

### Font chữ
- **Tiêu đề:** Segoe UI, 18pt, Bold
- **Label:** Segoe UI, 11pt
- **Button:** Segoe UI, 9.75pt, Bold
- **DataGridView:** Segoe UI, 9.75pt

### Kích thước
- **Form:** 1000 x 670 px
- **Panel trái:** 300px width
- **Panel chính:** Fill remaining
- **Header:** 100px height
- **Footer:** 70px height

## Lưu ý quan trọng

### 1. Chế độ Read-only
- ❌ Không thể thêm lịch mới
- ❌ Không thể sửa lịch
- ❌ Không thể xóa lịch
- ✅ Chỉ được xem lịch của chính mình

### 2. Phân quyền
- Menu "Xem Lịch làm việc" hiển thị cho **TẤT CẢ** vai trò
- Mỗi nhân viên chỉ xem được lịch của chính mình
- Không thể xem lịch của người khác

### 3. Dữ liệu
- Chỉ hiển thị lịch đã được Quản lý tạo trong form "Quản lý Lịch làm việc"
- Nếu chưa có lịch, DataGridView sẽ trống
- Label thống kê sẽ hiển thị "Tìm thấy 0 ca làm việc"

## So sánh với form Quản lý Lịch làm việc

| Tính năng | Xem Lịch làm việc | Quản lý Lịch làm việc |
|-----------|-------------------|----------------------|
| Đối tượng | Tất cả nhân viên | Chỉ Quản lý |
| Xem lịch | ✅ Của chính mình | ✅ Của tất cả nhân viên |
| Thêm lịch | ❌ | ✅ |
| Sửa lịch | ❌ | ✅ |
| Xóa lịch | ❌ | ✅ |
| Chọn nhân viên | ❌ | ✅ |
| MonthCalendar | ✅ | ✅ |

## Kỹ thuật

### Constructor
```csharp
public frmXemLichLamViec(int maNhanVien)
{
    InitializeComponent();
    this.maNhanVien = maNhanVien;
}
```

### Load Form
```csharp
private void frmXemLichLamViec_Load(object sender, EventArgs e)
{
    LoadThongTinNhanVien();
    monthCalendar.SelectionStart = DateTime.Today;
    monthCalendar.SelectionEnd = DateTime.Today.AddDays(6);
    LoadLichLamViec();
}
```

### Event DateChanged
```csharp
private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
{
    LoadLichLamViec();
}
```

## Lợi ích

### Cho nhân viên
- ✅ Dễ dàng xem lịch làm việc của mình
- ✅ Lên kế hoạch cá nhân tốt hơn
- ✅ Không bị nhầm lẫn ca làm việc
- ✅ Giao diện thân thiện, dễ sử dụng

### Cho quản lý
- ✅ Nhân viên chủ động xem lịch
- ✅ Giảm số lần hỏi về lịch làm việc
- ✅ Tăng tính minh bạch
- ✅ Nhân viên có trách nhiệm hơn

## Troubleshooting

### Không thấy lịch làm việc
**Nguyên nhân:**
- Quản lý chưa tạo lịch cho nhân viên
- Chọn sai khoảng thời gian

**Giải pháp:**
- Liên hệ Quản lý để được xếp lịch
- Thử chọn tháng hiện tại để xem

### Lỗi khi load form
**Nguyên nhân:**
- Lỗi kết nối database
- MaNhanVien không hợp lệ

**Giải pháp:**
- Kiểm tra kết nối database
- Đăng xuất và đăng nhập lại

## Mở rộng trong tương lai
- Thêm chức năng export lịch ra PDF
- Thêm thông báo nhắc nhở trước ca làm việc
- Thêm chức năng đăng ký đổi ca (nếu được phép)
- Tích hợp với calendar của điện thoại
- Hiển thị tổng số giờ làm việc trong tháng
