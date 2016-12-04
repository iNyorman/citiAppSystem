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
    public partial class addProducts : MetroForm
    {
        string poDetailsID = "";
        string prodModel = "";
        string branchID = "";

        string branchCode = "";

        string tempprice = "";

        DataTable tempPOdetailsIDTable = new DataTable();
        public addProducts()
        {
            InitializeComponent();
        }

      

        private void add_UpdateProducts_Load(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchAdapter = new citiAppDatabaseDataSetTableAdapters.branchTableAdapter();
            citiAppDatabaseDataSet.branchDataTable branchDT = branchAdapter.GetDataByBranchNo(Global.process.branchID);
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);
             
            tempPOdetailsIDTable.Columns.Add("tempPOdetailsID");
            tempPOdetailsIDTable.Columns.Add("tempStatus");
            tempPOdetailsIDTable.Columns.Add("tempQnty");
            tempPOdetailsIDTable.Columns.Add("tempprice");


            

            if (Global.process.branchID == "02")
            {
                cboxBranch.Enabled = true;
            }
            else
            {
                if (branchDT.Rows.Count.Equals(1))
                {
                    citiAppDatabaseDataSet.branchRow bRow = (citiAppDatabaseDataSet.branchRow)branchAdapter.GetDataByBranchNo(Global.process.branchID).Rows[0];
                    cboxBranch.Text = bRow.branchName.ToString();
                    cboxBranch.Enabled = false;
                }
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter poDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter();
            foreach (DataRow dr in tempPOdetailsIDTable.Rows)
            {
                citiAppDatabaseDataSet.poDetailsRow pDRow = (citiAppDatabaseDataSet.poDetailsRow)poDetailsAdapter.GetDataByPoDetailsID(dr["tempPOdetailsID"].ToString()).Rows[0];
                poDetailsAdapter.UpdateRemainingQTY(pDRow.holderQTY.ToString(), dr["tempPOdetailsID"].ToString());
                
            }
            clear();
        }

        private void clear()
        {
            tboxBrand.Text = "";
            
            tboxStockNo.Text = "";
           
            tboxQty.Text = "";
            tboxDeliveryNo.Text = "";
            tboxStockNo.Enabled = true;
            gridProducts.Rows.Clear();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter poDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter();
            foreach (DataRow dr in tempPOdetailsIDTable.Rows)
            {
                citiAppDatabaseDataSet.poDetailsRow pDRow = (citiAppDatabaseDataSet.poDetailsRow)poDetailsAdapter.GetDataByPoDetailsID(dr["tempPOdetailsID"].ToString()).Rows[0];             
                poDetailsAdapter.UpdateRemainingQTY(pDRow.holderQTY.ToString(), dr["tempPOdetailsID"].ToString());
                //dr["tempPOdetailsID"].ToString();
            }
            this.Close();
        }

        private void btnUpdate_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.process.ProductViewOpenFrom == "Add")
                {
                    citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter poDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter();
                    citiAppDatabaseDataSetTableAdapters.arrivalTableTableAdapter arrivalTbAdapter = new citiAppDatabaseDataSetTableAdapters.arrivalTableTableAdapter();
                    citiAppDatabaseDataSetTableAdapters.productsTableAdapter prodAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
                    citiAppDatabaseDataSet.arrivalTableDataTable arrivalTable = new citiAppDatabaseDataSet.arrivalTableDataTable();

                    //insert product
                    int rowCount = gridProducts.Rows.Count;
                    if (rowCount > 0)
                    {

                        if (Global.process.branchID == "02")
                        {
                            branchID = cboxBranch.SelectedValue.ToString();
                        }
                        else
                        {
                            branchID = Global.process.branchID;
                        }


                        if (radioButton2.Checked == true)
                        {
                            foreach (DataRow dr in tempPOdetailsIDTable.Rows)
                            {
                                //update holder qty
                                citiAppDatabaseDataSet.poDetailsRow pDRow = (citiAppDatabaseDataSet.poDetailsRow)poDetailsAdapter.GetDataByPoDetailsID(dr["tempPOdetailsID"].ToString()).Rows[0];
                                poDetailsAdapter.holderQTYupdate(pDRow.remainingQTY.ToString(), dr["tempPOdetailsID"].ToString());
                                //update status
                                poDetailsAdapter.UpdateStatus("Delivered", dr["tempPOdetailsID"].ToString());
                            }
                        }

                        arrivalTable = arrivalTbAdapter.GetDataByDeliveryNo(tboxDeliveryNo.Text);
                        if (arrivalTable.Rows.Count >= 1)
                        {
                            MessageBox.Show("Delivery Number Already Exist.");

                        }
                        else
                        {
                            DateTime dtaReceived = Convert.ToDateTime(dtReceived.Text);
                            arrivalTbAdapter.Insert(tboxDeliveryNo.Text, tboxVia.Text, tboxWayBill.Text, dtaReceived, DateTime.Today.Date,branchID,tboxSupplierName.Text);

                            for (int count = 0; count < rowCount; count++)
                            {
                                //checker
                                citiAppDatabaseDataSet.productsDataTable prodDT = prodAdapter.GetDataByStockNo(gridProducts.Rows[count].Cells[0].Value.ToString());

                                if (prodDT.Rows.Count.Equals(0))
                                {
                                    prodAdapter.Insert(gridProducts.Rows[count].Cells[0].Value.ToString(),
                                    gridProducts.Rows[count].Cells[2].Value.ToString(),
                                    gridProducts.Rows[count].Cells[3].Value.ToString(),
                                    gridProducts.Rows[count].Cells[1].Value.ToString(),
                                    "Available",
                                    gridProducts.Rows[count].Cells[4].Value.ToString(),
                                    "-",
                                    tboxDeliveryNo.Text,
                                    branchID,
                                    branchID,
                                    dtaReceived, "",
                                    gridProducts.Rows[count].Cells[5].Value.ToString(),
                                    branchID);
                                }
                            }



                         

                            MessageBox.Show("Products Added.");
                            ArrivalReport aP = new ArrivalReport();
                            aP.deliveryNo = tboxDeliveryNo.Text;
                            aP.ShowDialog();
                            clear();
                            }
                        }
                    
                    else
                    {
                        MessageBox.Show("No Products To Generate.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " : " + ex.Source);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter poDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter();
            citiAppDatabaseDataSetTableAdapters.productsTableAdapter prodAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
            citiAppDatabaseDataSet.productsDataTable prodIDchecker = prodAdapter.GetDataByStockNo(Global.process.branchCode + tboxStockNo.Text);
            int stockNo, qty;
            string brCode = branchCode;
                 
            //if (gridProducts.Rows.Count >= 1)
            //{
            //    gridProducts.Rows.Clear();
            //}
            try
            {
                if (tboxStockNo.Text.Length >= 5 && tboxBrand.Text.Length > 0)
                {
                    if (prodIDchecker.Rows.Count.Equals(0))
                    {
                        stockNo = Int32.Parse(tboxStockNo.Text);
                        if (tboxQty.Text.Length > 0)
                        {
                            qty = Int32.Parse(tboxQty.Text);
                            int gridCounter = qty + gridProducts.Rows.Count;

                            if (qty > 0)
                            {
                                if (gridCounter > 25)
                                {
                                    MessageBox.Show("Total Quantity:" + gridCounter + "/25. Exceeds the limit.");
                                }
                                else
                                {
                                    //datatable


                                    string model_ = "";
                                    if (this.rBtnManual.Checked == true)
                                    {
                                        model_ = tBoxModel.Text;
                                        for (int x = 0; x < qty; x++)
                                        {
                                            gridProducts.Rows.Add(tBoxStockCode.Text + stockNo.ToString("0000000"), "-", tboxBrand.Text, model_, "", "0.00");
                                            stockNo = stockNo + 1;



                                        }
                                    }
                                    else
                                    {
                                        citiAppDatabaseDataSet.poDetailsRow pDRow = (citiAppDatabaseDataSet.poDetailsRow)poDetailsAdapter.GetDataByPoDetailsID(poDetailsID).Rows[0];
                                        int remainingQTYdb = Int32.Parse(pDRow.remainingQTY.ToString());
                                        if (qty > remainingQTYdb)
                                        {
                                            MessageBox.Show("The qty input is greater than available qty.");
                                        }
                                        else
                                        {

                                            foreach (DataRow dr in tempPOdetailsIDTable.Rows)
                                            {
                                                if (dr["tempStatus"].ToString() == "pending" && dr["tempPOdetailsID"].ToString() == poDetailsID)
                                                {
                                                    dr["tempStatus"] = "approve";
                                                    dr["tempQnty"] = tboxQty.Text;
                                                }
                                                else if (dr["tempStatus"].ToString() == "approve" && dr["tempPOdetailsID"].ToString() == poDetailsID)
                                                {
                                                    dr["tempQnty"] = (Convert.ToInt32(dr["tempQnty"].ToString()) + Convert.ToInt32(tboxQty.Text)).ToString();
                                                }
                                            }
                                            model_ = prodModel;

                                            //add sa datagridview
                                            for (int x = 0; x < qty; x++)
                                            {
                                                gridProducts.Rows.Add(brCode + stockNo.ToString("0000000"), "-", tboxBrand.Text, model_, Global.poDetails.poDetailsID, tempprice);
                                                stockNo = stockNo + 1;



                                            }

                                            //update para sa db remaining qty
                                            int totalQTY = remainingQTYdb - Int32.Parse(tboxQty.Text);
                                            poDetailsAdapter.UpdateRemainingQTY(totalQTY.ToString(), poDetailsID);
                                        }
                                    }

                                    cboxBranch.Enabled = false;
                                    tboxStockNo.Text = stockNo.ToString("0000000");
                                    int currentCount = gridProducts.Rows.Count;
                                    currentProductCount.Text = currentCount.ToString() + "/25";

                                    if (currentCount == 25)
                                    {
                                        btnSearch.Enabled = false;

                                    }

                                    else
                                    {
                                        btnSearch.Enabled = true;
                                    }



                                    tboxQty.Text = "";
                                    tboxBrand.Text = "";
                                    tboxStockNo.Enabled = false;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Invalid QTY");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Number of Products is Empty.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Stock Number is already used.");
                    }
                }
                else
                {
                    MessageBox.Show("Stock Number or Brand is Empty.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
           
        }

        private void gboxOptions_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter poDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter();
            citiAppDatabaseDataSetTableAdapters.purchaseOrderTableAdapter poAdapter = new citiAppDatabaseDataSetTableAdapters.purchaseOrderTableAdapter();
            citiAppDatabaseDataSetTableAdapters.supplierTableAdapter supAdapter = new citiAppDatabaseDataSetTableAdapters.supplierTableAdapter();

            citiAppDatabaseDataSet.poDetailsDataTable POIDdt = poDetailsAdapter.GetDataByPOidandStatus(tboxPO.Text);


            if (POIDdt.Rows.Count != 0)
            {

                purchaseOrderDetailsVIEW poDV = new purchaseOrderDetailsVIEW();
                poDV.poNumber = tboxPO.Text;
                DialogResult res = poDV.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    //tboxPO.Text = Global.poDetails.purchaseOrderID;
                    //tboxQty.Text = Global.poDetails.orderedQTY;
                    tboxQty.Text = Global.poDetails.remainingQty;
                    poDetailsID = Global.poDetails.poDetailsID;
                    prodModel = Global.poDetails.model;
                    tboxBrand.Text = Global.poDetails.brand;
                    tempprice = Global.poDetails.price;
                    

                     for (int i = 0; i < tempPOdetailsIDTable.Rows.Count; i++)
                    {
                        DataRow dr = tempPOdetailsIDTable.Rows[i];
                        if (dr["tempStatus"].ToString() == "pending") 
                        dr.Delete();
                    }

                    
                    tempPOdetailsIDTable.Rows.Add(poDetailsID,"pending","0",tempprice);
                    //tempGrid.DataSource = tempPOdetailsIDTable;
                    //tempGrid.Refresh();

                }

                citiAppDatabaseDataSet.purchaseOrderRow poRow = (citiAppDatabaseDataSet.purchaseOrderRow)poAdapter.GetDataByPOID(tboxPO.Text).Rows[0];
                
                string supID = poRow.sup_IDno.ToString();

                citiAppDatabaseDataSet.supplierRow supROw = (citiAppDatabaseDataSet.supplierRow)supAdapter.GetDataByID(supID).Rows[0];

                tboxSupplierName.Text = supROw.sName.ToString();
            }
            else
            {
                MessageBox.Show("PO number not found.");
            }

        }

        private void tboxPO_TextChanged(object sender, EventArgs e)
        {
            if (tboxPO.Text.Length >= 6)
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


        }

        private void tboxDeliveryNo_TextChanged(object sender, EventArgs e)
        {
            if (tboxDeliveryNo.Text.Length > 0)
            {
                btnUpdate_Save.Enabled = true;
            }
            else
            {
                btnUpdate_Save.Enabled = false;
            }
        }



        private void cboxBranch_SelectedValueChanged(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchDtAdapter = new citiAppDatabaseDataSetTableAdapters.branchTableAdapter();



            citiAppDatabaseDataSet.branchRow branchRow = (citiAppDatabaseDataSet.branchRow)branchDtAdapter.GetDataByBranchName(cboxBranch.Text).Rows[0];

            branchCode = branchRow.branchCode.ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                tboxBrand.Enabled = false;
                tBoxModel.Visible = false;
                metroLabel11.Visible = false;

                tboxPO.Enabled = true;

                tboxSupplierName.Text = "";
                tboxSupplierName.Enabled = false;
            }
        
        }

        private void rBtnManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnManual.Checked == true)
            {
                tboxBrand.Enabled = true;
                tBoxModel.Visible = true;
                metroLabel11.Visible = true;

                tboxPO.Enabled = false;

                tboxSupplierName.Text = "";
                tboxSupplierName.Enabled = true;

            }
       
        }

        private void rBtnManual_Click(object sender, EventArgs e)
        {

        }
    }
}
