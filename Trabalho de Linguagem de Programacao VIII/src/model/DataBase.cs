using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Locadora.src.controller;


namespace Locadora.src.model
{
    class DataBase
    {
        
        //Como funciona: (Servidor; Segurança do acesso ao banco de dados; nome do banco de dados)
        //@"Data Source=LABHW-08; integrated security=SSPI;initial catalog=Locadora"
        private const String SQL = @"Data Source=DESKTOP-FQKS1SS\SQLEXPRESS; integrated security=SSPI;initial catalog=Locadora";
        private static SqlConnection connection = new SqlConnection(SQL);
        private static int rowsAffected;

        public static void saveUser(User user)
        {
            connection.Open();
            try
            {
                String query = "INSERT INTO Usuario (cpf, nome, sobrenome, telefone, endereco, email, data_nasc) " +
                                        "VALUES (@Cpf, @Nome, @Sobrenome, @Telefone, @Endereco, @Email, @DataNascimento)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", user.Cpf);
                    command.Parameters.AddWithValue("@Nome", user.Nome.ToLower());
                    command.Parameters.AddWithValue("@Sobrenome", user.Sobrenome.ToLower());
                    command.Parameters.AddWithValue("@Telefone", user.Telefone.ToLower());
                    command.Parameters.AddWithValue("@Endereco", user.Endereco.ToLower());
                    command.Parameters.AddWithValue("@Email", user.Email.ToLower());
                    command.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.Out.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Número de linhas afetadas: {rowsAffected}");
                connection.Close();
            }
        }

        public static void readUser()
        {
            connection.Open();
            try
            {

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
