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
using Excel = Microsoft.Office.Interop.Excel;

namespace UnionSpaceTask
{
    public partial class ProductListForm : Form
    {
        List<Product> products = new List<Product>();
        public ProductListForm()
        {
            InitializeComponent();

           
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {

            RefreshDataGrid();
        }

      
        public void LoadRows()
        {
           
            dataGridView.DataSource = products;
            dataGridView.Refresh();
           // dataGridView.CellContentClick += (sender, args) => { MessageBox.Show("ssdsd"); };
        }

        public void RefreshDataGrid()
        {
            dataGridView.Rows.Clear();
            string query = "SELECT * FROM product";
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
                    Product product = new Product();
                    product.IsChange = false;
                    product.Id = DBReader.GetInt32("Id");
                    product.Article = DBReader.GetString("Article");
                    product.Name = DBReader.GetString("Name");
                    product.Price = DBReader.GetInt32("Price");
                    product.Quantity = DBReader.GetInt32("Quantity");
                    products.Add(product);

                   
                }
                LoadRows();
                db.CloseConnection();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            for (int i = 1; i <= dataGridView.ColumnCount - 2; i++)
            {

                wsh.Cells[i] = dataGridView.Columns[i+1].HeaderText;

            }

            for (int i = 0; i <= dataGridView.RowCount -1; i++)
            {
               
                for (int j  = 2; j <= dataGridView.ColumnCount - 1; j++)
                {

                    wsh.Cells[i+2, j -1] = dataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;

        }

      
      

        private void isActive(object sender, DataGridViewCellEventArgs e)
        {
         
            for (int i = 0; i < products.Count; i++)
            {
                products[i].IsChange = false;
            }
            LoadRows();
            products[e.RowIndex].IsChange = !products[e.RowIndex].IsChange;
            //MessageBox.Show(products[e.RowIndex].IsChange.ToString());
        }
    }

  
}
