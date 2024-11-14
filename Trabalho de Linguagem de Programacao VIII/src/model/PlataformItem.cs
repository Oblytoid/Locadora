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
        private bool isManufacturer;

        public PlataformItem(string name, bool isManufacturer)
        {
            this.name = name;
            this.isManufacturer = isManufacturer;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
