using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Datasets.DeliveryReceiptDatasetsTableAdapters;
using citiAppSystem.Modules.Modals;
using citiAppSystem.Modules.Models;
using citiAppSystem.Modules.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citiAppSystem.Modules.Views.DR
{
    public partial class frmDrViewModal : Form
    {
        Form1 form1;
        private string currentBranch;
        private string newCustomerId = "";
        private string currentCustomerId = "";
        private DRModes currentMode = DRModes.New;
        private customerTransMode currentCustomerTransMode = customerTransMode.add;
        private AddingDrMode currentProductType = AddingDrMode.Primary;
        ProductsDatasets.productsDataTable currentProductsTb;
        ProductsDatasets.productsRow currentProductsRow;
        DeliveryReceiptDatasets.deliveryReceiptDataTable currentDrTb;
        DeliveryReceiptDatasets.DR_detailsDataTable currentDrDetailsTb;
        DeliveryReceiptDatasets.deliveryReceiptRow currentDrRow1;
        citiAppDatabaseDataSet.deliveryReceiptRow currentDrRow;
        DeliveryReceiptDatasets.DR_detailsRow currentDrDetailsRow;
        CustomerDatasets.customerTableDataTable currentCustomerTb;
        CollectionDatasets.collectionDataTable currentCollectionTb;
        CollectionDatasets.collectionRow currentCollectionRow;
        CollectionDatasets.collection_detailsDataTable currentCDetailsTb;
        Collection_Details currentCDetailsRow;
        List<DR_detailsModel> drDetailsList;
        int drDetailsCounter = 0;
        public frmDrViewModal()
        {
            InitializeComponent();
            Instantiate();
            
        }

        private void Instantiate()
        {
            form1 = Application.OpenForms["Form1"] as Form1;
            currentBranch = form1.CurrentBranchNo;
            currentProductsTb = new ProductsDatasets.productsDataTable();
            currentProductsRow = new ProductsDatasets.productsDataTable().NewproductsRow();
            currentDrTb = new DeliveryReceiptDatasets.deliveryReceiptDataTable();
            currentDrRow = new citiAppDatabaseDataSet.deliveryReceiptDataTable().NewdeliveryReceiptRow();
            currentDrRow1 = new DeliveryReceiptDatasets.deliveryReceiptDataTable().NewdeliveryReceiptRow();
            currentDrDetailsTb = new DeliveryReceiptDatasets.DR_detailsDataTable();
            currentDrDetailsRow = new DeliveryReceiptDatasets.DR_detailsDataTable().NewDR_detailsRow();
            currentCustomerTb = new CustomerDatasets.customerTableDataTable();
            currentCollectionTb = new CollectionDatasets.collectionDataTable();
            currentCollectionRow = new CollectionDatasets.collectionDataTable().NewcollectionRow();
            currentCDetailsTb = new CollectionDatasets.collection_detailsDataTable();
            currentCDetailsRow = new Collection_Details();
            drDetailsList = new List<DR_detailsModel>();
        }


        private void frmDrViewModal_Load(object sender, EventArgs e)
        {
            populateBranches();
            brancheRestrict();
            populateAccType();
            populateTotalType();
            populateSI_DI_Type();
        }
        
        private void brancheRestrict()
        {
            if(currentBranch != "02")
            {
                cBoxBranches.SelectedValue = currentBranch;
                cBoxBranches.Enabled = false;
            }
        }

        private void populateBranches()
        {
            var list = ServiceLocator.Instance().BranchServices().BranchList();
            cBoxBranches.DataSource = list;
            cBoxBranches.DisplayMember = "branchName";
            cBoxBranches.ValueMember = "branchNo";
        }

        private void populateAccType()
        {
            List<object> AccTypeList = new List<object>();
            foreach(AccountType type in Enum.GetValues(typeof(AccountType)))
            {
                AccTypeList.Add(new {Id = type,Name = Enum.GetName(typeof(AccountType),type).Replace('_',' ')});
            }
            cBoxAcctype.DataSource = AccTypeList;
            cBoxAcctype.DisplayMember = "Name";
            cBoxAcctype.ValueMember = "Id";
        }


        private void populateTotalType()
        {
            List<string> totalTypeList = new List<string>();

            if(currentTransaction == TransactionType.Cash)
            {
                totalTypeList.Add("Cash");
            }
            else
            {
                totalTypeList.Add("COD");
                totalTypeList.Add("LCP");
            }
            cBoxTotalType.DataSource = totalTypeList;
          
        }
        private void populateSI_DI_Type()
        {
            List<string> sidrType = new List<string>();
            sidrType.Add("DR");
            sidrType.Add("SI");
            sidrType.Add("CHARGE");
            cBoxSI_DR.DataSource = sidrType;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBoxStockNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                if(!string.IsNullOrEmpty(tBoxStockNo.Text))
                {
                    getProductType();
                    getProductByStockNo();
                }
            }
        }

        private void getProductByStockNo()
        {
            var checkProductObj = ServiceLocator.Instance().ProductServices().productByStockNo(tBoxStockNo.Text);
            if (checkProductObj != null)
            {
                if (checkProductObj.branchNo == cBoxBranches.SelectedValue.ToString())
                {
                    if (checkProductObj.status != "Sold")
                    {
                        drDetailsCounter = drDetailsCounter + 1;
                        addProduct(checkProductObj);
                    }
                    else
                    {
                        MessageBox.Show("Product already sold.");
                    }
                }
                else
                {
                    if(currentBranch == "02")
                    {
                        if (currentMode == DRModes.New)
                        {

                            if (checkProductObj.status != "Sold")
                            {
                                var result = MessageBox.Show("Product belongs to branch " + checkProductObj.toBranch + ", do you want to automatically set the branch?", "Branch Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    addProduct(checkProductObj);
                                    cBoxBranches.SelectedValue = checkProductObj.branchNo;
                                    cBoxBranches.Enabled = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product already sold.");
                            }
                        }

                        else
                        {

                            if (checkProductObj.status != "Sold")
                            {
                                var result = MessageBox.Show("Product belongs to branch " + checkProductObj.toBranch + ", do you want to automatically transfer product?", "Branch Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    addProduct(checkProductObj);
                                    cBoxBranches.SelectedValue = checkProductObj.branchNo;
                                    cBoxBranches.Enabled = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product already sold.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please add/transfer stockNo to the current branch first.");
                    }
                }
            }
            else
            {
                if(currentBranch == "02")
                {
                    if (MessageBox.Show("StockNo does not exist, direct add product?", "Product not found.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DirectAdd_products dp = new DirectAdd_products(currentProductType, tBoxStockNo.Text, cBoxBranches.Text, cBoxBranches.SelectedValue.ToString());                    
                        dp.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("StockNo cannot be found in the database.");
                }
            }
        }

        private void addProduct(ProductsDatasets.productsRow checkProductObj)
        {
            if (currentDrDetailsTb.AsQueryable().Where(x=>x.stockNo.Equals(checkProductObj.stockNo)).Count() == 0)
            {
                currentDrDetailsTb.AddDR_detailsRow(drDetailsCounter.ToString(),
                    "0.00",
                    checkProductObj.stockNo,
                    tBoxAccountNo.Text,
                    "0",
                    "",
                    "0.00", "", "", "", currentProductType.ToString(), "0.00", "0.00",
                    checkProductObj.model,
                                        checkProductObj.serialNo, checkProductObj.brand, "","0.00", numTerm.Value.ToString());
                populateDrDetailsTb(currentDrDetailsTb);
                if (currentTransaction == TransactionType.Cash)
                {
                    numTotal.Value = currentDrDetailsTb.Sum(x => decimal.Parse(x.orAmt));
                }
                tBoxStockNo.Text = "";
            }
            else
            {
                MessageBox.Show("Already added.");
            }
        }

        private void populateDrDetailsTb(DeliveryReceiptDatasets.DR_detailsDataTable tb)
        {
            //drDetailsList = tb.AsEnumerable().Cast<DeliveryReceiptDatasets.DR_detailsRow>().Select(x=> new DR_details(x)).ToList();
            dGridDrDetails.AutoGenerateColumns = false;
            dGridDrDetails.DataSource = tb;
            if (currentTransaction == TransactionType.Cash)
            {
                if (currentMode == DRModes.Update)
                {
                    if (currentCDetailsTb.Rows.Count == 0)
                    {
                        numTotal.Value = tb.Where(x => x.orAmt != "").Sum(x => decimal.Parse(x.orAmt));
                    }
                    cBoxTotalType.Text = tb.AsEnumerable().FirstOrDefault().description;
                }
                else
                {
                    numTotal.Value = tb.Sum(x => decimal.Parse(x.orAmt));
                }
            }
        }

        private void getProductType()
        {
            if(rPrimary.Checked)
            {
                currentProductType = AddingDrMode.Primary;
            }
            else
            {
                currentProductType = AddingDrMode.Free;
            }
        }

        private void cBoxAcctype_SelectedValueChanged(object sender, EventArgs e)
        {
            populateTotalType();
        }

        private void tBoxAccountNo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(!string.IsNullOrEmpty(tBoxAccountNo.Text))
                {
                    try
                    {
                        retrieveDataByAccountNo();
                        updateModeRestrictions();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                  
                }
            }
        }

        private void updateModeRestrictions()
        {
            if(currentDrDetailsTb.Rows.Count > 0)
            { 
                rBtnInstallment.Enabled = false;
                rBtnCash.Enabled = false;
                cBoxBranches.Enabled = false;
                btnViewPayments.Visible = true;
            }
        }
        private void retrieveDataByAccountNo()
        {
            currentDrTb = ServiceLocator.Instance().DRServices().DrTableByAcount(tBoxAccountNo.Text);
            if (currentDrTb.Rows.Count > 0)
            {
                currentMode = DRModes.Update;
                btnSave.Text = "Update";
                currentCollectionTb = ServiceLocator.Instance().CollectionServices().CollectionById(tBoxAccountNo.Text);
                currentCDetailsTb = ServiceLocator.Instance().CollectionServices().CollectionDetailsTbByCollectionId(tBoxAccountNo.Text);
                populateDetails(currentDrTb, currentCollectionTb, currentCDetailsTb);
                currentDrDetailsTb = ServiceLocator.Instance().DRServices().DrDetailsTableByAccountNo(tBoxAccountNo.Text);
                populateDrDetailsTb(currentDrDetailsTb);
                currentCustomerTb = ServiceLocator.Instance().CustomerServices().CustomerByID_Number(currentDrTb.FirstOrDefault().ID_Number);
                populateCustomerDetails(currentCustomerTb);
            }
            else
            {
                tBoxAccountNo.ForeColor = Color.Green;
                ToolTip accountToolTip = new ToolTip();
                accountToolTip.ToolTipTitle = "Tips";
                accountToolTip.ToolTipIcon = ToolTipIcon.Info;
                accountToolTip.ShowAlways = true;
                accountToolTip.SetToolTip(this.tBoxAccountNo, "AccountNo is available for use.");
            }
        }
        private void populateCustomerDetails(CustomerDatasets.customerTableDataTable dataTable)
        {
            var a = dataTable.FirstOrDefault();
            currentCustomerId = a.ID_Number;
            tBoxFullname.Text = a.fullName;
            tboxAddress.Text = a.address;
            tBoxEmployer.Text = a.employer;
            tBoxEmpAddress.Text = a.employerAddress;
            tBoxCoMaker.Text = a.co_Maker;
            tBoxCoAddress.Text = a.co_MakerAddress;
            currentCustomerTransMode = customerTransMode.update;
        }

        private void populateDetails(DeliveryReceiptDatasets.deliveryReceiptDataTable dataTable,CollectionDatasets.collectionDataTable dataTableCollection,CollectionDatasets.collection_detailsDataTable dataTableCDetails)
        {
            var a = dataTable.FirstOrDefault();
            var b = dataTableCollection.FirstOrDefault();
            if(a.Status == "Pending")
            {
                var c = dataTableCDetails.ElementAt(1);
                dtDueDate.Value = c.expected_date;
            }
            else
            {
                rBtnCash.Checked = true;
            }

            cBoxBranches.SelectedValue = a.branchNo;
            cBoxAcctype.Text = a.Account_Type;
            numTotalDown.Value = decimal.Parse(b.Payment);
            numTotal.Value = decimal.Parse(b.Total_LCP);
            numBalance.Value = decimal.Parse(b.Balance);
            numUDI.Value = decimal.Parse(b.UDI);
            numTotalRebate.Value =  decimal.Parse(b.Total_Rebate);
            numPN.Value = decimal.Parse(b.PN);
            numTerm.Value = decimal.Parse(b.terms);
            numGrsMonthly.Value = decimal.Parse(b.GRS_Monthly);
            numMonthlyRebate.Value = decimal.Parse(b.monthlyRebate);
            numNetMonthly.Value = decimal.Parse(b.Net_monthly);
            cBoxSI_DR.Text = a.DRtype;
            string siDiNo = "";
            if(a.DRtype == "SI")
            {
                siDiNo = a.SI_DR_no;
            }
            else
            {
                siDiNo = a.DR_no;
            }
            tBoxSI_DRNo.Text = siDiNo;
            tBoxSalesman.Text = a.Salesman;
            dtDRDate.Value = a.Delivery_Date;
            tBoxCIBy.Text = a.CI_By;
        }

        private void btnAssignAmt_Click(object sender, EventArgs e)
        {
            if(currentDrDetailsTb.Count > 0)
            {
                assignAmount();
            }
        }

        private void assignAmount()
        {
            DeliveryReceiptDatasets.DR_detailsRow selectedRow = (DeliveryReceiptDatasets.DR_detailsRow)((DataRowView)dGridDrDetails.CurrentRow.DataBoundItem).Row;
            var a = currentDrDetailsTb.Where(x => x.Equals(selectedRow)).FirstOrDefault().or_number;
            var b = currentDrDetailsTb.Where(x => x.Equals(selectedRow)).FirstOrDefault().orAmt;
            ModalAmount priceModal = new ModalAmount(currentTransaction,a,b);
            priceModal.Amount+=(or,amount) => {
                currentDrDetailsTb.Where(x => x.Equals(selectedRow)).FirstOrDefault().or_number = or;
                currentDrDetailsTb.Where(x => x.Equals(selectedRow)).FirstOrDefault().orAmt = amount;
                currentDrDetailsTb.Where(x => x.Equals(selectedRow)).FirstOrDefault().LCP = "0.00";
                populateDrDetailsTb(currentDrDetailsTb);
            };
            priceModal.ShowDialog();
        }

        private void rBtnInstallment_CheckedChanged(object sender, EventArgs e)
        {
            transactionTypeChanged();

        }
        private void restricEntryByTransaction()
        {
            if(currentTransaction == TransactionType.Installment)
            {
                enableControls(true);
            }
            else if(currentTransaction == TransactionType.Cash)
            {
                enableControls(false);
            }
        }

        private void enableControls(bool o)
        {
            numTotalDown.Enabled = o;
            numTotal.Enabled = o;
            numBalance.Enabled = o;
            numUDI.Enabled = o;
            numTotalRebate.Enabled = o;
            numPN.Enabled = o;
            numTerm.Enabled = o;
            numGrsMonthly.Enabled = o;
            numMonthlyRebate.Enabled = o;
            numNetMonthly.Enabled = o;
        }
        private TransactionType currentTransaction;
        private void transactionTypeChanged()
        {
            if(rBtnInstallment.Checked == true)
            {
                currentTransaction = TransactionType.Installment;
                tBoxAccountNo.Text = "";
                tBoxAccountNo.ReadOnly = false;
                dGridDrDetails.Columns["or_numColumn"].Visible = true;
            }
            else if(rBtnCash.Checked == true)
            {
                currentTransaction = TransactionType.Cash;
                tBoxAccountNo.Text = "CASH-" + (ServiceLocator.Instance().DRServices().DRList().LastOrDefault().Id + 1).ToString();
                tBoxAccountNo.ReadOnly = true;
                dGridDrDetails.Columns["or_numColumn"].Visible = false;
            }
            if(currentMode == DRModes.New)
            {
                restricEntryByTransaction();
                populateTotalType();
            }
        }

        private void rBtnCash_CheckedChanged(object sender, EventArgs e)
        {
            transactionTypeChanged();
        }

        private void rPrimary_CheckedChanged(object sender, EventArgs e)
        {
            currentAddingMode();
        }

        private void currentAddingMode()
        {
            if(rPrimary.Checked == true)
            {
                currentProductType = AddingDrMode.Primary;
            }
            else
            {
                currentProductType = AddingDrMode.Free;
            }
        }
        private void rFree_CheckedChanged(object sender, EventArgs e)
        {
            currentAddingMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentDrDetailsTb.Rows.Count > 0)
                {
                    if (currentMode == DRModes.New)
                    {
                        if (MessageBox.Show("Save current transaction?", "New Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            insertTransaction();
                            MessageBox.Show("Saving successful.");
                            if (MessageBox.Show("Do you want to proceed to view payments?","System",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                updateDeliveryCollections udc = new updateDeliveryCollections();
                                udc.acctNo = tBoxAccountNo.Text;
                                udc.Show();
                                currentMode = DRModes.Update;
                                btnSave.Text = "Update";
                                updateModeRestrictions();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                    else if (currentMode == DRModes.Update)
                    {
                        if (MessageBox.Show("Update current transaction?", "New Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            updateTransaction();
                            MessageBox.Show("Update successful.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
        }

        private void insertTransaction()
        {
            inserUpdateCustomer();
            insertDR();
            inserDRDetails();
            insertCollections();
            if(currentTransaction == TransactionType.Installment)
            {
                insertCollectionDetails();
            }
             
        }

        private void insertDR()
        {
        var a = currentDrRow;
            a.Account_Type = cBoxAcctype.Text;
            if(cBoxSI_DR.Text == "SI")
            {
                a.SI_DR_no = tBoxSI_DRNo.Text;
                a.DR_no = "";
            }
            else
            {
                a.SI_DR_no ="";
                a.DR_no = tBoxSI_DRNo.Text;
            }
            a.Salesman = tBoxSalesman.Text;
            a.CI_By = tBoxCIBy.Text;
            a.ID_Number = newCustomerId;
            a.Collection_ID = tBoxAccountNo.Text;
            a.AccountNo = tBoxAccountNo.Text.Trim();
            if(currentTransaction == TransactionType.Installment)
            {
                a.Status = "Pending";
            }
            else if(currentTransaction == TransactionType.Cash)
            {
                a.Status = "Paid";
            }
            a.Delivery_Date = dtDRDate.Value;
            a.branchNo = cBoxBranches.SelectedValue.ToString();
            a.DRtype = cBoxSI_DR.Text;
            ServiceLocator.Instance().DRServices().InsertDr(a);
        }
        private void inserDRDetails()
        {
            var drDetailsTb = ServiceLocator.Instance().DRServices().GetDrDetails();
            int drDetailsId = drDetailsTb.LastOrDefault().id;
            foreach(var a in currentDrDetailsTb)
            {
                drDetailsId = drDetailsId + 1;
                a.DR_Details_ID = drDetailsId.ToString("00000") + "-" + currentBranch;
                a.AccountNo = tBoxAccountNo.Text.Trim();
                a.qnty = "1";
                a.paymentType = "-";
                a.description = cBoxTotalType.Text; 
                a.PN = numPN.Value.ToString();
                a.down_payment = numTotalDown.Value.ToString();
                a.termsDR = numTerm.Value.ToString();
                if(currentTransaction == TransactionType.Cash)
                {
                    a.cash = a.orAmt;
                    a.LCP = "0.00";
                    a.BalanceAF = "0.00";
                }
                else
                {
                    a.cash = "0.00";
                    if (a.pStatus == "Primary")
                    {
                        a.BalanceAF = numBalance.Value.ToString();
                        a.LCP = numTotal.Value.ToString();
                    }
                    else
                    {
                        a.BalanceAF = "0.00";
                        a.LCP = "0.00";
                        a.PN = "0.00";
                        a.down_payment = "0.00";
                    }
                  
                }
                ServiceLocator.Instance().DRServices().InsertDRDetails(a);
                ServiceLocator.Instance().ProductServices().UpdateStatus("Sold", a.stockNo);
            }
            //for(int x=0; x < 5; x++)
            //{
            //    drDetailsId = drDetailsId + 1;
            //    DeliveryReceiptDatasets.DR_detailsRow a = new DeliveryReceiptDatasets.DR_detailsDataTable().NewDR_detailsRow();
            //    a.DR_Details_ID = drDetailsId.ToString("00000") + "-" + currentBranch;
            //    a.AccountNo = tBoxAccountNo.Text;
            //    a.LCP = "";
            //    a.qnty = "";
            //    a.paymentType = "-";
            //    a.description = "";
            //    a.BalanceAF = "";
            //    a.PN = "";
            //    a.down_payment ="";
            //    a.termsDR = numTerm.Value.ToString();
            //    a.cash = "";
            //    a.orAmt = "0";
            //    ServiceLocator.Instance().DRServices().InsertDRDetails(a);
            //}
        }
        private void inserUpdateCustomer()
        {
            if(currentCustomerTb.Count > 0)
            {
                updateCustomer();
            }
            else
            {
                addCustomer();
            }
        }

        private void addCustomer()
        {
            int index = ServiceLocator.Instance().CustomerServices().CustomerList().Count;
            int cusID = index + 1;
            newCustomerId = "CUS-" + cusID.ToString("00000") + "-" + currentBranch;
            ServiceLocator.Instance().CustomerServices().InsertForDr(tBoxFullname.Text,
                                                                     tboxAddress.Text,
                                                                     tBoxEmployer.Text,
                                                                     tBoxEmpAddress.Text,
                                                                     tBoxCoMaker.Text,
                                                                     tBoxCoAddress.Text,
                                                                     newCustomerId);
            currentCustomerId = newCustomerId;
        }

        private void insertCollections()
        {
            var a = currentCollectionRow;
            a.Collection_ID = tBoxAccountNo.Text.Trim();
            a.Total_LCP = numTotal.Value.ToString();
            a.Payment = numTotalDown.Value.ToString();
            a.Balance = numBalance.Value.ToString();
            a.UDI = numUDI.Value.ToString();
            a.Total_Rebate = numTotalRebate.Value.ToString();
            a.PN = numPN.Value.ToString();
            a.GRS_Monthly = numGrsMonthly.Value.ToString();
            a.Net_monthly = numNetMonthly.Value.ToString();
            a.Transaction_Date = DateTime.Now;
            a.Notarial_Fee = "0.00";
            a.Delivery_Fee = "0.00";
            a.Other_Pay = "0.00";
            if(currentTransaction == TransactionType.Cash)
            {
                a.Status = "Sold";
            }
            else if(currentTransaction == TransactionType.Installment)
            {
                a.Status = "Pending";
            }
            a.terms = numTerm.Value.ToString();
            a.paymentType = "";
            a.remarks = "";
            a.monthlyRebate = numMonthlyRebate.Value.ToString();
            ServiceLocator.Instance().CollectionServices().CollectionInsert(a);
        }
        private void insertCollectionDetails()
        {
            var latestRow = ServiceLocator.Instance().CollectionServices().LatestCollectionDetails();
            int cDetailsId = latestRow.id + 1;
            var a = currentCDetailsRow;
            string no = "";
            double expectedBalance = (double)numPN.Value;
            DateTime? expectedDate = null;
            int monthsToAdd = 0;
            for (int x = 0; x < numTerm.Value + 2; x++)
            {
                a.Collection_Details_ID = cDetailsId.ToString("000000") + "-" + currentBranch;
                a.NO = no;
                a.OR_Number = "";
                a.PRIN_Amount = "";
                a.Total_Amount = "";
                a.Penalty = "";
                a.Rebate = "";
                a.Discount = "";
                a.Acct_Balance = "";
                a.Collection_ID = tBoxAccountNo.Text.Trim();
                a.expected_balance = expectedBalance.ToString();
                a.paymentType = "";
                a.remarks = "";
                a.stockNo = "";
                a.transaction_date = dtDRDate.Value;
                a.expected_date = expectedDate;
                a.coll_cash_amt = "";
                a.col_cheque_amt = "";
                ServiceLocator.Instance().CollectionServices().CollectionDetailsInsert(a);
                expectedBalance = expectedBalance - (double)numGrsMonthly.Value;
                if(expectedBalance <= 0)
                {
                    expectedBalance = 0;
                }
                cDetailsId = cDetailsId + 1;
                no = (x + 1).ToString();
                expectedDate = dtDueDate.Value.AddMonths(monthsToAdd);
                monthsToAdd = monthsToAdd + 1;
            }
        }
        private void updateCustomer()
        {
            if(currentCustomerTransMode == customerTransMode.update)
            {
                if (!string.IsNullOrEmpty(newCustomerId) && newCustomerId != currentCustomerId)
                {
                    ServiceLocator.Instance().DRServices().UpdateCustomer(newCustomerId, tBoxAccountNo.Text);
                    ServiceLocator.Instance().CustomerServices().UpdateForDeliveryReceipt(tBoxFullname.Text,
                                                                                      tboxAddress.Text,
                                                                                      tBoxEmployer.Text,
                                                                                      tBoxEmpAddress.Text,
                                                                                      tBoxCoMaker.Text,
                                                                                      tBoxCoAddress.Text,
                                                                                      newCustomerId);
                }
                else
                {
                    ServiceLocator.Instance().CustomerServices().UpdateForDeliveryReceipt(tBoxFullname.Text,
                                                                                      tboxAddress.Text,
                                                                                      tBoxEmployer.Text,
                                                                                      tBoxEmpAddress.Text,
                                                                                      tBoxCoMaker.Text,
                                                                                      tBoxCoAddress.Text,
                                                                                      currentCustomerTb.FirstOrDefault().ID_Number);
                }
            }
            else
            {
                addCustomer();
                ServiceLocator.Instance().DRServices().UpdateCustomer(newCustomerId, tBoxAccountNo.Text);
                ServiceLocator.Instance().CustomerServices().UpdateForDeliveryReceipt(tBoxFullname.Text,
                                                                                  tboxAddress.Text,
                                                                                  tBoxEmployer.Text,
                                                                                  tBoxEmpAddress.Text,
                                                                                  tBoxCoMaker.Text,
                                                                                  tBoxCoAddress.Text,
                                                                                  newCustomerId);
            }
        }

        private void updateTransaction()
        {
            updateCustomer();
            updateDr();
            updateDRDetails();
            updateCollections();
            updateCollectionDetails();
        }

        private void updateCollectionDetails()
        {
            if (currentCDetailsTb.Rows.Count > 0)
            {
                var a = currentCollectionTb.FirstOrDefault();
                if (numTotal.Value != decimal.Parse(a.Total_LCP) || numBalance.Value != decimal.Parse(a.Balance) || numPN.Value != decimal.Parse(a.PN))
                {
                    ServiceLocator.Instance().CollectionServices().DeleteCollectionDetailsByAccountNo(tBoxAccountNo.Text);
                    insertCollectionDetails();
                }
            }
        }

        private void updateDr()
        {
            string SI = "";
            string DR = "";
            if(cBoxSI_DR.Text == "SI")
            {
                SI = tBoxSI_DRNo.Text;
                DR = "";
            }
            else
            {
                SI = "";
                DR = tBoxSI_DRNo.Text;
            }
            ServiceLocator.Instance().DRServices().UpdateDRforDR(cBoxAcctype.Text, 
                                                                 dtDRDate.Value.ToShortDateString(), 
                                                                 SI,
                                                                 tBoxSalesman.Text,
                                                                 tBoxCIBy.Text,
                                                                 DR, cBoxSI_DR.Text, 
                                                                 tBoxAccountNo.Text);
        }
        private void updateDRDetails()
        {
            foreach (var drDetails in currentDrDetailsTb)
            {
                if (drDetails.qnty == "0")
                {
                    var drDetailsTb = ServiceLocator.Instance().DRServices().GetDrDetails();
                    int drDetailsId = drDetailsTb.LastOrDefault().id;
                    drDetailsId = drDetailsId + 1;
                    drDetails.DR_Details_ID = drDetailsId.ToString("00000") + "-" + currentBranch;
                    drDetails.qnty = "1";
                    if (drDetails.pStatus == "Primary")
                    {
                        drDetails.BalanceAF = numBalance.Value.ToString();
                        drDetails.LCP = numTotal.Value.ToString();
                    }
                    else
                    {
                        drDetails.BalanceAF = "0.00";
                        drDetails.LCP = "0.00";
                        drDetails.PN = "0.00";
                        drDetails.down_payment = "0.00";
                    }
                    ServiceLocator.Instance().DRServices().InsertDRDetails(drDetails);
                }

                else if(drDetails.qnty == "1" && !string.IsNullOrEmpty(drDetails.pStatus) && drDetails.description != cBoxTotalType.Text)
                {
                    ServiceLocator.Instance().DRServices().UpdateDescriptionByStockNo(cBoxTotalType.Text, drDetails.stockNo);
                }

                if(currentTransaction == TransactionType.Installment && drDetails.pStatus == "Primary")
                {
                    drDetails.LCP = numTotal.Value.ToString();
                }
                else
                {
                    drDetails.LCP = "0.00";
                }
                drDetails.down_payment = numTotalDown.Value.ToString();
                drDetails.PN = numPN.Value.ToString();
                drDetails.BalanceAF = numBalance.Value.ToString();
                drDetails.LCP = numTotal.Value.ToString();
                ServiceLocator.Instance().DRServices().UpdatePrimaryInstallment(drDetails.down_payment, drDetails.PN, drDetails.BalanceAF, drDetails.LCP, drDetails.orAmt, drDetails.or_number, drDetails.DR_Details_ID);
            }
        }

        private void updateCollections()
        {
            var a = currentCollectionRow;
            a.id = a.id;
            a.Collection_ID = tBoxAccountNo.Text;
            a.Total_LCP = numTotal.Value.ToString();
            a.Payment = numTotalDown.Value.ToString();
            a.Balance = numBalance.Value.ToString();
            a.terms = numTerm.Value.ToString();
            a.UDI = numUDI.Value.ToString();
            a.monthlyRebate = numMonthlyRebate.Value.ToString();
            a.Total_Rebate = numTotalRebate.Value.ToString();
            a.PN = numPN.Value.ToString();
            a.GRS_Monthly = numGrsMonthly.Value.ToString();
            a.Net_monthly = numNetMonthly.Value.ToString();
            a.Transaction_Date = DateTime.Now;
            a.Notarial_Fee = "0.00";
            a.Delivery_Fee = "0.00";
            a.Other_Pay = "0.00";
            ServiceLocator.Instance().CollectionServices().UpdateCollection(a);
        }

        private void tBoxFullname_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tBoxFullname.Text))
            {
                customerChecker();
            }
        }

        private void customerChecker()
        {
            currentCustomerTb = ServiceLocator.Instance().CustomerServices().GetLikefullname(tBoxFullname.Text);
            if(currentCustomerTb.Count > 0)
            {
                if(currentMode == DRModes.Update)
                {
                    currentCustomerTransMode = customerTransMode.update;
                }
                newCustomerId = currentCustomerTb.FirstOrDefault().ID_Number;
                var a = currentCustomerTb.FirstOrDefault();
                tBoxFullname.Text = a.fullName;
                tBoxFullname.Tag = a.ID_Number;
                tboxAddress.Text = a.address;
                tBoxEmployer.Text = a.employer;
                tBoxEmpAddress.Text = a.employerAddress;
                tBoxCoMaker.Text = a.co_Maker;
                tBoxCoAddress.Text = a.co_MakerAddress;
            }
            else
            {
                if(currentMode == DRModes.Update)
                {
                    currentCustomerTransMode = customerTransMode.add;
                }
                tboxAddress.Text = "-";
                tBoxEmployer.Text = "-";
                tBoxEmpAddress.Text = "-";
                tBoxCoMaker.Text = "-";
                tBoxCoAddress.Text = "-";
            }
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(currentDrDetailsTb.Rows.Count > 0)
            {
                removeDrDetails();
            }
        }
        private void removeDrDetails()
        {
           var currentRowSelected = (DeliveryReceiptDatasets.DR_detailsRow)((DataRowView)dGridDrDetails.CurrentRow.DataBoundItem).Row;
            if(currentDrDetailsTb.AsQueryable().Where(x=> x == currentRowSelected).Single() != null)
            {
                if (currentRowSelected.id < 0)
                {
                    currentDrDetailsTb.RemoveDR_detailsRow(currentRowSelected);
                    populateDrDetailsTb(currentDrDetailsTb);
                }
                else
                {
                    MessageBox.Show("You can only remove newly added details, pls contact administrator for assistance.","Warning");
                }
            }
        }

        private void dtDRDate_ValueChanged(object sender, EventArgs e)
        {
            dtDueDate.Value = dtDRDate.Value.AddMonths(1);
        }
        private void calculateEntries()
        {
            decimal udi;
            decimal pn;
            decimal balance;
            udi = numNetMonthly.Value * numTerm.Value + numTotalDown.Value - numTotal.Value;
            pn = numGrsMonthly.Value * numTerm.Value;
            balance = numTotal.Value - numTotalDown.Value;
            if(udi >= 0)
            {
                numUDI.Value = udi;
            }
            if(pn >= 0)
            {
                numPN.Value = pn;
            }
            if(balance >= 0)
            {
                numBalance.Value = balance;
            }

        }

        private void numTotal_ValueChanged(object sender, EventArgs e)
        {
            calculateEntries();
        }

        private enum customerTransMode
        {
            add,
            update
        }

        private void btnViewPayments_Click(object sender, EventArgs e)
        {
            updateDeliveryCollections udc = new updateDeliveryCollections();
            udc.acctNo = tBoxAccountNo.Text;
            udc.Show();
        }

        private void tBoxAccountNo_Enter(object sender, EventArgs e)
        {
            if (currentMode == DRModes.New)
            {
                ToolTip accountToolTip = new ToolTip();
                accountToolTip.ToolTipTitle = "Tips";
                accountToolTip.ToolTipIcon = ToolTipIcon.Info;
                accountToolTip.ShowAlways = true;
                accountToolTip.SetToolTip(this.tBoxAccountNo, "Press enter after typing account number \n to check Details by AccountNo or to update details.");
            }
        }

        private void tBoxAccountNo_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnAddOr_Click(object sender, EventArgs e)
        {
            if(currentTransaction == TransactionType.Installment)
            {
               
            }
            else
            {
                MessageBox.Show("Cannot add OR for cash transaction.");
            }
        }

        private void addOr()
        {
            ModalAmount priceModal = new ModalAmount(currentTransaction,"","");
            priceModal.Amount += (ss, ee) => { 
                        
            };
        }
    }
}
