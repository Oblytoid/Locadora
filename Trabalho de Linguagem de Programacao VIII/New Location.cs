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

namespace Locadora
{
    public partial class New_Alocation : Form
    {
        private Size originalSize;
        private Size increasedSize;

        public New_Alocation()
        {
            InitializeComponent();
            RefreshListBox();
            dateTimePicker_withdrawal.Value = DateTime.Now;
            dateTimePicker_devolution.Value = dateTimePicker_withdrawal.Value.AddDays(7);
            originalSize = listBox_user.Size;
            increasedSize = new Size(originalSize.Width, originalSize.Height + 60);
        }

        private void RefreshListBox()
        {
            foreach (User user in UserController.GetAllUsers())
            {
                if (!listBox_user.Items.Contains(user.Cpf))
                {
                    listBox_user.Items.Add(user);
                }
            }

            foreach (Game game in GameController.GetAllGames())
            {
                if (!listBox_game.Items.Contains(game))
                {
                    listBox_game.Items.Add(game);
                }
            }
        }

        private void CenterSelectedItem(ListBox listBox)
        {
            if (listBox.SelectedIndex != -1)
            {
                int selectedIndex = listBox.SelectedIndex;

                int halfVisibleItems = listBox.ClientSize.Height / listBox.ItemHeight / 2;
                listBox.TopIndex = Math.Max(selectedIndex - halfVisibleItems, 0);
            }
        }

        private void btn_newLocation_Click(object sender, EventArgs e)
        {
            if (listBox_user.SelectedItem == null || listBox_game.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione todas as opções!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LocationItem li = new LocationItem(
                ((User)listBox_user.SelectedItem).Id,
                ((Game)listBox_game.SelectedItem).Id,
                dateTimePicker_withdrawal.Value,
                dateTimePicker_devolution.Value
                );

            if (!LocationController.RegisterLocation(li))
            {
                MessageBox.Show("Holve ume erro durante a locação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show("Alocação criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_user_MouseEnter(object sender, EventArgs e)
        {
            listBox_user.Size = increasedSize;
        }

        private void listBox_game_MouseEnter(object sender, EventArgs e)
        {
            listBox_game.Size = increasedSize;
        }

        private void listBox_user_MouseLeave(object sender, EventArgs e)
        {
            listBox_user.Size = originalSize;
            CenterSelectedItem(listBox_user);
        }

        private void listBox_game_MouseLeave(object sender, EventArgs e)
        {
            listBox_game.Size = originalSize;
            CenterSelectedItem(listBox_game);
        }

        private void listBox_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_user.SelectedItem != null && !string.IsNullOrEmpty(listBox_user.SelectedItem.ToString()))
            {
                User selectedUser = (User)listBox_user.SelectedItem;
                pictureBox_user.Image = selectedUser.ProfileImage; // Supondo que User tem uma propriedade Imagem do tipo Image 
            }
        }
        private void listBox_game_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_game.SelectedItem != null && !string.IsNullOrEmpty(listBox_game.SelectedItem.ToString()))
            {
                Game selectedGame = (Game)listBox_game.SelectedItem;
                pictureBox_game.Image = selectedGame.GameImage; // Supondo que Game tem uma propriedade Imagem do tipo Image } }
            }
        }

        
    }
}
