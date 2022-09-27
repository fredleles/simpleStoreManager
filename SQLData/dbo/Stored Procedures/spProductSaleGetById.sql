CREATE PROCEDURE [dbo].[spProductSaleGetById]
	@SaleId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT p.ProductName, sp.Quantity, sp.PurchasePrice
	FROM dbo.SaleProduct AS sp
	JOIN dbo.Product AS p ON p.Id = sp.ProductId
	WHERE sp.SaleId = @SaleId;
END;
