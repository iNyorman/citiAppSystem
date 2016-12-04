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

namespace citiAppSystem.Modules.Views.DelAccView
{
    public partial class frmDelAccView : Form
    {
        List<AccDel> AccountDeletedList;
        public frmDelAccView()
        {
            InitializeComponent();
            AccountDeletedList = new List<AccDel>();
            populateGrid();
        }

        public void populateGrid()
        {
            AccountDeletedList = ServiceLocator.Instance().AccDelTableService().DeletedAccountList();
            if(!string.IsNullOrEmpty(tBoxDeleteBy.Text))
            {
                AccountDeletedList = AccountDeletedList.Where(x => x.DelBy.ToUpper().Equals(tBoxDeleteBy.Text.ToUpper())).ToList();
            }
            if(!string.IsNullOrEmpty(tBoxAccountNo.Text))
            {
                AccountDeletedList = AccountDeletedList.Where(x => x.AccountNo.Equals(tBoxAccountNo.Text)).ToList();
            }
            if(dtDateTimeDeleted.Checked == true)
            {
                AccountDeletedList = AccountDeletedList.Where(x => x.DelDateTime.Equals(dtDateTimeDeleted.Value)).ToList();
            }

            dGridDelAcc.AutoGenerateColumns = false;
            dGridDelAcc.DataSource = AccountDeletedList;
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteAccount delAcc = new frmDeleteAccount();
            delAcc.ShowDialog();
        }

        private void dtDateTimeDeleted_ValueChanged(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void tBoxDeleteBy_TextChanged(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void tBoxAccountNo_TextChanged(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void frmDelAccView_Load(object sender, EventArgs e)
        {
            
        }
    }
}
