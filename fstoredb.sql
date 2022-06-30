USE [FStoreDB]
GO
DROP TABLE IF EXISTS [OrderDetail];
DROP TABLE IF EXISTS [Order];
DROP TABLE IF EXISTS [Member];
DROP TABLE IF EXISTS [Product];
GO
CREATE TABLE [Member](
	[MemberId] int IDENTITY(1, 1) PRIMARY KEY,
	[Email] VARCHAR(100),
	[CompanyName] VARCHAR(40),
	[City] VARCHAR(15),
	[Country] VARCHAR(15),
	[Password] VARCHAR(30),
);
GO
CREATE TABLE [Order](
	[OrderId] int IDENTITY(1, 1) PRIMARY KEY,
	[MemberId] int FOREIGN KEY REFERENCES [Member]([MemberId]),
	[OrderDate] datetime,
	[RequiredDate] datetime,
	[ShippedDate] datetime,
	[Freight] money,
);
GO
CREATE TABLE [Product](
	[ProductId] int IDENTITY(1, 1) PRIMARY KEY,
	[CategoryId] int,
	[ProductName] VARCHAR(40),
	[Weight] VARCHAR(20),
	[UnitPrice] money,
	[UnitsInStock] int,
);
GO
CREATE TABLE [OrderDetail](
	[OrderId] int FOREIGN KEY REFERENCES [Order]([OrderId]),
	[ProductId] int FOREIGN KEY REFERENCES [Product]([ProductId]),
	[UnitPrice] money,
	[Quantity] int,
	[Discount] float,
);