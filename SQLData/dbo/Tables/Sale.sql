﻿CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[UserId] NVARCHAR(128) NOT NULL,
	[Date] DATETIME2 NOT NULL DEFAULT getutcdate(),
	[Total] MONEY NOT NULL, 
    CONSTRAINT [FK_Sale_ToUser] FOREIGN KEY (UserId) REFERENCES [User](Id)
)