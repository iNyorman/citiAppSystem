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
    public partial class TransferList : MetroForm
    {
        public TransferList()
        {
            InitializeComponent();
        }

        private void TransferList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.st_requisitionTable' table. You can move, or remove it, as needed.
            this.st_requisitionTableTableAdapter.Fill(this.citiAppDatabaseDataSet.st_requisitionTable);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            stockTransfer st = new stockTransfer();
            st.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                TransferProductReports tfp = new TransferProductReports();
                tfp.st_ID = gridTransfer.CurrentRow.Cells[0].Value.ToString();
                tfp.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void searchMethod()
        {
               this.st_requisitionTableTableAdapter.FillByLIKEstid(this.citiAppDatabaseDataSet.st_requisitionTable,tboxSearch.Text);
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            searchMethod();
        }
    }
}
