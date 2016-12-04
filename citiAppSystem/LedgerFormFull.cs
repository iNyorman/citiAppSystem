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
    public partial class LedgerFormFull : Form
    {
        public LedgerFormFull()
        {
            InitializeComponent();
        }

        public string AccountNo = "";
        public string process = "";

        private void LedgerFormFull_Load(object sender, EventArgs e)
        {
            try
            {



                citiAppDatabaseDataSetTableAdapters.ledgerTableTableAdapter l= new citiAppDatabaseDataSetTableAdapters.ledgerTableTableAdapter();
                citiAppDatabaseDataSetTableAdapters.collectionLedgerTableTableAdapter c = new citiAppDatabaseDataSetTableAdapters.collectionLedgerTableTableAdapter();
                citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter  drAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
                citiAppDatabaseDataSetTableAdapters.NewSelectCommandDR_REPORTBYACCOUNTTableAdapter dr = new citiAppDatabaseDataSetTableAdapters.NewSelectCommandDR_REPORTBYACCOUNTTableAdapter();

                 
                if (process == "ledger")
                {

                    LedgerReport lReport = new LedgerReport();
                    cryLedger cL = new cryLedger();
                    drDetailsReport drReport = new drDetailsReport();

                    DataTable dt;
                    DataTable dt2;

                    dt = l.GetDataByLedgerReportAccountNo(AccountNo);
                    dt2 = drAdapter.GetDataByForLedgerReport(AccountNo);
                    Reports.Rows.addRows(dt);
                    lReport.SetDataSource(dt);
                    cL.SetDataSource(dt);
                    cL.Subreports[0].SetDataSource(dt2);
                    lReport.Subreports[0].SetDataSource(dt2);
                    crystalReportViewer1.ReportSource = lReport;
                }
                else
                {

                    LedgerCardReport lReport = new LedgerCardReport();
                    cryLedger cL = new cryLedger();
                    drDetailsReport drReport = new drDetailsReport();

                    DataTable dt;
                    DataTable dt2;

                    dt = l.GetDataByLedgerReportAccountNo(AccountNo);
                    dt2 = drAdapter.GetDataByForLedgerReport(AccountNo);

                    var lsit = dt2.AsEnumerable().ToList();
                    Reports.Rows.addRows12(dt);

                    lReport.SetDataSource(dt);
                     cL.SetDataSource(dt);
                    cL.Subreports[0].SetDataSource(dt2);
                    lReport.Subreports[0].SetDataSource(dt2);


                    crystalReportViewer1.ReportSource = lReport;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);

            }
        }
    }
}
