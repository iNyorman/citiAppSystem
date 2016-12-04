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
    public partial class frmManageUpdateAccountNo : Form
    {
        BindingSource drBindingSource;
        BindingSource drDetailsBindingSource;
        BindingSource collectionDetailsBindingSource;
        private string currentAccountNo = "";
        private string currentNewAccountNo = "";
        private bool isFound;
        public frmManageUpdateAccountNo()
        {
            InitializeComponent();
            drBindingSource = new BindingSource();
            drDetailsBindingSource = new BindingSource();
            collectionDetailsBindingSource = new BindingSource();
        }

        private void frmManageUpdateAccountNo_Load(object sender, EventArgs e)
        {
           

        }

        private void populateDRGrid()
        {
            var a = ServiceLocator.Instance().DRServices().DrByAccountNo(currentAccountNo);
            if(a.Count != 0)
            {
                isFound = true;
                dgridDeliveryReceipt.AutoGenerateColumns = false;
                dgridDeliveryReceipt.DataSource = a.CopyToDataTable<DeliveryReceiptDatasets.deliveryReceiptRow>();
                lblNewAcount.Visible = true;
                tBoxNewAccountNo.Visible = true;
                
            }
            else
            {
                isFound = false;
                MessageBox.Show("No Data Found");
            }
         
           
        }
        private void populateDRDetailsGrid()
        {
            var a = ServiceLocator.Instance().DRServices().DRDetailsByAccountNo(currentAccountNo);
            drDetailsGrid.AutoGenerateColumns = false;
            drDetailsGrid.DataSource = a;
        }
        private void populateCollectionDetailsGrid()
        {
            var a = ServiceLocator.Instance().CollectionServices().CollectionDetails(currentAccountNo).CopyToDataTable<CollectionDatasets.collection_detailsRow>();
            dgridCollections.AutoGenerateColumns = false;
            dgridCollections.DataSource = a;
        }
        private void collection_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void tBoxAccountNo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
               if(!string.IsNullOrEmpty(tBoxAccountNo.Text))
                {
                    currentAccountNo = tBoxAccountNo.Text;
                    populateGrids();

                }

            }
        }

        private void populateGrids()
        {
            populateDRGrid();
            if (isFound)
            {
                populateDRDetailsGrid();
                populateCollectionDetailsGrid();
            }
        }

        private void tBoxNewAccountNo_KeyUp(object sender, KeyEventArgs e)
        {
            if(!string.IsNullOrEmpty(tBoxNewAccountNo.Text))
            {
                if(e.KeyData == Keys.Enter)
                {
                    currentNewAccountNo = tBoxNewAccountNo.Text;
                    var a = ServiceLocator.Instance().DRServices().DrByAccountNo(currentNewAccountNo);
                    if(a.Count >= 1)
                    {
                        tBoxNewAccountNo.BackColor = Color.Yellow;
                        btnUpdateAccount.Enabled = false;
                        
                    }
                    else
                    {
                        btnUpdateAccount.Enabled = true;
                        tBoxNewAccountNo.BackColor = Color.Green;
                    }
                }
            }
        }

        private void updateAccount()
        {
            ServiceLocator.Instance().DRServices().UpdateAccountNo(tBoxNewAccountNo.Text, currentAccountNo);
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Updating account number,proceed?","System",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                updateAccount();
                MessageBox.Show("Update Successful");
                currentAccountNo = currentNewAccountNo;
                populateDRGrid();
                tBoxAccountNo.Text = "";
                tBoxNewAccountNo.Text = "";
                tBoxNewAccountNo.BackColor = Color.White;
                btnUpdateAccount.Enabled = false;
            }
        }
    }
}
