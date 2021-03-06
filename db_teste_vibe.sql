USE [master]
GO
/****** Object:  Database [ProvaVibe_00]    Script Date: 04/09/2020 12:24:58 ******/
CREATE DATABASE [ProvaVibe_00]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProvaVibe_00', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ProvaVibe_00.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProvaVibe_00_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ProvaVibe_00_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProvaVibe_00] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProvaVibe_00].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProvaVibe_00] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProvaVibe_00] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProvaVibe_00] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProvaVibe_00] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProvaVibe_00] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProvaVibe_00] SET  MULTI_USER 
GO
ALTER DATABASE [ProvaVibe_00] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProvaVibe_00] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProvaVibe_00] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProvaVibe_00] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProvaVibe_00] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProvaVibe_00] SET QUERY_STORE = OFF
GO
USE [ProvaVibe_00]
GO
/****** Object:  Table [dbo].[APOLICE]    Script Date: 04/09/2020 12:24:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[APOLICE](
	[IDAPOLICE] [int] NOT NULL,
	[IDTIPOSEGURO] [int] NOT NULL,
	[IDSEGURADO] [int] NOT NULL,
	[DTINIVIG] [datetime] NOT NULL,
	[DTFIMVIG] [datetime] NOT NULL,
	[STATUSAPOLICE] [int] NOT NULL,
 CONSTRAINT [PK_APOLICE] PRIMARY KEY CLUSTERED 
(
	[IDAPOLICE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FINANCEIROAPOLICE]    Script Date: 04/09/2020 12:24:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FINANCEIROAPOLICE](
	[IDFINANAPOLICE] [int] NOT NULL,
	[IDAPOLICE] [int] NOT NULL,
	[NUMPARCELA] [int] NOT NULL,
	[DTVENCIMENTO] [datetime] NOT NULL,
	[VALORPARCELA] [numeric](15, 2) NOT NULL,
	[DTPAGTO] [datetime] NULL,
	[VALORPAGTO] [numeric](15, 2) NULL,
	[VALORCOMISSAO] [numeric](15, 2) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_FINANCEIROAPOLICE] PRIMARY KEY CLUSTERED 
(
	[IDFINANAPOLICE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEGURADO]    Script Date: 04/09/2020 12:24:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEGURADO](
	[IDSEGURADO] [int] NOT NULL,
	[NOMESEGURADO] [varchar](100) NOT NULL,
	[DTNASC] [datetime] NOT NULL,
	[CPF] [varchar](11) NOT NULL,
 CONSTRAINT [PK_SEGURADO] PRIMARY KEY CLUSTERED 
(
	[IDSEGURADO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOSEGURO]    Script Date: 04/09/2020 12:24:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOSEGURO](
	[IDTIPOSEGURO] [int] NOT NULL,
	[DS_TIPOSEGURO] [varchar](400) NOT NULL,
	[CARENCIA] [int] NOT NULL,
 CONSTRAINT [PK_TIPOSEGURO] PRIMARY KEY CLUSTERED 
(
	[IDTIPOSEGURO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[APOLICE]  WITH CHECK ADD  CONSTRAINT [FK_APOLICE_SEGURADO] FOREIGN KEY([IDSEGURADO])
REFERENCES [dbo].[SEGURADO] ([IDSEGURADO])
GO
ALTER TABLE [dbo].[APOLICE] CHECK CONSTRAINT [FK_APOLICE_SEGURADO]
GO
ALTER TABLE [dbo].[APOLICE]  WITH CHECK ADD  CONSTRAINT [FK_APOLICE_TIPOSEGURO] FOREIGN KEY([IDTIPOSEGURO])
REFERENCES [dbo].[TIPOSEGURO] ([IDTIPOSEGURO])
GO
ALTER TABLE [dbo].[APOLICE] CHECK CONSTRAINT [FK_APOLICE_TIPOSEGURO]
GO
ALTER TABLE [dbo].[FINANCEIROAPOLICE]  WITH CHECK ADD  CONSTRAINT [FK_FINANCEIROAPOLICE_APOLICE] FOREIGN KEY([IDAPOLICE])
REFERENCES [dbo].[APOLICE] ([IDAPOLICE])
GO
ALTER TABLE [dbo].[FINANCEIROAPOLICE] CHECK CONSTRAINT [FK_FINANCEIROAPOLICE_APOLICE]
GO
USE [master]
GO
ALTER DATABASE [ProvaVibe_00] SET  READ_WRITE 
GO
