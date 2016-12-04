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
    public partial class CustomerCenter : MetroForm
    {
        public CustomerCenter()
        {
            InitializeComponent();
        }

        private void CustomerCenter_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'citiAppDatabaseDataSet.collection_details' table. You can move, or remove it, as needed.
            //this.collection_detailsTableAdapter.Fill(this.citiAppDatabaseDataSet.collection_details);
            //// TODO: This line of code loads data into the 'citiAppDatabaseDataSet.DeliveryView_Table' table. You can move, or remove it, as needed.
            //this.deliveryView_TableTableAdapter.Fill(this.citiAppDatabaseDataSet.DeliveryView_Table);

           

            label1.Visible = false;
         

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_NewCustomer_Click(object sender, EventArgs e)
        {
            CustomerForms.add_updateCustomer aUCustomer = new CustomerForms.add_updateCustomer();
            aUCustomer.fromCC = "y";
            this.Close();
            aUCustomer.Show();
          
        }

        private void tboxStockNo_TextChanged(object sender, EventArgs e)
        {
            this.collection_detailsTableAdapter.FillByCollectionID(this.citiAppDatabaseDataSet.collection_details,"");
            
           

           
        }

        private void rb_Date_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
          
        }

        private void rb_Name_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
           
        }

        private void rb_AcctNo_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
           
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dtTO_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_UpdateTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                Global.drReceipt.acountNo = gridDR.CurrentRow.Cells[7].Value.ToString();
                Global.drReceipt.customerID = gridDR.CurrentRow.Cells[8].Value.ToString();
                Global.drReceipt.collectionNo = gridDR.CurrentRow.Cells[6].Value.ToString();
                Global.process.accountType = gridDR.CurrentRow.Cells[3].Value.ToString();
                collections coll = new collections();
                coll.accountType = gridDR.CurrentRow.Cells[6].Value.ToString();
                DialogResult res = coll.ShowDialog();
                this.Close();

            }
            catch (Exception)
            {

            }
        }

        private void gridDR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.collection_detailsTableAdapter.FillByCollectionID(this.citiAppDatabaseDataSet.collection_details, gridDR.CurrentRow.Cells[6].Value.ToString());
        }
    }
}
