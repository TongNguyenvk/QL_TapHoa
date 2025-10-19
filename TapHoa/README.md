# 🏪 Hệ thống Quản lý Tạp hóa

Ứng dụng quản lý tạp hóa với giao diện Windows Forms, thiết kế theo hệ thống màu "Green Harmony".

## 📋 Tính năng

### 🔐 Quản trị
- Đăng nhập với phân quyền
- Quản lý nhân viên (CRUD)
- Quản lý lịch làm việc

### 💼 Nghiệp vụ
- **Bán hàng**: Tìm kiếm, giỏ hàng, thanh toán
- **Nhập kho**: Chọn NCC, nhập hàng, cập nhật tồn kho

### 📊 Danh mục & Báo cáo
- Quản lý loại hàng, sản phẩm, nhà cung cấp
- Báo cáo doanh thu (lọc theo ngày, nhân viên)
- Báo cáo tồn kho (lọc theo loại hàng)
- Kết xuất Excel (placeholder)

### 🔐 Hệ thống
- Đổi mật khẩu
- Đăng xuất
- Thoát ứng dụng

## 🎨 Giao diện

- **Màu chủ đạo**: Green (#28A745)
- **Font**: Segoe UI
- **Style**: Flat, Modern
- **Layout**: Responsive với TableLayoutPanel

## 🛠️ Công nghệ

- **Framework**: .NET Framework 4.7.2+
- **UI**: Windows Forms
- **Database**: SQL Server
- **Pattern**: 3-Layer (DAL/DTO/UI)

## 📦 Cài đặt

### Yêu cầu
- Windows 7/8/10/11
- .NET Framework 4.7.2 trở lên
- SQL Server 2012 trở lên

### Cấu hình
1. Chạy script `db.sql` để tạo database
2. Cập nhật connection string trong `DAL/DataAccess.cs`
3. Build và chạy project

### Tài khoản mặc định
- **Quản lý**: admin / 123
- **Bán hàng**: banhang01 / 123
- **Kho**: kho01 / 123

## 📚 Tài liệu

- [Hướng dẫn Bán hàng](HUONG_DAN_BAN_HANG.md)
- [Hướng dẫn Nhập kho](HUONG_DAN_NHAP_KHO.md)
- [Hướng dẫn Lịch làm việc](HUONG_DAN_LICH_LAM_VIEC.md)
- [Tổng kết dự án](TONG_KET_DU_AN.md)

## 🎯 Phân quyền

| Vai trò | Bán hàng | Nhập kho | Quản lý NV | Lịch LV | Báo cáo |
|---------|----------|----------|------------|---------|---------|
| Quản lý | ✅ | ✅ | ✅ | ✅ | ✅ |
| NV Bán hàng | ✅ | ❌ | ❌ | ❌ | ❌ |
| NV Kho | ❌ | ✅ | ❌ | ❌ | ❌ |

## 🚀 Tính năng nổi bật

- ✅ Giao diện đẹp, chuyên nghiệp
- ✅ Tìm kiếm real-time
- ✅ Validation đầy đủ
- ✅ Transaction an toàn
- ✅ Cập nhật tồn kho tự động
- ✅ Lọc dữ liệu linh hoạt
- ✅ Responsive layout

## 📸 Screenshots

### Form Bán hàng
- Tìm kiếm sản phẩm bên trái
- Giỏ hàng bên phải
- Thanh toán ở dưới

### Form Nhập kho
- Chọn nhà cung cấp
- Tìm kiếm sản phẩm
- Chỉnh sửa giá nhập

### Form Lịch làm việc
- Calendar chọn ngày
- Danh sách nhân viên
- Chi tiết ca làm việc

## 🤝 Đóng góp

Mọi đóng góp đều được chào đón! Vui lòng:
1. Fork project
2. Tạo branch mới
3. Commit changes
4. Push và tạo Pull Request

## 📄 License

MIT License - Xem file LICENSE để biết thêm chi tiết

## 👥 Tác giả

Dự án được phát triển với sự hỗ trợ của Kiro AI

## 📞 Liên hệ

- Issues: [GitHub Issues](https://github.com/yourusername/taphoa/issues)
- Email: your.email@example.com

---

⭐ Nếu thấy hữu ích, hãy cho project một star!
