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

namespace citiAppSystem.Modules.Views.Management.Logs
{
    public partial class frmChangesLogs : Form
    {
        ChangesLogDatasets.ChangesLogDataTable logsTable;
        public frmChangesLogs()
        {
            InitializeComponent();
            logsTable = new ChangesLogDatasets.ChangesLogDataTable();
            cBoxType.SelectedIndex = 0;
            dtDateChange.Checked = false;
            populateGrid();
        }

        private void changesLogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void frmChangesLogs_Load(object sender, EventArgs e)
        {
    
        }
        
        private void populateGrid()
        {

            var list = ServiceLocator.Instance().ChangesLogs().List();
            if(cBoxType.Text != "All")
            {
                list = list.Where(x => x.changeType == cBoxType.Text).ToList();
            }
            if(!string.IsNullOrEmpty(tBoxDetails.Text))
            {
                list = list.Where(x => x.Details.ToLower().Contains(tBoxDetails.Text.ToLower())).ToList();
            }
            if(dtDateChange.Checked)
            {
                list = list.Where(x => x.dateChange.Date == dtDateChange.Value.Date).ToList();
            }
            if(timeChange.Checked)
            {
                list = list.Where(x => x.dateChange.TimeOfDay == timeChange.Value.TimeOfDay).ToList();
            }

            changesLogDataGridView.AutoGenerateColumns = false;
            changesLogDataGridView.DataSource = list;
        }

        private void cBoxType_SelectedValueChanged(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void tBoxDetails_TextChanged(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void dtDateChange_ValueChanged(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void timeChange_ValueChanged(object sender, EventArgs e)
        {
            populateGrid();
        }
    }
}
