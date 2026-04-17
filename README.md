# SunriseLibrary

Ứng dụng **quản lý thư viện Sunrise** được xây dựng bằng **C# WinForms**, sử dụng **SQL Server** và **LINQ to SQL** để quản lý dữ liệu.  
Đề tài được thực hiện theo định hướng môn **Công nghệ phần mềm**, bám theo các giai đoạn khảo sát hiện trạng, phân tích yêu cầu, thiết kế dữ liệu và hiện thực sản phẩm.

## Mục tiêu dự án

Xây dựng một ứng dụng quản lý thư viện có giao diện desktop, hỗ trợ các nghiệp vụ chính:

- Đăng nhập và phân vai trò người dùng
- Tra cứu tài liệu
- Quản lý mượn / trả sách
- Cấp thẻ thư viện
- Quản lý hồ sơ bạn đọc
- Quản lý tài liệu và bản sao tài liệu
- Báo cáo thống kê

## Công nghệ sử dụng

- **Ngôn ngữ:** C#
- **Giao diện:** Windows Forms
- **Cơ sở dữ liệu:** SQL Server
- **Truy xuất dữ liệu:** LINQ to SQL
- **IDE:** Visual Studio 2022
- **Quản lý mã nguồn:** GitHub

## Kiến trúc dữ liệu

Hệ thống hiện sử dụng 7 bảng lõi:

- `VAI_TRO`
- `TAI_KHOAN`
- `BAN_DOC`
- `PHAN_LOAI_TAI_LIEU`
- `TAI_LIEU`
- `BAN_SAO_TAI_LIEU`
- `PHIEU_MUON_TRA`

Các bảng này phục vụ cho 3 khối nghiệp vụ chính:

- Quản lý người dùng và phân quyền nền
- Quản lý tài liệu và bản sao tài liệu
- Quản lý giao dịch mượn / trả

## Chức năng chính


- Đăng nhập hệ thống
- Trang chủ hệ thống
- Tra cứu tài liệu
- Mượn / trả sách
- Cấp thẻ thư viện
- Hồ sơ bạn đọc
- Quản lý tài liệu
- Quản lý bản sao tài liệu
- Báo cáo thống kê

## Giao diện mẫu

Dự án được thiết kế giao diện trước bằng các form prototype theo yêu cầu môn học.  
Giao diện hiện tại được dựng bằng **WinForms Designer**, không tạo giao diện động bằng code.

## Cấu trúc thư mục

```text
SunriseLibrary
│
├── Data/              # lớp dữ liệu, context, model
├── Database/          # script SQL tạo bảng và dữ liệu mẫu
├── Forms/             # các form giao diện
├── Helpers/           # lớp hỗ trợ dùng chung
├── Models/            # entity / model
├── Services/          # xử lý nghiệp vụ
├── App.config         # cấu hình kết nối CSDL
├── Program.cs         # điểm khởi động chương trình
└── SunriseLibrary.sln
