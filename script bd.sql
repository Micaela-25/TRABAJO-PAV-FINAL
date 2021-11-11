USE [master]
GO
/****** Object:  Database [Trabajo_Practico_PAV]    Script Date: 11/11/2021 17:10:20 ******/
CREATE DATABASE [Trabajo_Practico_PAV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Trabajo_Practico_PAV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Trabajo_Practico_PAV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Trabajo_Practico_PAV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Trabajo_Practico_PAV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Trabajo_Practico_PAV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET ARITHABORT OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET  MULTI_USER 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET QUERY_STORE = OFF
GO
USE [Trabajo_Practico_PAV]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 11/11/2021 17:10:20 ******/
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
/****** Object:  Table [dbo].[DetalleVentas]    Script Date: 11/11/2021 17:10:20 ******/
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
/****** Object:  Table [dbo].[Forma_Pago]    Script Date: 11/11/2021 17:10:20 ******/
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
/****** Object:  Table [dbo].[PrendasRopa]    Script Date: 11/11/2021 17:10:20 ******/
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
/****** Object:  Table [dbo].[Talle]    Script Date: 11/11/2021 17:10:20 ******/
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
/****** Object:  Table [dbo].[TipoDoc]    Script Date: 11/11/2021 17:10:20 ******/
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
/****** Object:  Table [dbo].[TipoPrenda]    Script Date: 11/11/2021 17:10:20 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/11/2021 17:10:20 ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 11/11/2021 17:10:20 ******/
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
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (1, N'Micaela', N'Ardiles', 6, 43143, N'wsqw', 448, 0)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (2, N'Micaela', N'Ardiles', 6, 43143860, N'wsqw', 4825672, 0)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (3, N'Micaela', N'Ardiles', 6, 43143860, N'micardiles@hotmail.com', 4825672, 0)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (5, N'MICA', N'ARDILES', 6, 6555555, N'MICA@HOTMAIL', 4646546, 0)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (7, N'Micaela', N'Ardiles', 6, 43143860, N'wsqw', 4825672, 0)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (13, N'Micaela', N'Ardiles', 6, 43143860, N'wsqw', 4825672, 0)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (14, N'Micaela', N'Ardiles', 6, 43143860, N'wsqw', 4825672, 0)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (16, N'Micaela', N'Ardiles', 6, 43143860, N'wsqw', 4825672, 0)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (17, N'Micaela', N'Ardiles', 6, 43143860, N'wsqw', 4825672, 0)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (29, N'Nacho', N'Avila', 4, 4314, N'nacho@mail', 351, 0)
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Id_Tipo_Doc], [NroDoc], [Mail], [NroTelefono], [Borrado]) VALUES (30, N'Nacho', N'Avila', 1, 43143852, N'nacho@hotmail.com', 3513083852, 0)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (4, 24, 500, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (8, 25, 600, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (11, 24, 500, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (12, 25, 600, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (13, 25, 600, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (14, 24, 500, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (14, 25, 600, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (15, 24, 1000, 2, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (16, 24, 1000, 2, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (16, 25, 1200, 2, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (17, 25, 600, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (18, 25, 600, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (19, 25, 600, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (24, 25, 600, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (25, 25, 600, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (26, 25, 0, 0, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (27, 26, 1780, 2, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (28, 26, 890, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (29, 26, 890, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (30, 24, 500, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (31, 28, 1120, 2, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (32, 31, 4450, 5, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (33, 32, 2010, 3, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (34, 33, 5460, 7, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (35, 25, 3920, 4, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (35, 27, 456, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (35, 29, 456, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (36, 24, 500, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (36, 27, 456, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (36, 29, 912, 2, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (37, 25, 1960, 2, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (37, 29, 456, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (38, 25, 3920, 4, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (38, 32, 2010, 3, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (38, 33, 1560, 2, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (39, 30, 6880, 8, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (39, 33, 3900, 5, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (40, 31, 4450, 5, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (40, 32, 2010, 3, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (40, 33, 3120, 4, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (41, 27, 1824, 4, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (41, 33, 2340, 3, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (42, 32, 670, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (42, 33, 1560, 2, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (43, 32, 670, 1, 0)
INSERT [dbo].[DetalleVentas] ([NroTicket], [CodigoPrenda], [Subtotal], [Cantidad], [Anulado]) VALUES (43, 33, 1560, 2, 0)
GO
SET IDENTITY_INSERT [dbo].[Forma_Pago] ON 

INSERT [dbo].[Forma_Pago] ([Id_Forma], [Nombre], [Descripción]) VALUES (1, N'Efectivo', N'Moneda')
INSERT [dbo].[Forma_Pago] ([Id_Forma], [Nombre], [Descripción]) VALUES (2, N'Tarjeta', N'Débito o Crédito')
SET IDENTITY_INSERT [dbo].[Forma_Pago] OFF
GO
SET IDENTITY_INSERT [dbo].[PrendasRopa] ON 

INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (24, 25, N'Mangas Cortas', N'Remi', 500, 0, N'Rosa', N'Gucci', 0, 0, 2)
INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (25, 25, N'Corta', N'Remeruli', 980, 16, N'Blanca', N'LV', 0, 16, 2)
INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (26, 26, N'Grueso', N'London', 759, 0, N'negro', N'Nike', 0, 0, 2)
INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (27, 25, N'Pupera', N'Pupi', 456, 15, N'Rosa', N'LV', 0, 15, 2)
INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (28, 26, N'Grande', N'Buzi', 560, 20, N'Marrón', N'Nike', 0, 1, 2)
INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (29, 25, N'Mangas cortas', N'Musculosa', 456, 25, N'rosa', N'Nina', 0, 1, 2)
INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (30, 26, N'Enorme', N'Buzo', 860, 43, N'Negro', N'Nina', 0, 43, 3)
INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (31, 28, N'Cuadriculada', N'Camisa night', 890, 47, N'Negra', N'Nine', 0, 47, 2)
INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (32, 29, N'Playero ', N'Sombrero beach', 670, 5, N'Marrón', N'Parilo', 0, 5, 1)
INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (33, 27, N'Animal Print', N'Pant print', 780, 42, N'Rosa', N'Lola', 0, 42, 4)
INSERT [dbo].[PrendasRopa] ([CodigoPrenda], [IdTipoPrenda], [Descripción], [Nombre], [PrecioUnitario], [CantidadStock], [Color], [Marca], [Borrado], [StockActual], [Id_Talle]) VALUES (34, 29, N'Con flores', N'Sombrero paraguayo', 489, 52, N'Rosa', N'NJ', 0, 9, 3)
SET IDENTITY_INSERT [dbo].[PrendasRopa] OFF
GO
SET IDENTITY_INSERT [dbo].[Talle] ON 

INSERT [dbo].[Talle] ([Id_Talle], [Nombre], [Descripción]) VALUES (1, N'S', N'Small')
INSERT [dbo].[Talle] ([Id_Talle], [Nombre], [Descripción]) VALUES (2, N'M', N'Medium')
INSERT [dbo].[Talle] ([Id_Talle], [Nombre], [Descripción]) VALUES (3, N'L', N'Large')
INSERT [dbo].[Talle] ([Id_Talle], [Nombre], [Descripción]) VALUES (4, N'XL', N'Extra Large')
INSERT [dbo].[Talle] ([Id_Talle], [Nombre], [Descripción]) VALUES (5, N'XS', N'Extra Small')
SET IDENTITY_INSERT [dbo].[Talle] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoDoc] ON 

INSERT [dbo].[TipoDoc] ([Id_Tipo_Doc], [Nombre], [Descripción], [Borrado]) VALUES (1, N'DNI', N'Identidad', 0)
INSERT [dbo].[TipoDoc] ([Id_Tipo_Doc], [Nombre], [Descripción], [Borrado]) VALUES (2, N'Pasaporte', N'Viaje', 1)
INSERT [dbo].[TipoDoc] ([Id_Tipo_Doc], [Nombre], [Descripción], [Borrado]) VALUES (3, N'Libreta Estudiantil', N'Facultad', 1)
INSERT [dbo].[TipoDoc] ([Id_Tipo_Doc], [Nombre], [Descripción], [Borrado]) VALUES (4, N'Carnet', N'Para viajar', 0)
INSERT [dbo].[TipoDoc] ([Id_Tipo_Doc], [Nombre], [Descripción], [Borrado]) VALUES (5, N'Libreta', N'Facultad', 0)
INSERT [dbo].[TipoDoc] ([Id_Tipo_Doc], [Nombre], [Descripción], [Borrado]) VALUES (6, N'VISA', N'Identidad', 0)
INSERT [dbo].[TipoDoc] ([Id_Tipo_Doc], [Nombre], [Descripción], [Borrado]) VALUES (7, N'Pasaporte italiano', N'Ciudadanía', 0)
SET IDENTITY_INSERT [dbo].[TipoDoc] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoPrenda] ON 

INSERT [dbo].[TipoPrenda] ([IdTipoPrenda], [Nombre], [Descripción], [Borrado]) VALUES (25, N'Remera', N'Larga', 0)
INSERT [dbo].[TipoPrenda] ([IdTipoPrenda], [Nombre], [Descripción], [Borrado]) VALUES (26, N'Buzo', N'Grande', 0)
INSERT [dbo].[TipoPrenda] ([IdTipoPrenda], [Nombre], [Descripción], [Borrado]) VALUES (27, N'Pantalón', N'Largo ancho', 0)
INSERT [dbo].[TipoPrenda] ([IdTipoPrenda], [Nombre], [Descripción], [Borrado]) VALUES (28, N'Camisa', N'De vestir', 0)
INSERT [dbo].[TipoPrenda] ([IdTipoPrenda], [Nombre], [Descripción], [Borrado]) VALUES (29, N'Sombrero', N'Para playa', 0)
INSERT [dbo].[TipoPrenda] ([IdTipoPrenda], [Nombre], [Descripción], [Borrado]) VALUES (30, N'Pasaporte italiano', N'Ciudadania', 1)
SET IDENTITY_INSERT [dbo].[TipoPrenda] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (32, N'ma', N'456', N'Vendedor', 1)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (33, N'mica', N'123', N'Vendedor', 1)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (34, N'napio', N'456', N'Administrador', 1)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (35, N'mama', N'123', N'Administrador', 1)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (36, N'laura', N'123', N'Administrador', 1)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (37, N'ale', N'123', N'Vendedor', 0)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (38, N'maria', N'123', N'Vendedor', 0)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (39, N'paz', N'123', N'Administrador', 0)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (40, N'Alba', N'123', N'Administrador', 0)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (41, N'primor', N'4823770', N'Administrador', 0)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (42, N'Facundo', N'456', N'Administrador', 0)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (43, N'Luana', N'456', N'Vendedor', 0)
INSERT [dbo].[Usuarios] ([Id_Usuario], [NombreUsuario], [Contraseña], [Rol], [Borrado]) VALUES (44, N'Alejandra', N'123', N'Vendedor', 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (1, 40, CAST(N'2021-10-18T16:51:00.000' AS DateTime), 500, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (2, 40, CAST(N'2021-10-18T16:51:00.000' AS DateTime), 500, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (3, 40, CAST(N'2021-10-18T16:51:00.000' AS DateTime), 500, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (4, 40, CAST(N'2021-10-18T16:51:00.000' AS DateTime), 500, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (5, 40, CAST(N'2021-10-18T16:51:00.000' AS DateTime), 500, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (6, 40, CAST(N'2021-10-18T16:51:00.000' AS DateTime), 500, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (7, 40, CAST(N'2021-10-18T17:12:00.000' AS DateTime), 500, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (8, 40, CAST(N'2021-10-18T17:56:23.000' AS DateTime), 600, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (10, 40, CAST(N'2021-10-18T18:06:49.000' AS DateTime), 500, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (11, 40, CAST(N'2021-10-18T18:08:29.000' AS DateTime), 500, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (12, 40, CAST(N'2021-10-18T18:10:59.000' AS DateTime), 600, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (13, 40, CAST(N'2021-10-18T18:19:36.000' AS DateTime), 600, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (14, 40, CAST(N'2021-10-18T19:08:27.000' AS DateTime), 1100, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (15, 40, CAST(N'2021-10-18T19:22:58.000' AS DateTime), 1000, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (16, 40, CAST(N'2021-10-18T19:33:41.000' AS DateTime), 2200, 30, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (17, 40, CAST(N'2021-10-18T19:36:02.000' AS DateTime), 600, 2, NULL, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (18, 40, CAST(N'2021-10-18T20:39:48.000' AS DateTime), 600, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (19, 40, CAST(N'2021-10-18T21:18:40.000' AS DateTime), 600, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (24, 40, CAST(N'2021-10-18T21:32:51.000' AS DateTime), 600, 2, 2, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (25, 40, CAST(N'2021-10-18T21:33:59.000' AS DateTime), 600, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (26, 40, CAST(N'2021-10-18T21:39:27.000' AS DateTime), 600, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (27, 40, CAST(N'2021-10-19T00:40:48.000' AS DateTime), 890, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (28, 40, CAST(N'2021-10-19T02:47:16.000' AS DateTime), 890, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (29, 40, CAST(N'2021-10-20T08:14:04.000' AS DateTime), 890, 2, 2, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (30, 40, CAST(N'2021-10-20T09:21:42.000' AS DateTime), 500, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (31, 40, CAST(N'2021-11-01T19:47:54.000' AS DateTime), 1120, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (32, 40, CAST(N'2021-11-01T19:53:22.000' AS DateTime), 4450, 2, 2, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (33, 40, CAST(N'2021-11-01T19:53:42.000' AS DateTime), 2010, 2, 2, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (34, 40, CAST(N'2021-11-01T19:54:28.000' AS DateTime), 5460, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (35, 40, CAST(N'2021-11-03T00:42:37.000' AS DateTime), 4832, 2, 2, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (36, 40, CAST(N'2021-11-03T00:44:54.000' AS DateTime), 1868, 2, 2, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (37, 44, CAST(N'2021-11-03T00:58:21.000' AS DateTime), 2416, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (38, 44, CAST(N'2021-11-03T01:00:06.000' AS DateTime), 7490, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (39, 44, CAST(N'2021-11-03T01:00:34.000' AS DateTime), 10780, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (40, 42, CAST(N'2021-11-03T01:01:29.000' AS DateTime), 9580, 2, 2, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (41, 42, CAST(N'2021-11-03T08:06:24.000' AS DateTime), 4164, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (42, 42, CAST(N'2021-11-03T08:09:36.000' AS DateTime), 2230, 2, 1, 0)
INSERT [dbo].[Ventas] ([NroTicket], [Id_usuario], [Fecha], [Total], [Id_cliente], [Id_Forma_Pago], [Anulado]) VALUES (43, 40, CAST(N'2021-11-03T08:32:23.000' AS DateTime), 2230, 2, 1, 0)
SET IDENTITY_INSERT [dbo].[Ventas] OFF
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
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_TIPODOC]    Script Date: 11/11/2021 17:10:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_TIPODOC]	@nombre varchar(50),	@descripcion varchar(max),	@bajas intASBEGIN	SELECT * FROM TipoDoc 	WHERE	(@bajas = 1 OR (@bajas = 0 AND Borrado = 0))	AND (@descripcion is null OR (Descripción like '%' + @descripcion + '%' ))	AND (@nombre is null OR (Nombre like '%' + @nombre + '%' ))END

GO
USE [master]
GO
ALTER DATABASE [Trabajo_Practico_PAV] SET  READ_WRITE 
GO
