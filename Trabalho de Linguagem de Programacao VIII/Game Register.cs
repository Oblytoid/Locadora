using Locadora.src.controller;
using Locadora.src.model;
using Locadora.src.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class Game_Register : Form
    {
        private Size originalSize;
        private Size increasedSize;


        public Game_Register()
        {
            InitializeComponent();

            originalSize = listbox_plataform.Size;
            increasedSize = new Size(originalSize.Width, originalSize.Height + 40);
            RefleshListBox();
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void RefleshListBox()
        {            
            foreach (PlataformItem pf in PlataformController.GetAll())
            {
                if (!listbox_plataform.Items.Contains(pf))
                {
                    listbox_plataform.Items.Add(pf);
                }
            }

            foreach (GenderItem gr in GenderController.GetAllGenders())
            {
                if (!listbox_gender.Items.Contains(gr))
                {
                    listbox_gender.Items.Add(gr);
                }
            }

            foreach (PublisherItem pb in PublisherController.GetAllPublishers())
            {
                if (!listbox_publisher.Items.Contains(pb))
                {
                    listbox_publisher.Items.Add(pb);
                }
            }
        }
        

        private void game_pictureBox_Click(object sender, EventArgs e)
        {
            game_pictureBox.Image = ImageHelper.OpenImageFromFile();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listbox_plataform_MouseEnter(object sender, EventArgs e)
        {
            listbox_plataform.Size = increasedSize;
        }

        private void listbox_plataform_MouseLeave(object sender, EventArgs e)
        {
            listbox_plataform.Size = originalSize;
            CenterSelectedItem(sender as ListBox);
        }

        private void listBox_gender_MouseEnter(object sender, EventArgs e)
        {
            listbox_gender.Size = increasedSize;
        }

        private void listBox_gender_MouseLeave(object sender, EventArgs e)
        {
            listbox_gender.Size = originalSize;
            CenterSelectedItem(sender as ListBox);
        }
        
        private void CenterSelectedItem(ListBox listBox)
        {

            int selectedIndex = listBox.SelectedIndex;
            int halfVisibleItems = listBox.ClientSize.Height / listBox.ItemHeight / 2;
            listBox.TopIndex = Math.Max(selectedIndex - halfVisibleItems, 0);
        }

        private void listbox_publisher_MouseEnter(object sender, EventArgs e)
        {
            listbox_publisher.Size = increasedSize;
        }

        private void listbox_publisher_MouseLeave(object sender, EventArgs e)
        {
            listbox_publisher.Size = originalSize;
            CenterSelectedItem(sender as ListBox);
        }

        private void btn_newgame_Click(object sender, EventArgs e)
        {
            if (listbox_plataform.SelectedItem == null || listbox_gender.SelectedItem == null || listbox_publisher.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione todas as opções: Plataforma, Gênero e Publicadora.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_gameName.Text) || string.IsNullOrWhiteSpace(txt_gameDescription.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios: Nome do Jogo e Descrição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gameName = txt_gameName.Text;
            string gameDesc = txt_gameDescription.Text;
            DateTime launchDate = dtp_LaunchDate.Value;
            PlataformItem selectedPlatform = (PlataformItem)listbox_plataform.SelectedItem;
            GenderItem selectedGender = (GenderItem)listbox_gender.SelectedItem;
            PublisherItem selectedPublisher = (PublisherItem)listbox_publisher.SelectedItem;
            Image gameImage = game_pictureBox.Image;

            Game newGame = new Game(gameName, gameDesc, selectedPlatform, selectedGender)
            {
                LaunchDate = launchDate.ToString(),
                Publisher = selectedPublisher,
                GameImage = gameImage
            };

            GameController.RegisterGame(newGame);

            MessageBox.Show("Jogo registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void listbox_publisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Game_Register_Load(object sender, EventArgs e)
        {

        }
    }
}
