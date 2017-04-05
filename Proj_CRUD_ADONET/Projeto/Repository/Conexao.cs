using System;
using System.Data.SqlClient;

namespace Projeto.Repository
{
    public class Conexao
    {
        protected SqlConnection Con;

        protected SqlCommand Cmd;

        protected SqlDataReader Dr;

        //Método para abrir a conexão com o SqlServer:
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=PCGLAUCIA\\SQLSERVER14;Initial Catalog=master;Integrated Security=True");
                Con.Open();
            }
            catch (Exception e)
            {   
                // Caso dê algum problema, enviar uma mensagem informando o erro:
                throw new Exception("Erro ao abrir a conexão: " + e.Message);
            }
        }

        //Método para fechar a conexão:
        protected void FecharConexao()
        {
            try
            {
                if (Con != null)
                {
                    Con.Close();
                }
            }
            catch (Exception e)
            {
                // Caso dê algum problema, enviar uma mensagem informando o erro:
                throw new Exception("Erro ao fechar a conexão: " + e.Message);
            }
        }
    }
}