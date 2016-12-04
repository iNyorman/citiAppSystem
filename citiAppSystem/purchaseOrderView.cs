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
    public partial class purchaseOrderView : MetroForm
    {
        public purchaseOrderView()
        {
            InitializeComponent();
        }

        private void purchaseOrderView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.PO_View' table. You can move, or remove it, as needed.
            this.pO_ViewTableAdapter.Fill(this.citiAppDatabaseDataSet.PO_View);
           
          

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            add_purchaseOrder po = new add_purchaseOrder();
            DialogResult res = po.ShowDialog();
            if (res == DialogResult.Yes)
            {
               
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PurchaseOrderReport poR = new PurchaseOrderReport();
            poR.poNumber = gridPurchaseOrder.CurrentRow.Cells[0].Value.ToString();
            poR.ShowDialog();
           
        }

        private void searchMethod()
        {
            if (cboxSearchBy.Text == "PO Number")
            {
                this.pO_ViewTableAdapter.FillByLIKEPOID(this.citiAppDatabaseDataSet.PO_View, tboxSearch.Text);
            }
            else
            {
                this.pO_ViewTableAdapter.FillByLIKEsName(this.citiAppDatabaseDataSet.PO_View, tboxSearch.Text);
            }
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            searchMethod();
        }

        private void cboxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchMethod();
        }
    }
}
