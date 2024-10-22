using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Trabalho_de_Linguagem_de_Programacao_VIII.src.textFormat;


namespace Trabalho_de_Linguagem_de_Programacao_VIII
{
    public partial class Cadastrar_Usuario : Form
    {
        public Cadastrar_Usuario()
        {
            InitializeComponent();
        }

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
              
                string formattedInput = cpfFormat(txt_cpf.Text); // Formata o CPF
                textBox.Text = formattedInput;

                textBox.SelectionStart = formattedInput.Length;
            }
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                String formattedInput = telFormat(txt_telefone.Text);
                textBox.Text = formattedInput;
                
                textBox.SelectionStart = formattedInput.Length;
            }
        }
    }
}
