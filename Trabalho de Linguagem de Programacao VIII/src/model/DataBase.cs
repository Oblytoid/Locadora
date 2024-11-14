using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Drawing.Imaging;

namespace Locadora.src.model
{
    class DataBase
    {
        private const String SQL = @"Data Source=DESKTOP-FQKS1SS\SQLEXPRESS; integrated security=SSPI;initial catalog=Locadora";
        private static SqlConnection connection = new SqlConnection(SQL);
        private static int rowsAffected;

        public static void SaveUser(User user)
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
        }//Melhorar

        public static void UpdateUser(User user)
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

        public static void DeleteUser(User user)
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

        private static int GetUserId(User user)
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
        }//Não esta sendo utilizado.

        

        private static void SaveUserImage(User user)
        {

            Byte[] imageByte = ImageToByteArray(user.ProfileImage);

            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();

                Console.WriteLine("salvando image");
                string query = "UPDATE Usuario SET profileImage = @ProfileImage WHERE id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProfileImage", imageByte);
                    command.Parameters.AddWithValue("@Id", GetUserId(user));

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }// Tentar substituir pelo SaveImage, deixar algo mais generico.


        public static List<Game> GetGameList(bool fill = false, string search)
        {
            List<Game> games = new List<Game>();

            string query = "SELECT g.id, g.titulo, g.Description, g.dataLancamento, p.nome AS PlatformName, f.nome AS ManufacturerName, gen.nome AS GenreName " + 
                "FROM Games g " +
                "JOIN Plataformas p ON g.id_plataforma = p.id " + 
                "JOIN Fabricantes f ON p.fabricanteID = f.id " + 
                "JOIN Generos gen ON g.id_genero = gen.id";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string desc = reader.GetString(2);
                            string launchDate = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                            string platformName = reader.GetString(4);
                            string manufacturerName = reader.GetString(5);
                            string genreName = reader.GetString(6);
                            PlataformItem plataform = new PlataformItem(platformName, false);
                            GenderItem gender = new GenderItem(genreName);
                            Game game = new Game(name, desc, plataform, gender) 

                                

                            );
                            game.id = int.Parse(reader["id"].ToString());
                            if (reader["gameImage"] != DBNull.Value)
                            {
                                game.gameImage = ByteArrayToImagem((byte[])reader["profileImage"]);
                            }
                            games.Add(game);
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

            return games;
        }

        public static Image ByteArrayToImagem(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                throw new ArgumentException("O array de bytes não pode ser nulo ou vazio.", nameof(byteArray));

            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao converter byte array para imagem: {ex.Message}");
                throw;
            }
        }

        private static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image), "A imagem não pode ser nula.");

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {

                    if (ImageFormat.Jpeg.Equals(image.RawFormat) ||
                        ImageFormat.Png.Equals(image.RawFormat) ||
                        ImageFormat.Bmp.Equals(image.RawFormat) ||
                        ImageFormat.Gif.Equals(image.RawFormat))
                    {
                        image.Save(ms, image.RawFormat);
                        return ms.ToArray();
                    }
                    else
                    {
                        throw new InvalidOperationException("Formato de imagem não suportado.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao converter a imagem para byte array: {ex.Message}");
                throw;
            }
        }
    }
}