USE [AccounCardDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountCardGroups]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountCardGroups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_AccountCardGroups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountCardKinds]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountCardKinds](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KindName] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_AccountCardKinds] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountCards]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountCards](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Degree] [nvarchar](max) NULL,
	[TaxAdministration] [nvarchar](max) NULL,
	[TaxNumber] [nvarchar](max) NULL,
	[TCNo] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
	[AccountCardGroupId] [int] NOT NULL,
	[AccountCardKindId] [int] NOT NULL,
	[AccountCardSubGroupId] [int] NOT NULL,
	[AccountCardTypeId] [int] NOT NULL,
 CONSTRAINT [PK_AccountCards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountCardSubGroups]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountCardSubGroups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
	[AccountCardGroupId] [int] NOT NULL,
 CONSTRAINT [PK_AccountCardSubGroups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountCardTypes]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountCardTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_AccountCardTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[SurName] [nvarchar](max) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 1.08.2022 16:52:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [int] NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220726193645_mig1', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220726193746_mig2', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220727125330_mig-identity', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220727130145_mig-identity2', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220727140542_mig_remove_identity', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220727140855_mig_addnewidentity', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220728124725_Mig4', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220728125410_Mig5', N'5.0.17')
SET IDENTITY_INSERT [dbo].[AccountCardGroups] ON 

INSERT [dbo].[AccountCardGroups] ([Id], [GroupName], [Status]) VALUES (1, N'Fason', 1)
INSERT [dbo].[AccountCardGroups] ([Id], [GroupName], [Status]) VALUES (2, N'Müşteri', 1)
INSERT [dbo].[AccountCardGroups] ([Id], [GroupName], [Status]) VALUES (3, N'Cari Hesap', 1)
INSERT [dbo].[AccountCardGroups] ([Id], [GroupName], [Status]) VALUES (4, N'Katılma Hesabı', 1)
INSERT [dbo].[AccountCardGroups] ([Id], [GroupName], [Status]) VALUES (5, N'Altın Hesapları', 1)
INSERT [dbo].[AccountCardGroups] ([Id], [GroupName], [Status]) VALUES (6, N'Gümüş hesapları', 1)
SET IDENTITY_INSERT [dbo].[AccountCardGroups] OFF
SET IDENTITY_INSERT [dbo].[AccountCardKinds] ON 

INSERT [dbo].[AccountCardKinds] ([Id], [KindName], [Status]) VALUES (1, N'Müşteri', 1)
INSERT [dbo].[AccountCardKinds] ([Id], [KindName], [Status]) VALUES (2, N'Satıcı', 0)
INSERT [dbo].[AccountCardKinds] ([Id], [KindName], [Status]) VALUES (3, N'Mastercard', 1)
INSERT [dbo].[AccountCardKinds] ([Id], [KindName], [Status]) VALUES (4, N'Troy', 1)
INSERT [dbo].[AccountCardKinds] ([Id], [KindName], [Status]) VALUES (5, N'Visa', 1)
SET IDENTITY_INSERT [dbo].[AccountCardKinds] OFF
SET IDENTITY_INSERT [dbo].[AccountCards] ON 

INSERT [dbo].[AccountCards] ([Id], [Degree], [TaxAdministration], [TaxNumber], [TCNo], [Address], [Status], [AccountCardGroupId], [AccountCardKindId], [AccountCardSubGroupId], [AccountCardTypeId]) VALUES (2, N'CEO', N'BASIT USULDE TİCARİ KAZANC', N'0003', N'14563987103', N'Molla Gürani Mahallesi Turgut Özal Millet Caddesi No 114 Fatih / İSTANBUL', 1, 4, 4, 5, 5)
INSERT [dbo].[AccountCards] ([Id], [Degree], [TaxAdministration], [TaxNumber], [TCNo], [Address], [Status], [AccountCardGroupId], [AccountCardKindId], [AccountCardSubGroupId], [AccountCardTypeId]) VALUES (3, N'Mali Müşavir ', N'Yıllık Gelir Vergisi', N'0006', N'12345678920', N'Kartaltepe Mahallesi Kültür Sokak No 2 Bayrampaşa /İSTANBUL', 1, 4, 3, 4, 5)
INSERT [dbo].[AccountCards] ([Id], [Degree], [TaxAdministration], [TaxNumber], [TCNo], [Address], [Status], [AccountCardGroupId], [AccountCardKindId], [AccountCardSubGroupId], [AccountCardTypeId]) VALUES (4, N'Yılmazlar  Çeyiz A.Ş', N'Çeyiz Vergisi', N'009', N'1256398703', N'Molla Gürani Mahallesi Turgut Özal Millet Caddesi No 114 Fatih / İSTANBUL', 1, 4, 1, 6, 2)
INSERT [dbo].[AccountCards] ([Id], [Degree], [TaxAdministration], [TaxNumber], [TCNo], [Address], [Status], [AccountCardGroupId], [AccountCardKindId], [AccountCardSubGroupId], [AccountCardTypeId]) VALUES (5, N'Kurucu Ortak', N'Yıllık Gelir Vergisi', N'0009', N'65498712302', N'İskender Paşa Mh. Atatürk Bulvarı No1 34091 Fatih/İstanbul', 1, 4, 3, 7, 5)
INSERT [dbo].[AccountCards] ([Id], [Degree], [TaxAdministration], [TaxNumber], [TCNo], [Address], [Status], [AccountCardGroupId], [AccountCardKindId], [AccountCardSubGroupId], [AccountCardTypeId]) VALUES (6, N'CEO', N'BASIT USULDE TİCARİ KAZANC', N'0008', N'78963254103', N'İskender Paşa Mh. Atatürk Bulvarı No1 34091 Fatih/İstanbul', 1, 4, 3, 5, 4)
INSERT [dbo].[AccountCards] ([Id], [Degree], [TaxAdministration], [TaxNumber], [TCNo], [Address], [Status], [AccountCardGroupId], [AccountCardKindId], [AccountCardSubGroupId], [AccountCardTypeId]) VALUES (7, N'Yılmazlar  Çeyiz A.Ş', N'Çeyiz Vergisi', N'0008', N'12345612687', N'İskender Paşa Mh. Atatürk Bulvarı No1 34091 Fatih/İstanbul', 1, 4, 3, 6, 5)
INSERT [dbo].[AccountCards] ([Id], [Degree], [TaxAdministration], [TaxNumber], [TCNo], [Address], [Status], [AccountCardGroupId], [AccountCardKindId], [AccountCardSubGroupId], [AccountCardTypeId]) VALUES (8, N'Kurucu Ortak', N'BASIT USULDE TİCARİ KAZANC', N'0002', N'78964523104', N'Molla Gürani Mahallesi Turgut Özal Millet Caddesi No 114 Fatih / İSTANBUL', 1, 4, 3, 5, 2)
SET IDENTITY_INSERT [dbo].[AccountCards] OFF
SET IDENTITY_INSERT [dbo].[AccountCardSubGroups] ON 

INSERT [dbo].[AccountCardSubGroups] ([Id], [Name], [Status], [AccountCardGroupId]) VALUES (4, N'Konut Hesabı', 1, 1)
INSERT [dbo].[AccountCardSubGroups] ([Id], [Name], [Status], [AccountCardGroupId]) VALUES (5, N'Kur Korumalı TL Katılma Hesabı', 1, 2)
INSERT [dbo].[AccountCardSubGroups] ([Id], [Name], [Status], [AccountCardGroupId]) VALUES (6, N'Çeyiz Hesabı', 1, 3)
INSERT [dbo].[AccountCardSubGroups] ([Id], [Name], [Status], [AccountCardGroupId]) VALUES (7, N'YUVAM Hesap', 1, 4)
INSERT [dbo].[AccountCardSubGroups] ([Id], [Name], [Status], [AccountCardGroupId]) VALUES (8, N'Ara Dönem Kar Payı Ödemeli Katılma Hesabı', 1, 5)
SET IDENTITY_INSERT [dbo].[AccountCardSubGroups] OFF
SET IDENTITY_INSERT [dbo].[AccountCardTypes] ON 

INSERT [dbo].[AccountCardTypes] ([Id], [TypeName], [Status]) VALUES (1, N'Hesap Kart', 1)
INSERT [dbo].[AccountCardTypes] ([Id], [TypeName], [Status]) VALUES (2, N'Kredi Kart', 1)
INSERT [dbo].[AccountCardTypes] ([Id], [TypeName], [Status]) VALUES (3, N'Sanal Kart', 1)
INSERT [dbo].[AccountCardTypes] ([Id], [TypeName], [Status]) VALUES (4, N'Gold Kart', 1)
INSERT [dbo].[AccountCardTypes] ([Id], [TypeName], [Status]) VALUES (5, N'Çek Kart', 1)
SET IDENTITY_INSERT [dbo].[AccountCardTypes] OFF
SET IDENTITY_INSERT [dbo].[AspNetUsers] ON 

INSERT [dbo].[AspNetUsers] ([Id], [Name], [SurName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (1, N'Sevde', N'Yorulmaz', N'Sevdee', N'SEVDEE', N'sevdesy.sy@gmail.com', N'SEVDESY.SY@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEH0Epuhc6I/RS7CxOQu4LJZloycmyYegO1fF8Gttylaj79D/iOWBdDVrhxNC+aCzxw==', N'KCLRUFTDRINQKOII7H6SGJ6JPID5WFRW', N'e73a0567-99b7-40ff-b36c-fb23109f5064', N'05396717296', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [SurName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (2, N'Sümeyye', N'Yorulmaz', N'Sumeyye', N'SUMEYYE', N'sumeyye@gmail.com', N'SUMEYYE@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEDL1zEuHvHi0kRMKWoaDaCVBScVndebuPzHkYQNJNSwxkX9ptTM1rFJzfqjL85eKOw==', N'5HGM67M43UBHJLOIX4S2PEI4RQQOASHD', N'8e53fc00-a4b0-4dc3-bc80-6bf541505231', N'+902126352072', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [SurName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (3, N'Onur', N'Şen', N'Onur', N'ONUR', N'onur@gmail.com', N'ONUR@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKRFdSQERKCnMCDvnZ8I/gqPX0bo1aQVhL8iVbsaHogiGEUYB7p0zfKzs/Nc2sMezg==', N'7ADEOBZSAW4KOEJNQCDCT3GFMJWRLVMP', N'c969ca39-9bdb-4d20-88fc-fdc219bdfa34', N'02125780458', 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[AspNetUsers] OFF
ALTER TABLE [dbo].[AccountCards]  WITH CHECK ADD  CONSTRAINT [FK_AccountCards_AccountCardSubGroups_AccountCardSubGroupId] FOREIGN KEY([AccountCardSubGroupId])
REFERENCES [dbo].[AccountCardSubGroups] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AccountCards] CHECK CONSTRAINT [FK_AccountCards_AccountCardSubGroups_AccountCardSubGroupId]
GO
ALTER TABLE [dbo].[AccountCards]  WITH CHECK ADD  CONSTRAINT [FK_AccountCards_AccountCardTypes_AccountCardTypeId] FOREIGN KEY([AccountCardTypeId])
REFERENCES [dbo].[AccountCardTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AccountCards] CHECK CONSTRAINT [FK_AccountCards_AccountCardTypes_AccountCardTypeId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
