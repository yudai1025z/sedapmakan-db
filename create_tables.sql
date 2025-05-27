CREATE DATABASE SedapMakanDB;
GO

USE SedapMakanDB;
GO
	
CREATE TABLE Userdata
(
	userID int PRIMARY KEY,
    userName varchar(50) NOT NULL,
	userPassword VARCHAR(20) NOT NULL,
    userRole varchar(50) NOT NULL
);

CREATE TABLE RoleName
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
