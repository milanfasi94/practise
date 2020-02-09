CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Price] FLOAT NOT NULL, 
    [Available] BIT NOT NULL
)
