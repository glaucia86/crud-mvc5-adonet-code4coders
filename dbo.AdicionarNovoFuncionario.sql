CREATE PROCEDURE [dbo].[AdicionarNovoFuncionario]
(
	@Nome		nvarchar(50),
	@Sobrenome	nvarchar(50),
	@Cidade		nvarchar(50),
	@Endereco	nvarchar(50),
	@Email		nvarchar(30)
)
AS BEGIN
	Insert into Funcionario values(
		@Nome, 
		@Sobrenome, 
		@Cidade, 
		@Endereco, 
		@Email)
END
