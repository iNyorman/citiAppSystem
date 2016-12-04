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
    public partial class deliveryReceipt : MetroForm
    {
        public deliveryReceipt()
        {
            InitializeComponent();
        }


        public string accountNo = "";
        public string name = "";
        public string IDNUMBER = "";
        public string AccountType = "";
        public string SI_DR_NO = "";
        public string salesman = "";
        public string ci_BY = "";

        //drFORM
        string sidr = "";

        //Collections
        public Boolean updateLCPFromCollections = false;
        public string accountNoFromCollections = "";
        public string collectionNoFromCollectionForm = "";
        public  string totalLCP = "";
        public   string Balance = "";
        public string Payment ="";
        public string UDI = "";
        public string totalRebate = "";
        public string pn = "";
        public string grsMonthly = "";
        public string netMonthly = "";
        public string terms = "";

        string accNo = "";
        private void deliveryReceipt_Load(object sender, EventArgs e)
        {
           
                   
            groupCustomerDetails.Enabled = false;
            panel1.Enabled = false;
            btnAddProduct.Enabled = false;
            btnRemoveProduct.Enabled = false;
            btnProceedDelivery.Enabled = false;
            tboxTerms.Enabled = false;
            tboxTotalDown.Enabled = false;
            tboxtotalRebate.Enabled = false;
            tboxGRSMonthly.Enabled = false;
            tboxNetMonthly.Enabled = false;
           
            
            //ifFromUpdateLCPButton
            if (updateLCPFromCollections == true)
            {

                this.product_DR_DetailsTableAdapter.FillByAcountNo(this.citiAppDatabaseDataSet.Product_DR_Details,accountNoFromCollections);
                tboxAccountNo.Enabled = false;
                tboxCustomerName.Text = name;
                tboxIDnumber.Text = IDNUMBER;
                btnProceedDelivery.Enabled = true;
                tboxAccountNo.Text = accountNoFromCollections;
                cboxAccountType.Text = AccountType;
                tboxSIDRNo.Text = SI_DR_NO;
                tboxSIDRNo.Enabled = false;
                tboxSalesman.Text = salesman;
                tboxSalesman.Enabled = false;
                tboxCIBy.Text = ci_BY;
                tboxCIBy.Enabled = false;

                btnSearch.Enabled = false;
                btnProceedDelivery.Text = "Update LCP";
              
                //collections
                tboxTotalLCP.Text =totalLCP;
                tboxTotalDown.Text = Payment;
                tboxTotalBalance.Text = Balance;
                tboxUDI.Text = UDI;
                tboxtotalRebate.Text = totalRebate;
                tboxPN.Text = pn;
                tboxGRSMonthly.Text = grsMonthly;
                tboxNetMonthly.Text = netMonthly;
                tboxTerms.Text = terms;
            }
            else
            {

                if (Global.process.addCustomerToReceipt == "2")
                {
                    tboxCustomerName.Text = Global.customerDetails.f_Name + " " + Global.customerDetails.l_Name;
                    tboxIDnumber.Text = Global.customerDetails.id_Number;

                    btnSearch.Visible = false;
                    tboxCustomerName.Enabled = false;
                    tboxIDnumber.Enabled = false;
                    metroDateTime1.Enabled = true;
                    tboxCIBy.Enabled = true;
                    tboxSalesman.Enabled = true;
                }

                if (Global.process.stepsFROMcustomer == "2")
                {
                    groupStep.Visible = true;
                    Global.process.stepsFROMcustomer = "";
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Global.process.SearchCustomerFromDR = "1";

            customerView cV = new customerView();
            DialogResult res = cV.ShowDialog();
            if (res == DialogResult.Yes)
            {
                tboxCustomerName.Text = Global.customerDetails.f_Name + " " + Global.customerDetails.l_Name;
                tboxIDnumber.Text = Global.customerDetails.id_Number;
                tboxCustomerName.Enabled = false;
                tboxIDnumber.Enabled = false;
                metroDateTime1.Enabled = true;
                tboxCIBy.Enabled = true;
                tboxSalesman.Enabled = true;
                
            }
        }

        private void cboxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboxAccountType.Text == "Delivery Receipt")
            {
                sidr = "DR";
            }

            else
            {
                sidr = "SI";
            }


            if (cboxAccountType.Text.Length > 1)
            {
                groupCustomerDetails.Enabled = true;
                tboxCIBy.Enabled = true;
                tboxSalesman.Enabled = true;
                metroDateTime1.Enabled = true;
                panel1.Enabled = true;

            }
            else
            {
                groupCustomerDetails.Enabled = false;
                tboxCIBy.Enabled = false;
                tboxSalesman.Enabled = false;
                metroDateTime1.Enabled = false;
                panel1.Enabled = false;
            }

            if ((cboxAccountType.Text == "Charge Sales Invoice" || cboxAccountType.Text == "Delivery Receipt") && gridDeliveryReceipt.Rows.Count.Equals(1))
            {
                btnAddProduct.Enabled = false;
           
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (updateLCPFromCollections == true)
            {
                collections coll = new collections();
                
                coll.ShowDialog();
                this.Close();
            }
            else
            {
                if (gridDeliveryReceipt.Rows.Count >= 1)
                {
                    DialogResult result = MessageBox.Show("Current transaction will be canceled, continue?", "Nontification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
                        citiAppDatabaseDataSetTableAdapters.productsTableAdapter prodAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
                        drDetailsAdapter.DeleteQueryByAccountNo(tboxAccountNo.Text);

                        int rowCount = gridDeliveryReceipt.Rows.Count;
                  
                        for (int i = 0; i < rowCount; i++)
                        {
                            if (gridDeliveryReceipt.Rows[i].Cells[8].Value.ToString() == "-")
                            {
                                prodAdapter.UpdateStatus("Available", gridDeliveryReceipt.Rows[i].Cells[1].Value.ToString());

                            }
                            else
                            {
                                prodAdapter.UpdateStatus("Free", gridDeliveryReceipt.Rows[i].Cells[1].Value.ToString());
                            }

                        }

                        drDetailsAdapter.DeleteQueryByAccountNo(accNo);
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

          
            Global.process.selectProdFromDR = "Add";
            Global.process.productAvailabilty = "Available";
            
 
            
            
            productsView pV = new productsView();
            pV.accNO = accNo;
            DialogResult res = pV.ShowDialog();

           
                if (res == DialogResult.Yes)
                {
                    this.product_DR_DetailsTableAdapter.FillByAcountNo(this.citiAppDatabaseDataSet.Product_DR_Details,accNo);
                    tboxAccountNo.Enabled = false;
                    btnProceedDelivery.Enabled = true;

                    if (gridDeliveryReceipt.Rows.Count > 0)
                    {
                        btnRemoveProduct.Enabled = true;
                    }
                    else
                    {
                        btnRemoveProduct.Enabled = false;
                    }

                    cboxAccountType.Enabled = false;
                }
        
        }

      

        private void tboxAccountNo_Leave(object sender, EventArgs e)
        {
         string acc_No = Global.process.branchID+tboxAccountNo.Text;
         accNo = acc_No;
         

        }

        private void tboxTotalDown_Leave(object sender, EventArgs e)
        {

            if (tboxAccountNo.Text.Length > 0)
            {
                

                citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
                drDetailsAdapter.UpdateAcountNumberDeliveryReceiptProcess(accNo, Global.process.drDetailsIDfromProductsView);
            }
            else
            { 
                
            }
        }

        private void gridDeliveryReceipt_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gridDeliveryReceipt_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //computations galing sa cell
            int x = gridDeliveryReceipt.Rows.Count;
            double container = 0.00;
            foreach (DataGridViewRow item in gridDeliveryReceipt.Rows)
            {
                int n = item.Index;

                container = container + double.Parse(gridDeliveryReceipt.Rows[n].Cells[6].Value.ToString());

            }

            tboxTotalLCP.Text = container.ToString();


            //pang enable ng mga tbacks
            if (cboxAccountType.Text == "Charge Sales Invoice" || cboxAccountType.Text == "Delivery Receipt")
            {
                tboxTerms.Enabled = true;
                tboxTotalDown.Enabled = true;
                tboxtotalRebate.Enabled = true;
                tboxGRSMonthly.Enabled = true;
                tboxNetMonthly.Enabled = true;
            }
            else
            {
                tboxTerms.Enabled = false;
                tboxTotalDown.Enabled = false;
                tboxtotalRebate.Enabled = false;
                tboxGRSMonthly.Enabled = false;
                tboxNetMonthly.Enabled = false;

            }
        }

        private void gridDeliveryReceipt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
            try
            {
                drDetailsAdapter.UpdateQueryQntyAndLCP(gridDeliveryReceipt.CurrentRow.Cells[5].Value.ToString(),
                    gridDeliveryReceipt.CurrentRow.Cells[6].Value.ToString(),
                    gridDeliveryReceipt.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.Source);
            }
        }

        private void tboxAccountNo_TextChanged(object sender, EventArgs e)
        {
            if (tboxAccountNo.Text.Length > 0 && cboxAccountType.Text == "Cash Sales Invoice")
            {
                btnAddProduct.Enabled = true;
               
            }
            else if (tboxAccountNo.Text.Length > 0 && cboxAccountType.Text == "Charge Sales Invoice")
            {
                if (gridDeliveryReceipt.Rows.Count >= 1)
                {
                    btnAddProduct.Enabled = false;
                  
                }
                else
                {
                    btnAddProduct.Enabled = true;
                   
                }
            }
            else if (tboxAccountNo.Text.Length > 0 && cboxAccountType.Text == "Delivery Receipt")
            {
                if (gridDeliveryReceipt.Rows.Count >= 1)
                {
                    btnAddProduct.Enabled = false;
                   
                }
                else
                {
                    btnAddProduct.Enabled = true;
                    
                }
                
            }
        }


        private void  calculationMethod()
        {
            try
            {
                double udi = 0.00;
                double pn = 0.00;
                double totalbalance = 0.00;
                double totalDown = 0.00;
                double netMonthly = 0.00;
                double monthlyRebate = 0.00;
                double totalRebate = 0.00;
                double grsMonthly = 0.00;

                netMonthly = Convert.ToDouble(tboxNetMonthly.Text);
                if (netMonthly <= 1500 && netMonthly >= 1)
                {
                    monthlyRebate = 20;
                }
                else if(netMonthly >= 1501 && netMonthly <= 3000)
                {
                    monthlyRebate = 40;
                }
                else if (netMonthly >= 3001)
                {
                    monthlyRebate = 60;
                }

                grsMonthly = netMonthly + monthlyRebate;
                tboxGRSMonthly.Text = grsMonthly.ToString();

                if (cboxAccountType.Text == "Cash Sales Invoice")
                {
                    totalDown = Convert.ToDouble(tboxTotalLCP.Text);
                }
                else
                {
                    totalDown = Convert.ToDouble(tboxTotalDown.Text);
                }
                totalbalance = Convert.ToDouble(tboxTotalLCP.Text) - totalDown;
                tboxTotalBalance.Text = totalbalance.ToString();

                udi = (Convert.ToDouble(tboxPN.Text) - Convert.ToDouble(tboxTotalBalance.Text)) - Convert.ToDouble(tboxtotalRebate.Text);
                if (udi < 0)
                {
                    tboxUDI.Text = "0.00";
                }
                else
                {
                    tboxUDI.Text = udi.ToString();
                }

               
                tboxMonthlyRebate.Text = monthlyRebate.ToString();

                totalRebate = Convert.ToDouble(tboxTerms.Text) * monthlyRebate;
                tboxtotalRebate.Text = totalRebate.ToString();

                pn = Convert.ToDouble(tboxGRSMonthly.Text) * Convert.ToDouble(tboxTerms.Text);
                tboxPN.Text = pn.ToString();
            }
            catch (Exception)
            {
            }
            
        }

        private void tboxTotalDown_TextChanged(object sender, EventArgs e)
        {
            if (tboxTotalDown.Text.Length > 0)
            {
                calculationMethod();
            }
            else
            {
                tboxTotalDown.Text = ".00";
                calculationMethod();
            }
        }

        private void tboxRebate_TextChanged(object sender, EventArgs e)
        {
            if (tboxtotalRebate.Text.Length > 0)
            {
                calculationMethod();
            }
            else
            {
                tboxtotalRebate.Text = ".00";
                calculationMethod();
            }
        }

        private void tboxTerms_TextChanged(object sender, EventArgs e)
        {
            if (tboxTerms.Text.Length > 0)
            {
                if (Convert.ToInt32(tboxTerms.Text) > 0)
                {
                    calculationMethod();
                }
                else
                {
                    tboxTerms.Text = "1";
                    calculationMethod();
                    MessageBox.Show("Terms cannot be less than 1.");
                }
            }
            else
            {
                
                tboxTerms.Text = "";
                
            }

        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (tboxNetMonthly.Text.Length > 0)
            {
                calculationMethod();
            }
            else
            {
                tboxNetMonthly.Text = ".00";
                calculationMethod();
            }
        }

        private void tboxGRSMonthly_TextChanged(object sender, EventArgs e)
        {
            if (tboxGRSMonthly.Text.Length > 0)
            {
                calculationMethod();
            }
            else
            {
                tboxGRSMonthly.Text = ".00";
                calculationMethod();
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (gridDeliveryReceipt.Rows.Count > 0)
            {
                citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
                citiAppDatabaseDataSetTableAdapters.productsTableAdapter prodAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
                
               
              



                //update status ng product
                if (gridDeliveryReceipt.CurrentRow.Cells[8].Value.ToString() == "-")
                {

                    prodAdapter.UpdateStatus("Available", gridDeliveryReceipt.CurrentRow.Cells[1].Value.ToString());
                }
                else
                {
                    prodAdapter.UpdateStatus("Free", gridDeliveryReceipt.CurrentRow.Cells[1].Value.ToString());
                }



                if (gridDeliveryReceipt.Rows.Count == 0)
                {
                    btnRemoveProduct.Enabled = false;
                }
                else
                {
                    btnRemoveProduct.Enabled = true;
                }
                drDetailsAdapter.DeleteQueryByStockNo(gridDeliveryReceipt.CurrentRow.Cells[1].Value.ToString());
                this.product_DR_DetailsTableAdapter.FillByAcountNo(this.citiAppDatabaseDataSet.Product_DR_Details, Global.process.accountNo);
            }
          
            

        }

        private void btnProceedDelivery_Click(object sender, EventArgs e)
        {

            if (updateLCPFromCollections == true)
            {
                citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter cDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter();
                citiAppDatabaseDataSetTableAdapters.collectionTableAdapter cAdapter = new citiAppDatabaseDataSetTableAdapters.collectionTableAdapter();
                citiAppDatabaseDataSet.collection_detailsDataTable cDetailsTable = new citiAppDatabaseDataSet.collection_detailsDataTable();
                cDetailsTable = cDetailsAdapter.GetDataByCollectionID(collectionNoFromCollectionForm);
                int cdetailsRowCount = Convert.ToInt32(cDetailsTable.Rows.Count);

                double expectedBalance = Convert.ToDouble(tboxPN.Text);
              
                cAdapter.UpdateQueryEditLCP(tboxTotalLCP.Text,
                    tboxTotalDown.Text,
                    tboxTotalBalance.Text,
                    tboxUDI.Text,
                    tboxtotalRebate.Text,
                    tboxPN.Text,
                    tboxGRSMonthly.Text,
                    tboxNetMonthly.Text,
                    collectionNoFromCollectionForm);
                for (int i = 0; i <= cdetailsRowCount; i++)
                {

                    
                    cDetailsAdapter.UpdateQueryByNO_cID(expectedBalance.ToString(), i.ToString(), collectionNoFromCollectionForm);

                    expectedBalance = expectedBalance - Convert.ToDouble(tboxGRSMonthly.Text);

                    

                }

                MessageBox.Show("Update LCP Success", "Notification");
                collections c = new collections();
                c.ShowDialog();
                this.Close();
               

            }

            else
            {


                DialogResult result = MessageBox.Show("Proceed with this delivery Information?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    double totaldown = double.Parse(tboxTotalDown.Text);



                    if (totaldown > 0)
                    {

                        ProceedMethod();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Downpayment input");
                    }





                }
            }
        }

        private void ProceedMethod()
        {
            string status = "";
            if (cboxAccountType.Text == "Cash Sales Invoice")
            {
                status = "Paid";
            }
            else
            {
                status = "Pending";
            }


            citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
            citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter deliveryAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
            citiAppDatabaseDataSetTableAdapters.collectionTableAdapter collectionAdapter = new citiAppDatabaseDataSetTableAdapters.collectionTableAdapter();
            

            citiAppDatabaseDataSet.collectionDataTable collectionTable = collectionAdapter.GetData();




            //if (gridDeliveryReceipt.Rows.Count > 1)
            //{

                for (int i = 0; i < gridDeliveryReceipt.Rows.Count; i++)
                {

                    if (Convert.ToDouble(gridDeliveryReceipt.Rows[i].Cells[6].Value.ToString()) == 0)
                    {
                        drDetailsAdapter.UpdateQueryLCP_Desc_pStatus("0.00",
                           gridDeliveryReceipt.Rows[i].Cells[7].Value.ToString(),
                           gridDeliveryReceipt.Rows[i].Cells[8].Value.ToString(),
                           gridDeliveryReceipt.Rows[i].Cells[0].Value.ToString());

                        if (cboxAccountType.Text == "Cash Sales Invoice")
                        {
                            drDetailsAdapter.UpdateDownPaymentANDcash("-", tboxTotalDown.Text,"0.00", gridDeliveryReceipt.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            drDetailsAdapter.UpdateDownPaymentANDcash(tboxTotalDown.Text,"-",tboxTotalLCP.Text, gridDeliveryReceipt.Rows[i].Cells[0].Value.ToString());
                        }


                    }

                    else
                    {
                        drDetailsAdapter.UpdateQueryLCP_Desc_pStatus(tboxTotalDown.Text,
                            gridDeliveryReceipt.Rows[i].Cells[7].Value.ToString(),
                            gridDeliveryReceipt.Rows[i].Cells[8].Value.ToString(),
                            gridDeliveryReceipt.Rows[i].Cells[0].Value.ToString());

                        if (cboxAccountType.Text == "Cash Sales Invoice")
                        {
                            drDetailsAdapter.UpdateDownPaymentANDcash("0.00", tboxTotalDown.Text, "0.00", gridDeliveryReceipt.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            drDetailsAdapter.UpdateDownPaymentANDcash(tboxTotalDown.Text, "0.00", tboxTotalLCP.Text, gridDeliveryReceipt.Rows[i].Cells[0].Value.ToString());
                        }
                    }
                }
            //}

            //else
            //{
            //    drDetailsAdapter.UpdateQueryLCP_Desc_pStatus(tboxTotalDown.Text,
            //        gridDeliveryReceipt.CurrentRow.Cells[7].Value.ToString(),
            //            gridDeliveryReceipt.CurrentRow.Cells[8].Value.ToString(),
            //        gridDeliveryReceipt.CurrentRow.Cells[0].Value.ToString());
            //}


            DateTime dt1;
            dt1 = DateTime.Parse(metroDateTime1.Text);


            int collectionID = collectionTable.Rows.Count + 1;
            
            deliveryAdapter.Insert(accNo,
                cboxAccountType.Text,
               sidr + tboxSIDRNo.Text,//SI_DR_NO
                tboxSalesman.Text,
                tboxCIBy.Text,
                tboxIDnumber.Text,
                collectionID.ToString("0000") + "-" + Global.process.branchID,
                status,
                dt1.Date,Global.process.branchID);
            
            collectionAdapter.Insert(collectionID.ToString("0000") + "-" + Global.process.branchID,
                tboxTotalLCP.Text,
                tboxTotalDown.Text,
                tboxTotalBalance.Text,
                tboxUDI.Text,
                tboxtotalRebate.Text,
                tboxPN.Text,
                tboxGRSMonthly.Text,
                tboxNetMonthly.Text,
                System.DateTime.Today,
                "",
                "",
                "",
                status,
                tboxTerms.Text, "", "",
                tboxMonthlyRebate.Text);


            //CollectionDetails Entry

            citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter cDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter();
            citiAppDatabaseDataSet.collection_detailsDataTable cDetailsTable = cDetailsAdapter.GetData();

            double count = 1;
            int NO = 1;
            int cdetailsID = cDetailsTable.Rows.Count;
            double expectedBalance = Convert.ToDouble(tboxPN.Text);

           
            for (int i = 0; i < Convert.ToInt32(tboxTerms.Text); i++)
            {

                double daysToAdd = 30;
                double incrementedDays = daysToAdd * count;
                
                

                count = count + 1;
                cdetailsID = cdetailsID + 1;
                cDetailsAdapter.Insert(cdetailsID.ToString("0000") + "-" + Global.process.branchID,
                    null,
                    NO.ToString(),
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    collectionID.ToString("0000") + "-" + Global.process.branchID,
                    expectedBalance.ToString(),
                    "",
                    "",
                    gridDeliveryReceipt.Rows[0].Cells[1].Value.ToString(),
                    System.DateTime.Today.Date, DateTime.Today.AddDays(incrementedDays).Date,
                    "",
                    "");

                
              
                expectedBalance = expectedBalance - Convert.ToDouble(tboxGRSMonthly.Text);
                NO = NO + 1;

            }



            //update Status ng product kung COD
            int rowCount = gridDeliveryReceipt.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {

                citiAppDatabaseDataSetTableAdapters.productsTableAdapter prodAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
                prodAdapter.UpdateStatus("Sold", gridDeliveryReceipt.Rows[i].Cells[1].Value.ToString());
            }


            DialogResult result1 = MessageBox.Show("Create another new delivery?","Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                deliveryReceipt dr = new deliveryReceipt();
                dr.ShowDialog();
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void tboxTotalLCP_TextChanged(object sender, EventArgs e)
        {

            if (updateLCPFromCollections == true)
            {
                calculationMethod();
            }
            else
            {
                if (cboxAccountType.Text == "Cash Sales Invoice")
                {
                    tboxTotalDown.Enabled = false;
                    tboxTotalDown.Text = tboxTotalLCP.Text;

                    tboxTerms.Enabled = false;
                    tboxTerms.Text = "1";

                    tboxtotalRebate.Enabled = false;
                    tboxGRSMonthly.Enabled = false;
                    tboxNetMonthly.Enabled = false;
                }
            }
        }

        private void tboxTotalDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxTotalDown.Text.IndexOf('.') != -1)
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
            if (ch == 46 && tboxtotalRebate.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tboxGRSMonthly_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && tboxGRSMonthly.Text.IndexOf('.') != -1)
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

        private void groupOptions_Enter(object sender, EventArgs e)
        {

        }
     
    }
}
