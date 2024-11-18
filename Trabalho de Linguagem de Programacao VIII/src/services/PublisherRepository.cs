using Locadora.src.config;
using Locadora.src.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Locadora.src.services
{
    public class PublisherRepository
    {
        private static string SQL = DataBaseConfig.ConnectionString;
        private static SqlConnection connection = new SqlConnection(SQL);

        public void SavePublisher(PublisherItem publisher)
        {
            string query = "INSERT INTO Publicadora (nome) VALUES (@nome)";
            connection.Open();

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", publisher.Name);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeletePublisher(int id)
        {
            string query = "DELETE FROM Publicadora WHERE ID = @ID";
            connection.Open();

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdatePublisher(PublisherItem publisher)
        {
            string query = "UPDATE Publicadora SET nome = @nome WHERE ID = @ID";
            connection.Open();

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", publisher.Name);
                    command.Parameters.AddWithValue("@ID", publisher.Id);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        public List<PublisherItem> GetAllPublishers()
        {
            List<PublisherItem> publishers = new List<PublisherItem>();
            string query = "SELECT ID, nome FROM Publicadora ORDER BY nome";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PublisherItem publisher = new PublisherItem(reader.GetInt32(0), reader.GetString(1));
                            publishers.Add(publisher);
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
                connection.Close();
            }

            return publishers;
        }

        public PublisherItem GetPublisherById(int id)
        {
            string query = "SELECT ID, nome FROM Publicadora WHERE ID = @ID";
            connection.Open();

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PublisherItem(reader.GetInt32(0), reader.GetString(1));
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
                connection.Close();
            }

            return null;
        }
    }
}
