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

            originalSize = checkList_plataform.Size;
            increasedSize = new Size(originalSize.Width, originalSize.Height + 20);
        }

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void game_pictureBox_Click(object sender, EventArgs e)
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

                    game_pictureBox.Image = Image.FromFile(imagePath);

                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkList_plataform_MouseEnter(object sender, EventArgs e)
        {
            checkList_plataform.Size = increasedSize;
        }

        private void checkList_plataform_MouseLeave(object sender, EventArgs e)
        {
            checkList_plataform.Size = originalSize;
        }

       
    }
}
