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
    public partial class add_purchaseOrder : MetroForm
    {
        public add_purchaseOrder()
        {
            InitializeComponent();
        }
        string supplierID = "";
        string brand_ID = "";
        string model_ID = "";
        private void add_purchaseOrder_Load(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.purchaseOrderTableAdapter poAdapter = new citiAppDatabaseDataSetTableAdapters.purchaseOrderTableAdapter();
            citiAppDatabaseDataSet.purchaseOrderDataTable poDTID = poAdapter.GetData();

            int poIDCounter = poDTID.Rows.Count + 1;
            string poID = System.DateTime.Today.Year.ToString().Substring(2,2)+ "-" + poIDCounter.ToString("000000");
            tboxPONumber.Text = poID;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Global.process.searchSupplierFromPO = "1";
                supplierView sv = new supplierView();
                DialogResult res = sv.ShowDialog();

                if (res == DialogResult.Yes)
                {
                    tboxSupplierName.Text = Global.supplier.supplierName;
                    supplierID = Global.supplier.supplierID;

                    citiAppDatabaseDataSetTableAdapters.productListTableAdapter productListAdapter = new citiAppDatabaseDataSetTableAdapters.productListTableAdapter();
                    citiAppDatabaseDataSetTableAdapters.cBoxOutPutTableAdapter cboxOutAdapter = new citiAppDatabaseDataSetTableAdapters.cBoxOutPutTableAdapter();
                    citiAppDatabaseDataSet.cBoxOutPutDataTable cBoxOutDT = new citiAppSystem.citiAppDatabaseDataSet.cBoxOutPutDataTable();
                    citiAppDatabaseDataSet.supplierDataTable supplierDT = new citiAppSystem.citiAppDatabaseDataSet.supplierDataTable();
                    citiAppDatabaseDataSetTableAdapters.supplierTableAdapter supAdapter = new citiAppDatabaseDataSetTableAdapters.supplierTableAdapter();


                    supplierDT = supAdapter.GetDataBySupName(tboxSupplierName.Text);
                    if (supplierDT.Rows.Count.Equals(1))
                    {
                        citiAppDatabaseDataSet.supplierRow supRow = (citiAppDatabaseDataSet.supplierRow)supAdapter.GetDataBySupName(tboxSupplierName.Text).Rows[0];
                        supplierID = supRow.sup_IDno.ToString();
                     
                        this.brandTableAdapter.FillBySUPIDno(this.citiAppDatabaseDataSet.brand, supplierID);
                        cBoxBrand.Text = "";

                    }
                }

                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + " : " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Save_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.purchaseOrderTableAdapter poAdapter = new citiAppDatabaseDataSetTableAdapters.purchaseOrderTableAdapter();
            citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter poDetailsAdapter = new citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter();
            citiAppDatabaseDataSetTableAdapters.supplierTableAdapter supAdapter = new citiAppDatabaseDataSetTableAdapters.supplierTableAdapter();
            citiAppDatabaseDataSetTableAdapters.productListTableAdapter prodListAdapter = new citiAppDatabaseDataSetTableAdapters.productListTableAdapter();
            citiAppDatabaseDataSetTableAdapters.modelTableAdapter modelAdapter = new citiAppDatabaseDataSetTableAdapters.modelTableAdapter();
            citiAppDatabaseDataSetTableAdapters.brandTableAdapter brandAdapter = new citiAppDatabaseDataSetTableAdapters.brandTableAdapter();
           
            
            
            DialogResult result = MessageBox.Show("Proceed with this Purchase Order?","Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dataGridView1.Rows.Count > 0)
            {
                if (result == DialogResult.Yes)
                {
                    citiAppDatabaseDataSet.supplierDataTable supDT = supAdapter.GetDataBySupName(tboxSupplierName.Text);
                    citiAppDatabaseDataSet.supplierDataTable supIDdt = supAdapter.GetData();
                    if (supDT.Rows.Count.Equals(0))
                    {
                        supAdapter.Insert(supplierID, tboxSupplierName.Text, "-", "-");

                        //insert sa purchase order
                        poAdapter.Insert(tboxPONumber.Text,
                            Convert.ToDateTime(POdateTimePicker.Text),
                            Convert.ToDateTime(DeliveryDateTimePicker.Text),
                            supplierID,
                            cboxBranch.Text,
                            "RGM", tboxTotal.Text);



                        
                        //insert sa poDetails
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            citiAppDatabaseDataSet.poDetailsDataTable dt = poDetailsAdapter.GetData();
                            int poDetailsID = dt.Rows.Count;
                            poDetailsID = poDetailsID + 1;
                                                      
                            int totalQty = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString()) + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                            poDetailsAdapter.Insert(poDetailsID.ToString("0000"),
                                dataGridView1.Rows[i].Cells[1].Value.ToString(),//model
                                dataGridView1.Rows[i].Cells[2].Value.ToString(),//ordered qty
                                dataGridView1.Rows[i].Cells[3].Value.ToString(),//free qty
                                dataGridView1.Rows[i].Cells[4].Value.ToString(),//cost
                                dataGridView1.Rows[i].Cells[5].Value.ToString(),//discount
                                dataGridView1.Rows[i].Cells[6].Value.ToString(),//total cost
                                tboxPONumber.Text,//PO Number
                                dataGridView1.Rows[i].Cells[0].Value.ToString(),//brand
                                totalQty.ToString(),//totalQty
                                "pending",//Status
                                totalQty.ToString(),
                                totalQty.ToString());

                        }


                    }
                    else
                    {
                        citiAppDatabaseDataSet.supplierRow supRow = (citiAppDatabaseDataSet.supplierRow)supAdapter.GetDataBySupName(tboxSupplierName.Text).Rows[0];
                        supplierID = supRow.sup_IDno.ToString();

                        //insert sa purchase order
                        poAdapter.Insert(tboxPONumber.Text,
                            Convert.ToDateTime(POdateTimePicker.Text),
                            Convert.ToDateTime(DeliveryDateTimePicker.Text),
                            supplierID,
                            cboxBranch.Text,
                            "RGM", tboxTotal.Text);

                        //insert sa poDetails
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            citiAppDatabaseDataSet.poDetailsDataTable dt = poDetailsAdapter.GetData();
                            int poDetailsID = dt.Rows.Count;
                            poDetailsID = poDetailsID + 1;
                            int totalQty = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString()) + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());

                            poDetailsAdapter.Insert(poDetailsID.ToString("0000"),
                                dataGridView1.Rows[i].Cells[1].Value.ToString(),//model
                                dataGridView1.Rows[i].Cells[2].Value.ToString(),//ordered qty
                                dataGridView1.Rows[i].Cells[3].Value.ToString(),//free qty
                                dataGridView1.Rows[i].Cells[4].Value.ToString(),//cost
                                dataGridView1.Rows[i].Cells[5].Value.ToString(),//discount
                                dataGridView1.Rows[i].Cells[6].Value.ToString(),//total cost
                                tboxPONumber.Text,
                                dataGridView1.Rows[i].Cells[0].Value.ToString(),
                                 totalQty.ToString(),//totalQty
                                "pending",
                                totalQty.ToString(), 
                                totalQty.ToString());

                        }

                    }

                    //insert sa productlist, brand and model


                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        citiAppDatabaseDataSet.productListDataTable brandSupID = prodListAdapter.GetDataByBRANDmodelSUPID(supplierID, dataGridView1.Rows[i].Cells[7].Value.ToString(), dataGridView1.Rows[i].Cells[8].Value.ToString());

                        if (brandSupID.Rows.Count == 0)
                        {
                            citiAppDatabaseDataSet.productListDataTable dtID = prodListAdapter.GetData();

                            int prodLID = dtID.Rows.Count;

                            prodLID = prodLID + 1;

                            prodListAdapter.Insert(prodLID.ToString("00000"), supplierID, dataGridView1.Rows[i].Cells[4].Value.ToString(), dataGridView1.Rows[i].Cells[7].Value.ToString(), dataGridView1.Rows[i].Cells[8].Value.ToString());
                          
                           
                        }
                    }

                    MessageBox.Show("Purchase order successfully added.");
                    PurchaseOrderReport poR = new PurchaseOrderReport();
                    poR.poNumber = tboxPONumber.Text;
                    this.DialogResult = DialogResult.Yes;
                    poR.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cancelled purchase order.");
                }
            }
            else
            {
                MessageBox.Show("No products selected.");
            }
        }

        private void cboxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchAdapter = new citiAppDatabaseDataSetTableAdapters.branchTableAdapter();
            //citiAppDatabaseDataSet.branchRow bRow = (citiAppDatabaseDataSet.branchRow)branchAdapter.GetDataByBranchName(cboxBranch.Text).Rows[0];

            //branchID = bRow.branchNo.ToString();
        }

        private void gridPODetails_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            
       
        }

        private void gridPODetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double total;
                double totalDiscount;

                totalDiscount = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value.ToString()) * Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value.ToString());

                total = (Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value.ToString()) * Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value.ToString())) - totalDiscount;
                dataGridView1.CurrentRow.Cells[6].Value = total.ToString();
            }
            catch (Exception)
            {
              
            }
        }

        private void gridPODetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int x = dataGridView1.Rows.Count;
                double container = 0.00;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    int n = item.Index;

                    container = container + double.Parse(dataGridView1.Rows[n].Cells[6].Value.ToString());

                }

                tboxTotal.Text = container.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.productListTableAdapter productListAdapter = new citiAppDatabaseDataSetTableAdapters.productListTableAdapter();
            citiAppDatabaseDataSetTableAdapters.brandTableAdapter brandAdapter = new citiAppDatabaseDataSetTableAdapters.brandTableAdapter();
            citiAppDatabaseDataSetTableAdapters.modelTableAdapter modelAdapter = new citiAppDatabaseDataSetTableAdapters.modelTableAdapter();
        
           string price = "";
           

            //checker CheckBox
            if (cBoxBrand.Text.Length > 0 && cBoxModel.Text.Length > 0)
            {


                if (cBoxBrand.SelectedValue == null)
                {
                    citiAppDatabaseDataSet.brandDataTable brandDT = brandAdapter.GetData();
                    int counter = brandDT.Rows.Count + 1;
                    brand_ID = counter.ToString("000000");
                    brandAdapter.Insert(brand_ID, cBoxBrand.Text, supplierID);
                   
                }
                else
                {
                    brand_ID = cBoxBrand.SelectedValue.ToString();
                }

                if (cBoxModel.SelectedValue == null)
                {
                    citiAppDatabaseDataSet.modelDataTable modelDT = modelAdapter.GetData();
                    int counter = modelDT.Rows.Count + 1;
                    model_ID = counter.ToString("000000");
                    modelAdapter.Insert(model_ID, cBoxModel.Text, brand_ID);
                }
                else
                {
                    model_ID = cBoxModel.SelectedValue.ToString();
                   
                }

                citiAppDatabaseDataSet.productListDataTable pLdt = productListAdapter.GetDataByBRANDmodelSUPID(supplierID, brand_ID, model_ID);

                if (pLdt.Rows.Count == 1)
                {
                    citiAppDatabaseDataSet.productListRow pLRow = (citiAppDatabaseDataSet.productListRow)productListAdapter.GetDataByBRANDmodelSUPID(supplierID, brand_ID, model_ID).Rows[0];
                    price = pLRow.price;

                }
                else
                {
                    price = "0.00";
                }

                if (dataGridView1.Rows.Count == 0)
                {               
                    dataGridView1.Rows.Add(cBoxBrand.Text, cBoxModel.Text, "0", "0", price, "0", "0.00",brand_ID,model_ID);

                }
                else
                {

                    Boolean found = false;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value != null && cBoxModel.Text == dataGridView1.Rows[i].Cells[1].Value.ToString())
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
                        dataGridView1.Rows.Add(cBoxBrand.Text, cBoxModel.Text, "0", "0", price, "0", "0.00", brand_ID, model_ID);
                       
                    }
                  
                }
                this.brandTableAdapter.FillBySUPIDno(this.citiAppDatabaseDataSet.brand, supplierID);
                this.modelTableAdapter.FillByBrandID(this.citiAppDatabaseDataSet.model, cBoxBrand.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Invalid brand name.");
            }

          
           

        }

        private void tboxSupplierName_TextChanged(object sender, EventArgs e)
        {
            if (tboxSupplierName.Text.Length > 0)
            {
                btnUpdate_Save.Enabled = true;
                btnAddProduct.Enabled = true;
                dataGridView1.Enabled = true;
                cboxBranch.Enabled = true;
                cBoxBrand.Enabled = true;
                cBoxModel.Enabled = true;
                POdateTimePicker.Enabled = true;
                DeliveryDateTimePicker.Enabled = true;
            }
            else
            {
                btnUpdate_Save.Enabled = false;
                btnAddProduct.Enabled = false;
                dataGridView1.Enabled = false;
                cboxBranch.Enabled = false;
                cBoxBrand.Enabled = false;
                cBoxModel.Enabled = false;
                POdateTimePicker.Enabled = false;
                DeliveryDateTimePicker.Enabled = false;
            }
        }

        private void tboxSupplierName_Leave(object sender, EventArgs e)
        {

            citiAppDatabaseDataSetTableAdapters.productListTableAdapter productListAdapter = new citiAppDatabaseDataSetTableAdapters.productListTableAdapter();
            citiAppDatabaseDataSetTableAdapters.cBoxOutPutTableAdapter cboxOutAdapter = new citiAppDatabaseDataSetTableAdapters.cBoxOutPutTableAdapter();
            citiAppDatabaseDataSetTableAdapters.supplierTableAdapter supAdapter = new citiAppDatabaseDataSetTableAdapters.supplierTableAdapter();
            citiAppDatabaseDataSet.cBoxOutPutDataTable cBoxOutDT = new citiAppSystem.citiAppDatabaseDataSet.cBoxOutPutDataTable();
            citiAppDatabaseDataSet.supplierDataTable supplierDT = new citiAppSystem.citiAppDatabaseDataSet.supplierDataTable();
            citiAppDatabaseDataSet.supplierDataTable supIDdt = supAdapter.GetData();
            

            supplierDT = supAdapter.GetDataBySupName(tboxSupplierName.Text);
            if (supplierDT.Rows.Count.Equals(1))
            {
                citiAppDatabaseDataSet.supplierRow supRow = (citiAppDatabaseDataSet.supplierRow)supAdapter.GetDataBySupName(tboxSupplierName.Text).Rows[0];
                supplierID = supRow.sup_IDno.ToString();
                

                this.brandTableAdapter.FillBySUPIDno(this.citiAppDatabaseDataSet.brand, supplierID);
                cBoxBrand.Text = "";
            }
            else
            {
                int counter = supIDdt.Rows.Count + 1;
                supplierID = "SUP-" + counter.ToString("0000") + "-" + Global.process.branchID;
                
            }


            dataGridView1.Rows.Clear();
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows.Count.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatePrice up = new updatePrice();
            up.ShowDialog();
        }

        private void cBoxBrand_Leave(object sender, EventArgs e)
        {
            citiAppDatabaseDataSetTableAdapters.brandTableAdapter brandAdapter = new citiAppDatabaseDataSetTableAdapters.brandTableAdapter();
            //citiAppDatabaseDataSetTableAdapters.modelTableAdapter modelAdapter = new citiAppDatabaseDataSetTableAdapters.modelTableAdapter();
            citiAppDatabaseDataSet.brandDataTable brandDT = brandAdapter.GetDataByBrandANDsupID(cBoxBrand.Text, supplierID);


            brandDT = brandAdapter.GetDataByBrandANDsupID(cBoxBrand.Text, supplierID);

            if (cBoxBrand.SelectedValue == null)
            {

                this.modelTableAdapter.FillByBrandID(this.citiAppDatabaseDataSet.model, "");
            }
            else
            {
                this.modelTableAdapter.FillByBrandID(this.citiAppDatabaseDataSet.model, cBoxBrand.SelectedValue.ToString());
            }

            //citiAppDatabaseDataSet.brandDataTable brandIDdt = brandAdapter.GetData();



            //    DataTable dt;

            //    dt = modelAdapter.GetDataByBrandID(cBoxBrand.SelectedValue.ToString());
            //    cBoxModel.DataSource = dt;
            //    cBoxModel.DisplayMember = "modelName";
            //    cBoxBrand.ValueMember = "modelID";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }


    }
}
