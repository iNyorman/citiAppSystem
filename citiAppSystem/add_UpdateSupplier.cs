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
    public partial class add_UpdateSupplier : MetroForm
    {
        public add_UpdateSupplier()
        {
            InitializeComponent();
        }
       
        private void add_UpdateSupplier_Load(object sender, EventArgs e)
        {
            if (Global.process.addOrUpdateSupplier == "Update")
            {
                btnClear.Enabled = false;
                btnUpdate_Save.Text = "Update";

                tboxAddress.Text = Global.supplier.supplierAddress;
                tboxContact.Text = Global.supplier.supplierContact;
                tboxSupplier.Text = Global.supplier.supplierName;
                
            }
        }

        private void btnUpdate_Save_Click(object sender, EventArgs e)
        {

            citiAppDatabaseDataSetTableAdapters.supplierTableAdapter suppAdapter = new citiAppDatabaseDataSetTableAdapters.supplierTableAdapter();

            if (Global.process.addOrUpdateSupplier == "Add")
            {
                citiAppDatabaseDataSet.supplierDataTable supDT = suppAdapter.GetData();
                int counter = supDT.Rows.Count + 1;
                string suppID = "SUP-" + counter.ToString("0000") + "-" + Global.process.branchID;

                DialogResult result = MessageBox.Show("Proceed with this Supplier details?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (tboxSupplier.Text.Length > 0)
                    {
                        suppAdapter.Insert(suppID,
                            tboxSupplier.Text,
                            tboxAddress.Text,
                            tboxContact.Text);

                        MessageBox.Show("Supplier Added.");

                        Global.process.poFromSupplier = "1";
                        Global.supplier.supplierName = tboxSupplier.Text;
                        this.DialogResult = DialogResult.Yes;
                        add_purchaseOrder POadd = new add_purchaseOrder();
                        POadd.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Input Supplier Name.");
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Update Supplier details?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        suppAdapter.UpdateQuery(tboxSupplier.Text,
                            tboxAddress.Text,
                            tboxContact.Text,
                            Global.supplier.supplierID);

                        MessageBox.Show("Update Successful");
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        MessageBox.Show("Update Cancelled.");
                    }
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
            tboxContact.Text = "";
            tboxSupplier.Text = "";
        }
    }
}
