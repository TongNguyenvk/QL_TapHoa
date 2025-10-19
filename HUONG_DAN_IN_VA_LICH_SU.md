# HƯỚNG DẪN CHỨC NĂNG IN ẤN VÀ LỊCH SỬ GIAO DỊCH

## Tổng quan
Đã nâng cấp module Bán hàng và Nhập kho với các chức năng:
- In hóa đơn/phiếu nhập
- Xem lịch sử giao dịch
- Xem trước và in lại các giao dịch cũ

## Các Form mới

### 1. frmXemTruocIn
**Mục đích:** Hiển thị xem trước và in hóa đơn/phiếu nhập

**Tính năng:**
- Hiển thị đầy đủ thông tin hóa đơn/phiếu nhập
- Xem trước trước khi in
- In ra máy in

**Cách sử dụng:**
- Form này được mở tự động sau khi thanh toán/lưu phiếu (nếu chọn "Có")
- Hoặc mở từ lịch sử bằng cách double-click vào dòng giao dịch

**Giao diện:**
```
╔══════════════════════════════════════════╗
║        CỬA HÀNG TẠP HÓA ABC             ║
║     Địa chỉ: 123 Đường ABC, TP.HCM      ║
║          SĐT: 0123-456-789              ║
╠══════════════════════════════════════════╣
║          HÓA ĐƠN BÁN LẺ                 ║
╚══════════════════════════════════════════╝

Số HĐ: 1
Ngày bán: 19/10/2025 14:30
Nhân viên: Nguyễn Văn A

────────────────────────────────────────────
[Bảng chi tiết sản phẩm]
────────────────────────────────────────────

TỔNG TIỀN: 500,000 đ

[Nút In] [Nút Đóng]
```

### 2. frmLichSuHoaDon
**Mục đích:** Xem lịch sử các hóa đơn đã bán

**Tính năng:**
- Lọc theo khoảng thời gian
- Hiển thị danh sách hóa đơn
- Double-click để xem chi tiết và in lại

**Cách mở:**
- Từ form Bán hàng: Click nút "📋 Lịch sử"

**Bộ lọc:**
- Từ ngày: Chọn ngày bắt đầu
- Đến ngày: Chọn ngày kết thúc
- Click "🔍 Lọc" để tìm kiếm

**Danh sách hiển thị:**
- Mã HĐ
- Ngày bán
- Nhân viên
- Tổng tiền

### 3. frmLichSuPhieuNhap
**Mục đích:** Xem lịch sử các phiếu nhập kho

**Tính năng:**
- Lọc theo khoảng thời gian
- Hiển thị danh sách phiếu nhập
- Double-click để xem chi tiết và in lại

**Cách mở:**
- Từ form Nhập kho: Click nút "📋 Lịch sử"

**Bộ lọc:**
- Từ ngày: Chọn ngày bắt đầu
- Đến ngày: Chọn ngày kết thúc
- Click "🔍 Lọc" để tìm kiếm

**Danh sách hiển thị:**
- Mã PN
- Ngày nhập
- Nhân viên
- Nhà cung cấp
- Tổng tiền

## Luồng hoạt động

### A. Bán hàng và In hóa đơn

1. **Tạo hóa đơn:**
   - Thêm sản phẩm vào giỏ hàng
   - Click "💳 THANH TOÁN"

2. **Hỏi in hóa đơn:**
   - Sau khi thanh toán thành công, hệ thống hiển thị:
     ```
     Thanh toán thành công!
     Mã hóa đơn: 123
     Tổng tiền: 500,000 đ
     
     Bạn có muốn in hóa đơn không?
     [Có] [Không]
     ```

3. **In hóa đơn:**
   - Chọn "Có" → Mở form xem trước
   - Click "🖨️ In" để in
   - Click "Đóng" để thoát

4. **Xem lại hóa đơn cũ:**
   - Click nút "📋 Lịch sử" trên form Bán hàng
   - Chọn khoảng thời gian và click "🔍 Lọc"
   - Double-click vào hóa đơn cần xem
   - Click "🖨️ In" để in lại

### B. Nhập kho và In phiếu nhập

1. **Tạo phiếu nhập:**
   - Chọn nhà cung cấp
   - Thêm sản phẩm vào phiếu nhập
   - Click "💾 Lưu phiếu"

2. **Hỏi in phiếu nhập:**
   - Sau khi lưu thành công, hệ thống hiển thị:
     ```
     Lưu phiếu nhập thành công!
     Mã phiếu nhập: 45
     Tổng tiền: 2,000,000 đ
     
     Bạn có muốn in phiếu nhập không?
     [Có] [Không]
     ```

3. **In phiếu nhập:**
   - Chọn "Có" → Mở form xem trước
   - Click "🖨️ In" để in
   - Click "Đóng" để thoát

4. **Xem lại phiếu nhập cũ:**
   - Click nút "📋 Lịch sử" trên form Nhập kho
   - Chọn khoảng thời gian và click "🔍 Lọc"
   - Double-click vào phiếu nhập cần xem
   - Click "🖨️ In" để in lại

## Thông tin in ấn

### Hóa đơn bán lẻ bao gồm:
- Tên cửa hàng, địa chỉ, SĐT
- Tiêu đề: "HÓA ĐƠN BÁN LẺ"
- Số HĐ, Ngày bán, Tên nhân viên
- Bảng chi tiết: Tên hàng, SL, Đơn giá, Thành tiền
- Tổng tiền
- Lời cảm ơn: "Cảm ơn quý khách! Hẹn gặp lại!"

### Phiếu nhập kho bao gồm:
- Tên cửa hàng, địa chỉ, SĐT
- Tiêu đề: "PHIẾU NHẬP KHO"
- Số PN, Ngày nhập, Tên nhân viên, Nhà cung cấp
- Bảng chi tiết: Tên hàng, SL, Đơn giá, Thành tiền
- Tổng tiền
- Thông báo: "Đã nhập kho thành công!"

## Lưu ý kỹ thuật

### Cấu trúc code:
```
frmBanHang.cs
├── ThanhToan() - Thêm logic hỏi in
└── btnLichSu_Click() - Mở form lịch sử

frmNhapKho.cs
├── LuuPhieuNhap() - Thêm logic hỏi in
└── btnLichSu_Click() - Mở form lịch sử

frmXemTruocIn.cs
├── Constructor(maGiaoDich, loaiPhieu)
├── LoadData() - Tải dữ liệu từ DB
├── HienThiXemTruoc() - Hiển thị trên form
├── btnIn_Click() - Mở PrintPreviewDialog
└── PrintDocument_PrintPage() - Vẽ nội dung in

frmLichSuHoaDon.cs
├── LoadLichSuHoaDon() - Tải danh sách
├── btnLoc_Click() - Lọc theo ngày
└── dgvLichSu_CellDoubleClick() - Mở xem chi tiết

frmLichSuPhieuNhap.cs
├── LoadLichSuPhieuNhap() - Tải danh sách
├── btnLoc_Click() - Lọc theo ngày
└── dgvLichSu_CellDoubleClick() - Mở xem chi tiết
```

### Truy vấn SQL:

**Lấy thông tin hóa đơn:**
```sql
SELECT HD.MaHoaDon, HD.NgayBan, HD.TongTien, NV.TenNhanVien
FROM HOADON HD
INNER JOIN NHANVIEN NV ON HD.MaNhanVien = NV.MaNhanVien
WHERE HD.MaHoaDon = @Ma
```

**Lấy chi tiết hóa đơn:**
```sql
SELECT HH.TenHang, B.SoLuongBan AS SoLuong, 
       B.DonGia, (B.SoLuongBan * B.DonGia) AS ThanhTien
FROM BAN B
INNER JOIN HANGHOA HH ON B.MaHang = HH.MaHang
WHERE B.MaHoaDon = @Ma
```

**Lấy thông tin phiếu nhập:**
```sql
SELECT PN.MaPhieuNhap, PN.NgayNhap, PN.TongTienNhap, 
       NV.TenNhanVien, NCC.TenNhaCungCap
FROM PHIEUNHAP PN
INNER JOIN NHANVIEN NV ON PN.MaNhanVien = NV.MaNhanVien
INNER JOIN NHACUNGCAP NCC ON PN.MaNhaCungCap = NCC.MaNhaCungCap
WHERE PN.MaPhieuNhap = @Ma
```

**Lấy chi tiết phiếu nhập:**
```sql
SELECT HH.TenHang, N.SoLuongNhap AS SoLuong, 
       N.GiaNhap AS DonGia, (N.SoLuongNhap * N.GiaNhap) AS ThanhTien
FROM NHAP N
INNER JOIN HANGHOA HH ON N.MaHang = HH.MaHang
WHERE N.MaPhieuNhap = @Ma
```

## Tùy chỉnh

### Thay đổi thông tin cửa hàng:
Mở file `frmXemTruocIn.cs` và tìm các dòng:
```csharp
string tenCuaHang = "CỬA HÀNG TẠP HÓA ABC";
string diaChi = "Địa chỉ: 123 Đường ABC, TP.HCM - SĐT: 0123-456-789";
```

### Thay đổi định dạng in:
Chỉnh sửa method `PrintDocument_PrintPage()` trong `frmXemTruocIn.cs`

### Thay đổi khoảng thời gian mặc định:
Trong `frmLichSuHoaDon_Load()` và `frmLichSuPhieuNhap_Load()`:
```csharp
dtpTuNgay.Value = DateTime.Now.AddMonths(-1); // Mặc định 1 tháng trước
dtpDenNgay.Value = DateTime.Now;
```

## Kiểm tra

### Test case 1: In hóa đơn mới
1. Tạo hóa đơn mới
2. Thanh toán
3. Chọn "Có" khi hỏi in
4. Kiểm tra xem trước
5. Click In

### Test case 2: Xem lịch sử hóa đơn
1. Mở form Bán hàng
2. Click "📋 Lịch sử"
3. Chọn khoảng thời gian
4. Click "🔍 Lọc"
5. Double-click vào hóa đơn
6. Kiểm tra thông tin hiển thị

### Test case 3: In lại hóa đơn cũ
1. Từ lịch sử, double-click vào hóa đơn
2. Click "🖨️ In"
3. Kiểm tra nội dung in

### Test case 4: In phiếu nhập mới
1. Tạo phiếu nhập mới
2. Lưu phiếu
3. Chọn "Có" khi hỏi in
4. Kiểm tra xem trước
5. Click In

### Test case 5: Xem lịch sử phiếu nhập
1. Mở form Nhập kho
2. Click "📋 Lịch sử"
3. Chọn khoảng thời gian
4. Click "🔍 Lọc"
5. Double-click vào phiếu nhập
6. Kiểm tra thông tin hiển thị

## Lợi ích

✅ **Tiện lợi:** Nút Lịch sử ngay trong form làm việc, không cần vào menu
✅ **Nhanh chóng:** Hỏi in ngay sau khi hoàn thành giao dịch
✅ **Linh hoạt:** Có thể in lại bất kỳ lúc nào từ lịch sử
✅ **Trực quan:** Xem trước trước khi in, tránh lãng phí giấy
✅ **Đầy đủ:** Hiển thị đầy đủ thông tin cần thiết trên hóa đơn/phiếu nhập

## Hoàn thành ✓

- [x] Form xem trước và in (frmXemTruocIn)
- [x] Form lịch sử hóa đơn (frmLichSuHoaDon)
- [x] Form lịch sử phiếu nhập (frmLichSuPhieuNhap)
- [x] Nút Lịch sử trong form Bán hàng
- [x] Nút Lịch sử trong form Nhập kho
- [x] Hỏi in sau thanh toán
- [x] Hỏi in sau lưu phiếu nhập
- [x] Chức năng in với PrintDocument
- [x] Lọc theo khoảng thời gian
- [x] Double-click để xem chi tiết
