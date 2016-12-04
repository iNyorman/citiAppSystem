using citiAppSystem.Modules.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citiAppSystem.Modules.Views.DelAccView
{
    public partial class frmDeleteAccount : Form
    {
        public frmDeleteAccount()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(tBoxAccountNo.Text))
                {
                    var getDrData = ServiceLocator.Instance().DRServices().DrByAccountNo(tBoxAccountNo.Text);
                    if (getDrData.Count > 0)
                    {
                        if (MessageBox.Show("Delete this AccountNo?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string deleteBy = "";
                            frmDeleteByModal deleteByModal = new frmDeleteByModal();
                            deleteByModal.NameInput += (obj) =>
                            {
                                deleteBy = obj;
                            };
                            deleteByModal.ShowDialog();
                            if (!string.IsNullOrEmpty(deleteBy))
                            {
                                var drDetailsList = ServiceLocator.Instance().DRServices().DRDetailsByAccountNo(tBoxAccountNo.Text);
                                foreach(var drdetails in drDetailsList)
                                {
                                    ServiceLocator.Instance().ProductServices().UpdateStatus("Available", drdetails.stockNo);
                                    if(string.IsNullOrEmpty(drdetails.stockNo))
                                    {
                                        ServiceLocator.Instance().DRServices().DeleteDrDetailsByPrimaryKey(drdetails.DR_Details_ID);
                                    }
                                }
                                ServiceLocator.Instance().AccDelTableService().DeleteAccount(tBoxAccountNo.Text);
                                ServiceLocator.Instance().AccDelTableService().Insert(new Models.AccDel()
                                {
                                    DelDateTime = System.DateTime.Now,
                                    DelBy = deleteBy,
                                    UserId = "-",
                                    AccountNo = tBoxAccountNo.Text
                                });
                                MessageBox.Show("Account Deleted");
                                tBoxAccountNo.Text = "";
                                var subParent = Application.OpenForms["frmDelAccView"] as frmDelAccView;
                                subParent.populateGrid();
                            }
                            else
                            {
                                MessageBox.Show("Name required.");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("No Data found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + ": " + ex.Message);
            }
        }

        private void deleteAccount()
        {

        }
    }
}
