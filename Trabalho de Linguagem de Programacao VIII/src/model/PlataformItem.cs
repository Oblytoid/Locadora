using Locadora.src.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.model
{
    
    public class PlataformItem
    {
        private int id;
        private string name;

        public PlataformItem(int id)
        {
            this.id = id;
            this.Name = PlataformController.GetPlataformNameById(id);

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

        public override string ToString()
        {
            return name;
        }
    }
}
