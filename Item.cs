using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillYourBackpack
{
    class Item
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public double Price { get; set; }

        public Item(string name, double weight, double price)
        {
            Name = name;
            Weight = weight;
            Price = price;
        }
    }
}