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
    public partial class ProductsList : MetroForm
    {
        
        string accountNo = "";
   
        public ProductsList()
        {
            InitializeComponent();
            
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet1.products' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet1.products' table. You can move, or remove it, as needed.
            tBoxStockNo.Visible = false;
            label2.Visible = false;
            if (Global.process.branchID == "02")
            {
                this.stockListReportTableAdapter.Fill(this.citiAppDatabaseDataSet.stockListReport);
                this.productsTableAdapter.Fill(this.citiAppDatabaseDataSet1.products);
                
            }
            else
            {
                this.stockListReportTableAdapter.FillByBranch(this.citiAppDatabaseDataSet.stockListReport, Global.process.branchID);
                this.productsTableAdapter.FillByLocationTO(this.citiAppDatabaseDataSet1.products, Global.process.branchID);
               
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tBoxSearch.Text.Length >= 1)
            {
                if (Global.process.branchID == "02")
                {
                    this.stockListReportTableAdapter.FillBySearchQuery(this.citiAppDatabaseDataSet.stockListReport, tBoxSearch.Text, tBoxSearch.Text, tBoxSearch.Text);
                }
                else
                {
                    this.stockListReportTableAdapter.FillBySearchProductList_OtherBranch(this.citiAppDatabaseDataSet.stockListReport, tBoxSearch.Text,tBoxSearch.Text,Global.process.branchID);
                }
              
            }
            else
            {
                MessageBox.Show("Invalid Search Input");
             
            }
         
        }

        private void tBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (Global.process.branchID == "02")
            {
                this.stockListReportTableAdapter.Fill(this.citiAppDatabaseDataSet.stockListReport);
                this.productsTableAdapter.Fill(this.citiAppDatabaseDataSet1.products);
            }
            else
            {
                this.stockListReportTableAdapter.FillByBranch(this.citiAppDatabaseDataSet.stockListReport, Global.process.branchID);
              
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.productsTableAdapter.FillByFromProductListSelection(this.citiAppDatabaseDataSet1.products, gridViewInventory.CurrentRow.Cells[1].Value.ToString(), gridViewInventory.CurrentRow.Cells[4].Value.ToString());
            tBoxStockNo.Visible = true;
            label2.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewProdDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewProdDetails.CurrentRow.Cells[4].Value.ToString() == "Sold")
            {
                btnView.Visible = true;
            }
            else
            {
                btnView.Visible = false;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            try
            {
                citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
                citiAppDatabaseDataSet.DR_detailsRow drDetailsRow = (citiAppDatabaseDataSet.DR_detailsRow)drDetailsAdapter.GetDataByStockNo(gridViewProdDetails.CurrentRow.Cells[0].Value.ToString()).Rows[0];

                accountNo = drDetailsRow.AccountNo.ToString();

                frmProductDetails fpDetails = new frmProductDetails(accountNo);
                fpDetails.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
          


        }

        private void tBoxStockNo_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tBoxStockNo.Text))
            {
                this.productsTableAdapter.FillByStockNoProductList(this.citiAppDatabaseDataSet1.products, gridViewInventory.CurrentRow.Cells[1].Value.ToString(), gridViewInventory.CurrentRow.Cells[4].Value.ToString(), tBoxStockNo.Text);
            }
           
        }
    }
}
