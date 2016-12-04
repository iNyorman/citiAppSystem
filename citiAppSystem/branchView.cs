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
    public partial class branchView : MetroForm
    {
        public branchView()
        {
            InitializeComponent();
        }

        private void branchView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);

            if (Global.process.searchBranchNoFromAddUser == "Search")
            {
                btnDelete.Visible = false;
                btnNew.Visible = false;
                btnUpdate.Visible = false;
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Global.process.addOrUpdateBranch = "Add";

             add_branch aB = new add_branch();
            DialogResult res = aB.ShowDialog();
            if (res == DialogResult.Yes)
            {
                this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Global.process.searchBranchNoFromAddUser = "";
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Global.process.addOrUpdateBranch = "Update";

            Global.branch.branchID = gridBranch.CurrentRow.Cells[0].Value.ToString();
            Global.branch.branchName = gridBranch.CurrentRow.Cells[1].Value.ToString();
            Global.branch.branchCode = gridBranch.CurrentRow.Cells[2].Value.ToString();
            Global.branch.address =  gridBranch.CurrentRow.Cells[3].Value.ToString();
            Global.branch.contactNo = gridBranch.CurrentRow.Cells[4].Value.ToString();


            add_branch aB = new add_branch();
            DialogResult res = aB.ShowDialog();
            if (res == DialogResult.Yes)
            {
                this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);
            }

        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            this.branchTableAdapter.FillByBranchName(this.citiAppDatabaseDataSet.branch,tboxSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void gridBranch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Global.process.searchBranchNoFromAddUser == "Search")
            {
                Global.branch.branchID = gridBranch.CurrentRow.Cells[0].Value.ToString();

                Global.process.searchBranchNoFromAddUser = "";
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}
