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
    public partial class BranchSelect : MetroForm 
    {
        public BranchSelect()
        {
            InitializeComponent();
        }

        private void BranchSelect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiAppDatabaseDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.citiAppDatabaseDataSet.branch);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            stockListREPORT sl = new stockListREPORT();
            sl.branchNo = comboBox1.SelectedValue.ToString();
            sl.Show();
            this.Hide();
        }
    }
}
