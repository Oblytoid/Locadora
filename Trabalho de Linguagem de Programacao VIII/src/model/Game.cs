using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.model
{
    class Game
    {
        private int id;
        private string name;
        private string desc;
        private PlataformItem plataform;
        private GenderItem gender;
        private string launchDate;
        private Image gameImage = null;

        public  Game(string name, string desc, PlataformItem plataform, GenderItem gender)
        {
            this.name = name;
            this.desc = desc;
            this.plataform = plataform;
            this.gender = gender;
        }


    }
}
