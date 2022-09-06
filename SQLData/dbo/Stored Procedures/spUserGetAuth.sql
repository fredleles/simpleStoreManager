CREATE PROCEDURE [dbo].[spUserGetAuth]
	@EmailAddress nvarchar(256),
	@Password nvarchar(128)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Id
	FROM [dbo].[User]
	WHERE EmailAddress = @EmailAddress AND [Password] = @Password;
END
