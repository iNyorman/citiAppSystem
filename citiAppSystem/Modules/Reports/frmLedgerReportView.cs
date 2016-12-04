using citiAppSystem.Modules.Models.EF;
using citiAppSystem.Modules.Models.EF.Classes;
using citiAppSystem.Modules.Models.EF.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citiAppSystem.Modules.Reports
{
    public partial class frmLedgerReportView : Form
    {
        string AccountNo;
        List<DR_details> drDetailsList;
        List<collection_details> cDetailsList;
        public frmLedgerReportView(string _accountNo,List<DR_details> drdetails, List<collection_details> cDetails)
        {
            InitializeComponent();
            AccountNo = _accountNo;
            drDetailsList = drdetails;
            cDetailsList = cDetails;
            populateBindings();
        }

        private void frmLedgerReportView_Load(object sender, EventArgs e)
        {
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }

        private void populateBindings()
        {
            var dr = CitiAppDbServices.Services().deliveryReceipt().DrByAcount(AccountNo);
            var collection = CitiAppDbServices.Services().Collection().CollectionByAccountNo(AccountNo);
            var customer = CitiAppDbServices.Services().customer().CustomerByIdNumber(dr.ID_Number);
            LedgerHeaderModelBindingSource.DataSource = new LedgerHeaderModel(dr, collection, customer);
            DR_detailsBindingSource.DataSource = drDetailsList.Where(x=>!string.IsNullOrEmpty(x.stockNo)).ToList();
            collection_detailsBindingSource.DataSource = cDetailsList;
        }
    }
}
