USE [master]
GO
/****** Object:  Database [Trabajo_Practico_PAV2]    Script Date: 12/11/2021 20:27:14 ******/
CREATE DATABASE [Trabajo_Practico_PAV2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Trabajo_Practico_PAV2', FILENAME = N'D:\Documents\Downloads\MSSQL15.SQLEXPRESS\MSSQL\DATA\Trabajo_Practico_PAV2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Trabajo_Practico_PAV2_log', FILENAME = N'D:\Documents\Downloads\MSSQL15.SQLEXPRESS\MSSQL\DATA\Trabajo_Practico_PAV2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Trabajo_Practico_PAV2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET  MULTI_USER 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET QUERY_STORE = OFF
GO
USE [Trabajo_Practico_PAV2]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 12/11/2021 20:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Id_Tipo_Doc] [int] NOT NULL,
	[NroDoc] [int] NULL,
	[Mail] [varchar](50) NOT NULL,
	[NroTelefono] [bigint] NULL,
	[Borrado] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVentas]    Script Date: 12/11/2021 20:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVentas](
	[NroTicket] [int] NOT NULL,
	[CodigoPrenda] [int] NOT NULL,
	[Subtotal] [float] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Anulado] [int] NULL,
 CONSTRAINT [PK_DetalleVentas] PRIMARY KEY CLUSTERED 
(
	[NroTicket] ASC,
	[CodigoPrenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Forma_Pago]    Script Date: 12/11/2021 20:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Forma_Pago](
	[Id_Forma] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripción] [varchar](max) NULL,
 CONSTRAINT [PK_Forma_Pago] PRIMARY KEY CLUSTERED 
(
	[Id_Forma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrendasRopa]    Script Date: 12/11/2021 20:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrendasRopa](
	[CodigoPrenda] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoPrenda] [int] NOT NULL,
	[Descripción] [varchar](max) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[PrecioUnitario] [float] NOT NULL,
	[CantidadStock] [int] NOT NULL,
	[Color] [varchar](50) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Borrado] [int] NULL,
	[StockActual] [int] NULL,
	[Id_Talle] [int] NULL,
 CONSTRAINT [PK_PrendasRopa] PRIMARY KEY CLUSTERED 
(
	[CodigoPrenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Talle]    Script Date: 12/11/2021 20:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Talle](
	[Id_Talle] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripción] [varchar](max) NULL,
 CONSTRAINT [PK_Talle] PRIMARY KEY CLUSTERED 
(
	[Id_Talle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDoc]    Script Date: 12/11/2021 20:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDoc](
	[Id_Tipo_Doc] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripción] [varchar](max) NULL,
	[Borrado] [int] NOT NULL,
 CONSTRAINT [PK_TipoDoc] PRIMARY KEY CLUSTERED 
(
	[Id_Tipo_Doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPrenda]    Script Date: 12/11/2021 20:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPrenda](
	[IdTipoPrenda] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripción] [varchar](max) NOT NULL,
	[Borrado] [int] NULL,
 CONSTRAINT [PK_TipoPrenda] PRIMARY KEY CLUSTERED 
(
	[IdTipoPrenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 12/11/2021 20:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Rol] [varchar](50) NULL,
	[Borrado] [int] NULL,
 CONSTRAINT [PK_Usuarios_1] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 12/11/2021 20:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[NroTicket] [int] IDENTITY(1,1) NOT NULL,
	[Id_usuario] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Total] [float] NOT NULL,
	[Id_cliente] [int] NOT NULL,
	[Id_Forma_Pago] [int] NULL,
	[Anulado] [int] NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[NroTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_TipoDoc] FOREIGN KEY([Id_Tipo_Doc])
REFERENCES [dbo].[TipoDoc] ([Id_Tipo_Doc])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_TipoDoc]
GO
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVentas_PrendasRopa] FOREIGN KEY([CodigoPrenda])
REFERENCES [dbo].[PrendasRopa] ([CodigoPrenda])
GO
ALTER TABLE [dbo].[DetalleVentas] CHECK CONSTRAINT [FK_DetalleVentas_PrendasRopa]
GO
ALTER TABLE [dbo].[DetalleVentas]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVentas_Ventas] FOREIGN KEY([NroTicket])
REFERENCES [dbo].[Ventas] ([NroTicket])
GO
ALTER TABLE [dbo].[DetalleVentas] CHECK CONSTRAINT [FK_DetalleVentas_Ventas]
GO
ALTER TABLE [dbo].[PrendasRopa]  WITH CHECK ADD  CONSTRAINT [FK_PrendasRopa_Talle] FOREIGN KEY([Id_Talle])
REFERENCES [dbo].[Talle] ([Id_Talle])
GO
ALTER TABLE [dbo].[PrendasRopa] CHECK CONSTRAINT [FK_PrendasRopa_Talle]
GO
ALTER TABLE [dbo].[PrendasRopa]  WITH CHECK ADD  CONSTRAINT [FK_PrendasRopa_TipoPrenda] FOREIGN KEY([IdTipoPrenda])
REFERENCES [dbo].[TipoPrenda] ([IdTipoPrenda])
GO
ALTER TABLE [dbo].[PrendasRopa] CHECK CONSTRAINT [FK_PrendasRopa_TipoPrenda]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[Clientes] ([Id_cliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Forma_Pago] FOREIGN KEY([Id_Forma_Pago])
REFERENCES [dbo].[Forma_Pago] ([Id_Forma])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Forma_Pago]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Usuarios] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[Usuarios] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Usuarios]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_TIPODOC]    Script Date: 12/11/2021 20:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_TIPODOC]
	@nombre varchar(50),
	@descripcion varchar(max),
	@bajas int


AS
BEGIN
	SELECT * FROM TipoDoc 
	WHERE
	(@bajas = 1 OR (@bajas = 0 AND Borrado = 0))
	AND (@descripcion is null OR (Descripción like '%' + @descripcion + '%' ))
	AND (@nombre is null OR (Nombre like '%' + @nombre + '%' ))

END

GO
USE [master]
GO
ALTER DATABASE [Trabajo_Practico_PAV2] SET  READ_WRITE 
GO
