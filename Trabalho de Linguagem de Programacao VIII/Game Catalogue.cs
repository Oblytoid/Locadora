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
    }
}
