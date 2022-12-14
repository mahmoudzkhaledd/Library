USE [master]
GO
/****** Object:  Database [Library]    Script Date: 9/21/2022 11:13:50 AM ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'E:\Projects\Library\Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 102400KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'E:\Projects\Library\Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Library] SET QUERY_STORE = OFF
GO
USE [Library]
GO
/****** Object:  User [mahmoud]    Script Date: 9/21/2022 11:13:50 AM ******/
CREATE USER [mahmoud] FOR LOGIN [mahmoud] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[id] [int] NOT NULL,
	[name] [nvarchar](250) NOT NULL,
	[Country_ID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[id] [int] NOT NULL,
	[name] [nvarchar](250) NOT NULL,
	[BooksNumber] [int] NOT NULL,
	[CatID] [int] NOT NULL,
	[authorID] [int] NOT NULL,
	[CountryID] [int] NOT NULL,
	[DarID] [int] NOT NULL,
	[subCat] [nvarchar](250) NOT NULL,
	[Date] [date] NOT NULL,
	[pageNumber] [int] NOT NULL,
	[PlaceID] [int] NOT NULL,
	[BookStat] [nvarchar](250) NOT NULL,
	[BookPrice] [real] NOT NULL,
	[Note] [text] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookPlace]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookPlace](
	[id] [int] NOT NULL,
	[name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_BookPlace] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BorrowBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BorrowBook](
	[id] [int] NOT NULL,
	[BorrowerID] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[BooksNumber] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[Note] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrowers]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrowers](
	[id] [int] NOT NULL,
	[name] [nvarchar](250) NOT NULL,
	[phone1] [nvarchar](250) NOT NULL,
	[phone2] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Borrowers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] NOT NULL,
	[name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[id] [int] NOT NULL,
	[name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dar]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dar](
	[id] [int] NOT NULL,
	[name] [nvarchar](250) NOT NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_Dar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Author]  WITH CHECK ADD  CONSTRAINT [FK_Author_Country] FOREIGN KEY([Country_ID])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Author] CHECK CONSTRAINT [FK_Author_Country]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_BookPlace] FOREIGN KEY([PlaceID])
REFERENCES [dbo].[BookPlace] ([id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_BookPlace]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Category] FOREIGN KEY([CatID])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Category]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Country]
GO
ALTER TABLE [dbo].[BorrowBook]  WITH CHECK ADD  CONSTRAINT [FK_BorrowBook_Book] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([id])
GO
ALTER TABLE [dbo].[BorrowBook] CHECK CONSTRAINT [FK_BorrowBook_Book]
GO
ALTER TABLE [dbo].[BorrowBook]  WITH CHECK ADD  CONSTRAINT [FK_BorrowBook_Borrowers] FOREIGN KEY([BorrowerID])
REFERENCES [dbo].[Borrowers] ([id])
GO
ALTER TABLE [dbo].[BorrowBook] CHECK CONSTRAINT [FK_BorrowBook_Borrowers]
GO
ALTER TABLE [dbo].[Dar]  WITH CHECK ADD  CONSTRAINT [FK_Dar_Country] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Dar] CHECK CONSTRAINT [FK_Dar_Country]
GO
/****** Object:  StoredProcedure [dbo].[BookByAuthor]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[BookByAuthor] @AuthorID int
As 
Select 
b.id as 'رقم الكتاب',
b.name as 'اسم الكتاب',
b.BooksNumber as 'عدد صفح الكتاب',
c.name as 'اسم التصنيف',
a.name as 'اسم المؤلف',
cc.name as 'اسم الدوله',
d.name as 'دار النشر',
b.subCat as 'التصنيف الفرعى',
b.Date as 'تاريخ النشر',
b.pageNumber as'عدد الصفح',
p.name as 'مكان الكتاب',
b.BookStat as 'حالة الكتاب',
b.BookPrice as 'السعر',
b.Note as 'ملاحظه'
From Book b join Category c on b.CatID = c.id 
join Author a on a.id = b.authorID 
join Country cc on cc.id = b.CountryID
join Dar d on b.DarID = d.id
join BookPlace p on p.id = b.PlaceID where b.AuthorID  = @AuthorID;
GO
/****** Object:  StoredProcedure [dbo].[BookByCat]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[BookByCat] @CatID int
As 
Select 
b.id as 'رقم الكتاب',
b.name as 'اسم الكتاب',
b.BooksNumber as 'عدد صفح الكتاب',
c.name as 'اسم التصنيف',
a.name as 'اسم المؤلف',
cc.name as 'اسم الدوله',
d.name as 'دار النشر',
b.subCat as 'التصنيف الفرعى',
b.Date as 'تاريخ النشر',
b.pageNumber as'عدد الصفح',
p.name as 'مكان الكتاب',
b.BookStat as 'حالة الكتاب',
b.BookPrice as 'السعر',
b.Note as 'ملاحظه'
From Book b join Category c on b.CatID = c.id 
join Author a on a.id = b.authorID 
join Country cc on cc.id = b.CountryID
join Dar d on b.DarID = d.id
join BookPlace p on p.id = b.PlaceID where b.CatID  = @CatID;
GO
/****** Object:  StoredProcedure [dbo].[BookByCountry]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[BookByCountry] @CountryID int
As 
Select 
b.id as 'رقم الكتاب',
b.name as 'اسم الكتاب',
b.BooksNumber as 'عدد صفح الكتاب',
c.name as 'اسم التصنيف',
a.name as 'اسم المؤلف',
cc.name as 'اسم الدوله',
d.name as 'دار النشر',
b.subCat as 'التصنيف الفرعى',
b.Date as 'تاريخ النشر',
b.pageNumber as'عدد الصفح',
p.name as 'مكان الكتاب',
b.BookStat as 'حالة الكتاب',
b.BookPrice as 'السعر',
b.Note as 'ملاحظه'
From Book b join Category c on b.CatID = c.id 
join Author a on a.id = b.authorID 
join Country cc on cc.id = b.CountryID
join Dar d on b.DarID = d.id
join BookPlace p on p.id = b.PlaceID where b.CountryID  = @CountryID;
GO
/****** Object:  StoredProcedure [dbo].[BookByDar]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[BookByDar] @DarID int
As 
Select 
b.id as 'رقم الكتاب',
b.name as 'اسم الكتاب',
b.BooksNumber as 'عدد صفح الكتاب',
c.name as 'اسم التصنيف',
a.name as 'اسم المؤلف',
cc.name as 'اسم الدوله',
d.name as 'دار النشر',
b.subCat as 'التصنيف الفرعى',
b.Date as 'تاريخ النشر',
b.pageNumber as'عدد الصفح',
p.name as 'مكان الكتاب',
b.BookStat as 'حالة الكتاب',
b.BookPrice as 'السعر',
b.Note as 'ملاحظه'
From Book b join Category c on b.CatID = c.id 
join Author a on a.id = b.authorID 
join Country cc on cc.id = b.CountryID
join Dar d on b.DarID = d.id
join BookPlace p on p.id = b.PlaceID where b.DarID  = @DarID;
GO
/****** Object:  StoredProcedure [dbo].[BookByName]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[BookByName] @name NvarChar(250)
As 
Select 
b.id as 'رقم الكتاب',
b.name as 'اسم الكتاب',
b.BooksNumber as 'عدد صفح الكتاب',
c.name as 'اسم التصنيف',
a.name as 'اسم المؤلف',
cc.name as 'اسم الدوله',
d.name as 'دار النشر',
b.subCat as 'التصنيف الفرعى',
b.Date as 'تاريخ النشر',
b.pageNumber as'عدد الصفح',
p.name as 'مكان الكتاب',
b.BookStat as 'حالة الكتاب',
b.BookPrice as 'السعر',
b.Note as 'ملاحظه'
From Book b join Category c on b.CatID = c.id 
join Author a on a.id = b.authorID 
join Country cc on cc.id = b.CountryID
join Dar d on b.DarID = d.id
join BookPlace p on p.id = b.PlaceID where b.name like '%@name%';
GO
/****** Object:  StoredProcedure [dbo].[BookByPlace]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[BookByPlace] @PlaceID int
As 
Select 
b.id as 'رقم الكتاب',
b.name as 'اسم الكتاب',
b.BooksNumber as 'عدد صفح الكتاب',
c.name as 'اسم التصنيف',
a.name as 'اسم المؤلف',
cc.name as 'اسم الدوله',
d.name as 'دار النشر',
b.subCat as 'التصنيف الفرعى',
b.Date as 'تاريخ النشر',
b.pageNumber as'عدد الصفح',
p.name as 'مكان الكتاب',
b.BookStat as 'حالة الكتاب',
b.BookPrice as 'السعر',
b.Note as 'ملاحظه'
From Book b join Category c on b.CatID = c.id 
join Author a on a.id = b.authorID 
join Country cc on cc.id = b.CountryID
join Dar d on b.DarID = d.id
join BookPlace p on p.id = b.PlaceID where b.PlaceID  = @PlaceID;
GO
/****** Object:  StoredProcedure [dbo].[DeleteAllAuthor]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[DeleteAllAuthor]
As
Delete from Author;
GO
/****** Object:  StoredProcedure [dbo].[DeleteAllBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteAllBook] 
As
Delete from Book;
GO
/****** Object:  StoredProcedure [dbo].[DeleteAllBookPlace]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[DeleteAllBookPlace]
As
Delete from BookPlace;
GO
/****** Object:  StoredProcedure [dbo].[DeleteAllBorrowBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[DeleteAllBorrowBook]
As
Delete from BorrowBook;
GO
/****** Object:  StoredProcedure [dbo].[DeleteAllCategory]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteAllCategory]
As
Delete from Category;
GO
/****** Object:  StoredProcedure [dbo].[DeleteAllCountry]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[DeleteAllCountry]
As
Delete from Country;
GO
/****** Object:  StoredProcedure [dbo].[DeleteAllDar]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteAllDar]
As
Delete from Dar;
GO
/****** Object:  StoredProcedure [dbo].[DeleteAuthor]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[DeleteAuthor] @id int
As
Delete from Author where id =@id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteBook] @id int
As
Delete from Book where id = @id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteBookPlace]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[DeleteBookPlace] @id int
As
Delete from BookPlace where id =@id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteBorrowBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteBorrowBook] @id int
As
Delete from BorrowBook where id =@id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteCategory]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteCategory] @id int
As
Delete from Category where id =@id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteCountry]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[DeleteCountry] @id int
As
Delete from Country where id =@id;
GO
/****** Object:  StoredProcedure [dbo].[DeleteDar]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteDar] @id int
As
Delete from Dar where id =@id;
GO
/****** Object:  StoredProcedure [dbo].[GetAllAuthor]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetAllAuthor]
As
select 
a.id as 'رقم المؤلف',
a.name as 'اسم المؤلف',
c.name as 'اسم الدوله',
a.Date as 'تاريخ المؤلف',
a.Country_ID
From Author a join Country c on a.Country_ID = c.id;
GO
/****** Object:  StoredProcedure [dbo].[GetAllBookPlace]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetAllBookPlace]
As
select 
id as 'رقم المكان',
name as 'اسم المكان'
From BookPlace ;
GO
/****** Object:  StoredProcedure [dbo].[GetAllBooks]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetAllBooks] 
As
Select 
b.id as 'رقم الكتاب',
b.name as 'اسم الكتاب',
b.BooksNumber as 'عدد صفح الكتاب',
c.name as 'اسم التصنيف',
a.name as 'اسم المؤلف',
cc.name as 'اسم الدوله',
d.name as 'دار النشر',
b.subCat as 'التصنيف الفرعى',
b.Date as 'تاريخ النشر',
b.pageNumber as'عدد الصفح',
p.name as 'مكان الكتاب',
b.BookStat as 'حالة الكتاب',
b.BookPrice as 'السعر',
b.Note as 'ملاحظه'
From Book b join Category c on b.CatID = c.id 
join Author a on a.id = b.authorID 
join Country cc on cc.id = b.CountryID
join Dar d on b.DarID = d.id
join BookPlace p on p.id = b.PlaceID;
GO
/****** Object:  StoredProcedure [dbo].[GetAllBorrowBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetAllBorrowBook]
As
select 
bb.id as 'رقم الاستعاره',
b.name as 'اسم المستعير',
book.name as 'اسم الكتاب',
bb.BooksNumber as 'عدد الكتب',
bb.StartDate as 'تاريخ الاستعاره',
bb.EndDate as 'تاريخ التسليم',
bb.Note as 'ملاحظه'
From BorrowBook bb join Borrowers b on bb.BorrowerID = b.id
join Book book on book.id = bb.BookId ;
GO
/****** Object:  StoredProcedure [dbo].[GetAllCategory]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetAllCategory]
As
select 
id as 'رقم التصنيف',
name as 'اسم التصنيف'
From Category ;
GO
/****** Object:  StoredProcedure [dbo].[GetAllCountry]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetAllCountry]
As
select 
id as 'رقم الدوله',
name as 'اسم الدوله'
From Country ;
GO
/****** Object:  StoredProcedure [dbo].[GetAllDar]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetAllDar]
As
select 
d.id as 'رقم دار النشر',
d.name as 'اسم الدار',
c.name as 'الدوله',
d.CountryID
From Dar d join Country c on d.CountryID = c.id;
GO
/****** Object:  StoredProcedure [dbo].[GetAuthorBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAuthorBook]
As
Select id,name from Author;
GO
/****** Object:  StoredProcedure [dbo].[GetBookByID]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBookByID] @id int
As
Select 
*
From Book where id = @id ;
GO
/****** Object:  StoredProcedure [dbo].[GetLastIDAuthor]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetLastIDAuthor]
As
select Max(id) from Author;
GO
/****** Object:  StoredProcedure [dbo].[GetLastIDBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetLastIDBook] 
As
Select Max(id) from Book;
GO
/****** Object:  StoredProcedure [dbo].[GetLastIDBookPlace]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetLastIDBookPlace]
As
select Max(id) from BookPlace;
GO
/****** Object:  StoredProcedure [dbo].[GetLastIDBorrowBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetLastIDBorrowBook]
As
select Max(id) from BorrowBook;
GO
/****** Object:  StoredProcedure [dbo].[GetLastIDCategory]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetLastIDCategory]
As
select Max(id) from Category;
GO
/****** Object:  StoredProcedure [dbo].[GetLastIDCountry]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetLastIDCountry]
As
select Max(id) from Country;
GO
/****** Object:  StoredProcedure [dbo].[GetLastIDDar]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetLastIDDar]
As
select Max(id) from Dar;
GO
/****** Object:  StoredProcedure [dbo].[InsertAuthor]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertAuthor] @id int ,@name NvarChar(250) ,@CountryID int ,@Date Date
As
Insert Author Values(@id ,@name ,@CountryID,@Date);
GO
/****** Object:  StoredProcedure [dbo].[InsertBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertBook] 
@id int, 
@name nvarchar(250),
@BooksNumber int,
@CatID int, 
@AuthorID int,
@CountryID int,
@DarID int, 
@SubCat nvarchar(250),
@Date Date, 
@PageNumber int,
@PlaceId int,
@BookStat nvarchar(250),
@BookPrice real,
@Note nvarchar(250)
As
insert Book Values(
@id , 
@name ,
@BooksNumber ,
@CatID , 
@AuthorID ,
@CountryID ,
@DarID , 
@SubCat ,
@Date , 
@PageNumber ,
@PlaceId ,
@BookStat ,
@BookPrice ,
@Note);
GO
/****** Object:  StoredProcedure [dbo].[InsertBookPlace]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertBookPlace] @id int ,@name NvarChar(250)
As
Insert BookPlace Values(@id ,@name);
GO
/****** Object:  StoredProcedure [dbo].[InsertBorrowBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertBorrowBook] 
@id int ,
@BorrowerID int,
@BookId int,
@BooksNumber int,
@StartDate date,
@EndDate date,
@Note text
As
Insert BorrowBook Values(@id  ,
@BorrowerID ,
@BookId ,
@BooksNumber ,
@StartDate ,
@EndDate ,
@Note );
GO
/****** Object:  StoredProcedure [dbo].[InsertCategory]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertCategory] @id int ,@name NvarChar(250)
As
Insert Category Values(@id ,@name);
GO
/****** Object:  StoredProcedure [dbo].[InsertCountry]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertCountry] @id int , @name NvarChar(250)
As
insert Country Values(@id ,@name);
GO
/****** Object:  StoredProcedure [dbo].[InsertDar]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertDar] @id int ,@name NvarChar(250) ,@CountryID int
As
Insert Dar Values(@id ,@name ,@CountryID);
GO
/****** Object:  StoredProcedure [dbo].[UpdateAuthor]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[UpdateAuthor] @id int ,@name NvarChar(250) ,@CountryID int ,@Date Date
As
Update Author set name = @name ,Country_ID = @CountryID , Date = @Date
where id = @id;
GO
/****** Object:  StoredProcedure [dbo].[UpdateBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[UpdateBook] 
@id int, 
@name nvarchar(250),
@BooksNumber int,
@CatID int, 
@AuthorID int,
@CountryID int,
@DarID int, 
@SubCat nvarchar(250),
@Date Date, 
@PageNumber int,
@PlaceId int,
@BookStat nvarchar(250),
@BookPrice real,
@Note nvarchar(250)
As
Update Book Set

name = @name ,
BooksNumber = @BooksNumber ,
CatID = @CatID , 
authorID =  @AuthorID ,
CountryID=@CountryID ,
DarID=@DarID , 
subCat=@SubCat ,
Date=@Date , 
pageNumber=@PageNumber ,
PlaceID=@PlaceId ,
BookStat=@BookStat ,
BookPrice=@BookPrice ,
Note=@Note where id =@id;
GO
/****** Object:  StoredProcedure [dbo].[UpdateBookPlace]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[UpdateBookPlace] @id int ,@name NvarChar(250)
As
Update BookPlace set name = @name where id = @id;
GO
/****** Object:  StoredProcedure [dbo].[UpdateBorrowBook]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[UpdateBorrowBook] 
@id int ,
@BorrowerID int,
@BookId int,
@BooksNumber int,
@StartDate date,
@EndDate date,
@Note text
As
Update BorrowBook Set

BorrowerID= @BorrowerID ,
BookId=@BookId ,
BooksNumber=@BooksNumber ,
StartDate=@StartDate ,
EndDate=@EndDate ,
Note=@Note where id = @id;
GO
/****** Object:  StoredProcedure [dbo].[UpdateCategory]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[UpdateCategory] @id int ,@name NvarChar(250)
As
Update Category set name = @name where id = @id;
GO
/****** Object:  StoredProcedure [dbo].[UpdateCountry]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[UpdateCountry] @id int ,@name NvarChar(250)
As
Update Country set name = @name where id = @id;
GO
/****** Object:  StoredProcedure [dbo].[UpdateDar]    Script Date: 9/21/2022 11:13:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[UpdateDar] @id int ,@name NvarChar(250) ,@CountryID int
As
Update Dar set name = @name , CountryID =@CountryID where id = @id;
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
