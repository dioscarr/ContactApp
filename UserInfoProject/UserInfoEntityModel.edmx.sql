
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/19/2014 08:06:36
-- Generated from EDMX file: c:\Users\dioscar\Documents\Visual Studio 2013\Projects\UserInfo\UserInfoProject\UserInfoEntityModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [UserInfo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserInfoModels'
CREATE TABLE [dbo].[UserInfoModels] (
    [UserInfo_ID] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(25)  NOT NULL,
    [LastName] varchar(25)  NOT NULL,
    [EmailAddress] varchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserInfo_ID] in table 'UserInfoModels'
ALTER TABLE [dbo].[UserInfoModels]
ADD CONSTRAINT [PK_UserInfoModels]
    PRIMARY KEY CLUSTERED ([UserInfo_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------