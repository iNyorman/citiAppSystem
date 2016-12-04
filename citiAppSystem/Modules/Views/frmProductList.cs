using citiAppSystem.Modules.Datasets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citiAppSystem.Modules.Views
{
    public partial class frmProductList : Form
    {
        List<ProductsDatasets.productsRow> productList;
        List<ProductsDatasets.stockListReportRow> stockList;
        ProductsDatasets.stockListReportRow selectedStock;
        string selectedStockNo = "";
        string accountNo = "";
        private BindingSource producListBinding;
        private BindingSource productsBinding;
        citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter;
        citiAppDatabaseDataSet.DR_detailsRow drDetailsRow;
        public frmProductList()
        {
            InitializeComponent();
            drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();

            producListBinding = new BindingSource();
            productsBinding = new BindingSource();
            populateBranchesList();
            populateStockList();
        }


        private void populateBranchesList()
        {
           
            
            var branchList = ServiceLocator.Instance().BranchServices().BranchList();
            BranchesDatasets.branchRow newRow = new BranchesDatasets.branchDataTable().NewbranchRow();
            newRow.indexNo = 0;
            newRow.branchName = "All";
            branchList.Insert(0, newRow);

            cBoxBranches.DataSource = branchList;
            cBoxBranches.DisplayMember = "branchName";
            cBoxBranches.ValueMember = "branchCode";
        }

        private void populateStockList()
        {
            stockList = ServiceLocator.Instance().ProductServices().stockList();

            if (cBoxBranches.SelectedIndex != 0)
            {
                stockList = stockList.Where(x => x.branchName == cBoxBranches.Text).ToList();
            }
            if(!string.IsNullOrEmpty(tBoxBrandModel.Text))
            {
                stockList = stockList.Where(x => x.brand.ToLower().Contains(tBoxBrandModel.Text.ToLower()) || x.model.ToLower().Contains(tBoxBrandModel.Text.ToLower())).ToList();
            }
            btnViewAccount.Visible = false;
            producListBinding.DataSource = stockList;
            dGridInventory.AutoGenerateColumns = false;
            dGridInventory.DataSource = stockList;
            dGridProductDetails.DataSource = null;
        }

        private void populateProductDetails()
        {
            try
            {
                productList = ServiceLocator.Instance().ProductServices().productList();
                if (selectedStock != null)
                {
                    productList = productList.Where(x => x.model == selectedStock.model && x.toBranch == selectedStock.branchName).ToList();
                }
                if (!string.IsNullOrEmpty(tBoxStockNo.Text) && productList != null)
                {
                    productList = productList.Where(x => x.stockNo.ToLower().Contains(tBoxStockNo.Text.ToLower())).ToList();
                }

                dGridProductDetails.AutoGenerateColumns = false;
                productsBinding.DataSource = productList;
                if (productList != null)
                {
                    dGridProductDetails.DataSource = productList.CopyToDataTable<ProductsDatasets.productsRow>();
                    btnViewAccount.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
            
        }
        private void retrieveAccountDetailsByStockNo()
        {

             drDetailsRow = (citiAppDatabaseDataSet.DR_detailsRow)drDetailsAdapter.GetDataByStockNo(selectedStockNo).FirstOrDefault();
            if (drDetailsRow != null)
            {
                accountNo = drDetailsRow.AccountNo;
            }
            
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            frmProductDetails fpDetails = new frmProductDetails(accountNo);
            fpDetails.ShowDialog();
        }

        private void cBoxBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateStockList();
        }

        private void tBoxBrandModel_TextChanged(object sender, EventArgs e)
        {
            populateStockList();
        }

        private void tBoxStockNo_TextChanged(object sender, EventArgs e)
        {
            populateProductDetails();
        }

        private void dGridInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(dGridInventory.Rows.Count != 0)
            {
                selectedStock = dGridInventory.CurrentRow.DataBoundItem as ProductsDatasets.stockListReportRow;
                populateProductDetails();
            }
        
        }

        private void dGridProductDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dGridProductDetails.Rows.Count != 0)
            {
                if(dGridProductDetails.CurrentRow.Cells[2].Value.ToString() == "Sold")
                {
                    btnViewAccount.Visible = true;
                    selectedStockNo = dGridProductDetails.CurrentRow.Cells[0].Value.ToString();
                    retrieveAccountDetailsByStockNo();
                }
                else
                {
                    btnViewAccount.Visible = false;
                }
       
            }
        }
    }
}
