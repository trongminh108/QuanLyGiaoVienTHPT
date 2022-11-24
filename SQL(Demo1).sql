CREATE DATABASE QLGV
go

-- Bang 1: Giao Vien
CREATE TABLE GiaoVien
(
	MaGV char(4),
	HoTen nvarchar(30),
	NamSinh date,
	MaMon char(3),
	GioiTinh nvarchar(3),
	Luong int,
	MaTruongBM varchar(4),
	SDT char(10),
	email varchar(50),

	primary key (MaGV)
)

-- Bang 2: Loai Giao Vien
CREATE TABLE LoaiGV
(
	MaGV char(4),
	Loai nvarchar(20),

	primary key (MaGV)
)

-- Bang 3: He so luong
CREATE TABLE HeSoLuong
(
	LoaiGV nvarchar(20),
	HeSoLuong float,

	primary key (LoaiGV)
)

-- Bang 4: Bo Mon
CREATE TABLE BoMon
(
	MaBM char(3),
	TenBM varchar(10),

	primary key (MaBM)
)

-- Bang 5: Lop
CREATE TABLE Lop
(
	MaLop char(5),
	MaCN char(4),
	Loai nvarchar(10),

	primary key (MaLop)
)

-- Bang 6: 
CREATE TABLE GiangDay
(
	MaGV char(4),
	MaLop char(5),
	NgayNhanLop date,

	primary key (MaGV, MaLop)
)

INSERT INTO BoMon VALUES 
('MAT', 'Toán'),
	('PHY', 'Lý'),
	('CHE', 'Hóa'),
	('LEC', 'Văn'),
	('ENG', 'Anh')

INSERT INTO GiaoVien 
	VALUES('M001', 'Luu Minh Trong', '08/01/2002','MAT', 'Nam', '1000', null, '0772104719', 'lmtrong.ctc2020@gmail.com');

INSERT INTO GiaoVien 
	VALUES('M002', 'Luu Minh Trong', '18/12/2002','MAT', 'Nam', '1000', null, '0772104719', 'lmtrong.ctc2020@gmail.com');

INSERT INTO GiaoVien 
	VALUES('L002', 'Luu Kim Minh', '12/12/2002','LEC', N'Nữ', '1000', null, '0682108619', 'lmtrong.ctc2020@gmail.com');

SELECT * FROM GiaoVien

SELECT * FROM BoMon


