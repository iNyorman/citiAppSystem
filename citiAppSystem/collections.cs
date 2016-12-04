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
    public partial class collections : MetroForm
    {

        public collections()
        {

            
            InitializeComponent();
        }
        public string accountType = "";
       
        private void collections_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.collection_details' table. You can move, or remove it, as needed.
            this.collection_detailsTableAdapter.Fill(this.citiAppDatabaseDataSet.collection_details);
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.collectionProductsView' table. You can move, or remove it, as needed.
            this.collectionProductsViewTableAdapter.Fill(this.citiAppDatabaseDataSet.collectionProductsView);
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet1.OF_Table' table. You can move, or remove it, as needed.
            this.oF_TableTableAdapter.Fill(this.citiAppDatabaseDataSet1.OF_Table);
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.OF_Table' table. You can move, or remove it, as needed.
            this.oF_TableTableAdapter.FillByCollectionID(this.citiAppDatabaseDataSet.OF_Table,Global.drReceipt.collectionNo);
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.collectionProductsView' table. You can move, or remove it, as needed.
           // this.collectionProductsViewTableAdapter.Fill(this.citiAppDatabaseDataSet.collectionProductsView);
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.collection_details' table. You can move, or remove it, as needed.
            this.collection_detailsTableAdapter.FillByCollectionID(this.citiAppDatabaseDataSet.collection_details,Global.drReceipt.collectionNo);
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.collectionProductsView' table. You can move, or remove it, as needed.
            this.collectionProductsViewTableAdapter.FillByAccountNo(this.citiAppDatabaseDataSet.collectionProductsView,Global.drReceipt.acountNo);
           
            //para sa mga textboxes
            citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter customerAdapter = new citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter();
            citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
            citiAppDatabaseDataSetTableAdapters.collectionTableAdapter collectionAdapter = new citiAppDatabaseDataSetTableAdapters.collectionTableAdapter();
           
            citiAppDatabaseDataSet.customerTableRow customerRow = (citiAppDatabaseDataSet.customerTableRow)customerAdapter.GetDataBySearchByID_Num(Global.drReceipt.customerID).Rows[0];
            citiAppDatabaseDataSet.deliveryReceiptRow drRow = (citiAppDatabaseDataSet.deliveryReceiptRow)drAdapter.GetDataByAccountNo(Global.drReceipt.acountNo).Rows[0];
            citiAppDatabaseDataSet.collectionRow cRow = (citiAppDatabaseDataSet.collectionRow)collectionAdapter.GetDataByCollectionID(Global.drReceipt.collectionNo).Rows[0];
            tboxAccountNo.Text = Global.drReceipt.acountNo;
            tboxCustomerName.Text = customerRow.last_Name + "," + customerRow.f_Name + " " + customerRow.mid_Name;
            tboxAddress.Text = customerRow.address;
            tboxEmployer.Text = customerRow.employer;
            tboxCoMaker.Text = customerRow.co_Maker;
            tboxCoMakerAddress.Text = customerRow.co_MakerAddress;
           
            tboxSIDRNumber.Text = drRow.SI_DR_no;
            tboxSalesman.Text = drRow.Salesman;
            tboxCIBy.Text = drRow.CI_By;
            tboxSIDRNumber.Text = drRow.SI_DR_no;

            tboxLCP.Text = cRow.Total_LCP;
            tboxTotalDown.Text = cRow.Payment;
            tboxBalance.Text = cRow.Balance;
            tboxUDI.Text = cRow.UDI;
            tboxTotalRebate.Text = cRow.Total_Rebate;
            tboxPN.Text = cRow.PN;
            tboxTErms.Text = cRow.terms;

            tboxGRSMonthly.Text = cRow.GRS_Monthly;
            tboxMonthlyRebate.Text = cRow.monthlyRebate;
            tboxNetMonthly.Text = cRow.Net_monthly;
            tboxDeliveryDate.Text = drRow.Delivery_Date.ToString();

            //disabler ng grid kung may laman.
            if (Global.process.accountType == "Cash Sales Invoice")
            {
                gridCollection.Enabled = false;
            }


         


  

        }

        private void gridPurchasedOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int rowCountPurchaseOrder = gridPurchasedOrder.Rows.Count;
            int rowCountCollection = gridCollection.Rows.Count;
            DateTime collectionDate;
           
            
            for (int i = 0; i < rowCountPurchaseOrder; i++)
            {

                citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
                drDetailsAdapter.UpdateRemarksDownPaymentTypeORNoPayment(gridPurchasedOrder.Rows[i].Cells[6].Value.ToString(),
                    gridPurchasedOrder.Rows[i].Cells[7].Value.ToString(),
                    gridPurchasedOrder.Rows[i].Cells[8].Value.ToString(),
                    gridPurchasedOrder.Rows[i].Cells[9].Value.ToString());

            }

            //update para sa collection Details
            string paymentCash ,paymentCheque ;
            for (int i = 0; i < rowCountCollection; i++)
            {
                if (gridCollection.Rows[i].Cells[12].Value.ToString() == "Cash")
                {
                    paymentCash = gridCollection.Rows[i].Cells[4].Value.ToString();
                    paymentCheque = "0.00";
                }
                else
                {
                    paymentCash = "0.00";
                    paymentCheque = gridCollection.Rows[i].Cells[4].Value.ToString();
                }

                citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter collDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter();

                if (gridCollection.Rows[i].Cells[2].Value.ToString() == "")
                {
                    collectionDate = Convert.ToDateTime(null);
                }
                else
                {
                    collectionDate = Convert.ToDateTime(gridCollection.Rows[i].Cells[2].Value.ToString());
                }

                //update collectionDetails              
                collDetailsAdapter.UpdateQueryCollectionDetailsPayment(collectionDate.ToShortDateString() /*Convert.ToDateTime(gridCollection.Rows[i].Cells[2].Value.ToString()).ToShortDateString()*/,
                gridCollection.Rows[i].Cells[13].Value.ToString(),
                gridCollection.Rows[i].Cells[12].Value.ToString(),
                gridCollection.Rows[i].Cells[8].Value.ToString(),
                gridCollection.Rows[i].Cells[9].Value.ToString(),
                gridCollection.Rows[i].Cells[6].Value.ToString(),
                gridCollection.Rows[i].Cells[4].Value.ToString(),
                gridCollection.Rows[i].Cells[3].Value.ToString(),
                paymentCash,
                paymentCheque,
                gridCollection.Rows[i].Cells[0].Value.ToString());
            }





            citiAppDatabaseDataSetTableAdapters.OF_TableTableAdapter ofAdapter = new citiAppDatabaseDataSetTableAdapters.OF_TableTableAdapter();
            citiAppDatabaseDataSet.OF_TableDataTable oFeeTable = ofAdapter.GetData();
            
            int gridRow = gridOtherFees.Rows.Count - 1;
            int OFID = oFeeTable.Rows.Count+1;
            string OFpaymentCash,OFpaymentCheque;
            for (int i = 0; i < gridRow; i++)
            {
                citiAppDatabaseDataSet.OF_TableDataTable ofDtable = ofAdapter.GetDataByORNumber(gridOtherFees.Rows[i].Cells[2].Value.ToString());
                if (ofDtable.Rows.Count.Equals(0))
                {
                    if (gridOtherFees.Rows[i].Cells[4].Value.ToString() == "Cash")
                    {
                        OFpaymentCash = gridOtherFees.Rows[i].Cells[3].Value.ToString();
                        OFpaymentCheque = "0.00";
                    }
                    else
                    {
                        OFpaymentCheque = gridOtherFees.Rows[i].Cells[3].Value.ToString();
                        OFpaymentCash = "0.00";
                    }

                        //OFID = OFID + 1;
                        //ofAdapter.Insert(OFID.ToString("0000") + "-" + Global.process.branchID,
                        //    gridOtherFees.Rows[i].Cells[1].Value.ToString(),
                        //    gridOtherFees.Rows[i].Cells[2].Value.ToString(),
                        //    gridOtherFees.Rows[i].Cells[5].Value.ToString(),
                        //    Global.drReceipt.collectionNo,
                        //    gridOtherFees.Rows[i].Cells[3].Value.ToString(),
                        //    gridOtherFees.Rows[i].Cells[4].Value.ToString(),
                        //    OFpaymentCash,
                        //    OFpaymentCheque);
                  
                }


            }


            //if (Convert.ToDouble(gridPurchasedOrder.CurrentRow.Cells[5].Value.ToString()) > Convert.ToDouble(gridPurchasedOrder.CurrentRow.Cells[6].Value.ToString()) && gridPurchasedOrder.CurrentRow.Cells[7].Value.ToString().Length > 1 && gridPurchasedOrder.CurrentRow.Cells[8].Value.ToString().Length > 1 || gridPurchasedOrder.CurrentRow.Cells[9].Value.ToString().Length > 1)
            //{
            //    double downPayment = 0.00;
            //    double nDownPayment = 0.00;
            //    double payment = 0.00;

            //    payment = Convert.ToDouble(gridPurchasedOrder.CurrentRow.Cells[6].Value.ToString());
            //    downPayment = Convert.ToDouble(gridPurchasedOrder.CurrentRow.Cells[5].Value.ToString());
            //    nDownPayment = downPayment - payment;
            //    citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
            //    citiAppDatabaseDataSet.DR_detailsDataTable count = drAdapter.GetData();
            //    int drDetailsID = count.Rows.Count + 1;

            //    if (downPayment > payment)
            //    {
            //        drAdapter.Insert(drDetailsID.ToString("0000"), "0.00", gridPurchasedOrder.Rows[0].Cells[1].Value.ToString(), gridPurchasedOrder.Rows[0].Cells[0].Value.ToString(), "1", "", nDownPayment.ToString(), "", "", "", "");
            //    }
            //    this.collectionProductsViewTableAdapter.FillByAccountNo(this.citiAppDatabaseDataSet.collectionProductsView, Global.drReceipt.acountNo);
            //}
   
            MessageBox.Show("Successfully Updated.");

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


        //manually created
        private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                citiAppDatabaseDataSetTableAdapters.collectionProductsViewTableAdapter cpViewAdapter = new citiAppDatabaseDataSetTableAdapters.collectionProductsViewTableAdapter();
                citiAppDatabaseDataSet.collectionProductsViewDataTable cpTAble = cpViewAdapter.GetDataByORNumber(gridPurchasedOrder.CurrentRow.Cells[7].Value.ToString());
                if (cpTAble.Rows.Count.Equals(1))
                {



                    if (e.ClickedItem.ToString() == "Cashiers Receipt")
                    {


                        ReceiptReport rr = new ReceiptReport();
                        rr.ReceiptType = "CR";
                        rr.parameter = gridPurchasedOrder.CurrentRow.Cells[7].Value.ToString();
                        rr.accountType = accountType;
                        rr.ShowDialog();
                    }

                    else if (e.ClickedItem.ToString() == "Collectors Receipt")
                    {
                        ReceiptReport rr = new ReceiptReport();
                        rr.ReceiptType = "COLR";
                        rr.parameter = gridPurchasedOrder.CurrentRow.Cells[7].Value.ToString();
                        rr.accountType = accountType;
                        rr.ShowDialog();

                    }


                }

                else
                {
                    MessageBox.Show("This transaction has not yet been save.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
        }


        private void m1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if (e.ClickedItem.ToString() == "Cashiers Receipt")
            { 
                
                
            }

            else if (e.ClickedItem.ToString() == "Collector's Receipt")
            { 
            
            
            }
            
        }







        private void btnPrintLedger_Click(object sender, EventArgs e)
        {
           
            string basis = tboxSIDRNumber.Text.Substring(0,2);




            LedgerFormFull LFF = new LedgerFormFull();
            //frm.arrayCenter.Add(tboxAccountNo);
            LFF.AccountNo = tboxAccountNo.Text;

            LFF.ShowDialog();
                    
        }



        private void btnUpdateLCP_Click(object sender, EventArgs e)
        {
            //deliveryReceipt dr = new deliveryReceipt();
            //dr.updateLCPFromCollections = true;

            //dr.accountNoFromCollections = tboxAccountNo.Text;
            //dr.name = tboxCustomerName.Text;
            //dr.IDNUMBER = "-";
            //dr.AccountType = Global.process.accountType;
            //dr.SI_DR_NO = tboxSIDRNumber.Text;
            //dr.salesman = tboxSalesman.Text;
            //dr.ci_BY = tboxCIBy.Text;
         

            //dr.collectionNoFromCollectionForm = Global.drReceipt.collectionNo;
            //dr.totalLCP = tboxLCP.Text;
            //dr.Payment = tboxTotalDown.Text;
            //dr.Balance = tboxBalance.Text;
            //dr.UDI = tboxUDI.Text;
            //dr.totalRebate = tboxTotalRebate.Text;
            //dr.pn = tboxPN.Text;
            //dr.grsMonthly = tboxGRSMonthly.Text;
            //dr.netMonthly = tboxNetMonthly.Text;
            //dr.terms = tboxTErms.Text;

          
            //dr.ShowDialog();
            //this.Close();
            


        }

        private void gridPurchasedOrder_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenuStrip m = new ContextMenuStrip();
                m.Items.Add("Cashiers Receipt");
                m.Items.Add("Collectors Receipt");
                m.Show(gridPurchasedOrder, new Point(e.X, e.Y));
                m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);

            }
        }

        private void gridCollection_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                m.Items.Add("Cashiers Receipt");
                m.Items.Add("Collector's Receipt");
                m.Show(gridCollection, new Point(e.X, e.Y));
                m.ItemClicked += new ToolStripItemClickedEventHandler(m1_ItemClicked);
            }
        }

        private void gridOtherFees_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.OF_TableTableAdapter ofAdapter = new citiAppDatabaseDataSetTableAdapters.OF_TableTableAdapter();
            citiAppDatabaseDataSet.OF_TableDataTable oFeeTable = ofAdapter.GetData();

            int OFID = oFeeTable.Rows.Count + 1;
            for (int i = 0; i < gridOtherFees.Rows.Count; i++)
            {
                OFID = OFID + 1;
                e.Row.Cells[0].Value = OFID.ToString("0000");
                e.Row.Cells[1].Value = "-na-";
                e.Row.Cells[2].Value = "-na-";
                e.Row.Cells[3].Value = "-na-";
                e.Row.Cells[5].Value = "-na-";
            }
        }

        private void gridOtherFees_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                if (e.Button == MouseButtons.Right)
                {
                    ContextMenuStrip m = new ContextMenuStrip();
                    m.Items.Add("Print Other Fees");

                    m.Show(gridOtherFees, new Point(e.X, e.Y));
                    m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
                }
            }
            catch (Exception)
            {

            }
        }

        private void gridCollection_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void gridCollection_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(2))
            {
                var cell = gridCollection.CurrentCell;
                var cellDisplayRect = gridCollection.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                toolTip1.Show(string.Format("Date format is M/D/YYYY", e.ColumnIndex, e.RowIndex),
                              gridCollection,
                              cellDisplayRect.X + cell.Size.Width / 2,
                              cellDisplayRect.Y + cell.Size.Height / 2,
                              2000);
                gridCollection.ShowCellToolTips = false;
            }
        }
    }
}
