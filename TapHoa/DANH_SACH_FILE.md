# Danh sách File trong Dự án

## 📁 Cấu trúc thư mục

### 🔧 Core Files
- `db.sql` - Script tạo database và dữ liệu mẫu
- `README.md` - Tài liệu chính của dự án
- `TONG_KET_DU_AN.md` - Tổng kết chi tiết dự án

### 💾 Data Access Layer (DAL/)
- `DAL/DataAccess.cs` - Lớp truy cập dữ liệu với các phương thức:
  - ExecuteQuery() - Truy vấn SELECT
  - ExecuteNonQuery() - INSERT/UPDATE/DELETE
  - ExecuteScalar() - Lấy giá trị đơn
  - GetConnection() - Lấy connection cho Transaction

### 📦 Data Transfer Objects (DTO/)
- `DTO/NhanVien.cs` - DTO cho nhân viên
- `DTO/SanPham.cs` - DTO cho sản phẩm

### 🖥️ Forms - Đăng nhập & Main
- `LoginForm.cs` - Form đăng nhập
- `LoginForm.Designer.cs` - Designer cho LoginForm
- `MainForm.cs` - Form chính (MDI Container)
- `MainForm.Designer.cs` - Designer cho MainForm

### 👥 Forms - Quản lý Nhân viên
- `frmQuanLyNhanVien.cs` - Logic quản lý nhân viên
- `frmQuanLyNhanVien.Designer.cs` - Giao diện với TableLayoutPanel
- `frmQuanLyNhanVien.resx` - Resources

**Tính năng:**
- CRUD nhân viên
- Tìm kiếm
- Phân quyền
- Layout tối ưu với TableLayoutPanel 2 cột

### 📅 Forms - Quản lý Lịch làm việc
- `frmQuanLyLichLamViec.cs` - Logic quản lý lịch
- `frmQuanLyLichLamViec.Designer.cs` - Giao diện 3 panel

**Tính năng:**
- MonthCalendar chọn ngày
- CheckedListBox lọc nhân viên
- CRUD ca làm việc
- Validation giờ làm việc

### 💰 Forms - Bán hàng
- `frmBanHang.cs` - Logic bán hàng
- `frmBanHang.Designer.cs` - Giao diện với TableLayoutPanel + SplitContainer

**Tính năng:**
- Tìm kiếm sản phẩm real-time
- Giỏ hàng với validation tồn kho
- Thanh toán với SqlTransaction
- Cập nhật tồn kho tự động

### 📦 Forms - Nhập kho
- `frmNhapKho.cs` - Logic nhập kho
- `frmNhapKho.Designer.cs` - Giao diện tương tự frmBanHang

**Tính năng:**
- Chọn nhà cung cấp
- Tìm kiếm sản phẩm
- Chỉnh sửa giá nhập
- Lưu phiếu với SqlTransaction
- Cộng tồn kho tự động

### 📋 Forms - Danh mục & Báo cáo
- `frmQuanLyDanhMuc.cs` - Quản lý danh mục
- `frmQuanLyDanhMuc.Designer.cs` - Giao diện
- `frmQuanLyDanhMuc.resx` - Resources
- `frmBaoCao.cs` - Báo cáo doanh thu & tồn kho
- `frmBaoCao.Designer.cs` - Giao diện với TabControl

**Tính năng:**
- Tab Doanh thu: Lọc theo ngày, nhân viên
- Tab Tồn kho: Lọc theo loại hàng
- Tính tổng tự động
- Nút kết xuất Excel

### 🔐 Forms - Hệ thống
- `frmDoiMatKhau.cs` - Đổi mật khẩu
- `frmDoiMatKhau.Designer.cs` - Giao diện đơn giản

**Tính năng:**
- Kiểm tra mật khẩu cũ
- Validation đầy đủ
- Yêu cầu đăng nhập lại

## 📚 Tài liệu

### Hướng dẫn sử dụng
- `HUONG_DAN_BAN_HANG.md` - Chi tiết quy trình bán hàng
- `HUONG_DAN_NHAP_KHO.md` - Chi tiết quy trình nhập kho
- `HUONG_DAN_LICH_LAM_VIEC.md` - Chi tiết quản lý lịch
- `HUONG_DAN_BAO_CAO.md` - Chi tiết xem và xuất báo cáo
- `HUONG_DAN_QUAN_LY_NHAN_VIEN.md` - Chi tiết quản lý nhân viên

### Tài liệu kỹ thuật
- `TABLELAYOUT_SUMMARY.md` - Tổng hợp sử dụng TableLayoutPanel
- `TABLELAYOUT_NHANVIEN.md` - Chi tiết layout form nhân viên
- `THAY_DOI_LABEL_DESIGN.md` - Hướng dẫn thiết kế label
- `FIX_FORM_SIZE.md` - Hướng dẫn fix kích thước form

### Checklist & Tổng kết
- `CHECKLIST_HOAN_THANH.md` - Danh sách kiểm tra hoàn thành
- `TONG_KET_DU_AN.md` - Tổng kết toàn bộ dự án
- `DANH_SACH_FILE.md` - File này

## 🎨 Hệ thống thiết kế

### Màu sắc (Green Harmony)
- Primary: #28A745 (40, 167, 69)
- Background: #F8F9FA (248, 249, 250)
- Text: #212529 (33, 37, 41)
- Danger: #DC3545 (220, 53, 69)
- Secondary: #5A6268 (90, 98, 104)

### Font
- Family: Segoe UI
- Sizes: 9-12pt
- Weights: Regular, Bold

## 📊 Thống kê

### Số lượng file
- **Code files (.cs)**: 20 files
- **Designer files (.Designer.cs)**: 10 files
- **Resource files (.resx)**: 3 files
- **Documentation (.md)**: 14 files
- **Database (.sql)**: 1 file
- **Tổng cộng**: 48+ files

### Dòng code (ước tính)
- DAL: ~100 lines
- DTO: ~50 lines
- Forms Logic: ~2000 lines
- Forms Designer: ~3000 lines
- **Tổng cộng**: ~5000+ lines

### Tính năng
- **Forms**: 7 forms chính
- **CRUD**: 4 modules
- **Transaction**: 2 modules
- **Validation**: Đầy đủ
- **Documentation**: Chi tiết

## 🔍 Tìm file nhanh

### Cần sửa connection string?
→ `DAL/DataAccess.cs`

### Cần thêm form mới?
→ Tạo file `.cs` và `.Designer.cs`, thêm vào `MainForm.cs`

### Cần sửa giao diện?
→ File `.Designer.cs` tương ứng

### Cần xem hướng dẫn?
→ File `HUONG_DAN_*.md`

### Cần kiểm tra hoàn thành?
→ `CHECKLIST_HOAN_THANH.md`

## 📝 Ghi chú

- Tất cả forms đều áp dụng hệ thống màu "Green Harmony"
- Sử dụng TableLayoutPanel cho layout responsive
- SqlTransaction cho các nghiệp vụ quan trọng
- Validation đầy đủ cho tất cả input
- Tài liệu chi tiết cho từng module

## 🎯 File quan trọng nhất

1. `db.sql` - Tạo database
2. `DAL/DataAccess.cs` - Truy cập dữ liệu
3. `MainForm.cs` - Điều hướng chính
4. `frmBanHang.cs` - Nghiệp vụ bán hàng
5. `frmNhapKho.cs` - Nghiệp vụ nhập kho
6. `README.md` - Tài liệu chính
7. `TONG_KET_DU_AN.md` - Tổng kết

---

📌 **Lưu ý**: Tất cả file đều được tổ chức theo chuẩn và có tài liệu đầy đủ!
