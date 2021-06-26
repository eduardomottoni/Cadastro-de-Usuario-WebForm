CREATE TABLE [dbo].[Servico] (
    [ServicoID] INT           IDENTITY (1, 1) NOT NULL,
    [Nomeserv]  VARCHAR (150) NULL,
    [Descricao] VARCHAR (500) NULL,
    [Valor]     FLOAT (53)    NULL,
    CONSTRAINT [PK_Servico] PRIMARY KEY CLUSTERED ([ServicoID] ASC)
);

