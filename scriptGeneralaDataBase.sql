USE [master]
GO
/****** Object:  Database [GeneralaDataBase]    Script Date: 21/06/2023 01:34:42 a. m. ******/
CREATE DATABASE [GeneralaDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GeneralaDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\GeneralaDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GeneralaDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\GeneralaDataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [GeneralaDataBase] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GeneralaDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GeneralaDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GeneralaDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GeneralaDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GeneralaDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GeneralaDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET RECOVERY FULL 
GO
ALTER DATABASE [GeneralaDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [GeneralaDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GeneralaDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GeneralaDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GeneralaDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GeneralaDataBase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GeneralaDataBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GeneralaDataBase', N'ON'
GO
ALTER DATABASE [GeneralaDataBase] SET QUERY_STORE = ON
GO
ALTER DATABASE [GeneralaDataBase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [GeneralaDataBase]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 21/06/2023 01:34:42 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NULL,
	[PartidasJugadas] [int] NULL,
	[PartidasGanadas] [int] NULL,
	[PartidasPerdidas] [int] NULL,
	[PuntajeTotal] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 21/06/2023 01:34:42 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Jugadores] ON 

INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (0, N'Kanthus', 2, 1, 1, 52)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (1, N'Maxiasdd', 1, 0, 1, 32)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (2, N'CeleVas', 6, 4, 2, 180)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (3, N'LucasModric', 1, 1, 0, 34)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (4, N'LeonelMessi', 2, 2, 0, 78)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (5, N'ElMasCapo202', 2, 2, 0, 111)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (6, N'BartS', 1, 1, 0, 60)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (7, N'WAZAA', 1, 0, 1, 23)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (8, N'Jamaica', 3, 2, 1, 116)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (9, N'Goku1234', 2, 0, 2, 43)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (10, N'Goku.com', 2, 1, 1, 62)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (11, N'PepeMarino', 1, 0, 1, 41)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (12, N'Lucifewr', 1, 0, 1, 30)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (13, N'Asta', 1, 0, 1, 42)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (14, N'NarutoSasuke', 3, 0, 3, 74)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (15, N'OMG123', 1, 0, 1, 20)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (16, N'SugarDady3', 1, 1, 0, 40)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (17, N'ñoño5', 1, 1, 0, 62)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (18, N'Feli233', 2, 1, 1, 87)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (19, N'CR7', 3, 0, 3, 81)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (20, N'Ñandyu12', 1, 0, 1, 20)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (21, N'MegMel', 1, 1, 0, 45)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (22, N'LuceroVp12', 1, 1, 0, 56)
INSERT [dbo].[Jugadores] ([Id], [Nombre], [PartidasJugadas], [PartidasGanadas], [PartidasPerdidas], [PuntajeTotal]) VALUES (23, N'jejeVegeta12', 1, 0, 1, 20)
SET IDENTITY_INSERT [dbo].[Jugadores] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [Nombre], [Apellido], [Correo], [Clave]) VALUES (1, N'Vasquez', N'Yober', N'yober@yober.com', N'yober12345')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
USE [master]
GO
ALTER DATABASE [GeneralaDataBase] SET  READ_WRITE 
GO
