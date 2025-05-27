CREATE DATABASE SedapMakanDB;
GO

USE SedapMakanDB;
GO
	
CREATE TABLE Users
	(
	UserID int PRIMARY KEY IDENTITY(1,1),
	UserName varchar(50) NOT NULL,
	Password VARCHAR(20) NOT NULL UNIQUE,
	RoleID int NOT NULL,
	FOREIGN KEY (RoleID) References Roles(RoleID),
	);

CREATE TABLE Roles
	(
	RoleId int PRIMARY KEY IDENTITY(1,1),
	RoleName varchar NOT NULL,
	);

CREATE TABLE Menu(
	ItemsID int PRIMARY KEY IDENTITY(1,1),
	Name varchar(50) NOT NULL,
	Price DECIMAL(10,2) NOT NULL,--10 digits integers n 2 digits decimal--
	IsAvailable BIT default 1, --1 means yes,0 means no--
	);

CREATE TABLE Orders(
	OrderID int PRIMARY KEY IDENTITY(1,1),
	UserID int NOT NULL,
	OrderDate datetime default GETDATE(),
	Status varchar(20) default 'pendiing',
	FOREIGN KEY (UserID) References Users(UserID),
	);

CREATE TABLE OrderItems(
	OrderItemID int PRIMARY KEY IDENTITY(1,1),
	OrderID int NOT NULL,
	ItemsID int NOT NULL,
	Quantity  int NOT NULL,
	FOREIGN KEY (OrderID) References Orders(OrderID),
	FOREIGN KEY (ItemsID) References Menu(ItemsID),
	);

CREATE TABLE E-walletTransactions(
	TransactionID int PRIMARY KEY IDENTITY(1,1),
	UserID int NOT NULL,
	Type varchar(20) NOT NULL, --TopUp or Payment or Refund"
	Amount decimal(10,2) NOT NULL,
	TransactionDate datetime default GETDATE(),
	FOREIGN KEY (UserID) References Users(UserID),
	);

CREATE TABLE Feedbacks(
	FeedbackID int PRIMARY KEY IDENTITY(1,1),
	UserID int NOT NULL,
	Message text NOT NULL,
	Response text,
	SentDate datetime default GETDATE(),
	FOREIGN KEY (UserID) References Users(UserID),
	);

CREATE TABLE Refunds(
	RefundID int PRIMARY KEY IDENTITY(1,1),
	OrderID int NOT NULL,
	Reason text,
	Status varchar(20) default "Pending",
	RequestedDate datetime default GETDATE(),
	FOREIGN KEY (OrderID) references Orders(OrderID)
	);
