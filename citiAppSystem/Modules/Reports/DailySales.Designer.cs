namespace citiAppSystem.Modules.Reports
{
    partial class DailySales
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dailySalesDatasetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailySalesDatasets = new citiAppSystem.Modules.Datasets.dailySalesDatasets();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dailySalesDatasetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailySalesDatasets)).BeginInit();
            this.SuspendLayout();
            // 
            // dailySalesDatasetsBindingSource
            // 
            this.dailySalesDatasetsBindingSource.DataSource = this.dailySalesDatasets;
            this.dailySalesDatasetsBindingSource.Position = 0;
            // 
            // dailySalesDatasets
            // 
            this.dailySalesDatasets.DataSetName = "dailySalesDatasets";
            this.dailySalesDatasets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.dailySalesDatasetsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "citiAppSystem.Modules.Reports.DailySales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(785, 684);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.WaitControlDisplayAfter = 2000;
            // 
            // DailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 684);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailySales";
            this.Text = "DailySales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DailySales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailySalesDatasetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailySalesDatasets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dailySalesDatasetsBindingSource;
        private Datasets.dailySalesDatasets dailySalesDatasets;
    }
}