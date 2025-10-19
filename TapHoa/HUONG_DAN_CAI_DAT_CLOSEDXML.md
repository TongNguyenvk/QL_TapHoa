# Hướng dẫn chức năng xuất dữ liệu ra Excel với ClosedXML

## Giải pháp hoàn chỉnh - Xuất Excel (.xlsx)

Chức năng xuất Excel đã được triển khai đầy đủ sử dụng thư viện ClosedXML, cho phép tạo file Excel với định dạng đẹp và chuyên nghiệp.

## Ưu điểm của ClosedXML:

✅ **File Excel thật (.xlsx)** - Không phải CSV, là file Excel chuẩn
✅ **Định dạng đẹp** - Header màu xanh lá, chữ trắng, in đậm
✅ **Tự động format** - Số tiền, ngày tháng được format đúng
✅ **Border đẹp** - Có viền cho toàn bộ bảng
✅ **Tự động điều chỉnh cột** - Độ rộng cột vừa với nội dung
✅ **Không cần Office** - Không yêu cầu cài Microsoft Office
✅ **Hỗ trợ tiếng Việt** - Hiển thị tiếng Việt hoàn hảo

## Chức năng đã được triển khai:

### 1. Xuất báo cáo doanh thu
- Click nút "📊 Kết xuất Excel" trong tab Doanh thu
- Chọn vị trí lưu file (định dạng .xlsx)
- File Excel sẽ chứa tất cả dữ liệu từ bảng doanh thu với định dạng đẹp

### 2. Xuất báo cáo tồn kho
- Click nút "📊 Kết xuất Excel" trong tab Tồn kho
- Chọn vị trí lưu file (định dạng .xlsx)
- File Excel sẽ chứa tất cả dữ liệu từ bảng tồn kho với định dạng đẹp

## Định dạng file Excel:

- **Header (dòng tiêu đề):**
  - Font in đậm
  - Nền màu xanh lá (#28A745)
  - Chữ màu trắng
  - Căn giữa theo chiều ngang và dọc

- **Dữ liệu:**
  - Số tiền: Format #,##0 (có dấu phân cách hàng nghìn)
  - Ngày tháng: Format dd/MM/yyyy HH:mm
  - Text: Hiển thị bình thường
  - Tự động nhận diện kiểu dữ liệu

- **Border:**
  - Có viền cho toàn bộ bảng
  - Viền ngoài và viền trong

- **Độ rộng cột:**
  - Tự động điều chỉnh vừa với nội dung

- **Tên file:**
  - Format: `[Tên báo cáo]_YYYYMMDD_HHmmss.xlsx`
  - Ví dụ: `Báo cáo doanh thu_20241019_143025.xlsx`

## Cách sử dụng:

1. **Xem báo cáo** - Chọn bộ lọc và click "Xem báo cáo"
2. **Xuất file** - Click nút "📊 Kết xuất Excel"
3. **Chọn vị trí** - Chọn nơi lưu file và đặt tên
4. **Mở file** - Chương trình sẽ hỏi có muốn mở file ngay không

## Mở file Excel:

### Cách 1: Tự động mở sau khi xuất
- Sau khi xuất thành công, chương trình sẽ hỏi
- Click "Yes" để mở file ngay lập tức

### Cách 2: Double-click file
- File .xlsx sẽ tự động mở trong Excel
- Không cần import hay cấu hình gì thêm

### Cách 3: Mở từ Excel
1. Mở Excel
2. File → Open → Chọn file .xlsx
3. File sẽ hiển thị với đầy đủ định dạng

## Xử lý lỗi:

Nếu gặp lỗi khi xuất file:
1. Đảm bảo file không đang được mở bởi chương trình khác
2. Kiểm tra quyền ghi vào thư mục đích
3. Đảm bảo có đủ dung lượng ổ đĩa

## Lưu ý:

- File .xlsx là file Excel chuẩn, mở được trên mọi phiên bản Excel
- Có thể mở bằng Google Sheets, LibreOffice Calc
- Định dạng đẹp, chuyên nghiệp
- Không cần cài đặt Microsoft Office để tạo file
- Hỗ trợ đầy đủ tiếng Việt

## Cài đặt ClosedXML:

### Trong Visual Studio:

**Cách 1: NuGet Package Manager Console**
1. Mở Visual Studio
2. Tools → NuGet Package Manager → Package Manager Console
3. Chạy lệnh: `Install-Package ClosedXML`

**Cách 2: NuGet Package Manager GUI**
1. Click chuột phải vào project TapHoa
2. Chọn "Manage NuGet Packages..."
3. Chọn tab "Browse"
4. Tìm kiếm "ClosedXML"
5. Click "Install"

### Kiểm tra cài đặt:

Sau khi cài đặt, bạn sẽ thấy:
- ClosedXML xuất hiện trong References của project
- Có thể build project thành công
- Chức năng xuất Excel hoạt động bình thường

## Các tính năng đã triển khai:

✅ Xuất file Excel (.xlsx) chuẩn
✅ Header có màu xanh lá, chữ trắng, in đậm
✅ Tự động format số tiền (có dấu phân cách hàng nghìn)
✅ Tự động format ngày tháng (dd/MM/yyyy HH:mm)
✅ Có border cho toàn bộ bảng
✅ Tự động điều chỉnh độ rộng cột
✅ Hỗ trợ tiếng Việt hoàn hảo
✅ Hỏi người dùng có muốn mở file sau khi xuất
