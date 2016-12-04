using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace citiAppSystem.Modules.Modals
{
    public partial class frmDeleteByModal : Form
    {
        public Action<string> NameInput { get; set; }
        public frmDeleteByModal()
        {
            InitializeComponent();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                NameInput(textBox1.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Name is required");
            }
        }
    }
}
