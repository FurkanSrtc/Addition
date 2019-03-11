Create Database AdditionDatabase
Go
Use AdditionDatabase
Go
Create Table Categories
(
	Id Int Primary Key Identity,
	CategoryName Varchar(50)
)
Go
Create Table Products
(
	Id Int Primary Key Identity,
	ProductName Varchar(50),
	UnitPrice Money,
	UnitsInStock Int,
	CategoryId Int,
	Constraint FK_Products_CategoryId
	Foreign Key(CategoryId)
	References Categories(Id)
)
Go
Create Table Waiters
(
	Id Int Primary Key Identity,
	FirstName Varchar(50),
	LastName Varchar(50),
	UserName Varchar(50),
	Password Varchar(50)
)
Go
Create Table Desks
(
	Id Int Primary Key Identity,
	DeskName varchar(50)
)
Go
Create Table ProductsOfDesks
(
	Id Int Primary Key Identity,
	DeskId Int,
	ProductId Int,
	Quantity Int,
	WaiterId Int,
	ProcessDateTime Datetime,
	Constraint FK_ProductsOfDesks_WaiterId
	Foreign Key(WaiterId)
	References Waiters(Id),
	Constraint FK_ProductsOfDesks_ProductId
	Foreign Key(ProductId)
	References Products(Id),
	Constraint FK_ProductsOfDesks_DeskId
	Foreign Key(DeskId)
	References Desks(Id)
)