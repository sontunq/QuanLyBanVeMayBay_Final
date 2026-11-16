# Quản lý bán vé máy bay

Ứng dụng Windows Forms (C#, .NET Framework 4.8) kết nối SQL Server, có báo cáo Crystal Reports.

## Yêu cầu

- Visual Studio 2022 (workload **.NET desktop development**)
- SQL Server
- SAP Crystal Reports for Visual Studio (bản cho VS 2022) và Crystal Reports Runtime 64-bit

## Cách chạy

1. Mở SQL Server Management Studio, mở file `Database/QLBanVeMayBay.sql` và bấm **Execute**.
   Script sẽ tự xóa (nếu có) rồi tạo lại CSDL `QLBanVeMayBay` kèm dữ liệu mẫu.
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
- Tra cứu và hủy vé
- Thống kê doanh thu theo tháng và theo chuyến bay
- Báo cáo Crystal Reports: in vé, danh sách hành khách theo chuyến, doanh thu theo tháng

## Cấu trúc thư mục

```
Database/
    QLBanVeMayBay.sql       Tạo bảng, stored procedure và dữ liệu mẫu
QLBanVeMayBay/
    Forms/                  Các form giao diện
    Reports/                Các file báo cáo Crystal Reports (.rpt)
    KetNoiCSDL.cs           Lớp gọi stored procedure
    PhienDangNhap.cs        Lưu thông tin nhân viên đang đăng nhập
    App.config              Chuỗi kết nối CSDL
```

Toàn bộ câu lệnh SQL nằm trong file `Database/QLBanVeMayBay.sql`. Code C# chỉ gọi stored procedure.
