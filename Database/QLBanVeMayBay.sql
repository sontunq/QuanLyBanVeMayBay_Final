-- CƠ SỞ DỮ LIỆU: QUẢN LÝ BÁN VÉ MÁY BAY
-- File 1/2: tạo bảng, view, stored procedure và dữ liệu bắt buộc
-- (tài khoản đăng nhập, hạng thành viên, mức phí hủy).
-- Cách dùng: tạo CSDL trống bằng lệnh bên dưới, chạy file này, sau đó chạy DuLieuMau.sql.
-- CREATE DATABASE QLBanVeMayBay
USE QLBanVeMayBay
GO


-- TẠO BẢNG
CREATE TABLE NhanVien
(
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(50) NOT NULL,
    VaiTro NVARCHAR(20) NOT NULL
)


CREATE TABLE SanBay
(
    MaSanBay VARCHAR(5) PRIMARY KEY,
    TenSanBay NVARCHAR(100) NOT NULL,
    ThanhPho NVARCHAR(50) NOT NULL
)


CREATE TABLE MayBay
(
    MaMayBay INT IDENTITY(1,1) PRIMARY KEY,
    SoHieu VARCHAR(20) NOT NULL UNIQUE,
    LoaiMayBay NVARCHAR(50) NOT NULL,
    SoHangGhe INT NOT NULL
)


CREATE TABLE Ghe
(
    MaGhe INT IDENTITY(1,1) PRIMARY KEY,
    MaMayBay INT NOT NULL REFERENCES MayBay(MaMayBay),
    SoGhe VARCHAR(5) NOT NULL,
    HangVe NVARCHAR(20) NOT NULL
)


CREATE TABLE ChuyenBay
(
    MaChuyenBay VARCHAR(10) PRIMARY KEY,
    MaMayBay INT NOT NULL REFERENCES MayBay(MaMayBay),
    SanBayDi VARCHAR(5) NOT NULL REFERENCES SanBay(MaSanBay),
    SanBayDen VARCHAR(5) NOT NULL REFERENCES SanBay(MaSanBay),
    NgayGioBay DATETIME NOT NULL,
    ThoiGianBay INT NOT NULL DEFAULT 120, -- Thời gian bay (phút)
    GiaPhoThong MONEY NOT NULL,
    GiaThuongGia MONEY NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Mở bán'
)


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


CREATE TABLE Ve
(
    MaVe INT IDENTITY(1,1) PRIMARY KEY,
    MaChuyenBay VARCHAR(10) NOT NULL REFERENCES ChuyenBay(MaChuyenBay),
    MaKH INT NOT NULL REFERENCES KhachHang(MaKH),
    MaGhe INT NOT NULL REFERENCES Ghe(MaGhe),
    GiaVe MONEY NOT NULL,              -- Số tiền khách trả (đã trừ ưu đãi)
    GiaGoc MONEY NULL,                 -- Giá vé trước ưu đãi
    TyLeGiam INT NOT NULL DEFAULT 0,   -- % ưu đãi đã áp dụng
    PhuongThuc NVARCHAR(20) NOT NULL,
    NgayDat DATETIME NOT NULL DEFAULT GETDATE(),
    MaNV INT NOT NULL REFERENCES NhanVien(MaNV),
    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Đã đặt',
    NgayHuy DATETIME NULL,
    LyDoHuy NVARCHAR(200) NULL,
    TyLePhiHuy INT NULL,               -- % phí hủy đã áp dụng
    PhiHuy MONEY NULL,                 -- Tiền phí giữ lại (tính vào doanh thu)
    TienHoan MONEY NULL                -- Tiền trả lại cho khách
)


-- Hạng thành viên: đạt hạng khi tổng chi tiêu >= MucChiTieu
CREATE TABLE HangThanhVien
(
    TenHang NVARCHAR(20) PRIMARY KEY,
    MucChiTieu MONEY NOT NULL,
    TyLeGiam INT NOT NULL           -- % giảm giá vé
)


-- Mức phí hủy: áp dụng khi còn ít nhất SoGioTruocBay giờ trước giờ bay
CREATE TABLE MucPhiHuy
(
    SoGioTruocBay INT PRIMARY KEY,
    TyLePhi INT NOT NULL            -- % phí trên số tiền khách đã trả
)
GO


-- ƯU ĐÃI KHÁCH HÀNG
-- Tổng chi tiêu = tổng tiền các vé đã đặt (không tính vé đã hủy).
-- Khách mới (chưa có vé nào) được giảm 10%. Ưu đãi được cộng dồn:
-- tổng % giảm = TyLeHang + TyLeKhachMoi.
CREATE VIEW vw_UuDaiKhachHang
AS
SELECT k.MaKH,
       ISNULL(t.TongChiTieu, 0) AS TongChiTieu,
       ISNULL(h.TenHang, N'Thường') AS TenHang,
       ISNULL(h.TyLeGiam, 0) AS TyLeHang,
       CASE WHEN t.MaKH IS NULL THEN 10 ELSE 0 END AS TyLeKhachMoi
FROM KhachHang k
LEFT JOIN (SELECT MaKH, SUM(GiaVe) AS TongChiTieu
           FROM Ve
           WHERE TrangThai = N'Đã đặt'
           GROUP BY MaKH) t ON t.MaKH = k.MaKH
OUTER APPLY (SELECT TOP 1 TenHang, TyLeGiam
             FROM HangThanhVien
             WHERE MucChiTieu <= ISNULL(t.TongChiTieu, 0)
             ORDER BY MucChiTieu DESC) h
GO


-- PHÍ HỦY VÉ
-- Phí hủy = % (theo số giờ còn lại trước giờ bay) x số tiền khách đã trả.
-- Tiền hoàn = số tiền đã trả - phí hủy.
CREATE VIEW vw_PhiHuyVe
AS
SELECT v.MaVe, v.GiaVe,
       DATEDIFF(MINUTE, GETDATE(), c.NgayGioBay) AS SoPhutConLai,
       ISNULL(m.TyLePhi, 100) AS TyLePhi,
       ROUND(v.GiaVe * ISNULL(m.TyLePhi, 100) / 100, 0) AS PhiHuy,
       v.GiaVe - ROUND(v.GiaVe * ISNULL(m.TyLePhi, 100) / 100, 0) AS TienHoan
FROM Ve v
JOIN ChuyenBay c ON c.MaChuyenBay = v.MaChuyenBay
OUTER APPLY (SELECT TOP 1 TyLePhi
             FROM MucPhiHuy
             WHERE DATEDIFF(MINUTE, GETDATE(), c.NgayGioBay) >= SoGioTruocBay * 60
             ORDER BY SoGioTruocBay DESC) m
GO


-- ĐĂNG NHẬP
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


-- NHÂN VIÊN
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


-- SÂN BAY
CREATE PROC sp_SanBay_DanhSach
AS
BEGIN
    SELECT MaSanBay, TenSanBay, ThanhPho,
           TenSanBay + ' (' + MaSanBay + ')' AS ThongTin
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


-- MÁY BAY
-- Mỗi hàng 6 ghế A-F. Hàng 1-2 là Thương gia, các hàng còn lại là Phổ thông.
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


-- CHUYẾN BAY
CREATE PROC sp_ChuyenBay_DanhSach
AS
BEGIN
    SELECT c.MaChuyenBay, c.MaMayBay, m.SoHieu, c.SanBayDi, c.SanBayDen,
           di.TenSanBay AS TenSanBayDi, den.TenSanBay AS TenSanBayDen,
           c.NgayGioBay, c.ThoiGianBay,
           DATEADD(MINUTE, c.ThoiGianBay, c.NgayGioBay) AS NgayGioDen,
           c.GiaPhoThong, c.GiaThuongGia, c.TrangThai,
           (SELECT COUNT(*) FROM Ve v WHERE v.MaChuyenBay = c.MaChuyenBay AND v.TrangThai = N'Đã đặt') AS SoVeDaBan
    FROM ChuyenBay c
    JOIN MayBay m ON m.MaMayBay = c.MaMayBay
    JOIN SanBay di ON di.MaSanBay = c.SanBayDi
    JOIN SanBay den ON den.MaSanBay = c.SanBayDen
    ORDER BY c.NgayGioBay DESC
END
GO

-- Chuyến còn mở bán, dùng cho màn hình đặt vé
CREATE PROC sp_ChuyenBay_ConBan
AS
BEGIN
    SELECT c.MaChuyenBay,
           c.MaChuyenBay + ' | ' + FORMAT(c.NgayGioBay, 'dd/MM/yyyy HH:mm') + ' | '
               + di.TenSanBay + N' → ' + den.TenSanBay AS ThongTin,
           di.TenSanBay AS TenSanBayDi, den.TenSanBay AS TenSanBayDen,
           c.NgayGioBay, DATEADD(MINUTE, c.ThoiGianBay, c.NgayGioBay) AS NgayGioDen,
           c.GiaPhoThong, c.GiaThuongGia
    FROM ChuyenBay c
    JOIN SanBay di ON di.MaSanBay = c.SanBayDi
    JOIN SanBay den ON den.MaSanBay = c.SanBayDen
    WHERE c.TrangThai = N'Mở bán' AND c.NgayGioBay > GETDATE()
    ORDER BY c.NgayGioBay
END
GO

CREATE PROC sp_ChuyenBay_Them
    @MaChuyenBay VARCHAR(10),
    @MaMayBay INT,
    @SanBayDi VARCHAR(5),
    @SanBayDen VARCHAR(5),
    @NgayGioBay DATETIME,
    @ThoiGianBay INT,
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

    IF @ThoiGianBay <= 0
    BEGIN
        RAISERROR(N'Thời gian bay phải lớn hơn 0.', 16, 1)
        RETURN
    END

    INSERT INTO ChuyenBay(MaChuyenBay, MaMayBay, SanBayDi, SanBayDen, NgayGioBay, ThoiGianBay, GiaPhoThong, GiaThuongGia, TrangThai)
    VALUES(@MaChuyenBay, @MaMayBay, @SanBayDi, @SanBayDen, @NgayGioBay, @ThoiGianBay, @GiaPhoThong, @GiaThuongGia, @TrangThai)
END
GO

CREATE PROC sp_ChuyenBay_Sua
    @MaChuyenBay VARCHAR(10),
    @MaMayBay INT,
    @SanBayDi VARCHAR(5),
    @SanBayDen VARCHAR(5),
    @NgayGioBay DATETIME,
    @ThoiGianBay INT,
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

    IF @ThoiGianBay <= 0
    BEGIN
        RAISERROR(N'Thời gian bay phải lớn hơn 0.', 16, 1)
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
        ThoiGianBay = @ThoiGianBay,
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


-- KHÁCH HÀNG
CREATE PROC sp_KhachHang_DanhSach
    @TuKhoa NVARCHAR(100) = ''
AS
BEGIN
    SELECT k.MaKH, k.HoTen, k.CCCD, k.NgaySinh, k.GioiTinh, k.SoDienThoai, k.Email,
           u.TenHang, u.TongChiTieu
    FROM KhachHang k
    JOIN vw_UuDaiKhachHang u ON u.MaKH = k.MaKH
    WHERE k.HoTen LIKE N'%' + @TuKhoa + '%'
       OR k.CCCD LIKE '%' + @TuKhoa + '%'
       OR k.SoDienThoai LIKE '%' + @TuKhoa + '%'
    ORDER BY k.MaKH DESC
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

-- Hạng thành viên và % ưu đãi của khách, dùng ở màn hình đặt vé
CREATE PROC sp_KhachHang_UuDai
    @MaKH INT
AS
BEGIN
    SELECT MaKH, TongChiTieu, TenHang, TyLeHang, TyLeKhachMoi,
           TyLeHang + TyLeKhachMoi AS TyLeGiam
    FROM vw_UuDaiKhachHang
    WHERE MaKH = @MaKH
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

    -- Trả về mã khách vừa thêm để màn hình đặt vé chọn sẵn
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS MaKH
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


-- ĐẶT VÉ - HỦY VÉ
CREATE PROC sp_Ghe_ConTrong
    @MaChuyenBay VARCHAR(10),
    @HangVe NVARCHAR(20)
AS
BEGIN
    -- Mỗi hàng 6 ghế A-F: A, F cạnh cửa sổ; C, D cạnh lối đi; B, E ở giữa
    SELECT g.MaGhe, g.SoGhe,
           g.SoGhe + ' - ' + CASE RIGHT(g.SoGhe, 1)
                                 WHEN 'A' THEN N'Cửa sổ'
                                 WHEN 'F' THEN N'Cửa sổ'
                                 WHEN 'C' THEN N'Lối đi'
                                 WHEN 'D' THEN N'Lối đi'
                                 ELSE N'Ghế giữa'
                             END AS ThongTin
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

    -- Giá gốc lấy theo hạng của ghế
    DECLARE @GiaGoc MONEY, @TyLeGiam INT

    SELECT @GiaGoc = CASE WHEN g.HangVe = N'Thương gia' THEN c.GiaThuongGia ELSE c.GiaPhoThong END
    FROM Ghe g, ChuyenBay c
    WHERE g.MaGhe = @MaGhe AND c.MaChuyenBay = @MaChuyenBay

    -- % ưu đãi của khách (hạng thành viên + khách mới), tính trước khi thêm vé
    SELECT @TyLeGiam = TyLeHang + TyLeKhachMoi
    FROM vw_UuDaiKhachHang
    WHERE MaKH = @MaKH

    INSERT INTO Ve(MaChuyenBay, MaKH, MaGhe, GiaGoc, TyLeGiam, GiaVe, PhuongThuc, MaNV)
    VALUES(@MaChuyenBay, @MaKH, @MaGhe, @GiaGoc, @TyLeGiam,
           ROUND(@GiaGoc * (100 - @TyLeGiam) / 100, 0), @PhuongThuc, @MaNV)

    SELECT SCOPE_IDENTITY() AS MaVe
END
GO

CREATE PROC sp_Ve_DanhSach
    @TuKhoa NVARCHAR(100) = ''
AS
BEGIN
    SELECT v.MaVe, k.HoTen, k.CCCD, v.MaChuyenBay,
           di.TenSanBay + N' → ' + den.TenSanBay AS ChangBay,
           c.NgayGioBay, g.SoGhe, g.HangVe, v.GiaVe, v.NgayDat, v.TrangThai,
           v.NgayHuy, v.LyDoHuy, v.PhiHuy, v.TienHoan
    FROM Ve v
    JOIN KhachHang k ON k.MaKH = v.MaKH
    JOIN ChuyenBay c ON c.MaChuyenBay = v.MaChuyenBay
    JOIN SanBay di ON di.MaSanBay = c.SanBayDi
    JOIN SanBay den ON den.MaSanBay = c.SanBayDen
    JOIN Ghe g ON g.MaGhe = v.MaGhe
    WHERE CAST(v.MaVe AS VARCHAR(10)) = @TuKhoa
       OR k.HoTen LIKE N'%' + @TuKhoa + '%'
       OR k.CCCD LIKE '%' + @TuKhoa + '%'
       OR v.MaChuyenBay LIKE '%' + @TuKhoa + '%'
    ORDER BY v.MaVe DESC
END
GO

-- Xem trước phí hủy và tiền hoàn của một vé
CREATE PROC sp_Ve_TinhPhiHuy
    @MaVe INT
AS
BEGIN
    SELECT MaVe, GiaVe, SoPhutConLai, TyLePhi, PhiHuy, TienHoan
    FROM vw_PhiHuyVe
    WHERE MaVe = @MaVe
END
GO

CREATE PROC sp_Ve_Huy
    @MaVe INT,
    @LyDoHuy NVARCHAR(200)
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

    IF LTRIM(RTRIM(ISNULL(@LyDoHuy, N''))) = N''
    BEGIN
        RAISERROR(N'Vui lòng nhập lý do hủy vé.', 16, 1)
        RETURN
    END

    -- Phí hủy và tiền hoàn lấy từ vw_PhiHuyVe tại thời điểm hủy
    UPDATE v
    SET TrangThai = N'Đã hủy',
        NgayHuy = GETDATE(),
        LyDoHuy = LTRIM(RTRIM(@LyDoHuy)),
        TyLePhiHuy = p.TyLePhi,
        PhiHuy = p.PhiHuy,
        TienHoan = p.TienHoan
    FROM Ve v
    JOIN vw_PhiHuyVe p ON p.MaVe = v.MaVe
    WHERE v.MaVe = @MaVe

    SELECT TyLePhiHuy, PhiHuy, TienHoan FROM Ve WHERE MaVe = @MaVe
END
GO


-- THỐNG KÊ
-- Doanh thu = tiền vé đã bán (theo ngày đặt) + phí hủy giữ lại (theo ngày hủy)
CREATE PROC sp_ThongKe_TheoThang
    @Nam INT
AS
BEGIN
    ;WITH Thang AS (
        SELECT 1 AS Thang
        UNION ALL SELECT Thang + 1 FROM Thang WHERE Thang < 12
    ),
    Ban AS (
        SELECT MONTH(NgayDat) AS Thang, COUNT(*) AS SoVe, SUM(GiaVe) AS TienVe
        FROM Ve
        WHERE TrangThai = N'Đã đặt' AND YEAR(NgayDat) = @Nam
        GROUP BY MONTH(NgayDat)
    ),
    Huy AS (
        -- Vé hủy trước khi có chức năng phí hủy không có ngày hủy: tạm tính theo ngày đặt
        SELECT MONTH(ISNULL(NgayHuy, NgayDat)) AS Thang, COUNT(*) AS SoVeHuy, SUM(ISNULL(PhiHuy, 0)) AS PhiHuy
        FROM Ve
        WHERE TrangThai = N'Đã hủy' AND YEAR(ISNULL(NgayHuy, NgayDat)) = @Nam
        GROUP BY MONTH(ISNULL(NgayHuy, NgayDat))
    )
    SELECT @Nam AS Nam, t.Thang,
           ISNULL(b.SoVe, 0) AS SoVe,
           ISNULL(b.TienVe, 0) AS TienVe,
           ISNULL(h.SoVeHuy, 0) AS SoVeHuy,
           ISNULL(h.PhiHuy, 0) AS PhiHuy,
           ISNULL(b.TienVe, 0) + ISNULL(h.PhiHuy, 0) AS DoanhThu,
           -- Tỷ trọng: doanh thu tháng chiếm bao nhiêu % doanh thu cả năm
           CAST(CASE WHEN SUM(ISNULL(b.TienVe, 0) + ISNULL(h.PhiHuy, 0)) OVER () = 0 THEN 0
                     ELSE (ISNULL(b.TienVe, 0) + ISNULL(h.PhiHuy, 0)) * 100.0
                          / SUM(ISNULL(b.TienVe, 0) + ISNULL(h.PhiHuy, 0)) OVER ()
                END AS DECIMAL(5, 1)) AS TyTrong
    FROM Thang t
    LEFT JOIN Ban b ON b.Thang = t.Thang
    LEFT JOIN Huy h ON h.Thang = t.Thang
    ORDER BY t.Thang
END
GO

CREATE PROC sp_ThongKe_TheoChuyen
    @Nam INT
AS
BEGIN
    SELECT c.MaChuyenBay,
           di.TenSanBay + N' → ' + den.TenSanBay AS ChangBay,
           c.NgayGioBay,
           x.SoVe, x.TienVe, x.SoVeHuy, x.PhiHuy,
           x.TienVe + x.PhiHuy AS DoanhThu
    FROM ChuyenBay c
    JOIN SanBay di ON di.MaSanBay = c.SanBayDi
    JOIN SanBay den ON den.MaSanBay = c.SanBayDen
    JOIN (SELECT MaChuyenBay,
                 SUM(CASE WHEN TrangThai = N'Đã đặt' AND YEAR(NgayDat) = @Nam THEN 1 ELSE 0 END) AS SoVe,
                 SUM(CASE WHEN TrangThai = N'Đã đặt' AND YEAR(NgayDat) = @Nam THEN GiaVe ELSE 0 END) AS TienVe,
                 SUM(CASE WHEN TrangThai = N'Đã hủy' AND YEAR(ISNULL(NgayHuy, NgayDat)) = @Nam THEN 1 ELSE 0 END) AS SoVeHuy,
                 SUM(CASE WHEN TrangThai = N'Đã hủy' AND YEAR(ISNULL(NgayHuy, NgayDat)) = @Nam THEN ISNULL(PhiHuy, 0) ELSE 0 END) AS PhiHuy
          FROM Ve
          GROUP BY MaChuyenBay) x ON x.MaChuyenBay = c.MaChuyenBay
    WHERE x.SoVe + x.SoVeHuy > 0
    ORDER BY DoanhThu DESC
END
GO


-- BÁO CÁO
CREATE PROC sp_BaoCao_Ve
    @MaVe INT
AS
BEGIN
    SELECT v.MaVe, k.HoTen, k.CCCD, k.SoDienThoai, v.MaChuyenBay, m.SoHieu, m.LoaiMayBay,
           di.TenSanBay + ' (' + c.SanBayDi + ')' AS NoiDi, di.ThanhPho AS ThanhPhoDi,
           den.TenSanBay + ' (' + c.SanBayDen + ')' AS NoiDen, den.ThanhPho AS ThanhPhoDen,
           FORMAT(c.NgayGioBay, 'dd/MM/yyyy HH:mm') AS NgayGioBay,
           FORMAT(DATEADD(MINUTE, c.ThoiGianBay, c.NgayGioBay), 'dd/MM/yyyy HH:mm') AS NgayGioDen,
           CASE WHEN c.ThoiGianBay < 60 THEN CAST(c.ThoiGianBay AS VARCHAR(5)) + N' phút'
                WHEN c.ThoiGianBay % 60 = 0 THEN CAST(c.ThoiGianBay / 60 AS VARCHAR(5)) + N' giờ'
                ELSE CAST(c.ThoiGianBay / 60 AS VARCHAR(5)) + N' giờ ' + CAST(c.ThoiGianBay % 60 AS VARCHAR(5)) + N' phút'
           END AS ThoiGianBay,
           g.SoGhe, g.HangVe,
           ISNULL(v.GiaGoc, v.GiaVe) AS GiaGoc, v.TyLeGiam, v.GiaVe, v.PhuongThuc,
           FORMAT(v.NgayDat, 'dd/MM/yyyy HH:mm') AS NgayDat,
           n.HoTen AS NhanVien, v.TrangThai,
           CASE WHEN v.TrangThai = N'Đã hủy' AND v.NgayHuy IS NULL
                THEN N'VÉ ĐÃ HỦY'   -- vé hủy trước khi có chức năng phí hủy
                WHEN v.TrangThai = N'Đã hủy'
                THEN N'VÉ ĐÃ HỦY ngày ' + FORMAT(v.NgayHuy, 'dd/MM/yyyy HH:mm')
                     + N'  -  Phí hủy: ' + FORMAT(ISNULL(v.PhiHuy, 0), 'N0', 'vi-VN') + N' đ'
                     + N'  -  Hoàn lại: ' + FORMAT(ISNULL(v.TienHoan, 0), 'N0', 'vi-VN') + N' đ'
                ELSE N'' END AS ThongTinHuy
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
           di.TenSanBay + N' → ' + den.TenSanBay AS ChangBay,
           di.TenSanBay + ' (' + c.SanBayDi + ')' AS NoiDi,
           den.TenSanBay + ' (' + c.SanBayDen + ')' AS NoiDen,
           FORMAT(c.NgayGioBay, 'dd/MM/yyyy HH:mm') AS NgayGioBay,
           FORMAT(DATEADD(MINUTE, c.ThoiGianBay, c.NgayGioBay), 'dd/MM/yyyy HH:mm') AS NgayGioDen,
           m.SoHieu, m.LoaiMayBay,
           v.MaVe, k.HoTen, k.CCCD, k.SoDienThoai, g.SoGhe, g.HangVe, v.GiaVe
    FROM Ve v
    JOIN KhachHang k ON k.MaKH = v.MaKH
    JOIN ChuyenBay c ON c.MaChuyenBay = v.MaChuyenBay
    JOIN MayBay m ON m.MaMayBay = c.MaMayBay
    JOIN SanBay di ON di.MaSanBay = c.SanBayDi
    JOIN SanBay den ON den.MaSanBay = c.SanBayDen
    JOIN Ghe g ON g.MaGhe = v.MaGhe
    WHERE v.MaChuyenBay = @MaChuyenBay AND v.TrangThai = N'Đã đặt'
    ORDER BY g.MaGhe
END
GO

-- PROCEDURE THỐNG KÊ & DANH SÁCH HÀNH KHÁCH
CREATE PROC sp_ThongKe_DoanhThuThang
    @Nam INT
AS
BEGIN
    SET NOCOUNT ON;
    ;WITH Thang AS (
        SELECT 1 AS Thang
        UNION ALL SELECT Thang + 1 FROM Thang WHERE Thang < 12
    )
    SELECT @Nam AS Nam, t.Thang, COUNT(v.MaVe) AS SoVe,
           ISNULL(SUM(v.GiaVe), 0) AS DoanhThu
    FROM Thang t
    LEFT JOIN Ve v ON YEAR(v.NgayDat) = @Nam
        AND MONTH(v.NgayDat) = t.Thang AND v.TrangThai = N'Đã đặt'
    GROUP BY t.Thang
    ORDER BY t.Thang;
END
GO

CREATE PROC sp_ThongKe_DoanhThuNam
    @TuNam INT = 2024,
    @DenNam INT = 2026
AS
BEGIN
    SET NOCOUNT ON;
    IF @TuNam > @DenNam OR @DenNam - @TuNam > 100
    BEGIN
        RAISERROR(N'Khoảng năm không hợp lệ (tối đa 101 năm).', 16, 1);
        RETURN;
    END;
    ;WITH Nam AS (
        SELECT @TuNam AS Nam
        UNION ALL SELECT Nam + 1 FROM Nam WHERE Nam < @DenNam
    )
    SELECT n.Nam, COUNT(v.MaVe) AS SoVe,
           ISNULL(SUM(v.GiaVe), 0) AS DoanhThu
    FROM Nam n
    LEFT JOIN Ve v ON YEAR(v.NgayDat) = n.Nam AND v.TrangThai = N'Đã đặt'
    GROUP BY n.Nam
    ORDER BY n.Nam
    OPTION (MAXRECURSION 101);
END
GO

CREATE PROC sp_ChuyenBay_DanhSachHanhKhach
    @MaChuyenBay VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT c.MaChuyenBay, c.NgayGioBay,
           di.TenSanBay AS SanBayDi, den.TenSanBay AS SanBayDen,
           m.SoHieu, v.MaVe, k.MaKH, k.HoTen, k.CCCD,
           k.NgaySinh, k.GioiTinh, k.SoDienThoai, k.Email,
           g.SoGhe, g.HangVe, v.GiaVe, v.NgayDat
    FROM Ve v
    INNER JOIN KhachHang k ON k.MaKH = v.MaKH
    INNER JOIN ChuyenBay c ON c.MaChuyenBay = v.MaChuyenBay
    INNER JOIN MayBay m ON m.MaMayBay = c.MaMayBay
    INNER JOIN SanBay di ON di.MaSanBay = c.SanBayDi
    INNER JOIN SanBay den ON den.MaSanBay = c.SanBayDen
    INNER JOIN Ghe g ON g.MaGhe = v.MaGhe
    WHERE v.MaChuyenBay = @MaChuyenBay AND v.TrangThai = N'Đã đặt'
    ORDER BY TRY_CONVERT(INT, LEFT(g.SoGhe, LEN(g.SoGhe)-1)), RIGHT(g.SoGhe,1), k.HoTen;
END
GO


-- DỮ LIỆU BẮT BUỘC: hạng thành viên, mức phí hủy, tài khoản đăng nhập
INSERT INTO HangThanhVien(TenHang, MucChiTieu, TyLeGiam) VALUES
(N'Thường', 0, 0),
(N'Đồng', 5000000, 2),
(N'Bạc', 15000000, 4),
(N'Vàng', 30000000, 6),
(N'Kim Cương', 50000000, 8)
GO

INSERT INTO MucPhiHuy(SoGioTruocBay, TyLePhi) VALUES
(168, 10),   -- Từ 7 ngày trở lên
(72, 25),    -- Từ 3 ngày đến dưới 7 ngày
(24, 50),    -- Từ 24 giờ đến dưới 3 ngày
(0, 80)      -- Dưới 24 giờ
GO

INSERT INTO NhanVien(HoTen, TenDangNhap, MatKhau, VaiTro) VALUES
(N'Quản trị viên', 'admin', '123', N'Admin'),
(N'Nguyễn Thu Hà', 'nv01', '123', N'Nhân viên'),
(N'Trần Minh Đức', 'nv02', '123', N'Nhân viên')
GO

-- VÍ DỤ GỌI PROCEDURE
-- EXEC sp_ThongKe_DoanhThuThang @Nam = 2025;
-- EXEC sp_ThongKe_DoanhThuNam @TuNam = 2024, @DenNam = 2026;
-- EXEC sp_ChuyenBay_DanhSachHanhKhach @MaChuyenBay = 'VN101';
