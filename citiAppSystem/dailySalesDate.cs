using citiAppSystem.Modules.Reports;
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
    public partial class dailySalesDate : MetroForm
    {
        public dailySalesDate()
        {
            InitializeComponent();
        }

        private void dailySalesDate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);
            if (Global.process.branchID == "02")
            {

                labelBranch.Visible = true;
                cBoxBranch.Visible = true;
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dailySalesREPORT dsR = new dailySalesREPORT();
            DailySales ds = new DailySales();

            ds.startDate = dateTimePickerStart.Text;
            ds.endDate = dateTimePickerEnd.Text;
            dsR.startDate = dateTimePickerStart.Text;
            dsR.endDate = dateTimePickerEnd.Text;
            if (Global.process.branchID == "02")
            {
                dsR.branchID = cBoxBranch.SelectedValue.ToString();
                ds.branchID = cBoxBranch.SelectedValue.ToString();
            }
            else
            {
                dsR.branchID = Global.process.branchID;
                ds.branchID = Global.process.branchID;
            }
            ds.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
