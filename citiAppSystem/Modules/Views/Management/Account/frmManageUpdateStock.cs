using citiAppSystem.Modules.Datasets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citiAppSystem.Modules.Views.Management.Account
{
    public partial class frmManageUpdateStock : Form
    {
        private string newStockNo = "";
        ProductsDatasets.productsRow currentProductsRow;
        private string currentSAccountNo = "";     
        public frmManageUpdateStock()
        {
            InitializeComponent();
            currentProductsRow = new ProductsDatasets.productsDataTable().NewproductsRow();
        }

        private void dR_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void dR_detailsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        }

        private void frmManageUpdateStock_Load(object sender, EventArgs e)
        {
           
        }

        private void retrieveData()
        {

            if (!string.IsNullOrEmpty(currentSAccountNo))
            {
                this.dR_detailsTableAdapter.Fill(this.deliveryReceiptDatasets.DR_details);
                var dtSOurce = deliveryReceiptDatasets.DR_details.Where(x => !string.IsNullOrEmpty(x.stockNo) && x.AccountNo == currentSAccountNo).ToList();
               if(dtSOurce.Count > 0)
               {
                   dR_detailsBindingSource.DataSource = dtSOurce;
                   bindingNavigator1.BindingSource = dR_detailsBindingSource;
               }
               else
               {
                   MessageBox.Show("No data found.");
               }
               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBoxAccountNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                currentSAccountNo = tBoxAccountNo.Text;
                retrieveData();
            }
        }

        private void accountNoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(dR_detailsBindingSource.Count > 0)
            {
                frmProductDetails newDetails = new frmProductDetails(accountNoLinkLabel.Text);
                newDetails.ShowDialog();
            }
          
        }

        private void tBoxNewStockNo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                var productSearched = ServiceLocator.Instance().ProductServices().productByStockNo(tBoxNewStockNo.Text);
                if(!string.IsNullOrEmpty(tBoxNewStockNo.Text))
                {
                    if(productSearched != null)
                    {
                        if (productSearched.status == "Sold")
                        {
                            productStatus.Text = "This product is not available.";
                            productStatus.ForeColor = Color.Red;
                            productStatus.Visible = true;
                            btnUpdate.Enabled = false;
                            newStockNo = "";
                        }
                        else
                        {
                            newStockNo = productSearched.stockNo;
                            productStatus.Text =newStockNo + " Available.";
                            productStatus.ForeColor = Color.Green;
                            productStatus.Visible = true;
                            btnUpdate.Enabled = true;
                            currentProductsRow = productSearched;
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Product found.");
                        btnUpdate.Enabled = false;
                    }
                   
                }
                else
                {
                    MessageBox.Show("No product found.");
                    productStatus.Visible = false;
                    btnUpdate.Enabled = false;
                }
             
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Details will be updated, proceed?","System",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                updateMethod();
                retrieveData();
                tBoxNewStockNo.Text = "";
                productStatus.Text = "";
                productStatus.Visible = false;
                MessageBox.Show("Update successful.");
                
            }
        }
        private void updateMethod()
        {
            var currentData = dR_detailsBindingSource.Current as DeliveryReceiptDatasets.DR_detailsRow;
             ServiceLocator.Instance().ProductServices().UpdateStatus("Available", stockNoLabel1.Text);
             ServiceLocator.Instance().ProductServices().UpdateStatus("Sold", newStockNo);
             ServiceLocator.Instance().DRServices().UpdateStockNo(currentProductsRow.stockNo, currentProductsRow.model,currentProductsRow.serialNo,currentProductsRow.brand,currentData.stockNo);
        }
    }
}
