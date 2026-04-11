IF DB_ID(N'ql_thu_vien_sunrise') IS NULL
BEGIN
    CREATE DATABASE ql_thu_vien_sunrise;
END
GO

USE ql_thu_vien_sunrise;
GO

IF OBJECT_ID(N'dbo.phieu_muon_tra', N'U') IS NOT NULL DROP TABLE dbo.phieu_muon_tra;
IF OBJECT_ID(N'dbo.ban_sao_tai_lieu', N'U') IS NOT NULL DROP TABLE dbo.ban_sao_tai_lieu;
IF OBJECT_ID(N'dbo.tai_lieu', N'U') IS NOT NULL DROP TABLE dbo.tai_lieu;
IF OBJECT_ID(N'dbo.phan_loai_tai_lieu', N'U') IS NOT NULL DROP TABLE dbo.phan_loai_tai_lieu;
IF OBJECT_ID(N'dbo.ban_doc', N'U') IS NOT NULL DROP TABLE dbo.ban_doc;
IF OBJECT_ID(N'dbo.tai_khoan', N'U') IS NOT NULL DROP TABLE dbo.tai_khoan;
IF OBJECT_ID(N'dbo.vai_tro', N'U') IS NOT NULL DROP TABLE dbo.vai_tro;
GO

CREATE TABLE dbo.vai_tro (
    ma_vai_tro INT IDENTITY(1,1) PRIMARY KEY,
    ten_vai_tro NVARCHAR(50) NOT NULL UNIQUE,
    mo_ta NVARCHAR(255) NULL
);
GO

CREATE TABLE dbo.tai_khoan (
    ma_tai_khoan INT IDENTITY(1,1) PRIMARY KEY,
    ma_vai_tro INT NOT NULL,
    ten_dang_nhap NVARCHAR(50) NOT NULL UNIQUE,
    mat_khau NVARCHAR(255) NOT NULL,
    email NVARCHAR(100) NULL UNIQUE,
    trang_thai NVARCHAR(20) NOT NULL DEFAULT N'HoatDong',
    ngay_tao DATETIME NOT NULL DEFAULT GETDATE(),
    lan_dang_nhap_cuoi DATETIME NULL,
    CONSTRAINT FK_tai_khoan_vai_tro FOREIGN KEY (ma_vai_tro)
        REFERENCES dbo.vai_tro(ma_vai_tro)
);
GO

CREATE TABLE dbo.ban_doc (
    ma_ban_doc INT IDENTITY(1,1) PRIMARY KEY,
    ma_tai_khoan INT NOT NULL UNIQUE,
    ma_the NVARCHAR(30) NOT NULL UNIQUE,
    ho_ten NVARCHAR(100) NOT NULL,
    ngay_sinh DATE NULL,
    gioi_tinh NVARCHAR(15) NULL,
    so_dien_thoai NVARCHAR(15) NULL,
    dia_chi NVARCHAR(255) NULL,
    loai_ban_doc NVARCHAR(20) NOT NULL,
    ngay_cap_the DATE NULL,
    ngay_het_han DATE NULL,
    trang_thai_the NVARCHAR(20) NOT NULL DEFAULT N'HoatDong',
    CONSTRAINT FK_ban_doc_tai_khoan FOREIGN KEY (ma_tai_khoan)
        REFERENCES dbo.tai_khoan(ma_tai_khoan)
);
GO

CREATE TABLE dbo.phan_loai_tai_lieu (
    ma_phan_loai INT IDENTITY(1,1) PRIMARY KEY,
    ten_phan_loai NVARCHAR(100) NOT NULL,
    ky_hieu NVARCHAR(30) NULL UNIQUE,
    mo_ta NVARCHAR(255) NULL,
    tu_khoa NVARCHAR(255) NULL
);
GO

CREATE TABLE dbo.tai_lieu (
    ma_tai_lieu INT IDENTITY(1,1) PRIMARY KEY,
    ma_phan_loai INT NOT NULL,
    ma_doc NVARCHAR(30) NOT NULL UNIQUE,
    ten_tai_lieu NVARCHAR(200) NOT NULL,
    tac_gia NVARCHAR(200) NOT NULL,
    nha_xuat_ban NVARCHAR(200) NULL,
    nam_xuat_ban INT NULL,
    loai_tai_lieu NVARCHAR(50) NOT NULL,
    mo_ta NVARCHAR(255) NULL,
    duong_dan_file NVARCHAR(255) NULL,
    quyen_truy_cap NVARCHAR(20) NOT NULL DEFAULT N'CongKhai',
    ngay_nhap DATE NULL,
    CONSTRAINT FK_tai_lieu_phan_loai FOREIGN KEY (ma_phan_loai)
        REFERENCES dbo.phan_loai_tai_lieu(ma_phan_loai)
);
GO

CREATE TABLE dbo.ban_sao_tai_lieu (
    ma_ban_sao INT IDENTITY(1,1) PRIMARY KEY,
    ma_tai_lieu INT NOT NULL,
    ma_vach NVARCHAR(50) NOT NULL UNIQUE,
    vi_tri_kho NVARCHAR(100) NOT NULL,
    trang_thai NVARCHAR(20) NOT NULL DEFAULT N'Con',
    ngay_nhap_kho DATE NULL,
    ghi_chu NVARCHAR(255) NULL,
    CONSTRAINT FK_ban_sao_tai_lieu FOREIGN KEY (ma_tai_lieu)
        REFERENCES dbo.tai_lieu(ma_tai_lieu)
);
GO

CREATE TABLE dbo.phieu_muon_tra (
    ma_phieu INT IDENTITY(1,1) PRIMARY KEY,
    ma_ban_doc INT NOT NULL,
    ma_ban_sao INT NOT NULL,
    ngay_muon DATE NOT NULL,
    han_tra DATE NOT NULL,
    ngay_tra DATE NULL,
    trang_thai_phieu NVARCHAR(20) NOT NULL DEFAULT N'DangMuon',
    tien_phat DECIMAL(10,2) NOT NULL DEFAULT 0,
    ghi_chu NVARCHAR(255) NULL,
    CONSTRAINT FK_phieu_muon_tra_ban_doc FOREIGN KEY (ma_ban_doc)
        REFERENCES dbo.ban_doc(ma_ban_doc),
    CONSTRAINT FK_phieu_muon_tra_ban_sao FOREIGN KEY (ma_ban_sao)
        REFERENCES dbo.ban_sao_tai_lieu(ma_ban_sao)
);
GO

CREATE INDEX IX_tai_khoan_ma_vai_tro ON dbo.tai_khoan(ma_vai_tro);
CREATE INDEX IX_tai_lieu_ma_phan_loai ON dbo.tai_lieu(ma_phan_loai);
CREATE INDEX IX_tai_lieu_ten ON dbo.tai_lieu(ten_tai_lieu);
CREATE INDEX IX_tai_lieu_tac_gia ON dbo.tai_lieu(tac_gia);
CREATE INDEX IX_ban_sao_ma_tai_lieu ON dbo.ban_sao_tai_lieu(ma_tai_lieu);
CREATE INDEX IX_phieu_muon_tra_ma_ban_doc ON dbo.phieu_muon_tra(ma_ban_doc);
CREATE INDEX IX_phieu_muon_tra_ma_ban_sao ON dbo.phieu_muon_tra(ma_ban_sao);
CREATE INDEX IX_phieu_muon_tra_ngay_muon ON dbo.phieu_muon_tra(ngay_muon);
CREATE INDEX IX_phieu_muon_tra_trang_thai ON dbo.phieu_muon_tra(trang_thai_phieu);
GO
