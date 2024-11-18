using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.src.model;
using Locadora.src.controller;

namespace Locadora
{
    public partial class Catalogo_Jogos : Form
    {

        Game selectedGame;

        public Catalogo_Jogos()
        {
            InitializeComponent();
            SetCol();
            RefreshGameList();
        }

        private void RefreshGameList()
        {
            dgv_list_games.DataSource = GameController.GetAllGames();
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            Game_Register gr = new Game_Register();
            gr.ShowDialog();
            RefreshGameList();
        }

        private void SetCol()
        {
            dgv_list_games.AutoGenerateColumns = false;

            dgv_list_games.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_list_games.MultiSelect = false;
            dgv_list_games.CellClick += dgv_list_games_CellClick;


            dgv_list_games.Columns.Add(new DataGridViewImageColumn
            {
                DataPropertyName = "GameImage",
                HeaderText = "Capa",
                Width = 75,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });

            dgv_list_games.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Width = 35
            });

            dgv_list_games.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Titulo",
                Width = 100
            });

            dgv_list_games.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Desc",
                HeaderText = "Descrição",
                Width = 100
            });

            dgv_list_games.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Gender",
                HeaderText = "Gênero",
                Width = 50
            });
            dgv_list_games.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Plataform",
                HeaderText = "Plataforma",
                Width = 75
            });
            dgv_list_games.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LaunchDate",
                HeaderText = "Data de Lançamento",
                Width = 90
            });
        }

        private void btt_update_Click(object sender, EventArgs e)
        {
            RefreshGameList();
        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
            if(selectedGame != null)
            {

                DialogResult result = MessageBox.Show("Você realmente deseja deletar este Jogo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    GameController.DeleteGame(selectedGame);
                    MessageBox.Show("Jogo deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshGameList();
                }
                else {
                    MessageBox.Show("Ação cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btt_search_Click(object sender, EventArgs e)
        {
            dgv_list_games.DataSource = GameController.SearchGames(txtbox_search.Text);
        }

        private void dgv_list_games_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_list_games.Rows[e.RowIndex];

                selectedGame = row.DataBoundItem as Game;
            }
        }

        
    }
}
