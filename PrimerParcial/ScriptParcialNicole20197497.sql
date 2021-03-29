USE [master]
GO
/****** Object:  Database [Manejo_condominio]    Script Date: 01/06/2020 13:49:59 ******/
CREATE DATABASE [Manejo_condominio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Manejo_condominio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Manejo_condominio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Manejo_condominio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Manejo_condominio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Manejo_condominio] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Manejo_condominio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Manejo_condominio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Manejo_condominio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Manejo_condominio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Manejo_condominio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Manejo_condominio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Manejo_condominio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Manejo_condominio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Manejo_condominio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Manejo_condominio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Manejo_condominio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Manejo_condominio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Manejo_condominio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Manejo_condominio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Manejo_condominio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Manejo_condominio] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Manejo_condominio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Manejo_condominio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Manejo_condominio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Manejo_condominio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Manejo_condominio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Manejo_condominio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Manejo_condominio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Manejo_condominio] SET RECOVERY FULL 
GO
ALTER DATABASE [Manejo_condominio] SET  MULTI_USER 
GO
ALTER DATABASE [Manejo_condominio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Manejo_condominio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Manejo_condominio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Manejo_condominio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Manejo_condominio] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Manejo_condominio', N'ON'
GO
ALTER DATABASE [Manejo_condominio] SET QUERY_STORE = OFF
GO
USE [Manejo_condominio]
GO
/****** Object:  Table [dbo].[Apartament]    Script Date: 01/06/2020 13:50:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apartament](
	[id_apartamento] [int] IDENTITY(1,1) NOT NULL,
	[Apartamento] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_apartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[condomine]    Script Date: 01/06/2020 13:50:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[condomine](
	[id_persona] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](20) NULL,
	[nombre] [varchar](50) NULL,
	[manzana] [int] NULL,
	[edificio] [int] NULL,
	[apartamento] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Edificio]    Script Date: 01/06/2020 13:50:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Edificio](
	[id_edificio] [int] IDENTITY(1,1) NOT NULL,
	[Edificio] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_edificio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manzana]    Script Date: 01/06/2020 13:50:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manzana](
	[id_manzana] [int] IDENTITY(1,1) NOT NULL,
	[Manzana] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_manzana] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Apartament] ON 
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (1, N'402')
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (2, N'102')
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (3, N'201')
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (4, N'401')
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (5, N'301')
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (6, N'302')
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (7, N'401')
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (8, N'402')
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (9, N'300')
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (10, N'302')
GO
INSERT [dbo].[Apartament] ([id_apartamento], [Apartamento]) VALUES (11, N'500')
GO
SET IDENTITY_INSERT [dbo].[Apartament] OFF
GO
SET IDENTITY_INSERT [dbo].[condomine] ON 
GO
INSERT [dbo].[condomine] ([id_persona], [cedula], [nombre], [manzana], [edificio], [apartamento]) VALUES (1, N'1071', N'Nicole', 1, 1, 2)
GO
INSERT [dbo].[condomine] ([id_persona], [cedula], [nombre], [manzana], [edificio], [apartamento]) VALUES (2, N'5601', N'Marie', 2, 3, 6)
GO
INSERT [dbo].[condomine] ([id_persona], [cedula], [nombre], [manzana], [edificio], [apartamento]) VALUES (3, N'5245', N'Sara', 3, 4, 7)
GO
SET IDENTITY_INSERT [dbo].[condomine] OFF
GO
SET IDENTITY_INSERT [dbo].[Edificio] ON 
GO
INSERT [dbo].[Edificio] ([id_edificio], [Edificio]) VALUES (1, N'1A')
GO
INSERT [dbo].[Edificio] ([id_edificio], [Edificio]) VALUES (2, N'2B')
GO
INSERT [dbo].[Edificio] ([id_edificio], [Edificio]) VALUES (3, N'3B')
GO
INSERT [dbo].[Edificio] ([id_edificio], [Edificio]) VALUES (4, N'4A')
GO
INSERT [dbo].[Edificio] ([id_edificio], [Edificio]) VALUES (5, N'2A')
GO
INSERT [dbo].[Edificio] ([id_edificio], [Edificio]) VALUES (6, N'3B')
GO
INSERT [dbo].[Edificio] ([id_edificio], [Edificio]) VALUES (7, N'7A')
GO
SET IDENTITY_INSERT [dbo].[Edificio] OFF
GO
SET IDENTITY_INSERT [dbo].[Manzana] ON 
GO
INSERT [dbo].[Manzana] ([id_manzana], [Manzana]) VALUES (1, N'2A')
GO
INSERT [dbo].[Manzana] ([id_manzana], [Manzana]) VALUES (2, N'1B')
GO
INSERT [dbo].[Manzana] ([id_manzana], [Manzana]) VALUES (3, N'3C')
GO
INSERT [dbo].[Manzana] ([id_manzana], [Manzana]) VALUES (5, N'5F')
GO
INSERT [dbo].[Manzana] ([id_manzana], [Manzana]) VALUES (6, N'1N')
GO
SET IDENTITY_INSERT [dbo].[Manzana] OFF
GO
ALTER TABLE [dbo].[condomine]  WITH CHECK ADD FOREIGN KEY([apartamento])
REFERENCES [dbo].[Apartament] ([id_apartamento])
GO
ALTER TABLE [dbo].[condomine]  WITH CHECK ADD FOREIGN KEY([edificio])
REFERENCES [dbo].[Edificio] ([id_edificio])
GO
ALTER TABLE [dbo].[condomine]  WITH CHECK ADD FOREIGN KEY([manzana])
REFERENCES [dbo].[Manzana] ([id_manzana])
GO
/****** Object:  StoredProcedure [dbo].[actApa]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actApa]
@act varchar(50),
@viej varchar (50)
as begin
update Apartament set Apartamento= @act
where Apartamento =@viej
end
GO
/****** Object:  StoredProcedure [dbo].[actEdi]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actEdi]
@act varchar(50),
@vij varchar (50)
as begin
update Edificio set [Edificio]= @act 
where [Edificio] = @vij
end 
GO
/****** Object:  StoredProcedure [dbo].[actMan]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actMan]
@act varchar(50),
@vij varchar (50)
as begin
update Manzana set [Manzana]= @act 
where Manzana = @vij
end 
GO
/****** Object:  StoredProcedure [dbo].[actu]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actu] 
@cedula NVARCHAR(50),
@nombre NVARCHAR(50),
@manzana int,
@edificio int,
@apart int
as 
begin
update condomine set nombre =@nombre, manzana = @manzana, edificio =@edificio, apartamento=@apart
where [cedula]= @cedula
end
GO
/****** Object:  StoredProcedure [dbo].[BorrarHabi]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BorrarHabi] @Borrar varchar(50)
as
begin
delete from condomine where cedula = @Borrar
end
GO
/****** Object:  StoredProcedure [dbo].[BusquedaEdi]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BusquedaEdi] @Busque varchar(50)
as
begin
select Con.Nombre, Con.Cedula, Man.Manzana,Edif.Edificio, Apa.Apartamento
from condomine as Con
inner join Manzana as Man 
on Con.manzana =[id_manzana]
join Edificio as edif
on Con.edificio =[id_edificio]
join Apartament as apa
on Con.apartamento =[id_apartamento]
where Edif.Edificio = @Busque
end
GO
/****** Object:  StoredProcedure [dbo].[BusquedaMan]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BusquedaMan] @Busque varchar(50)
as
begin
select Con.Nombre, Con.Cedula, Man.Manzana,Edif.Edificio, Apa.Apartamento
from condomine as Con
inner join Manzana as Man 
on Con.manzana =[id_manzana]
join Edificio as edif
on Con.edificio =[id_edificio]
join Apartament as apa
on Con.apartamento =[id_apartamento]
where Man.Manzana = @Busque
end
GO
/****** Object:  StoredProcedure [dbo].[Cargar]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Cargar]
as
begin
select Con.Nombre, Con.Cedula, Man.Manzana,Edif.Edificio, Apa.Apartamento
from condomine as Con
inner join Manzana as Man 
on Con.manzana =[id_manzana]
join Edificio as edif
on Con.edificio =[id_edificio]
join Apartament as apa
on Con.apartamento =[id_apartamento]
end
GO
/****** Object:  StoredProcedure [dbo].[InsApa]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsApa]
@agregar varchar(50)
as begin
insert into Apartament values (@agregar)
end 
GO
/****** Object:  StoredProcedure [dbo].[InsEdi]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsEdi]
@agregar varchar(50)
as begin
insert into Edificio values (@agregar)
end 
GO
/****** Object:  StoredProcedure [dbo].[insertar]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[insertar]
@cedula NVARCHAR(25),
@nombre NVARCHAR(65),
@manzana int,
@edificio int,
@apart int
as
insert into condomine values(@cedula,@nombre,@manzana,@edificio,@apart)
GO
/****** Object:  StoredProcedure [dbo].[InsMan]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsMan]
@agregar varchar(50)
as 
begin
insert into Manzana values (@agregar)
end 
GO
/****** Object:  StoredProcedure [dbo].[leer]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[leer] 
as begin
select * from Manzana 
select * from Edificio
select * from Apartament
end 
GO
/****** Object:  StoredProcedure [dbo].[leerm]    Script Date: 01/06/2020 13:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[leerm]
as begin
select m.manzana, e.edificio, a.apartamento
from Manzana as m 
join edificio as e
on id_manzana= id_edificio
join Apartament as a
on id_edificio= id_apartamento
end
GO
USE [master]
GO
ALTER DATABASE [Manejo_condominio] SET  READ_WRITE 
GO
