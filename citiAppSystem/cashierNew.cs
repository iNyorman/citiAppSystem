using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Datasets.CollectionDatasetsTableAdapters;
using citiAppSystem.Modules.Models;
using citiAppSystem.Modules.Models.EF;
using citiAppSystem.Modules.Models.EF.Services;
using citiAppSystem.Modules.Views.Cashiers;
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
    public partial class cashierNew : MetroForm
    {


        string installmentType = "";
        string custID = "";
        string accountNo = "";
        TransactionType currentType;
        c_TransTable cTransTable;
        customerTable customerDetails;
        deliveryReceipt dr;
        List<collection_details> collectionDetailsList;
        collection_details  collectionDetails;
        citiAppDatabaseEntities dbContext;
        string collectionDetailsBranchNo = "";
        public cashierNew()
        {
            InitializeComponent();
            collectionDetails = new collection_details();
            customerDetails = new customerTable();
            collectionDetailsList = new List<collection_details>();

            cTransTable = new c_TransTable();
            dbContext = new citiAppDatabaseEntities();
        }

  

        private void cashierNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
            if (Global.process.branchID == "02")
            {
                this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);
                cboxBranch.Text = "";
            }
            else
            {
                cboxBranch.Enabled = false;
                this.branchTableAdapter.FillByBranchNo(this.citiAppDatabaseDataSet.branch,Global.process.branchID);
            }

            currentType = TransactionType.None;
            cboxTransactionType.Text = "";
            
        }

        private void cboxRemarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTransactionType.Text == "DOWN")
            {

                tboxAcctNo.Text = "DP";

                tBoxCustomerName.Text = "";
                labelNo.Visible = false;
                tBoxNoPayment.Visible = false;
                checkerAssignPayment.Visible = false;
         
                btnViewAccDetails.Visible = false;
            }
            else if (cboxTransactionType.Text == "INSTALLMENT")
            {

                tboxAcctNo.Text = "";
                tBoxCustomerName.Text = "";
                labelNo.Visible = true;
                tBoxNoPayment.Visible = true;
                checkerAssignPayment.Visible = true;
            }
            else
            {
                tboxAcctNo.Text = "";
                tBoxCustomerName.Text = "";
                btnViewAccDetails.Visible = false;
                labelNo.Visible = false;
                tBoxNoPayment.Visible = false;
                checkerAssignPayment.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
        private void tboxAcctNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (currentType != TransactionType.OR)
                {
                    if (cboxTransactionType.Text == "INSTALLMENT")
                    {
                        //citiAppDatabaseDataSet.deliveryReceiptDataTable drAcctNoDT = drAdapter.GetDataByAccountNo(tboxAcctNo.Text);
                        //var dr = ServiceLocator.Instance().DRServices().DrByAccountNo(tboxAcctNo.Text);
                        var dr = CitiAppDbServices.deliveryReceipt().DrByAcount(tboxAcctNo.Text);
                        if (dr != null)
                        {
                            collectionDetailsBranchNo = dr.branchNo;
                            custID = dr.ID_Number;
                            currentType = TransactionType.AccountNo;
                            //citiAppDatabaseDataSet.customerTableRow cusRow = (citiAppDatabaseDataSet.customerTableRow)cusAdapter.GetDataBySearchByID_Num(idnumber).Rows[0];
                            //var customer = ServiceLocator.Instance().CustomerServices().CustomerByID_Number(idnumber);
                            customerDetails = CitiAppDbServices.customer().CustomerByIdNumber(custID);
                            tBoxCustomerName.Text = customerDetails.fullName;
                            installmentType = "old";
                            dateTimePicker1.Focus();
                        }
                        else
                        {
                            DialogResult res = MessageBox.Show("Account number doesn't exist,Create new account?", "Notification", MessageBoxButtons.YesNo);

                            if (res == DialogResult.Yes)
                            {
                                installmentType = "new";
                            }
                            else if (res == DialogResult.No)
                            {
                                cboxTransactionType.Text = "";
                                installmentType = "";
                            }
                            else
                            {
                                cboxTransactionType.Text = "";
                                installmentType = "";
                            }
                        }
                    }
                }
            }
        }
        private void RetrieveCustomerById(string idNumber)
        {
            customerDetails = CitiAppDbServices.customer().CustomerByIdNumber(idNumber);
            if (customerDetails != null)
            {
                tBoxCustomerName.Text = customerDetails.fullName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstname;
            string middlename;
            string lastname;
            string fullname;

            if (cboxTransactionType.Text.Length > 0 && tboxOrNo.Text.Length > 0 && tboxAcctNo.Text.Length > 0 && cboxPayType.Text.Length > 0)
            {
                if (!string.IsNullOrEmpty(tBoxCustomerName.Text))
                {
                    customerNameManager(out firstname, out middlename, out lastname, out fullname);
                    DialogResult res = MessageBox.Show("Proceed Transaction?", "Notification", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        if (currentType == TransactionType.OR)
                        {
                            ORTransaction(firstname, middlename, lastname, fullname);
                        }
                        else
                        {
                            mainTransaction(firstname, middlename, lastname, fullname);
                        }
                    }
                }
                else {
                    MessageBox.Show("Customer name is empty.");
                }
            }       
            else
            {
                MessageBox.Show("Check important inputs.");
            }
        }

        private void customerNameManager(out string firstname, out string middlename, out string lastname, out string fullname)
        {
            var customerName = tBoxCustomerName.Text.Split(',');


            firstname = "";
            middlename = "";
            lastname = "";
            fullname = "";
            if (customerName.Length >= 2)
            {
                lastname = customerName[0];
                firstname = customerName[1];
                if (customerName.Length == 3)
                {
                    middlename = customerName[2];
                }
                fullname = tBoxCustomerName.Text;
            }
            else
            {
                fullname = tBoxCustomerName.Text;
            }

            customerDetails = CitiAppDbServices.customer().CustomerByFullname(tBoxCustomerName.Text);
            if(customerDetails == null)
            {
                customerDetails = new customerTable();
                customerDetails.f_Name = firstname;
                customerDetails.last_Name = lastname;
                customerDetails.mid_Name = middlename;
                customerDetails.fullName = tBoxCustomerName.Text;
            }
        }

        private void mainTransaction(string firstname, string middlename, string lastname, string fullname)
        {
            
            PaymentTypeConfigure();
            var a = ServiceLocator.Instance().CustomerServices().GetByName(tBoxCustomerName.Text);
            if (customerDetails.ID_Number != null)
            {
                RetrieveCustomerById(customerDetails.ID_Number);
            }
            else
            {
                newCustomerAssembler();
                
                CitiAppDbServices.Services().customer().Add(customerDetails);
               
            }
            //validateIfSomething here
            if (cboxTransactionType.Text == "DOWN")
            {
                downTransaction(cash_amount, cheque_amount);
            }
            else if (cboxTransactionType.Text == "INSTALLMENT")
            {
                if (installmentType == "old")
                {
                    updateCollectionDetails();

                        var ctransChecker = CitiAppDbServices.CashierTransactions().CTransByORNum(tboxOrNo.Text, cboxBranch.SelectedValue.ToString());
                        if (ctransChecker != null)
                        {
                            NewCTransaction("used", cash_amount, cheque_amount);
                            CitiAppDbServices.CashierTransactions().Update(cTransTable);
                        }
                        else
                        {
                            NewCTransaction("used", cash_amount, cheque_amount);
                            InsertCTransaction();
                        }

                        //para sa new transaction lang
                        DialogResult newTransactionRES = MessageBox.Show("New Transaction?", "Notification", MessageBoxButtons.YesNo);
                        if (newTransactionRES == DialogResult.Yes)
                        {
                            this.Close();
                            cashierNew cs = new cashierNew();
                            cs.Show();
                        }
                        else
                        {
                            this.Close();
                        }
                }
                else if (installmentType == "new")
                {
                    NewCTransaction("pending", cash_amount, cheque_amount);
                    if (tboxAcctNo.Text.Length <= 5)
                    {
                       
                        int drIndex = CitiAppDbServices.CashierTransactions().CTransList().LastOrDefault().trans_Id + 1;
                        cTransTable.AccountNo = tboxAcctNo.Text + "-" + drIndex.ToString() + "-" + DateTime.Now.Date.Year;
                    }
                    else
                    {
                        cTransTable.AccountNo = tboxAcctNo.Text;
                    }
                    InsertCTransaction();
                    DialogResult newTransactionRES = MessageBox.Show("New Transaction?", "Notification", MessageBoxButtons.YesNo);
                    if (newTransactionRES == DialogResult.Yes)
                    {
                        this.Close();
                        cashierNew cs = new cashierNew();
                        cs.Show();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Installment Invalid");
                }
            }
            //COD
            else if (cboxTransactionType.Text == "COD")
            {
                //ctrans insert
                NewCTransaction("pending", cash_amount, cheque_amount);
                InsertCTransaction();

                //para sa new transaction lang
                DialogResult newTransactionRES = MessageBox.Show("New Transaction?", "Notification", MessageBoxButtons.YesNo);
                if (newTransactionRES == DialogResult.Yes)
                {
                    this.Close();
                    cashierNew cs = new cashierNew();
                    cs.Show();
                }
                else
                {
                    this.Close();
                }
            }
            //misc
            else
            {
                NewCTransaction("used", cash_amount, cheque_amount);
                InsertCTransaction();

                //para sa new transaction lang
                DialogResult newTransactionRES = MessageBox.Show("New Transaction?", "Notification", MessageBoxButtons.YesNo);
                if (newTransactionRES == DialogResult.Yes)
                {
                    this.Close();
                    cashierNew cs = new cashierNew();
                    cs.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }
        string cash_amount = "";
        string cheque_amount = "";
        double balance = 0;

        private void ORTransaction(string firstname, string middlename, string lastname, string fullname)
        {
            PaymentTypeConfigure();
            dr = CitiAppDbServices.deliveryReceipt().DrByAcount(tboxAcctNo.Text);
            if (dr != null)
            {
                if (cTransTable.cTransStatus != "used")
                {
                    updateCollectionDetails();
                }
            }
            if (customerDetails.ID_Number != null)
            {
                CitiAppDbServices.customer().Update(customerDetails);
            }
            else
            {
                CitiAppDbServices.customer().Add(customerDetails);
            }
            NewCTransaction("used", cash_amount, cheque_amount);
            updateCTransaction();
            DialogResult newTransactionRES = MessageBox.Show("Update Successful,New Transaction?", "Notification", MessageBoxButtons.YesNo);
            if (newTransactionRES == DialogResult.Yes)
            {
                this.Close();
                cashierNew cs = new cashierNew();
                cs.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void updateCollectionDetails()
        {

            collectionDetailsList = CitiAppDbServices.collectionDetails().ListByAccountNo(tboxAcctNo.Text);
            if (checkerAssignPayment.Checked == true && tBoxNoPayment.Visible == true)
            {
                collectionDetails = collectionDetailsList.Where(x => x.NO.Equals(tBoxNoPayment.Text)).FirstOrDefault();
                if (collectionDetails != null)
                {

                    CitiAppDbServices.collectionDetails().Update(collectionDetails);
                }
            }
            else
            {
                if (collectionDetailsList.Where(x => x.expected_balance == "0" && !string.IsNullOrEmpty(x.OR_Number)).FirstOrDefault() == null)
                {
                    if (collectionDetailsList.Where(x => x.OR_Number == tboxOrNo.Text).FirstOrDefault() == null)
                    {
                        double currentBalance = 0;
                        collectionDetails = collectionDetailsList.Where(x => !string.IsNullOrEmpty(x.NO) && x.Date == null).FirstOrDefault();
                        if (collectionDetails.NO == "1")
                        {
                            currentBalance = double.Parse(collectionDetails.expected_balance);
                        }
                        else
                        {
                            var lastPaymentCollectionDetails = ServiceLocator.Instance().CollectionServices().CollectionDetailstLastPaymentDetail(tboxAcctNo.Text);
                            var lastRowPayment = CitiAppDbServices.collectionDetails().ListByAccountNo(tboxAcctNo.Text).Where(x => !string.IsNullOrEmpty(x.OR_Number)).LastOrDefault();
                            currentBalance = double.Parse(lastRowPayment.Acct_Balance);
                        }
                        balance = currentBalance - Double.Parse(tboxGRSAMT.Text);
                        updateCollectionDetails(balance);
                        CitiAppDbServices.collectionDetails().Update(collectionDetails);
                    }
                }
                else
                {
                    updateCollectionDetails(balance);
                    collectionDetails.Collection_Details_ID = (CitiAppDbServices.collectionDetails().List().LastOrDefault().id + 1).ToString() + "-" + collectionDetailsBranchNo;
                    collectionDetails.Collection_ID = tboxAcctNo.Text;
                    CitiAppDbServices.collectionDetails().Add(collectionDetails);
                }
            }
        }

        private void PaymentTypeConfigure()
        {
            if (cboxPayType.Text == "Cash" || cboxPayType.Text == "Credit Card")
            {
                cash_amount = tBoxAmount.Text;
                cheque_amount = "0";
            }
            else if (cboxPayType.Text == "Cheque")
            {
                cash_amount = "0";
                cheque_amount = tBoxAmount.Text;
            }
        }

        private void updateCollectionDetails(double balance)
        {
            collectionDetails.OR_Number = tboxOrNo.Text;
            collectionDetails.PRIN_Amount = tboxGRSAMT.Text;
            collectionDetails.Total_Amount = tboxNetAMT.Text;
            collectionDetails.Penalty = tboxInterest.Text;
            collectionDetails.Discount = tboxDiscount.Text;
            collectionDetails.Rebate = tboxRebate.Text;
            collectionDetails.Acct_Balance = balance.ToString();
            collectionDetails.paymentType = cboxPayType.Text;
            collectionDetails.coll_cash_amt = cash_amount;
            collectionDetails.col_cheque_amt = cheque_amount;
            collectionDetails.Date = dateTimePicker1.Value;
            collectionDetails.remarks = tboxRemarks.Text;
        }

        private void InsertCTransaction()
        {
            CitiAppDbServices.CashierTransactions().Add(cTransTable);
        }

        private void updateCTransaction()
        {
            CitiAppDbServices.CashierTransactions().Update(cTransTable);
        }

        private void NewCTransaction(string CTransStatus,string cashAmt,string chequeAmt)
        {
            if (cTransTable == null)
            {
                cTransTable = new c_TransTable();
            }
            cTransTable.trans_Type = cboxTransactionType.Text;
            cTransTable.OR_NUM = tboxOrNo.Text;
            cTransTable.trans_Date = dateTimePicker1.Value;
            cTransTable.AccountNo = tboxAcctNo.Text;
            cTransTable.GRS_AMT = tboxGRSAMT.Text;
            cTransTable.REBATE = tboxRebate.Text;
            cTransTable.INT = tboxInterest.Text;
            cTransTable.DISC = tboxDiscount.Text;
            cTransTable.NET_AMT = tboxNetAMT.Text;
            cTransTable.pay_Type = cboxPayType.Text;
            cTransTable.PAYMENT = tBoxAmount.Text;
            cTransTable.bank = tboxBank.Text;
            cTransTable.chequeNo = tboxChequeNo.Text;
            cTransTable.cTransStatus = CTransStatus;
            cTransTable.change = tboxChange.Text;
            cTransTable.ID_Number = customerDetails.ID_Number;
            cTransTable.branchNo = cboxBranch.SelectedValue.ToString();
            cTransTable.cash_AMT = cashAmt;
            cTransTable.cheque_AMT = chequeAmt;
            cTransTable.remarks = tboxRemarks.Text;
            cTransTable.system_Date = DateTime.Today;
        }

        private void downTransaction(string cash_amount, string cheque_amount)
        {
            NewCTransaction("pending", cash_amount, cheque_amount);
            InsertCTransaction();
            DialogResult newTransactionRES = MessageBox.Show("New Transaction?", "Notification", MessageBoxButtons.YesNo);
            if (newTransactionRES == DialogResult.Yes)
            {
                this.Close();
                cashierNew cs = new cashierNew();
                cs.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }
        private void btnViewAccDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Global.process.role = "Accounting";
                updateDeliveryCollections udc = new updateDeliveryCollections();
                udc.acctNo = tboxAcctNo.Text;
                udc.TopMost = true;
                udc.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Source + ": " + ex.Message);

            }
        }

        public void calculationMethod()
        {

            double netAmt;

            if (tboxGRSAMT.Text == "")
            {
                tboxGRSAMT.Text = ".00";
            }

            if (tboxRebate.Text == "")
            {
                tboxRebate.Text = ".00";
            }

            if (tboxInterest.Text == "")
            {
                tboxInterest.Text = ".00";
            }

            if (tboxDiscount.Text == "")
            {
                tboxDiscount.Text = ".00";
            }



            netAmt = (Convert.ToDouble(tboxGRSAMT.Text) - Convert.ToDouble(tboxRebate.Text) + Convert.ToDouble(tboxInterest.Text) - Convert.ToDouble(tboxDiscount.Text));
            tboxNetAMT.Text = netAmt.ToString("N2");
        }
        private void tboxGRSAMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxGRSAMT.Text.IndexOf('.') != -1)
            {

                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                tboxRebate.Focus();
            }
        }

        private void tboxRebate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxRebate.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                tboxInterest.Focus();
            }
        }

        private void tboxInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxInterest.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                tboxDiscount.Focus();
            }
        }

        private void tboxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxDiscount.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                cboxPayType.Focus();
            }
        }

        private void tboxGRSAMT_TextChanged(object sender, EventArgs e)
        {
            calculationMethod();
        }

        private void tboxRebate_TextChanged(object sender, EventArgs e)
        {
            calculationMethod();
        }

        private void tboxInterest_TextChanged(object sender, EventArgs e)
        {
            calculationMethod();
        }

        private void tboxDiscount_TextChanged(object sender, EventArgs e)
        {
            calculationMethod();
        }

        private void cboxPayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPayType.Text == "Cash")
            {
                tboxBank.Visible = false;
                tboxBank.Text = "-";
                lblChequeNo.Visible = false;
                tboxChequeNo.Visible = false;
                tboxChequeNo.Text = "-";
                tboxChange.Visible = false;
                lblChange.Visible = false;
                tboxChange.Text = "-";
                lblBank.Visible = false;

                tBoxAmount.Text = tboxNetAMT.Text;
                tBoxAmount.Enabled = false;

            }
            else if (cboxPayType.Text == "Cheque")
            {
                tboxBank.Enabled = true;
                lblChequeNo.Visible = true;
                tboxChequeNo.Visible = true;
                tboxChange.Visible = true;
                lblChange.Visible = true;
                lblBank.Visible = true;
                tboxBank.Visible = true;
                tBoxAmount.Enabled = true;
            }
            else if (cboxPayType.Text == "Credit Card")
            {
                tboxBank.Enabled = true;
                lblChequeNo.Visible = true;
                tboxChequeNo.Visible = true;
                tboxChange.Visible = false;
                lblChange.Visible = false;
                tboxChange.Text = "-";
                lblBank.Visible = true;
                tboxBank.Visible = true;
                tBoxAmount.Enabled = true;
            }
            
        }

        private void tboxAcctNo_TextChanged(object sender, EventArgs e)
        {
            if (cboxTransactionType.Text == "INSTALLMENT" && tboxAcctNo.Text.Length > 0)
            {
                btnViewAccDetails.Visible = true;
            }
            else
            {
                btnViewAccDetails.Visible = false;
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {

                try
                {
                    dateTimePicker1.Value = DateTime.Parse(Clipboard.GetText());
                    e.Handled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + ": " + ex.Source);
                }
            }
        }

        private void tboxOrNo_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if(currentType != TransactionType.AccountNo)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter cTransAdapter = new citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter();
                    citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter custAdapter = new citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter();
                    citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchAdapter = new citiAppDatabaseDataSetTableAdapters.branchTableAdapter();

                    citiAppDatabaseDataSet.c_TransTableDataTable cTransDT = cTransAdapter.GetDataByOrBranchNo(tboxOrNo.Text, cboxBranch.SelectedValue.ToString());
                    //cTransTable = new c_TransTable();
                    cTransTable = CitiAppDbServices.CashierTransactions().CTransByORNum(tboxOrNo.Text,cboxBranch.SelectedValue.ToString());
                    if (cTransTable != null)
                    {
                        //citiAppDatabaseDataSet.c_TransTableRow c_TransRow = (citiAppDatabaseDataSet.c_TransTableRow)cTransAdapter.GetDataByORnumber(tboxOrNo.Text).Rows[0];

                        string currentTime = (Convert.ToDateTime(cTransTable.trans_Date) - System.DateTime.Today).TotalHours.ToString();
                        if (Convert.ToInt32(currentTime) >= 24)
                        {
                            MessageBox.Show("Updating of OR is expired.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            OR_Method(cTransAdapter, custAdapter, branchAdapter);
                        }
                    }
                    else
                    {
                        MessageBox.Show("OR Not found on the selected branch.");
                    }
                    tboxGRSAMT.Focus();
                }
            }
            else if (currentType != TransactionType.OR)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    var ctransChecker = ServiceLocator.Instance().CTransServices().GetDataByOR(tboxOrNo.Text, cboxBranch.SelectedValue.ToString());
                    if (ctransChecker.Count > 0)
                    {
                        var ctrans = ctransChecker.FirstOrDefault();
                        if (ctrans.cTransStatus.ToLower() != "used" && ctrans.AccountNo == tboxAcctNo.Text)
                        {
                            tboxOrNo.Text = ctrans.OR_NUM;
                            tboxGRSAMT.Text = ctrans.GRS_AMT;
                            tboxRebate.Text = ctrans.REBATE;
                            tboxInterest.Text = ctrans.INT;
                            tboxDiscount.Text = ctrans.DISC;
                            cboxPayType.Text = ctrans.pay_Type;
                        }
                        else
                        {
                            MessageBox.Show("OR Already used on the selected branch.");
                        }
                    }
                }
            }
           
        }

        

        private void OR_Method(citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter cTransAdapter, citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter custAdapter, citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchAdapter)
        {
            currentType = TransactionType.OR;
            custID = cTransTable.ID_Number;
            tboxGRSAMT.Text = cTransTable.GRS_AMT.ToString();
            tboxInterest.Text = cTransTable.INT.ToString();
            tboxRebate.Text = cTransTable.REBATE.ToString();
            tboxDiscount.Text = cTransTable.DISC.ToString();
            tboxNetAMT.Text = cTransTable.NET_AMT.ToString();
            tboxRemarks.Text = cTransTable.remarks.ToString();
            cboxTransactionType.Text = cTransTable.trans_Type.ToString();
            accountNo = cTransTable.AccountNo.ToString();
            tboxAcctNo.Text = accountNo;
            RetrieveCustomerById(cTransTable.ID_Number);
            dr = CitiAppDbServices.deliveryReceipt().DrByAcount(accountNo);
            if (dr != null)
            {
                tboxAcctNo.Enabled = false;
            }
            else
            {
                tboxAcctNo.Enabled = true;
            }
            cboxTransactionType.Enabled = false;

            cboxPayType.Text = cTransTable.pay_Type.ToString();

            tboxBank.Text = cTransTable.bank.ToString();
            tboxChequeNo.Text = cTransTable.chequeNo.ToString();
            tboxChange.Text = cTransTable.change.ToString();

            if (cboxPayType.Text == "Cash")
            {
                tboxBank.Visible = false;
                lblBank.Visible = false;
                tboxChange.Visible = false;
                lblChange.Visible = false;
                tboxChequeNo.Visible = false;
                lblChequeNo.Visible = false;

            }
            else
            {
                tboxBank.Visible = true;
                lblBank.Visible = true;
                tboxChange.Visible = true;
                lblChange.Visible = true;
                tboxChequeNo.Visible = true;
                lblChequeNo.Visible = true;
            }

            cboxBranch.SelectedValue = cTransTable.branchNo;
            dateTimePicker1.Text = cTransTable.trans_Date.Value.ToShortDateString();
            tboxOrNo.Enabled = false;
            btnSave.Text = "Update OR";
        }

        private void cboxTransactionType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tboxAcctNo.Focus();
            }
        }

        private void cboxBranch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tboxRemarks.Focus();
            }
        }

        private void tboxRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tboxOrNo.Focus();
            }
        }

        private void cboxPayType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tBoxAmount.Focus();
            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cboxBranch.Focus();
            }
        }

        private void tboxChange_Click(object sender, EventArgs e)
        {

        }

        private void tBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tBoxAmount.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (tBoxAmount.Text == "")
            {
                tBoxAmount.Text = ".00";
            }
            double change = Convert.ToDouble(tBoxAmount.Text) - Convert.ToDouble(tboxNetAMT.Text);

            tboxChange.Text = change.ToString("N2");
        }

        private void tboxAMT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxAMT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void viewAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewAccountList();
        }

        private void viewAccountList()
        {
            //deliveryView drv = new deliveryView();
            //drv.btnUpdateDelivery.Visible = false;
            //drv.TopMost = true;
            //drv.ShowDialog();
            frmAccountsList accListform = new frmAccountsList();
            accListform.ShowDialog();
        }


        private enum TransactionType
        {
            None,
            AccountNo,
            OR
        }

        private void tboxOrNo_Leave(object sender, EventArgs e)
        {
        }

        private void tBoxCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                customerExistenceChecker();
            }
        }

        private void customerExistenceChecker()
        {
            var customer = CitiAppDbServices.customer().CustomerByFullname(tBoxCustomerName.Text);
            if (customer != null)
            {
                customerDetails = customer;
                tBoxCustomerName.Text = customerDetails.fullName;
            }
            else
            {
                if (MessageBox.Show("No existing customer found,save new customer?","System",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    newCustomerAssembler();
                    CitiAppDbServices.customer().Add(customerDetails);
                    custID = customerDetails.ID_Number;
                    MessageBox.Show("Successfully added new customer");
                }
                else
                {
                    tBoxCustomerName.Text = "";
                }
            }
        }

        private void newCustomerAssembler()
        {
            var customerName = tBoxCustomerName.Text.Split(',');
            string firstname = "";
            string middlename = "";
            string lastname = "";
            string fullname = "";
            if (customerName.Length >= 2)
            {
                lastname = customerName[0];
                firstname = customerName[1];
                if (customerName.Length == 3)
                {
                    middlename = customerName[2];
                }
                fullname = tBoxCustomerName.Text;
            }
            else
            {
                fullname = tBoxCustomerName.Text;
            }
            customerDetails = new customerTable();
            var customerListCount = CitiAppDbServices.customer().CustomerList().Count + 1;
            customerDetails.ID_Number = "CUS-" + customerListCount.ToString() + "-" + cboxBranch.SelectedValue.ToString();
            customerDetails.f_Name = firstname;
            customerDetails.mid_Name = middlename;
            customerDetails.last_Name = lastname;
            customerDetails.fullName = fullname;
        }

        private void tBoxCustomerName_Leave(object sender, EventArgs e)
        {
        }

        private void checkerAssignPayment_CheckedChanged(object sender, EventArgs e)
        {
            tBoxNoPayment.Enabled = checkerAssignPayment.Checked;
        }
    }
}
