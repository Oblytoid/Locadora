using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Trabalho_de_Linguagem_de_Programacao_VIII.src.controller;
using Trabalho_de_Linguagem_de_Programacao_VIII.src.model;


namespace Trabalho_de_Linguagem_de_Programacao_VIII
{
    public partial class Cadastrar_Usuario : Form
    {
        public Cadastrar_Usuario()
        {
            InitializeComponent();

        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-FQKS1SS\SQLEXPRESS; integrated security=SSPI;initial catalog=Locadora");
        //SqlConnection cn = new SqlConnection(@"Data Source=LABHW-08; integrated security=SSPI;initial catalog=Locadora1");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_dataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void lbl_endereco_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cpf_TextChanged(object sender, EventArgs e)
        {
            
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
              
                string formattedInput = TextFormat.cpfFormat(txt_cpf.Text); // Formata o CPF
                textBox.Text = formattedInput;

                textBox.SelectionStart = formattedInput.Length;
            }
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                String formattedInput = TextFormat.telFormat(txt_telefone.Text);
                textBox.Text = formattedInput;
                
                textBox.SelectionStart = formattedInput.Length;
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Required.CheckRequiredField(txt_nome,txt_endereco,txt_cpf);
            try
            {
                cn.Open();
                String query = "INSERT INTO Usuario (cpf, nome, sobrenome, telefone, endereco, email, data_nasc) " +
                                        "VALUES (@Cpf, @Nome, @Sobrenome, @Telefone, @Endereco, @Email, @DataNascimento)";

                using (SqlCommand command = new SqlCommand(query, cn))
                {

                    command.Parameters.AddWithValue("@Cpf", txt_cpf.Text);
                    command.Parameters.AddWithValue("@Nome", txt_nome.Text);
                    command.Parameters.AddWithValue("@Sobrenome", txt_sobrenome.Text);
                    command.Parameters.AddWithValue("@Telefone", txt_telefone.Text);
                    command.Parameters.AddWithValue("@Endereco", txt_endereco.Text);
                    command.Parameters.AddWithValue("@Email", txt_email.Text);
                    command.Parameters.AddWithValue("@DataNascimento", dtp_nascimento.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"Número de linhas afetadas: {rowsAffected}");
                }
            }catch(Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
