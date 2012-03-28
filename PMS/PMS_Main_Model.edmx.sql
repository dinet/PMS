
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/18/2012 05:59:24
-- Generated from EDMX file: C:\Users\Minidu\Documents\Visual Studio 2010\Projects\PMS\PMS\PMS_Main_Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PMS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ExporterDirector_Exporter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExporterDirector] DROP CONSTRAINT [FK_ExporterDirector_Exporter];
GO
IF OBJECT_ID(N'[dbo].[FK_ExporterDirector_Director]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExporterDirector] DROP CONSTRAINT [FK_ExporterDirector_Director];
GO
IF OBJECT_ID(N'[dbo].[FK_ExporterShipment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Shipments] DROP CONSTRAINT [FK_ExporterShipment];
GO
IF OBJECT_ID(N'[dbo].[FK_ExporterDeclaration]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Declarations] DROP CONSTRAINT [FK_ExporterDeclaration];
GO
IF OBJECT_ID(N'[dbo].[FK_BuyerShipment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Shipments] DROP CONSTRAINT [FK_BuyerShipment];
GO
IF OBJECT_ID(N'[dbo].[FK_DeclarationBuyer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Declarations] DROP CONSTRAINT [FK_DeclarationBuyer];
GO
IF OBJECT_ID(N'[dbo].[FK_PolicyDeclaration]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Declarations] DROP CONSTRAINT [FK_PolicyDeclaration];
GO
IF OBJECT_ID(N'[dbo].[FK_CommodityShipment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Shipments] DROP CONSTRAINT [FK_CommodityShipment];
GO
IF OBJECT_ID(N'[dbo].[FK_CommodityDeclaration]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Declarations] DROP CONSTRAINT [FK_CommodityDeclaration];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryPremiumRate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PremiumRates] DROP CONSTRAINT [FK_CountryPremiumRate];
GO
IF OBJECT_ID(N'[dbo].[FK_AccessGroupUser_AccessGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccessGroupUser] DROP CONSTRAINT [FK_AccessGroupUser_AccessGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_AccessGroupUser_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccessGroupUser] DROP CONSTRAINT [FK_AccessGroupUser_User];
GO
IF OBJECT_ID(N'[dbo].[FK_AccessControlAccessGroup_AccessControl]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccessControlAccessGroup] DROP CONSTRAINT [FK_AccessControlAccessGroup_AccessControl];
GO
IF OBJECT_ID(N'[dbo].[FK_AccessControlAccessGroup_AccessGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AccessControlAccessGroup] DROP CONSTRAINT [FK_AccessControlAccessGroup_AccessGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_BuyerCountry]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Buyers] DROP CONSTRAINT [FK_BuyerCountry];
GO
IF OBJECT_ID(N'[dbo].[FK_DeclarationCountry]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Declarations] DROP CONSTRAINT [FK_DeclarationCountry];
GO
IF OBJECT_ID(N'[dbo].[FK_CommodityPremiumRate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PremiumRates] DROP CONSTRAINT [FK_CommodityPremiumRate];
GO
IF OBJECT_ID(N'[dbo].[FK_DeclarationPremiumRate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Declarations] DROP CONSTRAINT [FK_DeclarationPremiumRate];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyBuyer_inherits_Buyer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Buyers_CompanyBuyer] DROP CONSTRAINT [FK_CompanyBuyer_inherits_Buyer];
GO
IF OBJECT_ID(N'[dbo].[FK_IndividualBuyer_inherits_Buyer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Buyers_IndividualBuyer] DROP CONSTRAINT [FK_IndividualBuyer_inherits_Buyer];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Exporters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Exporters];
GO
IF OBJECT_ID(N'[dbo].[Directors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Directors];
GO
IF OBJECT_ID(N'[dbo].[Shipments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Shipments];
GO
IF OBJECT_ID(N'[dbo].[Buyers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Buyers];
GO
IF OBJECT_ID(N'[dbo].[Declarations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Declarations];
GO
IF OBJECT_ID(N'[dbo].[Policies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Policies];
GO
IF OBJECT_ID(N'[dbo].[Commodities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Commodities];
GO
IF OBJECT_ID(N'[dbo].[Countries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Countries];
GO
IF OBJECT_ID(N'[dbo].[PremiumRates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PremiumRates];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[AccessGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccessGroups];
GO
IF OBJECT_ID(N'[dbo].[AccessControls]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccessControls];
GO
IF OBJECT_ID(N'[dbo].[Buyers_CompanyBuyer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Buyers_CompanyBuyer];
GO
IF OBJECT_ID(N'[dbo].[Buyers_IndividualBuyer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Buyers_IndividualBuyer];
GO
IF OBJECT_ID(N'[dbo].[ExporterDirector]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExporterDirector];
GO
IF OBJECT_ID(N'[dbo].[AccessGroupUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccessGroupUser];
GO
IF OBJECT_ID(N'[dbo].[AccessControlAccessGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccessControlAccessGroup];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Exporters'
CREATE TABLE [dbo].[Exporters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [RegNo] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [TelNo] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ShortTag] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Directors'
CREATE TABLE [dbo].[Directors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [NIC] nvarchar(max)  NULL,
    [TelNo] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [JoinedDate] datetime  NULL,
    [Type] nvarchar(max)  NULL,
    [PassportNo] nvarchar(max)  NULL,
    [Gender] nvarchar(max)  NULL,
    [DateOfBirth] datetime  NULL,
    [LastName] nvarchar(max)  NULL
);
GO

-- Creating table 'Shipments'
CREATE TABLE [dbo].[Shipments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ExporterId] int  NOT NULL,
    [BuyerId] int  NOT NULL,
    [CommodityId] int  NOT NULL
);
GO

-- Creating table 'Buyers'
CREATE TABLE [dbo].[Buyers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CountryId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [ZipCode] nvarchar(max)  NOT NULL,
    [Fax] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [TelephoneNo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Declarations'
CREATE TABLE [dbo].[Declarations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ExporterId] int  NOT NULL,
    [BuyerId] int  NOT NULL,
    [PolicyId] int  NOT NULL,
    [CommodityId] int  NOT NULL,
    [ShipmentDate] datetime  NOT NULL,
    [TermOfPayment] nvarchar(max)  NOT NULL,
    [StampDate] datetime  NOT NULL,
    [CreditDuration] nvarchar(max)  NOT NULL,
    [CountryId] int  NOT NULL,
    [GrossValue] nvarchar(max)  NOT NULL,
    [PremiumRateId] int  NULL,
    [Buyer_Id] int  NOT NULL
);
GO

-- Creating table 'Policies'
CREATE TABLE [dbo].[Policies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PolicyNumber] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Commodities'
CREATE TABLE [dbo].[Commodities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Countries'
CREATE TABLE [dbo].[Countries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ShortCode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PremiumRates'
CREATE TABLE [dbo].[PremiumRates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rate] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [CountryId] int  NOT NULL,
    [CommodityId] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EpfNo] nvarchar(max)  NOT NULL,
    [NIC] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [Designation] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [MobileNo] nvarchar(max)  NOT NULL,
    [LandPhone] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [AddedDate] datetime  NULL,
    [LastLoginDate] datetime  NULL,
    [DateOfBirth] datetime  NULL
);
GO

-- Creating table 'AccessGroups'
CREATE TABLE [dbo].[AccessGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AccessControls'
CREATE TABLE [dbo].[AccessControls] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ActionDescription] nvarchar(max)  NOT NULL,
    [ShortTag] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Buyers_CompanyBuyer'
CREATE TABLE [dbo].[Buyers_CompanyBuyer] (
    [ShortName] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Buyers_IndividualBuyer'
CREATE TABLE [dbo].[Buyers_IndividualBuyer] (
    [DateOfBirth] datetime  NULL,
    [NIC] nvarchar(max)  NOT NULL,
    [MobileNo] nvarchar(max)  NOT NULL,
    [Passport] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'ExporterDirector'
CREATE TABLE [dbo].[ExporterDirector] (
    [Exporters_Id] int  NOT NULL,
    [Directors_Id] int  NOT NULL
);
GO

-- Creating table 'AccessGroupUser'
CREATE TABLE [dbo].[AccessGroupUser] (
    [AccessGroups_Id] int  NOT NULL,
    [Users_Id] int  NOT NULL
);
GO

-- Creating table 'AccessControlAccessGroup'
CREATE TABLE [dbo].[AccessControlAccessGroup] (
    [AccessControls_Id] int  NOT NULL,
    [AccessGroups_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Exporters'
ALTER TABLE [dbo].[Exporters]
ADD CONSTRAINT [PK_Exporters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Directors'
ALTER TABLE [dbo].[Directors]
ADD CONSTRAINT [PK_Directors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Shipments'
ALTER TABLE [dbo].[Shipments]
ADD CONSTRAINT [PK_Shipments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Buyers'
ALTER TABLE [dbo].[Buyers]
ADD CONSTRAINT [PK_Buyers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Declarations'
ALTER TABLE [dbo].[Declarations]
ADD CONSTRAINT [PK_Declarations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Policies'
ALTER TABLE [dbo].[Policies]
ADD CONSTRAINT [PK_Policies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Commodities'
ALTER TABLE [dbo].[Commodities]
ADD CONSTRAINT [PK_Commodities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Countries'
ALTER TABLE [dbo].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PremiumRates'
ALTER TABLE [dbo].[PremiumRates]
ADD CONSTRAINT [PK_PremiumRates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AccessGroups'
ALTER TABLE [dbo].[AccessGroups]
ADD CONSTRAINT [PK_AccessGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AccessControls'
ALTER TABLE [dbo].[AccessControls]
ADD CONSTRAINT [PK_AccessControls]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Buyers_CompanyBuyer'
ALTER TABLE [dbo].[Buyers_CompanyBuyer]
ADD CONSTRAINT [PK_Buyers_CompanyBuyer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Buyers_IndividualBuyer'
ALTER TABLE [dbo].[Buyers_IndividualBuyer]
ADD CONSTRAINT [PK_Buyers_IndividualBuyer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Exporters_Id], [Directors_Id] in table 'ExporterDirector'
ALTER TABLE [dbo].[ExporterDirector]
ADD CONSTRAINT [PK_ExporterDirector]
    PRIMARY KEY NONCLUSTERED ([Exporters_Id], [Directors_Id] ASC);
GO

-- Creating primary key on [AccessGroups_Id], [Users_Id] in table 'AccessGroupUser'
ALTER TABLE [dbo].[AccessGroupUser]
ADD CONSTRAINT [PK_AccessGroupUser]
    PRIMARY KEY NONCLUSTERED ([AccessGroups_Id], [Users_Id] ASC);
GO

-- Creating primary key on [AccessControls_Id], [AccessGroups_Id] in table 'AccessControlAccessGroup'
ALTER TABLE [dbo].[AccessControlAccessGroup]
ADD CONSTRAINT [PK_AccessControlAccessGroup]
    PRIMARY KEY NONCLUSTERED ([AccessControls_Id], [AccessGroups_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Exporters_Id] in table 'ExporterDirector'
ALTER TABLE [dbo].[ExporterDirector]
ADD CONSTRAINT [FK_ExporterDirector_Exporter]
    FOREIGN KEY ([Exporters_Id])
    REFERENCES [dbo].[Exporters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Directors_Id] in table 'ExporterDirector'
ALTER TABLE [dbo].[ExporterDirector]
ADD CONSTRAINT [FK_ExporterDirector_Director]
    FOREIGN KEY ([Directors_Id])
    REFERENCES [dbo].[Directors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExporterDirector_Director'
CREATE INDEX [IX_FK_ExporterDirector_Director]
ON [dbo].[ExporterDirector]
    ([Directors_Id]);
GO

-- Creating foreign key on [ExporterId] in table 'Shipments'
ALTER TABLE [dbo].[Shipments]
ADD CONSTRAINT [FK_ExporterShipment]
    FOREIGN KEY ([ExporterId])
    REFERENCES [dbo].[Exporters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExporterShipment'
CREATE INDEX [IX_FK_ExporterShipment]
ON [dbo].[Shipments]
    ([ExporterId]);
GO

-- Creating foreign key on [ExporterId] in table 'Declarations'
ALTER TABLE [dbo].[Declarations]
ADD CONSTRAINT [FK_ExporterDeclaration]
    FOREIGN KEY ([ExporterId])
    REFERENCES [dbo].[Exporters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ExporterDeclaration'
CREATE INDEX [IX_FK_ExporterDeclaration]
ON [dbo].[Declarations]
    ([ExporterId]);
GO

-- Creating foreign key on [BuyerId] in table 'Shipments'
ALTER TABLE [dbo].[Shipments]
ADD CONSTRAINT [FK_BuyerShipment]
    FOREIGN KEY ([BuyerId])
    REFERENCES [dbo].[Buyers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BuyerShipment'
CREATE INDEX [IX_FK_BuyerShipment]
ON [dbo].[Shipments]
    ([BuyerId]);
GO

-- Creating foreign key on [Buyer_Id] in table 'Declarations'
ALTER TABLE [dbo].[Declarations]
ADD CONSTRAINT [FK_DeclarationBuyer]
    FOREIGN KEY ([Buyer_Id])
    REFERENCES [dbo].[Buyers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeclarationBuyer'
CREATE INDEX [IX_FK_DeclarationBuyer]
ON [dbo].[Declarations]
    ([Buyer_Id]);
GO

-- Creating foreign key on [PolicyId] in table 'Declarations'
ALTER TABLE [dbo].[Declarations]
ADD CONSTRAINT [FK_PolicyDeclaration]
    FOREIGN KEY ([PolicyId])
    REFERENCES [dbo].[Policies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PolicyDeclaration'
CREATE INDEX [IX_FK_PolicyDeclaration]
ON [dbo].[Declarations]
    ([PolicyId]);
GO

-- Creating foreign key on [CommodityId] in table 'Shipments'
ALTER TABLE [dbo].[Shipments]
ADD CONSTRAINT [FK_CommodityShipment]
    FOREIGN KEY ([CommodityId])
    REFERENCES [dbo].[Commodities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CommodityShipment'
CREATE INDEX [IX_FK_CommodityShipment]
ON [dbo].[Shipments]
    ([CommodityId]);
GO

-- Creating foreign key on [CommodityId] in table 'Declarations'
ALTER TABLE [dbo].[Declarations]
ADD CONSTRAINT [FK_CommodityDeclaration]
    FOREIGN KEY ([CommodityId])
    REFERENCES [dbo].[Commodities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CommodityDeclaration'
CREATE INDEX [IX_FK_CommodityDeclaration]
ON [dbo].[Declarations]
    ([CommodityId]);
GO

-- Creating foreign key on [CountryId] in table 'PremiumRates'
ALTER TABLE [dbo].[PremiumRates]
ADD CONSTRAINT [FK_CountryPremiumRate]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryPremiumRate'
CREATE INDEX [IX_FK_CountryPremiumRate]
ON [dbo].[PremiumRates]
    ([CountryId]);
GO

-- Creating foreign key on [AccessGroups_Id] in table 'AccessGroupUser'
ALTER TABLE [dbo].[AccessGroupUser]
ADD CONSTRAINT [FK_AccessGroupUser_AccessGroup]
    FOREIGN KEY ([AccessGroups_Id])
    REFERENCES [dbo].[AccessGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_Id] in table 'AccessGroupUser'
ALTER TABLE [dbo].[AccessGroupUser]
ADD CONSTRAINT [FK_AccessGroupUser_User]
    FOREIGN KEY ([Users_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AccessGroupUser_User'
CREATE INDEX [IX_FK_AccessGroupUser_User]
ON [dbo].[AccessGroupUser]
    ([Users_Id]);
GO

-- Creating foreign key on [AccessControls_Id] in table 'AccessControlAccessGroup'
ALTER TABLE [dbo].[AccessControlAccessGroup]
ADD CONSTRAINT [FK_AccessControlAccessGroup_AccessControl]
    FOREIGN KEY ([AccessControls_Id])
    REFERENCES [dbo].[AccessControls]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AccessGroups_Id] in table 'AccessControlAccessGroup'
ALTER TABLE [dbo].[AccessControlAccessGroup]
ADD CONSTRAINT [FK_AccessControlAccessGroup_AccessGroup]
    FOREIGN KEY ([AccessGroups_Id])
    REFERENCES [dbo].[AccessGroups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AccessControlAccessGroup_AccessGroup'
CREATE INDEX [IX_FK_AccessControlAccessGroup_AccessGroup]
ON [dbo].[AccessControlAccessGroup]
    ([AccessGroups_Id]);
GO

-- Creating foreign key on [CountryId] in table 'Buyers'
ALTER TABLE [dbo].[Buyers]
ADD CONSTRAINT [FK_BuyerCountry]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BuyerCountry'
CREATE INDEX [IX_FK_BuyerCountry]
ON [dbo].[Buyers]
    ([CountryId]);
GO

-- Creating foreign key on [CountryId] in table 'Declarations'
ALTER TABLE [dbo].[Declarations]
ADD CONSTRAINT [FK_DeclarationCountry]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeclarationCountry'
CREATE INDEX [IX_FK_DeclarationCountry]
ON [dbo].[Declarations]
    ([CountryId]);
GO

-- Creating foreign key on [CommodityId] in table 'PremiumRates'
ALTER TABLE [dbo].[PremiumRates]
ADD CONSTRAINT [FK_CommodityPremiumRate]
    FOREIGN KEY ([CommodityId])
    REFERENCES [dbo].[Commodities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CommodityPremiumRate'
CREATE INDEX [IX_FK_CommodityPremiumRate]
ON [dbo].[PremiumRates]
    ([CommodityId]);
GO

-- Creating foreign key on [PremiumRateId] in table 'Declarations'
ALTER TABLE [dbo].[Declarations]
ADD CONSTRAINT [FK_DeclarationPremiumRate]
    FOREIGN KEY ([PremiumRateId])
    REFERENCES [dbo].[PremiumRates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeclarationPremiumRate'
CREATE INDEX [IX_FK_DeclarationPremiumRate]
ON [dbo].[Declarations]
    ([PremiumRateId]);
GO

-- Creating foreign key on [Id] in table 'Buyers_CompanyBuyer'
ALTER TABLE [dbo].[Buyers_CompanyBuyer]
ADD CONSTRAINT [FK_CompanyBuyer_inherits_Buyer]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Buyers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Buyers_IndividualBuyer'
ALTER TABLE [dbo].[Buyers_IndividualBuyer]
ADD CONSTRAINT [FK_IndividualBuyer_inherits_Buyer]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Buyers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------