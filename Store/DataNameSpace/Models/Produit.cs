using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataNameSpace.Models
{
    internal class Produit
    {
        public int id { get; set; }
        public String name { get; set; }
        public float prix { get; set; }

        public Produit(String name, float prix)
        {
            this.name = name;
            this.prix = prix;
        }

        public String toString()
        {
            return "name : " + this.name + ", price: " + this.prix;
        }
    }
}
