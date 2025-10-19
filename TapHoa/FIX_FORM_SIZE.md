# Sửa Kích thước Form Nhân viên

## Vấn đề
Form Quản lý Nhân viên có kích thước lớn hơn form Quản lý Danh mục, gây mất tính nhất quán.

## So sánh trước và sau

### Form Quản lý Danh mục (Chuẩn)
```
ClientSize: 1200 x 700
Padding: 10px
panelLeft: 350 x 650
panelRight: 822 x 650
grpThongTin: 350 x (250-380 tùy tab)
grpChucNang: 350 x 170
```

### Form Quản lý Nhân viên

#### ❌ Trước (Sai)
```
ClientSize: 1200 x 700
Padding: KHÔNG CÓ
panelLeft: 370 x 700 (TO HƠN)
  - Location: (0, 0)
  - Padding: 10px
panelRight: 830 x 700 (TO HƠN)
  - Location: (370, 0)
  - Padding: 10px
grpThongTin: 350 x 480 (TO HƠN)
  - Location: (10, 10)
grpChucNang: 350 x 190 (TO HƠN)
  - Location: (10, 500)
```

#### ✅ Sau (Đúng)
```
ClientSize: 1200 x 700
Padding: 10px (THÊM MỚI)
panelLeft: 350 x 650
  - Location: (10, 10)
  - Padding: KHÔNG CÓ
panelRight: 822 x 650
  - Location: (360, 10)
  - Padding: (10, 0, 0, 0)
grpThongTin: 350 x 450
  - Location: (0, 0)
grpChucNang: 350 x 170
  - Location: (0, 460)
```

## Chi tiết thay đổi

### 1. Form Level
- ✅ Thêm `Padding = new System.Windows.Forms.Padding(10)`
- ✅ Giữ nguyên `ClientSize = 1200 x 700`

### 2. Panel Left
- ✅ Size: `370 x 700` → `350 x 650`
- ✅ Location: `(0, 0)` → `(10, 10)`
- ✅ Bỏ Padding (form đã có padding)

### 3. Panel Right
- ✅ Size: `830 x 700` → `822 x 650`
- ✅ Location: `(370, 0)` → `(360, 10)`
- ✅ Padding: `10px all` → `(10, 0, 0, 0)` (chỉ left)

### 4. GroupBox Thông tin
- ✅ Size: `350 x 480` → `350 x 450`
- ✅ Location: `(10, 10)` → `(0, 0)`

### 5. GroupBox Chức năng
- ✅ Size: `350 x 190` → `350 x 170`
- ✅ Location: `(10, 500)` → `(0, 460)`

### 6. Buttons
- ✅ btnThem: Y = `35` → `30`
- ✅ btnSua: Y = `80` → `75`
- ✅ btnXoa: Y = `80` → `75`
- ✅ btnLuu: Y = `125` → `120`
- ✅ btnBoQua: Y = `125` → `120`

### 7. DataGridView
- ✅ Size: `810 x 655` → `812 x 625`
- ✅ Location: `(10, 35)` → `(10, 25)`

### 8. TextBox Tìm kiếm
- ✅ Size: `810 x 25` → `812 x 25`
- ✅ Location: `(10, 10)` → `(10, 0)`

## Kết quả
- ✅ Form Nhân viên giờ có kích thước CHÍNH XÁC như form Danh mục
- ✅ Padding và spacing nhất quán
- ✅ Không còn bị "to hơn"
- ✅ Tuân thủ 100% thiết kế Green Harmony

## Nguyên tắc Layout
```
Form (1200x700, padding 10)
├─ panelLeft (350x650, tại 10,10)
│  ├─ grpThongTin (350xH, tại 0,0)
│  └─ grpChucNang (350x170, tại 0,H)
└─ panelRight (822x650, tại 360,10, padding-left 10)
   ├─ txtTimKiem (812x25, dock top)
   └─ dgvData (812x625, dock fill)
```

## Lưu ý
- Padding của form tạo khoảng trống 10px xung quanh
- Panel không cần padding riêng vì form đã có
- GroupBox đặt tại (0,0) trong panel vì panel không có padding
- Tổng width: 10 + 350 + 10 + 822 + 8 = 1200 ✓
- Tổng height: 10 + 650 + 40 = 700 ✓
