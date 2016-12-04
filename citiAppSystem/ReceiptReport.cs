using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    
    public partial class ReceiptReport : Form
    {

        public string parameter = "";
        public string accountType = "";
        public string ReceiptType = "";
        public ReceiptReport()
        {
            InitializeComponent();
        }

        private void ReceiptReport_Load(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            ParameterField paramField = new ParameterField();
            ParameterFields paramFields = new ParameterFields();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

           

            paramField.Name = "@oRNO";

            paramDiscreteValue.Value = parameter;
            paramField.CurrentValues.Add(paramDiscreteValue);

            paramFields.Add(paramField);

            citiAppDatabaseDataSetTableAdapters.selectQueryReceiptByORTableAdapter cRAdapter = new citiAppDatabaseDataSetTableAdapters.selectQueryReceiptByORTableAdapter();
            DataTable dt = new DataTable();

           


            if (ReceiptType == "CR")
            {
                if (accountType == "Cash Sales Invoice")
                {
                    cryReceiptCR cr = new cryReceiptCR();
                    dt = cRAdapter.GetDataByOR(parameter);
                    cr.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = cr;

                   
                }
                else
                {
                    cryReceiptCRInstallment crInt = new cryReceiptCRInstallment();

                    dt = cRAdapter.GetDataByOR(parameter);
                    crInt.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = crInt;

                  
                }
           


            }
            else if (ReceiptType == "COLR")
            {


                if (accountType == "Cash Sales Invoice")
                {
                    cryReceiptCLR clr = new cryReceiptCLR();
                    dt = cRAdapter.GetDataByOR(parameter);
                    clr.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = clr;

                }
                else
                {
                    cryReceiptCLRInstallment clrInt = new cryReceiptCLRInstallment();
                    dt = cRAdapter.GetDataByOR(parameter);
                    clrInt.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = clrInt;
                }
            }
          
            //crystalReportViewer1.ParameterFieldInfo = paramFields;
            //if (accountType == "Cash Sales Invoice")
            //{
            //    reportDocument.Load(@"..\..\cryReceipt.rpt");
            //    //username, password,DSN,databasename, case sensitive
             
            //    reportDocument.SetDatabaseLogon("citiApplianceClient", "cac123", "JARVIS-PC", "citiAppDatabase", false);
            //    crystalReportViewer1.ReportSource = reportDocument;
            //}

            //else
            //{
            //    reportDocument.Load(@"..\..\cryReceiptMonthly.rpt");
            //    //username, password,DSN,databasename, case sensitive
            //    reportDocument.SetDatabaseLogon("citiApplianceClient", "cac123", "JARVIS-PC", "citiAppDatabase", false);
            //    crystalReportViewer1.ReportSource = reportDocument;
            //}

           
        }
    }
}
