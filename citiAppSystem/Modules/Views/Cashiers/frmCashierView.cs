using citiAppSystem.Modules.Models.Enums.Cashier;
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
    public partial class frmCashierView : Form
    {
        public frmCashierView()
        {
            InitializeComponent();
        }

        private void frmCashierView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);
            populateTransactionType();
            populatePaymentType();
        }

        private void populateTransactionType()
        {
            List<object> objList = new List<object>();
            foreach(TransactionType obj in Enum.GetValues(typeof(TransactionType)))
            {
                objList.Add(new { Id = obj, Name = obj.ToText() });
            }
            cboxTransactionType.DataSource = objList.ToList();
            cboxTransactionType.DisplayMember = "Name";
            cboxTransactionType.ValueMember = "Id";
        }

        private void populatePaymentType()
        {
            List<object> objList = new List<object>();
            foreach (PaymentType obj in Enum.GetValues(typeof(PaymentType)))
            {
                objList.Add(new { Id = obj, Name = obj.ToText() });
            }
            cboxPayType.DataSource = objList.ToList();
            cboxPayType.DisplayMember = "Name";
            cboxPayType.ValueMember = "Id";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
