create database userdata;

CREATE TABLE Users 
(
    userName varchar(15) NOT NULL PRIMARY KEY,
	userPassword VARCHAR(255),
    userRole varchar(255)
);
