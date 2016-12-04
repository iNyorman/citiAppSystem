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
    public partial class updateProductDetails : MetroForm
    {
        public string stockNo = "";
        public string brand = "";
        public string model = "";
        public string serialNo = "";
        public string price = "";

        public updateProductDetails()
        {
            InitializeComponent();
        }

        private void updateProductDetails_Load(object sender, EventArgs e)
        {
            labelStockNo.Text = stockNo;
            tBoxBrand.Text = brand;
            tBoxModel.Text = model;
            tBoxSerialNo.Text = serialNo;
            tboxPrice.Text = price;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            citiAppDatabaseDataSetTableAdapters.productsTableAdapter productsAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();

            DialogResult result = MessageBox.Show("Current Changes will be save, Proceed?","Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productsAdapter.UpdateQuery(tBoxSerialNo.Text, tBoxBrand.Text, tBoxModel.Text, tboxPrice.Text,labelStockNo.Text);
                MessageBox.Show("Update Successful","Notification");
            }
        }
    }
}
