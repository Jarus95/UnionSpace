using MySql.Data.MySqlClient;
using System.Data;
using UnionSpaceTask.Database;
using UnionSpaceTask.Model;

namespace UnionSpaceTask
{
    public partial class ProductForm : Form
    {
        int currentProductIndex;
        Product product = new Product();
        public ProductForm(int index)
        {
            currentProductIndex = index;
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {


            string query = $"SELECT * FROM product WHERE Id = {currentProductIndex}";
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
                ShowInormation();
            }
        }

        private void ShowInormation()
        {
            pictureBox1.Image = Image.FromFile($"pic\\{product.Article}.jpg");
            ProductName.Text = "Названия: " + product.Name;
            ProductPrice.Text = "Цена: " + product.Price.ToString();
            ProductArticle.Text = "Артикул: " + product.Article;
            ProductQty.Text = "Количество: " + product.Quantity.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductListForm form = new ProductListForm();
            form.Show();
        }
    }
}
