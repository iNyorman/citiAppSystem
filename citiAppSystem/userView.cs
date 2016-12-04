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
    public partial class userView : MetroForm
    {
        public userView()
        {
            InitializeComponent();
        }

        private void userView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.user' table. You can move, or remove it, as needed.
            if (Global.process.branchID == "02")
            {
                this.userTableAdapter.Fill(this.citiAppDatabaseDataSet.user);
            }
            else
            {
                this.userTableAdapter.FillByBranchNo(this.citiAppDatabaseDataSet.user,Global.process.branchID);
            }
          
 

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Global.process.addOrUpdateUser = "Add";
            add_updateUser aU = new add_updateUser();
            DialogResult res = aU.ShowDialog();
            if (res == DialogResult.Yes)
            {
                this.userTableAdapter.Fill(this.citiAppDatabaseDataSet.user); 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Global.process.addOrUpdateUser = "Update";

            Global.user.userID = gridUser.CurrentRow.Cells[0].Value.ToString();
            Global.user.Fname = gridUser.CurrentRow.Cells[1].Value.ToString();
            Global.user.Lname = gridUser.CurrentRow.Cells[2].Value.ToString();
            Global.user.Role = gridUser.CurrentRow.Cells[3].Value.ToString();
            Global.user.Username = gridUser.CurrentRow.Cells[4].Value.ToString();
            Global.user.Password = gridUser.CurrentRow.Cells[5].Value.ToString();
            Global.user.branchNo = gridUser.CurrentRow.Cells[6].Value.ToString();
            
            add_updateUser aU = new add_updateUser();
            DialogResult res = aU.ShowDialog();
            if (res == DialogResult.Yes)
            {
                this.userTableAdapter.Fill(this.citiAppDatabaseDataSet.user);
            }
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            if (cboxSearchBy.Text == "Role")
            {
                this.userTableAdapter.FillByRole(this.citiAppDatabaseDataSet.user,tboxSearch.Text,Global.process.branchID);
            }
            else if (cboxSearchBy.Text == "Name")
            {
                this.userTableAdapter.FillByName(this.citiAppDatabaseDataSet.user, tboxSearch.Text, tboxSearch.Text, Global.process.branchID);
            }
            else
            {
                MessageBox.Show("Choose Search By");
            }
        }
    }
}
