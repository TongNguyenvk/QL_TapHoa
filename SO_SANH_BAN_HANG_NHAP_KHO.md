# 🔄 So sánh Form Bán hàng vs Nhập kho

## 📊 Tổng quan

Cả hai form **Bán hàng** và **Nhập kho** đều sử dụng kiến trúc 3 khu vực tương tự nhưng có những điểm khác biệt quan trọng về nghiệp vụ và xử lý dữ liệu.

---

## 🏗️ Điểm Giống nhau

### **1. Kiến trúc Bố cục**
- ✅ Cùng sử dụng **TableLayoutPanel** chính với 3 hàng
- ✅ Khu vực 1: Thông tin phiếu (120px)
- ✅ Khu vực 2: Chi tiết phiếu (Flexible)
- ✅ Khu vực 3: Tổng kết (120px)

### **2. Khu vực Chi tiết**
- ✅ Cùng sử dụng **SplitContainer**
- ✅ Panel trái: Tìm kiếm sản phẩm (400px)
- ✅ Panel phải: Chi tiết phiếu (Còn lại)
- ✅ Tìm kiếm real-time
- ✅ Double-click để thêm sản phẩm

### **3. Hệ thống Thiết kế**
- ✅ Cùng áp dụng "Green Harmony"
- ✅ Màu sắc nhất quán
- ✅ Font Segoe UI
- ✅ Icon emoji trực quan

### **4. Kỹ thuật**
- ✅ Sử dụng **SqlTransaction**
- ✅ Validation đầy đủ
- ✅ Error handling chặt chẽ
- ✅ Rollback khi có lỗi

---

## 🔀 Điểm Khác biệt

### **1. Thông tin Phiếu (Khu vực 1)**

| Tiêu chí | Bán hàng | Nhập kho |
|----------|----------|----------|
| **Người thực hiện** | Nhân viên bán hàng | Nhân viên nhập kho |
| **Đối tác** | Khách hàng (TextBox) | Nhà cung cấp (ComboBox) |
| **Ngày** | Ngày bán | Ngày nhập |
| **Số cột** | 2 cột (Label + Input) | 4 cột (2 nhóm Label + Input) |

**Code Bán hàng:**
```csharp
// Khách hàng: TextBox tự do nhập
txtKhachHang.Text = "";
```

**Code Nhập kho:**
```csharp
// Nhà cung cấp: ComboBox chọn từ danh sách
LoadNhaCungCap();
cboNhaCungCap.DataSource = dt;
```

---

### **2. Chi tiết Phiếu (DataGridView chính)**

| Tiêu chí | Bán hàng | Nhập kho |
|----------|----------|----------|
| **Số lượng** | Số lượng bán | Số lượng nhập |
| **Giá** | Giá bán (ReadOnly) | Giá nhập (Editable) |
| **Validation** | Kiểm tra tồn kho | Không cần kiểm tra |
| **Tính toán** | SoLuong × GiaBan | SoLuongNhap × GiaNhap |

**Code Bán hàng:**
```csharp
// Kiểm tra tồn kho trước khi thêm
if (soLuongTon < soLuongBan)
{
    MessageBox.Show("Không đủ hàng trong kho!");
    return;
}
```

**Code Nhập kho:**
```csharp
// Không cần kiểm tra, giá nhập có thể sửa
newRow["GiaNhap"] = giaBan * 0.7m; // Mặc định 70%
// User có thể sửa giá nhập sau
```

---

### **3. Cập nhật Tồn kho**

| Tiêu chí | Bán hàng | Nhập kho |
|----------|----------|----------|
| **Thao tác** | **TRỪ** tồn kho | **CỘNG** tồn kho |
| **Validation** | Phải đủ hàng | Không cần |
| **SQL** | `SoLuong - @SoLuong` | `SoLuong + @SoLuong` |

**Code Bán hàng:**
```csharp
// TRỪ tồn kho
string queryUpdateKho = @"UPDATE HANGHOA 
                         SET SoLuong = SoLuong - @SoLuong 
                         WHERE MaHang = @MaHang";
```

**Code Nhập kho:**
```csharp
// CỘNG tồn kho
string queryUpdateKho = @"UPDATE HANGHOA 
                         SET SoLuong = SoLuong + @SoLuong 
                         WHERE MaHang = @MaHang";
```

---

### **4. Bảng Database**

| Tiêu chí | Bán hàng | Nhập kho |
|----------|----------|----------|
| **Bảng chính** | HOADON | PHIEUNHAP |
| **Bảng chi tiết** | BAN | NHAP |
| **Đối tác** | KhachHang (String) | MaNhaCungCap (FK) |
| **Tổng tiền** | TongTienBan | TongTienNhap |

**Schema Bán hàng:**
```sql
CREATE TABLE HOADON (
    MaHoaDon INT PRIMARY KEY IDENTITY,
    MaNhanVien INT,
    KhachHang NVARCHAR(100),
    NgayBan DATETIME,
    TongTienBan DECIMAL(18,2)
)

CREATE TABLE BAN (
    MaHoaDon INT,
    MaHang INT,
    SoLuongBan INT,
    GiaBan DECIMAL(18,2),
    PRIMARY KEY (MaHoaDon, MaHang)
)
```

**Schema Nhập kho:**
```sql
CREATE TABLE PHIEUNHAP (
    MaPhieuNhap INT PRIMARY KEY IDENTITY,
    MaNhanVien INT,
    MaNhaCungCap INT,
    NgayNhap DATETIME,
    TongTienNhap DECIMAL(18,2)
)

CREATE TABLE NHAP (
    MaPhieuNhap INT,
    MaHang INT,
    SoLuongNhap INT,
    GiaNhap DECIMAL(18,2),
    PRIMARY KEY (MaPhieuNhap, MaHang)
)
```

---

### **5. Validation Khác biệt**

#### **Bán hàng:**
```csharp
// 1. Kiểm tra khách hàng
if (string.IsNullOrWhiteSpace(txtKhachHang.Text))
{
    MessageBox.Show("Vui lòng nhập tên khách hàng!");
    return;
}

// 2. Kiểm tra tồn kho
string queryCheck = "SELECT SoLuong FROM HANGHOA WHERE MaHang = @MaHang";
int tonKho = (int)DataAccess.ExecuteScalar(queryCheck, ...);
if (tonKho < soLuongBan)
{
    MessageBox.Show("Không đủ hàng trong kho!");
    return;
}

// 3. Giá bán không được sửa
dgvHoaDon.Columns["GiaBan"].ReadOnly = true;
```

#### **Nhập kho:**
```csharp
// 1. Kiểm tra nhà cung cấp
if (cboNhaCungCap.SelectedValue == null)
{
    MessageBox.Show("Vui lòng chọn nhà cung cấp!");
    return;
}

// 2. KHÔNG cần kiểm tra tồn kho

// 3. Giá nhập được phép sửa
dgvPhieuNhap.Columns["GiaNhap"].ReadOnly = false;
```

---

### **6. Workflow Khác biệt**

#### **Bán hàng:**
```
1. Nhập tên khách hàng
2. Tìm sản phẩm
3. Kiểm tra tồn kho
4. Thêm vào hóa đơn (nếu đủ hàng)
5. Sửa số lượng (validate lại tồn kho)
6. Lưu hóa đơn
   → TRỪ tồn kho
   → Tạo hóa đơn
```

#### **Nhập kho:**
```
1. Chọn nhà cung cấp
2. Tìm sản phẩm
3. Thêm vào phiếu nhập
4. Sửa số lượng & giá nhập
5. Lưu phiếu nhập
   → CỘNG tồn kho
   → Tạo phiếu nhập
```

---

### **7. Tính năng Đặc biệt**

#### **Bán hàng:**
- ✅ Kiểm tra tồn kho real-time
- ✅ Cảnh báo khi không đủ hàng
- ✅ Giá bán cố định (từ database)
- ✅ Khách hàng nhập tự do

#### **Nhập kho:**
- ✅ Giá nhập linh hoạt (có thể sửa)
- ✅ Giá mặc định = 70% giá bán
- ✅ Nhà cung cấp từ danh sách
- ✅ Không giới hạn số lượng

---

## 📊 Bảng So sánh Tổng hợp

| Tiêu chí | Bán hàng | Nhập kho |
|----------|----------|----------|
| **Mục đích** | Bán hàng cho khách | Nhập hàng từ NCC |
| **Đối tác** | Khách hàng (TextBox) | Nhà cung cấp (ComboBox) |
| **Tồn kho** | TRỪ | CỘNG |
| **Validation tồn kho** | Có | Không |
| **Giá** | Giá bán (ReadOnly) | Giá nhập (Editable) |
| **Bảng chính** | HOADON | PHIEUNHAP |
| **Bảng chi tiết** | BAN | NHAP |
| **Icon chính** | 🛒 | 📦 |
| **Màu nút chính** | Xanh lá #28A745 | Xanh lá #28A745 |

---

## 🎯 Điểm Chung về Kỹ thuật

### **1. SqlTransaction Pattern**

Cả hai đều sử dụng pattern giống nhau:

```csharp
SqlConnection conn = null;
SqlTransaction transaction = null;

try
{
    conn = DataAccess.GetConnection();
    conn.Open();
    transaction = conn.BeginTransaction();

    // Bước 1: Tạo phiếu chính (HOADON/PHIEUNHAP)
    int maPhieu = (int)cmd.ExecuteScalar();

    // Bước 2: Thêm chi tiết (BAN/NHAP)
    foreach (DataRow row in dtChiTiet.Rows)
    {
        // Insert chi tiết
        // Update tồn kho
    }

    // Bước 3: Commit
    transaction.Commit();
    MessageBox.Show("Thành công!");
}
catch (Exception ex)
{
    transaction?.Rollback();
    MessageBox.Show("Lỗi: " + ex.Message);
}
finally
{
    conn?.Close();
}
```

### **2. DataTable Pattern**

```csharp
// Khởi tạo DataTable
dtChiTiet = new DataTable();
dtChiTiet.Columns.Add("MaHang", typeof(int));
dtChiTiet.Columns.Add("TenHang", typeof(string));
dtChiTiet.Columns.Add("SoLuong", typeof(int));
dtChiTiet.Columns.Add("Gia", typeof(decimal));
dtChiTiet.Columns.Add("ThanhTien", typeof(decimal), "SoLuong * Gia");

dgvChiTiet.DataSource = dtChiTiet;
```

### **3. Tìm kiếm Real-time**

```csharp
private void txtTimKiem_TextChanged(object sender, EventArgs e)
{
    if (dtSanPham != null)
    {
        DataView dv = dtSanPham.DefaultView;
        dv.RowFilter = $"TenHang LIKE '%{txtTimKiem.Text.Trim()}%'";
        dgvKetQua.DataSource = dv;
    }
}
```

---

## 🏆 Kết luận

### **Điểm Mạnh Chung:**
- ✅ Kiến trúc nhất quán, dễ bảo trì
- ✅ Giao diện trực quan, dễ sử dụng
- ✅ An toàn dữ liệu với Transaction
- ✅ Validation đầy đủ
- ✅ Code clean, dễ đọc

### **Điểm Khác biệt Chính:**
- 🔄 **Bán hàng:** TRỪ tồn kho, validate tồn kho, giá cố định
- 📦 **Nhập kho:** CỘNG tồn kho, không validate, giá linh hoạt

### **Khuyến nghị:**
- Sử dụng pattern tương tự cho các form khác
- Tái sử dụng code validation và transaction
- Duy trì tính nhất quán trong thiết kế

**Cả hai form đều sẵn sàng triển khai thực tế!** 🎊
