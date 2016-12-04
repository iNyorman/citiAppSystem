using citiAppSystem.Modules.Modals;
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
    public partial class updateDeliveryCollections : MetroForm
    {

        public string acctNo;
        public string orNumber;
        Form1 mainForm;
        public updateDeliveryCollections()
        {
            InitializeComponent();
            mainForm = Application.OpenForms["Form1"] as Form1;
        }

        private void updateDeliveryCollections_Load(object sender, EventArgs e)
        {
            
     
            tboxAcctNo.Text = acctNo;

            if (Global.process.role == "Accounting")
            {
                metroLabel25.Visible = false;
                cboxORnumber.Visible = false;
                btnAdd.Visible = false;
                btnSave.Visible = false;
               
            }

            try
            {
                // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.DR_details' table. You can move, or remove it, as needed.
                this.dR_detailsTableAdapter.FillByAccountNO(this.citiAppDatabaseDataSet.DR_details, acctNo);


                // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.collection_details' table. You can move, or remove it, as needed.
                this.collection_detailsTableAdapter.FillByCollectionID(this.citiAppDatabaseDataSet.collection_details, acctNo);

                this.c_TransTableTableAdapter.FillByStatusPending(this.citiAppDatabaseDataSet.c_TransTable);

                cboxORnumber.Text = orNumber;
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Source + ": " + EX.Message);
            }
          
        
        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                    string checker = "";
                    citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter ctransAdapter = new citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter();

                    DialogResult res = MessageBox.Show("Would you like to use this OR in downpayment?", "Notification", MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {

                        for (int x = 0; x < gridDetails.Rows.Count; x++)
                        {
                            if (gridDetails.Rows[x].Cells[5].Value.ToString() == cboxORnumber.Text)
                            {
                                checker = "true";
                                MessageBox.Show("OR number is in use.");
                                break;
                            }
                            else
                            {
                                checker = "false";
                            }
                        }

                        if (checker == "false")
                        {

                            citiAppDatabaseDataSet.c_TransTableRow ctransRow = (citiAppDatabaseDataSet.c_TransTableRow)ctransAdapter.GetDataByORnumber(cboxORnumber.Text).Rows[0];
                            for (int xxx = 0; xxx < gridDetails.Rows.Count; xxx++)
                            {
                                if (gridDetails.Rows[xxx].Cells[6].Value.ToString() == "")
                                {
                                    gridDetails.Rows[xxx].Cells[6].Value = ctransRow.OR_NUM.ToString();
                                    gridDetails.Rows[xxx].Cells[7].Value = ctransRow.NET_AMT.ToString();
                                    gridDetails.Rows[xxx].Cells[8].Value = ctransRow.pay_Type.ToString();

                                    break;
                                }
                                else if (gridDetails.Rows[xxx].Cells[6].Value.ToString() == cboxORnumber.Text)
                                {
                                    MessageBox.Show("OR number is in used.");
                                    break;
                                }
                            }
                        }
                    }
         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ":" + ex.Message);
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter ctransAdapter = new citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter();
            citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter cDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter();
            citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();

            DialogResult res = MessageBox.Show("Save this collections?", "Notification", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                //for(int xxx=0;xxx<gridCollectionDetails.Rows.Count;xxx++)
                //{
                //    cDetailsAdapter.UpdateQueryNew(gridCollectionDetails.Rows[xxx].Cells[2].Value.ToString(),
                //        gridCollectionDetails.Rows[xxx].Cells[3].Value.ToString(),
                //        gridCollectionDetails.Rows[xxx].Cells[4].Value.ToString(),
                //        gridCollectionDetails.Rows[xxx].Cells[5].Value.ToString(),
                //        gridCollectionDetails.Rows[xxx].Cells[6].Value.ToString(),
                //        gridCollectionDetails.Rows[xxx].Cells[7].Value.ToString(),
                //        gridCollectionDetails.Rows[xxx].Cells[8].Value.ToString(),
                //        gridCollectionDetails.Rows[xxx].Cells[9].Value.ToString(),
                //        gridCollectionDetails.Rows[xxx].Cells[10].Value.ToString(),
                //        gridCollectionDetails.Rows[xxx].Cells[0].Value.ToString());


                //}

                for (int x = 0; x < gridDetails.Rows.Count; x++)
                {
                    drDetailsAdapter.UpdateQueryCtrans(gridDetails.Rows[x].Cells[6].Value.ToString(),
                        gridDetails.Rows[x].Cells[7].Value.ToString(),
                        gridDetails.Rows[x].Cells[8].Value.ToString(),
                        gridDetails.Rows[x].Cells[0].Value.ToString());
                }

                for (int xx = 0; xx < gridDetails.Rows.Count; xx++)
                {
                    if (gridDetails.Rows[xx].Cells[6].Value.ToString() == "")
                    {
                        break;
                    }
                    else
                    {
                        citiAppDatabaseDataSet.c_TransTableDataTable cTransDT = ctransAdapter.GetDataByORnumber(gridDetails.Rows[xx].Cells[6].Value.ToString());
                        if (cTransDT.Rows.Count.Equals(1))
                        {
                            ctransAdapter.UpdateQueryStatus("done", gridDetails.Rows[xx].Cells[6].Value.ToString());
                        }
                    }
                }
            }

            MessageBox.Show("Account successfully updated.");
        }

        private void btnPrintLedger_Click(object sender, EventArgs e)
        {
            LedgerFormFull LFF = new LedgerFormFull();
            LFF.AccountNo = tboxAcctNo.Text;
            LFF.process = "ledger";
            LFF.ShowDialog();
        }

        private void btnLedgerCard_Click(object sender, EventArgs e)
        {
            LedgerFormFull LFF = new LedgerFormFull();
            LFF.AccountNo = tboxAcctNo.Text;
            LFF.process = "ledgerCard";
            LFF.ShowDialog();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            addOr();
        }

        private void addOr()
        {
            ModalAddOR_AMNT modal = new ModalAddOR_AMNT(tboxAcctNo.Text, mainForm.CurrentBranchNo);
            modal.IsSaved += (result) => {
                if (result == true)
                {
                    this.dR_detailsTableAdapter.FillByAccountNO(this.citiAppDatabaseDataSet.DR_details, acctNo);
                }
            };
            modal.ShowDialog();
        }

        
    }
}
