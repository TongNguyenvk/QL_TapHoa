# Cập nhật Thiết kế Label - Green Harmony

## Tổng quan thay đổi
Đã cập nhật tất cả label trong các form để có thiết kế đậm và rõ ràng hơn.

## Thay đổi chi tiết

### 1. Font Style
**Trước:** `Font = new System.Drawing.Font("Segoe UI", 9.75F)`  
**Sau:** `Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold)`

### 2. Màu chữ (ForeColor)
**Trước:** `#6C757D` (RGB: 108, 117, 125) - Slate Gray  
**Sau:** `#495057` (RGB: 73, 80, 87) - Dark Gray

### 3. Các form đã cập nhật

#### ✅ frmQuanLyDanhMuc (3 tabs)
**Tab Sản phẩm:**
- lblTenHang
- lblLoaiHang
- lblSoLuong
- lblDonGiaBan
- lblMoTaSP

**Tab Loại hàng:**
- lblTenLoaiHang
- lblMoTaLH

**Tab Nhà cung cấp:**
- lblTenNCC
- lblDiaChi
- lblSDT

#### ✅ frmQuanLyNhanVien
- lblTenNhanVien
- lblTenDangNhap
- lblMatKhau
- lblGioiTinh
- lblDiaChi
- lblSoDienThoai
- lblVaiTro

## Kết quả
- **Tất cả label** giờ đây có font đậm (Bold)
- **Màu chữ đậm hơn** giúp dễ đọc và nổi bật hơn
- **Nhất quán** trên toàn bộ ứng dụng
- **Tuân thủ** hệ thống thiết kế Green Harmony

## So sánh trực quan

### Trước
```
Label: Segoe UI 9.75pt Regular, màu #6C757D (xám nhạt)
```

### Sau
```
Label: Segoe UI 9.75pt Bold, màu #495057 (xám đậm)
```

## Lưu ý
- Không thay đổi kích thước font (vẫn giữ 9.75pt)
- Không thay đổi vị trí (Location) của các label
- Chỉ cập nhật Font Style và ForeColor
- Size của label có thể thay đổi nhẹ do Bold font (đã được điều chỉnh tự động)



