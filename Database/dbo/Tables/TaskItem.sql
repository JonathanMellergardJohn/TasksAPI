CREATE TABLE [dbo].[TaskItem]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(50) NOT NULL,
	[IsCompleted] BIT NOT NULL,
	[Latitude] DECIMAL(18,10) NULL,
	[Longitude] DECIMAL(18,10) NULL,
	[ListId] INT NOT NULL,
	FOREIGN KEY ([ListId]) REFERENCES [dbo].[List]([Id])
);
