using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace CompraRápida.DbContext
{
    public class DatabaseService
    {
        private string strConexao;
        private SqlConnection conexao;

        public DatabaseService(IConfiguration configuration)
        {
            strConexao = configuration.GetConnectionString("DefaultConnection");
            conexao = new SqlConnection(strConexao);

            conexao.Open();
        }
    }
}