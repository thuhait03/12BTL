USE [master]
GO
/****** Object:  Database [qlida]    Script Date: 6/1/2024 9:10:44 PM ******/
CREATE DATABASE [qlida] ON  PRIMARY 
( NAME = N'qlida', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\qlida.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'qlida_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\qlida_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [qlida] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qlida].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qlida] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qlida] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qlida] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qlida] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qlida] SET ARITHABORT OFF 
GO
ALTER DATABASE [qlida] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [qlida] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qlida] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qlida] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qlida] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qlida] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qlida] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qlida] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qlida] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qlida] SET  DISABLE_BROKER 
GO
ALTER DATABASE [qlida] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qlida] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qlida] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qlida] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qlida] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qlida] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qlida] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qlida] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [qlida] SET  MULTI_USER 
GO
ALTER DATABASE [qlida] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qlida] SET DB_CHAINING OFF 
GO
USE [qlida]
GO
/****** Object:  Table [dbo].[DuAn]    Script Date: 6/1/2024 9:10:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DuAn](
	[IDduan] [int] NOT NULL,
	[Tenduan] [nvarchar](50) NULL,
	[IDnhadautu] [int] NULL,
	[IDlichtrinh] [int] NULL,
	[kinhphi] [int] NULL,
	[IDkhachhang] [int] NULL,
	[IDnhanvien] [int] NULL,
	[IDhopdong] [int] NULL,
 CONSTRAINT [PK_DuAn] PRIMARY KEY CLUSTERED 
(
	[IDduan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hopdong]    Script Date: 6/1/2024 9:10:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hopdong](
	[IDhopdong] [int] NOT NULL,
	[Tenhophopdongduan] [nvarchar](50) NULL,
	[ngaykiket] [datetime] NULL,
	[hieuluc] [nchar](10) NULL,
 CONSTRAINT [PK_Hopdong] PRIMARY KEY CLUSTERED 
(
	[IDhopdong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/1/2024 9:10:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[IDKhachhang] [int] NOT NULL,
	[TenKhachhang] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[SĐT] [varchar](10) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[IDKhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lichtrinh]    Script Date: 6/1/2024 9:10:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lichtrinh](
	[IDlichtrinh] [int] NOT NULL,
	[Tenduan] [nvarchar](50) NULL,
	[ngaybatdau] [datetime] NULL,
	[ngạketthuc] [datetime] NULL,
	[IDthongbao] [int] NULL,
 CONSTRAINT [PK_Lichtrinh] PRIMARY KEY CLUSTERED 
(
	[IDlichtrinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhadautu]    Script Date: 6/1/2024 9:10:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhadautu](
	[IDnhadautu] [int] NOT NULL,
	[Tennhadautu] [nvarchar](50) NULL,
	[Sđt] [varchar](50) NULL,
 CONSTRAINT [PK_Nhadautu] PRIMARY KEY CLUSTERED 
(
	[IDnhadautu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 6/1/2024 9:10:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[IDnhanvien] [int] NOT NULL,
	[tennhanvien] [nvarchar](50) NULL,
	[SĐT] [nchar](50) NULL,
	[IDPhongban] [int] NULL,
 CONSTRAINT [PK_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[IDnhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phongban]    Script Date: 6/1/2024 9:10:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phongban](
	[IDphongban] [int] NOT NULL,
	[manhanvien] [int] NULL,
	[tenphongban] [nchar](50) NULL,
 CONSTRAINT [PK_Phongban] PRIMARY KEY CLUSTERED 
(
	[IDphongban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 6/1/2024 9:10:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[TenTk] [nvarchar](50) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
	[Sđt] [nvarchar](50) NULL,
 CONSTRAINT [PK_Taikhoan] PRIMARY KEY CLUSTERED 
(
	[TenTk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thongbao]    Script Date: 6/1/2024 9:10:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thongbao](
	[IDthongbao] [int] NOT NULL,
	[Tenthongbao] [nvarchar](50) NULL,
	[Ngaythongbao] [datetime] NULL,
 CONSTRAINT [PK_Thongbao] PRIMARY KEY CLUSTERED 
(
	[IDthongbao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DuAn] ([IDduan], [Tenduan], [IDnhadautu], [IDlichtrinh], [kinhphi], [IDkhachhang], [IDnhanvien], [IDhopdong]) VALUES (2002, N'hihi', 4001, 3002, 12334, 1001, 5001, 7001)
INSERT [dbo].[DuAn] ([IDduan], [Tenduan], [IDnhadautu], [IDlichtrinh], [kinhphi], [IDkhachhang], [IDnhanvien], [IDhopdong]) VALUES (2003, N'ki', 4001, 3002, 12332, 1002, 5001, 7001)
INSERT [dbo].[DuAn] ([IDduan], [Tenduan], [IDnhadautu], [IDlichtrinh], [kinhphi], [IDkhachhang], [IDnhanvien], [IDhopdong]) VALUES (2004, N'll', 4001, 3001, 22132, 1001, 5001, 7001)
INSERT [dbo].[DuAn] ([IDduan], [Tenduan], [IDnhadautu], [IDlichtrinh], [kinhphi], [IDkhachhang], [IDnhanvien], [IDhopdong]) VALUES (2005, N'hh', 4001, 3002, 12345, 1001, 5001, 7001)
GO
INSERT [dbo].[Hopdong] ([IDhopdong], [Tenhophopdongduan], [ngaykiket], [hieuluc]) VALUES (7001, N'hh', CAST(N'2001-04-02T00:00:00.000' AS DateTime), N'5         ')
INSERT [dbo].[Hopdong] ([IDhopdong], [Tenhophopdongduan], [ngaykiket], [hieuluc]) VALUES (7002, N'kk', CAST(N'2003-03-03T00:00:00.000' AS DateTime), N'7         ')
GO
INSERT [dbo].[KhachHang] ([IDKhachhang], [TenKhachhang], [Diachi], [SĐT]) VALUES (1001, N'Nguyễn Thị Hảo', N'Ba Đình-Hà Nội', N'0234657320')
INSERT [dbo].[KhachHang] ([IDKhachhang], [TenKhachhang], [Diachi], [SĐT]) VALUES (1002, N'Lê huyền Thương', N'Lê Văn Hiến', N'0351603370')
INSERT [dbo].[KhachHang] ([IDKhachhang], [TenKhachhang], [Diachi], [SĐT]) VALUES (1003, N'Phùng Lê Nguyên Vũ', N'Đức Thắng', N'0362801990')
INSERT [dbo].[KhachHang] ([IDKhachhang], [TenKhachhang], [Diachi], [SĐT]) VALUES (1004, N'Trần Thành Nam', N'Cổ Nhuế', N'0987345120')
INSERT [dbo].[KhachHang] ([IDKhachhang], [TenKhachhang], [Diachi], [SĐT]) VALUES (1006, N'ngô thị lại', N'Ba Đình', N'09876789')
GO
INSERT [dbo].[Lichtrinh] ([IDlichtrinh], [Tenduan], [ngaybatdau], [ngạketthuc], [IDthongbao]) VALUES (3001, N'Đầu tư Đất', CAST(N'2021-09-09T00:00:00.000' AS DateTime), CAST(N'2022-03-07T00:00:00.000' AS DateTime), 6001)
INSERT [dbo].[Lichtrinh] ([IDlichtrinh], [Tenduan], [ngaybatdau], [ngạketthuc], [IDthongbao]) VALUES (3002, N'Đầu tư chứng khoán', CAST(N'2021-03-04T00:00:00.000' AS DateTime), CAST(N'2022-08-09T00:00:00.000' AS DateTime), 6001)
GO
INSERT [dbo].[Nhadautu] ([IDnhadautu], [Tennhadautu], [Sđt]) VALUES (4001, N'hhh', N'09871343')
INSERT [dbo].[Nhadautu] ([IDnhadautu], [Tennhadautu], [Sđt]) VALUES (4002, N'coinmaster', N'99999')
INSERT [dbo].[Nhadautu] ([IDnhadautu], [Tennhadautu], [Sđt]) VALUES (4003, N'huhu', N'99999')
INSERT [dbo].[Nhadautu] ([IDnhadautu], [Tennhadautu], [Sđt]) VALUES (4004, N'joker', N'09871343')
GO
INSERT [dbo].[Nhanvien] ([IDnhanvien], [tennhanvien], [SĐT], [IDPhongban]) VALUES (5001, N'Hoài', N'09283234                                          ', 8001)
INSERT [dbo].[Nhanvien] ([IDnhanvien], [tennhanvien], [SĐT], [IDPhongban]) VALUES (5002, N'Hải', N'03209398                                          ', 8002)
GO
INSERT [dbo].[Phongban] ([IDphongban], [manhanvien], [tenphongban]) VALUES (8001, 5001, N'yyy                                               ')
INSERT [dbo].[Phongban] ([IDphongban], [manhanvien], [tenphongban]) VALUES (8002, 5001, N'hoho                                              ')
INSERT [dbo].[Phongban] ([IDphongban], [manhanvien], [tenphongban]) VALUES (8003, 5002, N'hohi                                              ')
GO
INSERT [dbo].[Taikhoan] ([TenTk], [Matkhau], [Sđt]) VALUES (N'hoa', N'hoa123', N'03934954')
INSERT [dbo].[Taikhoan] ([TenTk], [Matkhau], [Sđt]) VALUES (N'hue', N'hue123', N'036789456')
INSERT [dbo].[Taikhoan] ([TenTk], [Matkhau], [Sđt]) VALUES (N'huong', N'huong123', N'098356177')
INSERT [dbo].[Taikhoan] ([TenTk], [Matkhau], [Sđt]) VALUES (N'huy       ', N'huy123    ', N'145541    ')
INSERT [dbo].[Taikhoan] ([TenTk], [Matkhau], [Sđt]) VALUES (N'thu', N'thu123', N'0987375')
INSERT [dbo].[Taikhoan] ([TenTk], [Matkhau], [Sđt]) VALUES (N'thuha     ', N'thuha123  ', N'02345678  ')
INSERT [dbo].[Taikhoan] ([TenTk], [Matkhau], [Sđt]) VALUES (N'vuong     ', N'vuong123  ', N'123321    ')
GO
INSERT [dbo].[Thongbao] ([IDthongbao], [Tenthongbao], [Ngaythongbao]) VALUES (6001, N'Thông Báo Kinh Phí', CAST(N'2024-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Thongbao] ([IDthongbao], [Tenthongbao], [Ngaythongbao]) VALUES (6002, N'Thông Báo Chuyển Giao', CAST(N'2002-04-03T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[DuAn]  WITH CHECK ADD  CONSTRAINT [FK_DuAn_Hopdong] FOREIGN KEY([IDhopdong])
REFERENCES [dbo].[Hopdong] ([IDhopdong])
GO
ALTER TABLE [dbo].[DuAn] CHECK CONSTRAINT [FK_DuAn_Hopdong]
GO
ALTER TABLE [dbo].[DuAn]  WITH CHECK ADD  CONSTRAINT [FK_DuAn_KhachHang] FOREIGN KEY([IDkhachhang])
REFERENCES [dbo].[KhachHang] ([IDKhachhang])
GO
ALTER TABLE [dbo].[DuAn] CHECK CONSTRAINT [FK_DuAn_KhachHang]
GO
ALTER TABLE [dbo].[DuAn]  WITH CHECK ADD  CONSTRAINT [FK_DuAn_Lichtrinh] FOREIGN KEY([IDlichtrinh])
REFERENCES [dbo].[Lichtrinh] ([IDlichtrinh])
GO
ALTER TABLE [dbo].[DuAn] CHECK CONSTRAINT [FK_DuAn_Lichtrinh]
GO
ALTER TABLE [dbo].[DuAn]  WITH CHECK ADD  CONSTRAINT [FK_DuAn_Nhadautu] FOREIGN KEY([IDnhadautu])
REFERENCES [dbo].[Nhadautu] ([IDnhadautu])
GO
ALTER TABLE [dbo].[DuAn] CHECK CONSTRAINT [FK_DuAn_Nhadautu]
GO
ALTER TABLE [dbo].[DuAn]  WITH CHECK ADD  CONSTRAINT [FK_DuAn_Nhanvien] FOREIGN KEY([IDnhanvien])
REFERENCES [dbo].[Nhanvien] ([IDnhanvien])
GO
ALTER TABLE [dbo].[DuAn] CHECK CONSTRAINT [FK_DuAn_Nhanvien]
GO
ALTER TABLE [dbo].[Lichtrinh]  WITH CHECK ADD  CONSTRAINT [FK_Lichtrinh_Thongbao] FOREIGN KEY([IDthongbao])
REFERENCES [dbo].[Thongbao] ([IDthongbao])
GO
ALTER TABLE [dbo].[Lichtrinh] CHECK CONSTRAINT [FK_Lichtrinh_Thongbao]
GO
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien_Phongban] FOREIGN KEY([IDPhongban])
REFERENCES [dbo].[Phongban] ([IDphongban])
GO
ALTER TABLE [dbo].[Nhanvien] CHECK CONSTRAINT [FK_Nhanvien_Phongban]
GO
USE [master]
GO
ALTER DATABASE [qlida] SET  READ_WRITE 
GO
