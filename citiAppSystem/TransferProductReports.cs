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
    public partial class TransferProductReports : Form
    {
        public TransferProductReports()
        {
            InitializeComponent();
        }
        public string st_ID = "";

        private void TransferProductReports_Load(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.TransferProductJoinedDTTableAdapter tfPAdapter = new citiAppDatabaseDataSetTableAdapters.TransferProductJoinedDTTableAdapter();

            try
            {
                transferReport tReport = new transferReport();


                DataTable dt;
                dt = tfPAdapter.GetDataByST_ID(st_ID);

                tReport.SetDataSource(dt);
                crystalReportViewer1.ReportSource = tReport;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
            

        }
    }
}
