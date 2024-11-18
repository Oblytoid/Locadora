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
    class PlataformRepository
    {
        private String SQL = DataBaseConfig.ConnectionString;


        public void SavePlataform(PlataformItem plataform)
        {
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open(); string query = "INSERT INTO Plataformas (nome) VALUES (@nome)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", plataform.Name);
                    command.ExecuteNonQuery();
                }
            }
        } 

        public int GetPlataformIdByName(string name)
        {
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                string query = "SELECT id FROM Plataformas WHERE nome = @nome";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", name);
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public PlataformItem GetPlataformById(int id)
        {
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                string query = "SELECT id, nome FROM Plataformas WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PlataformItem(reader.GetInt32(0))
                            {
                                Name = reader.GetString(1)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public String GetPlataformNameById(int id)
        {
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                string query = "SELECT nome FROM Plataformas WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(0);
                            
                        }
                    }
                }
            }
            return "";
        }

        public List<PlataformItem> GetAllPlataforms()
        {
            List<PlataformItem> plataforms = new List<PlataformItem>();

            using (SqlConnection connection = new SqlConnection(SQL))
            {
                connection.Open();
                string query = "SELECT id, nome FROM Plataformas ORDER BY nome";
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PlataformItem plataform = new PlataformItem(reader.GetInt32(0))
                                {
                                    Name = reader.GetString(1)
                                };
                                plataforms.Add(plataform);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Erro:{ex}");
                }
                finally
                {
                    connection.Close();
                }

                return plataforms;
            }
        }
    }
}
