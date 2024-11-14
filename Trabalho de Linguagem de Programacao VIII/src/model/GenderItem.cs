using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.model
{
    class GenderItem
    {
        private string name;
       

        public GenderItem(string name)
        {
            this.name = name;
            
        }

        public override string ToString()
        {
            return name;
        }
    }

}
