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
    public partial class updateAcctNo : MetroForm
    {
        public updateAcctNo()
        {
            InitializeComponent();
        }

        private void updateAcctNo_Load(object sender, EventArgs e)
        {

        }

        private void tboxOldAcctNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
            citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter cusAdapter = new citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter();
            citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter cTransAdapter = new citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter();


                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            if (radioAcctNo.Checked == true)
                            {
                                citiAppDatabaseDataSet.deliveryReceiptDataTable drDt = drAdapter.GetDataByAccountNo(tboxOldAcctNo.Text);
                                //display sa customer info
                                if (drDt.Rows.Count.Equals(1))
                                {
                                    citiAppDatabaseDataSet.deliveryReceiptRow drRow = (citiAppDatabaseDataSet.deliveryReceiptRow)drAdapter.GetDataByAccountNo(tboxOldAcctNo.Text).Rows[0];

                                    string customerID = drRow.ID_Number.ToString();

                                    citiAppDatabaseDataSet.customerTableRow cusRow = (citiAppDatabaseDataSet.customerTableRow)cusAdapter.GetDataBySearchByID_Num(customerID).Rows[0];

                                    tboxName.Text = cusRow.last_Name.ToString() + ", " + cusRow.f_Name.ToString() + " " + cusRow.mid_Name.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Account number.");
                                }
                            }
                            else if (radioButton2.Checked == true)
                            {
                                citiAppDatabaseDataSet.c_TransTableDataTable cTransDT = cTransAdapter.GetDataByORnumber(tboxOldAcctNo.Text);
                                if (cTransDT.Rows.Count.Equals(1))
                                {
                                    citiAppDatabaseDataSet.c_TransTableRow cTransRow = (citiAppDatabaseDataSet.c_TransTableRow)cTransAdapter.GetDataByORnumber(tboxOldAcctNo.Text).Rows[0];

                                    tboxOldAcctNo.Text = cTransRow.AccountNo.ToString();

                                    citiAppDatabaseDataSet.deliveryReceiptRow drRow = (citiAppDatabaseDataSet.deliveryReceiptRow)drAdapter.GetDataByAccountNo(tboxOldAcctNo.Text).Rows[0];

                                    string customerID = drRow.ID_Number.ToString();

                                    citiAppDatabaseDataSet.customerTableRow cusRow = (citiAppDatabaseDataSet.customerTableRow)cusAdapter.GetDataBySearchByID_Num(customerID).Rows[0];

                                    tboxName.Text = cusRow.last_Name.ToString() + ", " + cusRow.f_Name.ToString() + " " + cusRow.mid_Name.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid OR number");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select search by.");
                            }

                        }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
            citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter ctransAdapter = new citiAppDatabaseDataSetTableAdapters.c_TransTableTableAdapter();
            citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
            citiAppDatabaseDataSetTableAdapters.collectionTableAdapter collAdapter = new citiAppDatabaseDataSetTableAdapters.collectionTableAdapter();
            citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter cDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter();

            if (tboxOldAcctNo.Text != "" && tboxNew.Text != "")
            {
                DialogResult res = MessageBox.Show("Update Account Number?", "Notification", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {

                    citiAppDatabaseDataSet.deliveryReceiptDataTable drDt = drAdapter.GetDataByAccountNo(tboxOldAcctNo.Text);
                    if (drDt.Rows.Count.Equals(1))
                    {
                        drAdapter.UpdateAcctNo(tboxNew.Text,tboxNew.Text, tboxOldAcctNo.Text);
                    }

                    citiAppDatabaseDataSet.DR_detailsDataTable drDetailsDT = drDetailsAdapter.GetDataByAccountNO(tboxOldAcctNo.Text);
                    if (drDetailsDT.Rows.Count > 0)
                    {
                        drDetailsAdapter.UpdateAcctNo(tboxNew.Text, tboxOldAcctNo.Text);
                    }

                    citiAppDatabaseDataSet.c_TransTableDataTable ctransDT = ctransAdapter.GetDataByAccountNumberSearch(tboxOldAcctNo.Text);
                    if (ctransDT.Rows.Count > 0)
                    {
                        ctransAdapter.UpdateAcctNo(tboxNew.Text, tboxOldAcctNo.Text);
                    }

                    citiAppDatabaseDataSet.collectionDataTable collDT = collAdapter.GetDataByCollectionID(tboxOldAcctNo.Text);
                    if (collDT.Rows.Count > 0)
                    {
                        collAdapter.UpdateCollectionID(tboxNew.Text, tboxOldAcctNo.Text);
                    }

                    citiAppDatabaseDataSet.collection_detailsDataTable collDetailsDT = cDetailsAdapter.GetDataByCollectionID(tboxOldAcctNo.Text);
                    if (collDetailsDT.Rows.Count > 0)
                    {
                        cDetailsAdapter.UpdateCollectionID(tboxNew.Text, tboxOldAcctNo.Text);
                    }

                    MessageBox.Show("Account number successfully update");
                }
            }
            else
            {
                MessageBox.Show("Missing inputs.");
            }
        }
    }
}
