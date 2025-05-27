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
	FOREIGN KEY (RoleID) References Roles(RoleID)
);

CREATE TABLE Roles
(
	RoleId int PRIMARY KEY,
	RoleName varchar NOT NULL
)
CREATE TABLE Menu(

	Items
	
	);



CREATE TABLE Refunds(
	RefundID int PRIMARY KEY IDENTITY(1,1),
	OrderID int NOT NULL,
	Reason text,
	Status varchar(20) default "Pending",
	RequestedDate datetime default GETDATE(),
	FOREIGN KEY (OrderID) references Orders(OrderID)
	);
