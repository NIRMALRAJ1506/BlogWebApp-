IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AdminInfo] (
    [EmailId] nvarchar(450) NOT NULL,
    [Password] nvarchar(max) NULL,
    CONSTRAINT [PK_AdminInfo] PRIMARY KEY ([EmailId])
);
GO

CREATE TABLE [BlogInfo] (
    [BlogId] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [Subject] nvarchar(max) NULL,
    [DateOfCreation] datetime2 NOT NULL,
    [BlogUrl] nvarchar(max) NULL,
    [EmpEmailId] nvarchar(max) NULL,
    CONSTRAINT [PK_BlogInfo] PRIMARY KEY ([BlogId])
);
GO

CREATE TABLE [EmpInfo] (
    [EmailId] nvarchar(450) NOT NULL,
    [Name] nvarchar(max) NULL,
    [DateOfJoining] datetime2 NOT NULL,
    [PassCode] nvarchar(max) NULL,
    CONSTRAINT [PK_EmpInfo] PRIMARY KEY ([EmailId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240122070317_FirstMig', N'6.0.26');
GO

COMMIT;
GO

