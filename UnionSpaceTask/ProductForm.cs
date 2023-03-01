using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnionSpaceTask.Database;
using UnionSpaceTask.Model;

namespace UnionSpaceTask
{
    public partial class ProductForm : Form
    {
        int currentProductIndex;
        public ProductForm(int index)
        {
            currentProductIndex = index;
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            Product product = new Product();

            string query = $"SELECT * FROM product WHERE Id = {currentProductIndex+1}";
            DB db = new DB();

            DataTable tableDB = new DataTable();

            MySqlDataAdapter adapterDB = new MySqlDataAdapter();

            MySqlCommand commandDB = new MySqlCommand(query, db.GetConnection());
            adapterDB.SelectCommand = commandDB;
            adapterDB.Fill(tableDB);

            if (tableDB.Rows.Count != 0)
            {
                MySqlDataReader DBReader;
                db.OpenConnection();
                DBReader = commandDB.ExecuteReader();

                while (DBReader.Read())
                {
                    product.IsChange = false;
                    product.Id = DBReader.GetInt32("Id");
                    product.Article = DBReader.GetString("Article");
                    product.Name = DBReader.GetString("Name");
                    product.Price = DBReader.GetInt32("Price");
                    product.Quantity = DBReader.GetInt32("Quantity");


                }
                db.CloseConnection();

            }
        }
    }
}
