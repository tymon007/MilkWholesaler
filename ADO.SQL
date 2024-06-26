USE [master]
GO
/****** Object:  Database [Milk_Wholesaler]    Script Date: 01.05.2024 12:58:35 ******/
CREATE DATABASE [Milk_Wholesaler]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Milk_Wholesaler', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Milk_Wholesaler.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Milk_Wholesaler_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Milk_Wholesaler_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Milk_Wholesaler] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Milk_Wholesaler].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Milk_Wholesaler] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET ARITHABORT OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Milk_Wholesaler] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Milk_Wholesaler] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Milk_Wholesaler] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Milk_Wholesaler] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET RECOVERY FULL 
GO
ALTER DATABASE [Milk_Wholesaler] SET  MULTI_USER 
GO
ALTER DATABASE [Milk_Wholesaler] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Milk_Wholesaler] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Milk_Wholesaler] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Milk_Wholesaler] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Milk_Wholesaler] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Milk_Wholesaler] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Milk_Wholesaler', N'ON'
GO
ALTER DATABASE [Milk_Wholesaler] SET QUERY_STORE = OFF
GO
USE [Milk_Wholesaler]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 01.05.2024 12:58:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[InventoryID] [int] NOT NULL,
	[ProductID] [int] NULL,
	[QuantityOnHand] [int] NULL,
	[ExpirationDate] [date] NULL,
	[ProductionDate] [date] NULL,
	[WarehouseLocation] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[InventoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 01.05.2024 12:58:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailID] [int] NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [decimal](10, 2) NULL,
	[TotalPrice] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 01.05.2024 12:58:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[OrderDate] [datetime] NULL,
	[SupplierID] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 01.05.2024 12:58:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
	[UnitPrice] [decimal](10, 2) NULL,
	[QuantityInStock] [int] NULL,
	[SupplierID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 01.05.2024 12:58:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] NOT NULL,
	[SupplierName] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[Phone] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[Address] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
USE [master]
GO
ALTER DATABASE [Milk_Wholesaler] SET  READ_WRITE 
GO
