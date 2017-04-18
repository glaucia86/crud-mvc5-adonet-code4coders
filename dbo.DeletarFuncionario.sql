CREATE PROCEDURE [dbo].[DeletarFuncionarioPorId]
(
	@FuncionarioId int
)
AS BEGIN
	delete from Funcionario	where Id = @FuncionarioId
END