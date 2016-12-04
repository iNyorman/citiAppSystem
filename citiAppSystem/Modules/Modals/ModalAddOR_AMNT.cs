using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citiAppSystem.Modules.Modals
{
    public partial class ModalAddOR_AMNT : Form
    {
        string AccountNo;
        string BranchNo;
        public Action<bool> IsSaved { get; set; }
        public ModalAddOR_AMNT(string accountNo,string branchNo)
        {
            InitializeComponent();
            AccountNo = accountNo;
            BranchNo = branchNo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save this transaction?","System",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IsSaved(addOrAmnt());
                this.Close();
            }
        }

        private bool addOrAmnt()
        {
            try
            {
                citiAppSystem.Modules.Datasets.DeliveryReceiptDatasetsTableAdapters.DR_detailsTableAdapter drDetails = new Datasets.DeliveryReceiptDatasetsTableAdapters.DR_detailsTableAdapter();
                var c = drDetails.GetData().LastOrDefault().id;
                c = c + 1;
                drDetails.Insert(c.ToString("00000") + "-" + BranchNo,
                                    "0",
                                    "",
                                    AccountNo,
                                    "",
                                    "",
                                    "0",
                                    tBoxOr.Text,
                                    tBoxPaymentType.Text,
                                    "",
                                    "0",
                                    "0",
                                    numericAmount.Value.ToString(),
                                    "",
                                    "",
                                    "",
                                    "0",
                                    "0",
                                    "");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
