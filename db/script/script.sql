--IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Wagner')
--BEGIN
    --CREATE DATABASE Wagner;
--END

USE [Wagner];

IF NOT EXISTS (SELECT schema_name FROM information_schema.schemata WHERE schema_name = 'Banking')
BEGIN
    EXEC('CREATE SCHEMA Banking AUTHORIZATION dbo');
END

IF NOT EXISTS (SELECT * FROM information_schema.tables WHERE table_name = 'Users' AND table_schema = 'Banking')
BEGIN
	CREATE TABLE Banking.Users
	(
		Id NVARCHAR(255) NOT NULL,
		Name NVARCHAR(50) NOT NULL,
		LastName NVARCHAR(50) NOT NULL,
		Email NVARCHAR(50) NOT NULL,
		RFC NVARCHAR(20) NOT NULL,
		PasswordHash NVARCHAR(255) NOT NULL,
		Role INT NOT NULL,
		IsActive BIT NOT NULL,
		CreatedAt DATETIME NOT NULL,
		LastUpdatedAt DATETIME
	)
	ALTER TABLE Banking.Users
		ADD CONSTRAINT [PK_Users_Id] PRIMARY KEY ([Id])
		
	CREATE NONCLUSTERED INDEX IX_Users_Name_LastName
		ON Banking.Users ([Name], [LastName])
		
	CREATE NONCLUSTERED INDEX IX_Users_Email
		ON Banking.Users ([Email])
		
	CREATE NONCLUSTERED INDEX IX_Users_RFC
		ON Banking.Users ([RFC])
END


/***
DECLARE @PageNumber INT = 1
DECLARE @PageSize INT = 100
DECLARE @Search NVARCHAR(100) = 'duckman'
    SELECT * 
    FROM Users
    WHERE ISNULL(UserName,'') LIKE '%' + @Search + '%' 
       OR ISNULL(Email,'') LIKE '%' + @Search + '%' 
       OR ISNULL(Role,'') LIKE '%' + @Search + '%'
    ORDER BY UserName
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;

    SELECT COUNT(*) AS TotalCount 
    FROM Users
    WHERE ISNULL(UserName,'') LIKE '%' + @Search + '%' 
       OR ISNULL(Email,'') LIKE '%' + @Search + '%' 
       OR ISNULL(Role,'') LIKE '%' + @Search + '%';


SELECT * FROM Banking.Users
SELECT COUNT(*) FROM Banking.Users
SELECT COUNT(*) FROM Clientes 
TRUNCATE TABLE Banking.Users

EXEC sp_helpfile;
**/
