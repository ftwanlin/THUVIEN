USE [master]
GO
/****** Object:  Database [QUANLYTHUVIEN]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE DATABASE [QUANLYTHUVIEN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYTHUVIEN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QUANLYTHUVIEN.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANLYTHUVIEN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QUANLYTHUVIEN_log.ldf' , SIZE = 1344KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYTHUVIEN] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYTHUVIEN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYTHUVIEN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYTHUVIEN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QUANLYTHUVIEN] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUANLYTHUVIEN', N'ON'
GO
USE [QUANLYTHUVIEN]
GO
/****** Object:  User [tg]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE USER [tg] FOR LOGIN [tg] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [N6]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE USER [N6] FOR LOGIN [N6] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [N5]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE USER [N5] FOR LOGIN [N5] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [N4]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE USER [N4] FOR LOGIN [N4] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [N3]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE USER [N3] FOR LOGIN [N3] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [N2]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE USER [N2] FOR LOGIN [N2] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [N1]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE USER [N1] FOR LOGIN [N1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [TACGIA]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE ROLE [TACGIA]
GO
/****** Object:  DatabaseRole [QUANLY]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE ROLE [QUANLY]
GO
/****** Object:  DatabaseRole [NHANVIEN]    Script Date: 6/10/2022 1:54:09 PM ******/
CREATE ROLE [NHANVIEN]
GO
ALTER ROLE [TACGIA] ADD MEMBER [tg]
GO
ALTER ROLE [NHANVIEN] ADD MEMBER [N6]
GO
ALTER ROLE [db_datareader] ADD MEMBER [N6]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [N6]
GO
ALTER ROLE [QUANLY] ADD MEMBER [N5]
GO
ALTER ROLE [db_owner] ADD MEMBER [N5]
GO
ALTER ROLE [NHANVIEN] ADD MEMBER [N4]
GO
ALTER ROLE [db_datareader] ADD MEMBER [N4]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [N4]
GO
ALTER ROLE [QUANLY] ADD MEMBER [N3]
GO
ALTER ROLE [db_owner] ADD MEMBER [N3]
GO
ALTER ROLE [NHANVIEN] ADD MEMBER [N2]
GO
ALTER ROLE [db_datareader] ADD MEMBER [N2]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [N2]
GO
ALTER ROLE [QUANLY] ADD MEMBER [N1]
GO
ALTER ROLE [db_owner] ADD MEMBER [N1]
GO
ALTER ROLE [db_owner] ADD MEMBER [QUANLY]
GO
ALTER ROLE [db_datareader] ADD MEMBER [NHANVIEN]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [NHANVIEN]
GO
/****** Object:  Table [dbo].[CT_PHIEUMUON]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUMUON](
	[MAPHIEUMUON] [int] NOT NULL,
	[MASACH] [int] NOT NULL,
	[HANTRA] [date] NULL,
	[MATINHTRANG] [int] NULL,
	[GHICHU] [nvarchar](100) NULL,
 CONSTRAINT [PK_CT_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUMUON] ASC,
	[MASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MADOCGIA] [int] IDENTITY(1,1) NOT NULL,
	[MATHE] [int] NOT NULL,
	[TENDOCGIA] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [bit] NOT NULL CONSTRAINT [DF_DOCGIA_GIOITINH]  DEFAULT ((0)),
	[CCCD] [char](12) NULL,
	[SDT] [char](12) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](100) NULL,
 CONSTRAINT [PK__DOCGIA__8CA726FC70D673D6] PRIMARY KEY CLUSTERED 
(
	[MADOCGIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [nvarchar](10) NOT NULL,
	[TEN] [nvarchar](40) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [bit] NULL CONSTRAINT [DF_NHANVIEN_GIOITINH]  DEFAULT ((0)),
	[CCCD] [char](12) NULL,
	[SDT] [char](12) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[TRANGTHAI] [bit] NOT NULL CONSTRAINT [DF__NHANVIEN__NGAYHO__182C9B23]  DEFAULT ((0)),
 CONSTRAINT [PK__NHANVIEN__603F5114BA20D896] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MANXB] [int] IDENTITY(1,1) NOT NULL,
	[TENNXB] [nvarchar](50) NULL,
	[SDT] [char](12) NULL,
	[EMAIL] [nvarchar](40) NULL,
	[DIACHI] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MAPHIEUMUON] [int] IDENTITY(1,1) NOT NULL,
	[MATHE] [int] NOT NULL,
	[MANV] [nvarchar](10) NOT NULL,
	[NGAYMUON] [datetime] NULL CONSTRAINT [DF__PHIEUMUON__NGAYM__276EDEB3]  DEFAULT (getdate()),
	[SOLUONGMUONTOIDA] [int] NULL,
 CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUMUON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QUYEN](
	[MAQUYEN] [char](10) NOT NULL,
	[TENQUYEN] [nvarchar](30) NULL,
 CONSTRAINT [PK__QUYEN__F2A840CF023E3EC0] PRIMARY KEY CLUSTERED 
(
	[MAQUYEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACH](
	[MASACH] [int] IDENTITY(1,1) NOT NULL,
	[MATHELOAI] [int] NOT NULL,
	[MATACGIA] [int] NOT NULL,
	[MANXB] [int] NOT NULL,
	[TENSACH] [nvarchar](50) NULL,
	[ANHSACH] [nvarchar](70) NULL,
	[NAMXB] [char](4) NULL,
	[GIA] [money] NULL,
	[SOLUONGDAUSACH] [int] NULL,
	[SOLUONGHIENTAI] [int] NULL,
	[TOMTAT] [nvarchar](500) NULL,
 CONSTRAINT [PK__SACH__3FC48E4C6619AA99] PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MATACGIA] [int] IDENTITY(1,1) NOT NULL,
	[TENTACGIA] [nvarchar](50) NULL,
	[TIEUSU] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[MATACGIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TENDANGNHAP] [nvarchar](10) NOT NULL,
	[MATKHAU] [nvarchar](16) NOT NULL,
	[MAQUYEN] [char](10) NOT NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[TENDANGNHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MATHELOAI] [int] IDENTITY(1,1) NOT NULL,
	[TENTHELOAI] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MATHELOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THETHUVIEN]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THETHUVIEN](
	[MATHE] [int] IDENTITY(1,1) NOT NULL,
	[NGAYCAP] [date] NULL CONSTRAINT [DF_THETHUVIEN_NGAYCAP]  DEFAULT (getdate()),
	[HSD] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MATHE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TINHTRANG]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANG](
	[MATINHTRANG] [int] IDENTITY(1,1) NOT NULL,
	[TINHTRANG] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MATINHTRANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[VIEW_NHAXUATBAN]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_NHAXUATBAN]
AS
SELECT MANXB, TENNXB
FROM     dbo.NHAXUATBAN

GO
/****** Object:  View [dbo].[VIEW_QUYEN]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_QUYEN]
AS
SELECT MAQUYEN, TENQUYEN
FROM     dbo.QUYEN

GO
/****** Object:  View [dbo].[VIEW_TACGIA]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_TACGIA]
AS
SELECT MATACGIA, TENTACGIA
FROM     dbo.TACGIA

GO
/****** Object:  View [dbo].[VIEW_THELOAI]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_THELOAI]
AS
SELECT * FROM THELOAI
GO
/****** Object:  View [dbo].[VIEW_TINHTRANG]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_TINHTRANG]
AS

	SELECT * FROM TINHTRANG

GO
INSERT [dbo].[CT_PHIEUMUON] ([MAPHIEUMUON], [MASACH], [HANTRA], [MATINHTRANG], [GHICHU]) VALUES (2, 7, CAST(N'2022-06-11' AS Date), 1, NULL)
SET IDENTITY_INSERT [dbo].[DOCGIA] ON 

INSERT [dbo].[DOCGIA] ([MADOCGIA], [MATHE], [TENDOCGIA], [NGAYSINH], [GIOITINH], [CCCD], [SDT], [EMAIL], [DIACHI]) VALUES (2, 2, N'Tạ Quang Linh', CAST(N'2022-06-21' AS Date), 0, N'197395861   ', N'0928323824  ', N'fglksd@gmail.com', N'87 abj iquhriq  ')
INSERT [dbo].[DOCGIA] ([MADOCGIA], [MATHE], [TENDOCGIA], [NGAYSINH], [GIOITINH], [CCCD], [SDT], [EMAIL], [DIACHI]) VALUES (4, 3, N'Draven Doat Menh', CAST(N'2018-05-30' AS Date), 1, N'245345      ', N'34534       ', N'sdvsvsaaaa', N'sfvsdf')
SET IDENTITY_INSERT [dbo].[DOCGIA] OFF
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [NGAYSINH], [GIOITINH], [CCCD], [SDT], [EMAIL], [DIACHI], [TRANGTHAI]) VALUES (N'N1', N'Ya Thị Xua', CAST(N'2022-06-06' AS Date), 0, N'321651515   ', N'032165134   ', N'sdjvhbksd@gmail.com', N'Sum mon nờ rítt', 1)
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [NGAYSINH], [GIOITINH], [CCCD], [SDT], [EMAIL], [DIACHI], [TRANGTHAI]) VALUES (N'N2', N'Nguyễn Văn Zed', CAST(N'2001-01-01' AS Date), 1, N'927491233   ', N'0123810928  ', N'sdfsdfsdf', N'sdfsdfsdf', 1)
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [NGAYSINH], [GIOITINH], [CCCD], [SDT], [EMAIL], [DIACHI], [TRANGTHAI]) VALUES (N'N3', N'Tran Van Long', CAST(N'2022-06-06' AS Date), 1, N'098123928   ', N'1029380122  ', N'kajsdhfkasdjhfkasdjhf', N'jshdvbskdjfhksdjhf', 1)
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [NGAYSINH], [GIOITINH], [CCCD], [SDT], [EMAIL], [DIACHI], [TRANGTHAI]) VALUES (N'N4', N'Nguyễn Văn Nam', CAST(N'2003-03-04' AS Date), 0, N'192736914   ', N'0945134155  ', N'eksjebkse@gmail.com', N'sdhvbkseygvskehbvskegv', 1)
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [NGAYSINH], [GIOITINH], [CCCD], [SDT], [EMAIL], [DIACHI], [TRANGTHAI]) VALUES (N'N5', N'Trần Thị Lan', CAST(N'2022-02-20' AS Date), 1, N'198273221   ', N'0917263871  ', N'gkhegke@gmaul.com', N'aiygfkayfgief', 1)
INSERT [dbo].[NHANVIEN] ([MANV], [TEN], [NGAYSINH], [GIOITINH], [CCCD], [SDT], [EMAIL], [DIACHI], [TRANGTHAI]) VALUES (N'N6', N'Giang Văn Cốt', CAST(N'2022-06-13' AS Date), 1, N'1352352334  ', N'2342342134  ', N'sgseesse', N'ewberberes', 1)
SET IDENTITY_INSERT [dbo].[NHAXUATBAN] ON 

INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [SDT], [EMAIL], [DIACHI]) VALUES (1, N'Nhà xuất bản Trẻ', N'0192837123  ', N'skdjfhksjdf@gmail.com', N'197/23 Man Thiện')
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [SDT], [EMAIL], [DIACHI]) VALUES (2, N'Nhà xuất bản Kim Đồng', N'0129830122  ', N'kdhjfksdf@gmail.com', N'kjzshfkjahsd')
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [SDT], [EMAIL], [DIACHI]) VALUES (3, N'Nhà xuất bản Thanh Niên', N'0987654321  ', N'thanhnien@gmail.com', N'97 Man Thiện A')
INSERT [dbo].[NHAXUATBAN] ([MANXB], [TENNXB], [SDT], [EMAIL], [DIACHI]) VALUES (5, N'Nhà xuất bản Summoner''s Rift', N'9182739133  ', N'skdhgfsdf@gmail.com', N'sdkfhksejhfkh')
SET IDENTITY_INSERT [dbo].[NHAXUATBAN] OFF
SET IDENTITY_INSERT [dbo].[PHIEUMUON] ON 

INSERT [dbo].[PHIEUMUON] ([MAPHIEUMUON], [MATHE], [MANV], [NGAYMUON], [SOLUONGMUONTOIDA]) VALUES (2, 5, N'N1', CAST(N'2022-06-10 00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[PHIEUMUON] OFF
INSERT [dbo].[QUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (N'NHANVIEN  ', N'Nhân viên')
INSERT [dbo].[QUYEN] ([MAQUYEN], [TENQUYEN]) VALUES (N'QUANLY    ', N'Quản lý')
SET IDENTITY_INSERT [dbo].[SACH] ON 

INSERT [dbo].[SACH] ([MASACH], [MATHELOAI], [MATACGIA], [MANXB], [TENSACH], [ANHSACH], [NAMXB], [GIA], [SOLUONGDAUSACH], [SOLUONGHIENTAI], [TOMTAT]) VALUES (1, 5, 3, 1, N'Tuổi trẻ đáng giá bao nhiêu?', NULL, N'2244', 60000.0000, 1, 1, N'Tuổi trẻ đáng giá 60000 VND nhé.')
INSERT [dbo].[SACH] ([MASACH], [MATHELOAI], [MATACGIA], [MANXB], [TENSACH], [ANHSACH], [NAMXB], [GIA], [SOLUONGDAUSACH], [SOLUONGHIENTAI], [TOMTAT]) VALUES (3, 1, 3, 3, N'dfvbsfdgs', NULL, N'2232', 23123.0000, 32, 12, N'àgsfgsdf')
INSERT [dbo].[SACH] ([MASACH], [MATHELOAI], [MATACGIA], [MANXB], [TENSACH], [ANHSACH], [NAMXB], [GIA], [SOLUONGDAUSACH], [SOLUONGHIENTAI], [TOMTAT]) VALUES (6, 4, 4, 2, N'Yasuo và những người bạn', NULL, N'2022', 50000.0000, 120, 11, N'Yasuo di mid gank tem 20 gg')
INSERT [dbo].[SACH] ([MASACH], [MATHELOAI], [MATACGIA], [MANXB], [TENSACH], [ANHSACH], [NAMXB], [GIA], [SOLUONGDAUSACH], [SOLUONGHIENTAI], [TOMTAT]) VALUES (7, 3, 1, 1, N'Triết lý sâu sắc', NULL, N'2021', 22221.0000, 2, 2, N'Không làm mà đòi có ăn')
INSERT [dbo].[SACH] ([MASACH], [MATHELOAI], [MATACGIA], [MANXB], [TENSACH], [ANHSACH], [NAMXB], [GIA], [SOLUONGDAUSACH], [SOLUONGHIENTAI], [TOMTAT]) VALUES (8, 4, 5, 5, N'200 năm cân bằng game Riot', NULL, N'2022', 100000.0000, 20, 11, N'Có con tướng nào xả trật hết skill xong chém thường solo kill không? Có con tướng nào thả cái R chết 5 thằng như con Aphe đbrr không? Có con tướng nào giao tranh 1 chấm máu xong cắt mấy nhát đầy máu như con Gwen không? Cân bằng game như cl.')
SET IDENTITY_INSERT [dbo].[SACH] OFF
SET IDENTITY_INSERT [dbo].[TACGIA] ON 

INSERT [dbo].[TACGIA] ([MATACGIA], [TENTACGIA], [TIEUSU]) VALUES (1, N'Tô Hoài', N'Tô Hoài là 1 nhà văn')
INSERT [dbo].[TACGIA] ([MATACGIA], [TENTACGIA], [TIEUSU]) VALUES (2, N'Huấn Hoa Hồng', N'Huấn là 1 nhà thơ')
INSERT [dbo].[TACGIA] ([MATACGIA], [TENTACGIA], [TIEUSU]) VALUES (3, N'Xuân Diệu', N'Xuân Diệu là 1 nhà văn lớn của nền văn học hiện đại Việt Nam.')
INSERT [dbo].[TACGIA] ([MATACGIA], [TENTACGIA], [TIEUSU]) VALUES (4, N'Yasuo', N'Death is like the wind, always by my side.')
INSERT [dbo].[TACGIA] ([MATACGIA], [TENTACGIA], [TIEUSU]) VALUES (5, N'Irelia', N'Irelia là vị tướng cân bằng nhất game với bộ chiêu thức chỉ bao gồm phím A.')
SET IDENTITY_INSERT [dbo].[TACGIA] OFF
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MATKHAU], [MAQUYEN]) VALUES (N'N1', N'1234', N'QUANLY    ')
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MATKHAU], [MAQUYEN]) VALUES (N'N2', N'123', N'NHANVIEN  ')
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MATKHAU], [MAQUYEN]) VALUES (N'N3', N'123', N'QUANLY    ')
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MATKHAU], [MAQUYEN]) VALUES (N'N4', N'123', N'NHANVIEN  ')
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MATKHAU], [MAQUYEN]) VALUES (N'N5', N'123', N'QUANLY    ')
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MATKHAU], [MAQUYEN]) VALUES (N'N6', N'123', N'NHANVIEN  ')
SET IDENTITY_INSERT [dbo].[THELOAI] ON 

INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (1, N'Trinh thám')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (2, N'Kinh dị')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (3, N'Tình cảm')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (4, N'Hài hước')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (5, N'Tiểu thuyết')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (6, N'Drama')
SET IDENTITY_INSERT [dbo].[THELOAI] OFF
SET IDENTITY_INSERT [dbo].[THETHUVIEN] ON 

INSERT [dbo].[THETHUVIEN] ([MATHE], [NGAYCAP], [HSD]) VALUES (2, CAST(N'2022-06-08' AS Date), CAST(N'2022-10-06' AS Date))
INSERT [dbo].[THETHUVIEN] ([MATHE], [NGAYCAP], [HSD]) VALUES (3, CAST(N'2022-06-08' AS Date), CAST(N'2022-10-10' AS Date))
INSERT [dbo].[THETHUVIEN] ([MATHE], [NGAYCAP], [HSD]) VALUES (4, CAST(N'2022-06-08' AS Date), CAST(N'2022-05-30' AS Date))
INSERT [dbo].[THETHUVIEN] ([MATHE], [NGAYCAP], [HSD]) VALUES (5, CAST(N'2022-06-08' AS Date), CAST(N'2029-07-25' AS Date))
INSERT [dbo].[THETHUVIEN] ([MATHE], [NGAYCAP], [HSD]) VALUES (6, CAST(N'2022-06-10' AS Date), CAST(N'2023-01-05' AS Date))
SET IDENTITY_INSERT [dbo].[THETHUVIEN] OFF
SET IDENTITY_INSERT [dbo].[TINHTRANG] ON 

INSERT [dbo].[TINHTRANG] ([MATINHTRANG], [TINHTRANG]) VALUES (1, N'Đã trả')
INSERT [dbo].[TINHTRANG] ([MATINHTRANG], [TINHTRANG]) VALUES (2, N'Chưa trả')
SET IDENTITY_INSERT [dbo].[TINHTRANG] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__DOCGIA__A955A0AA6469EFCC]    Script Date: 6/10/2022 1:54:09 PM ******/
ALTER TABLE [dbo].[DOCGIA] ADD  CONSTRAINT [UQ__DOCGIA__A955A0AA6469EFCC] UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__NHANVIEN__A955A0AAAFB0872A]    Script Date: 6/10/2022 1:54:09 PM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [UQ__NHANVIEN__A955A0AAAFB0872A] UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK__CT_PHIEUM__MASAC__38996AB5] FOREIGN KEY([MASACH])
REFERENCES [dbo].[SACH] ([MASACH])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK__CT_PHIEUM__MASAC__38996AB5]
GO
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUON] FOREIGN KEY([MAPHIEUMUON])
REFERENCES [dbo].[PHIEUMUON] ([MAPHIEUMUON])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUON]
GO
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_TINHTRANG] FOREIGN KEY([MATINHTRANG])
REFERENCES [dbo].[TINHTRANG] ([MATINHTRANG])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_TINHTRANG]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_THETHUVIEN] FOREIGN KEY([MATHE])
REFERENCES [dbo].[THETHUVIEN] ([MATHE])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_THETHUVIEN]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK__PHIEUMUON__MANV__267ABA7A] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK__PHIEUMUON__MANV__267ABA7A]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK__PHIEUMUON__MATHE__25869641] FOREIGN KEY([MATHE])
REFERENCES [dbo].[THETHUVIEN] ([MATHE])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK__PHIEUMUON__MATHE__25869641]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK__SACH__MANXB__33D4B598] FOREIGN KEY([MANXB])
REFERENCES [dbo].[NHAXUATBAN] ([MANXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK__SACH__MANXB__33D4B598]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK__SACH__MATACGIA__32E0915F] FOREIGN KEY([MATACGIA])
REFERENCES [dbo].[TACGIA] ([MATACGIA])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK__SACH__MATACGIA__32E0915F]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK__SACH__MATHELOAI__31EC6D26] FOREIGN KEY([MATHELOAI])
REFERENCES [dbo].[THELOAI] ([MATHELOAI])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK__SACH__MATHELOAI__31EC6D26]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK__TAIKHOAN__TENDAN__3A81B327] FOREIGN KEY([TENDANGNHAP])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK__TAIKHOAN__TENDAN__3A81B327]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_QUYEN] FOREIGN KEY([MAQUYEN])
REFERENCES [dbo].[QUYEN] ([MAQUYEN])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_QUYEN]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [CHECK_GIOITINH_DOCGIA] CHECK  (([GIOITINH]=(0) OR [GIOITINH]=(1)))
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [CHECK_GIOITINH_DOCGIA]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [CHECK_GIOITINH_NHANVIEN] CHECK  (([GIOITINH]=(0) OR [GIOITINH]=(1)))
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [CHECK_GIOITINH_NHANVIEN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [CK__SACH__SOLUONGDAU__34C8D9D1] CHECK  (([SOLUONGDAUSACH]>(0)))
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [CK__SACH__SOLUONGDAU__34C8D9D1]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [CK__SACH__SOLUONGHIE__35BCFE0A] CHECK  (([SOLUONGHIENTAI]>=(0)))
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [CK__SACH__SOLUONGHIE__35BCFE0A]
GO
/****** Object:  StoredProcedure [dbo].[SP_KiemTraLogin]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KiemTraLogin]
@loginname int
AS
BEGIN
	IF EXISTS(SELECT SUSER_SNAME(SID) FROM sys.sysusers WHERE name = CAST(@loginname AS NVARCHAR))
		RETURN 1;
	RETURN 0;
END


GO
/****** Object:  StoredProcedure [dbo].[SP_KiemTraPhieuMuon]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KiemTraPhieuMuon]
@MA nvarchar(10)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM CT_PHIEUMUON WHERE MAPHIEUMUON = @MA AND MATINHTRANG = 2) OR NOT EXISTS(SELECT 1 FROM CT_PHIEUMUON WHERE MAPHIEUMUON = @MA)
	RETURN 1; -- Co the sua phieu muon
	RETURN 0; -- Khong the sua phieu muon
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_Thong_Tin_NV_Tu_Login]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Lay_Thong_Tin_NV_Tu_Login]
@TENLOGIN nvarchar(10)
AS
DECLARE @UID INT
DECLARE @MANV nvarchar(10)
SELECT @UID= uid , @MANV= NAME FROM sys.sysusers 
  WHERE sid = SUSER_SID(@TENLOGIN)

SELECT
       HOTEN = (SELECT TEN FROM dbo.NHANVIEN WHERE MANV=@MANV ), 
       TENNHOM=NAME,
	   TRANGTHAI = (SELECT TRANGTHAI FROM NHANVIEN WHERE MANV = @MANV)
  FROM sys.sysusers
    WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)


GO
/****** Object:  StoredProcedure [dbo].[SP_TaoTaiKhoan]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_TaoTaiKhoan]
@loginame nvarchar(50),
@role nvarchar(50)
as
begin
	declare @exec_stmt nvarchar(4000), 
		@pwd sysname = '123',
		@defdb sysname = 'master',
		@policy bit = 0,
		@exp bit = 0,
		@must_change bit = 0

	set @exec_stmt = 'create login ' + quotename(@loginame) + ' with password ='+ quotename(@pwd, '''')

	if @must_change = 1
		set @exec_stmt = @exec_stmt + ' must_change'

	set @exec_stmt = @exec_stmt + ', default_database=' + quotename(@defdb) 

	if @policy = 1
		set @exec_stmt = @exec_stmt + ', check_policy = on' 
	else
		set @exec_stmt = @exec_stmt + ', check_policy = off'

	if @exp = 1
		set @exec_stmt = @exec_stmt + ', check_expiration = on' 
	else
		set @exec_stmt = @exec_stmt + ', check_expiration = off'

	exec (@exec_stmt) --ok

	set @exec_stmt = ''

	set @exec_stmt = 'create user '+quotename(@loginame) + ' for login '+quotename(@loginame) 
	exec (@exec_stmt)

	EXEC sp_addrolemember @role, @loginame 

	if (@role = 'QUANLY')
	begin
		EXEC sp_addsrvrolemember @loginame, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @loginame, 'ProcessAdmin'
	end

	INSERT INTO TAIKHOAN
	VALUES (@loginame, @pwd, @role);
	--exec sp_grantdbaccess @loginame, @loginame
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TimNV]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TimNV]
@MANV NVARCHAR(10)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM NHANVIEN WHERE MANV = @MANV)
		RETURN 1;
	RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TimTheThuVien]    Script Date: 6/10/2022 1:54:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TimTheThuVien]
@MATHE INT
AS
BEGIN
	IF EXISTS(SELECT * FROM DOCGIA WHERE MATHE = @MATHE)
		RETURN 1;
	RETURN 0;
END	
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NHAXUATBAN"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_NHAXUATBAN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_NHAXUATBAN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "QUYEN"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 126
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_QUYEN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_QUYEN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TACGIA"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 148
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_TACGIA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_TACGIA'
GO
USE [master]
GO
ALTER DATABASE [QUANLYTHUVIEN] SET  READ_WRITE 
GO
