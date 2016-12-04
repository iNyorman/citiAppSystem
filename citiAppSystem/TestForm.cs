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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void TestForm_Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add("PO_ID",typeof(String));
            dt.Columns.Add("Quantity", typeof(Int32));

                     

                     dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dt.Rows.Add("0001", 5);

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr.BeginEdit();
            dr[0] = "";
            dr.EndEdit();
                       
        }
    }
}
