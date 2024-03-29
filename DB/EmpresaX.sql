USE [master]
GO
/****** Object:  Database [Biblioteca]    Script Date: 8/3/2019 12:13:24 PM ******/
CREATE DATABASE [Biblioteca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Biblioteca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Biblioteca.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Biblioteca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Biblioteca_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Biblioteca] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Biblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Biblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Biblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Biblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Biblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Biblioteca] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Biblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Biblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Biblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Biblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Biblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Biblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Biblioteca] SET RECOVERY FULL 
GO
ALTER DATABASE [Biblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [Biblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Biblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Biblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Biblioteca] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Biblioteca] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Biblioteca', N'ON'
GO
ALTER DATABASE [Biblioteca] SET QUERY_STORE = OFF
GO
USE [Biblioteca]
GO
/****** Object:  Table [dbo].[Alumno_Mstr]    Script Date: 8/3/2019 12:13:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno_Mstr](
	[Alumno_ID] [int] IDENTITY(1,1) NOT NULL,
	[Alumno_Matricula] [varchar](50) NOT NULL,
	[Alumno_Nombre] [varchar](50) NOT NULL,
	[Alumno_Apellido] [varchar](50) NOT NULL,
	[Alumno_Email] [varchar](50) NOT NULL,
	[Alumno_Telefono] [varchar](50) NOT NULL,
	[Alumno_Estado] [bit] NULL,
 CONSTRAINT [PK_Alumno_Mstr] PRIMARY KEY CLUSTERED 
(
	[Alumno_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Autor_Mstr]    Script Date: 8/3/2019 12:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autor_Mstr](
	[Autor_ID] [int] NOT NULL,
	[Autor_Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Autor_Mstr] PRIMARY KEY CLUSTERED 
(
	[Autor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero_Mstr]    Script Date: 8/3/2019 12:13:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero_Mstr](
	[Genero_ID] [int] NOT NULL,
	[Genero_Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Genero_Mstr] PRIMARY KEY CLUSTERED 
(
	[Genero_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libro_Mstr]    Script Date: 8/3/2019 12:13:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro_Mstr](
	[Libro_ID] [int] NOT NULL,
	[Libro_ISBN] [varchar](50) NOT NULL,
	[Libro_Titulo] [varchar](50) NOT NULL,
	[Autor_ID] [int] NOT NULL,
	[Libro_Estado] [bit] NOT NULL,
	[Genero_ID] [int] NOT NULL,
 CONSTRAINT [PK_Libro_Mstr] PRIMARY KEY CLUSTERED 
(
	[Libro_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Multa_Mstr]    Script Date: 8/3/2019 12:13:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Multa_Mstr](
	[Multa_ID] [int] NOT NULL,
	[Multa_Estado] [bit] NOT NULL,
	[Multa_Monto] [int] NOT NULL,
	[Alumno_ID] [int] NOT NULL,
	[Libro_Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Multa_Mstr] PRIMARY KEY CLUSTERED 
(
	[Multa_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reporte_Mstr]    Script Date: 8/3/2019 12:13:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reporte_Mstr](
	[Reporte_ID] [int] NOT NULL,
	[Alumno_ID] [int] NOT NULL,
	[Reporte_Entrega] [datetime] NOT NULL,
	[Reporte_Devolucion] [datetime] NOT NULL,
	[Reporte_Estado] [bit] NOT NULL,
	[Multa_ID] [int] NOT NULL,
 CONSTRAINT [PK_Reporte_Mstr] PRIMARY KEY CLUSTERED 
(
	[Reporte_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReporteDetalle_Mstr]    Script Date: 8/3/2019 12:13:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReporteDetalle_Mstr](
	[Reporte_ID] [int] NOT NULL,
	[Libro_ID] [int] NOT NULL,
	[Reporte_Libro] [varchar](50) NOT NULL,
	[Reporte_Autor] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ReporteDetalle_Mstr] PRIMARY KEY CLUSTERED 
(
	[Reporte_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Mstr]    Script Date: 8/3/2019 12:13:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Mstr](
	[Usuario_ID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario_Nombre] [varchar](50) NULL,
	[Usuario_Apellido] [varchar](50) NULL,
	[Usuario_NombreUsuario] [varchar](50) NULL,
	[Usuario_Contraseña] [varchar](50) NULL,
	[Usuario_Email] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario_Mstr] PRIMARY KEY CLUSTERED 
(
	[Usuario_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Libro_Mstr]  WITH CHECK ADD  CONSTRAINT [FK_Libro_Mstr_Autor_Mstr] FOREIGN KEY([Autor_ID])
REFERENCES [dbo].[Autor_Mstr] ([Autor_ID])
GO
ALTER TABLE [dbo].[Libro_Mstr] CHECK CONSTRAINT [FK_Libro_Mstr_Autor_Mstr]
GO
ALTER TABLE [dbo].[Libro_Mstr]  WITH CHECK ADD  CONSTRAINT [FK_Libro_Mstr_Genero_Mstr] FOREIGN KEY([Genero_ID])
REFERENCES [dbo].[Genero_Mstr] ([Genero_ID])
GO
ALTER TABLE [dbo].[Libro_Mstr] CHECK CONSTRAINT [FK_Libro_Mstr_Genero_Mstr]
GO
ALTER TABLE [dbo].[Multa_Mstr]  WITH CHECK ADD  CONSTRAINT [FK_Multa_Mstr_Alumno_Mstr] FOREIGN KEY([Alumno_ID])
REFERENCES [dbo].[Alumno_Mstr] ([Alumno_ID])
GO
ALTER TABLE [dbo].[Multa_Mstr] CHECK CONSTRAINT [FK_Multa_Mstr_Alumno_Mstr]
GO
ALTER TABLE [dbo].[Reporte_Mstr]  WITH CHECK ADD  CONSTRAINT [FK_Reporte_Mstr_Alumno_Mstr] FOREIGN KEY([Alumno_ID])
REFERENCES [dbo].[Alumno_Mstr] ([Alumno_ID])
GO
ALTER TABLE [dbo].[Reporte_Mstr] CHECK CONSTRAINT [FK_Reporte_Mstr_Alumno_Mstr]
GO
ALTER TABLE [dbo].[Reporte_Mstr]  WITH CHECK ADD  CONSTRAINT [FK_Reporte_Mstr_Multa_Mstr] FOREIGN KEY([Multa_ID])
REFERENCES [dbo].[Multa_Mstr] ([Multa_ID])
GO
ALTER TABLE [dbo].[Reporte_Mstr] CHECK CONSTRAINT [FK_Reporte_Mstr_Multa_Mstr]
GO
ALTER TABLE [dbo].[Reporte_Mstr]  WITH CHECK ADD  CONSTRAINT [FK_Reporte_Mstr_ReporteDetalle_Mstr] FOREIGN KEY([Reporte_ID])
REFERENCES [dbo].[ReporteDetalle_Mstr] ([Reporte_ID])
GO
ALTER TABLE [dbo].[Reporte_Mstr] CHECK CONSTRAINT [FK_Reporte_Mstr_ReporteDetalle_Mstr]
GO
USE [master]
GO
ALTER DATABASE [Biblioteca] SET  READ_WRITE 
GO
