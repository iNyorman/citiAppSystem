using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using citiAppSystem.Modules.Datasets;
namespace citiAppSystem.Modules.Reports
{
    public partial class DailySales : Form
    {

        public string startDate = "";
        public string endDate = "";
        public string branchID = "";
        public DailySales()
        {
            InitializeComponent();
        }

        private void DailySales_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dailySalesDatasets.DailySales' table. You can move, or remove it, as needed.
            //this.dailySalesTableAdapter.Fill(this.dailySalesDatasets.DailySales);
            try
            {
                citiAppDatabaseDataSetTableAdapters.DailySalesTableAdapter dailySalesAdapter = new citiAppDatabaseDataSetTableAdapters.DailySalesTableAdapter();
                DataTable dt;
                
                List<ReportParameter> paramList = new List<ReportParameter>();
                dt = ServiceLocator.Instance().DailySalesServices().GetDailySales(Convert.ToDateTime(startDate).Date.ToShortDateString(), Convert.ToDateTime(endDate).Date.ToShortDateString(), branchID);

                paramList.Add(new ReportParameter("grandTotalCash", dt.AsEnumerable().Sum(x => Convert.ToDecimal(x.Field<string>("cash"))).ToString()));
                paramList.Add(new ReportParameter("grandTotalLCP", dt.AsEnumerable().Sum(x => Convert.ToDecimal(x.Field<string>("LCP"))).ToString()));
                paramList.Add(new ReportParameter("grandTotalDown", dt.AsEnumerable().Sum(x => Convert.ToDecimal(x.Field<string>("down_payment"))).ToString()));
                paramList.Add(new ReportParameter("grandTotalAF", dt.AsEnumerable().Sum(x => Convert.ToDecimal(x.Field<string>("BalanceAF"))).ToString()));
                paramList.Add(new ReportParameter("grandTotalPN", dt.AsEnumerable().Sum(x => Convert.ToDecimal(x.Field<string>("Expr1"))).ToString()));
                dailySalesDatasetsBindingSource.DataSource = dt;
                this.reportViewer1.LocalReport.SetParameters(paramList);
                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = ZoomMode.Percent;
                this.reportViewer1.ZoomPercent = 100;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

            }
        }
    }
}
