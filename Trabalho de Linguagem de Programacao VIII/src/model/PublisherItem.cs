using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.model
{
    public class PublisherItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PublisherItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public PublisherItem(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

