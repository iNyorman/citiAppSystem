using citiAppSystem.Modules.Models.EF;
using citiAppSystem.Modules.Models.EF.Services;
using citiAppSystem.Modules.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citiAppSystem.Modules.Views.Cashiers
{
    public partial class frmAccountLedgerView : Form
    {


        private string accountNo;
        List<DR_details> drDetailsList;
        List<collection_details> cDetailsList;
        public frmAccountLedgerView(string _accountNo)
        {
            InitializeComponent();
            drDetailsList = new List<DR_details>();
            cDetailsList = new List<collection_details>();
            accountNo = _accountNo;
            tBoxAccountNo.Text = accountNo;
            this.Shown+= frmAccountLedger_Shown;
        }

        void frmAccountLedger_Shown(object sender, EventArgs e)
        {
            populateDrDetails();
            populateCollectionDetails();
        }
        private void populateDrDetails()
        {
            drDetailsList = CitiAppDbServices.Services().DR_Details().GetDrDetailsByAccountNo(accountNo);
            dRdetailsBindingSource.DataSource = drDetailsList;
        }

        private void populateCollectionDetails()
        {
            cDetailsList = CitiAppDbServices.Services().collectionDetails().ListByAccountNo(accountNo);
            int rowsToAdd = 25 - cDetailsList.Count;
            cDetailsList = cDetailsList.OrderBy(x => x.id).ToList();
            for (int x = 0; x < rowsToAdd; x++ )
            {
                cDetailsList.Add(new collection_details());
            }
            collectiondetailsBindingSource.DataSource = cDetailsList;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmLedgerReportView report = new frmLedgerReportView(tBoxAccountNo.Text, drDetailsList, cDetailsList);
            report.TopMost = true;
            report.ShowDialog();
        }

      
    }
}
