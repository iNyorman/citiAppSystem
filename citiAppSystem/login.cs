using MetroFramework.Forms;
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
    public partial class login : MetroForm
    {
        public login()
        {
            InitializeComponent();
        }
        string branchID = "";
        private void login_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.userTableAdapter userAdapter = new citiAppDatabaseDataSetTableAdapters.userTableAdapter();

            if (cBoxRole.Text == "Manager")
            {
                citiAppDatabaseDataSet.userDataTable dtLoginRGM = userAdapter.GetDataByMANAGER(tboxUsername.Text, tboxPassword.Text, cBoxRole.Text);
                if (dtLoginRGM.Rows.Count.Equals(1))
                {
                    Global.process.role = cBoxRole.Text;
                    Form1 f1 = new Form1();
                    f1.CurrentBranchNo = cboxBranch.SelectedValue.ToString();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid inputs.");
                }
            }
            else
            {
                citiAppDatabaseDataSet.userDataTable dtLogin = (citiAppDatabaseDataSet.userDataTable)userAdapter.GetDataByLogin(tboxUsername.Text, tboxPassword.Text, branchID, cBoxRole.Text);

                if (dtLogin.Rows.Count.Equals(1))
                {
                    Global.process.role = cBoxRole.Text;
                    Form1 f1 = new Form1();
                    f1.CurrentBranchNo = cboxBranch.SelectedValue.ToString();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid inputs.");
                }
            }

        }

        private void cboxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchAdapter = new citiAppDatabaseDataSetTableAdapters.branchTableAdapter();

                citiAppDatabaseDataSet.branchRow bRow = (citiAppDatabaseDataSet.branchRow)branchAdapter.GetDataByBranchName(cboxBranch.Text).Rows[0];

                branchID = bRow.branchNo.ToString();

                Global.process.branchID = branchID;
                Global.process.branchCode = cboxBranch.SelectedValue.ToString();
                Global.branch.branchName = bRow.branchName.ToString();
                
            }
            catch (Exception)
            {
            }
            
        }
    }
}
