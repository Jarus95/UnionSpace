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
using Excel = Microsoft.Office.Interop.Excel;

namespace UnionSpaceTask
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();

           
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Article", "Article");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Price", "Price");
            dataGridView.Columns.Add("Quantity", "Quantity");
            RefredDataGrid(dataGridView);
        }


        public void LoadRows(DataGridView dataGridView, IDataRecord dataRecord)
        {
            dataGridView.Rows.Add(
                dataRecord.GetInt32(0),
                dataRecord.GetString(1),
                dataRecord.GetString(2),
                dataRecord.GetInt32(3),
                dataRecord.GetInt32(4));
        }

        public void RefredDataGrid(DataGridView dataGridView)
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
                    LoadRows(dataGridView, DBReader);
                }
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
            int i, j;
            for (i = 0; i <= dataGridView.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;

        }
    }
}
