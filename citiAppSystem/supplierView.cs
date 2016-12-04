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
    public partial class supplierView : MetroForm
    {
        public supplierView()
        {
            InitializeComponent();
        }

        private void supplierView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.citiAppDatabaseDataSet.supplier);

            if (Global.process.searchSupplierFromPO == "1")
            {
                btnDelete.Visible = false;
                btnNew.Visible = false;
                btnUpdate.Visible = false;

                
            }
          
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Global.process.addOrUpdateSupplier = "Add";
            add_UpdateSupplier aUsupp = new add_UpdateSupplier();
            DialogResult res = aUsupp.ShowDialog();

            if (res == DialogResult.Yes)
            {
                this.supplierTableAdapter.Fill(this.citiAppDatabaseDataSet.supplier);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Global.process.addOrUpdateSupplier = "Update";
           
            Global.supplier.supplierID = gridSupplier.CurrentRow.Cells[0].Value.ToString();
            Global.supplier.supplierName = gridSupplier.CurrentRow.Cells[1].Value.ToString();
            Global.supplier.supplierAddress = gridSupplier.CurrentRow.Cells[2].Value.ToString();
            Global.supplier.supplierContact = gridSupplier.CurrentRow.Cells[3].Value.ToString();

            add_UpdateSupplier aUsupp = new add_UpdateSupplier();
            DialogResult res = aUsupp.ShowDialog();

            if (res == DialogResult.Yes)
            {
                this.supplierTableAdapter.Fill(this.citiAppDatabaseDataSet.supplier);
            }

        }

        private void gridSupplier_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Global.process.searchSupplierFromPO == "1")
            {
                Global.supplier.supplierName = gridSupplier.CurrentRow.Cells[1].Value.ToString();
                Global.supplier.supplierID = gridSupplier.CurrentRow.Cells[0].Value.ToString();
                Global.process.searchSupplierFromPO = "";
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void tboxSearch_Click(object sender, EventArgs e)
        {

        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {

           
                this.supplierTableAdapter.FillBySupName(this.citiAppDatabaseDataSet.supplier, tboxSearch.Text);
          
          
        }
    }
}
