
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 09:31:33
-- Generated from EDMX file: C:\Users\Admin\source\repos\examschema\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DamodarDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [Sid] int IDENTITY(1,1) NOT NULL primary key,
    [Sname] nvarchar(max) NOT NULL,
    [Sloc] nvarchar(max) NOT NULL
);
GO


-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [StNo] int IDENTITY(1,1) NOT NULL primary key,
    [StName] nvarchar(max)  NOT NULL,
    [ExamDt] nvarchar(max)  NOT NULL,
    [ExamCode] int NOT NULL constraint f_k foreign key references Exams(ExamCode),
    [Sid] int NOT NULL constraint fk foreign key references Schools(Sid)
);
GO

-- Creating table 'Results'
CREATE TABLE [dbo].[Results] (
    [StNo] int IDENTITY(1,1) NOT NULL primary key,
    [SecMarks] nvarchar(max)  NOT NULL,
    [MaxMarks] nvarchar(max)  NOT NULL,
    [Percentage] nvarchar(max)  NOT NULL
);
GO

ALTER TABLE [dbo].[Schools] 
ADD  [Percentage] int;
GO
ALTER TABLE [dbo].[Schools] 
ADD  [SecMarks] int;
GO
ALTER TABLE [dbo].[Schools] 
ADD  [MaxMarks] int;
GO


-- Creating table 'Exams'
CREATE TABLE [dbo].[Exams] (
    [ExamCode] int IDENTITY(1,1) NOT NULL primary key,
    [ExamName] nvarchar(max)  NOT NULL,
    [ExamDate] nvarchar(max)  NOT NULL,
    [MaxMarks] nvarchar(max)  NOT NULL,
    [CutOff] nvarchar(max)  NOT NULL,
    [Duration] nvarchar(max)  NOT NULL
);
GO
 
-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Sid] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([Sid] ASC);
GO

-- Creating primary key on [StNo] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([StNo] ASC);
GO

-- Creating primary key on [StNo] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [PK_Results]
    PRIMARY KEY CLUSTERED ([StNo] ASC);
GO

-- Creating primary key on [ExamCode] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [PK_Exams]
    PRIMARY KEY CLUSTERED ([ExamCode] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------