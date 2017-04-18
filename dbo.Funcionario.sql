CREATE TABLE [dbo].[Funcionario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(50) NULL, 
    [Sobrenome] NVARCHAR(50) NULL, 
    [Cidade] NVARCHAR(50) NULL, 
    [Endereco] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(30) NULL
)
