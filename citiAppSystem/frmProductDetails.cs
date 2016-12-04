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
    public partial class frmProductDetails : Form
    {
        string currentAccountNo;
        newCitiAppDatasetTableAdapters.productDetailsViewTableAdapter pdvAdapter;
        newCitiAppDataset.productDetailsViewDataTable pdvTable;
        newCitiAppDataset.productDetailsViewRow pdvRow;
        public frmProductDetails(string accountNo)
        {
            InitializeComponent();
            currentAccountNo = accountNo;
            pdvAdapter = new newCitiAppDatasetTableAdapters.productDetailsViewTableAdapter();
            pdvTable = new newCitiAppDataset.productDetailsViewDataTable();
            fetchData();
        }

        private void fetchData()
        {
            pdvAdapter.FillByAccountNo(pdvTable, currentAccountNo);
            pdvRow = pdvAdapter.GetDataByAccountNo(currentAccountNo).FirstOrDefault();
            lblAccountNo.Text = pdvRow.AccountNo.ToString();
            lblName.Text = pdvRow.fullName;
            lblType.Text = pdvRow.Account_Type.ToString();
            lblBranch.Text = pdvRow.branchName;
            lblBAddress.Text = pdvRow.bAddress;
            lblContact.Text = pdvRow.contact;
            lblEmployer.Text = pdvRow.employer;
            lblEmpAddress.Text = pdvRow.employerAddress;
            lblCoMaker.Text = pdvRow.co_Maker;
            lblCoMakerAddress.Text = pdvRow.co_MakerAddress;
        }
    }
}
 