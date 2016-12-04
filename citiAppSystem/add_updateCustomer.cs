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

namespace citiAppSystem.CustomerForms
{
    public partial class add_updateCustomer : MetroForm
    {
        public Boolean fromForm1 = false;
        public string fromCC = "";
        public string idNumber = "";
        public string lastName = "";
        public string firstName = "";
        public string middleName = "";
        public add_updateCustomer()
        {
            InitializeComponent();
        }

        private void add_updateCustomer_Load(object sender, EventArgs e)
        {
            if (Global.process.CustomerclickFrom == "Add")
            {
                tboxLastName.Text = "-";
                tboxMName.Text = "-";
                tboxFName.Text = "-";
                tboxEmployer.Text = "-";
                tboxContact.Text = "-";
                tboxCoMaker.Text = "-";
                tboxAddress.Text = "-";
                tboxCoMakerAddress.Text = "-";
                tboxCivilStatus.Text = "-";
                tboxEmployerAddress.Text = "-";


                btnUpdate_Save.Text = "Next";
            }

            else
            {

                btnUpdate_Save.Text = "Update";
                btnClear.Visible = false;

                tboxLastName.Text = Global.customerDetails.l_Name;
                tboxMName.Text = Global.customerDetails.m_Name;
                tboxFName.Text = Global.customerDetails.f_Name;
                tboxEmployer.Text = Global.customerDetails.employer;
                tboxContact.Text = Global.customerDetails.contact;
                tboxCoMaker.Text = Global.customerDetails.co_Maker;
                tboxAddress.Text = Global.customerDetails.address;
                tboxCoMakerAddress.Text = Global.customerDetails.co_maker_address;
                tboxCivilStatus.Text = Global.customerDetails.civilStatus;
                tboxEmployerAddress.Text = Global.customerDetails.employerAddress;

            }

            if (Global.process.stepsFROMcustomer == "1")
            {
                groupSteps.Visible = true;
                Global.process.stepsFROMcustomer = "2";
            }
        }

        private void btnUpdate_Save_Click(object sender, EventArgs e)
        {
            if (Global.process.CustomerclickFrom == "Add")
            {
                
                citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter customerAdapter = new citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter();
                citiAppDatabaseDataSet.customerTableDataTable customerTable = customerAdapter.GetData();
                int counter = customerTable.Rows.Count + 1;
                string idNum = "CUS-" + counter.ToString("0000") + "-"+  Global.process.branchID;
                DialogResult result = MessageBox.Show("Proceed with this Customer details?","Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (tboxFName.Text.Length > 0 && tboxLastName.Text.Length > 0 && tboxEmployer.Text.Length > 0 && tboxCoMaker.Text.Length > 0)
                {
                    if (result == DialogResult.Yes)
                    {

                        string fullname = tboxLastName.Text + "," + tboxFName.Text + " "+ tboxMName.Text;
                        customerAdapter.Insert(idNum,
                            tboxLastName.Text,
                            tboxMName.Text,
                            tboxFName.Text,
                            tboxEmployer.Text,
                            tboxContact.Text,
                            tboxCoMaker.Text,
                            tboxAddress.Text,
                            tboxCoMakerAddress.Text,
                            tboxCivilStatus.Text,tboxEmployerAddress.Text,
                            fullname);

                        //Proceed to DR

                        idNumber = idNum;
                        lastName = tboxLastName.Text;
                        firstName = tboxFName.Text;
                        middleName = tboxMName.Text;

                        Global.customerDetails.id_Number = idNum;
                        Global.customerDetails.l_Name = tboxLastName.Text;
                        Global.customerDetails.m_Name = tboxMName.Text;
                        Global.customerDetails.f_Name = tboxFName.Text;
                        Global.customerDetails.employer = tboxEmployer.Text;
                        Global.customerDetails.contact = tboxContact.Text;
                        Global.customerDetails.co_Maker = tboxCoMaker.Text;
                        Global.customerDetails.address = tboxAddress.Text;
                        Global.customerDetails.co_maker_address = tboxCoMakerAddress.Text;
                        Global.customerDetails.employerAddress = tboxEmployerAddress.Text;
                        this.DialogResult = DialogResult.Yes;

           
                        //Global.process.addCustomerToReceipt = "2";

                        //deliveryReceipt dR = new deliveryReceipt();

                        //if (fromForm1 == true)
                        //{
                        //    this.Hide();
                        //    dR.ShowDialog();

                        //}
                        //else
                        //{
                        //    this.DialogResult = DialogResult.Yes;
                        //}


                    }
                }
                else
                {
                    MessageBox.Show("Please fill up important fields.");
                }
               
               
            }
            else if (Global.process.CustomerclickFrom == "Update")
            {
                DialogResult result = MessageBox.Show("Update current Customer Information?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter customerAdapter = new citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter();
                    customerAdapter.UpdateQuery(Global.customerDetails.id_Number,
                        tboxLastName.Text,
                        tboxMName.Text,
                        tboxFName.Text,
                        tboxEmployer.Text,
                        tboxContact.Text,
                        tboxCoMaker.Text,
                        tboxAddress.Text,
                        tboxCoMakerAddress.Text,
                        tboxCivilStatus.Text,tboxEmployerAddress.Text,
                        Global.customerDetails.id_Number                     
                        );
                        MessageBox.Show("Update Complete");
                }
            
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (fromCC == "y")
            {
                fromCC = "n";
                this.Close();


            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}
