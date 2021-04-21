CREATE TABLE [dbo].[Cars] (
    [Id]          INT            NOT NULL,
	[CarName]     NCHAR(15)      NOT NULL,
    [BrandId]     INT            NOT NULL,
    [ColorId]     INT            NOT NULL,
    [ModelYear]   NCHAR (10)     NOT NULL,
    [DailyPrice]  DECIMAL (18)   NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

