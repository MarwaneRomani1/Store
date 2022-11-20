using Microsoft.Data.SqlClient;
using Store.DataNameSpace.DAO;
using Store.DataNameSpace.Models;
using Store.DataNameSpace.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class AddProductForm : Form
    {
        private String operation = "enregistrer";
       
        private String name;
        private float price ;

        public AddProductForm()
        {
            InitializeComponent();
        }

        
        //overload the constructor to handle modification
        public AddProductForm( String name,
                               float price,
                               String operation )
        {
            InitializeComponent();
            this.name  = name;
            this.price = price;
            this.operation = operation;

            input_productName.Text  = name;
            input_productPrice.Text = price.ToString();   
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProductForm_Load(object sender, EventArgs e) { 
            button_enregistrer.Enabled = false;
        }

        private void button_annuler_Click(object sender, EventArgs e) { this.Close(); }

        private void input_productName_TextChanged(object sender, EventArgs e)
        {
            this.name = input_productName.Text;

            if (name != null && name != "" && price != 0)
                button_enregistrer.Enabled = true;
        }

        private void input_productPrice_TextChanged(object sender, EventArgs e)
        {
            this.price = float.Parse(input_productPrice.Text);
            
            if (name != null && name != "" && price != 0)
                button_enregistrer.Enabled = true;
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SqlServerConnection.connect(@"Data Source=DESKTOP-83J8IV6;Initial Catalog=Store;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
            ProduitDAO produitDAO = new ProduitDAO(connection);
            
            int result;

            if (operation == "enregistrer")
            {
                Produit p = new Produit(name, price);
                result =  produitDAO.save(p);
                DataSource.addProduct(p);
            }
            else
            {
                String[] newData = new string[] { input_productName.Text, input_productPrice.Text };
                
                result = produitDAO.update(DataSource.getSelectedProduct(), newData);
            }

            if (result > 0)
            {
                SuccessForm success = new SuccessForm("inserted");
                success.ShowDialog();
            }
        }
    }
}