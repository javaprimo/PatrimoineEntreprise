USE [PatrimoineEntreprise]
GO
ALTER TABLE [dbo].[patrimoine] DROP CONSTRAINT [FK_patrimoine_categorie]
GO
ALTER TABLE [dbo].[employe] DROP CONSTRAINT [FK_employe_compte]
GO
ALTER TABLE [dbo].[demande] DROP CONSTRAINT [FK_demande_patrimoine]
GO
ALTER TABLE [dbo].[demande] DROP CONSTRAINT [FK_demande_employe]
GO
/****** Object:  Table [dbo].[poste]    Script Date: 24/02/2021 03:55:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[poste]') AND type in (N'U'))
DROP TABLE [dbo].[poste]
GO
/****** Object:  Table [dbo].[patrimoine]    Script Date: 24/02/2021 03:55:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[patrimoine]') AND type in (N'U'))
DROP TABLE [dbo].[patrimoine]
GO
/****** Object:  Table [dbo].[employe]    Script Date: 24/02/2021 03:55:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[employe]') AND type in (N'U'))
DROP TABLE [dbo].[employe]
GO
/****** Object:  Table [dbo].[demande]    Script Date: 24/02/2021 03:55:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[demande]') AND type in (N'U'))
DROP TABLE [dbo].[demande]
GO
/****** Object:  Table [dbo].[compte]    Script Date: 24/02/2021 03:55:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[compte]') AND type in (N'U'))
DROP TABLE [dbo].[compte]
GO
/****** Object:  Table [dbo].[categorie]    Script Date: 24/02/2021 03:55:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[categorie]') AND type in (N'U'))
DROP TABLE [dbo].[categorie]
GO
USE [master]
GO
/****** Object:  Database [PatrimoineEntreprise]    Script Date: 24/02/2021 03:55:26 ******/
DROP DATABASE [PatrimoineEntreprise]
GO
/****** Object:  Database [PatrimoineEntreprise]    Script Date: 24/02/2021 03:55:26 ******/
CREATE DATABASE [PatrimoineEntreprise]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PatrimoineEntreprise', FILENAME = N'C:\Users\ChuCk\PatrimoineEntreprise.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PatrimoineEntreprise_log', FILENAME = N'C:\Users\ChuCk\PatrimoineEntreprise_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PatrimoineEntreprise] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PatrimoineEntreprise].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PatrimoineEntreprise] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET ARITHABORT OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PatrimoineEntreprise] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PatrimoineEntreprise] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PatrimoineEntreprise] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PatrimoineEntreprise] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PatrimoineEntreprise] SET  MULTI_USER 
GO
ALTER DATABASE [PatrimoineEntreprise] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PatrimoineEntreprise] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PatrimoineEntreprise] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PatrimoineEntreprise] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PatrimoineEntreprise] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PatrimoineEntreprise] SET QUERY_STORE = OFF
GO
USE [PatrimoineEntreprise]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [PatrimoineEntreprise]
GO
/****** Object:  Table [dbo].[categorie]    Script Date: 24/02/2021 03:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categorie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_categorie] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compte]    Script Date: 24/02/2021 03:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compte](
	[userName] [nvarchar](100) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[niveau] [int] NULL,
 CONSTRAINT [PK_compte] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[demande]    Script Date: 24/02/2021 03:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[demande](
	[idDemande] [int] IDENTITY(1,1) NOT NULL,
	[dateDemande] [datetime] NOT NULL,
	[idPatrimoine] [int] NOT NULL,
	[matricule] [int] NOT NULL,
 CONSTRAINT [PK_demande] PRIMARY KEY CLUSTERED 
(
	[idDemande] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employe]    Script Date: 24/02/2021 03:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employe](
	[matricule] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](100) NOT NULL,
	[prenom] [nvarchar](100) NOT NULL,
	[idPoste] [int] NOT NULL,
	[userName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_employe] PRIMARY KEY CLUSTERED 
(
	[matricule] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patrimoine]    Script Date: 24/02/2021 03:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patrimoine](
	[idPatrimoine] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](100) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[prix] [decimal](18, 0) NOT NULL,
	[dureeAmortissement] [int] NOT NULL,
	[tauxAmortissement] [decimal](18, 0) NOT NULL,
	[prixApresAmortissement] [decimal](18, 0) NOT NULL,
	[anciennete] [int] NOT NULL,
	[status] [nvarchar](20) NOT NULL,
	[dateAchat] [date] NOT NULL,
	[idCategorie] [int] NOT NULL,
	[matricule] [nvarchar](10) NULL,
 CONSTRAINT [PK_patrimoine] PRIMARY KEY CLUSTERED 
(
	[idPatrimoine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[poste]    Script Date: 24/02/2021 03:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[poste](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[libelle] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_poste] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categorie] ON 
GO
INSERT [dbo].[categorie] ([id], [Libelle]) VALUES (1, N'High Tech')
GO
INSERT [dbo].[categorie] ([id], [Libelle]) VALUES (2, N'Fourniture')
GO
INSERT [dbo].[categorie] ([id], [Libelle]) VALUES (3, N'Imprimerie')
GO
SET IDENTITY_INSERT [dbo].[categorie] OFF
GO
INSERT [dbo].[compte] ([userName], [password], [niveau]) VALUES (N'admin', N'YXplcnR5', 1)
GO
INSERT [dbo].[compte] ([userName], [password], [niveau]) VALUES (N'userName1', N'YXplcnR5', 0)
GO
INSERT [dbo].[compte] ([userName], [password], [niveau]) VALUES (N'userName2', N'YXplcnR5', 0)
GO
INSERT [dbo].[compte] ([userName], [password], [niveau]) VALUES (N'username3', N'YXplcnR5', 0)
GO
SET IDENTITY_INSERT [dbo].[demande] ON 
GO
INSERT [dbo].[demande] ([idDemande], [dateDemande], [idPatrimoine], [matricule]) VALUES (1, CAST(N'2021-02-24T03:12:16.897' AS DateTime), 1, 1)
GO
INSERT [dbo].[demande] ([idDemande], [dateDemande], [idPatrimoine], [matricule]) VALUES (2, CAST(N'2021-01-01T03:17:44.000' AS DateTime), 3, 2)
GO
INSERT [dbo].[demande] ([idDemande], [dateDemande], [idPatrimoine], [matricule]) VALUES (3, CAST(N'2021-02-24T03:25:52.557' AS DateTime), 1, 2)
GO
INSERT [dbo].[demande] ([idDemande], [dateDemande], [idPatrimoine], [matricule]) VALUES (5, CAST(N'2021-01-01T03:41:33.000' AS DateTime), 2, 1)
GO
INSERT [dbo].[demande] ([idDemande], [dateDemande], [idPatrimoine], [matricule]) VALUES (6, CAST(N'2021-02-24T03:49:53.363' AS DateTime), 2, 1)
GO
SET IDENTITY_INSERT [dbo].[demande] OFF
GO
SET IDENTITY_INSERT [dbo].[employe] ON 
GO
INSERT [dbo].[employe] ([matricule], [nom], [prenom], [idPoste], [userName]) VALUES (1, N'nomEmp1', N'prenomEmp1', 1, N'username1')
GO
INSERT [dbo].[employe] ([matricule], [nom], [prenom], [idPoste], [userName]) VALUES (2, N'nomEmp2', N'prenomEmp2', 2, N'username2')
GO
INSERT [dbo].[employe] ([matricule], [nom], [prenom], [idPoste], [userName]) VALUES (3, N'nomEmp3', N'prenomEmp3', 3, N'username3')
GO
SET IDENTITY_INSERT [dbo].[employe] OFF
GO
SET IDENTITY_INSERT [dbo].[patrimoine] ON 
GO
INSERT [dbo].[patrimoine] ([idPatrimoine], [nom], [description], [prix], [dureeAmortissement], [tauxAmortissement], [prixApresAmortissement], [anciennete], [status], [dateAchat], [idCategorie], [matricule]) VALUES (1, N'nom1', N'desc1', CAST(1000 AS Decimal(18, 0)), 12, CAST(1 AS Decimal(18, 0)), CAST(1200 AS Decimal(18, 0)), 12, N'Neuf', CAST(N'2000-01-01' AS Date), 1, NULL)
GO
INSERT [dbo].[patrimoine] ([idPatrimoine], [nom], [description], [prix], [dureeAmortissement], [tauxAmortissement], [prixApresAmortissement], [anciennete], [status], [dateAchat], [idCategorie], [matricule]) VALUES (2, N'nom2', N'desc2', CAST(1700 AS Decimal(18, 0)), 17, CAST(2 AS Decimal(18, 0)), CAST(1700 AS Decimal(18, 0)), 12, N'Remis-à-neuf', CAST(N'2000-01-01' AS Date), 2, N'1')
GO
INSERT [dbo].[patrimoine] ([idPatrimoine], [nom], [description], [prix], [dureeAmortissement], [tauxAmortissement], [prixApresAmortissement], [anciennete], [status], [dateAchat], [idCategorie], [matricule]) VALUES (3, N'nom3', N'desc3', CAST(2700 AS Decimal(18, 0)), 27, CAST(3 AS Decimal(18, 0)), CAST(2700 AS Decimal(18, 0)), 12, N'Ancien', CAST(N'2000-01-01' AS Date), 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[patrimoine] OFF
GO
SET IDENTITY_INSERT [dbo].[poste] ON 
GO
INSERT [dbo].[poste] ([id], [libelle]) VALUES (1, N'Ingénieur developpement')
GO
INSERT [dbo].[poste] ([id], [libelle]) VALUES (2, N'Comptable')
GO
INSERT [dbo].[poste] ([id], [libelle]) VALUES (3, N'Assistant administratif')
GO
SET IDENTITY_INSERT [dbo].[poste] OFF
GO
ALTER TABLE [dbo].[demande]  WITH CHECK ADD  CONSTRAINT [FK_demande_employe] FOREIGN KEY([matricule])
REFERENCES [dbo].[employe] ([matricule])
GO
ALTER TABLE [dbo].[demande] CHECK CONSTRAINT [FK_demande_employe]
GO
ALTER TABLE [dbo].[demande]  WITH CHECK ADD  CONSTRAINT [FK_demande_patrimoine] FOREIGN KEY([idPatrimoine])
REFERENCES [dbo].[patrimoine] ([idPatrimoine])
GO
ALTER TABLE [dbo].[demande] CHECK CONSTRAINT [FK_demande_patrimoine]
GO
ALTER TABLE [dbo].[employe]  WITH CHECK ADD  CONSTRAINT [FK_employe_compte] FOREIGN KEY([userName])
REFERENCES [dbo].[compte] ([userName])
GO
ALTER TABLE [dbo].[employe] CHECK CONSTRAINT [FK_employe_compte]
GO
ALTER TABLE [dbo].[patrimoine]  WITH CHECK ADD  CONSTRAINT [FK_patrimoine_categorie] FOREIGN KEY([idCategorie])
REFERENCES [dbo].[categorie] ([id])
GO
ALTER TABLE [dbo].[patrimoine] CHECK CONSTRAINT [FK_patrimoine_categorie]
GO
USE [master]
GO
ALTER DATABASE [PatrimoineEntreprise] SET  READ_WRITE 
GO
