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
    public partial class Game_Location : Form
    {
        private LocationItem selectedLocation;

        public Game_Location()
        {
            InitializeComponent();
            colConfig();
            RefreshData();
            dataGridView_location.CellFormatting += DataGridView_location_CellFormatting; // Adicione esta linha
        }

        private void colConfig()
        {
            dataGridView_location.AutoGenerateColumns = false;
            dataGridView_location.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_location.MultiSelect = false;
            dataGridView_location.CellClick += dataGridView_location_CellClick;

            dataGridView_location.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserName",
                HeaderText = "Usuario",
                Width = 100
            });
            dataGridView_location.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GameName",
                HeaderText = "Jogo",
                Width = 157
            });
            dataGridView_location.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataInicio",
                HeaderText = "Data da retirada",
                Width = 100
            });
            dataGridView_location.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataEntrega",
                HeaderText = "Data de entrega",
                Width = 100
            });
            dataGridView_location.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Entregue",
                HeaderText = "Status",
                Name = "Entregue",
                Width = 80
            });
        }

        private void RefreshData()
        {
            var locations = LocationController.GetAllLocations();
            var bindingList = new BindingList<LocationItem>(locations);
            var source = new BindingSource(bindingList, null);
            dataGridView_location.DataSource = source;
        }

        private void DataGridView_location_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_location.Columns[e.ColumnIndex].Name == "Entregue")
            {
                bool value = (bool)e.Value;
                if (value)
                {
                    e.Value = "Entregue";
                    e.CellStyle.BackColor = Color.Green;
                }
                else
                {
                    e.Value = "Não Entregue";
                    e.CellStyle.BackColor = Color.Red;
                }
                e.FormattingApplied = true;
            }
        }

        private void btn_newLocation_Click(object sender, EventArgs e)
        {
            New_Alocation al = new New_Alocation();
            al.ShowDialog();
            RefreshData();
        }

        private void btt_locationDone_Click(object sender, EventArgs e)
        {
            if (selectedLocation != null)
            {
                LocationController.MarkDelivered(selectedLocation);
                MessageBox.Show("Alocação marcada como entregue.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshData();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma alocação primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_location_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_location.Rows[e.RowIndex];
                selectedLocation = row.DataBoundItem as LocationItem;
            }
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
            if (selectedLocation == null)
            {
                MessageBox.Show("Selecione um usuario");
                return;
            }

            DialogResult result = MessageBox.Show("Você realmente deseja deletar este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                LocationController.DeleteLocation(selectedLocation.Id);
                MessageBox.Show("Deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshData();
            }
            else {
                MessageBox.Show("Ação cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
