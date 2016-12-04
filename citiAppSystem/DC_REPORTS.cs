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
    public partial class DC_REPORTS : Form
    {
        public string branchNo = "";
        public DC_REPORTS()
        {
            
            InitializeComponent();
        }

        private void DC_REPORTS_Load(object sender, EventArgs e)
        {

            if (Global.process.branchID == "02")
            {

                label4.Visible = true;
                cBoxBranches.Visible = true;
                // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
                this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);

            }
            else
            {
                label4.Visible = false;
                cBoxBranches.Visible = false;
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newDailyCollections ndc = new newDailyCollections();
            citiAppDatabaseDataSetTableAdapters.daily_CollectionsTableTableAdapter ndcAdapter = new citiAppDatabaseDataSetTableAdapters.daily_CollectionsTableTableAdapter();

            DataTable dt;
            if(Global.process.branchID == "02")
            {
               branchNo = cBoxBranches.SelectedValue.ToString();
            }
            else
            {
                branchNo = Global.process.branchID;
            }


            string transType1 = "";
            string transType2 = "";
            if(rbtnCOD_MISC.Checked == true)
            {
                 transType1 = "COD";
                 transType2 = "MISC";
            }

            else if(rBtnDown_Install.Checked == true)
            {
                transType1 = "DOWN";
                 transType2 = "INSTALLMENT";
            }

            dt = ndcAdapter.GetDataByCollectionReports(branchNo, dtFrom.Text, dtTo.Text, transType1,transType2);
            ndc.SetDataSource(dt);
            crystalReportViewer1.ReportSource = ndc;
            crystalReportViewer1.Refresh();
        }
    }
}
