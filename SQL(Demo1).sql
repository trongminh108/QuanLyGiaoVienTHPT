﻿CREATE DATABASE QLGV
go

USE QLGV
go

-- Bang 1: Giao Vien
CREATE TABLE GiaoVien
(
	MaGiaoVien char(4) NOT NULL,
	HoTen nvarchar(30),
	MaBoMon char(3),
	LoaiGiaoVien nvarchar(10),
	CMND_CCCD nvarchar(12),
	NgaySinh date,
	GioiTinh nvarchar(3),
	SDT char(10),
	Email varchar(50),
	Luong int
)

-- Bang 2: Bo Mon
CREATE TABLE BoMon
(
	MaBoMon char(3) NOT NULL,
	TenBoMon nvarchar(20),
	MaTruongBoMon char(4)
)

-- Bang 3: Loai Giao Vien
CREATE TABLE LoaiGiaoVien
(
	LoaiGiaoVien nvarchar(10) NOT NULL,
	HSL float,
	LuongCanBan int,
)

-- Bang 4: Lop
CREATE TABLE Lop
(
	MaLop char(5) NOT NULL,
	MaChuNhiem char(4)
)

-- Bang 5: Giang Day
CREATE TABLE GiangDay
(
	MaGiaoVien char(4) NOT NULL,
	MaLop char(5) NOT NULL,
	NgayNhanLop date
)

-- Bang 6:
CREATE TABLE TaiKhoan (
    TenTaiKhoan VARCHAR (20)    NOT NULL,
    MatKhau     VARCHAR (20)    NOT NULL,
    email       VARCHAR (50) NOT NULL,
    PRIMARY KEY (TenTaiKhoan ASC)
);
go

-- Thêm khóa chính
ALTER TABLE GiaoVien ADD CONSTRAINT pk_GiaoVien PRIMARY KEY (MaGiaoVien);
ALTER TABLE BoMon ADD CONSTRAINT pk_BoMon PRIMARY KEY (MaBoMon);
ALTER TABLE LoaiGiaoVien ADD CONSTRAINT pk_LoaiGiaoVien PRIMARY KEY (LoaiGiaoVien);
ALTER TABLE Lop ADD CONSTRAINT pk_Lop PRIMARY KEY (MaLop);
ALTER TABLE GiangDay ADD CONSTRAINT pk_GiangDay PRIMARY KEY (MaGiaoVien, MaLop);
GO

--  Thêm khóa ngoại
ALTER TABLE GiaoVien ADD CONSTRAINT fk_GiaoVien_BoMon FOREIGN KEY (MaBoMon) REFERENCES BoMon(MaBoMon);
ALTER TABLE GiaoVien ADD CONSTRAINT fk_GiaoVien_LoaiGiaoVien FOREIGN KEY (LoaiGiaoVien) REFERENCES LoaiGiaoVien(LoaiGiaoVien);
ALTER TABLE GiangDay ADD CONSTRAINT fk_GiangDay_GiaoVien FOREIGN KEY (MaGiaoVien) REFERENCES GiaoVien(MaGiaoVien);
ALTER TABLE GiangDay ADD CONSTRAINT fk_GiangDay_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop);
ALTER TABLE Lop ADD CONSTRAINT fk_Lop_GiaoVien FOREIGN KEY (MaChuNhiem) REFERENCES GIAOVIEN(MaGiaoVien);
GO

-- Thêm Bộ Môn
INSERT INTO BoMon VALUES 
	('MAT', N'Toán', 'null'),
	('LIT', N'Ngữ Văn', 'null'),
	('ENG', N'Tiếng Anh', 'null'),
	('HIS', N'Lịch Sử', 'null'),
	('GEO', N'Địa Lý', 'null'),
	('PHY', N'Vật Lý', 'null'),
	('CHE', N'Hóa Học', 'null'),
	('CED', N'Giáo Dục Công Dân', 'null'),
	('ART', N'Mỹ Thuật', 'null'),
	('INF', N'Tin Học', 'null'),
	('TEC', N'Công Nghệ', 'null'),
	('BIO', N'Sinh Học', 'null'),
	('MUS', N'Âm Nhạc', 'null'),
	('PED', N'Thể Dục', 'null')
GO

-- Thêm Loại giáo viên
INSERT INTO LoaiGiaoVien VALUES
	(N'Hạng 1', '4.4', '1490000'),
	(N'Hạng 2', '4.0', '1490000'),
	(N'Hạng 3', '2.34', '1490000');
GO

--Thêm Lớp
INSERT INTO Lop VALUES
	('10C1', null),
	('10C2', null),
	('10C3', null),
	('11C1', null),
	('11C2', null),
	('11C3', null),
	('12C1', null),
	('12C2', null),
	('12C3', null);
GO

-- Thêm giáo viên
INSERT INTO GiaoVien VALUES
	('M001', N'Lưu Minh Trọng', 'MAT', N'Hạng 3', '352715948', '01/08/2002', 'Nam', '0772104719', 'lmtrong.ctc2020@gmail.com', null),
	('C002', N'Lê Quốc Toàn', 'CHE', N'Hạng 1', '123456789', '12/18/2002', 'Nam', '0123987654', 'lqtoan.ctc2020@gmail.com', null),
	('L002', N'Lê Minh Thông', 'LIT', N'Hạng 2', '954678213',  '12/13/2002', 'Nam', '0123987654', 'lmthong.ctc2020@gmail.com', null);
GO

-- Thêm tài khoản admin
INSERT INTO TaiKhoan VALUES
	('admin', '123', 'admin@gmail.com');
GO

--SELECT * FROM GiaoVien
--SELECT * FROM BoMon


