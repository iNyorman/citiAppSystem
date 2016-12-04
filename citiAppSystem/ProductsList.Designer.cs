namespace citiAppSystem
{
    partial class ProductsList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridViewInventory = new System.Windows.Forms.DataGridView();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockListReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.stockListReportTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.stockListReportTableAdapter();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewProdDetails = new System.Windows.Forms.DataGridView();
            this.stockNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet1 = new citiAppSystem.citiAppDatabaseDataSet();
            this.productsTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxStockNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockListReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridViewInventory);
            this.groupBox1.Location = new System.Drawing.Point(23, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products Inventory";
            // 
            // gridViewInventory
            // 
            this.gridViewInventory.AllowUserToAddRows = false;
            this.gridViewInventory.AllowUserToDeleteRows = false;
            this.gridViewInventory.AutoGenerateColumns = false;
            this.gridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.branchNameDataGridViewTextBoxColumn,
            this.locToDataGridViewTextBoxColumn});
            this.gridViewInventory.DataSource = this.stockListReportBindingSource;
            this.gridViewInventory.Location = new System.Drawing.Point(3, 14);
            this.gridViewInventory.Name = "gridViewInventory";
            this.gridViewInventory.ReadOnly = true;
            this.gridViewInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewInventory.Size = new System.Drawing.Size(991, 251);
            this.gridViewInventory.TabIndex = 0;
            this.gridViewInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchNameDataGridViewTextBoxColumn
            // 
            this.branchNameDataGridViewTextBoxColumn.DataPropertyName = "branchName";
            this.branchNameDataGridViewTextBoxColumn.HeaderText = "branchName";
            this.branchNameDataGridViewTextBoxColumn.Name = "branchNameDataGridViewTextBoxColumn";
            this.branchNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locToDataGridViewTextBoxColumn
            // 
            this.locToDataGridViewTextBoxColumn.DataPropertyName = "loc_To";
            this.locToDataGridViewTextBoxColumn.HeaderText = "loc_To";
            this.locToDataGridViewTextBoxColumn.Name = "locToDataGridViewTextBoxColumn";
            this.locToDataGridViewTextBoxColumn.ReadOnly = true;
            this.locToDataGridViewTextBoxColumn.Visible = false;
            // 
            // stockListReportBindingSource
            // 
            this.stockListReportBindingSource.DataMember = "stockListReport";
            this.stockListReportBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockListReportTableAdapter
            // 
            this.stockListReportTableAdapter.ClearBeforeFill = true;
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Location = new System.Drawing.Point(105, 85);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(211, 20);
            this.tBoxSearch.TabIndex = 1;
            this.tBoxSearch.TextChanged += new System.EventHandler(this.tBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SEARCH:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(498, 85);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(170, 25);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViewProdDetails);
            this.groupBox2.Location = new System.Drawing.Point(26, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1004, 258);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products Details";
            // 
            // gridViewProdDetails
            // 
            this.gridViewProdDetails.AllowUserToAddRows = false;
            this.gridViewProdDetails.AllowUserToDeleteRows = false;
            this.gridViewProdDetails.AutoGenerateColumns = false;
            this.gridViewProdDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewProdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProdDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNoDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn1,
            this.serialNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.prodStatusDataGridViewTextBoxColumn,
            this.deliveryNoDataGridViewTextBoxColumn,
            this.dateReceivedDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.branchNoDataGridViewTextBoxColumn,
            this.branchNo,
            this.Column1});
            this.gridViewProdDetails.DataSource = this.productsBindingSource;
            this.gridViewProdDetails.Location = new System.Drawing.Point(3, 14);
            this.gridViewProdDetails.Name = "gridViewProdDetails";
            this.gridViewProdDetails.ReadOnly = true;
            this.gridViewProdDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewProdDetails.Size = new System.Drawing.Size(988, 241);
            this.gridViewProdDetails.TabIndex = 0;
            this.gridViewProdDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewProdDetails_CellClick);
            // 
            // stockNoDataGridViewTextBoxColumn
            // 
            this.stockNoDataGridViewTextBoxColumn.DataPropertyName = "stockNo";
            this.stockNoDataGridViewTextBoxColumn.HeaderText = "stockNo";
            this.stockNoDataGridViewTextBoxColumn.Name = "stockNoDataGridViewTextBoxColumn";
            this.stockNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn1
            // 
            this.brandDataGridViewTextBoxColumn1.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn1.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn1.Name = "brandDataGridViewTextBoxColumn1";
            this.brandDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn1
            // 
            this.modelDataGridViewTextBoxColumn1.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn1.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn1.Name = "modelDataGridViewTextBoxColumn1";
            this.modelDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "serialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "serialNo";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodStatusDataGridViewTextBoxColumn
            // 
            this.prodStatusDataGridViewTextBoxColumn.DataPropertyName = "prodStatus";
            this.prodStatusDataGridViewTextBoxColumn.HeaderText = "prodStatus";
            this.prodStatusDataGridViewTextBoxColumn.Name = "prodStatusDataGridViewTextBoxColumn";
            this.prodStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryNoDataGridViewTextBoxColumn
            // 
            this.deliveryNoDataGridViewTextBoxColumn.DataPropertyName = "deliveryNo";
            this.deliveryNoDataGridViewTextBoxColumn.HeaderText = "deliveryNo";
            this.deliveryNoDataGridViewTextBoxColumn.Name = "deliveryNoDataGridViewTextBoxColumn";
            this.deliveryNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateReceivedDataGridViewTextBoxColumn
            // 
            this.dateReceivedDataGridViewTextBoxColumn.DataPropertyName = "date_Received";
            this.dateReceivedDataGridViewTextBoxColumn.HeaderText = "date_Received";
            this.dateReceivedDataGridViewTextBoxColumn.Name = "dateReceivedDataGridViewTextBoxColumn";
            this.dateReceivedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchNoDataGridViewTextBoxColumn
            // 
            this.branchNoDataGridViewTextBoxColumn.DataPropertyName = "branchNo";
            this.branchNoDataGridViewTextBoxColumn.HeaderText = "branchNo";
            this.branchNoDataGridViewTextBoxColumn.Name = "branchNoDataGridViewTextBoxColumn";
            this.branchNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchNo
            // 
            this.branchNo.DataPropertyName = "fromBranch";
            this.branchNo.HeaderText = "FROM";
            this.branchNo.Name = "branchNo";
            this.branchNo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "toBranch";
            this.Column1.HeaderText = "TO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.citiAppDatabaseDataSet1;
            // 
            // citiAppDatabaseDataSet1
            // 
            this.citiAppDatabaseDataSet1.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(48, 649);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(871, 649);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(146, 42);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View Details";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stock No:";
            // 
            // tBoxStockNo
            // 
            this.tBoxStockNo.Location = new System.Drawing.Point(584, 649);
            this.tBoxStockNo.Name = "tBoxStockNo";
            this.tBoxStockNo.Size = new System.Drawing.Size(200, 20);
            this.tBoxStockNo.TabIndex = 8;
            this.tBoxStockNo.TextChanged += new System.EventHandler(this.tBoxStockNo_TextChanged);
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 698);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxStockNo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductsList";
            this.Resizable = false;
            this.Text = "ProductsList";
            this.Load += new System.EventHandler(this.ProductsList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockListReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridViewInventory;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockListReportBindingSource;
        private citiAppDatabaseDataSetTableAdapters.stockListReportTableAdapter stockListReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locToDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridViewProdDetails;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private citiAppDatabaseDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxStockNo;
    }
}