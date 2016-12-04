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
    public partial class add_updateUser : MetroForm
    {
        public add_updateUser()
        {
            InitializeComponent();
        }

        private void add_updateUser_Load(object sender, EventArgs e)
        {
            if (Global.process.addOrUpdateUser == "Update")
            {
                tboxUserID.Text = Global.user.userID;
                tboxFirstName.Text = Global.user.Fname;
                tboxLastName.Text = Global.user.Lname;
                tboxUsername.Text = Global.user.Username;
                tboxPassword.Text = Global.user.Password;
                cBoxRole.Text = Global.user.Role;
                tboxBranchNo.Text = Global.user.branchNo;

                btnClear.Enabled = false;
                tboxUserID.Enabled = false;
                btnUpdate_Save.Text = "Update";
            }
        }

        private void btnUpdate_Save_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.userTableAdapter userAdapter = new citiAppDatabaseDataSetTableAdapters.userTableAdapter();

            addAndUpdateMethod(userAdapter);
        }

        private void addAndUpdateMethod(citiAppDatabaseDataSetTableAdapters.userTableAdapter userAdapter)
        {
            if (Global.process.addOrUpdateUser == "Add")
            {
                citiAppDatabaseDataSet.userDataTable dtID = (citiAppDatabaseDataSet.userDataTable)userAdapter.GetDataByUserID(tboxUserID.Text);
                citiAppDatabaseDataSet.userDataTable dtUsername = (citiAppDatabaseDataSet.userDataTable)userAdapter.GetDataByUsername(tboxUsername.Text);
                if (tboxUserID.Text.Length > 0)
                {
                    if (tboxLastName.Text.Length > 0)
                    {
                        if (tboxFirstName.Text.Length > 0)
                        {
                            if (tboxUsername.Text.Length > 0)
                            {
                                if (tboxPassword.Text.Length > 0)
                                {
                                    if (tboxBranchNo.Text.Length > 0)
                                    {
                                        if (dtID.Rows.Count.Equals(0))
                                        {
                                            if (dtUsername.Rows.Count.Equals(0))
                                            {
                                                userAdapter.Insert(tboxUserID.Text,
                                                    tboxFirstName.Text,
                                                    tboxLastName.Text,
                                                    cBoxRole.Text,
                                                    tboxUsername.Text,
                                                    tboxPassword.Text,
                                                    tboxBranchNo.Text);

                                                MessageBox.Show("User Successfully Added.");

                                                this.DialogResult = DialogResult.Yes;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Username Exist");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("User ID exists.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Fillup Branch No");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fill up Password.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Fill up Username");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fill up First Name.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill up Last Name.");
                    }
                }
                else
                {
                    MessageBox.Show("Fill up User ID.");
                }
            }
            else
            {
                userAdapter.UpdateQuery(tboxFirstName.Text,
                    tboxLastName.Text,
                    cBoxRole.Text,
                    tboxUsername.Text,
                    tboxPassword.Text,
                    tboxBranchNo.Text,
                    tboxUserID.Text);

                MessageBox.Show("User Successfully Updated.");

                this.DialogResult = DialogResult.Yes;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Global.process.searchBranchNoFromAddUser = "Search";
            branchView bV = new branchView();
            DialogResult res = bV.ShowDialog();
            if (res == DialogResult.Yes)
            {
                tboxBranchNo.Text = Global.branch.branchID;
            }
        }
    }
}
