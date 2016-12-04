using citiAppSystem.Modules.Models.Enums;
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
    public partial class ModalAmount : Form
    {
        public Action<string,string> Amount { get; set; }

        private TransactionType currentMode;
        public ModalAmount(TransactionType drMode,string ORNUM,string AMOUNT)
        {
            InitializeComponent();
            currentMode = drMode;
            checkMode();
            populateEntries(ORNUM, AMOUNT);
        }

        private void checkMode()
        {
            if(currentMode == TransactionType.Installment)
            {
                label1.Visible = true;
                tBoxOR.Visible = true;
            }
        }

        private void populateEntries(string ornum,string amount)
        {
            tBoxOR.Text = ornum;
            numAmount.Value = decimal.Parse(amount);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
                commitAmount();
        }

        private void commitAmount()
        {
            if (currentMode == TransactionType.Installment)
            {
                if (MessageBox.Show("Commit entries?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Amount(tBoxOR.Text, numAmount.Value.ToString());
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Current transaction type is Installment, OR Number is required.");
                }
            }
            else
            {
                Amount(tBoxOR.Text, numAmount.Value.ToString());
                this.Close();
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                commitAmount();
            }
            base.OnKeyPress(e);
        }

        private void ModalAmount_Load(object sender, EventArgs e)
        {

        }
    }
}
