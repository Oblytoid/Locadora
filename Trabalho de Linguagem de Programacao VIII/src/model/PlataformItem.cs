using Locadora.src.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.model
{
    
    class PlataformItem
    {
        private int id;
        private string name;
        private int manufacturerID;

        public PlataformItem( int id)
        {
            this.id = id;
            this.Name = PlataformController.GetPlataformNameById(manufacturerID);

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

        public int ManufacturerID {
            get { return manufacturerID; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
