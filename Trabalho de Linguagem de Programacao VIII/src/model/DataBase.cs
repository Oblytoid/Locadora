using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace Locadora.src.model
{
    class DataBase
    {
        private const String SQL = @"Data Source=DESKTOP-FQKS1SS\SQLEXPRESS; integrated security=SSPI;initial catalog=Locadora";
        private static SqlConnection connection = new SqlConnection(SQL);
        private static int rowsAffected;

        public static void saveUser(User user)
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

        public static List<User> GetUsers(bool fill = false, string search = "")
        {
            List<User> users = new List<User>();

            StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Usuario WHERE 1=1");

            if (fill)
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
                    if (fill)
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
                            if (reader["profileImage"] != DBNull.Value)
                            {
                                user.ProfileImage = ByteArrayToImagem((byte[])reader["profileImage"]);
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

        public static int GetUserId(User user)
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

        public static void SaveImage(User user, byte[] image)
        {
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                string query = "INSERT INTO Usuario (Nome, Imagem) VALUES (@Nome, @Imagem)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", user.Id);
                    command.Parameters.AddWithValue("@Imagem", image);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static byte[] GetImage(int id)
        {
            byte[] image = null;
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                string query = "SELECT FROM Imagens WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            image = reader["imagem"] as byte[];
                        }
                    }
                }
            }
            return image;
        }

        public Image GetUserImage(User user)
        {
            byte[] bytes = null;
            Image image = null;
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                string query = "SELECT FROM profileImage WHERE id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", user.Id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bytes = reader["profileImage"] as byte[];
                        }
                    }
                }
            }
            image = ByteArrayToImagem(bytes);
            return image;
        }

        public void SaveUserImage(User user,Image image)
        {

            Byte[] imageByte = ImageToByteArray(image);

            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                string query = "UPDATE Usuario SET profileImage = @ProfileImage WHERE id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProfileImage", imageByte);
                    command.Parameters.AddWithValue("@Id", user.Id);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static Image ByteArrayToImagem(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Console.WriteLine(ms);
                return Image.FromStream(ms);
            }
        }

        private static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public void ExibirImagemNoPictureBox(int id, PictureBox pictureBox)
        {
            byte[] image = GetImage(id);
            if (image != null)
            {
                pictureBox.Image = ByteArrayToImagem(image);
            }
        }

    }
}