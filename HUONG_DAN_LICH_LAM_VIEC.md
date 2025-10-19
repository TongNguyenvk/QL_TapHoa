# Hướng dẫn Form Quản lý Lịch làm việc

## Tổng quan
Form quản lý lịch làm việc được thiết kế với bố cục 3 panel để quản lý ca làm việc của nhân viên một cách trực quan và hiệu quả.

## Cấu trúc giao diện

### 1. Panel Trái: Lựa chọn & Lọc
**MonthCalendar (Chọn ngày)**
- Chọn một ngày hoặc khoảng ngày (tối đa 7 ngày)
- Lịch làm việc sẽ được lọc theo ngày đã chọn
- Mặc định hiển thị ngày hiện tại

**CheckedListBox (Danh sách nhân viên)**
- Hiển thị tất cả nhân viên trong hệ thống
- Có thể chọn/bỏ chọn nhiều nhân viên
- Mặc định tất cả nhân viên được chọn
- Lịch làm việc sẽ được lọc theo nhân viên đã chọn

### 2. Panel Giữa: Hiển thị Lịch
**DataGridView - Lịch làm việc**
- Hiển thị danh sách ca làm việc theo bộ lọc
- Các cột:
  - Mã lịch
  - Tên nhân viên
  - Ngày làm việc
  - Giờ bắt đầu
  - Giờ kết thúc
  - Ghi chú
- Sắp xếp theo ngày và giờ bắt đầu
- Click vào một ca để xem chi tiết

### 3. Panel Phải: Chi tiết Ca làm việc
**Thông tin ca**
- **Chọn nhân viên**: ComboBox chọn nhân viên
- **Ngày làm**: DateTimePicker chọn ngày
- **Giờ bắt đầu**: DateTimePicker chọn giờ (format Time)
- **Giờ kết thúc**: DateTimePicker chọn giờ (format Time)
- **Ghi chú**: TextBox nhập ghi chú (tùy chọn)

**Các nút chức năng**
- **Thêm ca mới** (màu xanh lá): Bắt đầu thêm ca mới
- **Lưu** (màu xanh lá): Lưu ca làm việc (chỉ khi đang thêm/sửa)
- **Bỏ qua** (màu xám): Hủy thao tác thêm/sửa
- **Xóa ca** (màu đỏ): Xóa ca làm việc đã chọn

## Quy trình sử dụng

### Xem lịch làm việc
1. Chọn khoảng ngày trên MonthCalendar
2. Chọn/bỏ chọn nhân viên muốn xem
3. Danh sách ca làm việc sẽ tự động cập nhật

### Thêm ca làm việc mới
1. Click nút **Thêm ca mới**
2. Chọn nhân viên
3. Chọn ngày làm việc
4. Chọn giờ bắt đầu (mặc định 08:00)
5. Chọn giờ kết thúc (mặc định 17:00)
6. Nhập ghi chú nếu cần
7. Click nút **Lưu**
8. Hệ thống sẽ kiểm tra:
   - Nhân viên đã được chọn
   - Giờ kết thúc phải sau giờ bắt đầu
9. Thông báo thành công

### Sửa ca làm việc
1. Click vào ca làm việc trong danh sách
2. Thông tin ca sẽ hiển thị ở panel phải
3. Chỉnh sửa thông tin cần thiết
4. Click nút **Lưu**
5. Thông báo thành công

### Xóa ca làm việc
1. Click vào ca làm việc cần xóa
2. Click nút **Xóa ca**
3. Xác nhận xóa
4. Thông báo thành công

### Hủy thao tác
- Click nút **Bỏ qua** để hủy thao tác thêm/sửa
- Form sẽ trở về trạng thái xem

## Tính năng nổi bật

### 1. Lọc linh hoạt
- Lọc theo ngày/khoảng ngày
- Lọc theo nhiều nhân viên cùng lúc
- Cập nhật real-time khi thay đổi bộ lọc

### 2. Giao diện trực quan
- MonthCalendar dễ chọn ngày
- CheckedListBox dễ chọn nhân viên
- DataGridView hiển thị rõ ràng
- Panel chi tiết tách biệt

### 3. Validation đầy đủ
- Kiểm tra nhân viên đã chọn
- Kiểm tra giờ kết thúc > giờ bắt đầu
- Thông báo lỗi rõ ràng

### 4. Quản lý trạng thái
- Enable/Disable controls theo trạng thái
- Nút chức năng thay đổi theo ngữ cảnh
- Không cho phép thao tác không hợp lệ

## Lưu ý quan trọng

### Giờ làm việc
- Giờ bắt đầu mặc định: 08:00
- Giờ kết thúc mặc định: 17:00
- Có thể tùy chỉnh theo nhu cầu
- Giờ kết thúc phải sau giờ bắt đầu

### Chọn ngày
- Có thể chọn tối đa 7 ngày liên tiếp
- Phù hợp để xem lịch theo tuần
- Chọn 1 ngày để xem chi tiết ngày đó

### Lọc nhân viên
- Mặc định hiển thị tất cả nhân viên
- Bỏ chọn để ẩn lịch của nhân viên đó
- Hữu ích khi muốn tập trung vào một số nhân viên

## Ví dụ sử dụng

### Sắp xếp lịch tuần
1. Chọn ngày đầu tuần trên calendar
2. Kéo chọn đến ngày cuối tuần (7 ngày)
3. Xem tổng quan lịch cả tuần
4. Thêm ca cho từng nhân viên từng ngày

### Kiểm tra lịch một nhân viên
1. Bỏ chọn tất cả nhân viên
2. Chỉ chọn nhân viên cần xem
3. Chọn khoảng thời gian trên calendar
4. Xem lịch chi tiết của nhân viên đó

### Sửa ca làm việc hàng loạt
1. Lọc theo ngày và nhân viên
2. Click vào từng ca cần sửa
3. Chỉnh sửa thông tin
4. Lưu từng ca

## Cải tiến trong tương lai
- Kéo thả để thay đổi ca
- Copy/Paste ca làm việc
- Tạo mẫu ca làm việc
- Xung đột ca làm việc (cảnh báo trùng lịch)
- Thống kê giờ làm việc
- Export lịch ra Excel/PDF
- Gửi thông báo lịch cho nhân viên
- Tích hợp với chấm công
