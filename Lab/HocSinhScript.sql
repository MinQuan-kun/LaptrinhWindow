CREATE TABLE Lop(
	MaLop varchar(20) NOT NULL PRIMARY KEY,
	TenLop nvarchar(100) NOT NULL,
	SiSo smallint NULL
)
GO

INSERT Lop (MaLop, TenLop, SiSo) VALUES (N'10A1', N'Lớp 10A1', 30)
INSERT Lop (MaLop, TenLop, SiSo) VALUES (N'10A2', N'Lớp 10A2', 25)
INSERT Lop (MaLop, TenLop, SiSo) VALUES (N'10A3', N'Mười A ba', 22)
GO

CREATE PROCEDURE spThem 
	-- Add the parameters for the stored procedure here
	@Ma  VARCHAR(20),
	@Ten NVARCHAR(100),
	@SiSo SMALLINT
AS
BEGIN
	INSERT INTO Lop(MaLop,TenLop,SiSo)
	VALUES(@Ma,@Ten,@SiSo)
END
GO

CREATE TABLE HocSinh(
	MaHS varchar(20) NOT NULL PRIMARY KEY,
	TenHS nvarchar(100) NOT NULL,
	NgaySinh datetime NULL,
	DiaChi nvarchar(150) NULL,
	DTB real NULL,
	MaLop varchar(20) NULL
)
GO

INSERT HocSinh (MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop) VALUES (N'HS0001', N'Nguyễn Thanh Tùng', CAST(0x000087B300000000 AS DateTime), N'123 Ký Con, Q12', 7.77, N'10A1')
INSERT HocSinh (MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop) VALUES (N'HS0002', N'Lê Thanh Thủy', CAST(0x000087BF00000000 AS DateTime), N'456 Lê Lợi, Q1', 6.66, N'10A1')
INSERT HocSinh (MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop) VALUES (N'HS0003', N'Trần Ngọc Thanh', CAST(0x0000808501585920 AS DateTime), N'222 Lê Văn Sỹ, Quận 3, TpHCM', 8.77, N'10A1')
INSERT HocSinh (MaHS, TenHS, NgaySinh, DiaChi, DTB, MaLop) VALUES (N'HS0004', N'Lương Ngọc Hân', CAST(0x00009EEF0148FD99 AS DateTime), N'175/1 Nguyễn Huỳnh Đức, P.Khánh Hậu, Tp Tân An, Long An', 9.87, N'10A1')
GO

ALTER TABLE HocSinh  WITH CHECK ADD  CONSTRAINT FK_HocSinh_Lop FOREIGN KEY(MaLop)
REFERENCES Lop (MaLop)
GO