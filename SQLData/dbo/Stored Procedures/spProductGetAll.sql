CREATE PROCEDURE [dbo].[spProductGetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, ProductName, Barcode, [Description], RetailPrice, QuantityInStock, ProductImage
	FROM dbo.Product
	ORDER BY ProductName;
END
