CREATE TABLE [dbo].[Players] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (20) NOT NULL,
    [LastName]  VARCHAR (20) NOT NULL,
    [Email]     VARCHAR (50) NOT NULL,
    [Phone]     VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

