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
    public partial class purchaseOrderDetailsVIEW : MetroForm
    {
        public purchaseOrderDetailsVIEW()
        {
            InitializeComponent();
        }
        public string poNumber = "";
        

        private void purchaseOrderDetailsVIEW_Load(object sender, EventArgs e)
        {           
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.poDetails' table. You can move, or remove it, as needed.          
            this.poDetailsTableAdapter.FillByPOidandStatus(this.citiAppDatabaseDataSet.poDetails,poNumber);         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
         {
            //int totalQTY;
            //int orderQTY = Int32.Parse(gridPODetails.CurrentRow.Cells[2].Value.ToString());
            //int freeQTY = Int32.Parse(gridPODetails.CurrentRow.Cells[3].Value.ToString());
            //totalQTY = orderQTY + freeQTY;
            Global.poDetails.brand = gridPODetails.CurrentRow.Cells[0].Value.ToString();
            Global.poDetails.model = gridPODetails.CurrentRow.Cells[1].Value.ToString();
            //Global.poDetails.orderedQTY = totalQTY.ToString();
            Global.poDetails.totalQty = gridPODetails.CurrentRow.Cells[7].Value.ToString();
            Global.poDetails.poDetailsID = gridPODetails.CurrentRow.Cells[8].Value.ToString();
            Global.poDetails.remainingQty = gridPODetails.CurrentRow.Cells[10].Value.ToString();
            Global.poDetails.holderQty = gridPODetails.CurrentRow.Cells[11].Value.ToString();
            Global.poDetails.price = gridPODetails.CurrentRow.Cells[4].Value.ToString();
         
            
            
            
            this.DialogResult = DialogResult.Yes;
           

        
        }
    }
}
