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
    public partial class dailyCollectionREPORTS : Form
    {
        public dailyCollectionREPORTS()
        {
            InitializeComponent();
        }

        public string startDate = "";
        public string endDate = "";

        private void dailyCollectionREPORTS_Load(object sender, EventArgs e)
        {
                cryDailyCollections dailyCollectionsReport = new cryDailyCollections();
                citiAppDatabaseDataSetTableAdapters.DailyCollectionReportTableTableAdapter dailyCollectionAdapter = new citiAppDatabaseDataSetTableAdapters.DailyCollectionReportTableTableAdapter();
                DataTable dt;

                dt = dailyCollectionAdapter.GetDataByDate(Convert.ToDateTime(startDate).Date.ToShortDateString(), Convert.ToDateTime(endDate).Date.ToShortDateString());
                dailyCollectionsReport.SetDataSource(dt);
                crystalReportViewer1.ReportSource = dailyCollectionsReport;

        }
    }
}
