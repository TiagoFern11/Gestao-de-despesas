CREATE TABLE [dbo].[Utilizador] (
    [Idutilizador]   INT          NOT NULL,
    [Nome]           VARCHAR (20) NOT NULL,
    [Sobrenome]      VARCHAR (20) NOT NULL,
    [DataNascimento] DATE         NOT NULL,
    [SaldoAtual]     MONEY        NOT NULL,
    [PalavraPasse]  VARCHAR(20) NOT NULL,
    [Email] VARCHAR(60) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Idutilizador] ASC)
);

