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
    public partial class User_Management : Form
    {
        public User_Management()
        {
            InitializeComponent();
            SetCol();
            dataGridView_user.DataSource = DataBase.GetUsers();
           
            
        }

        private void SetCol()
        {
            dataGridView_user.AutoGenerateColumns = false;

            dataGridView_user.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_user.MultiSelect = false;
            dataGridView_user.CellClick += DataGridView_user_CellClick;
            

            dataGridView_user.Columns.Add(new DataGridViewImageColumn
            {
                DataPropertyName = "ProfileImage",
                HeaderText = "Foto",
                Width = 100,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            });

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
                Width = 100
            });

            dataGridView_user.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sobrenome",
                HeaderText = "Sobrenome",
                Width = 100
            });
            
            dataGridView_user.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataNascimento",
                HeaderText = "Data de Nascimento",
                Width = 120
            });

        }

        private void DataGridView_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_user.Rows[e.RowIndex];

                User selectedUser = row.DataBoundItem as User;

                if (selectedUser != null)
                {
                    pictureBox1.Image = selectedUser.ProfileImage;
                }
            }
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

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
        }

        private void btt_update_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView_user.SelectedRows[0];

            User selectedUser = row.DataBoundItem as User;

            pictureBox1.Image = selectedUser.ProfileImage;
        }
    }
}
