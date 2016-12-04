using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Models;
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
    public partial class stockTransfer : MetroForm
    {
        List<StockTransferModel> stockList;
        List<StockTransferModel> transferStockList;
        BindingSource stockTransferBinding;
        stockTransferDatasets.transferTableRow transferRowObj;
        stockTransferDatasets.st_requisitionTableRow st_requisitionRowObj;
        public stockTransfer()
        {
            InitializeComponent();
            stockList = new List<StockTransferModel>();
            transferStockList = new List<StockTransferModel>();
            stockTransferBinding = new BindingSource();
        }

        private void stockTransfer_Load(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.st_requisitionTableTableAdapter st_Adapter = new citiAppDatabaseDataSetTableAdapters.st_requisitionTableTableAdapter();
            citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchAdapter = new citiAppDatabaseDataSetTableAdapters.branchTableAdapter();

            //citiAppDatabaseDataSet.st_requisitionTableDataTable stIDDT = st_Adapter.GetData();

            //int stID = stIDDT.Rows.Count + 1;
            //tboxSTNo.Text = stID.ToString("0000000");

            if (Global.process.branchID == "02")
            {
                bindCurrentLocation();
                
            }
            else
            {
                citiAppDatabaseDataSet.branchRow bRow = (citiAppDatabaseDataSet.branchRow)branchAdapter.GetDataByBranchNo(Global.process.branchID).Rows[0];
                cboxCurrentLocation.Text = bRow.branchName.ToString();
                cboxCurrentLocation.Enabled = false;
                stockList = ServiceLocator.Instance().ProductServices().productList().AsEnumerable().Where(y => y.branchNo == Global.process.branchID && y.status == "Available").Select(x => new StockTransferModel(x)).ToList();                   
                
            }
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);
            populateGridStocks();
        }

        private void stockListByBranch()
        {
            stockList = stockList.Where(x => x.currentBranch == cboxCurrentLocation.SelectedValue.ToString()).ToList();
        }
        private void populateGridStocks()
        {
            stockList = ServiceLocator.Instance().ProductServices().productList().AsEnumerable().Where(y => y.status == "Available").Select(x => new StockTransferModel(x)).ToList();
            gridProductLIST.AutoGenerateColumns = false;
            stockListByBranch();
            FilterMethod();
            gridProductLIST.DataSource = stockList;
        }

        private void addTrasferStockList()
        {
            var selectedStock = gridProductLIST.CurrentRow.DataBoundItem as StockTransferModel;
            if (transferStockList.Where(x => x == selectedStock).FirstOrDefault() != null)
            {
                MessageBox.Show("already selected");
            }
            else
            {
                transferStockList.Add(selectedStock);
                populateTrasferStockList();
            }
        }

        private void populateTrasferStockList()
        {
            gridTransfer.AutoGenerateColumns = false;
            stockTransferBinding.DataSource = transferStockList.ToList();
            gridTransfer.DataSource = stockTransferBinding;
            lblCount.Text = stockTransferBinding.Count.ToString() + "/25";
            gridProductLIST.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (stockTransferBinding.Count < 25)
            {
                addTrasferStockList();
            }
            else
            {
                MessageBox.Show("Maximum transfer count.");
            }
        }

        private void gridProductLIST_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            populateGridStocks();
        }

        private void FilterMethod()
        {
            if (!string.IsNullOrEmpty(tboxSearch.Text))
            {
                if (cBoxFilter.Text == "Stock Number")
                {
                    stockList = stockList.Where(x => x.stockNo.ToLower().Contains(tboxSearch.Text.ToLower())).ToList();
                }
                else
                    if (cBoxFilter.Text == "Serial")
                {
                    stockList = stockList.Where(x => x.Serial.ToLower().Contains(tboxSearch.Text.ToLower())).ToList();
                }
                else
                    if(cBoxFilter.Text == "Model")
                    {
                        stockList = stockList.Where(x => x.Model.ToLower().Contains(tboxSearch.Text.ToLower())).ToList();
                    }
                    else 
                        if(cBoxFilter.Text == "Brand")
                        {
                            stockList = stockList.Where(x => x.Brand.ToLower().Contains(tboxSearch.Text.ToLower())).ToList();
                        }
            }
        }

        private void cBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMethod();
        }
        private void transferStocks()
        {
            var checkSTID = ServiceLocator.Instance().StockTransferServices().GetSt_requisitionTable();
            int counterTableRow = ServiceLocator.Instance().StockTransferServices().GetTransferTable().Count;
            int transfer_ID = counterTableRow + 1;
            transferRowObj = new stockTransferDatasets.transferTableDataTable().NewtransferTableRow();
            if (checkSTID.AsEnumerable().Where(x => x.st_ID == tboxSTNo.Text).FirstOrDefault() == null)
            {
                st_requisitionRowObj = new stockTransferDatasets.st_requisitionTableDataTable().Newst_requisitionTableRow();
                st_requisitionRowObj.st_ID = tboxSTNo.Text;
                st_requisitionRowObj.date_Transaction = DateTime.Today;
                st_requisitionRowObj.from_location = cboxCurrentLocation.Text;
                st_requisitionRowObj.transfer_location = cboxTransferLocation.Text;
                st_requisitionRowObj.receivedBy = tboxReceivedBy.Text;
                st_requisitionRowObj.releasedBy = tboxReleasedBy.Text;
                st_requisitionRowObj.gatePassNo = "-";
                insertSTrequisition(st_requisitionRowObj);
            }
            foreach (var transferObj in transferStockList)
            {
                updateStocksLocation(transferObj);
                transfer_ID = transfer_ID + 1;
                transferRowObj.transfer_ID = transfer_ID.ToString("000000") + "-" + Global.process.branchID;
                transferRowObj.stockNo = transferObj.stockNo;
                transferRowObj.trans_Date = DateTime.Today.Date;
                transferRowObj.transferLocation = cboxTransferLocation.SelectedValue.ToString();
                transferRowObj.qnty = stockTransferBinding.Count.ToString();
                transferRowObj.st_ID = tboxSTNo.Text;
                insertTransferTable(transferRowObj);
            }
        }

        private void updateStocksLocation(StockTransferModel obj)
        {
            ServiceLocator.Instance().StockTransferServices().TransferStock(
                obj.stockNo, 
                cboxCurrentLocation.SelectedValue.ToString(),
                cboxTransferLocation.SelectedValue.ToString(),
                cboxTransferLocation.SelectedValue.ToString(),
                "None");
        }

        private void insertTransferTable(stockTransferDatasets.transferTableRow obj)
        {
            ServiceLocator.Instance().StockTransferServices().Insert_Transfer(obj);
        }
        private void insertSTrequisition(stockTransferDatasets.st_requisitionTableRow obj)
        {
            ServiceLocator.Instance().StockTransferServices().Insert_StRequisition(obj);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (cboxCurrentLocation.Text != cboxTransferLocation.Text)
            {
                if (!string.IsNullOrEmpty(tboxReceivedBy.Text) && !string.IsNullOrEmpty(tboxReleasedBy.Text) && !string.IsNullOrEmpty(tboxSTNo.Text))
                {
                    DialogResult result = MessageBox.Show("Proceed transfer products?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        transferStocks();
                        MessageBox.Show("Transfer complete.");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required.");
                }
            }
            else
            {
                MessageBox.Show("Cant transfer to the same branch.");
            }
        }


        private void bindCurrentLocation()
        {
            citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchAdapter = new citiAppDatabaseDataSetTableAdapters.branchTableAdapter();
            citiAppDatabaseDataSet.branchDataTable branchDT = branchAdapter.GetData();

            cboxCurrentLocation.DataSource = branchDT;
            cboxCurrentLocation.DisplayMember = branchDT.branchNameColumn.ToString();
            cboxCurrentLocation.ValueMember = branchDT.branchNoColumn.ToString() ;
            cboxCurrentLocation.Refresh();

        }

        private void cboxCurrentLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var currentSelected = gridTransfer.CurrentRow.DataBoundItem as StockTransferModel;
            transferStockList.Remove(currentSelected);
            populateTrasferStockList();
        }

        private void tboxSTNo_Leave(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear transfer stock list?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                transferStockList.Clear();
            }
        }

        private void cboxCurrentLocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            populateGridStocks();
        }



    }
}
