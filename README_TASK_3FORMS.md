# Phần việc 3 form đã bổ sung

Repo này đã được code thêm 3 chức năng theo `form(1).zip`:
- Cấp thẻ thư viện
- Hồ sơ bạn đọc
- Mượn / Trả sách

## File chính
- `SunriseLibrary/Forms/frmCapTheThuVien.cs`
- `SunriseLibrary/Forms/frmHoSoBanDoc.cs`
- `SunriseLibrary/Forms/frmMuonTraSach.cs`
- `SunriseLibrary/Services/CapTheThuVienService.cs`
- `SunriseLibrary/Services/BanDocService.cs`
- `SunriseLibrary/Services/MuonTraSachService.cs`
- `SunriseLibrary/Database/01_CreateDatabase_SQLServer.sql`
- `SunriseLibrary/Database/02_SeedData_SQLServer.sql`
- `SunriseLibrary/Database/03_Extend_CardAndBorrowFeatures_SQLServer.sql`

## Cách chạy
1. Sửa connection string trong `SunriseLibrary/App.config` cho đúng SQL Server của máy.
2. Nếu làm mới CSDL: chạy `01_CreateDatabase_SQLServer.sql`, rồi `02_SeedData_SQLServer.sql`.
3. Nếu repo nhóm đã có CSDL cũ: chạy thêm `03_Extend_CardAndBorrowFeatures_SQLServer.sql`.
4. Mở solution và chạy bằng Visual Studio.

## Dữ liệu mẫu
- Bạn đọc mẫu: `THE001`
- Sinh viên chờ cấp thẻ: `SV2024001`, `SV2024002`, `SV2024003`
- Mã sách đang mượn mẫu: `BAR002`
- Mã tài liệu có sẵn để mượn: `TL002`, `BAR003`
