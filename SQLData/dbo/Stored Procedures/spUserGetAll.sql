CREATE PROCEDURE [dbo].[spUserGetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id, FirstName, LastName, EmailAddress, CreatedDate
	FROM [dbo].[User];
END
