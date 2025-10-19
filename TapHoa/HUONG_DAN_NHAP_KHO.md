# Hướng dẫn Form Nhập kho

## Tổng quan
Form nhập kho được thiết kế tương tự form Bán hàng với bố cục tối ưu sử dụng **TableLayoutPanel** và **SplitContainer**.

## Cấu trúc giao diện

### 1. Khu vực Thông tin Phiếu nhập (Trên cùng)
- **Nhân viên nhập**: Tự động điền tên người đăng nhập (chỉ đọc)
- **Ngày nhập**: Mặc định là ngày hiện tại, có thể thay đổi

### 2. Khu vực Chi tiết (Giữa - Chia 2 panel)

#### Panel Trái: Tìm kiếm & Thêm sản phẩm
- **Nhà cung cấp**: ComboBox chọn nhà cung cấp (bắt buộc)
- Ô tìm kiếm sản phẩm theo tên
- DataGridView hiển thị kết quả tìm kiếm
- **Double-click** vào sản phẩm để thêm vào phiếu nhập

#### Panel Phải: Chi tiết phiếu nhập
- DataGridView hiển thị các sản phẩm đã chọn:
  - Tên sản phẩm
  - Số lượng nhập (có thể chỉnh sửa)
  - Giá nhập (có thể chỉnh sửa)
  - Thành tiền (tự động tính)
- Có thể xóa sản phẩm bằng phím Delete

### 3. Khu vực Tổng kết (Dưới cùng)

#### Bên trái: Ghi chú
- Ô nhập ghi chú cho phiếu nhập (tùy chọn)

#### Bên phải: Tổng tiền & Chức năng
- Hiển thị tổng tiền nhập lớn, rõ ràng (màu xanh lá)
- Nút **LƯU PHIẾU NHẬP** (màu xanh lá)
- Nút **HỦY** (màu xám)

## Quy trình nhập kho

### Bước 1: Chọn nhà cung cấp
1. Chọn nhà cung cấp từ ComboBox (bắt buộc)
2. Danh sách nhà cung cấp được sắp xếp theo tên

### Bước 2: Tìm kiếm sản phẩm
1. Nhập tên sản phẩm vào ô tìm kiếm
2. Danh sách sản phẩm sẽ được lọc tự động
3. Hiển thị tất cả sản phẩm trong hệ thống

### Bước 3: Thêm vào phiếu nhập
1. Double-click vào sản phẩm muốn nhập
2. Sản phẩm sẽ được thêm với:
   - Số lượng = 1
   - Giá nhập mặc định = 70% giá bán
3. Nếu sản phẩm đã có trong phiếu, số lượng sẽ tăng lên 1

### Bước 4: Điều chỉnh thông tin
1. **Số lượng nhập**: Click vào ô và nhập số lượng mong muốn
   - Phải > 0
2. **Giá nhập**: Click vào ô và nhập giá nhập thực tế
   - Phải > 0
   - Có thể khác với giá mặc định
3. Thành tiền sẽ tự động cập nhật

### Bước 5: Xóa sản phẩm (nếu cần)
1. Chọn sản phẩm trong phiếu nhập
2. Nhấn phím Delete
3. Xác nhận xóa

### Bước 6: Lưu phiếu nhập
1. Kiểm tra lại:
   - Nhà cung cấp đã chọn
   - Danh sách sản phẩm và số lượng
   - Giá nhập
   - Tổng tiền
2. Nhập ghi chú nếu cần
3. Click nút **LƯU PHIẾU NHẬP**
4. Xác nhận lưu
5. Hệ thống sẽ:
   - Tạo phiếu nhập mới
   - Lưu chi tiết phiếu nhập
   - Cộng tồn kho tự động
   - Hiển thị mã phiếu nhập và tổng tiền

### Hủy phiếu
- Click nút **HỦY** để xóa toàn bộ phiếu nhập
- Xác nhận hủy

## Tính năng nổi bật

### 1. Giá nhập linh hoạt
- Giá nhập mặc định = 70% giá bán
- Có thể chỉnh sửa giá nhập cho từng sản phẩm
- Validation đảm bảo giá nhập > 0

### 2. Tính toán tự động
- Thành tiền = Số lượng × Giá nhập
- Tổng tiền cập nhật real-time

### 3. Transaction an toàn
- Sử dụng SqlTransaction
- Rollback nếu có lỗi
- Đảm bảo tính toàn vẹn dữ liệu

### 4. Cập nhật tồn kho
- Tự động cộng tồn kho sau khi lưu
- Không cần cập nhật thủ công

## So sánh với Form Bán hàng

| Tính năng | Bán hàng | Nhập kho |
|-----------|----------|----------|
| Kiểm tra tồn kho | Có (không bán vượt quá) | Không |
| Giá | Giá bán (cố định) | Giá nhập (có thể sửa) |
| Thông tin thêm | - | Nhà cung cấp |
| Cập nhật kho | Trừ tồn kho | Cộng tồn kho |
| Màu nút chính | Xanh lá | Xanh lá |
| Màu nút phụ | Đỏ (Hủy đơn) | Xám (Hủy) |

## Lưu ý quan trọng

1. **Bắt buộc chọn nhà cung cấp** trước khi lưu
2. **Giá nhập có thể chỉnh sửa** - kiểm tra kỹ trước khi lưu
3. **Tồn kho sẽ tăng ngay** sau khi lưu phiếu nhập
4. **Không thể sửa/xóa** phiếu nhập sau khi đã lưu

## Cải tiến trong tương lai
- Sửa/xóa phiếu nhập đã lưu
- Import từ Excel
- Quét mã vạch
- Lịch sử nhập hàng từ nhà cung cấp
- Thống kê giá nhập trung bình
