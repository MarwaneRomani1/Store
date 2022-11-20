using Microsoft.Data.SqlClient;
using Store.DataNameSpace.DAO;
using Store.DataNameSpace.DatabaseConnection;
using Store.DataNameSpace.Models;

namespace Store
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = SqlServerConnection.connect(@"Data Source=DESKTOP-83J8IV6;Initial Catalog=Store;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //disable button modify and delete
            button_modifier.Enabled = false;
            button_suprr.Enabled = false;
            
            // fetch all products from the DB
            ProduitDAO produitDAO = new ProduitDAO(connection);
            List<Produit> result = produitDAO.getAll();

            foreach (var produit in result)
            {
                comboBox1.Items.Add(produit.name);
                DataSource.addProduct(produit);
            }
        }

       
       
        private void button_ajoute_Click(object sender, EventArgs e)
        {
            AddProductForm productForm = new AddProductForm();
            productForm.ShowDialog();
        }


        // button modifier
        private void button2_Click(object sender, EventArgs e)
        {
            Produit p = DataSource.getSelectedProduct();
            AddProductForm form = new AddProductForm(p.name,p.prix,"modification");
            form.ShowDialog();
        }

        private void button_suprr_Click(object sender, EventArgs e)
        {
            ProduitDAO produitDAO = new ProduitDAO(connection);

            int result = produitDAO.delete(DataSource.getSelectedProduct());

            if (result > 0)
            {
                SuccessForm success = new SuccessForm("deleted.");
                success.ShowDialog();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_modifier.Enabled = true;
            button_suprr.Enabled = true;

            DataSource.setSelectedProduct(comboBox1.SelectedIndex);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}