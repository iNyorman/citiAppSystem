using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class customerListReport : Form
    {
        public string queryBy = "";
        public string parameterValue = "";

        public customerListReport()
        {
            InitializeComponent();
        }

        private void customerListReport_Load(object sender, EventArgs e)
        {
           

            citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter customerAdapter = new citiAppDatabaseDataSetTableAdapters.customerTableTableAdapter();
            DataTable dt = new DataTable();
            CustomerReports cReport = new CustomerReports();

            if (queryBy == "@idNo")
            {
                
              
                dt = customerAdapter.ReportsGetDataByCustomerID(parameterValue);
                cReport.SetDataSource(dt);
                crystalReportViewer1.ReportSource = cReport;


            }

            else if (queryBy == "@employer")
            {
               
                dt = customerAdapter.GetDataByEmployer(parameterValue);
                cReport.SetDataSource(dt);
                crystalReportViewer1.ReportSource = cReport;
            }
            
        }
    }
}
