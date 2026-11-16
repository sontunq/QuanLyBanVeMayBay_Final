# Quản lý bán vé máy bay

Ứng dụng Windows Forms (C#, .NET Framework 4.8) kết nối SQL Server, có báo cáo Crystal Reports.

## Yêu cầu

- Visual Studio 2022 (workload **.NET desktop development**)
- SQL Server
- SAP Crystal Reports for Visual Studio (bản cho VS 2022) và Crystal Reports Runtime 64-bit

## Cách chạy

1. Trong SQL Server Management Studio:
   - Tạo CSDL trống: `CREATE DATABASE QLBanVeMayBay`
   - Chạy `Database/QLBanVeMayBay.sql`: tạo bảng, view, stored procedure, tài khoản đăng nhập,
     hạng thành viên và mức phí hủy.
   - Chạy `Database/DuLieuMau.sql`: thêm dữ liệu mẫu (sân bay, máy bay, khách hàng, chuyến bay, vé).
2. Mở `QLBanVeMayBay.sln` bằng Visual Studio.
3. Nếu SQL Server không phải máy chủ mặc định (`.`), sửa `Data Source` trong `QLBanVeMayBay/App.config`
   (ví dụ `.\SQLEXPRESS`).
4. Nhấn **F5** để chạy.

## Tài khoản mẫu

| Tên đăng nhập | Mật khẩu | Vai trò |
|---|---|---|
| admin | 123 | Admin |
| nv01 | 123 | Nhân viên |
| nv02 | 123 | Nhân viên |

## Chức năng

- Đăng nhập, phân quyền (chỉ Admin quản lý nhân viên)
- Quản lý sân bay, máy bay, chuyến bay, khách hàng, nhân viên
- Đặt vé: chọn chuyến bay, khách hàng, hạng vé, ghế còn trống, phương thức thanh toán
- Ưu đãi: khách mới giảm 10%; hạng thành viên theo tổng chi tiêu
  (Đồng ≥ 5tr: 2%, Bạc ≥ 15tr: 4%, Vàng ≥ 30tr: 6%, Kim Cương ≥ 50tr: 8%), sửa mức trong bảng `HangThanhVien`
- Tra cứu và hủy vé: bắt buộc nhập lý do; phí hủy tính theo % số tiền khách đã trả
  (còn ≥ 7 ngày: 10%, 3–7 ngày: 25%, 24 giờ–3 ngày: 50%, dưới 24 giờ: 80%), sửa mức trong bảng `MucPhiHuy`
- Thống kê doanh thu theo tháng và theo chuyến bay (doanh thu = tiền vé + phí hủy giữ lại)
- Báo cáo Crystal Reports: in vé, danh sách hành khách theo chuyến, doanh thu theo tháng

## Cấu trúc thư mục

```
Database/
    QLBanVeMayBay.sql       Tạo bảng, view, stored procedure và dữ liệu bắt buộc
    DuLieuMau.sql           Dữ liệu mẫu khoảng 1000 dòng (chạy sau QLBanVeMayBay.sql)
QLBanVeMayBay/
    Forms/                  Các form giao diện
    Reports/                Các file báo cáo Crystal Reports (.rpt)
    KetNoiCSDL.cs           Lớp gọi stored procedure
    PhienDangNhap.cs        Lưu thông tin nhân viên đang đăng nhập
    App.config              Chuỗi kết nối CSDL
```

Toàn bộ câu lệnh SQL nằm trong file `Database/QLBanVeMayBay.sql`. Code C# chỉ gọi stored procedure.
