using Locadora.src.config;
using Locadora.src.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Locadora.src.services
{
    public class GenderRepository
    {
        private static string SQL = DataBaseConfig.ConnectionString;
        private static SqlConnection connection = new SqlConnection(SQL);

        public void SaveGender(GenderItem gender)
        {
            string query = "INSERT INTO Generos (nome, descricao) VALUES (@nome, @descricao)";
            connection.Open();

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", gender.Name);
                    command.Parameters.AddWithValue("@descricao", gender.Description);
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

        public void DeleteGender(int id)
        {
            string query = "DELETE FROM Generos WHERE id = @id";
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
            finally
            {
                connection.Close();
            }
        }

        public void UpdateGender(GenderItem gender)
        {
            string query = "UPDATE Generos SET nome = @nome, descricao = @descricao WHERE id = @id";
            connection.Open();

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", gender.Name);
                    command.Parameters.AddWithValue("@descricao", gender.Description);
                    command.Parameters.AddWithValue("@id", gender.Id);
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

        public List<GenderItem> GetAllGenders()
        {
            List<GenderItem> genders = new List<GenderItem>();
            string query = "SELECT id, nome, descricao FROM Generos ORDER BY nome";

            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GenderItem gender = new GenderItem(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            genders.Add(gender);
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

            return genders;
        }

        public GenderItem GetGenderById(int id)
        {
            string query = "SELECT id, nome, descricao FROM Generos WHERE id = @id";
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
                            return new GenderItem(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
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
