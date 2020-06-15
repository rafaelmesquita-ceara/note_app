
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/15/2020 06:14:59
-- Generated from EDMX file: C:\Users\ery_c\Desktop\Programacao\C#\note_app\Noteapp\Models\NotesModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [note_app];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[NotesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NotesSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'NotesSet'
CREATE TABLE [dbo].[NotesSet] (
    [CD_Notes] int IDENTITY(1,1) NOT NULL,
    [CH_Name] nvarchar(max)  NOT NULL,
    [CH_Description] nvarchar(max)  NOT NULL,
    [DT_Creation] datetime  NOT NULL
);
GO

-- Creating table 'UsersSet'
CREATE TABLE [dbo].[UsersSet] (
    [CD_Users] int IDENTITY(1,1) NOT NULL,
    [CH_Name] nvarchar(max)  NOT NULL,
    [CH_Login] nvarchar(max)  NOT NULL,
    [CH_Password] nvarchar(max)  NOT NULL,
    [DT_Creation] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CD_Notes] in table 'NotesSet'
ALTER TABLE [dbo].[NotesSet]
ADD CONSTRAINT [PK_NotesSet]
    PRIMARY KEY CLUSTERED ([CD_Notes] ASC);
GO

-- Creating primary key on [CD_Users] in table 'UsersSet'
ALTER TABLE [dbo].[UsersSet]
ADD CONSTRAINT [PK_UsersSet]
    PRIMARY KEY CLUSTERED ([CD_Users] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------