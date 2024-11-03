﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.src.view;
using System.IO;

namespace Locadora
{

    public partial class Home : Form
    {
        

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "src", "font", "Pretendo.ttf");
            
            TextFont.ButtonUseCustomFont(path, 8, btn_close);
            TextFont.ButtonUseCustomFont(path, 8, btn_alocar);
            TextFont.ButtonUseCustomFont(path, 8, btn_userManagement);
            TextFont.ButtonUseCustomFont(path, 8, btn_gameManagement);
        }
        

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUser cadastrar = new RegisterUser();
            cadastrar.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestãoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Management gerenciar = new User_Management();
            gerenciar.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogo_Jogos catalogo = new Catalogo_Jogos();
            catalogo.ShowDialog();
        }

        private void picture_user_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_userManagement_Click(object sender, EventArgs e)
        {
            User_Management gestaoUsuario = new User_Management();
            gestaoUsuario.Show();
        }

    }
}