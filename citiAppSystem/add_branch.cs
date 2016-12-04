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
    public partial class add_branch : MetroForm
    {
        public add_branch()
        {
            InitializeComponent();
        }

        private void add_branch_Load(object sender, EventArgs e)
        {
            if (Global.process.addOrUpdateBranch == "Update")
            {
                tboxBranchID.Text = Global.branch.branchID;
                tboxBranchName.Text = Global.branch.branchName;
                tboxBranchCode.Text = Global.branch.branchCode;
                tboxAddress.Text = Global.branch.address;
                tboxContactNo.Text = Global.branch.contactNo;


                btnClear.Enabled = false;
                btnUpdate_Save.Text = "Update";
            }
        }

        private void btnUpdate_Save_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchAdapter = new citiAppDatabaseDataSetTableAdapters.branchTableAdapter();
            

            if (Global.process.addOrUpdateBranch == "Update")
            {
                    branchAdapter.UpdateQuery(tboxBranchName.Text,
                        tboxBranchCode.Text,
                        tboxAddress.Text,
                        tboxContactNo.Text,
                        tboxBranchID.Text);
                    MessageBox.Show("Branch Successfully Updated.");
                    Global.process.addOrUpdateBranch = "";
                    this.DialogResult = DialogResult.Yes;
            }
            else
            {
                citiAppDatabaseDataSet.branchDataTable dt = (citiAppDatabaseDataSet.branchDataTable)branchAdapter.GetDataByBranchNo(tboxBranchID.Text);
                //citiAppDatabaseDataSet.branchDataTable dtBranchCode = (citiAppDatabaseDataSet.branchDataTable)branchAdapter.GetDataByBranchCode(tboxBranchCode.Text);
                if (tboxBranchID.Text.Length > 0)
                {
                    if (tboxBranchName.Text.Length > 0)
                    {
                        if (tboxBranchCode.Text.Length > 0)
                        {
                            if (dt.Rows.Count.Equals(0))
                            {

                                    branchAdapter.Insert(tboxBranchID.Text,
                                        tboxBranchName.Text,
                                        tboxBranchCode.Text,
                                        tboxAddress.Text,
                                        tboxContactNo.Text);

                                    MessageBox.Show("Branch Successfully Added.");
                                    this.DialogResult = DialogResult.Yes;                              
                            }
                            else
                            {
                                MessageBox.Show("Branch ID exists.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fill Up Branch Code.");
                        }
                          
                    }
                    else
                    {
                        MessageBox.Show("Fill Up Branch Name.");
                    }
                }
                else
                {
                    MessageBox.Show("Fill up Branch ID.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

                tboxAddress.Text = "";
                tboxBranchCode.Text = "";
                tboxBranchID.Text = "";
                tboxBranchName.Text = "";
                tboxContactNo.Text = "";

        }
    }
}
