using CompraRápida.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CompraRápida.repositorio
{
    public class ClienteService
    {
        private readonly string _connectionString;

        public ClienteService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void InserirCliente(Cliente cliente)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Cliente (cpf, email, senha, nomeCliente) VALUES (@cpf, @email, @senha, @nomeCliente)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cliente.CPF;
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = cliente.Email;
                    command.Parameters.Add("@senha", SqlDbType.VarChar).Value = cliente.Senha;
                    command.Parameters.Add("@nomeCliente", SqlDbType.VarChar).Value = cliente.NomeCliente;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}