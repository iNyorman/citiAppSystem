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
    public partial class collDateUpdate : MetroForm
    {
        public collDateUpdate()
        {
            InitializeComponent();
        }

        public string date = "";

        private void collDateUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Global.process.dateForCollections = dateTimePickerUpdateDate.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
