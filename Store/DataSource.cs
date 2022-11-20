using Store.DataNameSpace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class DataSource
    {
        private static List<Produit> produits = new List<Produit>();
        private static int selectedProduit;

        private DataSource() { }

        public static List<Produit> getProductList()
        {
            return produits;
        }

        public static Produit getSelectedProduct()
        {
            return produits[selectedProduit];
        }

        public static void setSelectedProduct(int index)
        {
            selectedProduit = index;
        }

        public static void addProduct(Produit produit)
        {
            produits.Add(produit);
        }
    }
}
