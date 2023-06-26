USE [master]
GO
/****** Object:  Database [GroupStudy]    Script Date: 6/26/2023 7:14:58 PM ******/
CREATE DATABASE [GroupStudy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GroupStudydata', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\GroupStudydata.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GroupStudydata_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\GroupStudydata_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [GroupStudy] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GroupStudy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GroupStudy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GroupStudy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GroupStudy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GroupStudy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GroupStudy] SET ARITHABORT OFF 
GO
ALTER DATABASE [GroupStudy] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GroupStudy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GroupStudy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GroupStudy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GroupStudy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GroupStudy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GroupStudy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GroupStudy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GroupStudy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GroupStudy] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GroupStudy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GroupStudy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GroupStudy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GroupStudy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GroupStudy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GroupStudy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GroupStudy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GroupStudy] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GroupStudy] SET  MULTI_USER 
GO
ALTER DATABASE [GroupStudy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GroupStudy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GroupStudy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GroupStudy] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GroupStudy] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GroupStudy] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GroupStudy] SET QUERY_STORE = ON
GO
ALTER DATABASE [GroupStudy] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [GroupStudy]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 6/26/2023 7:14:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[commentId] [int] IDENTITY(1,1) NOT NULL,
	[studyMaterialID] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[comment] [text] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[commentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 6/26/2023 7:14:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[groupId] [int] IDENTITY(1,1) NOT NULL,
	[subjectId] [varchar](10) NOT NULL,
	[size] [int] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[groupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participant]    Script Date: 6/26/2023 7:14:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participant](
	[userId] [int] NOT NULL,
	[groupId] [int] NOT NULL,
 CONSTRAINT [PK_Participant] PRIMARY KEY CLUSTERED 
(
	[userId] ASC,
	[groupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 6/26/2023 7:14:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [varchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slot]    Script Date: 6/26/2023 7:14:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slot](
	[slotId] [int] IDENTITY(1,1) NOT NULL,
	[groupId] [int] NULL,
	[slotIndex] [varchar](50) NULL,
	[slotName] [varchar](50) NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_Slot] PRIMARY KEY CLUSTERED 
(
	[slotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudyMaterial]    Script Date: 6/26/2023 7:14:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudyMaterial](
	[studyMaterialID] [int] IDENTITY(1,1) NOT NULL,
	[slotId] [int] NULL,
	[title] [varchar](50) NULL,
	[content] [text] NULL,
	[link] [varchar](100) NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_StudyMaterial] PRIMARY KEY CLUSTERED 
(
	[studyMaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 6/26/2023 7:14:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[subjectId] [varchar](10) NOT NULL,
	[subjectName] [varchar](50) NULL,
	[description] [text] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[subjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 6/26/2023 7:14:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[birthday] [date] NULL,
	[address] [varchar](50) NULL,
	[roleId] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (1, N'PRJ301', 10, 1)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (2, N'PRN211', 6, 0)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (3, N'PRJ301', 22, 1)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (4, N'PRJ301', 5, 0)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (5, N'PRJ301', 16, 1)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (6, N'PRN211', 8, 1)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (9, N'SWR302', 66, 1)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (10, N'SWP391', 25, 1)
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (1, 1)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (1, 2)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (1, 5)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (2, 2)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (2, 3)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (2, 5)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (3, 2)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (3, 3)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (3, 5)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (4, 2)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (4, 4)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (4, 5)
INSERT [dbo].[Participant] ([userId], [groupId]) VALUES (5, 2)
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([roleId], [roleName]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([roleId], [roleName]) VALUES (2, N'Student')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Slot] ON 

INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (1, 1, N'1', N'Course Introduction', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (2, 1, N'2', N'Introduction to .NET Platform with Visual Studio', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (3, 1, N'3', N'C Sharp Programming', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (4, 1, N'4', N'Object-Oriented Programming', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (5, 1, N'5', N'Collections and Generics', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (6, 4, N'1', N'Git & GitLab Guides', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (7, 4, N'2', N'Oracle Java Coding Standards', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (8, 4, N'3', N'Student Guides Document', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (9, 6, N'1', N'Basic Web Application, Servlet', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (10, 6, N'2', N'JDBC', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (11, 6, N'3', N'Java Server Pages', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (12, 6, N'4', N'MVC-Architecture', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (13, 6, N'5', N'Sesssion Management', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (14, 6, N'6', N'Expression Language', 1)
SET IDENTITY_INSERT [dbo].[Slot] OFF
GO
SET IDENTITY_INSERT [dbo].[StudyMaterial] ON 

INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (1, 9, N'1', N'Java Web ebook', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (2, 3, N'2', N'C Sharp ebook', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (3, 11, N'3', N'Web Development with Java Server Pages', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (4, 5, N'4', N'Java Generics', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (5, 2, N'5', N'Introducing .NET 4.0 With Visual Studio 2010', NULL, 1)
SET IDENTITY_INSERT [dbo].[StudyMaterial] OFF
GO
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'PRJ301', NULL, N'Java Web', 1)
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'PRN211', NULL, N'C Sharp Basic', 1)
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'SWP391', NULL, N'Mini Capstone', 1)
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'SWR302', NULL, N'Software Requirements', 1)
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'SWT301', NULL, N'Software Testing', 1)
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([userId], [username], [email], [password], [birthday], [address], [roleId]) VALUES (1, N'hieuht', N'hieuht@gmail.com', N'1', CAST(N'2008-11-11' AS Date), N'Long An', 2)
INSERT [dbo].[User] ([userId], [username], [email], [password], [birthday], [address], [roleId]) VALUES (2, N'quanntn', N'quanntn@gmail.com', N'1', CAST(N'1998-08-29' AS Date), N'HCM', 2)
INSERT [dbo].[User] ([userId], [username], [email], [password], [birthday], [address], [roleId]) VALUES (3, N'datbh', N'datbh@gmail.com', N'1', CAST(N'2005-07-02' AS Date), N'Vung Tau', 2)
INSERT [dbo].[User] ([userId], [username], [email], [password], [birthday], [address], [roleId]) VALUES (4, N'quocbn', N'quocbn@gmail.com', N'1', CAST(N'1996-01-15' AS Date), N'HCM', 2)
INSERT [dbo].[User] ([userId], [username], [email], [password], [birthday], [address], [roleId]) VALUES (5, N'admin', N'admin@gmail.com', N'1', CAST(N'2023-04-20' AS Date), NULL, 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_StudyMaterial] FOREIGN KEY([studyMaterialID])
REFERENCES [dbo].[StudyMaterial] ([studyMaterialID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_StudyMaterial]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_User]
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_Subject] FOREIGN KEY([subjectId])
REFERENCES [dbo].[Subject] ([subjectId])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_Subject]
GO
ALTER TABLE [dbo].[Participant]  WITH CHECK ADD  CONSTRAINT [FK_Participant_Group] FOREIGN KEY([groupId])
REFERENCES [dbo].[Group] ([groupId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Participant] CHECK CONSTRAINT [FK_Participant_Group]
GO
ALTER TABLE [dbo].[Participant]  WITH CHECK ADD  CONSTRAINT [FK_Participant_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Participant] CHECK CONSTRAINT [FK_Participant_User]
GO
ALTER TABLE [dbo].[Slot]  WITH CHECK ADD  CONSTRAINT [FK_Slot_Group] FOREIGN KEY([groupId])
REFERENCES [dbo].[Group] ([groupId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Slot] CHECK CONSTRAINT [FK_Slot_Group]
GO
ALTER TABLE [dbo].[StudyMaterial]  WITH CHECK ADD  CONSTRAINT [FK_StudyMaterial_Slot] FOREIGN KEY([slotId])
REFERENCES [dbo].[Slot] ([slotId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[StudyMaterial] CHECK CONSTRAINT [FK_StudyMaterial_Slot]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([roleId])
REFERENCES [dbo].[Role] ([roleId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [GroupStudy] SET  READ_WRITE 
GO
