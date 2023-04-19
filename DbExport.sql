USE [master]
GO
/****** Object:  Database [tranngoc]    Script Date: 19.04.2023 13:12:59 ******/
CREATE DATABASE [tranngoc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tranngoc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\tranngoc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tranngoc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\tranngoc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [tranngoc] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tranngoc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tranngoc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tranngoc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tranngoc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tranngoc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tranngoc] SET ARITHABORT OFF 
GO
ALTER DATABASE [tranngoc] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [tranngoc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tranngoc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tranngoc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tranngoc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tranngoc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tranngoc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tranngoc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tranngoc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tranngoc] SET  ENABLE_BROKER 
GO
ALTER DATABASE [tranngoc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tranngoc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tranngoc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tranngoc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tranngoc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tranngoc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tranngoc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tranngoc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [tranngoc] SET  MULTI_USER 
GO
ALTER DATABASE [tranngoc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tranngoc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tranngoc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tranngoc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [tranngoc] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [tranngoc] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [tranngoc] SET QUERY_STORE = OFF
GO
USE [tranngoc]
GO
/****** Object:  Table [dbo].[comments]    Script Date: 19.04.2023 13:12:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comments](
	[comment_id] [int] IDENTITY(1,1) NOT NULL,
	[content] [nvarchar](max) NOT NULL,
	[date] [datetime] NOT NULL,
	[user_id] [int] NOT NULL,
	[task_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[comment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[projects]    Script Date: 19.04.2023 13:12:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projects](
	[project_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[deadline] [datetime] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[manager_id] [int] NOT NULL,
	[team_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[project_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 19.04.2023 13:12:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tasks]    Script Date: 19.04.2023 13:12:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tasks](
	[task_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[deadline] [datetime] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[user_id] [int] NOT NULL,
	[project_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[task_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teams]    Script Date: 19.04.2023 13:12:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teams](
	[team_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[team_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 19.04.2023 13:12:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[role_id] [int] NOT NULL,
	[team_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[comments] ON 
GO
INSERT [dbo].[comments] ([comment_id], [content], [date], [user_id], [task_id]) VALUES (1, N'test1', CAST(N'2023-04-19T13:08:09.523' AS DateTime), 2, 1)
GO
INSERT [dbo].[comments] ([comment_id], [content], [date], [user_id], [task_id]) VALUES (2, N'test2', CAST(N'2023-04-19T13:08:09.523' AS DateTime), 2, 1)
GO
INSERT [dbo].[comments] ([comment_id], [content], [date], [user_id], [task_id]) VALUES (3, N'test3', CAST(N'2023-04-19T13:08:09.523' AS DateTime), 2, 1)
GO
SET IDENTITY_INSERT [dbo].[comments] OFF
GO
SET IDENTITY_INSERT [dbo].[projects] ON 
GO
INSERT [dbo].[projects] ([project_id], [name], [description], [deadline], [status], [manager_id], [team_id]) VALUES (1, N'test', N'test', CAST(N'2023-03-20T00:00:00.000' AS DateTime), N'not done', 2, 2)
GO
SET IDENTITY_INSERT [dbo].[projects] OFF
GO
SET IDENTITY_INSERT [dbo].[roles] ON 
GO
INSERT [dbo].[roles] ([role_id], [name]) VALUES (1, N'admin')
GO
INSERT [dbo].[roles] ([role_id], [name]) VALUES (2, N'manager')
GO
INSERT [dbo].[roles] ([role_id], [name]) VALUES (3, N'employee')
GO
SET IDENTITY_INSERT [dbo].[roles] OFF
GO
SET IDENTITY_INSERT [dbo].[tasks] ON 
GO
INSERT [dbo].[tasks] ([task_id], [name], [description], [deadline], [status], [user_id], [project_id]) VALUES (1, N'task test', N'task test', CAST(N'2023-03-20T00:00:00.000' AS DateTime), N'not done', 3, 1)
GO
INSERT [dbo].[tasks] ([task_id], [name], [description], [deadline], [status], [user_id], [project_id]) VALUES (2, N'task test2', N'task test2', CAST(N'2023-04-20T00:00:00.000' AS DateTime), N'not done', 3, 1)
GO
INSERT [dbo].[tasks] ([task_id], [name], [description], [deadline], [status], [user_id], [project_id]) VALUES (3, N'task test3', N'task tes3t', CAST(N'2023-05-20T00:00:00.000' AS DateTime), N'not done', 3, 1)
GO
INSERT [dbo].[tasks] ([task_id], [name], [description], [deadline], [status], [user_id], [project_id]) VALUES (4, N'doe', N'task tes3t', CAST(N'2023-05-20T00:00:00.000' AS DateTime), N'not done', 2, 1)
GO
INSERT [dbo].[tasks] ([task_id], [name], [description], [deadline], [status], [user_id], [project_id]) VALUES (5, N'doe', N'task tes3t', CAST(N'2023-05-20T00:00:00.000' AS DateTime), N'not done', 2, 1)
GO
SET IDENTITY_INSERT [dbo].[tasks] OFF
GO
SET IDENTITY_INSERT [dbo].[teams] ON 
GO
INSERT [dbo].[teams] ([team_id], [name]) VALUES (1, N'admin')
GO
INSERT [dbo].[teams] ([team_id], [name]) VALUES (2, N'engineer')
GO
SET IDENTITY_INSERT [dbo].[teams] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 
GO
INSERT [dbo].[users] ([user_id], [first_name], [last_name], [username], [email], [password], [role_id], [team_id]) VALUES (1, N'admin', N'admin', N'admin', N'admin@gmail.com', N'admin', 1, 1)
GO
INSERT [dbo].[users] ([user_id], [first_name], [last_name], [username], [email], [password], [role_id], [team_id]) VALUES (2, N'John', N'Doe', N'doe', N'doe@gmail.com', N'doe', 2, 2)
GO
INSERT [dbo].[users] ([user_id], [first_name], [last_name], [username], [email], [password], [role_id], [team_id]) VALUES (3, N'Adam', N'Smith', N'smith', N'smith@gmail.com', N'smith', 3, 2)
GO
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[comments]  WITH CHECK ADD  CONSTRAINT [fk_comment_task] FOREIGN KEY([task_id])
REFERENCES [dbo].[tasks] ([task_id])
GO
ALTER TABLE [dbo].[comments] CHECK CONSTRAINT [fk_comment_task]
GO
ALTER TABLE [dbo].[comments]  WITH CHECK ADD  CONSTRAINT [fk_comment_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[comments] CHECK CONSTRAINT [fk_comment_user]
GO
ALTER TABLE [dbo].[projects]  WITH CHECK ADD  CONSTRAINT [fk_manager] FOREIGN KEY([manager_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[projects] CHECK CONSTRAINT [fk_manager]
GO
ALTER TABLE [dbo].[projects]  WITH CHECK ADD  CONSTRAINT [fk_project_team] FOREIGN KEY([team_id])
REFERENCES [dbo].[teams] ([team_id])
GO
ALTER TABLE [dbo].[projects] CHECK CONSTRAINT [fk_project_team]
GO
ALTER TABLE [dbo].[tasks]  WITH CHECK ADD  CONSTRAINT [fk_project] FOREIGN KEY([project_id])
REFERENCES [dbo].[projects] ([project_id])
GO
ALTER TABLE [dbo].[tasks] CHECK CONSTRAINT [fk_project]
GO
ALTER TABLE [dbo].[tasks]  WITH CHECK ADD  CONSTRAINT [fk_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[tasks] CHECK CONSTRAINT [fk_user]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [fk_role] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([role_id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [fk_role]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [fk_team] FOREIGN KEY([team_id])
REFERENCES [dbo].[teams] ([team_id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [fk_team]
GO
USE [master]
GO
ALTER DATABASE [tranngoc] SET  READ_WRITE 
GO
