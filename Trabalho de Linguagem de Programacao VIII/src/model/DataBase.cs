using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Locadora.src.controller;
using System.Data;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Locadora.src.model
{
    class DataBase
    {

        //Como funciona: (Servidor; Segurança do acesso ao banco de dados; nome do banco de dados)
        //"Data Source=LAB3-12;integrated security=SSPI;initial catalog=Locadora"
        //@"Data Source=LABHW-08; integrated security=SSPI;initial catalog=Locadora"
        //@"Data Source=DESKTOP-FQKS1SS\SQLEXPRESS; integrated security=SSPI;initial catalog=Locadora";

        private const String SQL = @"Data Source=LABHW-32; integrated security=SSPI;initial catalog=Locadora";
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

            

            string query;

            if (fill)
            {
                query = "SELECT * FROM Usuario " +
                 "WHERE cpf = @Cpf OR " +
                 "LOWER(nome) LIKE @Nome OR " +
                 "LOWER(sobrenome) LIKE @Sobrenome OR " +
                 "LOWER(telefone) LIKE @Telefone OR " +
                 "LOWER(endereco) LIKE @Endereco OR " +
                 "LOWER(email) LIKE @Email OR " +
                 "CONVERT(VARCHAR, data_nasc, 105) LIKE @DataNascimento";
            }
            else
            {
                query = "SELECT * FROM Usuario";
            }
            

            try
            {
                connection.Open();
                using (SqlCommand command =  new SqlCommand(query, connection))
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

        public static void SaveImage(string name, byte[] image)
        {
            using(SqlConnection connection = new SqlConnection(SQL))
            {
                string query = "INSERT INTO Imagens (Nome, Imagem) VALUES (@Nome, @Imagem)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", name);
                    command.Parameters.AddWithValue("@Imagem", image);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static byte[] GetImage(int id)
        {
            byte[] image = null;
            using (SqlConnection connection = new SqlConnection(SQL))
            {
                string query = "SELECT Imagem FROM Imagens WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            image = reader["Imagem"] as byte[];
                        }
                    }
                }
            }
            return image;
        }

        public Image ByteArrayParaImagem(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        public void ExibirImagemNoPictureBox(int id, PictureBox pictureBox)
        {
            byte[] image = GetImage(id);
            if (image != null)
            {
                pictureBox.Image = ByteArrayParaImagem(image);
            }
            else
            {
                MessageBox.Show("Imagem não encontrada.");
            }
        }
    }
}
