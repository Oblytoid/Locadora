﻿using Locadora.src.config;
using Locadora.src.model;
using Locadora.src.model.Locadora.src.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Locadora.src.services
{
    public class LocacaoRepository
    {
        private static string SQL = DataBaseConfig.ConnectionString;

        public void SaveLocation(LocationItem locacao)
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
                }
            }
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

        public List<LocationItem> GetAllLocations()
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
