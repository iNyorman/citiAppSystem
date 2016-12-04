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
    public partial class ArrivalReport : Form
    {
        public ArrivalReport()
        {
            InitializeComponent();
        }

        public string deliveryNo = "";

        private void ArrivalReport_Load(object sender, EventArgs e)
        {

            SArrivalReport report = new SArrivalReport();
            citiAppDatabaseDataSetTableAdapters.StocksArrivalTableTableAdapter sAAdapter = new citiAppDatabaseDataSetTableAdapters.StocksArrivalTableTableAdapter();
            DataTable dt;
            dt = sAAdapter.GetDataBydeliveryNo(deliveryNo);
            report.SetDataSource(dt);
            crystalReportViewer1.ReportSource= report;

            

        }
    }
}
