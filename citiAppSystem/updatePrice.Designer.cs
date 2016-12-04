namespace citiAppSystem
{
    partial class updatePrice
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
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.cboxSupplierName = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboxBrand = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboxModel = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tboxCurrentPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tboxNewPrice = new MetroFramework.Controls.MetroTextBox();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Save = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supplierTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.supplierTableAdapter();
            this.brandTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.brandTableAdapter();
            this.modelTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.modelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.gboxOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -176;
            this.lineShape2.X2 = 1094;
            this.lineShape2.Y1 = 1;
            this.lineShape2.Y2 = 1;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -171;
            this.lineShape1.X2 = 1099;
            this.lineShape1.Y1 = 6;
            this.lineShape1.Y2 = 6;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(427, 431);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // cboxSupplierName
            // 
            this.cboxSupplierName.DataSource = this.supplierBindingSource;
            this.cboxSupplierName.DisplayMember = "sName";
            this.cboxSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSupplierName.FormattingEnabled = true;
            this.cboxSupplierName.Location = new System.Drawing.Point(70, 62);
            this.cboxSupplierName.Name = "cboxSupplierName";
            this.cboxSupplierName.Size = new System.Drawing.Size(245, 21);
            this.cboxSupplierName.TabIndex = 28;
            this.cboxSupplierName.ValueMember = "sup_IDno";
            this.cboxSupplierName.SelectedIndexChanged += new System.EventHandler(this.cboxSupplierName_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(70, 40);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "Supplier Name :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(70, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Brand :";
            // 
            // cboxBrand
            // 
            this.cboxBrand.DataSource = this.brandBindingSource;
            this.cboxBrand.DisplayMember = "brandName";
            this.cboxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBrand.Enabled = false;
            this.cboxBrand.FormattingEnabled = true;
            this.cboxBrand.Location = new System.Drawing.Point(70, 111);
            this.cboxBrand.Name = "cboxBrand";
            this.cboxBrand.Size = new System.Drawing.Size(245, 21);
            this.cboxBrand.TabIndex = 30;
            this.cboxBrand.ValueMember = "brandID";
            this.cboxBrand.SelectedIndexChanged += new System.EventHandler(this.cboxBrand_SelectedIndexChanged);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(70, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "Model :";
            // 
            // cboxModel
            // 
            this.cboxModel.DataSource = this.modelBindingSource;
            this.cboxModel.DisplayMember = "modelName";
            this.cboxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModel.Enabled = false;
            this.cboxModel.FormattingEnabled = true;
            this.cboxModel.Location = new System.Drawing.Point(70, 173);
            this.cboxModel.Name = "cboxModel";
            this.cboxModel.Size = new System.Drawing.Size(245, 21);
            this.cboxModel.TabIndex = 32;
            this.cboxModel.ValueMember = "modelID";
            this.cboxModel.SelectedIndexChanged += new System.EventHandler(this.cboxModel_SelectedIndexChanged);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "model";
            this.modelBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // tboxCurrentPrice
            // 
            this.tboxCurrentPrice.Enabled = false;
            this.tboxCurrentPrice.Lines = new string[0];
            this.tboxCurrentPrice.Location = new System.Drawing.Point(70, 234);
            this.tboxCurrentPrice.MaxLength = 32767;
            this.tboxCurrentPrice.Name = "tboxCurrentPrice";
            this.tboxCurrentPrice.PasswordChar = '\0';
            this.tboxCurrentPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxCurrentPrice.SelectedText = "";
            this.tboxCurrentPrice.Size = new System.Drawing.Size(242, 28);
            this.tboxCurrentPrice.TabIndex = 34;
            this.tboxCurrentPrice.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(70, 212);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "Current Price :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(70, 274);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "New Price :";
            // 
            // tboxNewPrice
            // 
            this.tboxNewPrice.Lines = new string[0];
            this.tboxNewPrice.Location = new System.Drawing.Point(70, 296);
            this.tboxNewPrice.MaxLength = 32767;
            this.tboxNewPrice.Name = "tboxNewPrice";
            this.tboxNewPrice.PasswordChar = '\0';
            this.tboxNewPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxNewPrice.SelectedText = "";
            this.tboxNewPrice.Size = new System.Drawing.Size(242, 28);
            this.tboxNewPrice.TabIndex = 36;
            this.tboxNewPrice.UseSelectable = true;
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.btnUpdate_Save);
            this.gboxOptions.Controls.Add(this.btnBack);
            this.gboxOptions.Location = new System.Drawing.Point(23, 439);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(400, 68);
            this.gboxOptions.TabIndex = 38;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Options";
            // 
            // btnUpdate_Save
            // 
            this.btnUpdate_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate_Save.Location = new System.Drawing.Point(226, 19);
            this.btnUpdate_Save.Name = "btnUpdate_Save";
            this.btnUpdate_Save.Size = new System.Drawing.Size(147, 34);
            this.btnUpdate_Save.TabIndex = 7;
            this.btnUpdate_Save.Text = "Save";
            this.btnUpdate_Save.UseSelectable = true;
            this.btnUpdate_Save.Click += new System.EventHandler(this.btnUpdate_Save_Click);
            // 
            // btnBack
            // 
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(16, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 34);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.cboxSupplierName);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.cboxBrand);
            this.groupBox1.Controls.Add(this.tboxNewPrice);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.cboxModel);
            this.groupBox1.Controls.Add(this.tboxCurrentPrice);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(29, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 355);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information";
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // updatePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 511);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxOptions);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "updatePrice";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.updatePrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.gboxOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.ComboBox cboxSupplierName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cboxBrand;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cboxModel;
        private MetroFramework.Controls.MetroTextBox tboxCurrentPrice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tboxNewPrice;
        private System.Windows.Forms.GroupBox gboxOptions;
        private MetroFramework.Controls.MetroButton btnUpdate_Save;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private citiAppDatabaseDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private citiAppDatabaseDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private citiAppDatabaseDataSetTableAdapters.modelTableAdapter modelTableAdapter;
    }
}