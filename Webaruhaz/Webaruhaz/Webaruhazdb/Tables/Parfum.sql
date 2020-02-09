CREATE TABLE [dbo].[Parfum]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(20) NOT NULL, 
    [Price] FLOAT NOT NULL, 
    [Men] BIT NOT NULL, 
    [Akcios] BIT NULL, 
    [Akcioszazalek] INT NULL
)
