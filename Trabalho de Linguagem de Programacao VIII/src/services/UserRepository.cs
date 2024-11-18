using Locadora.src.config;
using Locadora.src.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.services
{
    class UserRepository
    {
        private static String SQL = DataBaseConfig.ConnectionString;
        private  SqlConnection connection = new SqlConnection(SQL);
        private  int rowsAffected;

       
        public  void SaveUser(User user)
        {
            try
            {
                connection.Open();
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
                    if (user.ProfileImage != null)
                    {
                        SaveUserImage(user);
                    }
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

        public  void UpdateUser(User user)
        {

            String query;
            try
            {
                query = "UPDATE Usuario SET telefone = @Telefone, endereco = @Endereco, email = @Email WHERE id = @ID";
                connection.Open();


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Telefone", user.Telefone);
                    command.Parameters.AddWithValue("@Endereco", user.Endereco);
                    command.Parameters.AddWithValue("@Email", user.Email.ToLower());


                    command.Parameters.AddWithValue("@ID", user.Id);

                    rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (user.ProfileImage != null)
                    {
                        SaveUserImage(user);
                    }
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

        public  void DeleteUser(User user)
        {
            try
            {
                connection.Open();
                String query = "DELETE FROM Usuario WHERE id = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ID", user.Id);

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

        public  List<User> GetUsers(bool filter, string search)
        {
            List<User> users = new List<User>();

            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Usuario WHERE 1=1");

            if (filter)
            {
                if (!string.IsNullOrEmpty(search))
                {
                    queryBuilder.Append(" AND (");
                    queryBuilder.Append(" cpf =  @Cpf");
                    queryBuilder.Append(" OR LOWER(nome) LIKE @Nome");
                    queryBuilder.Append(" OR LOWER(sobrenome) LIKE @Sobrenome");
                    queryBuilder.Append(" OR LOWER(telefone) LIKE @Telefone");
                    queryBuilder.Append(" OR LOWER(endereco) LIKE @Endereco");
                    queryBuilder.Append(" OR LOWER(email) LIKE @Email");
                    queryBuilder.Append(" OR CONVERT(VARCHAR, data_nasc, 105) LIKE @DataNascimento");
                    queryBuilder.Append(")");
                }
            }

            string query = queryBuilder.ToString();

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (filter)
                    {
                        command.Parameters.AddWithValue("@Cpf", search);
                        command.Parameters.AddWithValue("@Nome", $"%{search.ToLower()}%");
                        command.Parameters.AddWithValue("@Sobrenome", $"%{search.ToLower()}%");
                        command.Parameters.AddWithValue("@Telefone", $"%{search.ToLower()}%");
                        command.Parameters.AddWithValue("@Endereco", $"%{search.ToLower()}%");
                        command.Parameters.AddWithValue("@Email", $"%{search.ToLower()}%");
                        command.Parameters.AddWithValue("@DataNascimento", $"%{search}%");
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(

                                reader["cpf"].ToString(),
                                reader["nome"].ToString(),
                                reader["sobrenome"].ToString(),
                                reader["telefone"].ToString(),
                                reader["endereco"].ToString(),
                                reader["email"].ToString(),
                                Convert.ToDateTime(reader["data_nasc"].ToString()).ToString("dd-MM-yyyy")

                            );
                            user.Id = int.Parse(reader["id"].ToString());
                            if (reader["imagem"] != DBNull.Value)
                            {
                                user.ProfileImage = ImageConverter.ByteArrayToImagem((byte[])reader["imagem"]);
                            }
                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return users;
        }

        private  int GetUserId(User user)
        {
            string query = "SELECT * FROM Usuario " +
                 "WHERE cpf = @Cpf";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cpf", user.Cpf);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = int.Parse(reader["id"].ToString());
                            return id;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return 0;
        }

        private  void SaveUserImage(User user)
        {

            Byte[] imageByte = ImageConverter.ImageToByteArray(user.ProfileImage);

            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();

                Console.WriteLine("salvando imagem");
                string query = "UPDATE Usuario SET imagem = @Imagem WHERE id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Imagem", imageByte);
                    command.Parameters.AddWithValue("@Id", GetUserId(user));

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public  User GetUserById(int id)
        {
            string query = "SELECT * FROM Usuario " +
                 "WHERE id = @Id";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            User user = new User(

                                reader["cpf"].ToString(),
                                reader["nome"].ToString(),
                                reader["sobrenome"].ToString(),
                                reader["telefone"].ToString(),
                                reader["endereco"].ToString(),
                                reader["email"].ToString(),
                                Convert.ToDateTime(reader["data_nasc"].ToString()).ToString("dd-MM-yyyy")

                            );
                            user.Id = int.Parse(reader["id"].ToString());

                            if (reader["imagem"] != DBNull.Value)
                            {
                                user.ProfileImage = ImageConverter.ByteArrayToImagem((byte[])reader["imagem"]);
                            }
                            return user;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }
    }
}
