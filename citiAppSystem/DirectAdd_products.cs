using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Models;
using citiAppSystem.Modules.Models.Enums;
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
    public partial class DirectAdd_products : MetroForm
    {
        public string stockNo_ = "";
        public Action<List<ProductDR>> directAddProduct { get; set; }
        public Action<List<ProductsDatasets.productsRow>> directAddPRoductList { get; set; }
        List<ProductDR> direcAddList;
        private AddingDrMode currentMode;
        public DirectAdd_products(AddingDrMode selectedMode, string _stockNo = null, string _branch = null, string branchNo = null)
        {
            InitializeComponent();
            if (_stockNo != null)
            {
                tboxStockNo.Text = _stockNo;
                tBoxBranch.Text = _branch;
                tBoxBranch.Tag = branchNo;
                currentMode = selectedMode;
            }
            direcAddList = new List<ProductDR>();
        }
        private void DirectAdd_products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnADd_Click(object sender, EventArgs e)
        {
            addProductToList();
        }

        private void addProductToList()
        {
            ProductDR productNew = new ProductDR();
            var checkProductExist = ServiceLocator.Instance().ProductServices().productByStockNo(tboxStockNo.Text);
            if (checkProductExist != null)
            {
                MessageBox.Show("Product already exist.");
            }
            else
            {
                if (direcAddList.Where(x => x.stockNo == tboxStockNo.Text).ToList().Count == 1)
                {
                    MessageBox.Show("Already added.");
                }
                else
                {
                    productNew.stockNo = tboxStockNo.Text;
                    productNew.Serial = tboxSerialNo.Text;
                    productNew.Brand = tboxBrand.Text;
                    productNew.Model = tboxModel.Text;
                    productNew.Remarks = currentMode.ToString();
                    productNew.Price = tboxPrice.Text;
                    direcAddList.Add(productNew);
                    populateGrid();
                    tboxBrand.Text = "";
                    tboxModel.Text = "";
                    tboxSerialNo.Text = "";
                    tboxStockNo.Text = "";
                }
            }
        }

        private void populateGrid()
        {
            gridProducts.AutoGenerateColumns = false;
            gridProducts.DataSource = direcAddList.ToList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxBrand.Text = "";
            tboxModel.Text = "";
            tboxSerialNo.Text = "";
            tboxStockNo.Text = "";
            direcAddList = null;
            populateGrid();
        }

        private void btnUpdate_Save_Click(object sender, EventArgs e)
        {
            try
            {
                citiAppDatabaseDataSetTableAdapters.productsTableAdapter productsAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
                  
                if (gridProducts.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Proceed with this products?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        foreach(var list in direcAddList)
                        {
                            productsAdapter.Insert(list.stockNo,
                                list.Brand,
                                list.Model,
                                list.Serial,
                                "Available",
                                "n/a",
                                "n/a",
                                "none",
                                tBoxBranch.Tag.ToString(),
                                tBoxBranch.Tag.ToString(),
                                null,
                                "none",
                                list.Price,
                                tBoxBranch.Tag.ToString());
                        }
                        MessageBox.Show("Product/s Successfully Added.");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No products to add.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.Source);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridProducts.Rows.Count > 0)
            {
                var a = gridProducts.CurrentRow.DataBoundItem as ProductDR;
                direcAddList.Remove(a);
                populateGrid();
            }
        }
    }
}
