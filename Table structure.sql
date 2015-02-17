
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/22/2015 10:05:08
-- Generated from EDMX file: D:\Dharmesh\Project\AngularJsAppDemo\AngularJsAppDemo.DOL\DataClassModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Test];
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

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [MiddleName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [ContactNo] nvarchar(max)  NOT NULL,
    [EmailID] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserRoleMaps'
CREATE TABLE [dbo].[UserRoleMaps] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [UserID] int  NOT NULL,
    [RoleID] int  NOT NULL
);
GO

-- Creating table 'Menus'
CREATE TABLE [dbo].[Menus] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ParentID] int  NOT NULL,
    [DisplayName] nvarchar(max)  NOT NULL,
    [DisplayOrder] int  NOT NULL,
    [IsAccess] bit  NOT NULL,
    [IsActive] bit  NOT NULL,
    [IsExtraAccess] bit  NOT NULL,
    [ExtraAccessFunction] nvarchar(max)  NOT NULL,
    [ControllerNameID] int  NOT NULL,
    [ActionID] int  NOT NULL
);
GO

-- Creating table 'ControllerNames'
CREATE TABLE [dbo].[ControllerNames] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Actions'
CREATE TABLE [dbo].[Actions] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ActionName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RoleMenuMaps'
CREATE TABLE [dbo].[RoleMenuMaps] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [MenuID] int  NOT NULL,
    [RoleID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'UserRoleMaps'
ALTER TABLE [dbo].[UserRoleMaps]
ADD CONSTRAINT [PK_UserRoleMaps]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [PK_Menus]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ControllerNames'
ALTER TABLE [dbo].[ControllerNames]
ADD CONSTRAINT [PK_ControllerNames]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Actions'
ALTER TABLE [dbo].[Actions]
ADD CONSTRAINT [PK_Actions]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'RoleMenuMaps'
ALTER TABLE [dbo].[RoleMenuMaps]
ADD CONSTRAINT [PK_RoleMenuMaps]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserID] in table 'UserRoleMaps'
ALTER TABLE [dbo].[UserRoleMaps]
ADD CONSTRAINT [FK_UserUserRoleMap]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserUserRoleMap'
CREATE INDEX [IX_FK_UserUserRoleMap]
ON [dbo].[UserRoleMaps]
    ([UserID]);
GO

-- Creating foreign key on [RoleID] in table 'UserRoleMaps'
ALTER TABLE [dbo].[UserRoleMaps]
ADD CONSTRAINT [FK_RoleUserRoleMap]
    FOREIGN KEY ([RoleID])
    REFERENCES [dbo].[Roles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleUserRoleMap'
CREATE INDEX [IX_FK_RoleUserRoleMap]
ON [dbo].[UserRoleMaps]
    ([RoleID]);
GO

-- Creating foreign key on [ControllerNameID] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [FK_ControllerNameMenu]
    FOREIGN KEY ([ControllerNameID])
    REFERENCES [dbo].[ControllerNames]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ControllerNameMenu'
CREATE INDEX [IX_FK_ControllerNameMenu]
ON [dbo].[Menus]
    ([ControllerNameID]);
GO

-- Creating foreign key on [ActionID] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [FK_ActionMenu]
    FOREIGN KEY ([ActionID])
    REFERENCES [dbo].[Actions]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ActionMenu'
CREATE INDEX [IX_FK_ActionMenu]
ON [dbo].[Menus]
    ([ActionID]);
GO

-- Creating foreign key on [MenuID] in table 'RoleMenuMaps'
ALTER TABLE [dbo].[RoleMenuMaps]
ADD CONSTRAINT [FK_MenuRoleMenuMap]
    FOREIGN KEY ([MenuID])
    REFERENCES [dbo].[Menus]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MenuRoleMenuMap'
CREATE INDEX [IX_FK_MenuRoleMenuMap]
ON [dbo].[RoleMenuMaps]
    ([MenuID]);
GO

-- Creating foreign key on [RoleID] in table 'RoleMenuMaps'
ALTER TABLE [dbo].[RoleMenuMaps]
ADD CONSTRAINT [FK_RoleRoleMenuMap]
    FOREIGN KEY ([RoleID])
    REFERENCES [dbo].[Roles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleRoleMenuMap'
CREATE INDEX [IX_FK_RoleRoleMenuMap]
ON [dbo].[RoleMenuMaps]
    ([RoleID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------