USE [QLBanHangDG]
GO
/****** Object:  Table [dbo].[CTHoaDon]    Script Date: 9/25/2017 10:31:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDon](
	[MaHD] [int] NOT NULL,
	[MaHH] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CTHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 9/25/2017 10:31:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHH] [int] IDENTITY(1,1) NOT NULL,
	[TenHH] [nvarchar](50) NOT NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[DonGia] [float] NOT NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 9/25/2017 10:31:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayLapHD] [datetime] NULL,
	[KhachHang] [nvarchar](50) NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CTHoaDon] ([MaHD], [MaHH], [SoLuong]) VALUES (1, 1, 6)
INSERT [dbo].[CTHoaDon] ([MaHD], [MaHH], [SoLuong]) VALUES (1, 3, 5)
INSERT [dbo].[CTHoaDon] ([MaHD], [MaHH], [SoLuong]) VALUES (1, 4, 3)
INSERT [dbo].[CTHoaDon] ([MaHD], [MaHH], [SoLuong]) VALUES (2, 4, 3)
INSERT [dbo].[CTHoaDon] ([MaHD], [MaHH], [SoLuong]) VALUES (2, 5, 1)
INSERT [dbo].[CTHoaDon] ([MaHD], [MaHH], [SoLuong]) VALUES (3, 4, 5)
INSERT [dbo].[CTHoaDon] ([MaHD], [MaHH], [SoLuong]) VALUES (3, 5, 2)
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [DonViTinh], [DonGia]) VALUES (1, N'Bánh mì', N'Ổ', 15000)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [DonViTinh], [DonGia]) VALUES (2, N'Hủ tiếu', N'Tô', 22000)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [DonViTinh], [DonGia]) VALUES (3, N'Phở', N'Tô', 25000)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [DonViTinh], [DonGia]) VALUES (4, N'Bia 333', N'Thùng', 231000)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [DonViTinh], [DonGia]) VALUES (5, N'7up Revie', N'Chai', 7500)
INSERT [dbo].[HangHoa] ([MaHH], [TenHH], [DonViTinh], [DonGia]) VALUES (6, N'Coca-Cala', N'Chai', 5900)
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [KhachHang], [TongTien]) VALUES (1, CAST(N'2015-05-11 16:58:43.853' AS DateTime), N'Nguyễn Thanh Thủy', 908000)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [KhachHang], [TongTien]) VALUES (2, CAST(N'2015-12-03 16:30:02.213' AS DateTime), N'Tèo', 700500)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLapHD], [KhachHang], [TongTien]) VALUES (3, CAST(N'2015-12-03 16:37:47.910' AS DateTime), N'Gái', 1170000)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_HangHoa]
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_HoaDon]
GO
