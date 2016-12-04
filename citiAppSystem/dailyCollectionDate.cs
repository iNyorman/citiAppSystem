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
    public partial class dailyCollectionDate : MetroForm
    {
        public dailyCollectionDate()
        {
            InitializeComponent();
        }

        private void dailyCollectionDate_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dailyCollectionREPORTS dcr = new dailyCollectionREPORTS();
            dcr.startDate = dateTimePickerStart.Text;
            dcr.endDate = dateTimePickerEnd.Text;
            dcr.ShowDialog();
        }
    }
}
