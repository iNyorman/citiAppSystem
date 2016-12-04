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
    public partial class customerView : MetroForm
    {
        public customerView()
        {
            InitializeComponent();
        }

        private void customerView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.customerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.citiAppDatabaseDataSet.customerTable);
            if (Global.process.SearchCustomerFromDR == "1")
            {
                btnUpdate.Visible = false;
                btnNew.Visible = false;
                btnDelete.Visible = false;
                metroButton1.Visible = false;
            }
            btnUpdate.Enabled = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Global.process.SearchCustomerFromDR == "1")
            {
                this.DialogResult = DialogResult.No;
            }
            else
            {
                this.Close();
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Global.process.CustomerclickFrom = "Add";
            CustomerForms.add_updateCustomer aUCustomer = new CustomerForms.add_updateCustomer();
            DialogResult res = aUCustomer.ShowDialog();
            if (res == DialogResult.Yes)
            {
                this.customerTableTableAdapter.Fill(this.citiAppDatabaseDataSet.customerTable);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

           
                Global.process.CustomerclickFrom = "Update";
                CustomerForms.add_updateCustomer aUCustomer = new CustomerForms.add_updateCustomer();
                DialogResult res = aUCustomer.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    
                    this.customerTableTableAdapter.Fill(this.citiAppDatabaseDataSet.customerTable);
                    btnUpdate.Enabled = false;


                }
            
          
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           tboxSearch.Text = "";
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {

            if (tboxSearch.Text.Length > 0)
            {
                if (cboxSearchBy.Text == "ID_Number")
                {
                    this.customerTableTableAdapter.FillByLIKEIDno(this.citiAppDatabaseDataSet.customerTable, tboxSearch.Text);
                }
                else if (cboxSearchBy.Text == "Name")
                {
                    this.customerTableTableAdapter.FillBySearchByName(this.citiAppDatabaseDataSet.customerTable, "%" + tboxSearch.Text + "%",
                        "%" + tboxSearch.Text + "%",
                        "%" + tboxSearch.Text + "%");
                }

                else if (cboxSearchBy.Text == "Employer")
                {
                    this.customerTableTableAdapter.FillBySearchByEmployer(this.citiAppDatabaseDataSet.customerTable, "%" + tboxSearch.Text + "%");
                }
                else
                {
                    this.customerTableTableAdapter.Fill(this.citiAppDatabaseDataSet.customerTable);
                }
            }
            else
            {
                this.customerTableTableAdapter.Fill(this.citiAppDatabaseDataSet.customerTable);
            }
        }

        private void gridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;


            if (Global.process.SearchCustomerFromDR == "1")
            {
                Global.customerDetails.id_Number = gridCustomer.CurrentRow.Cells[0].Value.ToString();
                Global.customerDetails.l_Name = gridCustomer.CurrentRow.Cells[1].Value.ToString();
                Global.customerDetails.m_Name = gridCustomer.CurrentRow.Cells[2].Value.ToString();
                Global.customerDetails.f_Name = gridCustomer.CurrentRow.Cells[3].Value.ToString();
                Global.customerDetails.employer = gridCustomer.CurrentRow.Cells[5].Value.ToString();
                Global.customerDetails.contact = gridCustomer.CurrentRow.Cells[6].Value.ToString();
                Global.customerDetails.co_Maker = gridCustomer.CurrentRow.Cells[7].Value.ToString();
                Global.customerDetails.address = gridCustomer.CurrentRow.Cells[4].Value.ToString();
                Global.customerDetails.co_maker_address = gridCustomer.CurrentRow.Cells[8].Value.ToString();
                Global.customerDetails.civilStatus = gridCustomer.CurrentRow.Cells[9].Value.ToString();
                Global.customerDetails.employerAddress = gridCustomer.CurrentRow.Cells[10].Value.ToString();

                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                Global.customerDetails.id_Number = gridCustomer.CurrentRow.Cells[0].Value.ToString();
                Global.customerDetails.l_Name = gridCustomer.CurrentRow.Cells[1].Value.ToString();
                Global.customerDetails.m_Name = gridCustomer.CurrentRow.Cells[2].Value.ToString();
                Global.customerDetails.f_Name = gridCustomer.CurrentRow.Cells[3].Value.ToString();
                Global.customerDetails.employer = gridCustomer.CurrentRow.Cells[5].Value.ToString();
                Global.customerDetails.contact = gridCustomer.CurrentRow.Cells[6].Value.ToString();
                Global.customerDetails.co_Maker = gridCustomer.CurrentRow.Cells[7].Value.ToString();
                Global.customerDetails.address = gridCustomer.CurrentRow.Cells[4].Value.ToString();
                Global.customerDetails.co_maker_address = gridCustomer.CurrentRow.Cells[8].Value.ToString();
                Global.customerDetails.civilStatus = gridCustomer.CurrentRow.Cells[9].Value.ToString();
                Global.customerDetails.employerAddress = gridCustomer.CurrentRow.Cells[10].Value.ToString();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                customerListReport clr = new customerListReport();
                if (cboxSearchBy.Text == "ID_Number")
                {
                    clr.queryBy = "@idNo";

                }


                else if (cboxSearchBy.Text == "Employer")
                {

                    clr.queryBy = "@employer";
                }

                clr.parameterValue = "%" + tboxSearch.Text + "%";
                clr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ":" + ex.Message);
            }
        }
    }
}
