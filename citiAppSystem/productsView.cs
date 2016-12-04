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
    public partial class productsView : MetroForm
    {
        public productsView()
        {
            InitializeComponent();
        }

        public string mainProduct = "";
        public string accNO = "";
        

        private void productsView_Load(object sender, EventArgs e)
        {
            label1.Text = accNO;
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet1.freeProduct' table. You can move, or remove it, as needed.

            if (Global.process.branchID == "02")
            {
                this.productsTableAdapter.Fill(this.citiAppDatabaseDataSet1.products);
                this.freeProductTableAdapter.Fill(this.citiAppDatabaseDataSet1.freeProduct);
            }
            else
            {
                this.productsTableAdapter.FillByLocationTO(this.citiAppDatabaseDataSet1.products, Global.process.branchID);
            }
           
          
            //btnUpdate.Enabled = false;          
            //// from dr form
            //if (Global.process.selectProdFromDR == "Add")
            //{
            //    //this.productsTableAdapter.FillByStatusANDfromLOC(this.citiAppDatabaseDataSet1.products, "Available", Global.process.branchID); 
            //    if (Global.branch.branchID == "02")
            //    {
            //        this.productsTableAdapter.Fill(this.citiAppDatabaseDataSet1.products);
            //    }
            //    else
            //    {
            //        this.productsTableAdapter.FillByLocationTO(this.citiAppDatabaseDataSet1.products, Global.process.branchID); 
            //    }
                
                
            //    btnNew.Visible = false;
            //    btnUpdate.Visible = false;
            //    btnFree.Visible = false;
        
            //}
            ////else if (Global.process.selectProdFromDR == "Add Free")
            ////{

            ////    this.productsTableAdapter.FillByForAddFree(this.citiAppDatabaseDataSet1.products, mainProduct); 
            ////    btnDelete.Visible = false;
            ////    btnNew.Visible = false;
            ////    btnUpdate.Visible = false;
            ////    btnFree.Visible = false;
            ////}

            //else
            //{
               
            //    // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.products' table. You can move, or remove it, as needed.
            //    if (Global.branch.branchID == "02")
            //    {
            //        this.productsTableAdapter.Fill(this.citiAppDatabaseDataSet1.products);
            //    }
            //    else
            //    {
            //        this.productsTableAdapter.FillByLocationTO(this.citiAppDatabaseDataSet1.products, Global.process.branchID);
            //    }
               
              
            //    btnNew.Visible = true;
            //    btnUpdate.Visible = true;
            //    btnFree.Visible = true;
             
            //}



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Global.process.ProductViewOpenFrom = "Add";
            Global.process.addPRODorderedORfree = "ordered";
            addProducts aUprod = new addProducts();
            this.Close();
            aUprod.Show();
           
            //DialogResult res = aUprod.ShowDialog();
            //if (res == DialogResult.Yes)
            //{
            //    this.productsTableAdapter.FillByLocationTO(this.citiAppDatabaseDataSet1.products, Global.process.branchID);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            updateProductDetails uPD = new updateProductDetails();
            uPD.stockNo = gridProducts.CurrentRow.Cells[0].Value.ToString();
            uPD.serialNo = gridProducts.CurrentRow.Cells[3].Value.ToString();
            uPD.brand = gridProducts.CurrentRow.Cells[1].Value.ToString();
            uPD.model = gridProducts.CurrentRow.Cells[2].Value.ToString();
            uPD.price = gridProducts.CurrentRow.Cells[7].Value.ToString();
            
            DialogResult res = uPD.ShowDialog();
            if (res == DialogResult.Yes)
            {
                this.productsTableAdapter.FillByLocationTO(this.citiAppDatabaseDataSet1.products, Global.process.branchID);
                btnUpdate.Enabled = false;

            }
        }

 

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterMethod();
            
        }

        private void FilterMethod()
        {
            //if (Global.process.selectProdFromDR == "Add")
            //{
                if (cBoxFilter.Text == "Stock Number")
                {
                    this.productsTableAdapter.FillByStockNoANDlocToANDstatus(this.citiAppDatabaseDataSet1.products, tboxSearch.Text, "Available", Global.process.branchID);
                }
                else if (cBoxFilter.Text == "Model")
                {
                    this.productsTableAdapter.FillByModelANDToLOCandstatus(this.citiAppDatabaseDataSet1.products, tboxSearch.Text, "Available", Global.process.branchID);
                }
                else if (cBoxFilter.Text == "Serial")
                {
                    this.productsTableAdapter.FillByserialNOANDlocationToANDstatus(this.citiAppDatabaseDataSet1.products, tboxSearch.Text, Global.process.branchID, "Available");
                }
                else if (cBoxFilter.Text == "Brand")
                {
                    this.productsTableAdapter.FillBybrandANDlocTOANDstatus(this.citiAppDatabaseDataSet1.products, tboxSearch.Text, Global.process.branchID, "Available");
                }
                else if (cBoxFilter.Text == "Arrival Number")
                {
                    this.productsTableAdapter.FillByDeliveryNo(this.citiAppDatabaseDataSet1.products, tboxSearch.Text);
                }
                else
                {
                    MessageBox.Show("Invalid Search By.");
                }
            //}
            //else
            //{
            //    if (cBoxFilter.Text == "Stock Number")
            //    {
            //        this.productsTableAdapter.FillByStockNoANDfromLOC(this.citiAppDatabaseDataSet1.products, tboxSearch.Text, Global.process.branchID);
            //    }
            //    else if (cBoxFilter.Text == "Model")
            //    {
            //        this.productsTableAdapter.FillByModelANDfromLOC(this.citiAppDatabaseDataSet1.products, tboxSearch.Text, Global.process.branchID);
            //    }

            //    else if (cBoxFilter.Text == "Serial")
            //    {
            //        this.productsTableAdapter.FillBySerialNoANDfromLOC(this.citiAppDatabaseDataSet1.products, tboxSearch.Text, Global.process.branchID);
            //    }

            //    else if (cBoxFilter.Text == "Brand")
            //    {
            //        this.productsTableAdapter.FillByBrandANDfromLOC(this.citiAppDatabaseDataSet1.products, tboxSearch.Text, Global.process.branchID);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid Search By.");
            //    }
            //}
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (cBoxFilter.Text == "Arrival Number")
            {
                ArrivalReport aR = new ArrivalReport();
                aR.deliveryNo = tboxSearch.Text;

                aR.ShowDialog();
            }
            else
            {
                productsReport pR = new productsReport();
                pR.parameter = tboxSearch.Text;

                pR.ShowDialog();
            }

        }

        private void gridProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdate.Enabled = true;
            if (Global.process.selectProdFromDR == "Add")
            {
                //citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter drAdapter = new citiAppDatabaseDataSetTableAdapters.deliveryReceiptTableAdapter();
                //citiAppDatabaseDataSet.deliveryReceiptDataTable drTable = drAdapter.GetData();

                //citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter drDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.DR_detailsTableAdapter();
                //citiAppDatabaseDataSet.DR_detailsDataTable count = drDetailsAdapter.GetData();

                ////int drDetailsID = count.Rows.Count + 1;
                ////drDetailsAdapter.Insert(Global.process.branchID + drDetailsID.ToString("0000"), "0.00", gridProducts.CurrentRow.Cells[0].Value.ToString(), label1.Text, "1", "", "", "", "", "-", "");

                ////if (gridFreeProductView.Rows.Count > 0)
                ////{
                ////    for (int xxx = 0; xxx < gridFreeProductView.Rows.Count; xxx++)
                ////    {
                ////        drDetailsID = drDetailsID + 1;
                ////        drDetailsAdapter.Insert(Global.process.branchID + drDetailsID.ToString("0000"), "0.00", gridFreeProductView.Rows[xxx].Cells[0].Value.ToString(), label1.Text, "1", "", "", "", "", "Free", "");

                ////    }
                ////}
                
                
                //Global.productsDetails.stockNo = gridProducts.CurrentRow.Cells[0].Value.ToString();
                //Global.process.drDetailsIDfromProductsView = Global.process.branchID + drDetailsID.ToString("0000");
               
                ////update status ng prod
                //citiAppDatabaseDataSetTableAdapters.productsTableAdapter prodAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
                //prodAdapter.UpdateStatus("Pending", gridProducts.CurrentRow.Cells[0].Value.ToString());
                
                
                //Global.process.selectProdFromDR = "";
                //this.DialogResult = DialogResult.Yes;
            }
            else if (Global.process.selectProdFromDR == "Add Free")
            {
              
                
                    Global.productsDetails.stockNo = gridProducts.CurrentRow.Cells[0].Value.ToString();
                    Global.productsDetails.serialNo = gridProducts.CurrentRow.Cells[3].Value.ToString();
                    Global.productsDetails.brand = gridProducts.CurrentRow.Cells[1].Value.ToString();
                    Global.productsDetails.model = gridProducts.CurrentRow.Cells[2].Value.ToString();

                    Global.process.selectProdFromDR = "";
                    this.DialogResult = DialogResult.Yes;
            
                
            }
            else
            {
                Global.productsDetails.stockNo = gridProducts.CurrentRow.Cells[0].Value.ToString();
                Global.productsDetails.serialNo = gridProducts.CurrentRow.Cells[1].Value.ToString();
                Global.productsDetails.brand = gridProducts.CurrentRow.Cells[2].Value.ToString();
                Global.productsDetails.model = gridProducts.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            Global.productsDetails.stockNo = gridProducts.CurrentRow.Cells[0].Value.ToString();
            Global.productsDetails.serialNo = gridProducts.CurrentRow.Cells[3].Value.ToString();
            Global.productsDetails.brand = gridProducts.CurrentRow.Cells[1].Value.ToString();
            Global.productsDetails.model = gridProducts.CurrentRow.Cells[2].Value.ToString();
            this.Close();
            free_products fp = new free_products();
            fp.Show();
        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }



        private void gridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMethod();
        }

        private void gridProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet1.Free_Product_View' table. You can move, or remove it, as needed.
            this.free_Product_ViewTableAdapter.FillByStockNo(this.citiAppDatabaseDataSet1.Free_Product_View, gridProducts.CurrentRow.Cells[0].Value.ToString());
            btnFree.Enabled = true;
        }

     
    }
}
