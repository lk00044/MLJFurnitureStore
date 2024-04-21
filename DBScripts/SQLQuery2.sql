IF NOT EXISTS(SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'cs6232-g4') 
BEGIN
CREATE DATABASE [cs6232-g4];
END
GO

USE [cs6232-g4];
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

DROP TABLE IF EXISTS dbo.ReturnLineItem
DROP TABLE IF EXISTS dbo.RentalLineItem
DROP TABLE IF EXISTS dbo.Furniture
DROP TABLE IF EXISTS dbo.Style
DROP TABLE IF EXISTS dbo.Category
DROP TABLE IF EXISTS dbo.RentalTransaction
DROP TABLE IF EXISTS dbo.Employee
DROP TABLE IF EXISTS dbo.Login
DROP TABLE IF EXISTS dbo.StoreMember
DROP TABLE IF EXISTS dbo.ReturnTransaction


CREATE TABLE [dbo].Login(
	[user_id] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
	CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED ([user_id] ASC),
)

CREATE TABLE [dbo].[Employee](
	[employee_id] [int] NOT NULL IDENTITY(1,1),
	[login_userID] [varchar](20) NOT NULL,
	[employee_type] [varchar](15) NOT NULL,
	[date_of_birth] [date],
	[fname] [varchar](25),
	[lname] [varchar](25),
	[phone] [char](12),
	[address1] [varchar](25),
	[address2] [varchar](25),
	[city] [varchar](25),
	[state] [char](2),
	[zip] [varchar](10),
	[gender] [char](1),
	CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([employee_id] ASC ),
    CONSTRAINT [FK_Employee_Login] FOREIGN KEY ([login_userID]) REFERENCES [dbo].[Login] ([user_id])
	)

CREATE TABLE [dbo].[StoreMember](
	[member_id] [int] NOT NULL IDENTITY(1,1),
	[date_of_birth] [date],
	[fname] [varchar](25),
	[lname] [varchar](25),
	[phone] [char](10),
	[address1] [varchar](25),
	[address2] [varchar](25),
	[city] [varchar](25),
	[state] [char](2),
	[zip] [varchar](10),
	[gender] [char](1),
	CONSTRAINT [PK_StoreMember] PRIMARY KEY CLUSTERED ([member_id] ASC), 
)

CREATE TABLE [dbo].[Style](
	[style_name] [varchar](20) NOT NULL,
	CONSTRAINT [PK_Style] PRIMARY KEY CLUSTERED ([style_name] )
)

CREATE TABLE [dbo].[Category](
	[category_name] [varchar](20) NOT NULL,
	CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([category_name] )
)

CREATE TABLE [dbo].[Furniture](
	[furniture_id] [int] NOT NULL IDENTITY(1,1),
	[name] [varchar](45) NOT NULL,
	[description] [varchar](300) NOT NULL,
	[daily_rental_rate] [decimal](6,2) NOT NULL,
	[instock_quantity] [int] NOT NULL,
	[total_quantity] [int] NOT NULL,
	[category_name] [varchar](20) NOT NULL,
	[style_name] [varchar](20) NOT NULL,
	CONSTRAINT [PK_Furniture] PRIMARY KEY CLUSTERED ([furniture_id] ASC),
	CONSTRAINT [FK_Furniture_Style] FOREIGN KEY ([style_name]) REFERENCES [dbo].[Style] ([style_name]),
	CONSTRAINT [FK_Furniture_Category] FOREIGN KEY ([category_name]) REFERENCES [dbo].[Category] ([category_name]),
)

CREATE TABLE [dbo].[RentalTransaction](
	[transaction_id] [int] NOT NULL IDENTITY(1,1),
	[transaction_date] [datetime] NOT NULL,
	[member_id] [int] NOT NULL,
	[employee_id] [int] NOT NULL,
	[total_amount] [decimal](12,2) NOT NULL,
	[due_date] [datetime] NOT NULL,
	CONSTRAINT [PK_RentalTransaction] PRIMARY KEY CLUSTERED ([transaction_id] ASC),
	CONSTRAINT [FK_RentalTransaction_Employee] FOREIGN KEY ([employee_id]) REFERENCES [dbo].[Employee] ([employee_id]),
	CONSTRAINT [FK_RentalTransaction_StoreMember] FOREIGN KEY ([member_id]) REFERENCES [dbo].[StoreMember] ([member_id])
)

CREATE TABLE [dbo].[RentalLineItem](
	[line_item_id] [int] NOT NULL IDENTITY(1,1),
	[rental_transaction_id] [int] NOT NULL,
	[furniture_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[subtotal] [decimal](12,2) NOT NULL,
	CONSTRAINT [PK_RentalLineItem] PRIMARY KEY CLUSTERED ([line_item_id] ASC),
	CONSTRAINT [FK_RentalLineItem_RentalTransaction] FOREIGN KEY ([rental_transaction_id]) REFERENCES [dbo].[RentalTransaction] ([transaction_id]),
	CONSTRAINT [FK_RentalLineItem_Furniture] FOREIGN KEY ([furniture_id]) REFERENCES [dbo].[Furniture] ([furniture_id]),
)

CREATE TABLE [dbo].[ReturnTransaction](
	[return_transaction_id] [int] NOT NULL IDENTITY(1,1),
	[fine_or_refund] [decimal](12,2),
	[return_date] [datetime] NOT NULL,
	CONSTRAINT [PK_ReturnTransaction] PRIMARY KEY CLUSTERED ([return_transaction_id] )
)

CREATE TABLE [dbo].[ReturnLineItem](
	[line_item_id] [int] NOT NULL,
	[return_transaction_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	CONSTRAINT [PK_ReturnLineItem] PRIMARY KEY CLUSTERED ([line_item_id] ,[return_transaction_id] ),
	CONSTRAINT [FK_ReturnLineItem_RentalLineItem] FOREIGN KEY ([line_item_id]) REFERENCES [dbo].[RentalLineItem] ([line_item_id]),
	CONSTRAINT [FK_ReturnLineItem_ReturnTransaction] FOREIGN KEY ([return_transaction_id]) REFERENCES [dbo].[ReturnTransaction] ([return_transaction_id]),
)


GO
SET ANSI_PADDING OFF
GO

INSERT [dbo].[Login] ([user_id], [password]) VALUES ('mikhail01','1234'), ('laskey01', '1234'), ('keller01', '1234'), ('admin', '1234');

INSERT INTO [dbo].[Employee] VALUES ('mikhail01','regular','06-27-1992','Jonathan','Mikhail','9995551212','123 Main St.','','Anywhere','WA','12345','M'),
				('laskey01','regular','03-12-1989','LM','Laskey','9995551212','123 Main St.','','Anywhere','AL','12345',''),
				('keller01','regular','01-03-1970','Leslie','Keller','9995551212','123 Main St.','Apt 8','Anywhere','NC','12345','F'),
				('admin','admin','10-18-1979','Admin','lname','9995551212','123 Main St.','','Anywhere','GA','','');

INSERT [dbo].[StoreMember] VALUES ('06-27-1992','Joe','Smith','9995551212','123 Main St.','','Anywhere','IL','12345','M'),
				('02-19-1987','Ashish','Patel','9995551212','123 Main St.','','Anywhere','OR','12345','N'),
				('07-21-1992','Jane','Li','9995551212','123 Main St.','','Anywhere','MN','12345','F');

INSERT INTO [dbo].[Style] VALUES ('MidCentury Modern'), ('Modern'), ('Traditional'), ('Contemporary');

INSERT INTO [dbo].[Category] VALUES ('LRChair'), ('DRChair'), ('Sofa'), ('DiningSet');

INSERT INTO [dbo].[Furniture] VALUES ('Chair1','Accent your living area with the mid-century allure of this Lounge Chair.', 1.5, 30, 30, 'LRChair','MidCentury Modern');
INSERT INTO [dbo].[Furniture] VALUES ('Sofa1','Accent your living area with the mid-century allure of this Sofa.', 2.5, 10, 10, 'Sofa','MidCentury Modern');
INSERT INTO [dbo].[Furniture] VALUES ('Sofa2','Sporting clean lines and sleek track arms, this sofa has a contemporary profile.', 1.99, 8, 8, 'Sofa', 'Contemporary');
INSERT INTO [dbo].[Furniture] VALUES ('Chair2','With its back-to-nature sensibility, this dining room side chair is a natural fit.', 1.25, 25, 25, 'DRChair', 'Modern');
INSERT INTO [dbo].[Furniture] VALUES ('Dining01','This modern counter-height table and barstool ensemble will highlight your dining', 2.25, 5, 5, 'DiningSet', 'Modern');
INSERT INTO [dbo].[Furniture] VALUES ('Dining02','This dining package adds an air of playful simplicity to your dining space', 2.25, 5, 5, 'DiningSet', 'MidCentury Modern');
