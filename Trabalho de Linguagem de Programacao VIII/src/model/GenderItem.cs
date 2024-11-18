using Locadora.src.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.model
{
    public class GenderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public GenderItem(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public GenderItem(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public GenderItem(string name)
        {
            Name = name;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
