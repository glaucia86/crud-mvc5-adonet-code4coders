using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Projeto.Models; //importando o modelo da Classe: Funcionario

namespace Projeto.Repository
{
    public class FuncionarioRepository : Conexao
    {
        // Método: CREATE
        public bool AdicionarFuncionario(Funcionario func)
        {
            try
            {
                AbrirConexao();

                //Aqui estou chamando a procedure:
                Cmd = new SqlCommand("AdicionarNovoFuncionario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Nome", func.Nome);
                Cmd.Parameters.AddWithValue("@Sobrenome", func.Sobrenome);
                Cmd.Parameters.AddWithValue("Cidade", func.Cidade);
                Cmd.Parameters.AddWithValue("@Endereco", func.Endereco);
                Cmd.Parameters.AddWithValue("@Email", func.Email);

                int i = Cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Adicionar Novo Funcionário: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método: READ 
        public List<Funcionario> SelecionarFuncionarios()
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("SelecionarFuncionarios", Con);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Aqui irá ler os registros obtidos através do SqlDataReader
                Dr = Cmd.ExecuteReader();

                // Criando uma lista vazia
                var lista = new List<Funcionario>();

                while (Dr.Read())
                {
                    var func = new Funcionario
                    {
                        IdFuncionario = Convert.ToInt32(Dr["Id"]),
                        Nome = Convert.ToString(Dr["Nome"]),
                        Sobrenome = Convert.ToString(Dr["Sobrenome"]),
                        Cidade = Convert.ToString(Dr["Cidade"]),
                        Endereco = Convert.ToString(Dr["Endereco"]),
                        Email = Convert.ToString(Dr["Email"])
                    };

                    lista.Add(func);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao selecionar o Funcionario: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }           
        }

        // Método: Update
        public bool AtualizarFuncionario(Funcionario func)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("AtualizarFuncionario", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdFuncionario", func.IdFuncionario);
                Cmd.Parameters.AddWithValue("@Nome", func.Nome);
                Cmd.Parameters.AddWithValue("@Sobrenome", func.Sobrenome);
                Cmd.Parameters.AddWithValue("@Endereco", func.Endereco);
                Cmd.Parameters.AddWithValue("@Cidade", func.Cidade);
                Cmd.Parameters.AddWithValue("@Email", func.Email);

                int i = Cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao Atualizar Funcionário: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Método: Delete
        public bool ExcluirFuncionario(int Id)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("DeletarFuncionarioPorId", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdFuncionario", Con);

                int i = Cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir Funcionário: " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}