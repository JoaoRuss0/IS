CREATE TABLE [dbo].[Prods] (
    [Id]       INT             PRIMARY KEY		IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50)   NOT NULL,
    [Category] NVARCHAR (50)   NULL,
    [Price]    DECIMAL (18, 2) NULL,
);

