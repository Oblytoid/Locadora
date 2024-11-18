using Locadora.src.config;
using Locadora.src.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.services
{
    class GameRepository
    {
        private static String SQL = DataBaseConfig.ConnectionString;
        private static SqlConnection connection = new SqlConnection(SQL);

        public static void SaveGame(Game game)
        {
            string query = "INSERT INTO Games (titulo, id_genero, id_plataforma, id_publicadora, dataLancamento, Description, image)" +
                           "VALUES (@Titulo, @Id_genero, @Id_plataforma, @Id_publicadora, @DataLancamento, @Description, @Image)";
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Titulo", game.Name);
                        command.Parameters.AddWithValue("@Id_genero", game.Gender.Id);
                        command.Parameters.AddWithValue("@Id_plataforma", game.Plataform.Id);
                        command.Parameters.AddWithValue("@Id_publicadora", game.Publisher.Id);
                        command.Parameters.AddWithValue("@DataLancamento", game.LaunchDate);
                        command.Parameters.AddWithValue("@Description", game.Desc);

                        SqlParameter imageParam = new SqlParameter("@Image", SqlDbType.VarBinary);
                        if (game.GameImage != null)
                        {
                            imageParam.Value = ImageConverter.ImageToByteArray(game.GameImage);
                        }
                        else
                        {
                            imageParam.Value = DBNull.Value;
                        }
                        command.Parameters.Add(imageParam);

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.LineNumber);
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }

        public static List<Game> GetAllGame()
        {
            List<Game> games = new List<Game>();
            
            string query = "SELECT g.image, g.id, g.titulo, g.Description, g.dataLancamento, p.nome AS PlatformName, f.nome AS ManufacturerName, gen.nome AS GenreName " +
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
                        PlataformRepository plataformRepository = new PlataformRepository();
                        while (reader.Read())
                        {

                            int id = int.Parse(reader["id"].ToString());
                            string name = reader["titulo"].ToString();
                            string desc = reader["Description"].ToString();                            
                            string platformName = reader["PlatformName"].ToString();
                            string manufacturerName = reader["ManufacturerName"].ToString();
                            string genderName = reader["GenreName"].ToString();
                            PlataformItem plataform = new PlataformItem(plataformRepository.GetPlataformIdByName(platformName));
                            GenderItem gender = new GenderItem(genderName);
                            Game game = new Game(name, desc, plataform, gender)
                            {
                                LaunchDate = Convert.ToDateTime(reader["dataLancamento"].ToString()).ToString("dd-MM-yyyy")
                            };


                            if (reader["image"] != DBNull.Value)
                            {
                                game.GameImage = ImageConverter.ByteArrayToImagem((byte[])reader["image"]);
                            }

                            game.Id = int.Parse(reader["id"].ToString());
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

        public static void UpdateGame(Game game)
        {
            string query = "UPDATE Games SET titulo = @Titulo, id_genero = @Id_genero, id_plataforma = @Id_plataforma, " +
                           "id_publicadora = @Id_publicadora, dataLancamento = @DataLancamento, Description = @Description, image = @Image " +
                           "WHERE id = @Id";
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Titulo", game.Name);
                        command.Parameters.AddWithValue("@Id_genero", game.Gender.Id);
                        command.Parameters.AddWithValue("@Id_plataforma", game.Plataform.Id);
                        command.Parameters.AddWithValue("@Id_publicadora", game.Publisher.Id);
                        command.Parameters.AddWithValue("@DataLancamento", game.LaunchDate);
                        command.Parameters.AddWithValue("@Description", game.Desc);
                        command.Parameters.AddWithValue("@Image", game.GameImage != null ? ImageConverter.ImageToByteArray(game.GameImage) : (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Id", game.Id);

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }

        public static void DeleteGame(int id)
        {
            string query = "DELETE FROM Games WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }

        public static List<Game> SearchGames(string search)
        {
            List<Game> games = new List<Game>();
            StringBuilder queryBuilder = new StringBuilder("SELECT g.image, g.id, g.titulo, g.Description, g.dataLancamento, p.nome AS PlatformName, f.nome AS ManufacturerName, gen.nome AS GenreName "
                + "FROM Games g "
                + "JOIN Plataformas p ON g.id_plataforma = p.id "
                + "JOIN Fabricantes f ON p.fabricanteID = f.id "
                + "JOIN Generos gen ON g.id_genero = gen.id "
                + "WHERE 1=1");

            if (!string.IsNullOrEmpty(search))
            {
                queryBuilder.Append(" AND (");
                queryBuilder.Append(" LOWER(g.titulo) LIKE @search");
                queryBuilder.Append(" OR LOWER(gen.nome) LIKE @search");
                queryBuilder.Append(" OR LOWER(p.nome) LIKE @search");
                queryBuilder.Append(" OR LOWER(f.nome) LIKE @search");
                queryBuilder.Append(" OR CONVERT(VARCHAR, g.dataLancamento, 105) LIKE @search");
                queryBuilder.Append(")");
            }

            queryBuilder.Append(" ORDER BY g.titulo");

            string query = queryBuilder.ToString();
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(search))
                    {
                        command.Parameters.AddWithValue("@search", $"%{search.ToLower()}%");
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        PlataformRepository plataformRepository = new PlataformRepository();
                        while (reader.Read())
                        {
                            int id = int.Parse(reader["id"].ToString());
                            string name = reader["titulo"].ToString();
                            string desc = reader["Description"].ToString();
                            string launchDate = reader.GetDateTime(4).ToString("yyyy-MM-dd");
                            string platformName = reader["PlatformName"].ToString();
                            string manufacturerName = reader["ManufacturerName"].ToString();
                            string genderName = reader["GenreName"].ToString();
                            PlataformItem plataform = new PlataformItem(plataformRepository.GetPlataformIdByName(platformName));
                            GenderItem gender = new GenderItem(genderName);
                            Game game = new Game(name, desc, plataform, gender);
                            if (reader["image"] != DBNull.Value)
                            {
                                game.GameImage = ImageConverter.ByteArrayToImagem((byte[])reader["image"]);
                            }
                            game.Id = id; games.Add(game);
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

        public static List<Game> GetGamesByPlatform(int platformId)
        {
            List<Game> games = new List<Game>();

            string query = "SELECT g.image, g.id, g.titulo, g.Description, g.dataLancamento, p.nome AS PlatformName, f.nome AS ManufacturerName, gen.nome AS GenreName " +
                           "FROM Games g " +
                           "JOIN Plataformas p ON g.id_plataforma = p.id " +
                           "JOIN Fabricantes f ON p.fabricanteID = f.id " +
                           "JOIN Generos gen ON g.id_genero = gen.id " +
                           "WHERE g.id_plataforma = @platformId";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@platformId", platformId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        PlataformRepository plataformRepository = new PlataformRepository();
                        while (reader.Read())
                        {
                            int id = int.Parse(reader["id"].ToString());
                            string name = reader["titulo"].ToString();
                            string desc = reader["Description"].ToString();
                            string launchDate = reader.GetDateTime(4).ToString("yyyy-MM-dd");
                            string platformName = reader["PlatformName"].ToString();
                            string manufacturerName = reader["ManufacturerName"].ToString();
                            string genderName = reader["GenreName"].ToString();
                            PlataformItem plataform = new PlataformItem(plataformRepository.GetPlataformIdByName(platformName));
                            GenderItem gender = new GenderItem(genderName);
                            Game game = new Game(name, desc, plataform, gender);

                            if (reader["image"] != DBNull.Value)
                            {
                                game.GameImage = ImageConverter.ByteArrayToImagem((byte[])reader["image"]);
                            }

                            game.Id = id;
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

        public static List<Game> GetGamesByPublisher(int publisherId)
        {
            List<Game> games = new List<Game>();

            string query = "SELECT g.image, g.id, g.titulo, g.Description, g.dataLancamento, p.nome AS PlatformName, f.nome AS ManufacturerName, gen.nome AS GenreName " +
                           "FROM Games g " +
                           "JOIN Plataformas p ON g.id_plataforma = p.id " +
                           "JOIN Fabricantes f ON p.fabricanteID = f.id " +
                           "JOIN Generos gen ON g.id_genero = gen.id " +
                           "WHERE g.id_publicadora = @publisherId";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@publisherId", publisherId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        PlataformRepository plataformRepository = new PlataformRepository();
                        while (reader.Read())
                        {
                            int id = int.Parse(reader["id"].ToString());
                            string name = reader["titulo"].ToString();
                            string desc = reader["Description"].ToString();
                            string launchDate = reader.GetDateTime(4).ToString("yyyy-MM-dd");
                            string platformName = reader["PlatformName"].ToString();
                            string manufacturerName = reader["ManufacturerName"].ToString();
                            string genderName = reader["GenreName"].ToString();
                            PlataformItem plataform = new PlataformItem(plataformRepository.GetPlataformIdByName(platformName));
                            GenderItem gender = new GenderItem(genderName);
                            Game game = new Game(name, desc, plataform, gender);

                            if (reader["image"] != DBNull.Value)
                            {
                                game.GameImage = ImageConverter.ByteArrayToImagem((byte[])reader["image"]);
                            }

                            game.Id = id;
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

        private static void SaveGameImage(Game game)
        {

            Byte[] imageByte = ImageConverter.ImageToByteArray(game.GameImage);

            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();

                Console.WriteLine("salvando image");
                string query = "UPDATE Games SET image = @Image WHERE id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Image", imageByte);
                    command.Parameters.AddWithValue("@Id", GetGameIdByName(game));

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static int GetGameIdByName(Game game)
        {
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open(); string query = "SELECT id FROM Games WHERE titulo = @titulo"; using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@titulo", game.Name);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }
    }
}
