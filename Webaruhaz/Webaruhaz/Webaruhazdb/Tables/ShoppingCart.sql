CREATE TABLE [dbo].[ShoppingCart]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Created] DATE NOT NULL , 
    [Name] NCHAR(15) NOT NULL , 
    [osszeg] FLOAT NULL DEFAULT 0.0, 
    [itemID] INT NOT NULL DEFAULT 0, 
    [instanceID] NCHAR(36) NOT NULL 
)
