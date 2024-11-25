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
using Locadora.src.services;

namespace Locadora
{
    public partial class User_Update : Form
    {
        User user;
        bool saveImage = false;
        public User_Update(User user)
        {
            InitializeComponent();

            this.user = user;

            ShowUser();
        }

        public void ShowUser()
        {
            
            picture_user.Image = user.ProfileImage;
            lbl_cpf_show.Text = TextFormat.cpfFormat(user.Cpf);
            lbl_first_name_show.Text = user.Nome;
            lbl_last_name_show.Text = user.Sobrenome;
            txt_endereco.Text = user.Endereco;
            txt_email.Text = user.Email;
            txt_telefone.Text = user.Telefone;
            lbl_date_show.Text = user.DataNascimento;
        }

        private void picture_user_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Arquivos de Imagem (.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    saveImage = true;
                    picture_user.Image = Image.FromFile(imagePath);

                    user.ProfileImage = picture_user.Image;
                }
            }
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btt_update_Click(object sender, EventArgs e)
        {
            if (Required.CheckRequiredField(txt_email,txt_endereco,txt_telefone))
            {
                user.Email = txt_email.Text;
                user.Endereco = txt_endereco.Text;
                user.Telefone = txt_telefone.Text;
                user.ProfileImage = picture_user.Image;
                UserController.UpdateUser(user, saveImage);
            }
            UserController.UpdateUser(user, saveImage);
            this.Close();
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

        private void User_Update_Load(object sender, EventArgs e)
        {

        }
    }
}
