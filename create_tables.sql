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

CREATE TABLE ROLE
(
	RoleId int PRIMARY KEY,
	Role varchar NOT NULL
)
CREATE TABLE Menu(

	Items
	
	);
