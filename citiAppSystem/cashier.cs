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
    public partial class cashier : MetroForm
    {

        string acctNo = "";
        string customerNo = "";
        string transType = "";
        string downType = "";

        public cashier()
        {
            InitializeComponent();
        }

        private void cashier_Load(object sender, EventArgs e)
        {
            tboxBank.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            tboxAcctNo.Text = "";
            if (radioButton1.Checked == true)
            {
                tboxAcctNo.Enabled = true;
                tboxLastName.Enabled = true;
                tboxMiddleName.Enabled = true;
                tboxFirstName.Enabled = true;
                cboxRemarks.Enabled = false;

                tboxAcctNo.Text = "";
                tboxFirstName.Text = "";
                tboxLastName.Text = "";
                tboxMiddleName.Text = "";
              

               

                DialogResult res = MessageBox.Show("New Customer?", "System", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    Global.process.CustomerclickFrom = "Add";
                    CustomerForms.add_updateCustomer nc = new CustomerForms.add_updateCustomer();
                    DialogResult result = nc.ShowDialog();
                    if (result == DialogResult.Yes)
                    {

                        customerNo = nc.idNumber;
                        tboxFirstName.Text = nc.firstName;
                        tboxLastName.Text = nc.lastName;
                        tboxMiddleName.Text = nc.middleName;
                        btnSearch.Visible = true;
                        Global.process.CustomerclickFrom = "";

                        transType = "new";
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

                        tboxFirstName.Text = Global.customerDetails.f_Name;
                        tboxLastName.Text = Global.customerDetails.l_Name;
                        tboxMiddleName.Text = Global.customerDetails.m_Name;

                        btnSearch.Visible = true;

                        Global.process.SearchCustomerFromDR = "";


                        transType = "new";
                    }
                    else
                    {
                        radioButton1.Checked = false;
                        transType = "";
                    }
                }
                else
                {
                    radioButton1.Checked = false;
                    transType = "";
                    
                }

                panel1.Enabled = true;
                panel2.Enabled = true;
            }


           

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tboxAcctNo.Text = "";
            if (radioButton2.Checked == true)
            {
                tboxAcctNo.Enabled = true;
                tboxLastName.Enabled = false;
                tboxMiddleName.Enabled = false;
                tboxFirstName.Enabled = false;
                cboxRemarks.Enabled = false;
                tboxFirstName.Text = "";
                tboxLastName.Text = "";
                tboxMiddleName.Text = "";
                
                

                 panel1.Enabled = true;
                panel2.Enabled = true;


                DialogResult message_ = MessageBox.Show("Search for an Account?","System",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (message_ == DialogResult.Yes)
                {
                    Global.process.role = "Accounting";
                    deliveryView dV = new deliveryView();
                    DialogResult result = dV.ShowDialog();
                    if (result == DialogResult.Yes)
                    {

                        tboxAcctNo.Text = Customer.AccountNo;
                        tboxFirstName.Text = Customer.f_name;
                        tboxMiddleName.Text = Customer.m_name;
                        tboxLastName.Text = Customer.l_name;

                       


                    }
                }

                btnViewAccDetails.Visible = true;


                transType = "installment";

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tboxAcctNo.Text = "";
            if (radioButton3.Checked == true)
            {
                tboxAcctNo.Enabled = true;
                tboxLastName.Enabled = false;
                tboxMiddleName.Enabled = false;
                tboxFirstName.Enabled = false;
                cboxRemarks.Enabled = true;
                tboxFirstName.Text = "";
                tboxLastName.Text = "";
                tboxMiddleName.Text = "";
                
                transType = cboxRemarks.Text;

                panel1.Enabled = true;
                panel2.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxAcctNo_Leave(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
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

                tboxAMT.Text = tboxNetAMT.Text;
                tboxAMT.Enabled = false;

            }
            else if(comboBox1.Text == "Cheque")
            {
                tboxBank.Enabled = true;
                lblChequeNo.Visible = true;
                tboxChequeNo.Visible = true;
                tboxChange.Visible = true;
                lblChange.Visible = true;
                lblBank.Visible = true;
                tboxBank.Visible = true;
                tboxAMT.Enabled = true;
            }
            else if (comboBox1.Text == "Credit Card")
            {
                tboxBank.Enabled = true;
                lblChequeNo.Visible = true;
                tboxChequeNo.Visible = true;
                tboxChange.Visible = false;
                lblChange.Visible = false;
                tboxChange.Text = "-";
                lblBank.Visible = true;
                tboxBank.Visible = true;
                tboxAMT.Enabled = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
            citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter cTransAdapter = new citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter();
            citiAppDatabaseDataSetTableAdapters.collectionTableAdapter collectionAdapter = new citiAppDatabaseDataSetTableAdapters.collectionTableAdapter();
            citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter c_DetailsAdapter = new citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter();

            if (tboxOrNo.Text.Length > 0 && tboxAcctNo.Text.Length > 0)
            {
                if (comboBox1.Text == "Cheque" || comboBox1.Text == "Credit Card" || comboBox1.Text == "Cash")
                {
                   
                    DialogResult res = MessageBox.Show("Finish transaction?", "Notification", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        if (transType == "new" || (transType == "down" && downType == "new") || transType == "cod")
                        {

                            //drAdapter.Insert(tboxAcctNo.Text, "", "", "", "", customerNo, tboxAcctNo.Text, "Pending", Convert.ToDateTime(null), Global.process.branchID);

                            //cTransAdapter.Insert(transType, tboxOrNo.Text, Convert.ToDateTime(dateTimePicker1.Text),
                            //    tboxAcctNo.Text,
                            //    tboxGRSAMT.Text,
                            //    tboxRebate.Text,
                            //    tboxInterest.Text,
                            //    tboxDiscount.Text,
                            //    tboxNetAMT.Text,
                            //    comboBox1.Text,
                            //    tboxAMT.Text,
                            //    tboxBank.Text,
                            //    tboxChequeNo.Text, "pending",
                            //    tboxChange.Text);

                            collectionAdapter.Insert(tboxAcctNo.Text, "", "", "", "", "", "", "", "", Convert.ToDateTime(null), "", "", "", "Pending", "", "", "", tboxRebate.Text);
                        }
                        else if(transType == "installment")
                        {
                            citiAppDatabaseDataSet.collection_detailsRow cdRow = (citiAppDatabaseDataSet.collection_detailsRow)c_DetailsAdapter.GetDataByEmptyOR(tboxAcctNo.Text).Rows[1];
                            double currentBalance = 0;
                            if (cdRow.NO == "1")
                            {
                                citiAppDatabaseDataSet.collection_detailsRow cdRow2 = (citiAppDatabaseDataSet.collection_detailsRow)c_DetailsAdapter.GetDataByEmptyOR(tboxAcctNo.Text).Rows[0];
                                currentBalance = Double.Parse(cdRow2.expected_balance);
                            }
                            else
                            {
                                citiAppDatabaseDataSet.collection_detailsRow cdRow1 = (citiAppDatabaseDataSet.collection_detailsRow)c_DetailsAdapter.GetDataByLatestBalance(tboxAcctNo.Text).Rows[0];
                                currentBalance = Double.Parse(cdRow1.Acct_Balance);
                            }
                            
                            double balance = currentBalance - Double.Parse(tboxAMT.Text);  
                            string cash_amount = "";
                            string cheque_amount = "";
                            if(comboBox1.Text == "Cash" || comboBox1.Text == "Credit Card")
                            {
                             cash_amount = tboxAMT.Text;
                            cheque_amount = "0";
                            }
                            else if(comboBox1.Text == "Cheque")
                            {
                                cash_amount = "0";
                            cheque_amount = tboxAMT.Text;
                            }

                            //c_DetailsAdapter.UpdateQueryByInstallment(tboxOrNo.Text,
                            //                                            tboxGRSAMT.Text,
                            //                                            tboxNetAMT.Text,
                            //                                            tboxInterest.Text,
                            //                                            tboxRebate.Text,
                            //                                            tboxDiscount.Text,
                            //                                            balance.ToString(),
                            //                                            comboBox1.Text,
                            //                                            cash_amount,
                            //                                            cheque_amount,
                            //                                            dateTimePicker1.Text,
                            //                                            cdRow.Collection_Details_ID);

                            //cTransAdapter.Insert(transType, tboxOrNo.Text, Convert.ToDateTime(dateTimePicker1.Text),
                            //tboxAcctNo.Text,
                            //tboxGRSAMT.Text,
                            //tboxRebate.Text,
                            //tboxInterest.Text,
                            //tboxDiscount.Text,
                            //tboxNetAMT.Text,
                            //comboBox1.Text,
                            //tboxAMT.Text,
                            //tboxBank.Text,
                            //tboxChequeNo.Text, "pending",
                            //tboxChange.Text);
                        }

                        //else if (transType == "down" && downType == "old")
                        //{
                        //    cTransAdapter.Insert(transType, tboxOrNo.Text, Convert.ToDateTime(dateTimePicker1.Text),
                        //    tboxAcctNo.Text,
                        //    tboxGRSAMT.Text,
                        //    tboxRebate.Text,
                        //    tboxInterest.Text,
                        //    tboxDiscount.Text,
                        //    tboxNetAMT.Text,
                        //    comboBox1.Text,
                        //    tboxAMT.Text,
                        //    tboxBank.Text,
                        //    tboxChequeNo.Text, "pending",
                        //    tboxChange.Text);
                        //}


                        //para sa new transaction lang
                            DialogResult newTransactionRES = MessageBox.Show("New Transaction?", "Notification", MessageBoxButtons.YesNo);
                            if (newTransactionRES == DialogResult.Yes)
                            {
                                this.Close();
                                cashier cs = new cashier();
                                cs.Show();
                            }
                            else
                            {
                                this.Close();
                            }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Check Remarks");
                }
            }
            else
            {
                MessageBox.Show("No account number or OR number");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Global.process.SearchCustomerFromDR = "1";
            customerView cv = new customerView();
            DialogResult result = cv.ShowDialog();
            if (result == DialogResult.Yes)
            {
                customerNo = Global.customerDetails.id_Number;

                tboxFirstName.Text = Global.customerDetails.f_Name;
                tboxLastName.Text = Global.customerDetails.l_Name;
                tboxMiddleName.Text = Global.customerDetails.m_Name;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void tboxAMT_TextChanged(object sender, EventArgs e)
        {

            if (tboxAMT.Text == "")
            {
                tboxAMT.Text = ".00";
            }
            double change = Convert.ToDouble(tboxAMT.Text) - Convert.ToDouble(tboxNetAMT.Text);

            tboxChange.Text = change.ToString("N2");
        }

        private void tboxAMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxAMT.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tboxAcctNo.Text = "";

            citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
      

            citiAppDatabaseDataSet.deliveryReceiptDataTable drDT = drAdapter.GetData();
            int DRindexNo = drDT.Rows.Count + 1;
            if (radioButton4.Checked == true)
            {
                tboxAcctNo.Enabled = true;
                tboxLastName.Enabled = true;
                tboxMiddleName.Enabled = true;
                tboxFirstName.Enabled = true;
                cboxRemarks.Enabled = false;

                tboxAcctNo.Text = "dp-" + DRindexNo.ToString();
                tboxFirstName.Text = "";
                tboxLastName.Text = "";
                tboxMiddleName.Text = "";


                panel1.Enabled = true;
                panel2.Enabled = true;
                transType = "down";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            tboxAcctNo.Text = "";

            citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();


            citiAppDatabaseDataSet.deliveryReceiptDataTable drDT = drAdapter.GetData();
            int DRindexNo = drDT.Rows.Count + 1;
            if (radioButton5.Checked == true)
            {
                tboxAcctNo.Enabled = true;
                tboxLastName.Enabled = true;
                tboxMiddleName.Enabled = true;
                tboxFirstName.Enabled = true;
                cboxRemarks.Enabled = false;

                tboxAcctNo.Text = "";
                tboxFirstName.Text = "";
                tboxLastName.Text = "";
                tboxMiddleName.Text = "";




                DialogResult res = MessageBox.Show("New Customer?", "System", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    Global.process.CustomerclickFrom = "Add";
                    CustomerForms.add_updateCustomer nc = new CustomerForms.add_updateCustomer();
                    DialogResult result = nc.ShowDialog();
                    if (result == DialogResult.Yes)
                    {

                        customerNo = nc.idNumber;
                        tboxFirstName.Text = nc.firstName;
                        tboxLastName.Text = nc.lastName;
                        tboxMiddleName.Text = nc.middleName;
                        btnSearch.Visible = true;

                        Global.process.CustomerclickFrom = "";

                        transType = "cod";
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

                        tboxFirstName.Text = Global.customerDetails.f_Name;
                        tboxLastName.Text = Global.customerDetails.l_Name;
                        tboxMiddleName.Text = Global.customerDetails.m_Name;

                        btnSearch.Visible = true;
                        Global.process.SearchCustomerFromDR = "";

                        transType = "cod";
                    }
                    else
                    {
                        radioButton5.Checked = false;
                        transType = "";

                    }
                }
                else
                {
                    radioButton5.Checked = false;
                    transType = "";

                }

                panel1.Enabled = true;
                panel2.Enabled = true;
            }
        }

        private void tboxAcctNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
                citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter custAdapter = new citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter();
                citiAppDatabaseDataSet.deliveryReceiptDataTable drAcctNoDT = drAdapter.GetDataByAccountNo(tboxAcctNo.Text);
                citiAppDatabaseDataSet.deliveryReceiptDataTable drDT = drAdapter.GetData();
                int DRindexNo = drDT.Rows.Count + 1;
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    acctNo = tboxAcctNo.Text + "-" + DRindexNo.ToString();
                    tboxAcctNo.Text = acctNo;
                }
                else if (radioButton4.Checked == true)
                {
                    citiAppDatabaseDataSet.deliveryReceiptDataTable deliveryDt = drAdapter.GetDataByAccountNo(tboxAcctNo.Text);
                    if (deliveryDt.Rows.Count.Equals(0))
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
                                tboxFirstName.Text = nc.firstName;
                                tboxLastName.Text = nc.lastName;
                                tboxMiddleName.Text = nc.middleName;
                                btnSearch.Visible = true;

                                Global.process.CustomerclickFrom = "";
                                downType = "new";
                               
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

                                tboxFirstName.Text = Global.customerDetails.f_Name;
                                tboxLastName.Text = Global.customerDetails.l_Name;
                                tboxMiddleName.Text = Global.customerDetails.m_Name;

                                btnSearch.Visible = true;
                                Global.process.SearchCustomerFromDR = "";
                                downType = "new";
                              
                            }
                            else
                            {
                                radioButton4.Checked = false;
                                transType = "";
                                downType = "";

                            }
                        }
                        else
                        {
                            radioButton4.Checked = false;
                            transType = "";
                            downType = "";

                        }

                    }
                    else
                    {
                        acctNo = tboxAcctNo.Text;
                        citiAppDatabaseDataSet.deliveryReceiptRow drRow = (citiAppDatabaseDataSet.deliveryReceiptRow)drAdapter.GetDataByAccountNo(acctNo).Rows[0];
                        customerNo = drRow.ID_Number.ToString();
                        citiAppDatabaseDataSet.customerTableRow cusRow = (citiAppDatabaseDataSet.customerTableRow)custAdapter.GetDataBySearchByID_Num(customerNo).Rows[0];

                        tboxFirstName.Text = cusRow.f_Name.ToString();
                        tboxLastName.Text = cusRow.last_Name.ToString();
                        tboxMiddleName.Text = cusRow.mid_Name.ToString();

                        downType = "old";
                    }
                }
                else
                {
                    if (drAcctNoDT.Rows.Count.Equals(1))
                    {
                        acctNo = tboxAcctNo.Text;
                        citiAppDatabaseDataSet.deliveryReceiptRow drRow = (citiAppDatabaseDataSet.deliveryReceiptRow)drAdapter.GetDataByAccountNo(acctNo).Rows[0];
                        customerNo = drRow.ID_Number.ToString();
                        citiAppDatabaseDataSet.customerTableRow cusRow = (citiAppDatabaseDataSet.customerTableRow)custAdapter.GetDataBySearchByID_Num(customerNo).Rows[0];

                        tboxFirstName.Text = cusRow.f_Name.ToString();
                        tboxLastName.Text = cusRow.last_Name.ToString();
                        tboxMiddleName.Text = cusRow.mid_Name.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Account Number doesn't exist");
                        tboxMiddleName.Text = "";
                        tboxLastName.Text = "";
                        tboxFirstName.Text = "";
                    }
                }
            }
        }

        private void btnViewAccDetails_Click(object sender, EventArgs e)
        {

            try
            {
                Global.process.role = "Accounting";
                updateDeliveryCollections udc = new updateDeliveryCollections();
                udc.acctNo = tboxAcctNo.Text;
                udc.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Source+": " + ex.Message);
              
            }
            
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
    
        }
    }
}
