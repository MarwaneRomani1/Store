using Microsoft.Data.SqlClient;
using Store.DataNameSpace.Models;
using Store;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataNameSpace.DAO 
{
    internal class ProduitDAO : DataAccessObject<Produit>
    {
        public ProduitDAO(SqlConnection connection) : base(connection) { }

        
        public override List<Produit> getAll()
        {
            List<Produit> produits = new List<Produit>();
         
            connection.Open();

            String query = "select * from Produit;";
            SqlCommand command = new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) { 
                String name = reader["nom"].ToString();
                float price = float.Parse(reader["price"].ToString());
                Produit p = new Produit(name, price);
                p.id = int.Parse(reader["id"].ToString());
                produits.Add(p);
            }

            connection.Close();
            return produits;
        }

        public override Produit getOne(int id)
        {
            connection.Open();

            String query = "select * from Produit where id="+ id + ";";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            Produit produit = null;
            while (reader.Read()) {
                produit = new Produit(reader["nom"].ToString(), float.Parse(reader["price"].ToString()));
            }

            return produit;
        }

        public override int save(Produit p)
        {
            String query = "insert into Produit(nom,price) values(" + "'" + p.name + "'" + "," + p.prix + ");";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            String getIdQuery = "SELECT SCOPE_IDENTITY()";
            SqlCommand command2 = new SqlCommand(getIdQuery, connection);
            int id = Convert.ToInt32(command2.ExecuteScalar());
            p.id = id;

            connection.Close();
            return result;
        }

        public override int update(Produit p, string[] arguments)
        {
            String query = "update Produit set nom = " + "'" + arguments[0] + "', price=" + arguments[1] + "where id=" + p.id + ";";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
        
        public override int delete(Produit p)
        {
            String query = "delete from Produit where nom=" + "'" + p.name + "'" + ";";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
