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
        private PublisherItem publisher;
        private string launchDate;
        private Image gameImage = null;

        public  Game(string name, string desc, PlataformItem plataform, GenderItem gender)
        {
            this.name = name;
            this.desc = desc;
            this.plataform = plataform;
            this.gender = gender;
            
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public PlataformItem Plataform
        {
            get { return plataform; }
            set { plataform = value; }
        }

        public GenderItem Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string LaunchDate
        {
            get { return launchDate; }
            set { launchDate = value; }
        }

        public PublisherItem Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public Image GameImage
        {
            get { return gameImage; }
            set { gameImage = value; }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
