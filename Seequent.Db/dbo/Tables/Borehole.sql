CREATE TABLE [dbo].[Borehole] (
    [Id]            BIGINT         IDENTITY (1, 1) NOT NULL,
    [DepthKm]       INT            NOT NULL,
    [XLocationKm]   INT            NOT NULL,
    [YLocationKm]   INT            NOT NULL,
    [Type]          NVARCHAR (100) NOT NULL,
    [CableType]     NVARCHAR (100) NULL,
    [CableStrength] NVARCHAR (500) NULL,
    [DrillType]     NVARCHAR (100) NULL,
    [DrillStrength] NVARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

