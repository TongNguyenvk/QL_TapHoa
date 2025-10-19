-- XÓA DATABASE CŨ NẾU TỒN TẠI VÀ TẠO DATABASE MỚI
USE master;
GO
IF DB_ID('QLTapHoa') IS NOT NULL
    DROP DATABASE QLTapHoa;
GO
CREATE DATABASE QLTapHoa;
GO
USE QLTapHoa;
GO

-- Bảng 1: VAI TRÒ (Phân quyền)
CREATE TABLE VAITRO (
    MaVaiTro INT PRIMARY KEY,
    TenVaiTro NVARCHAR(50) NOT NULL,
    MoTa NVARCHAR(255)
);
GO

-- Bảng 2: NHÂN VIÊN
CREATE TABLE NHANVIEN (
    MaNhanVien INT PRIMARY KEY IDENTITY(1,1),
    TenNhanVien NVARCHAR(100) NOT NULL,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(255) NOT NULL, -- Kích thước lớn để sau này có thể băm mật khẩu
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    SdtNhanVien VARCHAR(10),
    MaVaiTro INT,
    FOREIGN KEY (MaVaiTro) REFERENCES VAITRO(MaVaiTro)
);
GO

-- Bảng 3: LỊCH LÀM VIỆC
CREATE TABLE LICHLAMVIEC (
    MaLich INT PRIMARY KEY IDENTITY(1,1),
    MaNhanVien INT NOT NULL,
    NgayLamViec DATE NOT NULL,
    GioBatDau TIME,
    GioKetThuc TIME,
    MoTa NVARCHAR(255),
    FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
);
GO

-- Bảng 4: LOẠI HÀNG
CREATE TABLE LOAIHANG (
    MaLoaiHang INT PRIMARY KEY IDENTITY(1,1),
    TenLoaiHang NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(255)
);
GO

-- Bảng 5: HÀNG HÓA
CREATE TABLE HANGHOA (
    MaHang INT PRIMARY KEY IDENTITY(1,1),
    TenHang NVARCHAR(150) NOT NULL,
    SoLuong INT NOT NULL DEFAULT 0,
    GiaBan DECIMAL(18, 0) NOT NULL, -- Sử dụng DECIMAL cho tiền tệ, 0 số thập phân
    MoTa NVARCHAR(MAX),
    MaLoaiHang INT,
    FOREIGN KEY (MaLoaiHang) REFERENCES LOAIHANG(MaLoaiHang)
);
GO

-- Bảng 6: NHÀ CUNG CẤP
CREATE TABLE NHACUNGCAP (
    MaNhaCungCap INT PRIMARY KEY IDENTITY(1,1),
    TenNhaCungCap NVARCHAR(150) NOT NULL,
    DiaChi NVARCHAR(255),
    Sdt VARCHAR(15)
);
GO

-- Bảng 7: HÓA ĐƠN
CREATE TABLE HOADON (
    MaHoaDon INT PRIMARY KEY IDENTITY(1,1),
    MaNhanVien INT,
    NgayBan DATETIME NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(18, 0) NOT NULL DEFAULT 0,
    FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
);
GO

-- Bảng 8: BAN (Chi tiết hóa đơn)
CREATE TABLE BAN (
    MaHoaDon INT NOT NULL,
    MaHang INT NOT NULL,
    SoLuongBan INT NOT NULL,
    DonGia DECIMAL(18, 0) NOT NULL, -- Giá tại thời điểm bán
    ThanhTien AS (CAST(SoLuongBan AS DECIMAL(18,0)) * DonGia),
    PRIMARY KEY (MaHoaDon, MaHang),
    FOREIGN KEY (MaHoaDon) REFERENCES HOADON(MaHoaDon),
    FOREIGN KEY (MaHang) REFERENCES HANGHOA(MaHang)
);
GO

-- Bảng 9: PHIẾU NHẬP
CREATE TABLE PHIEUNHAP (
    MaPhieuNhap INT PRIMARY KEY IDENTITY(1,1),
    MaNhanVien INT,
    MaNhaCungCap INT,
    NgayNhap DATETIME NOT NULL DEFAULT GETDATE(),
    TongTienNhap DECIMAL(18, 0) DEFAULT 0,
    FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien),
    FOREIGN KEY (MaNhaCungCap) REFERENCES NHACUNGCAP(MaNhaCungCap)
);
GO

-- Bảng 10: NHẬP (Chi tiết phiếu nhập)
CREATE TABLE NHAP (
    MaPhieuNhap INT NOT NULL,
    MaHang INT NOT NULL,
    SoLuongNhap INT NOT NULL,
    GiaNhap DECIMAL(18, 0) NOT NULL,
    ThanhTienNhap AS (CAST(SoLuongNhap AS DECIMAL(18,0)) * GiaNhap),
    PRIMARY KEY (MaPhieuNhap, MaHang),
    FOREIGN KEY (MaPhieuNhap) REFERENCES PHIEUNHAP(MaPhieuNhap),
    FOREIGN KEY (MaHang) REFERENCES HANGHOA(MaHang)
);
GO

----------------------------------------------------
-- CHÈN DỮ LIỆU MẪU ĐỂ KIỂM THỬ
----------------------------------------------------
-- Dữ liệu vai trò
INSERT INTO VAITRO (MaVaiTro, TenVaiTro, MoTa) VALUES
(1, N'Quản lý', N'Toàn quyền quản trị hệ thống'),
(2, N'Nhân viên Bán hàng', N'Chịu trách nhiệm bán hàng và tạo hóa đơn'),
(3, N'Nhân viên Kho', N'Chịu trách nhiệm nhập và quản lý kho');
GO

-- Dữ liệu nhân viên
INSERT INTO NHANVIEN (TenNhanVien, TenDangNhap, MatKhau, GioiTinh, DiaChi, SdtNhanVien, MaVaiTro) VALUES
(N'Nguyễn Văn An', 'admin', '123', N'Nam', N'123 Cầu Giấy, Hà Nội', '0987654321', 1),
(N'Trần Thị Bích', 'banhang01', '123', N'Nữ', N'456 Xuân Thủy, Hà Nội', '0912345678', 2),
(N'Lê Minh Cường', 'kho01', '123', N'Nam', N'789 Mỹ Đình, Hà Nội', '0905558888', 3);
GO

-- Dữ liệu loại hàng
INSERT INTO LOAIHANG (TenLoaiHang, MoTa) VALUES
(N'Đồ uống', N'Các loại nước ngọt, bia, nước suối'),
(N'Thực phẩm khô', N'Mì gói, bánh kẹo, đồ hộp'),
(N'Hóa mỹ phẩm', N'Dầu gội, sữa tắm, kem đánh răng');
GO

-- Dữ liệu hàng hóa
INSERT INTO HANGHOA (TenHang, SoLuong, GiaBan, MaLoaiHang) VALUES
(N'Nước ngọt Coca Cola 1.5L', 100, 18000, 1),
(N'Mì Hảo Hảo tôm chua cay', 500, 4000, 2),
(N'Bánh Chocopie 12 cái', 80, 52000, 2),
(N'Dầu gội Clear Men 650g', 50, 165000, 3);
GO

-- Dữ liệu nhà cung cấp
INSERT INTO NHACUNGCAP (TenNhaCungCap, DiaChi, Sdt) VALUES
(N'Công ty TNHH Coca Cola Việt Nam', N'Quận 1, TP.HCM', '02838293838'),
(N'Công ty Cổ phần Acecook Việt Nam', N'KCN Tân Bình, TP.HCM', '02838150969');
GO