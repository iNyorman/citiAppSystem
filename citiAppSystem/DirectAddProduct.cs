using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citiAppSystem
{
    public partial class DirectAddProduct : MetroForm
    {
        public DirectAddProduct()
        {
            InitializeComponent();
        }

        private void DirectAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.productsTableAdapter productsAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
            citiAppDatabaseDataSet.productsDataTable productsDT = new citiAppDatabaseDataSet.productsDataTable();
            productsDT = productsAdapter.GetDataByStockNo(tboxStocks.Text);
            if (productsDT.Rows.Count == 1)
            {
                MessageBox.Show("Stock Number already Existed.");
            }
            else
            {
                gridProducts.Rows.Add(tboxStocks.Text, tboxSerial.Text, tboxModel.Text, tboxBrand.Text);

            }
        }

        private void ClearMethod()
        {
            tboxStocks.Text = "";
            tboxSerial.Text = "";
            tboxModel.Text = "";
            tboxBrand.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.productsTableAdapter productsAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
            for (int i = 0; i < gridProducts.Rows.Count; i++)
            {
                productsAdapter.Insert(gridProducts.Rows[i].Cells[0].Value.ToString(),
                       gridProducts.Rows[i].Cells[3].Value.ToString(),
                      gridProducts.Rows[i].Cells[2].Value.ToString(),
                      gridProducts.Rows[i].Cells[1].Value.ToString(),
                       "sold",
                       "n/a",
                       "n/a",
                       "none",
                       "none",
                       "none",
                       null,
                       "none","","");
            }
           
            MessageBox.Show("Product/s Successfully Added.");
            ClearMethod();
        }
    }
}
