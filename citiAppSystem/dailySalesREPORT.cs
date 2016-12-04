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
    public partial class dailySalesREPORT : Form
    {
        public dailySalesREPORT()
        {
            InitializeComponent();
        }

        public string startDate = "";
        public string endDate = "";
        public string branchID = "";

        private void dailySalesREPORT_Load(object sender, EventArgs e)
        {
            try
            {              
                cryDailySales dailySalesReport = new cryDailySales();
                citiAppDatabaseDataSetTableAdapters.DailySalesTableAdapter dailySalesAdapter = new citiAppDatabaseDataSetTableAdapters.DailySalesTableAdapter();
                DataTable dt;
                dt = ServiceLocator.Instance().DailySalesServices().GetDailySales(Convert.ToDateTime(startDate).Date.ToShortDateString(), Convert.ToDateTime(endDate).Date.ToShortDateString(), branchID);
                var test = dt.AsEnumerable().ToList();
                dailySalesReport.SetDataSource(dt);
                crystalReportViewer1.ReportSource = dailySalesReport;
            }
            catch (Exception)
            {
               
            }
 
        }
    }
}
