# 📅 Ràng buộc Ngày tháng trong Hệ thống

## Tổng quan
Để đảm bảo tính hợp lý và chính xác của dữ liệu, hệ thống áp dụng các ràng buộc về ngày tháng cho các form nhập liệu.

## Quy tắc ràng buộc

### 1. Form Bán hàng (frmBanHang)
**Quy tắc:** Chỉ cho phép chọn **ngày hiện tại**

**Lý do:**
- Hóa đơn bán hàng phải được tạo trong ngày
- Không cho phép tạo hóa đơn cho ngày quá khứ (sai thực tế)
- Không cho phép tạo hóa đơn cho ngày tương lai (chưa xảy ra)

**Triển khai:**
```csharp
dtpNgayBan.MinDate = DateTime.Today;
dtpNgayBan.MaxDate = DateTime.Today;
dtpNgayBan.Value = DateTime.Now;
```

**Kết quả:**
- ✅ Chỉ có thể chọn ngày hôm nay
- ❌ Không thể chọn ngày quá khứ
- ❌ Không thể chọn ngày tương lai

---

### 2. Form Nhập kho (frmNhapKho)
**Quy tắc:** Chỉ cho phép chọn **ngày hiện tại**

**Lý do:**
- Phiếu nhập kho phải được tạo trong ngày nhập hàng
- Không cho phép tạo phiếu nhập cho ngày quá khứ (sai thực tế)
- Không cho phép tạo phiếu nhập cho ngày tương lai (chưa nhập)

**Triển khai:**
```csharp
dtpNgayNhap.MinDate = DateTime.Today;
dtpNgayNhap.MaxDate = DateTime.Today;
dtpNgayNhap.Value = DateTime.Now;
```

**Kết quả:**
- ✅ Chỉ có thể chọn ngày hôm nay
- ❌ Không thể chọn ngày quá khứ
- ❌ Không thể chọn ngày tương lai

---

### 3. Form Quản lý Lịch làm việc (frmQuanLyLichLamViec)
**Quy tắc:** Chỉ cho phép chọn **ngày tương lai** (từ ngày mai trở đi)

**Lý do:**
- Lịch làm việc phải được lên kế hoạch trước
- Không cho phép tạo lịch cho ngày hiện tại (quá gấp)
- Không cho phép tạo lịch cho ngày quá khứ (đã qua)

**Triển khai:**
```csharp
dtpNgayLam.MinDate = DateTime.Today.AddDays(1);
dtpNgayLam.Value = DateTime.Today.AddDays(1);
```

**Kết quả:**
- ✅ Chỉ có thể chọn từ ngày mai trở đi
- ❌ Không thể chọn ngày hôm nay
- ❌ Không thể chọn ngày quá khứ

---

## Bảng tóm tắt

| Form | Control | Ngày quá khứ | Ngày hiện tại | Ngày tương lai |
|------|---------|--------------|---------------|----------------|
| **Bán hàng** | dtpNgayBan | ❌ | ✅ | ❌ |
| **Nhập kho** | dtpNgayNhap | ❌ | ✅ | ❌ |
| **Lịch làm việc** | dtpNgayLam | ❌ | ❌ | ✅ (từ ngày mai) |

## Chi tiết kỹ thuật

### DateTimePicker Properties

#### MinDate
- Ngày nhỏ nhất có thể chọn
- Giá trị: `DateTime.Today` hoặc `DateTime.Today.AddDays(1)`

#### MaxDate
- Ngày lớn nhất có thể chọn
- Giá trị: `DateTime.Today` (nếu chỉ cho phép ngày hiện tại)
- Mặc định: `DateTime.MaxValue` (nếu cho phép tương lai)

#### Value
- Giá trị mặc định khi form load
- Nên set theo quy tắc ràng buộc

### DateTime Methods

```csharp
// Ngày hiện tại (không có giờ)
DateTime.Today

// Ngày và giờ hiện tại
DateTime.Now

// Ngày mai
DateTime.Today.AddDays(1)

// Ngày hôm qua
DateTime.Today.AddDays(-1)
```

## Xử lý ngoại lệ

### Trường hợp đặc biệt

#### 1. Sửa hóa đơn/phiếu nhập cũ
**Vấn đề:** Không thể sửa hóa đơn/phiếu nhập của ngày trước

**Giải pháp:**
- Khi mở form ở chế độ "Sửa", tạm thời bỏ ràng buộc
- Hiển thị ngày gốc (read-only)
- Không cho phép thay đổi ngày

```csharp
// Khi sửa
dtpNgayBan.Enabled = false; // Không cho đổi ngày
```

#### 2. Sửa lịch làm việc đã tạo
**Vấn đề:** Lịch đã tạo cho ngày mai, hôm nay muốn sửa

**Giải pháp:**
- Cho phép sửa lịch đã tạo
- Nhưng không cho đổi ngày về quá khứ
- Giữ nguyên MinDate = ngày gốc hoặc ngày mai (lấy lớn hơn)

```csharp
// Khi sửa lịch
DateTime ngayGoc = // lấy từ database
dtpNgayLam.MinDate = ngayGoc > DateTime.Today.AddDays(1) 
    ? ngayGoc 
    : DateTime.Today.AddDays(1);
```

## Thông báo lỗi

### Khi user cố chọn ngày không hợp lệ

DateTimePicker tự động chặn, không cần xử lý thêm. Nhưng nên có tooltip:

```csharp
// Form Bán hàng
toolTip.SetToolTip(dtpNgayBan, "Chỉ có thể chọn ngày hôm nay");

// Form Nhập kho
toolTip.SetToolTip(dtpNgayNhap, "Chỉ có thể chọn ngày hôm nay");

// Form Lịch làm việc
toolTip.SetToolTip(dtpNgayLam, "Chỉ có thể chọn từ ngày mai trở đi");
```

## Lợi ích

### 1. Đảm bảo tính chính xác
- ✅ Dữ liệu phản ánh đúng thực tế
- ✅ Không có hóa đơn/phiếu nhập "tương lai"
- ✅ Không có lịch làm việc "quá khứ"

### 2. Tránh lỗi nghiệp vụ
- ✅ Không tạo hóa đơn cho ngày chưa đến
- ✅ Không nhập kho "hồi tưởng"
- ✅ Không phân công lịch cho ngày đã qua

### 3. Tuân thủ quy trình
- ✅ Bán hàng phải trong ngày
- ✅ Nhập kho phải trong ngày
- ✅ Lịch làm việc phải lên trước

### 4. Dễ kiểm soát
- ✅ Quản lý dễ dàng theo dõi
- ✅ Báo cáo chính xác theo thời gian
- ✅ Không có dữ liệu "lạc thời gian"

## Testing

### Test Cases

#### Form Bán hàng
1. ✅ Mở form → dtpNgayBan = hôm nay
2. ✅ Click calendar → Chỉ thấy ngày hôm nay
3. ✅ Không thể chọn ngày khác
4. ✅ Tạo hóa đơn thành công với ngày hôm nay

#### Form Nhập kho
1. ✅ Mở form → dtpNgayNhap = hôm nay
2. ✅ Click calendar → Chỉ thấy ngày hôm nay
3. ✅ Không thể chọn ngày khác
4. ✅ Tạo phiếu nhập thành công với ngày hôm nay

#### Form Lịch làm việc
1. ✅ Mở form → dtpNgayLam = ngày mai
2. ✅ Click calendar → Không thấy hôm nay và quá khứ
3. ✅ Chỉ có thể chọn từ ngày mai trở đi
4. ✅ Tạo lịch thành công với ngày tương lai

## Mở rộng trong tương lai

### 1. Cấu hình linh hoạt
- Cho phép Admin cấu hình số ngày tối thiểu cho lịch làm việc
- Ví dụ: Phải tạo lịch trước ít nhất 3 ngày

### 2. Cảnh báo
- Cảnh báo khi tạo lịch quá gần (ví dụ: chỉ 1 ngày trước)
- Cảnh báo khi tạo nhiều hóa đơn trong 1 ngày

### 3. Quyền đặc biệt
- Admin có thể tạo hóa đơn/phiếu nhập cho ngày quá khứ (để sửa lỗi)
- Ghi log khi có thao tác đặc biệt

### 4. Validation bổ sung
- Kiểm tra ngày không được quá xa trong tương lai (ví dụ: không quá 1 năm)
- Kiểm tra ngày làm việc không trùng với ngày nghỉ/lễ

## Troubleshooting

### Vấn đề: DateTimePicker vẫn cho chọn ngày không hợp lệ
**Nguyên nhân:** MinDate/MaxDate chưa được set
**Giải pháp:** Kiểm tra lại code trong Form_Load

### Vấn đề: Không thể mở form
**Nguyên nhân:** MinDate > MaxDate
**Giải pháp:** Đảm bảo MinDate <= MaxDate

### Vấn đề: Muốn sửa dữ liệu cũ nhưng bị chặn
**Nguyên nhân:** Ràng buộc áp dụng cho cả chế độ sửa
**Giải pháp:** Disable DateTimePicker khi sửa, hoặc điều chỉnh MinDate

---

**Ngày cập nhật:** 20/10/2025  
**Người thực hiện:** Kiro AI Assistant  
**Trạng thái:** ✅ Đã triển khai
