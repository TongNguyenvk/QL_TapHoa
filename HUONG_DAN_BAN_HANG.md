# Hướng dẫn Form Bán hàng

## Tổng quan
Form bán hàng được thiết kế với bố cục tối ưu sử dụng **TableLayoutPanel** và **SplitContainer** để hiển thị nhiều thông tin một cách rõ ràng và dễ thao tác.

## Cấu trúc giao diện

### 1. Khu vực Thông tin Hóa đơn (Trên cùng)
- **Nhân viên**: Tự động điền tên người đăng nhập (chỉ đọc)
- **Ngày bán**: Mặc định là ngày hiện tại, có thể thay đổi

### 2. Khu vực Chi tiết (Giữa - Chia 2 panel)

#### Panel Trái: Tìm kiếm & Thêm sản phẩm
- Ô tìm kiếm sản phẩm theo tên
- DataGridView hiển thị kết quả tìm kiếm với các cột:
  - Mã sản phẩm
  - Tên sản phẩm
  - Tồn kho
  - Giá bán
- **Double-click** vào sản phẩm để thêm vào giỏ hàng

#### Panel Phải: Giỏ hàng
- DataGridView hiển thị các sản phẩm đã chọn:
  - Tên sản phẩm
  - Số lượng (có thể chỉnh sửa)
  - Đơn giá
  - Thành tiền (tự động tính)
- Có thể xóa sản phẩm bằng phím Delete

### 3. Khu vực Thanh toán (Dưới cùng)

#### Bên trái: Ghi chú
- Ô nhập ghi chú cho hóa đơn (tùy chọn)

#### Bên phải: Tổng tiền & Chức năng
- Hiển thị tổng tiền lớn, rõ ràng (màu xanh lá)
- Nút **THANH TOÁN** (màu xanh lá)
- Nút **HỦY ĐƠN** (màu đỏ)

## Quy trình bán hàng

### Bước 1: Tìm kiếm sản phẩm
1. Nhập tên sản phẩm vào ô tìm kiếm
2. Danh sách sản phẩm sẽ được lọc tự động
3. Chỉ hiển thị sản phẩm còn hàng trong kho

### Bước 2: Thêm vào giỏ hàng
1. Double-click vào sản phẩm muốn bán
2. Sản phẩm sẽ được thêm vào giỏ hàng với số lượng = 1
3. Nếu sản phẩm đã có trong giỏ, số lượng sẽ tăng lên 1

### Bước 3: Điều chỉnh số lượng
1. Click vào ô "Số lượng" trong giỏ hàng
2. Nhập số lượng mong muốn
3. Hệ thống sẽ kiểm tra:
   - Số lượng phải > 0
   - Số lượng không được vượt quá tồn kho
4. Thành tiền sẽ tự động cập nhật

### Bước 4: Xóa sản phẩm (nếu cần)
1. Chọn sản phẩm trong giỏ hàng
2. Nhấn phím Delete
3. Xác nhận xóa

### Bước 5: Thanh toán
1. Kiểm tra lại giỏ hàng và tổng tiền
2. Nhập ghi chú nếu cần
3. Click nút **THANH TOÁN**
4. Xác nhận thanh toán
5. Hệ thống sẽ:
   - Tạo hóa đơn mới
   - Lưu chi tiết hóa đơn
   - Trừ tồn kho tự động
   - Hiển thị mã hóa đơn và tổng tiền

### Hủy đơn
- Click nút **HỦY ĐƠN** để xóa toàn bộ giỏ hàng
- Xác nhận hủy

## Tính năng nổi bật

### 1. Kiểm tra tồn kho tự động
- Không cho phép bán vượt quá số lượng tồn kho
- Hiển thị cảnh báo khi không đủ hàng

### 2. Tính toán tự động
- Thành tiền = Số lượng × Đơn giá
- Tổng tiền cập nhật real-time khi thay đổi giỏ hàng

### 3. Transaction an toàn
- Sử dụng SqlTransaction để đảm bảo tính toàn vẹn dữ liệu
- Nếu có lỗi, toàn bộ giao dịch sẽ được rollback

### 4. Giao diện thân thiện
- Bố cục rõ ràng, dễ thao tác
- Màu sắc theo hệ thống "Green Harmony"
- Phím tắt và double-click để tăng tốc độ làm việc

## Lưu ý kỹ thuật

### Bố cục sử dụng TableLayoutPanel
```
mainTableLayout (3 rows):
├── Row 1 (80px): Thông tin hóa đơn
│   └── tblThongTinHoaDon (2 columns)
│       ├── Column 1: Nhân viên
│       └── Column 2: Ngày bán
├── Row 2 (100%): Chi tiết
│   └── SplitContainer
│       ├── Panel1 (450px): Tìm kiếm sản phẩm
│       └── Panel2 (auto): Giỏ hàng
└── Row 3 (140px): Thanh toán
    └── tblThanhToan (2 columns)
        ├── Column 1: Ghi chú
        └── Column 2: Tổng tiền & Nút chức năng
```

### Ưu điểm của bố cục này
1. **Responsive**: Tự động điều chỉnh khi thay đổi kích thước form
2. **Rõ ràng**: Phân chia khu vực chức năng rõ ràng
3. **Hiệu quả**: Tối ưu không gian màn hình
4. **Chuyên nghiệp**: Giao diện hiện đại, dễ sử dụng

## Cải tiến trong tương lai
- Thêm chức năng quản lý khách hàng
- In hóa đơn
- Áp dụng khuyến mãi/giảm giá
- Thanh toán nhiều hình thức (tiền mặt, chuyển khoản)
- Lịch sử giao dịch trong ngày
