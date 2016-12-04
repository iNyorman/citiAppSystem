using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace citiAppSystem
{
    public partial class productsReport : Form
    {

        public string parameter = "";
        public productsReport()
        {
            InitializeComponent();
        }

        private void productsReport_Load(object sender, EventArgs e)
        {

            //ReportDocument reportDocument = new ReportDocument();
            //ParameterField paramField = new ParameterField();
            //ParameterFields paramFields = new ParameterFields();
            //ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //paramField.Name = "@brand";

            //paramDiscreteValue.Value = parameter;
            //paramField.CurrentValues.Add(paramDiscreteValue);

            //paramFields.Add(paramField);


            //crystalReportViewer1.ParameterFieldInfo = paramFields;


            //reportDocument.Load(@"..\..\cryProducts.rpt");
            ////username, password,DSN,databasename, case sensitive
            ////reportDocument.SetDatabaseLogon("citiApplianceClient", "cac123", "JARVIS-PC", "citiAppDatabase", false);
            //reportDocument.SetDatabaseLogon("admin", "admin", "", "citiAppDatabase", false);
            //crystalReportViewer1.ReportSource = reportDocument;



            cryProducts productsReport = new cryProducts();

            citiAppDatabaseDataSetTableAdapters.productsTableAdapter productsAdapter = new citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
            DataTable dt = new DataTable();
            dt = productsAdapter.GetDataByBrandANDfromLOC(parameter, Global.branch.branchID);

            productsReport.SetDataSource(dt);
            crystalReportViewer1.ReportSource = productsReport;


 



        }

        private void cryProducts1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
