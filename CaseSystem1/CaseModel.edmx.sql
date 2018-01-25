
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/22/2018 13:56:13
-- Generated from EDMX file: C:\Users\artem\source\repos\CaseSystem1\CaseSystem1\CaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CaseDataBase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EntityForma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormaSet] DROP CONSTRAINT [FK_EntityForma];
GO
IF OBJECT_ID(N'[dbo].[FK_EntityAttribute]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AttributeSet] DROP CONSTRAINT [FK_EntityAttribute];
GO
IF OBJECT_ID(N'[dbo].[FK_DataBaseProjectEntity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EntitySet] DROP CONSTRAINT [FK_DataBaseProjectEntity];
GO
IF OBJECT_ID(N'[dbo].[FK_AttributeRelation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RelationSet] DROP CONSTRAINT [FK_AttributeRelation];
GO
IF OBJECT_ID(N'[dbo].[FK_AttributeRelation1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RelationSet] DROP CONSTRAINT [FK_AttributeRelation1];
GO
IF OBJECT_ID(N'[dbo].[FK_FormaControlElement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ControlElementSet] DROP CONSTRAINT [FK_FormaControlElement];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeControlElementControlElement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ControlElementSet] DROP CONSTRAINT [FK_TypeControlElementControlElement];
GO
IF OBJECT_ID(N'[dbo].[FK_AttributeControlElement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ControlElementSet] DROP CONSTRAINT [FK_AttributeControlElement];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeEventForma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormaSet] DROP CONSTRAINT [FK_TypeEventForma];
GO
IF OBJECT_ID(N'[dbo].[FK_QuestionCondition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConditionSet] DROP CONSTRAINT [FK_QuestionCondition];
GO
IF OBJECT_ID(N'[dbo].[FK_QuestionReport]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReportSet] DROP CONSTRAINT [FK_QuestionReport];
GO
IF OBJECT_ID(N'[dbo].[FK_QuestionAttribute_Question]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuestionAttribute] DROP CONSTRAINT [FK_QuestionAttribute_Question];
GO
IF OBJECT_ID(N'[dbo].[FK_QuestionAttribute_Attribute]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[QuestionAttribute] DROP CONSTRAINT [FK_QuestionAttribute_Attribute];
GO
IF OBJECT_ID(N'[dbo].[FK_AttributeAttributeValue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AttributeValueSet] DROP CONSTRAINT [FK_AttributeAttributeValue];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EntitySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EntitySet];
GO
IF OBJECT_ID(N'[dbo].[AttributeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AttributeSet];
GO
IF OBJECT_ID(N'[dbo].[RelationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RelationSet];
GO
IF OBJECT_ID(N'[dbo].[FormaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormaSet];
GO
IF OBJECT_ID(N'[dbo].[ControlElementSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ControlElementSet];
GO
IF OBJECT_ID(N'[dbo].[TypeControlElementSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeControlElementSet];
GO
IF OBJECT_ID(N'[dbo].[TypeEventSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeEventSet];
GO
IF OBJECT_ID(N'[dbo].[QuestionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuestionSet];
GO
IF OBJECT_ID(N'[dbo].[ConditionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConditionSet];
GO
IF OBJECT_ID(N'[dbo].[ReportSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReportSet];
GO
IF OBJECT_ID(N'[dbo].[AttributeValueSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AttributeValueSet];
GO
IF OBJECT_ID(N'[dbo].[DataBaseProjectSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataBaseProjectSet];
GO
IF OBJECT_ID(N'[dbo].[QuestionAttribute]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuestionAttribute];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EntitySet'
CREATE TABLE [dbo].[EntitySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DataBaseProject_Id] int  NOT NULL
);
GO

-- Creating table 'AttributeSet'
CREATE TABLE [dbo].[AttributeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Specification] nvarchar(max)  NOT NULL,
    [Entity_Id] int  NOT NULL
);
GO

-- Creating table 'RelationSet'
CREATE TABLE [dbo].[RelationSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Multiplicity] nvarchar(max)  NOT NULL,
    [Source_Id] int  NOT NULL,
    [Target_Id] int  NOT NULL
);
GO

-- Creating table 'FormaSet'
CREATE TABLE [dbo].[FormaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Entity_Id] int  NOT NULL,
    [TypeEvent_Id] int  NOT NULL
);
GO

-- Creating table 'ControlElementSet'
CREATE TABLE [dbo].[ControlElementSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Enabled] bit  NOT NULL,
    [PositionX] int  NOT NULL,
    [PositionY] int  NOT NULL,
    [Length] int  NOT NULL,
    [Width] int  NOT NULL,
    [Forma_Id] int  NOT NULL,
    [TypeControlElement_Id] int  NOT NULL,
    [Attribute_Id] int  NOT NULL
);
GO

-- Creating table 'TypeControlElementSet'
CREATE TABLE [dbo].[TypeControlElementSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TypeEventSet'
CREATE TABLE [dbo].[TypeEventSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'QuestionSet'
CREATE TABLE [dbo].[QuestionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ConditionSet'
CREATE TABLE [dbo].[ConditionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Not] bit  NOT NULL,
    [Compare] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [Operation] nvarchar(max)  NOT NULL,
    [Question_Id] int  NOT NULL,
    [Attribute_Id] int  NOT NULL
);
GO

-- Creating table 'ReportSet'
CREATE TABLE [dbo].[ReportSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Format] nvarchar(max)  NOT NULL,
    [Question_Id] int  NOT NULL
);
GO

-- Creating table 'AttributeValueSet'
CREATE TABLE [dbo].[AttributeValueSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [Number] int  NOT NULL,
    [Attribute_Id] int  NOT NULL
);
GO

-- Creating table 'DataBaseProjectSet'
CREATE TABLE [dbo].[DataBaseProjectSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'QuestionAttribute'
CREATE TABLE [dbo].[QuestionAttribute] (
    [Questions_Id] int  NOT NULL,
    [Attributes_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EntitySet'
ALTER TABLE [dbo].[EntitySet]
ADD CONSTRAINT [PK_EntitySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AttributeSet'
ALTER TABLE [dbo].[AttributeSet]
ADD CONSTRAINT [PK_AttributeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RelationSet'
ALTER TABLE [dbo].[RelationSet]
ADD CONSTRAINT [PK_RelationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormaSet'
ALTER TABLE [dbo].[FormaSet]
ADD CONSTRAINT [PK_FormaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ControlElementSet'
ALTER TABLE [dbo].[ControlElementSet]
ADD CONSTRAINT [PK_ControlElementSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeControlElementSet'
ALTER TABLE [dbo].[TypeControlElementSet]
ADD CONSTRAINT [PK_TypeControlElementSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeEventSet'
ALTER TABLE [dbo].[TypeEventSet]
ADD CONSTRAINT [PK_TypeEventSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'QuestionSet'
ALTER TABLE [dbo].[QuestionSet]
ADD CONSTRAINT [PK_QuestionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConditionSet'
ALTER TABLE [dbo].[ConditionSet]
ADD CONSTRAINT [PK_ConditionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReportSet'
ALTER TABLE [dbo].[ReportSet]
ADD CONSTRAINT [PK_ReportSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AttributeValueSet'
ALTER TABLE [dbo].[AttributeValueSet]
ADD CONSTRAINT [PK_AttributeValueSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DataBaseProjectSet'
ALTER TABLE [dbo].[DataBaseProjectSet]
ADD CONSTRAINT [PK_DataBaseProjectSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Questions_Id], [Attributes_Id] in table 'QuestionAttribute'
ALTER TABLE [dbo].[QuestionAttribute]
ADD CONSTRAINT [PK_QuestionAttribute]
    PRIMARY KEY CLUSTERED ([Questions_Id], [Attributes_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Entity_Id] in table 'FormaSet'
ALTER TABLE [dbo].[FormaSet]
ADD CONSTRAINT [FK_EntityForma]
    FOREIGN KEY ([Entity_Id])
    REFERENCES [dbo].[EntitySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EntityForma'
CREATE INDEX [IX_FK_EntityForma]
ON [dbo].[FormaSet]
    ([Entity_Id]);
GO

-- Creating foreign key on [Entity_Id] in table 'AttributeSet'
ALTER TABLE [dbo].[AttributeSet]
ADD CONSTRAINT [FK_EntityAttribute]
    FOREIGN KEY ([Entity_Id])
    REFERENCES [dbo].[EntitySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EntityAttribute'
CREATE INDEX [IX_FK_EntityAttribute]
ON [dbo].[AttributeSet]
    ([Entity_Id]);
GO

-- Creating foreign key on [DataBaseProject_Id] in table 'EntitySet'
ALTER TABLE [dbo].[EntitySet]
ADD CONSTRAINT [FK_DataBaseProjectEntity]
    FOREIGN KEY ([DataBaseProject_Id])
    REFERENCES [dbo].[DataBaseProjectSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DataBaseProjectEntity'
CREATE INDEX [IX_FK_DataBaseProjectEntity]
ON [dbo].[EntitySet]
    ([DataBaseProject_Id]);
GO

-- Creating foreign key on [Source_Id] in table 'RelationSet'
ALTER TABLE [dbo].[RelationSet]
ADD CONSTRAINT [FK_AttributeRelation]
    FOREIGN KEY ([Source_Id])
    REFERENCES [dbo].[AttributeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeRelation'
CREATE INDEX [IX_FK_AttributeRelation]
ON [dbo].[RelationSet]
    ([Source_Id]);
GO

-- Creating foreign key on [Target_Id] in table 'RelationSet'
ALTER TABLE [dbo].[RelationSet]
ADD CONSTRAINT [FK_AttributeRelation1]
    FOREIGN KEY ([Target_Id])
    REFERENCES [dbo].[AttributeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeRelation1'
CREATE INDEX [IX_FK_AttributeRelation1]
ON [dbo].[RelationSet]
    ([Target_Id]);
GO

-- Creating foreign key on [Forma_Id] in table 'ControlElementSet'
ALTER TABLE [dbo].[ControlElementSet]
ADD CONSTRAINT [FK_FormaControlElement]
    FOREIGN KEY ([Forma_Id])
    REFERENCES [dbo].[FormaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormaControlElement'
CREATE INDEX [IX_FK_FormaControlElement]
ON [dbo].[ControlElementSet]
    ([Forma_Id]);
GO

-- Creating foreign key on [TypeControlElement_Id] in table 'ControlElementSet'
ALTER TABLE [dbo].[ControlElementSet]
ADD CONSTRAINT [FK_TypeControlElementControlElement]
    FOREIGN KEY ([TypeControlElement_Id])
    REFERENCES [dbo].[TypeControlElementSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeControlElementControlElement'
CREATE INDEX [IX_FK_TypeControlElementControlElement]
ON [dbo].[ControlElementSet]
    ([TypeControlElement_Id]);
GO

-- Creating foreign key on [Attribute_Id] in table 'ControlElementSet'
ALTER TABLE [dbo].[ControlElementSet]
ADD CONSTRAINT [FK_AttributeControlElement]
    FOREIGN KEY ([Attribute_Id])
    REFERENCES [dbo].[AttributeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeControlElement'
CREATE INDEX [IX_FK_AttributeControlElement]
ON [dbo].[ControlElementSet]
    ([Attribute_Id]);
GO

-- Creating foreign key on [TypeEvent_Id] in table 'FormaSet'
ALTER TABLE [dbo].[FormaSet]
ADD CONSTRAINT [FK_TypeEventForma]
    FOREIGN KEY ([TypeEvent_Id])
    REFERENCES [dbo].[TypeEventSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeEventForma'
CREATE INDEX [IX_FK_TypeEventForma]
ON [dbo].[FormaSet]
    ([TypeEvent_Id]);
GO

-- Creating foreign key on [Question_Id] in table 'ConditionSet'
ALTER TABLE [dbo].[ConditionSet]
ADD CONSTRAINT [FK_QuestionCondition]
    FOREIGN KEY ([Question_Id])
    REFERENCES [dbo].[QuestionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_QuestionCondition'
CREATE INDEX [IX_FK_QuestionCondition]
ON [dbo].[ConditionSet]
    ([Question_Id]);
GO

-- Creating foreign key on [Question_Id] in table 'ReportSet'
ALTER TABLE [dbo].[ReportSet]
ADD CONSTRAINT [FK_QuestionReport]
    FOREIGN KEY ([Question_Id])
    REFERENCES [dbo].[QuestionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_QuestionReport'
CREATE INDEX [IX_FK_QuestionReport]
ON [dbo].[ReportSet]
    ([Question_Id]);
GO

-- Creating foreign key on [Questions_Id] in table 'QuestionAttribute'
ALTER TABLE [dbo].[QuestionAttribute]
ADD CONSTRAINT [FK_QuestionAttribute_Question]
    FOREIGN KEY ([Questions_Id])
    REFERENCES [dbo].[QuestionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Attributes_Id] in table 'QuestionAttribute'
ALTER TABLE [dbo].[QuestionAttribute]
ADD CONSTRAINT [FK_QuestionAttribute_Attribute]
    FOREIGN KEY ([Attributes_Id])
    REFERENCES [dbo].[AttributeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_QuestionAttribute_Attribute'
CREATE INDEX [IX_FK_QuestionAttribute_Attribute]
ON [dbo].[QuestionAttribute]
    ([Attributes_Id]);
GO

-- Creating foreign key on [Attribute_Id] in table 'AttributeValueSet'
ALTER TABLE [dbo].[AttributeValueSet]
ADD CONSTRAINT [FK_AttributeAttributeValue]
    FOREIGN KEY ([Attribute_Id])
    REFERENCES [dbo].[AttributeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeAttributeValue'
CREATE INDEX [IX_FK_AttributeAttributeValue]
ON [dbo].[AttributeValueSet]
    ([Attribute_Id]);
GO

-- Creating foreign key on [Attribute_Id] in table 'ConditionSet'
ALTER TABLE [dbo].[ConditionSet]
ADD CONSTRAINT [FK_AttributeCondition]
    FOREIGN KEY ([Attribute_Id])
    REFERENCES [dbo].[AttributeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeCondition'
CREATE INDEX [IX_FK_AttributeCondition]
ON [dbo].[ConditionSet]
    ([Attribute_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------