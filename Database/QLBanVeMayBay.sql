-- =============================================
-- CƠ SỞ DỮ LIỆU: QUẢN LÝ BÁN VÉ MÁY BAY
-- =============================================
USE master
GO

IF DB_ID('QLBanVeMayBay') IS NOT NULL
BEGIN
    ALTER DATABASE QLBanVeMayBay SET SINGLE_USER WITH ROLLBACK IMMEDIATE
    DROP DATABASE QLBanVeMayBay
END
GO

CREATE DATABASE QLBanVeMayBay
GO

USE QLBanVeMayBay
GO

-- =============================================
-- TẠO BẢNG
-- =============================================
CREATE TABLE NhanVien
(
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(50) NOT NULL,
    VaiTro NVARCHAR(20) NOT NULL
)
GO

CREATE TABLE SanBay
(
    MaSanBay VARCHAR(5) PRIMARY KEY,
    TenSanBay NVARCHAR(100) NOT NULL,
    ThanhPho NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE MayBay
(
    MaMayBay INT IDENTITY(1,1) PRIMARY KEY,
    SoHieu VARCHAR(20) NOT NULL UNIQUE,
    LoaiMayBay NVARCHAR(50) NOT NULL,
    SoHangGhe INT NOT NULL
)
GO

CREATE TABLE Ghe
(
    MaGhe INT IDENTITY(1,1) PRIMARY KEY,
    MaMayBay INT NOT NULL FOREIGN KEY REFERENCES MayBay(MaMayBay),
    SoGhe VARCHAR(5) NOT NULL,
    HangVe NVARCHAR(20) NOT NULL
)
GO

CREATE TABLE ChuyenBay
(
    MaChuyenBay VARCHAR(10) PRIMARY KEY,
    MaMayBay INT NOT NULL FOREIGN KEY REFERENCES MayBay(MaMayBay),
    SanBayDi VARCHAR(5) NOT NULL FOREIGN KEY REFERENCES SanBay(MaSanBay),
    SanBayDen VARCHAR(5) NOT NULL FOREIGN KEY REFERENCES SanBay(MaSanBay),
    NgayGioBay DATETIME NOT NULL,
    GiaPhoThong MONEY NOT NULL,
    GiaThuongGia MONEY NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Mở bán'
)
GO

CREATE TABLE KhachHang
(
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    CCCD VARCHAR(12) NOT NULL UNIQUE,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(5) NOT NULL,
    SoDienThoai VARCHAR(15),
    Email VARCHAR(100)
)
GO

CREATE TABLE Ve
(
    MaVe INT IDENTITY(1,1) PRIMARY KEY,
    MaChuyenBay VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES ChuyenBay(MaChuyenBay),
    MaKH INT NOT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
    MaGhe INT NOT NULL FOREIGN KEY REFERENCES Ghe(MaGhe),
    GiaVe MONEY NOT NULL,
    PhuongThuc NVARCHAR(20) NOT NULL,
    NgayDat DATETIME NOT NULL DEFAULT GETDATE(),
    MaNV INT NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNV),
    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Đã đặt'
)
GO

-- =============================================
-- ĐĂNG NHẬP
-- =============================================
CREATE PROC sp_DangNhap
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(50)
AS
BEGIN
    SELECT MaNV, HoTen, VaiTro
    FROM NhanVien
    WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau
END
GO

-- =============================================
-- NHÂN VIÊN
-- =============================================
CREATE PROC sp_NhanVien_DanhSach
AS
BEGIN
    SELECT MaNV, HoTen, TenDangNhap, VaiTro
    FROM NhanVien
    ORDER BY MaNV
END
GO

CREATE PROC sp_NhanVien_Them
    @HoTen NVARCHAR(100),
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(50),
    @VaiTro NVARCHAR(20)
AS
BEGIN
    IF EXISTS (SELECT * FROM NhanVien WHERE TenDangNhap = @TenDangNhap)
    BEGIN
        RAISERROR(N'Tên đăng nhập đã tồn tại.', 16, 1)
        RETURN
    END

    INSERT INTO NhanVien(HoTen, TenDangNhap, MatKhau, VaiTro)
    VALUES(@HoTen, @TenDangNhap, @MatKhau, @VaiTro)
END
GO

CREATE PROC sp_NhanVien_Sua
    @MaNV INT,
    @HoTen NVARCHAR(100),
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(50),
    @VaiTro NVARCHAR(20)
AS
BEGIN
    IF EXISTS (SELECT * FROM NhanVien WHERE TenDangNhap = @TenDangNhap AND MaNV <> @MaNV)
    BEGIN
        RAISERROR(N'Tên đăng nhập đã tồn tại.', 16, 1)
        RETURN
    END

    -- Để trống mật khẩu thì giữ mật khẩu cũ
    UPDATE NhanVien
    SET HoTen = @HoTen,
        TenDangNhap = @TenDangNhap,
        MatKhau = CASE WHEN @MatKhau = '' THEN MatKhau ELSE @MatKhau END,
        VaiTro = @VaiTro
    WHERE MaNV = @MaNV
END
GO

CREATE PROC sp_NhanVien_Xoa
    @MaNV INT
AS
BEGIN
    IF EXISTS (SELECT * FROM Ve WHERE MaNV = @MaNV)
    BEGIN
        RAISERROR(N'Nhân viên đã bán vé, không thể xóa.', 16, 1)
        RETURN
    END

    DELETE FROM NhanVien WHERE MaNV = @MaNV
END
GO

-- =============================================
-- SÂN BAY
-- =============================================
CREATE PROC sp_SanBay_DanhSach
AS
BEGIN
    SELECT MaSanBay, TenSanBay, ThanhPho
    FROM SanBay
    ORDER BY MaSanBay
END
GO

CREATE PROC sp_SanBay_Them
    @MaSanBay VARCHAR(5),
    @TenSanBay NVARCHAR(100),
    @ThanhPho NVARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT * FROM SanBay WHERE MaSanBay = @MaSanBay)
    BEGIN
        RAISERROR(N'Mã sân bay đã tồn tại.', 16, 1)
        RETURN
    END

    INSERT INTO SanBay(MaSanBay, TenSanBay, ThanhPho)
    VALUES(@MaSanBay, @TenSanBay, @ThanhPho)
END
GO

CREATE PROC sp_SanBay_Sua
    @MaSanBay VARCHAR(5),
    @TenSanBay NVARCHAR(100),
    @ThanhPho NVARCHAR(50)
AS
BEGIN
    UPDATE SanBay
    SET TenSanBay = @TenSanBay, ThanhPho = @ThanhPho
    WHERE MaSanBay = @MaSanBay
END
GO

CREATE PROC sp_SanBay_Xoa
    @MaSanBay VARCHAR(5)
AS
BEGIN
    IF EXISTS (SELECT * FROM ChuyenBay WHERE SanBayDi = @MaSanBay OR SanBayDen = @MaSanBay)
    BEGIN
        RAISERROR(N'Sân bay đang có chuyến bay, không thể xóa.', 16, 1)
        RETURN
    END

    DELETE FROM SanBay WHERE MaSanBay = @MaSanBay
END
GO

-- =============================================
-- MÁY BAY
-- Mỗi hàng 6 ghế A-F. Hàng 1-2 là Thương gia, các hàng còn lại là Phổ thông.
-- =============================================
CREATE PROC sp_MayBay_DanhSach
AS
BEGIN
    SELECT m.MaMayBay, m.SoHieu, m.LoaiMayBay, m.SoHangGhe,
           (SELECT COUNT(*) FROM Ghe g WHERE g.MaMayBay = m.MaMayBay) AS TongGhe
    FROM MayBay m
    ORDER BY m.MaMayBay
END
GO

CREATE PROC sp_MayBay_Them
    @SoHieu VARCHAR(20),
    @LoaiMayBay NVARCHAR(50),
    @SoHangGhe INT
AS
BEGIN
    IF EXISTS (SELECT * FROM MayBay WHERE SoHieu = @SoHieu)
    BEGIN
        RAISERROR(N'Số hiệu máy bay đã tồn tại.', 16, 1)
        RETURN
    END

    INSERT INTO MayBay(SoHieu, LoaiMayBay, SoHangGhe)
    VALUES(@SoHieu, @LoaiMayBay, @SoHangGhe)

    DECLARE @MaMayBay INT = SCOPE_IDENTITY()
    DECLARE @Hang INT = 1

    WHILE @Hang <= @SoHangGhe
    BEGIN
        INSERT INTO Ghe(MaMayBay, SoGhe, HangVe)
        SELECT @MaMayBay,
               CAST(@Hang AS VARCHAR(3)) + Cot,
               CASE WHEN @Hang <= 2 THEN N'Thương gia' ELSE N'Phổ thông' END
        FROM (VALUES ('A'), ('B'), ('C'), ('D'), ('E'), ('F')) AS DanhSachCot(Cot)

        SET @Hang = @Hang + 1
    END
END
GO

CREATE PROC sp_MayBay_Sua
    @MaMayBay INT,
    @SoHieu VARCHAR(20),
    @LoaiMayBay NVARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT * FROM MayBay WHERE SoHieu = @SoHieu AND MaMayBay <> @MaMayBay)
    BEGIN
        RAISERROR(N'Số hiệu máy bay đã tồn tại.', 16, 1)
        RETURN
    END

    UPDATE MayBay
    SET SoHieu = @SoHieu, LoaiMayBay = @LoaiMayBay
    WHERE MaMayBay = @MaMayBay
END
GO

CREATE PROC sp_MayBay_Xoa
    @MaMayBay INT
AS
BEGIN
    IF EXISTS (SELECT * FROM ChuyenBay WHERE MaMayBay = @MaMayBay)
    BEGIN
        RAISERROR(N'Máy bay đang có chuyến bay, không thể xóa.', 16, 1)
        RETURN
    END

    DELETE FROM Ghe WHERE MaMayBay = @MaMayBay
    DELETE FROM MayBay WHERE MaMayBay = @MaMayBay
END
GO

-- =============================================
-- CHUYẾN BAY
-- =============================================
CREATE PROC sp_ChuyenBay_DanhSach
AS
BEGIN
    SELECT c.MaChuyenBay, c.MaMayBay, m.SoHieu, c.SanBayDi, c.SanBayDen,
           c.NgayGioBay, c.GiaPhoThong, c.GiaThuongGia, c.TrangThai,
           (SELECT COUNT(*) FROM Ve v WHERE v.MaChuyenBay = c.MaChuyenBay AND v.TrangThai = N'Đã đặt') AS SoVeDaBan
    FROM ChuyenBay c
    JOIN MayBay m ON m.MaMayBay = c.MaMayBay
    ORDER BY c.NgayGioBay DESC
END
GO

-- Chuyến còn mở bán, dùng cho màn hình đặt vé
CREATE PROC sp_ChuyenBay_ConBan
AS
BEGIN
    SELECT MaChuyenBay,
           MaChuyenBay + ' | ' + SanBayDi + ' - ' + SanBayDen + ' | ' + FORMAT(NgayGioBay, 'dd/MM/yyyy HH:mm') AS ThongTin,
           GiaPhoThong, GiaThuongGia
    FROM ChuyenBay
    WHERE TrangThai = N'Mở bán' AND NgayGioBay > GETDATE()
    ORDER BY NgayGioBay
END
GO

CREATE PROC sp_ChuyenBay_Them
    @MaChuyenBay VARCHAR(10),
    @MaMayBay INT,
    @SanBayDi VARCHAR(5),
    @SanBayDen VARCHAR(5),
    @NgayGioBay DATETIME,
    @GiaPhoThong MONEY,
    @GiaThuongGia MONEY,
    @TrangThai NVARCHAR(20)
AS
BEGIN
    IF EXISTS (SELECT * FROM ChuyenBay WHERE MaChuyenBay = @MaChuyenBay)
    BEGIN
        RAISERROR(N'Mã chuyến bay đã tồn tại.', 16, 1)
        RETURN
    END

    IF @SanBayDi = @SanBayDen
    BEGIN
        RAISERROR(N'Sân bay đi và sân bay đến phải khác nhau.', 16, 1)
        RETURN
    END

    INSERT INTO ChuyenBay(MaChuyenBay, MaMayBay, SanBayDi, SanBayDen, NgayGioBay, GiaPhoThong, GiaThuongGia, TrangThai)
    VALUES(@MaChuyenBay, @MaMayBay, @SanBayDi, @SanBayDen, @NgayGioBay, @GiaPhoThong, @GiaThuongGia, @TrangThai)
END
GO

CREATE PROC sp_ChuyenBay_Sua
    @MaChuyenBay VARCHAR(10),
    @MaMayBay INT,
    @SanBayDi VARCHAR(5),
    @SanBayDen VARCHAR(5),
    @NgayGioBay DATETIME,
    @GiaPhoThong MONEY,
    @GiaThuongGia MONEY,
    @TrangThai NVARCHAR(20)
AS
BEGIN
    IF @SanBayDi = @SanBayDen
    BEGIN
        RAISERROR(N'Sân bay đi và sân bay đến phải khác nhau.', 16, 1)
        RETURN
    END

    IF @MaMayBay <> (SELECT MaMayBay FROM ChuyenBay WHERE MaChuyenBay = @MaChuyenBay)
       AND EXISTS (SELECT * FROM Ve WHERE MaChuyenBay = @MaChuyenBay)
    BEGIN
        RAISERROR(N'Chuyến bay đã có vé, không thể đổi máy bay.', 16, 1)
        RETURN
    END

    UPDATE ChuyenBay
    SET MaMayBay = @MaMayBay,
        SanBayDi = @SanBayDi,
        SanBayDen = @SanBayDen,
        NgayGioBay = @NgayGioBay,
        GiaPhoThong = @GiaPhoThong,
        GiaThuongGia = @GiaThuongGia,
        TrangThai = @TrangThai
    WHERE MaChuyenBay = @MaChuyenBay
END
GO

CREATE PROC sp_ChuyenBay_Xoa
    @MaChuyenBay VARCHAR(10)
AS
BEGIN
    IF EXISTS (SELECT * FROM Ve WHERE MaChuyenBay = @MaChuyenBay)
    BEGIN
        RAISERROR(N'Chuyến bay đã có vé, không thể xóa.', 16, 1)
        RETURN
    END

    DELETE FROM ChuyenBay WHERE MaChuyenBay = @MaChuyenBay
END
GO

-- =============================================
-- KHÁCH HÀNG
-- =============================================
CREATE PROC sp_KhachHang_DanhSach
    @TuKhoa NVARCHAR(100) = ''
AS
BEGIN
    SELECT MaKH, HoTen, CCCD, NgaySinh, GioiTinh, SoDienThoai, Email
    FROM KhachHang
    WHERE HoTen LIKE N'%' + @TuKhoa + '%'
       OR CCCD LIKE '%' + @TuKhoa + '%'
       OR SoDienThoai LIKE '%' + @TuKhoa + '%'
    ORDER BY MaKH DESC
END
GO

-- Danh sách khách hàng cho ComboBox ở màn hình đặt vé
CREATE PROC sp_KhachHang_ChonLua
AS
BEGIN
    SELECT MaKH, HoTen + ' - ' + CCCD AS ThongTin
    FROM KhachHang
    ORDER BY HoTen
END
GO

CREATE PROC sp_KhachHang_Them
    @HoTen NVARCHAR(100),
    @CCCD VARCHAR(12),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(5),
    @SoDienThoai VARCHAR(15),
    @Email VARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT * FROM KhachHang WHERE CCCD = @CCCD)
    BEGIN
        RAISERROR(N'Số CCCD đã tồn tại.', 16, 1)
        RETURN
    END

    INSERT INTO KhachHang(HoTen, CCCD, NgaySinh, GioiTinh, SoDienThoai, Email)
    VALUES(@HoTen, @CCCD, @NgaySinh, @GioiTinh, @SoDienThoai, @Email)
END
GO

CREATE PROC sp_KhachHang_Sua
    @MaKH INT,
    @HoTen NVARCHAR(100),
    @CCCD VARCHAR(12),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(5),
    @SoDienThoai VARCHAR(15),
    @Email VARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT * FROM KhachHang WHERE CCCD = @CCCD AND MaKH <> @MaKH)
    BEGIN
        RAISERROR(N'Số CCCD đã tồn tại.', 16, 1)
        RETURN
    END

    UPDATE KhachHang
    SET HoTen = @HoTen,
        CCCD = @CCCD,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        SoDienThoai = @SoDienThoai,
        Email = @Email
    WHERE MaKH = @MaKH
END
GO

CREATE PROC sp_KhachHang_Xoa
    @MaKH INT
AS
BEGIN
    IF EXISTS (SELECT * FROM Ve WHERE MaKH = @MaKH)
    BEGIN
        RAISERROR(N'Khách hàng đã có vé, không thể xóa.', 16, 1)
        RETURN
    END

    DELETE FROM KhachHang WHERE MaKH = @MaKH
END
GO

-- =============================================
-- ĐẶT VÉ - HỦY VÉ
-- =============================================
CREATE PROC sp_Ghe_ConTrong
    @MaChuyenBay VARCHAR(10),
    @HangVe NVARCHAR(20)
AS
BEGIN
    SELECT g.MaGhe, g.SoGhe
    FROM Ghe g
    JOIN ChuyenBay c ON c.MaMayBay = g.MaMayBay
    WHERE c.MaChuyenBay = @MaChuyenBay
      AND g.HangVe = @HangVe
      AND g.MaGhe NOT IN (SELECT MaGhe FROM Ve
                          WHERE MaChuyenBay = @MaChuyenBay AND TrangThai = N'Đã đặt')
    ORDER BY g.MaGhe
END
GO

CREATE PROC sp_Ve_Dat
    @MaChuyenBay VARCHAR(10),
    @MaKH INT,
    @MaGhe INT,
    @PhuongThuc NVARCHAR(20),
    @MaNV INT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM ChuyenBay
                   WHERE MaChuyenBay = @MaChuyenBay AND TrangThai = N'Mở bán' AND NgayGioBay > GETDATE())
    BEGIN
        RAISERROR(N'Chuyến bay không còn mở bán.', 16, 1)
        RETURN
    END

    IF EXISTS (SELECT * FROM Ve WHERE MaChuyenBay = @MaChuyenBay AND MaGhe = @MaGhe AND TrangThai = N'Đã đặt')
    BEGIN
        RAISERROR(N'Ghế này đã có người đặt.', 16, 1)
        RETURN
    END

    IF EXISTS (SELECT * FROM Ve WHERE MaChuyenBay = @MaChuyenBay AND MaKH = @MaKH AND TrangThai = N'Đã đặt')
    BEGIN
        RAISERROR(N'Khách hàng đã có vé trên chuyến bay này.', 16, 1)
        RETURN
    END

    -- Giá vé lấy theo hạng của ghế
    DECLARE @GiaVe MONEY

    SELECT @GiaVe = CASE WHEN g.HangVe = N'Thương gia' THEN c.GiaThuongGia ELSE c.GiaPhoThong END
    FROM Ghe g, ChuyenBay c
    WHERE g.MaGhe = @MaGhe AND c.MaChuyenBay = @MaChuyenBay

    INSERT INTO Ve(MaChuyenBay, MaKH, MaGhe, GiaVe, PhuongThuc, MaNV)
    VALUES(@MaChuyenBay, @MaKH, @MaGhe, @GiaVe, @PhuongThuc, @MaNV)

    SELECT SCOPE_IDENTITY() AS MaVe
END
GO

CREATE PROC sp_Ve_DanhSach
    @TuKhoa NVARCHAR(100) = ''
AS
BEGIN
    SELECT v.MaVe, k.HoTen, k.CCCD, v.MaChuyenBay,
           c.SanBayDi + ' - ' + c.SanBayDen AS ChangBay,
           c.NgayGioBay, g.SoGhe, g.HangVe, v.GiaVe, v.NgayDat, v.TrangThai
    FROM Ve v
    JOIN KhachHang k ON k.MaKH = v.MaKH
    JOIN ChuyenBay c ON c.MaChuyenBay = v.MaChuyenBay
    JOIN Ghe g ON g.MaGhe = v.MaGhe
    WHERE CAST(v.MaVe AS VARCHAR(10)) = @TuKhoa
       OR k.HoTen LIKE N'%' + @TuKhoa + '%'
       OR k.CCCD LIKE '%' + @TuKhoa + '%'
       OR v.MaChuyenBay LIKE '%' + @TuKhoa + '%'
    ORDER BY v.MaVe DESC
END
GO

CREATE PROC sp_Ve_Huy
    @MaVe INT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM Ve WHERE MaVe = @MaVe AND TrangThai = N'Đã đặt')
    BEGIN
        RAISERROR(N'Vé không tồn tại hoặc đã bị hủy.', 16, 1)
        RETURN
    END

    IF EXISTS (SELECT * FROM Ve v JOIN ChuyenBay c ON c.MaChuyenBay = v.MaChuyenBay
               WHERE v.MaVe = @MaVe AND c.NgayGioBay <= GETDATE())
    BEGIN
        RAISERROR(N'Chuyến bay đã khởi hành, không thể hủy vé.', 16, 1)
        RETURN
    END

    UPDATE Ve SET TrangThai = N'Đã hủy' WHERE MaVe = @MaVe
END
GO

-- =============================================
-- THỐNG KÊ
-- =============================================
CREATE PROC sp_ThongKe_TheoThang
    @Nam INT
AS
BEGIN
    SELECT @Nam AS Nam,
           MONTH(NgayDat) AS Thang,
           COUNT(*) AS SoVe,
           SUM(GiaVe) AS DoanhThu
    FROM Ve
    WHERE TrangThai = N'Đã đặt' AND YEAR(NgayDat) = @Nam
    GROUP BY MONTH(NgayDat)
    ORDER BY Thang
END
GO

CREATE PROC sp_ThongKe_TheoChuyen
    @Nam INT
AS
BEGIN
    SELECT c.MaChuyenBay,
           c.SanBayDi + ' - ' + c.SanBayDen AS ChangBay,
           c.NgayGioBay,
           COUNT(v.MaVe) AS SoVe,
           ISNULL(SUM(v.GiaVe), 0) AS DoanhThu
    FROM ChuyenBay c
    JOIN Ve v ON v.MaChuyenBay = c.MaChuyenBay AND v.TrangThai = N'Đã đặt'
    WHERE YEAR(v.NgayDat) = @Nam
    GROUP BY c.MaChuyenBay, c.SanBayDi, c.SanBayDen, c.NgayGioBay
    ORDER BY DoanhThu DESC
END
GO

-- =============================================
-- BÁO CÁO (CRYSTAL REPORT)
-- =============================================
CREATE PROC sp_BaoCao_Ve
    @MaVe INT
AS
BEGIN
    SELECT v.MaVe, k.HoTen, k.CCCD, v.MaChuyenBay, m.SoHieu,
           di.ThanhPho + ' (' + c.SanBayDi + ')' AS NoiDi,
           den.ThanhPho + ' (' + c.SanBayDen + ')' AS NoiDen,
           FORMAT(c.NgayGioBay, 'dd/MM/yyyy HH:mm') AS NgayGioBay,
           g.SoGhe, g.HangVe, v.GiaVe, v.PhuongThuc,
           FORMAT(v.NgayDat, 'dd/MM/yyyy HH:mm') AS NgayDat,
           n.HoTen AS NhanVien
    FROM Ve v
    JOIN KhachHang k ON k.MaKH = v.MaKH
    JOIN ChuyenBay c ON c.MaChuyenBay = v.MaChuyenBay
    JOIN MayBay m ON m.MaMayBay = c.MaMayBay
    JOIN SanBay di ON di.MaSanBay = c.SanBayDi
    JOIN SanBay den ON den.MaSanBay = c.SanBayDen
    JOIN Ghe g ON g.MaGhe = v.MaGhe
    JOIN NhanVien n ON n.MaNV = v.MaNV
    WHERE v.MaVe = @MaVe
END
GO

CREATE PROC sp_BaoCao_HanhKhach
    @MaChuyenBay VARCHAR(10)
AS
BEGIN
    SELECT c.MaChuyenBay,
           c.SanBayDi + ' - ' + c.SanBayDen AS ChangBay,
           FORMAT(c.NgayGioBay, 'dd/MM/yyyy HH:mm') AS NgayGioBay,
           m.SoHieu,
           v.MaVe, k.HoTen, k.CCCD, k.SoDienThoai, g.SoGhe, g.HangVe, v.GiaVe
    FROM Ve v
    JOIN KhachHang k ON k.MaKH = v.MaKH
    JOIN ChuyenBay c ON c.MaChuyenBay = v.MaChuyenBay
    JOIN MayBay m ON m.MaMayBay = c.MaMayBay
    JOIN Ghe g ON g.MaGhe = v.MaGhe
    WHERE v.MaChuyenBay = @MaChuyenBay AND v.TrangThai = N'Đã đặt'
    ORDER BY g.MaGhe
END
GO

-- =============================================
-- DỮ LIỆU MẪU
-- =============================================
INSERT INTO NhanVien(HoTen, TenDangNhap, MatKhau, VaiTro) VALUES
(N'Quản trị viên', 'admin', '123', N'Admin'),
(N'Nguyễn Thu Hà', 'nv01', '123', N'Nhân viên'),
(N'Trần Minh Đức', 'nv02', '123', N'Nhân viên')
GO

INSERT INTO SanBay(MaSanBay, TenSanBay, ThanhPho) VALUES
('HAN', N'Sân bay quốc tế Nội Bài', N'Hà Nội'),
('SGN', N'Sân bay quốc tế Tân Sơn Nhất', N'TP. Hồ Chí Minh'),
('DAD', N'Sân bay quốc tế Đà Nẵng', N'Đà Nẵng'),
('CXR', N'Sân bay quốc tế Cam Ranh', N'Nha Trang'),
('PQC', N'Sân bay quốc tế Phú Quốc', N'Phú Quốc'),
('HPH', N'Sân bay quốc tế Cát Bi', N'Hải Phòng'),
('VCA', N'Sân bay quốc tế Cần Thơ', N'Cần Thơ'),
('DLI', N'Sân bay Liên Khương', N'Đà Lạt')
GO

EXEC sp_MayBay_Them 'VN-A321', N'Airbus A321', 10
EXEC sp_MayBay_Them 'VN-A350', N'Airbus A350', 12
EXEC sp_MayBay_Them 'VN-B787', N'Boeing 787', 12
GO

-- Ngày bay tính theo ngày hiện tại để luôn có chuyến để đặt
DECLARE @HomNay DATETIME = CAST(CAST(GETDATE() AS DATE) AS DATETIME)

INSERT INTO ChuyenBay(MaChuyenBay, MaMayBay, SanBayDi, SanBayDen, NgayGioBay, GiaPhoThong, GiaThuongGia, TrangThai) VALUES
('VN101', 1, 'HAN', 'SGN', DATEADD(HOUR, -52 * 24 + 8, @HomNay), 1500000, 3500000, N'Đã bay'),
('VN102', 1, 'SGN', 'HAN', DATEADD(HOUR, -21 * 24 + 14, @HomNay), 1500000, 3500000, N'Đã bay'),
('VN201', 2, 'HAN', 'DAD', DATEADD(HOUR, 2 * 24 + 7, @HomNay), 1100000, 2600000, N'Mở bán'),
('VN202', 2, 'DAD', 'HAN', DATEADD(HOUR, 4 * 24 + 18, @HomNay), 1100000, 2600000, N'Mở bán'),
('VN301', 3, 'SGN', 'PQC', DATEADD(HOUR, 3 * 24 + 9, @HomNay), 900000, 2100000, N'Mở bán'),
('VN302', 3, 'PQC', 'SGN', DATEADD(HOUR, 6 * 24 + 16, @HomNay), 900000, 2100000, N'Mở bán'),
('VN401', 1, 'HAN', 'CXR', DATEADD(HOUR, 5 * 24 + 10, @HomNay), 1300000, 3000000, N'Mở bán'),
('VN501', 2, 'SGN', 'DLI', DATEADD(HOUR, 7 * 24 + 6, @HomNay), 800000, 1900000, N'Mở bán')
GO

INSERT INTO KhachHang(HoTen, CCCD, NgaySinh, GioiTinh, SoDienThoai, Email) VALUES
(N'Nguyễn Văn An', '001095001234', '1995-03-12', N'Nam', '0912345678', 'an.nguyen@gmail.com'),
(N'Trần Thị Bình', '079198002345', '1998-07-25', N'Nữ', '0987654321', 'binh.tran@gmail.com'),
(N'Lê Hoàng Cường', '048090003456', '1990-11-02', N'Nam', '0905112233', 'cuong.le@gmail.com'),
(N'Phạm Thu Dung', '001201004567', '2001-01-18', N'Nữ', '0934556677', 'dung.pham@gmail.com'),
(N'Hoàng Minh Đức', '079087005678', '1987-09-30', N'Nam', '0978123456', 'duc.hoang@gmail.com'),
(N'Vũ Ngọc Hà', '031199006789', '1999-05-08', N'Nữ', '0916789012', 'ha.vu@gmail.com'),
(N'Đặng Quốc Huy', '001092007890', '1992-12-21', N'Nam', '0965432109', 'huy.dang@gmail.com'),
(N'Bùi Thanh Lan', '079200008901', '2000-04-14', N'Nữ', '0947891234', 'lan.bui@gmail.com')
GO

-- Vé của các chuyến đã bay (ngày đặt ở các tháng trước)
INSERT INTO Ve(MaChuyenBay, MaKH, MaGhe, GiaVe, PhuongThuc, NgayDat, MaNV, TrangThai)
SELECT 'VN101', 1, MaGhe, 3500000, N'Tiền mặt', DATEADD(DAY, -60, GETDATE()), 2, N'Đã đặt' FROM Ghe WHERE MaMayBay = 1 AND SoGhe = '1A'
UNION ALL
SELECT 'VN101', 2, MaGhe, 1500000, N'Chuyển khoản', DATEADD(DAY, -58, GETDATE()), 2, N'Đã đặt' FROM Ghe WHERE MaMayBay = 1 AND SoGhe = '5C'
UNION ALL
SELECT 'VN101', 3, MaGhe, 1500000, N'Thẻ', DATEADD(DAY, -57, GETDATE()), 3, N'Đã đặt' FROM Ghe WHERE MaMayBay = 1 AND SoGhe = '5D'
UNION ALL
SELECT 'VN102', 4, MaGhe, 1500000, N'Tiền mặt', DATEADD(DAY, -30, GETDATE()), 3, N'Đã đặt' FROM Ghe WHERE MaMayBay = 1 AND SoGhe = '7A'
UNION ALL
SELECT 'VN102', 5, MaGhe, 3500000, N'Thẻ', DATEADD(DAY, -28, GETDATE()), 2, N'Đã đặt' FROM Ghe WHERE MaMayBay = 1 AND SoGhe = '2F'
UNION ALL
SELECT 'VN102', 6, MaGhe, 1500000, N'Chuyển khoản', DATEADD(DAY, -27, GETDATE()), 2, N'Đã hủy' FROM Ghe WHERE MaMayBay = 1 AND SoGhe = '8B'
GO

-- Vé của các chuyến sắp bay
DECLARE @Ghe INT

SELECT @Ghe = MaGhe FROM Ghe WHERE MaMayBay = 2 AND SoGhe = '3A'
EXEC sp_Ve_Dat 'VN201', 1, @Ghe, N'Tiền mặt', 2

SELECT @Ghe = MaGhe FROM Ghe WHERE MaMayBay = 2 AND SoGhe = '3B'
EXEC sp_Ve_Dat 'VN201', 7, @Ghe, N'Tiền mặt', 2

SELECT @Ghe = MaGhe FROM Ghe WHERE MaMayBay = 2 AND SoGhe = '1C'
EXEC sp_Ve_Dat 'VN201', 8, @Ghe, N'Thẻ', 3

SELECT @Ghe = MaGhe FROM Ghe WHERE MaMayBay = 3 AND SoGhe = '6E'
EXEC sp_Ve_Dat 'VN301', 2, @Ghe, N'Chuyển khoản', 3

SELECT @Ghe = MaGhe FROM Ghe WHERE MaMayBay = 1 AND SoGhe = '2A'
EXEC sp_Ve_Dat 'VN401', 4, @Ghe, N'Thẻ', 2
GO
