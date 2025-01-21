Create Database Ajax_CRUD;

USE Ajax_CRUD;

CREATE TABLE UserRegistration (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Age INT NOT NULL
);

INSERT INTO [dbo].[UserRegistration] (Name, Age) VALUES 
('Namra Pithwa', 22), 
('Sumit Chauhan', 20);

Select * from [dbo].[UserRegistration];

