USE ql_thu_vien_sunrise;
GO

INSERT INTO dbo.vai_tro (ten_vai_tro, mo_ta)
SELECT N'BanDoc', N'Người dùng thư viện'
UNION ALL SELECT N'NhanVien', N'Nhân viên thư viện'
UNION ALL SELECT N'QuanTriVien', N'Quản trị hệ thống';
GO

INSERT INTO dbo.tai_khoan (ma_vai_tro, ten_dang_nhap, mat_khau, email, trang_thai)
SELECT vt.ma_vai_tro, N'nv01', N'123', N'nv01@sunrise.local', N'HoatDong'
FROM dbo.vai_tro vt WHERE vt.ten_vai_tro = N'NhanVien'
UNION ALL
SELECT vt.ma_vai_tro, N'admin', N'123', N'admin@sunrise.local', N'HoatDong'
FROM dbo.vai_tro vt WHERE vt.ten_vai_tro = N'QuanTriVien'
UNION ALL
SELECT vt.ma_vai_tro, N'bd01', N'123', N'bd01@sunrise.local', N'HoatDong'
FROM dbo.vai_tro vt WHERE vt.ten_vai_tro = N'BanDoc'
UNION ALL
SELECT vt.ma_vai_tro, N'bd02', N'123', N'bd02@sunrise.local', N'HoatDong'
FROM dbo.vai_tro vt WHERE vt.ten_vai_tro = N'BanDoc'
UNION ALL
SELECT vt.ma_vai_tro, N'bd03', N'123', N'bd03@sunrise.local', N'HoatDong'
FROM dbo.vai_tro vt WHERE vt.ten_vai_tro = N'BanDoc';
GO

IF COL_LENGTH('dbo.ban_doc', 'mssv') IS NOT NULL
   AND COL_LENGTH('dbo.ban_doc', 'khoa') IS NOT NULL
   AND COL_LENGTH('dbo.ban_doc', 'lop') IS NOT NULL
BEGIN
    INSERT INTO dbo.ban_doc
    (
        ma_tai_khoan, ma_the, ho_ten, ngay_sinh, gioi_tinh,
        so_dien_thoai, dia_chi, loai_ban_doc,
        ngay_cap_the, ngay_het_han, trang_thai_the,
        mssv, khoa, lop
    )
    SELECT tk.ma_tai_khoan, N'THE001', N'Nguyễn Văn A', '2004-05-10', N'Nam',
           N'0909123456', N'TP.HCM', N'SinhVien',
           CAST(GETDATE() AS DATE), DATEADD(YEAR, 1, CAST(GETDATE() AS DATE)), N'HoatDong',
           N'SV2024000', N'Công nghệ thông tin', N'DH21IT01'
    FROM dbo.tai_khoan tk WHERE tk.ten_dang_nhap = N'bd01'
    UNION ALL
    SELECT tk.ma_tai_khoan, N'THE002', N'Trần Thị B', '2003-11-20', N'Nữ',
           N'0909000002', N'Đồng Nai', N'SinhVien',
           CAST(GETDATE() AS DATE), DATEADD(YEAR, 1, CAST(GETDATE() AS DATE)), N'HoatDong',
           N'SV2024002', N'Kế toán', N'DH24KT01'
    FROM dbo.tai_khoan tk WHERE tk.ten_dang_nhap = N'bd02'
    UNION ALL
    SELECT tk.ma_tai_khoan, N'THE003', N'Lê Minh C', '2002-01-15', N'Nam',
           N'0909000003', N'Bình Dương', N'SinhVien',
           CAST(GETDATE() AS DATE), DATEADD(YEAR, 1, CAST(GETDATE() AS DATE)), N'HoatDong',
           N'SV2024003', N'Quản trị kinh doanh', N'DH24QTKD01'
    FROM dbo.tai_khoan tk WHERE tk.ten_dang_nhap = N'bd03';
END
ELSE
BEGIN
    INSERT INTO dbo.ban_doc
    (
        ma_tai_khoan, ma_the, ho_ten, ngay_sinh, gioi_tinh,
        so_dien_thoai, dia_chi, loai_ban_doc,
        ngay_cap_the, ngay_het_han, trang_thai_the
    )
    SELECT tk.ma_tai_khoan, N'THE001', N'Nguyễn Văn A', '2004-05-10', N'Nam',
           N'0909123456', N'TP.HCM', N'SinhVien',
           CAST(GETDATE() AS DATE), DATEADD(YEAR, 1, CAST(GETDATE() AS DATE)), N'HoatDong'
    FROM dbo.tai_khoan tk WHERE tk.ten_dang_nhap = N'bd01'
    UNION ALL
    SELECT tk.ma_tai_khoan, N'THE002', N'Trần Thị B', '2003-11-20', N'Nữ',
           N'0909000002', N'Đồng Nai', N'SinhVien',
           CAST(GETDATE() AS DATE), DATEADD(YEAR, 1, CAST(GETDATE() AS DATE)), N'HoatDong'
    FROM dbo.tai_khoan tk WHERE tk.ten_dang_nhap = N'bd02'
    UNION ALL
    SELECT tk.ma_tai_khoan, N'THE003', N'Lê Minh C', '2002-01-15', N'Nam',
           N'0909000003', N'Bình Dương', N'SinhVien',
           CAST(GETDATE() AS DATE), DATEADD(YEAR, 1, CAST(GETDATE() AS DATE)), N'HoatDong'
    FROM dbo.tai_khoan tk WHERE tk.ten_dang_nhap = N'bd03';
END
GO

IF OBJECT_ID('dbo.sinh_vien_cho_cap_the', 'U') IS NOT NULL
BEGIN
    INSERT INTO dbo.sinh_vien_cho_cap_the
    (
        mssv, ho_ten, khoa, lop, ngay_sinh, email, so_dien_thoai,
        trang_thai_dong_bo, da_cap_the
    )
    VALUES
    (N'SV2024001', N'Lê Minh Anh', N'Công nghệ thông tin', N'DH24IT01', '2006-01-15', N'sv2024001@sunrise.local', N'0911111111', N'ChuaNhan', 0),
    (N'SV2024002', N'Phạm Quốc Bảo', N'Kế toán', N'DH24KT01', '2006-03-18', N'sv2024002@sunrise.local', N'0922222222', N'ChuaNhan', 0),
    (N'SV2024003', N'Trần Gia Hân', N'Quản trị kinh doanh', N'DH24QTKD01', '2006-07-21', N'sv2024003@sunrise.local', N'0933333333', N'DaNhan', 0);
END
GO

INSERT INTO dbo.phan_loai_tai_lieu (ten_phan_loai, ky_hieu, mo_ta, tu_khoa)
SELECT N'Công nghệ thông tin', N'CNTT', N'Sách ngành CNTT', N'lập trình,cơ sở dữ liệu,phần mềm'
UNION ALL SELECT N'Kinh tế', N'KT', N'Sách ngành kinh tế', N'kinh tế,quản trị,tài chính'
UNION ALL SELECT N'Văn học', N'VH', N'Sách văn học', N'tiểu thuyết,truyện,ngôn ngữ';
GO

IF COL_LENGTH('dbo.tai_lieu', 'the_loai') IS NOT NULL
   AND COL_LENGTH('dbo.tai_lieu', 'dinh_dang') IS NOT NULL
   AND COL_LENGTH('dbo.tai_lieu', 'hien_thi_tra_cuu') IS NOT NULL
BEGIN
    INSERT INTO dbo.tai_lieu
    (
        ma_phan_loai, ma_doc, ten_tai_lieu, tac_gia, nha_xuat_ban, nam_xuat_ban,
        loai_tai_lieu, the_loai, dinh_dang, mo_ta, duong_dan_file,
        quyen_truy_cap, ngay_nhap, hien_thi_tra_cuu
    )
    SELECT pl.ma_phan_loai, N'TL001', N'Lập trình C# căn bản', N'Trần Minh Quân',
           N'NXB Giáo Dục', 2023, N'SachIn', N'Giáo trình', N'PDF',
           N'Sách cơ bản về C#', N'Data\TaiLieu\lap-trinh-csharp-can-ban.pdf',
           N'NoiBo', CAST(GETDATE() AS DATE), 1
    FROM dbo.phan_loai_tai_lieu pl WHERE pl.ky_hieu = N'CNTT'
    UNION ALL
    SELECT pl.ma_phan_loai, N'TL002', N'Cơ sở dữ liệu SQL Server', N'Mai Quốc Huy',
           N'NXB Khoa Học', 2022, N'SachIn', N'Giáo trình', N'PDF',
           N'Tài liệu về SQL Server', NULL,
           N'CongKhai', CAST(GETDATE() AS DATE), 1
    FROM dbo.phan_loai_tai_lieu pl WHERE pl.ky_hieu = N'CNTT'
    UNION ALL
    SELECT pl.ma_phan_loai, N'TL003', N'Nguyên lý kế toán', N'Hồ Minh Sang',
           N'NXB Tài Chính', 2021, N'TaiLieuSo', N'Giáo trình', N'PDF',
           N'Giáo trình kế toán', N'Data\TaiLieu\nguyen-ly-ke-toan.pdf',
           N'NoiBo', CAST(GETDATE() AS DATE), 1
    FROM dbo.phan_loai_tai_lieu pl WHERE pl.ky_hieu = N'KT'
    UNION ALL
    SELECT pl.ma_phan_loai, N'TL004', N'Dế Mèn phiêu lưu ký', N'Tô Hoài',
           N'NXB Kim Đồng', 2020, N'SachIn', N'Truyện', N'In',
           N'Tác phẩm văn học thiếu nhi', NULL,
           N'CongKhai', CAST(GETDATE() AS DATE), 1
    FROM dbo.phan_loai_tai_lieu pl WHERE pl.ky_hieu = N'VH';
END
ELSE
BEGIN
    INSERT INTO dbo.tai_lieu
    (
        ma_phan_loai, ma_doc, ten_tai_lieu, tac_gia, nha_xuat_ban, nam_xuat_ban,
        loai_tai_lieu, mo_ta, duong_dan_file, quyen_truy_cap, ngay_nhap
    )
    SELECT pl.ma_phan_loai, N'TL001', N'Lập trình C# căn bản', N'Trần Minh Quân',
           N'NXB Giáo Dục', 2023, N'SachIn',
           N'Sách cơ bản về C#', N'Data\TaiLieu\lap-trinh-csharp-can-ban.pdf',
           N'NoiBo', CAST(GETDATE() AS DATE)
    FROM dbo.phan_loai_tai_lieu pl WHERE pl.ky_hieu = N'CNTT'
    UNION ALL
    SELECT pl.ma_phan_loai, N'TL002', N'Cơ sở dữ liệu SQL Server', N'Mai Quốc Huy',
           N'NXB Khoa Học', 2022, N'SachIn',
           N'Tài liệu về SQL Server', NULL,
           N'CongKhai', CAST(GETDATE() AS DATE)
    FROM dbo.phan_loai_tai_lieu pl WHERE pl.ky_hieu = N'CNTT'
    UNION ALL
    SELECT pl.ma_phan_loai, N'TL003', N'Nguyên lý kế toán', N'Hồ Minh Sang',
           N'NXB Tài Chính', 2021, N'TaiLieuSo',
           N'Giáo trình kế toán', N'Data\TaiLieu\nguyen-ly-ke-toan.pdf',
           N'NoiBo', CAST(GETDATE() AS DATE)
    FROM dbo.phan_loai_tai_lieu pl WHERE pl.ky_hieu = N'KT'
    UNION ALL
    SELECT pl.ma_phan_loai, N'TL004', N'Dế Mèn phiêu lưu ký', N'Tô Hoài',
           N'NXB Kim Đồng', 2020, N'SachIn',
           N'Tác phẩm văn học thiếu nhi', NULL,
           N'CongKhai', CAST(GETDATE() AS DATE)
    FROM dbo.phan_loai_tai_lieu pl WHERE pl.ky_hieu = N'VH';
END
GO

INSERT INTO dbo.ban_sao_tai_lieu
(
    ma_tai_lieu, ma_vach, vi_tri_kho, trang_thai, ngay_nhap_kho, ghi_chu
)
SELECT tl.ma_tai_lieu, N'BAR001', N'Kệ A1', N'Con', CAST(GETDATE() AS DATE), N'Bản in mới'
FROM dbo.tai_lieu tl WHERE tl.ma_doc = N'TL001'
UNION ALL
SELECT tl.ma_tai_lieu, N'BAR002', N'Kệ A2', N'DangMuon', CAST(GETDATE() AS DATE), N'Đang cho mượn'
FROM dbo.tai_lieu tl WHERE tl.ma_doc = N'TL001'
UNION ALL
SELECT tl.ma_tai_lieu, N'BAR003', N'Kệ B1', N'Con', CAST(GETDATE() AS DATE), N'Sẵn sàng phục vụ'
FROM dbo.tai_lieu tl WHERE tl.ma_doc = N'TL002'
UNION ALL
SELECT tl.ma_tai_lieu, N'BAR004', N'Kệ C1', N'Con', CAST(GETDATE() AS DATE), N'Tài liệu số tham khảo'
FROM dbo.tai_lieu tl WHERE tl.ma_doc = N'TL003'
UNION ALL
SELECT tl.ma_tai_lieu, N'BAR005', N'Kệ D1', N'Con', CAST(GETDATE() AS DATE), N'Sách văn học'
FROM dbo.tai_lieu tl WHERE tl.ma_doc = N'TL004';
GO

INSERT INTO dbo.phieu_muon_tra
(
    ma_ban_doc, ma_ban_sao, ngay_muon, han_tra, ngay_tra, trang_thai_phieu, tien_phat, ghi_chu
)
SELECT bd.ma_ban_doc, bs.ma_ban_sao,
       DATEADD(DAY,-25,CAST(GETDATE() AS DATE)),
       DATEADD(DAY,-11,CAST(GETDATE() AS DATE)),
       NULL, N'DangMuon', 0, N'Phiếu mượn mẫu'
FROM dbo.ban_doc bd
JOIN dbo.ban_sao_tai_lieu bs ON bs.ma_vach = N'BAR002'
WHERE bd.ma_the = N'THE001'
UNION ALL
SELECT bd.ma_ban_doc, bs.ma_ban_sao,
       DATEADD(DAY,-40,CAST(GETDATE() AS DATE)),
       DATEADD(DAY,-26,CAST(GETDATE() AS DATE)),
       DATEADD(DAY,-28,CAST(GETDATE() AS DATE)),
       N'DaTra', 0, N'Đã trả'
FROM dbo.ban_doc bd
JOIN dbo.ban_sao_tai_lieu bs ON bs.ma_vach = N'BAR003'
WHERE bd.ma_the = N'THE001'
UNION ALL
SELECT bd.ma_ban_doc, bs.ma_ban_sao,
       DATEADD(DAY,-15,CAST(GETDATE() AS DATE)),
       DATEADD(DAY,-1,CAST(GETDATE() AS DATE)),
       DATEADD(DAY,-2,CAST(GETDATE() AS DATE)),
       N'DaTra', 0, N'Đã trả'
FROM dbo.ban_doc bd
JOIN dbo.ban_sao_tai_lieu bs ON bs.ma_vach = N'BAR001'
WHERE bd.ma_the = N'THE002'
UNION ALL
SELECT bd.ma_ban_doc, bs.ma_ban_sao,
       DATEADD(DAY,-10,CAST(GETDATE() AS DATE)),
       DATEADD(DAY,4,CAST(GETDATE() AS DATE)),
       NULL, N'DangMuon', 0, N'Đang mượn'
FROM dbo.ban_doc bd
JOIN dbo.ban_sao_tai_lieu bs ON bs.ma_vach = N'BAR005'
WHERE bd.ma_the = N'THE002'
UNION ALL
SELECT bd.ma_ban_doc, bs.ma_ban_sao,
       DATEADD(DAY,-8,CAST(GETDATE() AS DATE)),
       DATEADD(DAY,6,CAST(GETDATE() AS DATE)),
       NULL, N'DangMuon', 0, N'Đang mượn'
FROM dbo.ban_doc bd
JOIN dbo.ban_sao_tai_lieu bs ON bs.ma_vach = N'BAR003'
WHERE bd.ma_the = N'THE003'
UNION ALL
SELECT bd.ma_ban_doc, bs.ma_ban_sao,
       DATEADD(DAY,-60,CAST(GETDATE() AS DATE)),
       DATEADD(DAY,-46,CAST(GETDATE() AS DATE)),
       DATEADD(DAY,-45,CAST(GETDATE() AS DATE)),
       N'DaTra', 0, N'Đã trả'
FROM dbo.ban_doc bd
JOIN dbo.ban_sao_tai_lieu bs ON bs.ma_vach = N'BAR005'
WHERE bd.ma_the = N'THE003';
GO

IF OBJECT_ID('dbo.phan_quyen_tai_khoan', 'U') IS NOT NULL
BEGIN
    INSERT INTO dbo.phan_quyen_tai_khoan
    (
        ma_tai_khoan, xem_du_lieu, them_sua_xoa, quan_ly_tai_khoan, xem_bao_cao
    )
    SELECT tk.ma_tai_khoan,
           1,
           CASE WHEN vt.ten_vai_tro IN (N'NhanVien', N'QuanTriVien') THEN 1 ELSE 0 END,
           CASE WHEN vt.ten_vai_tro = N'QuanTriVien' THEN 1 ELSE 0 END,
           CASE WHEN vt.ten_vai_tro IN (N'NhanVien', N'QuanTriVien') THEN 1 ELSE 0 END
    FROM dbo.tai_khoan tk
    JOIN dbo.vai_tro vt ON tk.ma_vai_tro = vt.ma_vai_tro;
END
GO