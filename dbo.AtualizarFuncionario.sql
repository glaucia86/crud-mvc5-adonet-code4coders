CREATE PROCEDURE [dbo].[AtualizarFuncionario]
(
	@IdFuncionario int,
	@Nome nvarchar(50),
	@Sobrenome nvarchar(50),
	@Endereco nvarchar(50),
	@Cidade nvarchar(50),
	@Email nvarchar(30)
)
AS BEGIN
	Update Funcionario
	set Nome		= @Nome,
		Sobrenome	= @Sobrenome,
		Cidade		= @Cidade,
		Endereco	= @Endereco,
		Email		= @Email
	where Id = @IdFuncionario
END	
