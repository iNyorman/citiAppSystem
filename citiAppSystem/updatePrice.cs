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
    public partial class updatePrice : MetroForm
    {
        public updatePrice()
        {
            InitializeComponent();
        }
        
        private void updatePrice_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.citiAppDatabaseDataSet.supplier);       
            cboxSupplierName.Text = "";
         

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboxModel.Enabled = true;
                // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.model' table. You can move, or remove it, as needed.
                this.modelTableAdapter.FillByBrandID(this.citiAppDatabaseDataSet.model, cboxBrand.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + " : " + ex.Message);
            }
         
        }

        private void cboxSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboxBrand.Enabled = true;
                // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.brand' table. You can move, or remove it, as needed.
                this.brandTableAdapter.FillBySUPIDno(this.citiAppDatabaseDataSet.brand, cboxSupplierName.SelectedValue.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + " : " + ex.Message);
            }
        }

        private void cboxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                citiAppDatabaseDataSetTableAdapters.productListTableAdapter pLAdapter = new citiAppDatabaseDataSetTableAdapters.productListTableAdapter();
                citiAppDatabaseDataSet.productListDataTable plDT = pLAdapter.GetDataByBRANDmodelSUPID(cboxSupplierName.SelectedValue.ToString(), cboxBrand.SelectedValue.ToString(), cboxModel.SelectedValue.ToString());
                if (plDT.Rows.Count.Equals(1))
                {
                    citiAppDatabaseDataSet.productListRow plRow = (citiAppDatabaseDataSet.productListRow)pLAdapter.GetDataByBRANDmodelSUPID(cboxSupplierName.SelectedValue.ToString(), cboxBrand.SelectedValue.ToString(), cboxModel.SelectedValue.ToString()).Rows[0];

                    tboxCurrentPrice.Text = plRow.price.ToString();
                }
                else
                {
                    tboxCurrentPrice.Text = "0.00";
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnUpdate_Save_Click(object sender, EventArgs e)
        {
            try
            {
                citiAppDatabaseDataSetTableAdapters.productListTableAdapter pLadapter = new citiAppDatabaseDataSetTableAdapters.productListTableAdapter();

                citiAppDatabaseDataSet.productListDataTable plDT = pLadapter.GetDataByBRANDmodelSUPID(cboxSupplierName.SelectedValue.ToString(), cboxBrand.SelectedValue.ToString(), cboxModel.SelectedValue.ToString());
                if (plDT.Rows.Count.Equals(1))
                {
                    pLadapter.UpdatePrice(tboxNewPrice.Text, cboxModel.SelectedValue.ToString());
                    tboxNewPrice.Text = "";
                    MessageBox.Show("Price Successfully Updated");
                }
                else
                {
                    MessageBox.Show("No existing record of purchase order.");
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
