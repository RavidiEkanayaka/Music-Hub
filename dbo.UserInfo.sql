CREATE TABLE [dbo].[UserInfo] (
    [First Name]       CHAR (10)    NULL,
    [Last Name]        NCHAR (10)   NULL,
    [Contact]          INT          NOT NULL,
    [Address]          VARCHAR (50) NULL,
    [User Name]        NCHAR (10)   NULL,
    [Password]         VARCHAR (6)  NULL,
    [Confirm Password] VARCHAR (6)  NULL, 
    CONSTRAINT [PK_UserInfo] PRIMARY KEY ([Contact])
);

