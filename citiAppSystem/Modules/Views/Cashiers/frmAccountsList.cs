using citiAppSystem.Modules.Models;
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
    public partial class frmAccountsList : Form
    {

        List<DeliveryReceipt> drList;
        public frmAccountsList()
        {
            InitializeComponent();
            drList = new List<DeliveryReceipt>();
            drList = ServiceLocator.Instance().DRServices().AccountList();
        }

        private void frmAccountsList_Load(object sender, EventArgs e)
        {
            populateAccountList();
        }

        private void populateAccountList()
        {

            List<DeliveryReceipt> list = new List<DeliveryReceipt>();
            if (!string.IsNullOrEmpty(tBoxAccountNo.Text) || !string.IsNullOrEmpty(tBoxName.Text))
            {
                if (tBoxName.Focused == true)
                {
                    list = drList.Where(x => x.fullName.ToLower().Contains(tBoxName.Text.ToLower())).ToList();

                }
                if (tBoxAccountNo.Focused == true)
                {
                    list = drList.Where(x => x.AccountNo.ToLower().Contains(tBoxAccountNo.Text.ToLower())).ToList();
                    
                }
            }
            else
            {
                list = drList;
            }
          
            if(dtDeliveryDate.Checked == true)
            {
                list = drList.Where(x => x.Delivery_Date.Equals(dtDeliveryDate.Value)).ToList();
            }

            deliveryReceiptBindingSource.DataSource = list;

        }
        private void tBoxAccountNo_TextChanged(object sender, EventArgs e)
        {

                populateAccountList();
            
        }

        private void tBoxName_TextChanged(object sender, EventArgs e)
        {
       

                populateAccountList();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            viewDetails();
        }

        private void viewDetails()
        {
            
            var accountRow = dGridAccountList.CurrentRow.DataBoundItem as DeliveryReceipt;
            if(accountRow.DRtype.Equals("DR"))
            {
                //LedgerFormFull lf = new LedgerFormFull();
                //lf.AccountNo = accountRow.AccountNo;
                //lf.TopMost = true;
                //lf.ShowDialog();
                frmAccountLedgerView ledgerView = new frmAccountLedgerView(accountRow.AccountNo);
                ledgerView.TopMost = true;
                ledgerView.ShowDialog();
            }
        }

    }
}
