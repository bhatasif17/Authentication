# Authentication

Create table.

CREATE TABLE [dbo].[Students] (
    [ID]      UNIQUEIDENTIFIER NOT NULL,
    [Name]    VARCHAR (50)     NULL,
    [Address] VARCHAR (100)    NULL,
    [Email]   VARCHAR (50)     NULL,
    [AddedBy] VARCHAR (50)     NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);
