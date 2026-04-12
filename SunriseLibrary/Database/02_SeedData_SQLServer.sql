USE ql_thu_vien_sunrise;
GO

INSERT INTO dbo.vai_tro (ten_vai_tro, mo_ta) VALUES
(N'BanDoc', N'Người dùng thư viện'),
(N'NhanVien', N'Nhân viên thư viện'),
(N'QuanTriVien', N'Quản trị hệ thống');
GO

INSERT INTO dbo.tai_khoan (ma_vai_tro, ten_dang_nhap, mat_khau, email, trang_thai)
VALUES
((SELECT ma_vai_tro FROM dbo.vai_tro WHERE ten_vai_tro = N'NhanVien'), N'nv01', N'123', N'nv01@sunrise.local', N'HoatDong'),
((SELECT ma_vai_tro FROM dbo.vai_tro WHERE ten_vai_tro = N'QuanTriVien'), N'admin', N'123', N'admin@sunrise.local', N'HoatDong'),
((SELECT ma_vai_tro FROM dbo.vai_tro WHERE ten_vai_tro = N'BanDoc'), N'bd01', N'123', N'bd01@sunrise.local', N'HoatDong');
GO

INSERT INTO dbo.ban_doc (ma_tai_khoan, ma_the, ho_ten, ngay_sinh, gioi_tinh, so_dien_thoai, dia_chi, loai_ban_doc, ngay_cap_the, ngay_het_han, trang_thai_the, mssv, khoa, lop)
VALUES
((SELECT ma_tai_khoan FROM dbo.tai_khoan WHERE ten_dang_nhap = N'bd01'), N'THE001', N'Nguyễn Văn A', '2004-05-10', N'Nam', N'0909123456', N'TP.HCM', N'SinhVien', CAST(GETDATE() AS DATE), DATEADD(YEAR, 1, CAST(GETDATE() AS DATE)), N'HoatDong', N'SV2024000', N'Công nghệ thông tin', N'DH21IT01');
GO

INSERT INTO dbo.sinh_vien_cho_cap_the (mssv, ho_ten, khoa, lop, ngay_sinh, email, so_dien_thoai, trang_thai_dong_bo, da_cap_the)
VALUES
(N'SV2024001', N'Lê Minh Anh', N'Công nghệ thông tin', N'DH24IT01', '2006-01-15', N'sv2024001@sunrise.local', N'0911111111', N'ChuaNhan', 0),
(N'SV2024002', N'Phạm Quốc Bảo', N'Kế toán', N'DH24KT01', '2006-03-18', N'sv2024002@sunrise.local', N'0922222222', N'ChuaNhan', 0),
(N'SV2024003', N'Trần Gia Hân', N'Quản trị kinh doanh', N'DH24QTKD01', '2006-07-21', N'sv2024003@sunrise.local', N'0933333333', N'DaNhan', 0);
GO

INSERT INTO dbo.phan_loai_tai_lieu (ten_phan_loai, ky_hieu, mo_ta, tu_khoa)
VALUES
(N'Công nghệ thông tin', N'CNTT', N'Sách ngành CNTT', N'lập trình,cơ sở dữ liệu,phần mềm'),
(N'Kinh tế', N'KT', N'Sách ngành kinh tế', N'kinh tế,quản trị,tài chính'),
(N'Văn học', N'VH', N'Sách văn học', N'tiểu thuyết,truyện,ngôn ngữ');
GO

INSERT INTO dbo.tai_lieu (ma_phan_loai, ma_doc, ten_tai_lieu, tac_gia, nha_xuat_ban, nam_xuat_ban, loai_tai_lieu, mo_ta, duong_dan_file, quyen_truy_cap, ngay_nhap)
VALUES
((SELECT ma_phan_loai FROM dbo.phan_loai_tai_lieu WHERE ky_hieu = N'CNTT'), N'TL001', N'Lập trình C# căn bản', N'Trần Minh Quân', N'NXB Giáo Dục', 2023, N'SachIn', N'Sách cơ bản về C#', N'Data\\TaiLieu\\lap-trinh-csharp-can-ban.pdf', N'NoiBo', CAST(GETDATE() AS DATE)),
((SELECT ma_phan_loai FROM dbo.phan_loai_tai_lieu WHERE ky_hieu = N'CNTT'), N'TL002', N'Cơ sở dữ liệu SQL Server', N'Mai Quốc Huy', N'NXB Khoa Học', 2022, N'SachIn', N'Tài liệu về SQL Server', NULL, N'CongKhai', CAST(GETDATE() AS DATE)),
((SELECT ma_phan_loai FROM dbo.phan_loai_tai_lieu WHERE ky_hieu = N'KT'), N'TL003', N'Nguyên lý kế toán', N'Hồ Minh Sang', N'NXB Tài Chính', 2021, N'TaiLieuSo', N'Giáo trình kế toán', N'Data\\TaiLieu\\nguyen-ly-ke-toan.pdf', N'NoiBo', CAST(GETDATE() AS DATE));
GO

INSERT INTO dbo.ban_sao_tai_lieu (ma_tai_lieu, ma_vach, vi_tri_kho, trang_thai, ngay_nhap_kho, ghi_chu)
VALUES
((SELECT ma_tai_lieu FROM dbo.tai_lieu WHERE ma_doc = N'TL001'), N'BAR001', N'Kệ A1', N'Con', CAST(GETDATE() AS DATE), N'Bản in mới'),
((SELECT ma_tai_lieu FROM dbo.tai_lieu WHERE ma_doc = N'TL001'), N'BAR002', N'Kệ A2', N'DangMuon', CAST(GETDATE() AS DATE), N'Đang cho mượn'),
((SELECT ma_tai_lieu FROM dbo.tai_lieu WHERE ma_doc = N'TL002'), N'BAR003', N'Kệ B1', N'Con', CAST(GETDATE() AS DATE), N'Sẵn sàng phục vụ'),
((SELECT ma_tai_lieu FROM dbo.tai_lieu WHERE ma_doc = N'TL003'), N'BAR004', N'Kệ C1', N'Con', CAST(GETDATE() AS DATE), N'Tài liệu số tham khảo');
GO

INSERT INTO dbo.phieu_muon_tra (ma_ban_doc, ma_ban_sao, ngay_muon, han_tra, ngay_tra, trang_thai_phieu, tien_phat, ghi_chu)
VALUES
((SELECT ma_ban_doc FROM dbo.ban_doc WHERE ma_the = N'THE001'),
 (SELECT ma_ban_sao FROM dbo.ban_sao_tai_lieu WHERE ma_vach = N'BAR002'),
 DATEADD(DAY, -2, CAST(GETDATE() AS DATE)), DATEADD(DAY, 12, CAST(GETDATE() AS DATE)), NULL, N'DangMuon', 0, N'Phiếu mượn mẫu');
GO
