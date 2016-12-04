using MetroFramework.Forms;
using System;
using System.Collections;
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
    public partial class free_products : MetroForm
    {
        public free_products()
        {
            InitializeComponent();
        }

        string branchNo = "";
        

        private void free_products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.products' table. You can move, or remove it, as needed.
            
            tboxBrand.Text = Global.productsDetails.brand;
            tboxModel.Text = Global.productsDetails.model;
            tboxSerialNo.Text = Global.productsDetails.serialNo;
            tboxStockNo.Text = Global.productsDetails.stockNo;

            if (Global.process.branchID == "02")
            {
                cboxBranch.Visible = true;
                lblBranch.Visible = true;
                branchNo = cboxBranch.SelectedValue.ToString();
            }
            else
            {
                cboxBranch.Visible = false;
                lblBranch.Visible = false;
                branchNo = Global.process.branchID;
            }

                this.productsTableAdapter.FillByForAddFree(this.citiAppDatabaseDataSet.products, tboxStockNo.Text, branchNo);
            
            
        }

        private void btnAttachProduct_Click(object sender, EventArgs e)
        {
            gridProductList.CurrentRow.DefaultCellStyle.BackColor = Color.Red;

            if (gridFreeProducts.Rows.Count.Equals(0))
            {
                gridFreeProducts.Rows.Add(gridProductList.CurrentRow.Cells[0].Value.ToString(), gridProductList.CurrentRow.Cells[1].Value.ToString(), gridProductList.CurrentRow.Cells[2].Value.ToString(), gridProductList.CurrentRow.Cells[3].Value.ToString());
            }
            else
            {
                Boolean found = false;
                for (int i = 0; i < gridFreeProducts.Rows.Count; i++)
                {
                    if (gridFreeProducts.Rows[i].Cells[0].Value != null && gridProductList.CurrentRow.Cells[0].Value.ToString() == gridFreeProducts.Rows[i].Cells[0].Value.ToString())
                    {

                        MessageBox.Show("Already exist");
                        found = true;
                        break;

                    }
                    else
                    {
                        found = false;
                    }

                }

                if (found == false)
                {
                    gridFreeProducts.Rows.Add(gridProductList.CurrentRow.Cells[0].Value.ToString(), gridProductList.CurrentRow.Cells[1].Value.ToString(), gridProductList.CurrentRow.Cells[2].Value.ToString(), gridProductList.CurrentRow.Cells[3].Value.ToString());

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Save_Click(object sender, EventArgs e)
        {
            if (gridFreeProducts.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Proceed with this Attached Products?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    citiAppDatabaseDataSetTableAdapters.freeProductTableAdapter freeProdAdapter = new citiAppDatabaseDataSetTableAdapters.freeProductTableAdapter();
                    citiAppDatabaseDataSetTableAdapters.productsTableAdapter prodAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
                    citiAppDatabaseDataSet.freeProductDataTable fStockNoDT = freeProdAdapter.GetData();
                    string fStockNo = fStockNoDT.Rows.Count.ToString("0000");
                    for (int i = 0; i < gridFreeProducts.Rows.Count; i++)
                    {
                        fStockNo = fStockNo + 1;
                        freeProdAdapter.Insert(fStockNo, gridFreeProducts.Rows[i].Cells[0].Value.ToString(),tboxStockNo.Text);

                        prodAdapter.UpdateStatus("Free", gridFreeProducts.Rows[i].Cells[0].Value.ToString());
                    }

                    MessageBox.Show("Free product successfully attached.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Attaching Free Product Canceled.");
                }
            }
            else
            {
                MessageBox.Show("No free products selected.");
            }
        }

        private void FilterMethod()
        {

                if (cBoxFilter.Text == "Stock Number")
                {

                    this.productsTableAdapter.FillBySearchByStockNOFREE(this.citiAppDatabaseDataSet.products, tboxStockNo.Text,tboxSearch.Text,branchNo);
                    
                }
                else if (cBoxFilter.Text == "Model")
                {
                    this.productsTableAdapter.FillBySearchByModelFREE(this.citiAppDatabaseDataSet.products, tboxStockNo.Text, tboxSearch.Text, branchNo);
                  
                }
                else if (cBoxFilter.Text == "Serial")
                {
                    this.productsTableAdapter.FillBySearchBySerialNoFREE(this.citiAppDatabaseDataSet.products, tboxStockNo.Text, tboxSearch.Text, branchNo);
                    
                }
                else if (cBoxFilter.Text == "Brand")
                {
                    this.productsTableAdapter.FillBySearchByBrandFREE(this.citiAppDatabaseDataSet.products, tboxStockNo.Text, tboxSearch.Text, branchNo);
                }
                else
                {
                    MessageBox.Show("Invalid Search By.");
                }
          
            
        }

        private void gridProductList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void cBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMethod();
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterMethod();
        }

        private void cboxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            branchNo = cboxBranch.SelectedValue.ToString();
            //this.productsTableAdapter.FillByAttachProductChangeindex(this.citiAppDatabaseDataSet.products, branchNo);
            this.productsTableAdapter.FillByForAddFree(this.citiAppDatabaseDataSet.products, tboxStockNo.Text, branchNo);
        }

        private void tboxStockNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.productsTableAdapter prodAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();

            citiAppDatabaseDataSet.productsDataTable dtProducts = prodAdapter.GetDataByStockNoStatusLOC(branchNo, tboxStockNo.Text);

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Global.process.branchID == "02")
                {
                    if (dtProducts.Rows.Count == 1)
                    {
                        citiAppDatabaseDataSet.productsRow productsRow = (citiAppDatabaseDataSet.productsRow)prodAdapter.GetDataByStockNo(tboxStockNo.Text).Rows[0];
                        tboxModel.Text = productsRow.model.ToString();
                        tboxBrand.Text = productsRow.brand.ToString();
                        tboxSerialNo.Text = productsRow.serialNo.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid stock number.");
                    }
                }
            }
        }
    }
}
