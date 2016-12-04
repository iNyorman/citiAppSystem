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

namespace citiAppSystem.Modules.Views.Cashiers
{
    public partial class frmAccountLedgerView : Form
    {

        private string accountNo;
        public frmAccountLedgerView(string _accountNo)
        {
            InitializeComponent();
            accountNo = _accountNo;
        }

        private void populateDrDetails()
        {
            
        }
    }
}
