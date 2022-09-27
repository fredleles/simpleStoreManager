CREATE TABLE [dbo].[SaleProduct]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SaleId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [Quantity] INT NOT NULL DEFAULT 1,
    [PurchasePrice] MONEY NOT NULL,
    CONSTRAINT [FK_SaleProduct_ToSale] FOREIGN KEY (SaleId) REFERENCES Sale(Id), 
    CONSTRAINT [FK_SaleProduct_ToProduct] FOREIGN KEY (ProductId) REFERENCES Product(Id)
)
