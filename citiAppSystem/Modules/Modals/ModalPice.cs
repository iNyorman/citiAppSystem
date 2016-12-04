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
    public partial class ModalPice : Form
    {
        public Action<string> SelectedPrice { get; set; }
        public ModalPice()
        {
            InitializeComponent();
        }

        private void ModalPice_Load(object sender, EventArgs e)
        {

        }

        private void commitPrice()
        {
            SelectedPrice(numericPRice.Value.ToString());
            this.Close();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            commitPrice();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                commitPrice();
            }
            base.OnKeyPress(e);
        }
    }
}
