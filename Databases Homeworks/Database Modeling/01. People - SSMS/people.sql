USE [master]
GO
/****** Object:  Database [People]    Script Date: 4.10.2015 г. 14:36:35 ******/
CREATE DATABASE [People]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'People', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\People.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'People_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\People_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [People] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [People].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [People] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [People] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [People] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [People] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [People] SET ARITHABORT OFF 
GO
ALTER DATABASE [People] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [People] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [People] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [People] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [People] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [People] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [People] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [People] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [People] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [People] SET  DISABLE_BROKER 
GO
ALTER DATABASE [People] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [People] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [People] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [People] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [People] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [People] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [People] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [People] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [People] SET  MULTI_USER 
GO
ALTER DATABASE [People] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [People] SET DB_CHAINING OFF 
GO
ALTER DATABASE [People] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [People] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [People] SET DELAYED_DURABILITY = DISABLED 
GO
USE [People]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 4.10.2015 г. 14:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AddressText] [ntext] NULL,
	[TownId] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continent]    Script Date: 4.10.2015 г. 14:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Continent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 4.10.2015 г. 14:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[ContinentId] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 4.10.2015 г. 14:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Town]    Script Date: 4.10.2015 г. 14:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([Id], [AddressText], [TownId]) VALUES (1, N'Aleksandar Malinov 31', 1)
INSERT [dbo].[Address] ([Id], [AddressText], [TownId]) VALUES (2, N'California, OC', 2)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Continent] ON 

INSERT [dbo].[Continent] ([Id], [Name]) VALUES (1, N'Europe')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (2, N'North America')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (3, N'South America')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (4, N'Africa')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (5, N'Asia')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (6, N'Australia')
INSERT [dbo].[Continent] ([Id], [Name]) VALUES (7, N'Antarctica')
SET IDENTITY_INSERT [dbo].[Continent] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([Id], [Name], [ContinentId]) VALUES (1, N'Bulgaria', 1)
INSERT [dbo].[Country] ([Id], [Name], [ContinentId]) VALUES (2, N'USA', 2)
INSERT [dbo].[Country] ([Id], [Name], [ContinentId]) VALUES (3, N'Brazil', 3)
INSERT [dbo].[Country] ([Id], [Name], [ContinentId]) VALUES (4, N'Egypt', 4)
INSERT [dbo].[Country] ([Id], [Name], [ContinentId]) VALUES (5, N'China', 5)
INSERT [dbo].[Country] ([Id], [Name], [ContinentId]) VALUES (6, N'Australia', 6)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [AddressId]) VALUES (2, N'George', N'Lucas', 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [AddressId]) VALUES (3, N'Nikolay', N'Kostov', 1)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (2, N'New York', 2)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (4, N'Rio de Janeiro', 3)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (5, N'Cairo', 4)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (6, N'Beijing', 5)
INSERT [dbo].[Town] ([Id], [Name], [CountryId]) VALUES (7, N'Sidney', 6)
SET IDENTITY_INSERT [dbo].[Town] OFF
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Town] FOREIGN KEY([TownId])
REFERENCES [dbo].[Town] ([Id])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Town]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continent] FOREIGN KEY([ContinentId])
REFERENCES [dbo].[Continent] ([Id])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continent]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Address]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [People] SET  READ_WRITE 
GO
