using Locadora.src.config;
using Locadora.src.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Locadora.src.services
{
    public class LocacaoRepository
    {
        private static string SQL = DataBaseConfig.ConnectionString;

        public bool SaveLocation(LocationItem locacao)
        {
            string query = "INSERT INTO Locacao (id_usuario, id_game, data_inicio, data_entrega, entregue) " +
                           "VALUES (@id_usuario, @id_game, @data_inicio, @data_entrega, @entregue)";

            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_usuario", locacao.UserId);
                        command.Parameters.AddWithValue("@id_game", locacao.GameId);
                        command.Parameters.AddWithValue("@data_inicio", locacao.DataInicio);
                        command.Parameters.AddWithValue("@data_entrega", locacao.DataEntrega);
                        command.Parameters.AddWithValue("@entregue", locacao.Entregue);

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
            return true;
        }

        public void DeleteLocation(int id)
        {
            string query = "DELETE FROM Locacao WHERE id = @id";

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

        public void UpdateLocation(LocationItem locacao)
        {
            string query = "UPDATE Locacao SET id_usuario = @id_usuario, id_game = @id_game, data_inicio = @data_inicio, " +
                           "data_entrega = @data_entrega, entregue = @entregue WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_usuario", locacao.UserId);
                        command.Parameters.AddWithValue("@id_game", locacao.GameId);
                        command.Parameters.AddWithValue("@data_inicio", locacao.DataInicio);
                        command.Parameters.AddWithValue("@data_entrega", locacao.DataEntrega);
                        command.Parameters.AddWithValue("@entregue", locacao.Entregue);
                        command.Parameters.AddWithValue("@id", locacao.Id);

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }

        /*public List<LocationItem> GetAllLocations()
        {
            List<LocationItem> locacoes = new List<LocationItem>();
            string query = "SELECT id, id_usuario, id_game, data_inicio, data_entrega, entregue FROM Locacao";

            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LocationItem locacao = new LocationItem(
                                    reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetInt32(2),
                                    reader.GetDateTime(3),
                                    reader.GetDateTime(4),
                                    reader.GetBoolean(5)
                                );
                                locacoes.Add(locacao);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }

            return locacoes;
        }
        */
        public List<LocationItem> GetAllLocations()
        {
            List<LocationItem> locacoes = new List<LocationItem>();
            string query = "SELECT l.id, l.id_usuario, u.nome AS UserName, l.id_game, g.titulo AS GameName, l.data_inicio, l.data_entrega, l.entregue " +
                           "FROM Locacao l " +
                           "JOIN Usuario u ON l.id_usuario = u.id " +
                           "JOIN Games g ON l.id_game = g.id";

            try
            {
                using (SqlConnection connection = new SqlConnection(SQL))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(reader.GetOrdinal("id"));
                                int userId = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                                string userName = reader.GetString(reader.GetOrdinal("UserName"));
                                int gameId = reader.GetInt32(reader.GetOrdinal("id_game"));
                                string gameName = reader.GetString(reader.GetOrdinal("GameName"));
                                DateTime dataInicio = reader.GetDateTime(reader.GetOrdinal("data_inicio"));
                                DateTime dataEntrega = reader.GetDateTime(reader.GetOrdinal("data_entrega"));
                                bool entregue = reader.GetBoolean(reader.GetOrdinal("entregue"));

                                LocationItem locacao = new LocationItem(id, userId, gameId, dataInicio, dataEntrega, entregue)
                                {
                                    GameName = gameName,
                                    UserName = userName
                                };
                                locacoes.Add(locacao);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                using (SqlConnection connection = new SqlConnection(SQL))
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return locacoes;
        }

        public void MarkAsDelivered(int id)
        {
            string query = "UPDATE Locacao SET entregue = @entregue WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@entregue", true);
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


        public static int GetLocationId(int userId, int gameId, DateTime dataInicio)
        {
            string query = "SELECT id FROM Locacao WHERE id_usuario = @id_usuario AND id_game = @id_game AND data_inicio = @data_inicio";
            using (SqlConnection connection = new SqlConnection(SQL))
            { connection.Open();
                try {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_usuario", userId);
                        command.Parameters.AddWithValue("@id_game", gameId);
                        command.Parameters.AddWithValue("@data_inicio", dataInicio);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) { return reader.GetInt32(0);
                            }
                        }
                    }
                } catch (SqlException ex) { Console.WriteLine($"Erro: {ex.Message}");
                }
            }
            return -1;
        }

        public LocationItem GetLocationById(int id)
        {
            string query = "SELECT id, id_usuario, id_game, data_inicio, data_entrega, entregue FROM Locacao WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new LocationItem(
                                    reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetInt32(2),
                                    reader.GetDateTime(3),
                                    reader.GetDateTime(4),
                                    reader.GetBoolean(5)
                                );
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }

            return null;
        }
    }
}
