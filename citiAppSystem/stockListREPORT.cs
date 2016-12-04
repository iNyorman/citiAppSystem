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

  
    public partial class stockListREPORT : Form
    {

        public string branchNo = "";
        public stockListREPORT()
        {
            InitializeComponent();
        }

        private void stockListREPORT_Load(object sender, EventArgs e)
        {
            try
            {


                cryStocklist stockListReport = new cryStocklist();
                citiAppDatabaseDataSetTableAdapters.stockListReportTableAdapter slrAdapter = new citiAppDatabaseDataSetTableAdapters.stockListReportTableAdapter();
                DataTable dt;

              

                dt = slrAdapter.GetDataByBranch(branchNo);
                stockListReport.SetDataSource(dt);
                crystalReportViewer1.ReportSource = stockListReport;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ":" + ex.Message);
            }
        }
    }
}
