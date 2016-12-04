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
    public partial class CompanyProfile : MetroForm
    {
        public CompanyProfile()
        {
            InitializeComponent();
        }

        private void CompanyProfile_Load(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.companyProfileTableAdapter companyAdapter = new citiAppDatabaseDataSetTableAdapters.companyProfileTableAdapter();
            citiAppDatabaseDataSet.companyProfileDataTable cpbranchIDdt = companyAdapter.GetDataByBranchID(Global.process.branchID);
            if (cpbranchIDdt.Rows.Count.Equals(1))
            {
                citiAppDatabaseDataSet.companyProfileRow compRow = (citiAppDatabaseDataSet.companyProfileRow)companyAdapter.GetDataByBranchID(Global.process.branchID).Rows[0];
                tboxCedulaNo.Text = compRow.cedula_no.ToString();
                tboxName.Text = compRow.cedula_name.ToString();
                tboxPlace.Text = compRow.place_issued.ToString();
                dateTimePicker1.Text = compRow.cedula_dateissued.ToShortDateString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                citiAppDatabaseDataSetTableAdapters.companyProfileTableAdapter companyAdapter = new citiAppDatabaseDataSetTableAdapters.companyProfileTableAdapter();
                citiAppDatabaseDataSet.companyProfileDataTable cpbranchIDdt = companyAdapter.GetDataByBranchID(Global.process.branchID);
                citiAppDatabaseDataSet.companyProfileDataTable compIDDT = companyAdapter.GetData();

                DialogResult result = MessageBox.Show("Would you like to save data?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cpbranchIDdt.Rows.Count.Equals(0))
                    {
                        int compID = compIDDT.Rows.Count + 1;
                        companyAdapter.Insert(compID.ToString("0000000") + Global.process.branchID, tboxName.Text, tboxCedulaNo.Text, DateTime.Parse(dateTimePicker1.Text), tboxPlace.Text, Global.process.branchID);
                    }
                    else
                    {
                        companyAdapter.UpdateQueryBranchID(tboxName.Text, tboxCedulaNo.Text, dateTimePicker1.Text, tboxPlace.Text, Global.process.branchID);
                    }
                }

                MessageBox.Show("Data has been saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source+":"+ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
