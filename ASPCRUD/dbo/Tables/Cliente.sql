CREATE TABLE [dbo].[Cliente] (
    [ClienteID] INT           IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (50)  NULL,
    [Email]     VARCHAR (50)  NULL,
    [Endereco]  VARCHAR (250) NULL,
    [Cpf]       INT           NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([ClienteID] ASC)
);

