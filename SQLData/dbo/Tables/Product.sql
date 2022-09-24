CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(100) NOT NULL, 
    [Barcode] NVARCHAR(100), 
    [Description] NVARCHAR(MAX), 
    [RetailPrice] MONEY NOT NULL, 
    [QuantityInStock] INT NOT NULL DEFAULT 1,
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [LastModified] DATETIME2 NOT NULL DEFAULT getutcdate(),
    [ProductImage] NVARCHAR(500) NULL
)
