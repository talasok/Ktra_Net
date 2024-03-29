USE [QLSV]
GO
/****** Object:  Table [dbo].[CNTT]    Script Date: 12/1/2019 3:36:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CNTT](
	[id_sv] [int] NOT NULL,
	[pascal] [nchar](10) NULL,
	[cshap] [float] NULL,
	[sql] [nchar](10) NULL,
 CONSTRAINT [PK_CNTT] PRIMARY KEY CLUSTERED 
(
	[id_sv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 12/1/2019 3:36:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[makhoa] [nchar](10) NOT NULL,
	[tenkhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[makhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 12/1/2019 3:36:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinh] [bit] NULL,
	[ngaysinh] [date] NULL,
	[makhoa] [nchar](10) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Van]    Script Date: 12/1/2019 3:36:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Van](
	[id_sv] [int] NOT NULL,
	[vanhoccd] [float] NULL,
	[vanhochd] [float] NULL,
 CONSTRAINT [PK_Van] PRIMARY KEY CLUSTERED 
(
	[id_sv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VatLy]    Script Date: 12/1/2019 3:36:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatLy](
	[id_sv] [int] NOT NULL,
	[cokhi] [float] NULL,
	[quanghoc] [float] NULL,
	[dien] [float] NULL,
	[vlhatnhan] [float] NULL,
 CONSTRAINT [PK_VatLy] PRIMARY KEY CLUSTERED 
(
	[id_sv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CNTT] ([id_sv], [pascal], [cshap], [sql]) VALUES (3, N'7         ', 8, N'9         ')
INSERT [dbo].[CNTT] ([id_sv], [pascal], [cshap], [sql]) VALUES (4, N'8         ', 8, N'8         ')
INSERT [dbo].[CNTT] ([id_sv], [pascal], [cshap], [sql]) VALUES (25, N'9         ', 9, N'9         ')
INSERT [dbo].[CNTT] ([id_sv], [pascal], [cshap], [sql]) VALUES (28, N'1         ', 2, N'3         ')
SET IDENTITY_INSERT [dbo].[SINHVIEN] ON 

INSERT [dbo].[SINHVIEN] ([id], [hoten], [gioitinh], [ngaysinh], [makhoa]) VALUES (1, N'Hồ Thanh Hoàng', 1, CAST(N'2019-11-11' AS Date), N'van       ')
INSERT [dbo].[SINHVIEN] ([id], [hoten], [gioitinh], [ngaysinh], [makhoa]) VALUES (2, N'Hồ Thanh Lâm', 1, CAST(N'2019-11-11' AS Date), N'vatly     ')
INSERT [dbo].[SINHVIEN] ([id], [hoten], [gioitinh], [ngaysinh], [makhoa]) VALUES (3, N'Phạm Tiến Đạt 1', 1, CAST(N'2019-11-11' AS Date), N'cntt      ')
INSERT [dbo].[SINHVIEN] ([id], [hoten], [gioitinh], [ngaysinh], [makhoa]) VALUES (4, N'Trương Văn Vân', 0, CAST(N'2019-11-11' AS Date), N'cntt      ')
SET IDENTITY_INSERT [dbo].[SINHVIEN] OFF
INSERT [dbo].[Van] ([id_sv], [vanhoccd], [vanhochd]) VALUES (11, 9, 9)
INSERT [dbo].[Van] ([id_sv], [vanhoccd], [vanhochd]) VALUES (14, 9, 9)
INSERT [dbo].[Van] ([id_sv], [vanhoccd], [vanhochd]) VALUES (27, 1, 2)
INSERT [dbo].[VatLy] ([id_sv], [cokhi], [quanghoc], [dien], [vlhatnhan]) VALUES (2, 6, 7, 8, 9)
INSERT [dbo].[VatLy] ([id_sv], [cokhi], [quanghoc], [dien], [vlhatnhan]) VALUES (26, 1, 2, 4, 3)
INSERT [dbo].[VatLy] ([id_sv], [cokhi], [quanghoc], [dien], [vlhatnhan]) VALUES (29, 6, 7, 9, 8)
