# 📦 Hướng dẫn Chi tiết Form Nhập Kho

## 🎯 Tổng quan

Form **Nhập kho** (`frmNhapKho`) là một trong những form quan trọng nhất của hệ thống, cho phép nhân viên kho nhập hàng hóa từ nhà cung cấp vào kho. Form được thiết kế với bố cục 3 khu vực rõ ràng sử dụng **TableLayoutPanel** và **SplitContainer**.

---

## 🏗️ Kiến trúc Bố cục

### **Cấu trúc 3 Khu vực Chính**

```
┌─────────────────────────────────────────────────────────┐
│  KHU VỰC 1: THÔNG TIN PHIẾU NHẬP (120px)               │
│  - Nhân viên nhập, Ngày nhập, Nhà cung cấp             │
└─────────────────────────────────────────────────────────┘
┌─────────────────────────────────────────────────────────┐
│  KHU VỰC 2: CHI TIẾT PHIẾU NHẬP (Flexible)             │
│  ┌──────────────┬────────────────────────────────────┐  │
│  │ Tìm kiếm SP  │  Chi tiết phiếu nhập              │  │
│  │ (400px)      │  (Còn lại)                        │  │
│  └──────────────┴────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────┘
┌─────────────────────────────────────────────────────────┐
│  KHU VỰC 3: TỔNG KẾT & CHỨC NĂNG (120px)               │
│  - Ghi chú | Tổng tiền & Nút chức năng                 │
└─────────────────────────────────────────────────────────┘
```

---

## 📋 Chi tiết từng Khu vực

### **1. Khu vực Thông tin Phiếu nhập (Trên cùng)**

#### **Sử dụng TableLayoutPanel với 4 cột:**

| Cột | Loại | Nội dung |
|-----|------|----------|
| 0 | Label (150px) | Nhãn cột trái |
| 1 | Control (50%) | Input cột trái |
| 2 | Label (150px) | Nhãn cột phải |
| 3 | Control (50%) | Input cột phải |

#### **Controls:**

**Hàng 1:**
- 👤 **Nhân viên nhập:** `txtNhanVien` (ReadOnly) - Hiển thị tên nhân viên đang đăng nhập
- 🏢 **Nhà cung cấp:** `cboNhaCungCap` (DropDownList) - Chọn nhà cung cấp

**Hàng 2:**
- 📅 **Ngày nhập:** `dtpNgayNhap` (DateTimePicker) - Mặc định là ngày hiện tại

#### **Code khởi tạo:**

```csharp
private void frmNhapKho_Load(object sender, EventArgs e)
{
    txtNhanVien.Text = tenNhanVien;
    dtpNgayNhap.Value = DateTime.Now;
    
    LoadNhaCungCap();
    LoadSanPham();
    InitPhieuNhap();
}
```

---

### **2. Khu vực Chi tiết Phiếu nhập (Ở giữa)**

#### **Sử dụng SplitContainer với 2 Panel:**

#### **Panel Trái (400px): Tìm kiếm & Thêm sản phẩm**

**Controls:**
- 🔍 **Label tiêu đề:** "Tìm kiếm sản phẩm"
- **TextBox tìm kiếm:** `txtTimKiemSP` với placeholder "🔍 Nhập tên sản phẩm..."
- **DataGridView:** `dgvKetQuaTimKiem` hiển thị kết quả tìm kiếm

**Cột trong dgvKetQuaTimKiem:**
- `MaHang` (50px)
- `TenHang` (Fill)
- `SoLuong` (70px) - Tồn kho hiện tại
- `GiaBan` (90px) - Giá bán lẻ

**Tính năng:**
- Tìm kiếm real-time khi gõ
- Double-click để thêm vào phiếu nhập
- Hiển thị tồn kho để tham khảo

#### **Panel Phải (Còn lại): Chi tiết phiếu nhập**

**Controls:**
- 📋 **Label tiêu đề:** "Chi tiết phiếu nhập"
- **DataGridView:** `dgvPhieuNhap` hiển thị chi tiết phiếu

**Cột trong dgvPhieuNhap:**
- `MaHang` (Hidden)
- `TenHang` (ReadOnly, Fill)
- `SoLuongNhap` (100px) - **Có thể sửa**
- `GiaNhap` (120px) - **Có thể sửa**
- `ThanhTien` (140px, ReadOnly) - Tự động tính = SoLuongNhap × GiaNhap

**Tính năng:**
- Sửa số lượng và giá nhập trực tiếp
- Xóa dòng bằng phím Delete
- Tự động tính thành tiền

---

### **3. Khu vực Tổng kết & Chức năng (Dưới cùng)**

#### **Sử dụng TableLayoutPanel với 2 cột (50%-50%):**

#### **Cột Trái: Ghi chú**
- 📝 **Label:** "Ghi chú phiếu nhập:"
- **TextBox:** `txtGhiChu` (Multiline) - Ghi chú tùy chọn

#### **Cột Phải: Tổng tiền & Nút chức năng**
- 💰 **Label:** "Tổng tiền nhập:"
- **Label giá trị:** `lblTongTienNhap` (Font 14, Bold, Màu đỏ)
- 💾 **Button Lưu:** `btnLuuPhieuNhap` (Màu xanh lá #28A745)
- ❌ **Button Hủy:** `btnHuy` (Màu xám #6C757D)

---

## 🔧 Logic Nghiệp vụ Chi tiết

### **1. Tải Nhà cung cấp**

```csharp
private void LoadNhaCungCap()
{
    string query = "SELECT MaNhaCungCap, TenNhaCungCap FROM NHACUNGCAP ORDER BY TenNhaCungCap";
    DataTable dt = DataAccess.ExecuteQuery(query);
    
    cboNhaCungCap.DataSource = dt;
    cboNhaCungCap.DisplayMember = "TenNhaCungCap";
    cboNhaCungCap.ValueMember = "MaNhaCungCap";
}
```

### **2. Tìm kiếm Sản phẩm Real-time**

```csharp
private void txtTimKiemSP_TextChanged(object sender, EventArgs e)
{
    if (txtTimKiemSP.ForeColor == System.Drawing.Color.Gray) return;

    if (dtSanPham != null)
    {
        DataView dv = dtSanPham.DefaultView;
        dv.RowFilter = $"TenHang LIKE '%{txtTimKiemSP.Text.Trim()}%'";
        dgvKetQuaTimKiem.DataSource = dv;
    }
}
```

### **3. Thêm Sản phẩm vào Phiếu (Double-click)**

```csharp
private void ThemVaoPhieuNhap(int maHang, string tenHang, decimal giaBan)
{
    DataRow[] existingRows = dtPhieuNhap.Select($"MaHang = {maHang}");
    
    if (existingRows.Length > 0)
    {
        // Nếu đã có, tăng số lượng
        int soLuongHienTai = Convert.ToInt32(existingRows[0]["SoLuongNhap"]);
        existingRows[0]["SoLuongNhap"] = soLuongHienTai + 1;
    }
    else
    {
        // Nếu chưa có, thêm mới với giá nhập = 70% giá bán
        DataRow newRow = dtPhieuNhap.NewRow();
        newRow["MaHang"] = maHang;
        newRow["TenHang"] = tenHang;
        newRow["SoLuongNhap"] = 1;
        newRow["GiaNhap"] = giaBan * 0.7m; // Giá nhập mặc định
        dtPhieuNhap.Rows.Add(newRow);
    }

    TinhTongTien();
}
```

### **4. Validation khi Sửa Số lượng/Giá**

```csharp
private void dgvPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
    {
        string columnName = dgvPhieuNhap.Columns[e.ColumnIndex].Name;
        
        if (columnName == "SoLuongNhap")
        {
            int soLuong = 0;
            if (int.TryParse(row.Cells["SoLuongNhap"].Value?.ToString(), out soLuong))
            {
                if (soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!");
                    row.Cells["SoLuongNhap"].Value = 1;
                    return;
                }
            }
        }
        
        if (columnName == "GiaNhap")
        {
            decimal giaNhap = 0;
            if (decimal.TryParse(row.Cells["GiaNhap"].Value?.ToString(), out giaNhap))
            {
                if (giaNhap <= 0)
                {
                    MessageBox.Show("Giá nhập phải lớn hơn 0!");
                    row.Cells["GiaNhap"].Value = 1000;
                    return;
                }
            }
        }

        TinhTongTien();
    }
}
```

### **5. Lưu Phiếu nhập với SqlTransaction**

```csharp
private void LuuPhieuNhap()
{
    SqlConnection conn = null;
    SqlTransaction transaction = null;

    try
    {
        conn = DataAccess.GetConnection();
        conn.Open();
        transaction = conn.BeginTransaction();

        // Bước 1: Tính tổng tiền
        decimal tongTien = 0;
        foreach (DataRow row in dtPhieuNhap.Rows)
        {
            tongTien += Convert.ToDecimal(row["ThanhTien"]);
        }

        // Bước 2: Thêm PHIEUNHAP và lấy MaPhieuNhap
        string queryPhieuNhap = @"INSERT INTO PHIEUNHAP 
                                 (MaNhanVien, MaNhaCungCap, NgayNhap, TongTienNhap) 
                                 OUTPUT INSERTED.MaPhieuNhap
                                 VALUES (@MaNhanVien, @MaNhaCungCap, @NgayNhap, @TongTienNhap)";
        SqlCommand cmdPhieuNhap = new SqlCommand(queryPhieuNhap, conn, transaction);
        cmdPhieuNhap.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
        cmdPhieuNhap.Parameters.AddWithValue("@MaNhaCungCap", cboNhaCungCap.SelectedValue);
        cmdPhieuNhap.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
        cmdPhieuNhap.Parameters.AddWithValue("@TongTienNhap", tongTien);

        int maPhieuNhap = (int)cmdPhieuNhap.ExecuteScalar();

        // Bước 3: Thêm chi tiết NHAP và cập nhật tồn kho
        foreach (DataRow row in dtPhieuNhap.Rows)
        {
            int maHang = Convert.ToInt32(row["MaHang"]);
            int soLuong = Convert.ToInt32(row["SoLuongNhap"]);
            decimal giaNhap = Convert.ToDecimal(row["GiaNhap"]);

            // Thêm chi tiết nhập
            string queryChiTiet = @"INSERT INTO NHAP 
                                   (MaPhieuNhap, MaHang, SoLuongNhap, GiaNhap) 
                                   VALUES (@MaPhieuNhap, @MaHang, @SoLuongNhap, @GiaNhap)";
            SqlCommand cmdChiTiet = new SqlCommand(queryChiTiet, conn, transaction);
            cmdChiTiet.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
            cmdChiTiet.Parameters.AddWithValue("@MaHang", maHang);
            cmdChiTiet.Parameters.AddWithValue("@SoLuongNhap", soLuong);
            cmdChiTiet.Parameters.AddWithValue("@GiaNhap", giaNhap);
            cmdChiTiet.ExecuteNonQuery();

            // Cập nhật tồn kho (CỘNG thêm)
            string queryUpdateKho = @"UPDATE HANGHOA 
                                     SET SoLuong = SoLuong + @SoLuong 
                                     WHERE MaHang = @MaHang";
            SqlCommand cmdUpdateKho = new SqlCommand(queryUpdateKho, conn, transaction);
            cmdUpdateKho.Parameters.AddWithValue("@SoLuong", soLuong);
            cmdUpdateKho.Parameters.AddWithValue("@MaHang", maHang);
            cmdUpdateKho.ExecuteNonQuery();
        }

        // Bước 4: Commit transaction
        transaction.Commit();
        MessageBox.Show($"Lưu phiếu nhập thành công!\nMã phiếu: {maPhieuNhap}\nTổng tiền: {tongTien:N0} đ",
            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Bước 5: Reset form
        dtPhieuNhap.Clear();
        txtGhiChu.Clear();
        TinhTongTien();
        LoadSanPham(); // Reload để cập nhật tồn kho
    }
    catch (Exception ex)
    {
        transaction?.Rollback();
        MessageBox.Show("Lỗi lưu phiếu nhập: " + ex.Message, "Lỗi",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        conn?.Close();
    }
}
```

---

## 🎨 Hệ thống Thiết kế "Green Harmony"

### **Màu sắc:**
- **Primary:** #28A745 (40, 167, 69) - Nút Lưu, Tiêu đề
- **Background:** #F8F9FA (248, 249, 250) - Khu vực 1 & 3
- **White:** #FFFFFF - Khu vực 2
- **Danger:** #DC3545 (220, 53, 69) - Tổng tiền
- **Gray:** #6C757D (108, 117, 125) - Nút Hủy

### **Font:**
- **Tiêu đề:** Segoe UI, 12pt, Bold
- **Label:** Segoe UI, 10pt
- **Input:** Segoe UI, 10pt
- **Tổng tiền:** Segoe UI, 14pt, Bold

### **Icon Emoji:**
- 👤 Nhân viên
- 🏢 Nhà cung cấp
- 📅 Ngày nhập
- 🔍 Tìm kiếm
- 📋 Chi tiết
- 📝 Ghi chú
- 💰 Tổng tiền
- 💾 Lưu
- ❌ Hủy

---

## ✅ Validation & Error Handling

### **1. Validation trước khi Lưu:**
- ✅ Phiếu nhập không được trống
- ✅ Phải chọn nhà cung cấp
- ✅ Số lượng nhập > 0
- ✅ Giá nhập > 0

### **2. Xác nhận:**
- Xác nhận trước khi lưu phiếu
- Xác nhận trước khi xóa sản phẩm
- Xác nhận trước khi hủy phiếu

### **3. Error Handling:**
- Try-catch cho tất cả database operations
- Rollback transaction nếu có lỗi
- Hiển thị thông báo lỗi rõ ràng

---

## 🚀 Workflow Sử dụng

### **Quy trình Nhập kho:**

1. **Mở form Nhập kho**
   - Tên nhân viên tự động hiển thị
   - Ngày nhập mặc định là hôm nay

2. **Chọn Nhà cung cấp**
   - Chọn từ ComboBox

3. **Thêm Sản phẩm**
   - Tìm kiếm sản phẩm
   - Double-click để thêm vào phiếu
   - Hoặc nhập trực tiếp vào grid

4. **Điều chỉnh Chi tiết**
   - Sửa số lượng nhập
   - Sửa giá nhập (mặc định 70% giá bán)
   - Xóa dòng nếu cần

5. **Thêm Ghi chú** (tùy chọn)

6. **Kiểm tra Tổng tiền**

7. **Lưu Phiếu nhập**
   - Xác nhận
   - Hệ thống tự động:
     - Tạo phiếu nhập
     - Lưu chi tiết
     - Cập nhật tồn kho
     - Hiển thị mã phiếu

8. **Hoàn tất**
   - Form tự động reset
   - Sẵn sàng cho phiếu tiếp theo

---

## 📊 Cấu trúc Database

### **Bảng PHIEUNHAP:**
```sql
CREATE TABLE PHIEUNHAP (
    MaPhieuNhap INT PRIMARY KEY IDENTITY,
    MaNhanVien INT,
    MaNhaCungCap INT,
    NgayNhap DATETIME,
    TongTienNhap DECIMAL(18,2)
)
```

### **Bảng NHAP (Chi tiết):**
```sql
CREATE TABLE NHAP (
    MaPhieuNhap INT,
    MaHang INT,
    SoLuongNhap INT,
    GiaNhap DECIMAL(18,2),
    PRIMARY KEY (MaPhieuNhap, MaHang)
)
```

### **Cập nhật HANGHOA:**
```sql
UPDATE HANGHOA 
SET SoLuong = SoLuong + @SoLuongNhap 
WHERE MaHang = @MaHang
```

---

## 🎯 Điểm Nổi bật

### **1. Giao diện Trực quan:**
- Bố cục 3 khu vực rõ ràng
- SplitContainer cho tìm kiếm & chi tiết
- Màu sắc hài hòa theo "Green Harmony"

### **2. Trải nghiệm Tốt:**
- Tìm kiếm real-time
- Double-click thêm nhanh
- Sửa trực tiếp trong grid
- Tự động tính thành tiền

### **3. An toàn Dữ liệu:**
- SqlTransaction đảm bảo tính toàn vẹn
- Validation đầy đủ
- Error handling chặt chẽ
- Rollback khi có lỗi

### **4. Linh hoạt:**
- Giá nhập có thể điều chỉnh
- Ghi chú tùy chọn
- Xóa/sửa dễ dàng

---

## 📝 Lưu ý Quan trọng

1. **Giá nhập mặc định:** 70% giá bán, có thể sửa
2. **Tồn kho:** Được CỘNG thêm, không ghi đè
3. **Transaction:** Đảm bảo tất cả thao tác thành công hoặc rollback
4. **Validation:** Kiểm tra đầy đủ trước khi lưu
5. **Reload:** Sau khi lưu, reload danh sách để cập nhật tồn kho

---

## 🏆 Kết luận

Form **Nhập kho** là một ví dụ xuất sắc về:
- ✅ Thiết kế UI/UX chuyên nghiệp
- ✅ Bố cục responsive với TableLayoutPanel
- ✅ Logic nghiệp vụ chặt chẽ
- ✅ An toàn dữ liệu với Transaction
- ✅ Trải nghiệm người dùng tốt

**Sẵn sàng triển khai thực tế!** 🎊
