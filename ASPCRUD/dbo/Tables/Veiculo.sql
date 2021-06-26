CREATE TABLE [dbo].[Veiculo] (
    [VeiculoID]     INT          IDENTITY (1, 1) NOT NULL,
    [Placa]         VARCHAR (50) NULL,
    [Tipo]          VARCHAR (50) NULL,
    [Marca]         VARCHAR (50) NULL,
    [Modelo]        VARCHAR (50) NULL,
    [Anomodelo]     INT          NULL,
    [Anofabricacao] INT          NULL,
    CONSTRAINT [PK_Veiculo] PRIMARY KEY CLUSTERED ([VeiculoID] ASC)
);

