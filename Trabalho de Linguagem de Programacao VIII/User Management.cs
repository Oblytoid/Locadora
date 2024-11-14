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

        private User selectedUser;
        public User_Management()
        {
            InitializeComponent();
            SetCol();
            RefreshUserList();
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

                selectedUser = row.DataBoundItem as User;

                
            }
        }

        private void RefreshUserList()
        {
            dataGridView_user.DataSource = DataBase.GetUsers();
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
            if (selectedUser == null)
            {
                MessageBox.Show("Selecione um usuario");
                return;
            }

            DialogResult result = MessageBox.Show("Você realmente deseja deletar este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DataBase.DeleteUser(selectedUser);
                MessageBox.Show("Usuário deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshUserList();
            }
            else {
                MessageBox.Show("Ação cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
            RefreshUserList();
        }

        private void btt_update_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                User_Update userUpdate = new User_Update(selectedUser);
                userUpdate.ShowDialog();
                RefreshUserList();
            }
        }
    }
}
