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
    public partial class Catalogo_Jogos : Form
    {
        public Catalogo_Jogos()
        {
            InitializeComponent();
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            Game_Register addJogo = new Game_Register();
            addJogo.ShowDialog();
        }

        

        private void btt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            Game_Register gr = new Game_Register();
            gr.ShowDialog();
        }


    }
}
