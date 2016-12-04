using citiAppSystem.Modules.Views;
using citiAppSystem.Modules.Views.Cashiers;
using citiAppSystem.Modules.Views.DelAccView;
using citiAppSystem.Modules.Views.Management.Account;
using citiAppSystem.Modules.Views.Management.Logs;
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
    public partial class Form1 : MetroForm
    {
        public string CurrentBranchNo = "";
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            companyProfileToolStripMenuItem.Text = "Company Profile "+"(Branch Code :"+Global.process.branchID+")";
            if (Global.process.role == "Cashier")
            {
                inventoryToolStripMenuItem.Visible = false;
                userToolStripMenuItem.Visible = false;
                dailySalesReportsToolStripMenuItem.Visible = false;
                stockReportsToolStripMenuItem.Visible = false;
                deliveryToolStripMenuItem.Visible = false;
                customerCenterToolStripMenuItem.Visible = false;
                //-----------------------------temporary disable ----------------------//
                updateAccountToolStripMenuItem.Visible = false;
            }
            else if (Global.process.role == "Manager")
            {
                salesToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;
                userToolStripMenuItem.Visible = false;
                productToolStripMenuItem.Visible = false;
                btnCustomer.Visible = false;
                btnNewDelivery.Visible= false;
                btnNewTransation.Visible = false;

            }
            else if (Global.process.role == "Stocks")
            {

                if (Global.process.branchID == "02")
                {
                    purchaseOrderToolStripMenuItem.Visible = true;
                }
                else
                {
                    purchaseOrderToolStripMenuItem.Visible = false;
                }
                salesToolStripMenuItem.Visible = false;
                btnCustomer.Visible = false;
                btnNewDelivery.Visible = false;
                btnNewTransation.Visible = false;
                
                supplierToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;
                userToolStripMenuItem.Visible = false;
            }
            else if (Global.process.role == "Encoder")
            {
                
                dailyCollectionReportsToolStripMenuItem.Visible = false;
                userToolStripMenuItem.Visible = false;
                productToolStripMenuItem.Visible = false;
                inventoryToolStripMenuItem.Visible = false;
                cashierToolStripMenuItem.Visible = false;
                stockReportsToolStripMenuItem.Visible = false;
                customerCenterToolStripMenuItem.Visible = false;
                btnNewDelivery.SetBounds(22, 233, 378, 138);
                btnNewDelivery.Visible = true;
            }
            else if (Global.process.role == "C&C")
            {
                userToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;
                inventoryToolStripMenuItem.Visible = false;
                customerCenterToolStripMenuItem.Visible = false;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                customerView cV = new customerView();
                cV.ShowDialog();
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deliveryView dv = new deliveryView();
            dv.ShowDialog();
        }

        private void metroTileDeliveryView_Click(object sender, EventArgs e)
        {

            Global.process.CustomerclickFrom = "Add";
            Global.process.stepsFROMcustomer = "1";
            CustomerForms.add_updateCustomer aUCustomer = new CustomerForms.add_updateCustomer();
            aUCustomer.fromForm1 = true;
            aUCustomer.ShowDialog();
            
            
        }

        private void collectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            customerView cV = new customerView();
            cV.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            deliveryView dR = new deliveryView();
            dR.ShowDialog();
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void branchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void branchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            branchView bV = new branchView();
            bV.ShowDialog();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userView uV = new userView();
            uV.ShowDialog();
        }

        private void purchaseOrderViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplierView sv = new supplierView();
            sv.ShowDialog();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseOrderView pov = new purchaseOrderView();
            pov.ShowDialog();
        }

        private void customerCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountsList list = new frmAccountsList();
            list.ShowDialog();
        }

        private void dailySalesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dailySalesDate dsD = new dailySalesDate();
            dsD.ShowDialog();
        }

        private void dailyCollectionReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DC_REPORTS dc = new DC_REPORTS();
            dc.ShowDialog();
        }

        private void addUpdateProdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.process.selectProdFromDR = "View";
            productsView pV = new productsView();
            pV.ShowDialog();
        }

        private void transferProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferList tl = new TransferList();
            tl.ShowDialog();
        }

        private void directAddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void companyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyProfile cp = new CompanyProfile();
            cp.ShowDialog();
        }

        private void stockReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockListREPORT slr = new stockListREPORT();
            if (Global.process.branchID == "02")
            {
                BranchSelect bs = new BranchSelect();
             
                bs.ShowDialog();
                
            }
            else
            {
                slr.branchNo = Global.process.branchID;
                slr.ShowDialog();
            }
           
        }

        private void cashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           cashierNew cs = new cashierNew();
            cs.ShowDialog();
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateAcctNo ua = new updateAcctNo();
            ua.ShowDialog();
        }

        private void productsInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductList a = new frmProductList();
            
            a.ShowDialog();
        }

        private void changeStockNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUpdateStock manage = new frmManageUpdateStock();
            manage.ShowDialog();
        }

        private void changeAccountNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUpdateAccountNo frmAcount = new frmManageUpdateAccountNo();
            frmAcount.ShowDialog();
        }

        private void changesLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangesLogs logs = new frmChangesLogs();
            logs.ShowDialog();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDelAccView DelAccView = new frmDelAccView();
            DelAccView.ShowDialog();
        }
    }
}
