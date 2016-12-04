namespace citiAppSystem.Modules.Reports
{
    partial class frmLedgerReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.LedgerHeaderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DR_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collection_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerHeaderModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DR_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collection_detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LedgerHeaderModelBindingSource
            // 
            this.LedgerHeaderModelBindingSource.DataSource = typeof(citiAppSystem.Modules.Models.EF.Classes.LedgerHeaderModel);
            // 
            // DR_detailsBindingSource
            // 
            this.DR_detailsBindingSource.DataSource = typeof(citiAppSystem.Modules.Models.EF.DR_details);
            // 
            // collection_detailsBindingSource
            // 
            this.collection_detailsBindingSource.DataSource = typeof(citiAppSystem.Modules.Models.EF.collection_details);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LedgerHeader";
            reportDataSource1.Value = this.LedgerHeaderModelBindingSource;
            reportDataSource2.Name = "drDetails";
            reportDataSource2.Value = this.DR_detailsBindingSource;
            reportDataSource3.Name = "CollectionDetails";
            reportDataSource3.Value = this.collection_detailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "citiAppSystem.Modules.Reports.LedgerReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(886, 626);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmLedgerReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 626);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLedgerReportView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger Report";
            this.Load += new System.EventHandler(this.frmLedgerReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LedgerHeaderModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DR_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collection_detailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource LedgerHeaderModelBindingSource;
        private System.Windows.Forms.BindingSource DR_detailsBindingSource;
        private System.Windows.Forms.BindingSource collection_detailsBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}