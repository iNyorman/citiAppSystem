using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Modals;
using citiAppSystem.Modules.Models;
using citiAppSystem.Modules.Models.Enums;
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
    public partial class updateDelivery : MetroForm
    {

       
        string customerID = "";
        //para sa new accout
        string customerNo = "";
        string branchNo = "";
        string transaction = "";
        string productPriceSum = "";
        List<ProductDR> productList;
        List<ProductDR> toAddList;
        List<string> AccountType;
        List<string> TransType;
         DeliveryReceiptDatasets.DR_detailsRow drDetailsRow;
        private AddingDrMode addproductMode = AddingDrMode.Primary;

        public updateDelivery()
        {
            InitializeComponent();
            productList = new List<ProductDR>();
            toAddList = new List<ProductDR>();
            AccountType = new List<string>();
            TransType = new List<string>();
            populateAccountType();
        }
        private void populateAccountType()
        { 
            AccountType.Add("");
            AccountType.Add("Charge Sales Invoice");
            AccountType.Add("Cash Sales Invoice");
            AccountType.Add("Delivery Receipt");
            cboxAccountType.DataSource = AccountType;
        }
        private void populateTransactionType()
        {
            cboxLCPCOD.DataSource = TransType.ToList();
        }
        private void updateDelivery_Load(object sender, EventArgs e)
        {
            if (Global.process.branchID == "02")
            {
                cBoxBranches.Visible = true;
                metroLabel28.Visible = true;
                this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);
            }
            else
            {
                cBoxBranches.Visible = false;
                metroLabel28.Visible = false;
                branchNo = Global.process.branchID;

            }
            
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.collection_details' table. You can move, or remove it, as needed.
            this.collection_detailsTableAdapter.Fill(this.citiAppDatabaseDataSet.collection_details);
            branchNo = cBoxBranches.SelectedValue.ToString();

        }

 

        private void tboxStockNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string currentBranch = "";
                if (Global.process.branchID == "02")
                {
                    currentBranch = cBoxBranches.SelectedValue.ToString();
                }
                else
                {
                    currentBranch = branchNo;
                }
                if (state == currentState.New)
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        if (!string.IsNullOrEmpty(tboxStockNo.Text))
                        {
                            addProductMain(currentBranch, addproductMode);
                        }
                    }
                }
                else if (state == currentState.Update)
                {
                            addProductMain(currentBranch, addproductMode);
                            btnRemoveProductList.Enabled = true;
                            btnAssignPrice.Enabled = true;
                }
            }
        }

        private void addProductMain(string _currentBranchNo,AddingDrMode mode)
        {
            var data = ServiceLocator.Instance().ProductServices().productByStockNo(tboxStockNo.Text);
            if(data != null)
            {
                if (data.status != "Sold")
                {
                    if (data.branchNo == _currentBranchNo)
                    {
                        ProductDR newProductDr = new ProductDR();
                        if (productList.Where(x => x.stockNo == data.stockNo).Count() == 1)
                        {
                            MessageBox.Show("Already added.");
                        }
                        else
                        {
                            newProductDr.stockNo = data.stockNo;
                            newProductDr.Brand =   data.brand;
                            newProductDr.Model =   data.model;
                            newProductDr.Serial =  data.serialNo;
                            newProductDr.Remarks = addproductMode.ToString();
                            newProductDr.Price = "0.0";

                            if (state == currentState.Update)
                            {
                                newProductDr.Indentifier = "Added";
                                productList.Insert(2, newProductDr);
                                toAddList.Add(newProductDr);
                                currentDetailsStatus = Details_Status.added;
                            }
                            else
                            {
                                productList.Add(newProductDr);
                                calculateSum();
                            }
                            populateGrid();
                            tboxStockNo.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("StockNo " + data.stockNo + " belongs to branchNo " + data.branchNo + ".", "System");
                    }
                }
                else
                {
                    MessageBox.Show("Stock number already sold.");
                }
            }
            else
            {
                if(MessageBox.Show("No existing stockNo found, direct add this product?","System",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DirectAdd_products dp = new DirectAdd_products(addproductMode,tboxStockNo.Text, cBoxBranches.Text, cBoxBranches.SelectedValue.ToString());
                    dp.directAddProduct+=(obj) => {
                        productList.AddRange(obj);
                        populateGrid();
                        tboxStockNo.Text = "";
                        currentDetailsStatus = Details_Status.added;
                    };
                    dp.ShowDialog();
                }
            }
        }

        private void calculateSum()
        {
            if (cboxAccountType.Text == "Cash Sales Invoice" && cboxLCPCOD.Text == "Cash")
            {
                productPriceSum = productList.Where(x => !string.IsNullOrEmpty(x.stockNo)).Sum(x => Convert.ToDouble(x.Price)).ToString();
                tboxTotalLCP.Text = productPriceSum;
            }
        }

        private void populateGrid()
        {
            gridStocks.AutoGenerateColumns = false;
            gridStocks.DataSource = productList.ToList();
            cBoxBranches.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerEntry()
        { 
             var customerName = tBoxCustomerName.Text.Split(',');

            string firstname = "";
            string middlename = "";
            string lastname = "";
            if (customerName.Length >= 2)
            {
                lastname = customerName[0];
                firstname = customerName[1];
                if (customerName.Length == 3)
                {
                    middlename = customerName[2];
                }
                else
                {
                    middlename = "";
                }
            }
        }
        private void tboxAcctNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
            citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter cusAdapter = new citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter();
            citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter cTransAdapter = new citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter();
            citiAppDatabaseDataSetTableAdapters.collectionTableAdapter collAdapter = new citiAppDatabaseDataSetTableAdapters.collectionTableAdapter();
            citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter collDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter();
            citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
            citiAppDatabaseDataSetTableAdapters.productsTableAdapter productsAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();

                if (radioAcctNo.Checked == true && cboxMode.Text == "Search")
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {

                    
                    citiAppDatabaseDataSet.deliveryReceiptDataTable drDt = drAdapter.GetDataByAccountNo(tboxAcctNo.Text);
                    citiAppDatabaseDataSet.collectionDataTable cDt = collAdapter.GetDataByCollectionID(tboxAcctNo.Text);
                    var dr = ServiceLocator.Instance().DRServices().DrByAccountNo(tboxAcctNo.Text);
                    var cd = ServiceLocator.Instance().CollectionServices().CollectionDetails(tboxAcctNo.Text);
                    //display sa customer info
                    if (dr !=null && cd != null)
                    {
                        state = currentState.Update;
                        customerID = dr.FirstOrDefault().ID_Number;
                        cBoxBranches.SelectedValue = dr.FirstOrDefault().branchNo;
                        var cus = ServiceLocator.Instance().CustomerServices().CustomerByID_Number(customerID).FirstOrDefault();
                        tBoxCustomerName.Text = cus.fullName;
                        customerID = cus.ID_Number.ToString();
                        tboxAddres.Text = cus.address.ToString();
                        tboxEmployer.Text = cus.employer.ToString();
                        tboxEmpAdd.Text = cus.employerAddress.ToString();
                        tboxComaker.Text = cus.co_Maker.ToString();
                        tboxCoAddress.Text = cus.co_MakerAddress.ToString();
                       
                        var col = ServiceLocator.Instance().CollectionServices().CollectionById(tboxAcctNo.Text);
                        var drDet = ServiceLocator.Instance().DRServices().DRDetailsByAccountNo(tboxAcctNo.Text);
                        if (col.Count.Equals(1) && drDet.Count > 0)
                        {
                           
                            var cRow = col.FirstOrDefault();

                            cboxAccountType.Text = dr.FirstOrDefault().Account_Type.ToString();
                            cboxLCPCOD.Text = drDet.FirstOrDefault().description.ToString();
                            tboxTotalLCP.Text  = cRow.Total_LCP.ToString();
                            tboxTotalDown.Text = cRow.Payment.ToString();
                            tboxBalance.Text   = cRow.Balance.ToString();

                            tboxUDI.Text = cRow.UDI.ToString();
                            tboxTotalRebate.Text = cRow.Total_Rebate.ToString();
                            tboxPN.Text = cRow.PN.ToString();
                            tboxTerms.Text = cRow.terms.ToString();

                            tboxGRSmonthly.Text = cRow.GRS_Monthly.ToString();
                            tboxMonthlyRebate.Text = cRow.monthlyRebate.ToString();

                            tboxNetMonthly.Text = cRow.Net_monthly.ToString();

                            deliveryDatePicker.Value = dr.FirstOrDefault().Delivery_Date;

                            cboxSIDR.Text = dr.FirstOrDefault().DRtype;
                            if (cboxSIDR.Text == "SI")
                            {
                                tboxSIDR.Text = dr.FirstOrDefault().SI_DR_no;
                            }
                            else
                            {
                                tboxSIDR.Text = dr.FirstOrDefault().DR_no.ToString();
                            }
                            tboxSalesman.Text = dr.FirstOrDefault().Salesman.ToString();
                            tboxCIBY.Text = dr.FirstOrDefault().CI_By.ToString();
                            cboxAccountType.Enabled = false;
                            tboxTotalLCP.Enabled = true;
                            tboxTotalDown.Enabled = true;
                            tboxBalance.Enabled = true;
                            tboxUDI.Enabled = true;
                            tboxTotalRebate.Enabled = true;
                            tboxPN.Enabled = true;
                            tboxTerms.Enabled = false;
                            tboxGRSmonthly.Enabled = true;
                            tboxMonthlyRebate.Enabled = true;
                            tboxNetMonthly.Enabled = true;
                            deliveryDatePicker.Enabled = true;
                            tboxSIDR.Enabled = true;
                            tboxSalesman.Enabled = true;
                            tboxCIBY.Enabled = true;
                            cboxLCPCOD.Enabled = true;
                            btnSave.Visible = false;
                            btnUpdate.Visible = true;
                            btnAssignPrice.Enabled = false;
                            btnRemoveProductList.Enabled = false;
                            cBoxBranches.Enabled = false;
                            cboxSIDR.Enabled = true;
                            btnAddDetails.Visible = true;
                            if (drDet.Count > 0)
                            {
                                productList = drDet.Select(x => new ProductDR(x)).Where(x=>!string.IsNullOrEmpty(x.stockNo)).ToList();
                                gridStocks.AutoGenerateColumns = false;
                                gridStocks.DataSource = productList;

                                calculateSum();
                            }
                            tboxStockNo.Enabled = false;
                            gridStocks.Enabled = false;


                        }



                    }
                    else if(cDt.Rows.Count.Equals(0) && drDt.Rows.Count.Equals(1))
                    {
                        citiAppDatabaseDataSet.deliveryReceiptRow drRow = (citiAppDatabaseDataSet.deliveryReceiptRow)drAdapter.GetDataByAccountNo(tboxAcctNo.Text).Rows[0];

                        string customerID = drRow.ID_Number.ToString();

                        citiAppDatabaseDataSet.customerTableRow cusRow = (citiAppDatabaseDataSet.customerTableRow)cusAdapter.GetDataBySearchByID_Num(customerID).Rows[0];

                        tBoxCustomerName.Text= cusRow.fullName;
                        customerID = cusRow.ID_Number.ToString();
                        tboxAddres.Text = cusRow.address.ToString();
                        tboxEmployer.Text = cusRow.employer.ToString();
                        tboxEmpAdd.Text = cusRow.employerAddress.ToString();
                        tboxComaker.Text = cusRow.co_Maker.ToString();
                        tboxCoAddress.Text = cusRow.co_MakerAddress.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid account number.");
                        tboxAcctNo.Enabled = true;

                        clearMethod();

                    }
                }
                  
                    
            }
            
        }



        private void clearMethod()
        {
            tBoxCustomerName.Text = "";
            tboxAddres.Text = "";
            tboxEmployer.Text = "";
            tboxEmpAdd.Text = "";
            tboxComaker.Text = "";
            tboxCoAddress.Text = "";


            tboxTotalLCP.Text = "";
            tboxBalance.Text = "0.00";
            tboxCIBY.Text = "0.00";
            tboxTotalRebate.Text = "0.00";
            tboxGRSmonthly.Text = "0.00";
            tboxNetMonthly.Text = "0.00";
            tboxMonthlyRebate.Text = "0.00";
            tboxPN.Text = "0.00";
            tboxSIDR.Text = "";

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{

                citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
                citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
                citiAppDatabaseDataSetTableAdapters.collectionTableAdapter collectionAdapter = new citiAppDatabaseDataSetTableAdapters.collectionTableAdapter();
                citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter collDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter();
                citiAppDatabaseDataSetTableAdapters.OF_TableTableAdapter ofAdapter = new citiAppDatabaseDataSetTableAdapters.OF_TableTableAdapter();
                citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter custAdapter = new citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter();
                citiAppDatabaseDataSetTableAdapters.productsTableAdapter prodAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
                citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter cTransAdapte = new citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter();


            var customerName = tBoxCustomerName.Text.Split(',');

            string firstname = "";
            string middlename = "";
            string lastname = "";
            string fName = "";
            if (customerName.Length >= 2)
            {
                lastname = customerName[0];
                firstname = customerName[1];
                if (customerName.Length == 3)
                {
                    middlename = customerName[2];
                }
                else
                {
                    middlename = "";
                }
                fName = lastname + "," + firstname + "," + middlename;
            }
            else
            {
                fName = tBoxCustomerName.Text;
            }
            
            DialogResult res = MessageBox.Show("Save updates?","Notification",MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    citiAppDatabaseDataSet.deliveryReceiptDataTable drDT = drAdapter.GetDataByAccountNo(tboxAcctNo.Text);
                    if (drDT.Rows.Count.Equals(0) && tboxAcctNo.Text.Length > 0)
                    {

                        if (gridStocks.Rows.Count > 0)
                        {
                            string IDnumber = "";
                            string drStatus = "";

                            if (cboxMode.Text == "New")
                            {
                            var customer = ServiceLocator.Instance()
                                .CustomerServices()
                                .CustomerList()
                                .AsEnumerable()
                                .Where(x=>x.fullName.ToLower()
                                .Contains(fName.ToLower())).FirstOrDefault();
                               
                                if (customer != null)
                                {
                                    customerNo = customer.ID_Number;
                                    custAdapter.UpdateQueryNew(tboxEmployer.Text, tboxComaker.Text, tboxAddres.Text, tboxCoAddress.Text, tboxEmpAdd.Text, customerNo);
                                }
                                else
                                {
                                int index = ServiceLocator.Instance().CustomerServices().CustomerList().Count;
                                int cusID = index + 1;
                                    custAdapter.Insert("CUS-" + cusID.ToString("00000") + "-" + branchNo,
                                        lastname,
                                        middlename,
                                        firstname,
                                        tboxEmployer.Text,
                                        "-",
                                        tboxComaker.Text,
                                        tboxAddres.Text,
                                        tboxCoAddress.Text,
                                        "-",
                                        tboxEmpAdd.Text,
                                        fName);
                                    customerNo = "CUS-" + cusID.ToString("00000") + "-" + branchNo;
                                }
                                IDnumber = customerNo;
                            }
                            else
                            {
                                IDnumber = customerID;
                            }
                            if (cboxAccountType.Text == "Cash Sales Invoice")
                            {
                                drStatus = "Paid";
                            }
                            else
                            {
                                drStatus = "Pending";
                            }

                            //-------------------------------------delivery receipt insert -----------------------------------------------//
                            string SI;
                            string DR;

                            if (cboxSIDR.Text == "DR")
                            {
                                DR = tboxSIDR.Text;
                                SI = "";
                            }
                            else
                            {
                                DR = "";
                                SI = tboxSIDR.Text;
                            }

                            drAdapter.Insert(tboxAcctNo.Text,
                                cboxAccountType.Text,
                                SI,
                                tboxSalesman.Text,
                                tboxCIBY.Text,
                                IDnumber,
                                tboxAcctNo.Text,
                                drStatus,
                                Convert.ToDateTime(deliveryDatePicker.Text),
                                branchNo,
                                DR,
                                cboxSIDR.Text);
                            #region drDetails Entry
                            //-------------------------------------dr details insert -----------------------------------------------//
                            citiAppDatabaseDataSet.DR_detailsDataTable drDitDT = drDetailsAdapter.GetData();
                            int drDetailsID = drDitDT.Rows.Count;
                           
                         
                            string lcp = "";
                            string dp = "";
                            string af = "";
                            string pn = "";
                        string orAmt = "";
                            string cash = "";
                            string drterms = "";

                            foreach (var product in productList)
                            {
                                drDetailsRow = new DeliveryReceiptDatasets.DR_detailsDataTable().NewDR_detailsRow();
                                drDetailsID = drDetailsID + 1;
                                if (cboxAccountType.Text == "Cash Sales Invoice")
                                {
                                    if (product.Remarks == "Primary")
                                    {
                                        lcp = tboxTotalLCP.Text;
                                        if (cboxLCPCOD.Text == "Cash")
                                        {
                                            cash = product.Price;
                                            orAmt = product.Price;
                                        }
                                        else
                                        {
                                            cash = tboxTotalDown.Text;
                                            orAmt = tboxTotalDown.Text;
                                        }
                                        af = "0.00";
                                        pn = "0.00";
                                        dp = "0.00";
                                        drterms = tboxTerms.Text;
                                    }
                                    else
                                    {
                                        cash = "";
                                        lcp = "";
                                        dp = "0.00";
                                        af = "0.00";
                                        pn = "0.00";
                                        drterms = "0";
                                    }
                                }
                                else
                                {
                                    if (product.Remarks == "Primary")
                                    {

                                   
                                    if (cboxLCPCOD.Text == "Cash")
                                    {
                                        cash = product.Price;
                                        lcp = "0.00";
                                    }
                                    else
                                    {
                                        lcp = tboxTotalLCP.Text;
                                        cash = "0.00";
                                    }
                                        af = tboxBalance.Text;
                                        pn = tboxPN.Text;
                                        dp = tboxTotalDown.Text;
                                        drterms = tboxTerms.Text;
                                    }
                                    else
                                    {
                                        cash = "0.00";
                                        lcp = "0.00";
                                        dp = "0.00";
                                        af = "0.00";
                                        pn = "0.00";
                                        drterms = "0";
                                    }
                                }
                                drDetailsAdapter.Insert(drDetailsID.ToString("00000") + "-" + branchNo,
                                    lcp,
                                    product.stockNo,
                                    tboxAcctNo.Text,
                                    "",
                                    "",
                                   dp,
                                    "",
                                    cboxLCPCOD.Text,
                                    product.Remarks,
                                    cash,
                                    orAmt,
                                    product.Brand,
                                    product.Serial,
                                    product.Model,
                                    "",
                                    pn,
                                    af,
                                    drterms);
                                prodAdapter.UpdateStatus("Sold", product.stockNo);
                            }
                            for (int a = 0; a < 5; a++)
                            {
                                drDetailsID = drDetailsID + 1;
                                drDetailsAdapter.Insert(drDetailsID.ToString("00000") + "-" + branchNo,
                                    "",
                                    "",
                                    tboxAcctNo.Text,
                                    "",
                                    "",
                                    "0",
                                    "",
                                    "",
                                    "",
                                    "0",
                                    "0",
                                    "",
                                    "",
                                    "",
                                    "",
                                    "0",
                                    "0",
                                    "");
                            }
                            #endregion
                            //-------------------------------------collection insert -----------------------------------------------//
                            collectionAdapter.Insert(tboxAcctNo.Text,
                                tboxTotalLCP.Text,
                                tboxTotalDown.Text,
                                tboxBalance.Text,
                                tboxUDI.Text,
                                tboxTotalRebate.Text,
                                tboxPN.Text,
                                tboxGRSmonthly.Text,
                                tboxNetMonthly.Text,
                                null,
                                "",
                                "",
                                "",
                                drStatus,
                                tboxTerms.Text,
                                "",
                                "",
                                tboxMonthlyRebate.Text);

                            //------------------------------------collection details insert------------------------------------------//
                            //insert sa collectionDetails
                            citiAppDatabaseDataSet.collection_detailsDataTable cdDT = collDetailsAdapter.GetData();
                            int cDetailsID = cdDT.Rows.Count;
                            int cDetailsCounter = 1 * Int32.Parse(tboxTerms.Text);
                            double expectedBalance = Convert.ToDouble(tboxPN.Text);
                            cDetailsID = cDetailsID + 1;
                            collDetailsAdapter.Insert(cDetailsID.ToString("00000") + "-" + branchNo,
                                    null,
                                    "",// no
                                    "",//or number
                                    "",//prin amount
                                    "",//total amt
                                    "",//penalty
                                    "",//rebate
                                    "",//discount
                                    "",//acct balance
                                    tboxAcctNo.Text,
                                    expectedBalance.ToString(),//expected balance
                                    "",// payment type
                                    "",//remarks
                                    "",//stock no
                                    Convert.ToDateTime(deliveryDatePicker.Text),//trans date
                                    null,//expected date
                                    "",//coll cash amt
                                    "");//coll cheque amt
                            int monthsToAdd = 0;
                            for (int xx = 0; xx < cDetailsCounter; xx++)
                            {
                               

                                expectedBalance = expectedBalance - Convert.ToDouble(tboxGRSmonthly.Text);
                                cDetailsID = cDetailsID + 1;
                                int no = xx + 1;
                            DateTime duDate = Convert.ToDateTime(dueDatePicker.Value);
                                collDetailsAdapter.Insert(cDetailsID.ToString("00000") + "-" + branchNo,
                                    null,
                                    no.ToString(),// no
                                    "",//or number
                                    "",//prin amount
                                    "",//total amt
                                    "",//penalty
                                    "",//rebate
                                    "",//discount
                                    "",//acct balance
                                    tboxAcctNo.Text,
                                    expectedBalance.ToString(),//expected balance
                                    "",// payment type
                                    "",//remarks
                                    "",//stock no
                                    Convert.ToDateTime(deliveryDatePicker.Text),//trans date
                                    Convert.ToDateTime(duDate.AddMonths(monthsToAdd).ToString("d")), //DateTime.Today.AddDays(incrementedDays).Date,//expected date
                                    "",//coll cash amt
                                    "");//coll cheque amt

                                monthsToAdd = monthsToAdd + 1;
                            }

                            //extra row ng cdetails
                            cDetailsID = cDetailsID + 1;
                            collDetailsAdapter.Insert(cDetailsID.ToString("00000") + "-" + branchNo,
                                null,
                                "",
                                "",
                                "",
                                "",
                                "",
                                "",
                                "",
                                "",
                                tboxAcctNo.Text,
                                "",
                                "",
                                "",
                                "",
                                 null,
                                  null,
                                  "",
                                  "");

                            DialogResult result = MessageBox.Show("Would you like to proceed to payments?", "Notification", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                               
                                updateDeliveryCollections udc = new updateDeliveryCollections();
                                udc.acctNo = tboxAcctNo.Text;
                                udc.orNumber = tboxORnumber.Text;
                                udc.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No product selected.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid account number.");
                    }
                }
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            updateDeliveryCollections udc = new updateDeliveryCollections();
            udc.acctNo = tboxAcctNo.Text;
            udc.orNumber = tboxORnumber.Text;
            udc.ShowDialog();
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }


        private void calculationsMethod()
        {

            if (tboxNetMonthly.Text == "")
            {
                tboxNetMonthly.Text = ".00";
            }

            if (tboxTerms.Text == "")
            {
                tboxTerms.Text = "1";
            }

            if (tboxTotalDown.Text == "")
            {
                tboxTotalDown.Text = ".00";
            }

            if (tboxTotalLCP.Text == "")
            {
                tboxTotalLCP.Text = ".00";
            }

            if (tboxGRSmonthly.Text == "")
            {
                tboxGRSmonthly.Text = ".00";
            }

            if (tboxMonthlyRebate.Text == "")
            {
                tboxMonthlyRebate.Text = ".00";
            }
            double UDI = (Convert.ToDouble(tboxNetMonthly.Text) * Convert.ToDouble(tboxTerms.Text)) + Convert.ToDouble(tboxTotalDown.Text) - Convert.ToDouble(tboxTotalLCP.Text);
            double PN = Convert.ToDouble(tboxGRSmonthly.Text) * Convert.ToDouble(tboxTerms.Text);
            double balance = Convert.ToDouble(tboxTotalLCP.Text) - Convert.ToDouble(tboxTotalDown.Text);
            if (UDI < 0)
            {
                tboxUDI.Text = "0.00";
            }
            else
            {
                tboxUDI.Text = UDI.ToString("N2");
            }

            if (PN < 0)
            {
                tboxPN.Text = "0.00";
            }
            else
            {
                tboxPN.Text = PN.ToString("N2");
            }

            if (balance < 0)
            {
                tboxBalance.Text = "0.00";
            }
            else
            {
                tboxBalance.Text = balance.ToString("N2");
            }
        }

        private void tboxTotalLCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxTotalLCP.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tboxTotalDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxTotalLCP.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tboxUDI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxUDI.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tboxBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxBalance.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tboxTotalRebate_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tboxTotalRebate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxTotalRebate.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tboxPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxPN.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tboxGRSmonthly_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxGRSmonthly.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tboxMonthlyRebate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxMonthlyRebate.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tboxNetMonthly_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxNetMonthly.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tboxTotalLCP_TextChanged(object sender, EventArgs e)
        {
            if (cboxAccountType.Text == "Cash Sales Invoice")
            {
                tboxTotalDown.Text = tboxTotalLCP.Text;
            }
            else
            {
                calculationsMethod();
            }
        }

        private void tboxTotalDown_TextChanged(object sender, EventArgs e)
        {
            calculationsMethod();
        }

        private void tboxBalance_TextChanged(object sender, EventArgs e)
        {
            calculationsMethod();
        }

        private void tboxTotalRebate_TextChanged(object sender, EventArgs e)
        {
            calculationsMethod();
        }

        private void tboxGRSmonthly_TextChanged(object sender, EventArgs e)
        {
            calculationsMethod();
        }

        private void tboxMonthlyRebate_TextChanged(object sender, EventArgs e)
        {
            calculationsMethod();
        }

        private void tboxNetMonthly_TextChanged(object sender, EventArgs e)
        {
            calculationsMethod();
        }

        private void btnNewAcct_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("New Customer?", "System", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                Global.process.CustomerclickFrom = "Add";
                CustomerForms.add_updateCustomer nc = new CustomerForms.add_updateCustomer();
                DialogResult result = nc.ShowDialog();
                if (result == DialogResult.Yes)
                {

                    customerNo = nc.idNumber;
                    tBoxCustomerName.Text = Global.customerDetails.l_Name + ", " + Global.customerDetails.f_Name + " " + Global.customerDetails.m_Name;
                    tboxAddres.Text = Global.customerDetails.address.ToString();
                    tboxEmployer.Text = Global.customerDetails.employer.ToString();
                    tboxEmpAdd.Text = Global.customerDetails.employerAddress.ToString();
                    tboxComaker.Text = Global.customerDetails.co_Maker.ToString();
                    tboxCoAddress.Text = Global.customerDetails.co_maker_address.ToString();


                    Global.process.CustomerclickFrom = "";

                    tboxAddres.Enabled = true;
                    tboxCoAddress.Enabled = true;
                    tboxComaker.Enabled = true;
                    tboxEmpAdd.Enabled = true;
                    tboxEmployer.Enabled = true;

                    transaction = "new";

                   
                }
            }
            else if (res == DialogResult.No)
            {
                Global.process.SearchCustomerFromDR = "1";
                customerView cv = new customerView();
                DialogResult result = cv.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    customerNo = Global.customerDetails.id_Number;

                    tBoxCustomerName.Text = Global.customerDetails.l_Name + ", " + Global.customerDetails.f_Name + " " + Global.customerDetails.m_Name;
                    tboxAddres.Text = Global.customerDetails.address.ToString();
                    tboxEmployer.Text = Global.customerDetails.employer.ToString();
                    tboxEmpAdd.Text = Global.customerDetails.employerAddress.ToString();
                    tboxComaker.Text = Global.customerDetails.co_Maker.ToString();
                    tboxCoAddress.Text = Global.customerDetails.co_maker_address.ToString();
                    

                    Global.process.SearchCustomerFromDR = "";

                    tboxAddres.Enabled = true;
                    tboxCoAddress.Enabled = true;
                    tboxComaker.Enabled = true;
                    tboxEmpAdd.Enabled = true;
                    tboxEmployer.Enabled = true;

                    transaction = "new";
                }

            }



        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

         
        }

        private void cboxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxAccountType.Text == "Cash Sales Invoice")
            {
                tboxBalance.Enabled = false;
                tboxCIBY.Text = "-";
                tboxCIBY.Enabled = false;

                tboxGRSmonthly.Enabled = false;
                tboxMonthlyRebate.Enabled = false;
                tboxNetMonthly.Enabled = false;
                tboxPN.Enabled = false;
                tboxTerms.Text = "1";
                tboxTerms.Enabled = false;
                tboxTotalRebate.Enabled = false;
                tboxUDI.Enabled = false;
                tboxTotalDown.Enabled = false;
            }
            else
            {

                tboxTotalDown.Enabled = true;
                tboxGRSmonthly.Enabled = true;
                tboxMonthlyRebate.Enabled = true;
                tboxNetMonthly.Enabled = true;
                tboxPN.Enabled = false;
                tboxTerms.Enabled = true;
                tboxTotalRebate.Enabled = true;
                tboxUDI.Enabled = false;
                tboxCIBY.Enabled = true;
            }
        }

        private void radioAcctNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAcctNo.Checked == true)
            {
                lblORNumber.Visible = false;
                tboxORnumber.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblORNumber.Visible = true;
                tboxORnumber.Visible = true;
               
            }
        }
        private currentState state;
        private enum currentState
        {
            New,
            Update
        }

        private void tboxORnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var cTrans = ServiceLocator.Instance().CTransServices().GetDataByOR(tboxORnumber.Text,cBoxBranches.SelectedValue.ToString());
                if (cTrans.Count.Equals(1))
                {
                    state = currentState.Update;
                    gridStocks.Rows.Clear();
                    customerID = cTrans.FirstOrDefault().ID_Number;
                    var customerRow = ServiceLocator.Instance().CustomerServices().CustomerByID_Number(customerID).FirstOrDefault();
                    tBoxCustomerName.Text = customerRow.fullName;
                    tBoxCustomerName.Text = customerRow.last_Name.ToString() + ", " + customerRow.f_Name.ToString() + " " + customerRow.mid_Name.ToString();
                    tboxAddres.Text = customerRow.address.ToString();
                    tboxCoAddress.Text = customerRow.co_MakerAddress.ToString();
                    tboxComaker.Text = customerRow.co_Maker.ToString();
                    tboxEmployer.Text = customerRow.employer.ToString();
                    tboxEmpAdd.Text = customerRow.employerAddress.ToString();
                    tboxAcctNo.Text = cTrans.FirstOrDefault().AccountNo.ToString();
                    tboxAcctNo.Enabled = true;
                    //kung cod lng
                    if (cTrans.FirstOrDefault().trans_Type.ToString() == "COD")
                    {
                        var index = ServiceLocator.Instance().DRServices().DRList();
                        int drIndex = index.Count + 1;
                        cboxAccountType.Text = "Cash Sales Invoice";
                        cboxAccountType.Enabled = false;
                        tboxAcctNo.Text = "CASH" + drIndex + "-" + Global.process.branchID;
                        tboxAcctNo.Enabled = false;

                        cboxLCPCOD.Text = "COD";
                        cboxLCPCOD.Enabled = false;

                        tboxTotalLCP.Text = cTrans.FirstOrDefault().PAYMENT.ToString();
                        tboxTotalDown.Text = tboxTotalLCP.Text;

                        tboxTotalLCP.Enabled = false;
                        tboxTotalDown.Enabled = false;
                    }

                    
                    transaction = "fromDown";
                    tboxORnumber.Enabled = false;
                }
                else
                {
                    MessageBox.Show("OR number can't be found");
                    tboxORnumber.Enabled = true;
                   
                }
            }
        }

        private void tboxORnumber_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            branchNo = cBoxBranches.SelectedValue.ToString();
           
        }

        private void cboxMode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboxMode.Text == "New")
            {
                panel4.Visible = false;
                radioAcctNo.Checked = false;
                radioButton2.Checked = false;
                btnSave.Visible = true;
                btnPayments.Enabled = false;
                btnUpdate.Visible = false;
                btnSave.Enabled = true;
                


                clearMethod();
            }
            else
            {
                panel4.Visible = true;
                btnSave.Visible = false;
                btnPayments.Enabled = true;
                btnUpdate.Visible = true;
                

            }
        }

        private void btnAttachFree_Click(object sender, EventArgs e)
        {
            
        }

        private void tboxSIDR_Click(object sender, EventArgs e)
        {

        }

        private void tboxStockNo_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
                citiAppDatabaseDataSetTableAdapters.collectionTableAdapter collAdapter = new citiAppDatabaseDataSetTableAdapters.collectionTableAdapter();
                foreach (DataGridViewRow row in gridStocks.Rows)
                {
                    var cRow = row.DataBoundItem as ProductDR;
                    if (!string.IsNullOrEmpty(cRow.stockNo))
                    {
                        ServiceLocator.Instance().DRServices().UpdateDescriptionByStockNo(cboxLCPCOD.Text, cRow.stockNo);
                    }
                }

                    ServiceLocator.Instance().CustomerServices().UpdateForDeliveryReceipt(tBoxCustomerName.Text,
                    tboxAddres.Text, tboxEmployer.Text, tboxEmpAdd.Text, tboxComaker.Text, tboxCoAddress.Text, customerID);

                string SI;
                string DR;

                if (cboxSIDR.Text == "DR")
                {
                    DR = tboxSIDR.Text;
                    SI = "";
                }
                else
                {
                    DR = "";
                    SI = tboxSIDR.Text;
                }

                ServiceLocator.Instance().DRServices().UpdateDRforDR(cboxAccountType.Text, deliveryDatePicker.Text, SI, tboxSalesman.Text, tboxCIBY.Text, DR, cboxSIDR.Text, tboxAcctNo.Text);
                collAdapter.NewUpdateQueryDR(
                    tboxTotalLCP.Text,
                    tboxTotalDown.Text,
                    tboxBalance.Text,
                    tboxUDI.Text,
                    tboxTotalRebate.Text,
                    tboxPN.Text,
                    tboxGRSmonthly.Text,
                    tboxNetMonthly.Text,
                    tboxMonthlyRebate.Text,
                    tboxAcctNo.Text);
                    updateDRDetailsList();
                
                MessageBox.Show("Update Successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Source + ":" + ex.Message);
            }

        }

        private void updateDRDetailsList()
        {

            citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
            citiAppDatabaseDataSetTableAdapters.productsTableAdapter prodAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
                string lcp = "";
                string dp = "";
                string af = "";
                string pn = "";
                string cash = "";
                string drterms = "";
            string orAmt = "";
                   citiAppDatabaseDataSet.DR_detailsDataTable drDitDT = drDetailsAdapter.GetData();
                int drDetailsID = drDitDT.Rows.Count;
            foreach (var p in productList)
            {
                //-------------------------------------dr details insert -----------------------------------------------//
                drDetailsRow = new DeliveryReceiptDatasets.DR_detailsDataTable().NewDR_detailsRow();
                drDetailsID = drDetailsID + 1;
                drDetailsRow.description = cboxLCPCOD.Text;
                if (p.Remarks == "Primary")
                {
                    if (cboxAccountType.Text == "Delivery Receipt" || cboxAccountType.Text == "Charge Sales Invoice" && cboxLCPCOD.Text == "Cash")
                    {
                        drDetailsRow.LCP = "0.00";
                        lcp = "0.00";
                    }
                    else
                    {
                    drDetailsRow.LCP = tboxTotalLCP.Text;
                    lcp = tboxTotalLCP.Text;
                    }

                    if (cboxLCPCOD.Text == "Cash")
                    {
                        drDetailsRow.cash = p.Price;
                        cash = p.Price;
                        orAmt = p.Price;
                    }
                    else
                    {
                        drDetailsRow.cash = "0.00";
                        cash = "0.00";
                        orAmt = "0.00";
                    }
                    drDetailsRow.BalanceAF =tboxBalance.Text;
                    af = tboxBalance.Text;

                    drDetailsRow.PN = tboxPN.Text;
                    pn = tboxPN.Text;

                    drDetailsRow.down_payment = tboxTotalDown.Text;
                    dp = tboxTotalDown.Text;

                    drDetailsRow.termsDR = tboxTerms.Text;
                    drterms = tboxTerms.Text;
                }
                else
                {
                    drDetailsRow.cash = "0.00";
                    drDetailsRow.LCP = "0.00";
                    drDetailsRow.down_payment = "0.00";
                    drDetailsRow.BalanceAF = "0.00";
                    drDetailsRow.PN = "0.00";
                    drDetailsRow.termsDR = "0";
                    cash = "0.00";
                    lcp = "0.00";
                    dp = "0.00";
                    af = "0.00";
                    pn = "0.00";
                    drterms = "0";
                }

                if (!string.IsNullOrEmpty(p.stockNo) &&  p.Indentifier != "Added")
                {
                    var a = drDetailsRow;
                    drDetailsAdapter.UpdateQueryForDR(a.LCP,
                        a.down_payment,
                        a.description,
                        p.Remarks,
                        a.cash,
                        a.PN,
                        a.BalanceAF,
                        a.termsDR,
                        p.stockNo);
                }

                if (p.Indentifier == "Added")
                {
                    drDetailsAdapter.Insert(drDetailsID.ToString("00000") + "-" + branchNo,
                        lcp,
                        p.stockNo,
                        tboxAcctNo.Text,
                        "",
                        "",
                       dp,
                        "",
                        cboxLCPCOD.Text,
                        p.Remarks,
                        cash,
                        orAmt,
                        p.Brand,
                        p.Serial,
                        p.Model,
                        "",
                        pn,
                        af,
                        drterms);
                    prodAdapter.UpdateStatus("Sold", p.stockNo);
                }
            }
        }

        private void deliveryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dueDatePicker.Value = deliveryDatePicker.Value.AddMonths(1);
        }

        private void rbtnMain_MouseClick(object sender, MouseEventArgs e)
        {
            addproductMode = AddingDrMode.Primary;
        }

        private void rbtnFree_MouseClick(object sender, MouseEventArgs e)
        {
            addproductMode = AddingDrMode.Free;
        }

        private void btnRemoveProductList_Click(object sender, EventArgs e)
        {
            if (productList.Count != 0)
            {
                var selectedRow = gridStocks.CurrentRow.DataBoundItem as ProductDR;
                productList.Remove(selectedRow);
                calculateSum();
                populateGrid();
            }
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            customerChecker();
        }
        private void customerChecker()
        {
            var customer = ServiceLocator.Instance().CustomerServices().CustomerList().AsEnumerable()
                .Where(x => x.fullName.ToLower().Contains(tBoxCustomerName.Text.ToLower())).FirstOrDefault();
            if (customer != null)
            {
                tboxAddres.Text = customer.address;
                tboxComaker.Text = customer.co_Maker;
                tBoxCustomerName.Text = customer.fullName;
                tboxEmployer.Text = customer.employer;
                tboxCoAddress.Text = customer.co_MakerAddress;
            }
            else
            {
                MessageBox.Show("No existing customer found.");
            }
        }

        private void cboxAccountType_SelectedValueChanged(object sender, EventArgs e)
        {
            TransType.Clear();
            if (cboxAccountType.Text != "")
            {
              
                    TransType.Add("COD");
                    TransType.Add("LCP");
                    TransType.Add("Cash");
                populateTransactionType();
            }
        }

        private void btnAssignPrice_Click(object sender, EventArgs e)
        {
            if (gridStocks.Rows.Count > 0)
            {
                ProductDR selectedRow = gridStocks.CurrentRow.DataBoundItem as ProductDR;
                if (selectedRow != null)
                {
                    ModalPice priceModal = new ModalPice();
                    priceModal.SelectedPrice += (obj) =>
                    {
                        productList.Where(x => x.Equals(selectedRow)).FirstOrDefault().Price = obj;
                        calculateSum();
                        populateGrid();
                    };
                    priceModal.ShowDialog();
                }
            }
        }

        private void cboxLCPCOD_SelectedValueChanged(object sender, EventArgs e)
        {
            if (state != currentState.Update)
            {
                if (cboxLCPCOD.Text == "Cash")
                {
                    tboxTotalLCP.Enabled = false;
                    tboxTotalDown.Enabled = false;
                    tboxTotalLCP.Text = "0.00";
                    tboxTotalDown.Text = "0.00";
                }
                else
                {
                    tboxTotalDown.Enabled = true;
                    tboxTotalLCP.Enabled = true;
                    tboxTotalLCP.Text = "0.00";
                    tboxTotalDown.Text = "0.00";
                }
            }
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            addDetails();
        }

         Details_Status currentDetailsStatus = Details_Status.none;

         private void addDetails()
         {
             if (currentDetailsStatus == Details_Status.none)
             {
                 tboxStockNo.Enabled = true;
                 gridStocks.Enabled = true;
                 currentDetailsStatus = Details_Status.pending;
                 MessageBox.Show("Adding product is now enabled.");
                btnAddDetails.Enabled = false;
             }
             
         }
        private enum Details_Status
        { 
            none,
            pending,
            added
        }
    }
}
