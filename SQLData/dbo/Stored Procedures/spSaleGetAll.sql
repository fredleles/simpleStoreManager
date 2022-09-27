CREATE PROCEDURE [dbo].[spSaleGetAll]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT s.[Id] AS SaleId, u.EmailAddress AS [User], s.[Date], s.[Total]
	FROM dbo.Sale AS s
	JOIN dbo.[User] AS u ON u.Id = s.UserId
	ORDER BY [Date] DESC;
END
