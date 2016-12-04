namespace citiAppSystem
{
    partial class stockTransfer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridProductLIST = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.cBoxFilter = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCount = new MetroFramework.Controls.MetroLabel();
            this.tboxReleasedBy = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tboxReceivedBy = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cboxTransferLocation = new MetroFramework.Controls.MetroComboBox();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gridTransfer = new System.Windows.Forms.DataGridView();
            this.StockNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnTransfer = new MetroFramework.Controls.MetroButton();
            this.btnAddProduct = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.branchTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.branchTableAdapter();
            this.freeProductViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.free_Product_ViewTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.Free_Product_ViewTableAdapter();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tboxSTNo = new MetroFramework.Controls.MetroTextBox();
            this.cboxCurrentLocation = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductLIST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfer)).BeginInit();
            this.gboxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freeProductViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -236;
            this.lineShape2.X2 = 1210;
            this.lineShape2.Y1 = 5;
            this.lineShape2.Y2 = 5;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -235;
            this.lineShape1.X2 = 1228;
            this.lineShape1.Y1 = 2;
            this.lineShape1.Y2 = 1;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(1190, 518);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridProductLIST);
            this.groupBox1.Location = new System.Drawing.Point(18, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1207, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // gridProductLIST
            // 
            this.gridProductLIST.AllowUserToAddRows = false;
            this.gridProductLIST.AllowUserToDeleteRows = false;
            this.gridProductLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductLIST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridProductLIST.Location = new System.Drawing.Point(5, 19);
            this.gridProductLIST.Name = "gridProductLIST";
            this.gridProductLIST.ReadOnly = true;
            this.gridProductLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductLIST.Size = new System.Drawing.Size(1192, 157);
            this.gridProductLIST.TabIndex = 0;
            this.gridProductLIST.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridProductLIST_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "stockNo";
            this.Column1.HeaderText = "StockNo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Brand";
            this.Column2.HeaderText = "Brand";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Serial";
            this.Column3.HeaderText = "Serial";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Model";
            this.Column4.HeaderText = "Model";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Status";
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(846, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Current Location :";
            // 
            // tboxSearch
            // 
            this.tboxSearch.Lines = new string[0];
            this.tboxSearch.Location = new System.Drawing.Point(274, 119);
            this.tboxSearch.MaxLength = 32767;
            this.tboxSearch.Multiline = true;
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.PasswordChar = '\0';
            this.tboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSearch.SelectedText = "";
            this.tboxSearch.Size = new System.Drawing.Size(295, 29);
            this.tboxSearch.TabIndex = 30;
            this.tboxSearch.UseSelectable = true;
            this.tboxSearch.TextChanged += new System.EventHandler(this.tboxSearch_TextChanged);
            // 
            // cBoxFilter
            // 
            this.cBoxFilter.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cBoxFilter.FormattingEnabled = true;
            this.cBoxFilter.ItemHeight = 19;
            this.cBoxFilter.Items.AddRange(new object[] {
            "Stock Number",
            "Serial",
            "Model",
            "Brand"});
            this.cBoxFilter.Location = new System.Drawing.Point(109, 122);
            this.cBoxFilter.Name = "cBoxFilter";
            this.cBoxFilter.Size = new System.Drawing.Size(159, 25);
            this.cBoxFilter.TabIndex = 29;
            this.cBoxFilter.UseSelectable = true;
            this.cBoxFilter.SelectedIndexChanged += new System.EventHandler(this.cBoxFilter_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(27, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "SEARCH:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Controls.Add(this.tboxReleasedBy);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.tboxReceivedBy);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.cboxTransferLocation);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.gridTransfer);
            this.groupBox2.Location = new System.Drawing.Point(18, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1207, 182);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer Products";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCount.Location = new System.Drawing.Point(759, 16);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(47, 19);
            this.lblCount.TabIndex = 39;
            this.lblCount.Text = "0 / 25";
            // 
            // tboxReleasedBy
            // 
            this.tboxReleasedBy.Lines = new string[0];
            this.tboxReleasedBy.Location = new System.Drawing.Point(477, 12);
            this.tboxReleasedBy.MaxLength = 32767;
            this.tboxReleasedBy.Name = "tboxReleasedBy";
            this.tboxReleasedBy.PasswordChar = '\0';
            this.tboxReleasedBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxReleasedBy.SelectedText = "";
            this.tboxReleasedBy.Size = new System.Drawing.Size(242, 28);
            this.tboxReleasedBy.TabIndex = 35;
            this.tboxReleasedBy.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(374, 20);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(98, 19);
            this.metroLabel7.TabIndex = 34;
            this.metroLabel7.Text = "Released By :";
            // 
            // tboxReceivedBy
            // 
            this.tboxReceivedBy.Lines = new string[0];
            this.tboxReceivedBy.Location = new System.Drawing.Point(119, 13);
            this.tboxReceivedBy.MaxLength = 32767;
            this.tboxReceivedBy.Name = "tboxReceivedBy";
            this.tboxReceivedBy.PasswordChar = '\0';
            this.tboxReceivedBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxReceivedBy.SelectedText = "";
            this.tboxReceivedBy.Size = new System.Drawing.Size(242, 28);
            this.tboxReceivedBy.TabIndex = 33;
            this.tboxReceivedBy.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(16, 21);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(99, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Received By :";
            // 
            // cboxTransferLocation
            // 
            this.cboxTransferLocation.DataSource = this.branchBindingSource;
            this.cboxTransferLocation.DisplayMember = "branchName";
            this.cboxTransferLocation.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboxTransferLocation.FormattingEnabled = true;
            this.cboxTransferLocation.ItemHeight = 19;
            this.cboxTransferLocation.Location = new System.Drawing.Point(932, 14);
            this.cboxTransferLocation.Name = "cboxTransferLocation";
            this.cboxTransferLocation.Size = new System.Drawing.Size(269, 25);
            this.cboxTransferLocation.TabIndex = 31;
            this.cboxTransferLocation.UseSelectable = true;
            this.cboxTransferLocation.ValueMember = "branchNo";
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "branch";
            this.branchBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(833, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Transfer To :";
            // 
            // gridTransfer
            // 
            this.gridTransfer.AllowUserToAddRows = false;
            this.gridTransfer.AllowUserToDeleteRows = false;
            this.gridTransfer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockNo,
            this.Brand,
            this.model,
            this.SerialNo,
            this.status});
            this.gridTransfer.Location = new System.Drawing.Point(5, 45);
            this.gridTransfer.Name = "gridTransfer";
            this.gridTransfer.ReadOnly = true;
            this.gridTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransfer.Size = new System.Drawing.Size(1196, 131);
            this.gridTransfer.TabIndex = 0;
            // 
            // StockNo
            // 
            this.StockNo.DataPropertyName = "stockNo";
            this.StockNo.HeaderText = "StockNo";
            this.StockNo.Name = "StockNo";
            this.StockNo.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // model
            // 
            this.model.DataPropertyName = "Model";
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // SerialNo
            // 
            this.SerialNo.DataPropertyName = "Serial";
            this.SerialNo.HeaderText = "Serial No";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.btnRemove);
            this.gboxOptions.Controls.Add(this.btnTransfer);
            this.gboxOptions.Controls.Add(this.btnAddProduct);
            this.gboxOptions.Controls.Add(this.btnBack);
            this.gboxOptions.Controls.Add(this.btnClear);
            this.gboxOptions.Location = new System.Drawing.Point(18, 522);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(1204, 68);
            this.gboxOptions.TabIndex = 32;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Options";
            // 
            // btnRemove
            // 
            this.btnRemove.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRemove.Location = new System.Drawing.Point(748, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(147, 34);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove Product";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTransfer.Location = new System.Drawing.Point(1051, 19);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(147, 34);
            this.btnTransfer.TabIndex = 7;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseSelectable = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddProduct.Location = new System.Drawing.Point(595, 19);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(147, 34);
            this.btnAddProduct.TabIndex = 21;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseSelectable = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
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
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.Location = new System.Drawing.Point(901, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 34);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // freeProductViewBindingSource
            // 
            this.freeProductViewBindingSource.DataMember = "Free Product View";
            this.freeProductViewBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // free_Product_ViewTableAdapter
            // 
            this.free_Product_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(27, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(137, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Stock Transfer No :";
            // 
            // tboxSTNo
            // 
            this.tboxSTNo.Lines = new string[0];
            this.tboxSTNo.Location = new System.Drawing.Point(170, 73);
            this.tboxSTNo.MaxLength = 32767;
            this.tboxSTNo.Name = "tboxSTNo";
            this.tboxSTNo.PasswordChar = '\0';
            this.tboxSTNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSTNo.SelectedText = "";
            this.tboxSTNo.Size = new System.Drawing.Size(295, 29);
            this.tboxSTNo.TabIndex = 35;
            this.tboxSTNo.UseSelectable = true;
            this.tboxSTNo.Leave += new System.EventHandler(this.tboxSTNo_Leave);
            // 
            // cboxCurrentLocation
            // 
            this.cboxCurrentLocation.FormattingEnabled = true;
            this.cboxCurrentLocation.Location = new System.Drawing.Point(980, 119);
            this.cboxCurrentLocation.Name = "cboxCurrentLocation";
            this.cboxCurrentLocation.Size = new System.Drawing.Size(241, 21);
            this.cboxCurrentLocation.TabIndex = 38;
            this.cboxCurrentLocation.SelectedIndexChanged += new System.EventHandler(this.cboxCurrentLocation_SelectedIndexChanged);
            this.cboxCurrentLocation.SelectionChangeCommitted += new System.EventHandler(this.cboxCurrentLocation_SelectionChangeCommitted);
            // 
            // stockTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 598);
            this.Controls.Add(this.cboxCurrentLocation);
            this.Controls.Add(this.tboxSTNo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.gboxOptions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.cBoxFilter);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Movable = false;
            this.Name = "stockTransfer";
            this.Text = "Stock Transfer";
            this.Load += new System.EventHandler(this.stockTransfer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductLIST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfer)).EndInit();
            this.gboxOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.freeProductViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView gridProductLIST;
        private MetroFramework.Controls.MetroTextBox tboxSearch;
        private MetroFramework.Controls.MetroComboBox cBoxFilter;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridTransfer;
        private MetroFramework.Controls.MetroComboBox cboxTransferLocation;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox gboxOptions;
        private MetroFramework.Controls.MetroButton btnTransfer;
        private MetroFramework.Controls.MetroButton btnAddProduct;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnClear;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchTableAdapter;
        private System.Windows.Forms.BindingSource freeProductViewBindingSource;
        private citiAppDatabaseDataSetTableAdapters.Free_Product_ViewTableAdapter free_Product_ViewTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tboxSTNo;
        private MetroFramework.Controls.MetroTextBox tboxReleasedBy;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tboxReceivedBy;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ComboBox cboxCurrentLocation;
        private MetroFramework.Controls.MetroLabel lblCount;
        private MetroFramework.Controls.MetroButton btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;

    }
}