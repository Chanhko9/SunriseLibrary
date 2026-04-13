USE ql_thu_vien_sunrise;
GO

IF COL_LENGTH('dbo.ban_doc', 'mssv') IS NULL
    ALTER TABLE dbo.ban_doc ADD mssv NVARCHAR(20) NULL;
GO
IF COL_LENGTH('dbo.ban_doc', 'khoa') IS NULL
    ALTER TABLE dbo.ban_doc ADD khoa NVARCHAR(100) NULL;
GO
IF COL_LENGTH('dbo.ban_doc', 'lop') IS NULL
    ALTER TABLE dbo.ban_doc ADD lop NVARCHAR(50) NULL;
GO

IF OBJECT_ID(N'dbo.sinh_vien_cho_cap_the', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.sinh_vien_cho_cap_the (
        ma_sinh_vien_cho INT IDENTITY(1,1) PRIMARY KEY,
        mssv NVARCHAR(20) NOT NULL UNIQUE,
        ho_ten NVARCHAR(100) NOT NULL,
        khoa NVARCHAR(100) NULL,
        lop NVARCHAR(50) NULL,
        ngay_sinh DATE NULL,
        email NVARCHAR(100) NULL,
        so_dien_thoai NVARCHAR(15) NULL,
        trang_thai_dong_bo NVARCHAR(20) NOT NULL DEFAULT N'ChuaNhan',
        da_cap_the BIT NOT NULL DEFAULT 0,
        ngay_tao DATETIME NOT NULL DEFAULT GETDATE(),
        ngay_cap_nhat DATETIME NULL
    );
END
GO

IF NOT EXISTS (SELECT 1 FROM dbo.sinh_vien_cho_cap_the WHERE mssv = N'SV2024001')
BEGIN
    INSERT INTO dbo.sinh_vien_cho_cap_the (mssv, ho_ten, khoa, lop, ngay_sinh, email, so_dien_thoai, trang_thai_dong_bo, da_cap_the)
    VALUES
    (N'SV2024001', N'Lê Minh Anh', N'Công nghệ thông tin', N'DH24IT01', '2006-01-15', N'sv2024001@sunrise.local', N'0911111111', N'ChuaNhan', 0),
    (N'SV2024002', N'Phạm Quốc Bảo', N'Kế toán', N'DH24KT01', '2006-03-18', N'sv2024002@sunrise.local', N'0922222222', N'ChuaNhan', 0),
    (N'SV2024003', N'Trần Gia Hân', N'Quản trị kinh doanh', N'DH24QTKD01', '2006-07-21', N'sv2024003@sunrise.local', N'0933333333', N'DaNhan', 0);
END
GO
