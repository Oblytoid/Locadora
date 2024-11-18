using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.src.controller;
using Locadora.src.model;
using Locadora.src.utils;

namespace Locadora
{
    public partial class RegisterUser : Form
    {

        
        public RegisterUser()
        {
            InitializeComponent();

        }
        private void picture_user_Click(object sender, EventArgs e)
        {   
            picture_user.Image = ImageHelper.OpenImageFromFile();  
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

        private void txt_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Required.onlyNumber(e,txt_cpf);
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
  
            if (Required.CheckRequiredField(txt_nome, txt_endereco, txt_cpf, txt_sobrenome, txt_telefone))
            {

                User user = new User(
                TextFormat.cpfFormat(txt_cpf.Text, true), txt_nome.Text, txt_sobrenome.Text,
                txt_telefone.Text, txt_endereco.Text, txt_email.Text, dtp_nascimento.Text);

                if (picture_user.Image != null)
                    user.ProfileImage = picture_user.Image;

                UserController.RegisterUser(user);
                
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
