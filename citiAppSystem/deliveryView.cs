using citiAppSystem.Modules.Views.DR;
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
    public partial class deliveryView : MetroForm
    {


       

        public deliveryView()
        {
            InitializeComponent();
        }

        private void deliveryView_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.DeliveryView_Table' table. You can move, or remove it, as needed.

            if(Global.process.branchID == "02")
            {
                this.deliveryView_TableTableAdapter.FillBySelectAllBranches(this.citiAppDatabaseDataSet.DeliveryView_Table);
            }
            else
            {
                this.deliveryView_TableTableAdapter.Fill(this.citiAppDatabaseDataSet.DeliveryView_Table, Global.process.branchID);
            }
          

            if (gridDR.Rows.Count == 0)
            {
                btnViewDetails.Visible = false;
            }

            if (Global.process.role == "Accounting")
            {
                btnUpdateDelivery.Enabled = false;
        
            }


            
            
            //btnUpdate.Enabled = false;
          
            tboxSearch.Visible = false;
            metroDateStart.Visible = false;
            metroDateEnd.Visible = false;
            labelSearch.Visible = false;
            labelStart.Visible = false;
            labelEnd.Visible = false;



        }

        private void btnNewDelivery_Click(object sender, EventArgs e)
        {
            //Global.process.addCustomerToReceipt= "1";
            //updateDelivery dr = new updateDelivery();
            //DialogResult res = dr.ShowDialog();

            frmDrViewModal ndr = new frmDrViewModal();
            DialogResult res = ndr.ShowDialog();
            if (res == DialogResult.Yes)
            {
                this.deliveryView_TableTableAdapter.Fill(this.citiAppDatabaseDataSet.DeliveryView_Table,Global.process.branchID);
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Global.process.role = "";
            this.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

         
            try
            {
                Global.drReceipt.acountNo = gridDR.CurrentRow.Cells[0].Value.ToString();
                Global.drReceipt.customerID = gridDR.CurrentRow.Cells[1].Value.ToString();
                Global.drReceipt.collectionNo = gridDR.CurrentRow.Cells[2].Value.ToString();
                Global.process.accountType = gridDR.CurrentRow.Cells[6].Value.ToString();
                collections coll = new collections();
                coll.accountType = gridDR.CurrentRow.Cells[6].Value.ToString();
                DialogResult res = coll.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    this.deliveryView_TableTableAdapter.Fill(this.citiAppDatabaseDataSet.DeliveryView_Table,Global.process.branchID);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);
            }

           
            

        }

        private void gridDR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (Global.process.role == "Sales")
            //{
            //    btnUpdate.Enabled = false;
            //}
            //else
            //{
            //    btnUpdate.Enabled = true;
            //}
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            if (cboxSearchBy.Text == "AccountNo")
            {
                if(Global.process.branchID == "02")
                {
                    this.deliveryView_TableTableAdapter.FillByAB_AccountNo(this.citiAppDatabaseDataSet.DeliveryView_Table, tboxSearch.Text);
                }
                else
                {
                    this.deliveryView_TableTableAdapter.FillByAccountNo(this.citiAppDatabaseDataSet.DeliveryView_Table, tboxSearch.Text, Global.process.branchID);
                }
              
            }
            else if (cboxSearchBy.Text == "Account Type")
            {   

                if(Global.process.branchID == "02")
                {
                    this.deliveryView_TableTableAdapter.FillByAB_AccType(this.citiAppDatabaseDataSet.DeliveryView_Table, tboxSearch.Text);
                }
                else
                {
                    this.deliveryView_TableTableAdapter.FillByAccountType(this.citiAppDatabaseDataSet.DeliveryView_Table, tboxSearch.Text, Global.process.branchID);
                }
                
            }
            //else if (cboxSearchBy.Text == "Status")
            //{
            //    this.deliveryView_TableTableAdapter.FillByStatus(this.citiAppDatabaseDataSet.DeliveryView_Table, tboxSearch.Text);
            //}
            else if (cboxSearchBy.Text == "Name")
            {
                if(Global.process.branchID == "02")
                {
                    this.deliveryView_TableTableAdapter.FillByAB_Name(this.citiAppDatabaseDataSet.DeliveryView_Table, tboxSearch.Text,tboxSearch.Text, tboxSearch.Text);
                }
                else
                {
                    this.deliveryView_TableTableAdapter.FillByName(this.citiAppDatabaseDataSet.DeliveryView_Table, Global.process.branchID, tboxSearch.Text, tboxSearch.Text, tboxSearch.Text);
                }
               
            }

        }

        private void cboxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSearchBy.Text == "Date")
            {
                cboxStatus.Visible = false;
                tboxSearch.Visible = false;
                metroDateStart.Visible = true;
                metroDateEnd.Visible = true;
                labelSearch.Visible = false;
                labelStart.Visible = true;
                labelEnd.Visible = true;
            }
            else if (cboxSearchBy.Text == "Status")
            {
                cboxStatus.Visible = true;
                tboxSearch.Visible = false;
                metroDateStart.Visible = false;
                metroDateEnd.Visible = false;
                labelSearch.Visible = false;
                labelStart.Visible = false;
                labelEnd.Visible = false;
            }
            else
            {
                cboxStatus.Visible = false;
                tboxSearch.Visible = true;
                metroDateStart.Visible = false;
                metroDateEnd.Visible = false;
                labelSearch.Visible = true;
                labelStart.Visible = false;
                labelEnd.Visible = false;
            }
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            if (cboxSearchBy.Text == "Date")
            {
                DateTime dt1;
                dt1 = DateTime.Parse(metroDateStart.Text);

                string date;
                date = dt1.ToShortDateString();

            }
        }

        private void metroDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (metroDateStart.MinDate > metroDateEnd.MinDate)
            {
                MessageBox.Show("Start date is greater than End Date.");
            }

            else
            {
                if(Global.process.branchID == "02")
                {
                    this.deliveryView_TableTableAdapter.FillByAB_DATERANGE(this.citiAppDatabaseDataSet.DeliveryView_Table, metroDateStart.Text, metroDateEnd.Text);
                }
                else
                {
                    this.deliveryView_TableTableAdapter.FillByDateRange(this.citiAppDatabaseDataSet.DeliveryView_Table, metroDateStart.Text, metroDateEnd.Text, Global.process.branchID);
                }
               
            }
        }

        private void cboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Global.process.branchID == "02")
            {

            }
            else
            {
                this.deliveryView_TableTableAdapter.FillByStatus(this.citiAppDatabaseDataSet.DeliveryView_Table, cboxStatus.Text, Global.process.branchID);
            }
           
        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void gridDR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (Global.process.role == "Accounting")
            {

      
                Customer.AccountNo =  gridDR.CurrentRow.Cells[0].Value.ToString();
                Customer.l_name = gridDR.CurrentRow.Cells[3].Value.ToString();
                Customer.m_name = gridDR.CurrentRow.Cells[4].Value.ToString();
                Customer.f_name = gridDR.CurrentRow.Cells[5].Value.ToString();

                Global.process.role = "";
                this.DialogResult = DialogResult.Yes;

            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Global.process.role = "Accounting";
            updateDeliveryCollections udc = new updateDeliveryCollections();
            if (gridDR.CurrentRow.Cells[0].Value.ToString() != "")
            {
                udc.acctNo = gridDR.CurrentRow.Cells[0].Value.ToString();
                udc.ShowDialog();
            }
          
        }
    }
}
