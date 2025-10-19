# Module Quản lý Nhân viên - Green Harmony Design

## Tổng quan
Module Quản lý Nhân viên đã được xây dựng hoàn chỉnh với thiết kế "Green Harmony" nhất quán với module Quản lý Danh mục.

## Các file đã tạo
1. **frmQuanLyNhanVien.cs** - Logic nghiệp vụ
2. **frmQuanLyNhanVien.Designer.cs** - Thiết kế giao diện
3. **frmQuanLyNhanVien.resx** - Resource file

## Tính năng chính

### 1. Giao diện (UI/UX)
- **Bố cục 2 phần:**
  - **Bên trái:** Panel nhập liệu với các trường thông tin nhân viên
  - **Bên phải:** DataGridView hiển thị danh sách nhân viên và ô tìm kiếm

### 2. Hệ thống màu sắc "Green Harmony"
- Nền: `#F8F9FA` (Light Gray)
- Chữ chính: `#212529` (Dark Gray)
- Nút Thêm/Lưu: `#28A745` (Green)
- Nút Sửa/Bỏ qua: `#5A6268` (Gray)
- Nút Xóa: `#DC3545` (Red)
- Dòng được chọn: `#D4EDDA` (Light Green)
- Header DataGridView: `#28A745` (Green)

### 3. Các trường thông tin
- Tên nhân viên
- Tên đăng nhập
- Mật khẩu (PasswordChar: ●)
- Giới tính (ComboBox: Nam/Nữ)
- Địa chỉ (Multiline TextBox)
- Số điện thoại
- Vai trò (ComboBox từ bảng VAITRO)

### 4. Chức năng CRUD

#### Thêm nhân viên
- Click nút "➕ Thêm"
- Nhập đầy đủ thông tin (bắt buộc: Tên, Tên đăng nhập, Mật khẩu)
- Click "💾 Lưu"

#### Sửa nhân viên
- Click vào dòng cần sửa trong DataGridView
- Click nút "✏️ Sửa"
- **Đặc biệt:** Mật khẩu sẽ để trống khi hiển thị
- **Logic mật khẩu:**
  - Nếu để trống mật khẩu → Không cập nhật mật khẩu
  - Nếu nhập mật khẩu mới → Cập nhật mật khẩu
- Click "💾 Lưu"

#### Xóa nhân viên
- Click vào dòng cần xóa
- Click nút "🗑️ Xóa"
- Xác nhận trong MessageBox

#### Tìm kiếm
- Nhập tên nhân viên vào ô tìm kiếm
- Kết quả lọc tự động theo tên

### 5. Validation
- Tên nhân viên: Bắt buộc
- Tên đăng nhập: Bắt buộc
- Mật khẩu: Bắt buộc khi thêm mới, tùy chọn khi sửa

### 6. Kết nối với MainForm
- Menu item "Quản lý Nhân viên" đã được kết nối
- Event handler: `menuNhanVien_Click`
- Form mở dạng MDI Child

## Cấu trúc Database
```sql
CREATE TABLE NHANVIEN (
    MaNhanVien INT PRIMARY KEY IDENTITY(1,1),
    TenNhanVien NVARCHAR(100) NOT NULL,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(255) NOT NULL,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    SdtNhanVien VARCHAR(10),
    MaVaiTro INT,
    FOREIGN KEY (MaVaiTro) REFERENCES VAITRO(MaVaiTro)
);
```

## Cách sử dụng
1. Chạy ứng dụng và đăng nhập với tài khoản Quản lý
2. Vào menu "Quản trị" → "Quản lý Nhân viên"
3. Form sẽ tự động load danh sách nhân viên và vai trò
4. Thực hiện các thao tác Thêm/Sửa/Xóa/Tìm kiếm

## Lưu ý quan trọng
- **Bảo mật mật khẩu:** Hiện tại mật khẩu lưu dạng plain text. Nên mã hóa (hash) trước khi deploy production.
- **Xóa nhân viên:** Cần kiểm tra ràng buộc với các bảng khác (HOADON, PHIEUNHAP) trước khi xóa.
- **Tên đăng nhập:** Phải unique, database sẽ báo lỗi nếu trùng.

## Tương thích
- Font: Segoe UI (9.75pt, 11pt Bold)
- Kích thước form: 1200x700
- Tương thích với Windows Forms .NET Framework
