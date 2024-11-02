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

namespace Locadora
{
    public partial class Gestao_Usuario : Form
    {
        public Gestao_Usuario()
        {
            InitializeComponent();
            SetCol();
            dataGridView_user.DataSource = DataBase.GetUsers();
        }

        private void SetCol()
        {
            dataGridView_user.AutoGenerateColumns = false;

            dataGridView_user.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cpf",
                HeaderText = "CPF",
                Width = 100
            });

            dataGridView_user.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome",
                Width = 150
            });

            dataGridView_user.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sobrenome",
                HeaderText = "Sobrenome",
                Width = 150
            });

            dataGridView_user.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefone",
                HeaderText = "Telefone",
                Width = 150
            });

            dataGridView_user.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Endereco",
                HeaderText = "Endereço",
                Width = 200
            });

            dataGridView_user.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Width = 200
            });

            dataGridView_user.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataNascimento",
                HeaderText = "Data de Nascimento",
                Width = 150
            });

        }

        
        private void btt_search_Click(object sender, EventArgs e)
        {
            dataGridView_user.DataSource = DataBase.GetUsers(true, txtBox_search.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_user.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha!");
                return;
            }


            DataGridViewRow row = dataGridView_user.SelectedRows[0];

            User selectedUser = row.DataBoundItem as User;
            
            Console.WriteLine(selectedUser);
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
