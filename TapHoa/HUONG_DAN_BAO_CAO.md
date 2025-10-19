# Hướng dẫn Form Báo cáo

## Tổng quan
Form báo cáo cung cấp các báo cáo quan trọng về doanh thu và tồn kho với giao diện TabControl.

## Cấu trúc giao diện

### Tab 1: Báo cáo Doanh thu 📊

**Khu vực bộ lọc (Trên cùng)**
- **Từ ngày**: DateTimePicker chọn ngày bắt đầu
- **Đến ngày**: DateTimePicker chọn ngày kết thúc
- **Chọn nhân viên**: ComboBox (có tùy chọn "Tất cả")
- **Nút Xem báo cáo**: Hiển thị dữ liệu theo bộ lọc
- **Nút Kết xuất Excel**: Xuất báo cáo ra file Excel

**Khu vực hiển thị (Giữa)**
- DataGridView hiển thị danh sách hóa đơn:
  - Mã hóa đơn
  - Ngày bán
  - Nhân viên
  - Tổng tiền

**Khu vực tổng kết (Dưới cùng)**
- Hiển thị tổng doanh thu lớn, rõ ràng (màu xanh lá)

### Tab 2: Báo cáo Tồn kho 📦

**Khu vực bộ lọc (Trên cùng)**
- **Loại hàng**: ComboBox (có tùy chọn "Tất cả")
- **Nút Xem báo cáo**: Hiển thị dữ liệu theo bộ lọc
- **Nút Kết xuất Excel**: Xuất báo cáo ra file Excel

**Khu vực hiển thị (Giữa)**
- DataGridView hiển thị danh sách sản phẩm:
  - Mã sản phẩm
  - Tên sản phẩm
  - Loại hàng
  - Số lượng tồn kho
  - Giá bán
  - Giá trị tồn kho (Số lượng × Giá bán)

## Quy trình sử dụng

### Xem báo cáo Doanh thu

1. **Chọn khoảng thời gian**
   - Click vào "Từ ngày" và chọn ngày bắt đầu
   - Click vào "Đến ngày" và chọn ngày kết thúc
   - Mặc định: 1 tháng gần nhất

2. **Chọn nhân viên (tùy chọn)**
   - Chọn "Tất cả nhân viên" để xem tổng hợp
   - Hoặc chọn một nhân viên cụ thể

3. **Xem báo cáo**
   - Click nút "Xem báo cáo"
   - Danh sách hóa đơn sẽ hiển thị
   - Tổng doanh thu được tính tự động

4. **Phân tích dữ liệu**
   - Xem chi tiết từng hóa đơn
   - So sánh doanh thu giữa các nhân viên
   - Theo dõi xu hướng theo thời gian

### Xem báo cáo Tồn kho

1. **Chọn loại hàng (tùy chọn)**
   - Chọn "Tất cả loại hàng" để xem tổng hợp
   - Hoặc chọn một loại hàng cụ thể

2. **Xem báo cáo**
   - Click nút "Xem báo cáo"
   - Danh sách sản phẩm sẽ hiển thị
   - Tự động tính giá trị tồn kho

3. **Phân tích dữ liệu**
   - Xem sản phẩm nào còn nhiều/ít
   - Tính giá trị tồn kho tổng
   - Lập kế hoạch nhập hàng

### Kết xuất Excel

1. Click nút "Kết xuất Excel"
2. Chọn vị trí lưu file
3. File Excel sẽ được tạo với dữ liệu hiện tại

**Lưu ý**: Chức năng này cần cài đặt thư viện EPPlus hoặc ClosedXML

## Tính năng nổi bật

### 1. Lọc linh hoạt
- Lọc theo nhiều tiêu chí
- Kết hợp các bộ lọc
- Cập nhật real-time

### 2. Hiển thị trực quan
- DataGridView rõ ràng
- Format số tiền chuẩn
- Màu sắc dễ nhìn

### 3. Tính toán tự động
- Tổng doanh thu
- Giá trị tồn kho
- Không cần tính thủ công

### 4. Xuất báo cáo
- Kết xuất ra Excel
- Dễ chia sẻ
- Tiện lưu trữ

## Các trường hợp sử dụng

### Báo cáo cuối ngày
1. Chọn ngày hôm nay
2. Chọn "Tất cả nhân viên"
3. Xem tổng doanh thu trong ngày

### Báo cáo cuối tháng
1. Chọn từ ngày 1 đến ngày cuối tháng
2. Xem doanh thu từng nhân viên
3. So sánh hiệu suất

### Kiểm tra tồn kho
1. Vào tab Tồn kho
2. Chọn "Tất cả loại hàng"
3. Xem sản phẩm nào cần nhập thêm

### Báo cáo theo loại hàng
1. Vào tab Tồn kho
2. Chọn loại hàng cụ thể
3. Xem tình trạng tồn kho loại đó

## Mẹo sử dụng

### Báo cáo Doanh thu
- Chọn khoảng thời gian ngắn để xem chi tiết
- Chọn khoảng thời gian dài để xem xu hướng
- So sánh doanh thu giữa các nhân viên
- Theo dõi doanh thu theo ngày trong tuần

### Báo cáo Tồn kho
- Kiểm tra thường xuyên để tránh hết hàng
- Chú ý sản phẩm có tồn kho = 0
- Tính giá trị tồn kho để quản lý vốn
- Lọc theo loại để dễ quản lý

## Lưu ý quan trọng

### Dữ liệu
- Báo cáo dựa trên dữ liệu thực tế trong database
- Cập nhật ngay khi có giao dịch mới
- Chính xác 100%

### Hiệu suất
- Nên chọn khoảng thời gian hợp lý
- Tránh chọn quá dài (> 1 năm)
- Lọc theo nhân viên để tăng tốc

### Bảo mật
- Chỉ Quản lý mới xem được báo cáo
- Dữ liệu nhạy cảm, cần bảo mật
- Không chia sẻ báo cáo ra ngoài

## Cải tiến trong tương lai

### Báo cáo thêm
- Báo cáo lợi nhuận
- Báo cáo nhập hàng
- Báo cáo theo sản phẩm
- Báo cáo theo khách hàng

### Biểu đồ
- Biểu đồ cột doanh thu
- Biểu đồ tròn tỷ lệ
- Biểu đồ đường xu hướng
- Dashboard tổng quan

### Xuất file
- Xuất PDF
- Xuất Word
- Gửi email tự động
- Lên lịch báo cáo

### Phân tích
- So sánh với kỳ trước
- Dự báo xu hướng
- Phân tích ABC
- Cảnh báo tồn kho

## Kết luận

Form Báo cáo cung cấp thông tin quan trọng để:
- Theo dõi doanh thu
- Quản lý tồn kho
- Ra quyết định kinh doanh
- Lập kế hoạch nhập hàng

Sử dụng thường xuyên để nắm bắt tình hình kinh doanh!
