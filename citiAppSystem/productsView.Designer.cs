namespace citiAppSystem
{
    partial class productsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.gridProducts = new MetroFramework.Controls.MetroGrid();
            this.stockNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poDetailsIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet1 = new citiAppSystem.citiAppDatabaseDataSet();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnFree = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridFreeProductView = new MetroFramework.Controls.MetroGrid();
            this.stockNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fstockNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeProductViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cachedcryLedger1 = new citiAppSystem.CachedcryLedger();
            this.cBoxFilter = new MetroFramework.Controls.MetroComboBox();
            this.productsTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
            this.freeProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freeProductTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.freeProductTableAdapter();
            this.free_Product_ViewTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.Free_Product_ViewTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFreeProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeProductViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(22, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "SEARCH:";
            // 
            // tboxSearch
            // 
            this.tboxSearch.Lines = new string[0];
            this.tboxSearch.Location = new System.Drawing.Point(269, 85);
            this.tboxSearch.MaxLength = 32767;
            this.tboxSearch.Multiline = true;
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.PasswordChar = '\0';
            this.tboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSearch.SelectedText = "";
            this.tboxSearch.Size = new System.Drawing.Size(295, 29);
            this.tboxSearch.TabIndex = 16;
            this.tboxSearch.UseSelectable = true;
            this.tboxSearch.TextChanged += new System.EventHandler(this.tboxSearch_TextChanged);
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.AutoGenerateColumns = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNoDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1,
            this.prodStatusDataGridViewTextBoxColumn1,
            this.poDetailsIDDataGridViewTextBoxColumn1,
            this.price});
            this.gridProducts.DataSource = this.productsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProducts.EnableHeadersVisualStyles = false;
            this.gridProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProducts.Location = new System.Drawing.Point(20, 120);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(774, 253);
            this.gridProducts.TabIndex = 15;
            this.gridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellClick);
            this.gridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellContentClick);
            this.gridProducts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProducts_CellMouseClick);
            this.gridProducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProducts_CellMouseDoubleClick);
            // 
            // stockNoDataGridViewTextBoxColumn
            // 
            this.stockNoDataGridViewTextBoxColumn.DataPropertyName = "stockNo";
            this.stockNoDataGridViewTextBoxColumn.HeaderText = "Stock Number";
            this.stockNoDataGridViewTextBoxColumn.Name = "stockNoDataGridViewTextBoxColumn";
            this.stockNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "serialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "Serial Number";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prodStatusDataGridViewTextBoxColumn1
            // 
            this.prodStatusDataGridViewTextBoxColumn1.DataPropertyName = "prodStatus";
            this.prodStatusDataGridViewTextBoxColumn1.HeaderText = "Product Remarks";
            this.prodStatusDataGridViewTextBoxColumn1.Name = "prodStatusDataGridViewTextBoxColumn1";
            this.prodStatusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // poDetailsIDDataGridViewTextBoxColumn1
            // 
            this.poDetailsIDDataGridViewTextBoxColumn1.DataPropertyName = "poDetails_ID";
            this.poDetailsIDDataGridViewTextBoxColumn1.HeaderText = "poDetails_ID";
            this.poDetailsIDDataGridViewTextBoxColumn1.Name = "poDetailsIDDataGridViewTextBoxColumn1";
            this.poDetailsIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.poDetailsIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
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
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNew.Location = new System.Drawing.Point(1120, 402);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(127, 32);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Add New Product";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate.Location = new System.Drawing.Point(942, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(20, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 32);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -49;
            this.lineShape2.X2 = 1221;
            this.lineShape2.Y1 = 2;
            this.lineShape2.Y2 = 2;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(1218, 374);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = -64;
            this.lineShape4.X2 = 1206;
            this.lineShape4.Y1 = 327;
            this.lineShape4.Y2 = 327;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -62;
            this.lineShape3.X2 = 1208;
            this.lineShape3.Y1 = 322;
            this.lineShape3.Y2 = 322;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -44;
            this.lineShape1.X2 = 1226;
            this.lineShape1.Y1 = 7;
            this.lineShape1.Y2 = 7;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(1115, 83);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(127, 29);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "Print";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnFree
            // 
            this.btnFree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFree.Enabled = false;
            this.btnFree.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnFree.Location = new System.Drawing.Point(800, 402);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(127, 32);
            this.btnFree.TabIndex = 21;
            this.btnFree.Text = "Add Free";
            this.btnFree.UseSelectable = true;
            this.btnFree.Visible = false;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridFreeProductView);
            this.groupBox1.Location = new System.Drawing.Point(800, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 261);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // gridFreeProductView
            // 
            this.gridFreeProductView.AllowUserToAddRows = false;
            this.gridFreeProductView.AllowUserToDeleteRows = false;
            this.gridFreeProductView.AllowUserToResizeRows = false;
            this.gridFreeProductView.AutoGenerateColumns = false;
            this.gridFreeProductView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFreeProductView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridFreeProductView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridFreeProductView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridFreeProductView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFreeProductView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridFreeProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFreeProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNoDataGridViewTextBoxColumn1,
            this.fstockNoDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn1,
            this.serialNoDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn});
            this.gridFreeProductView.DataSource = this.freeProductViewBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFreeProductView.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridFreeProductView.EnableHeadersVisualStyles = false;
            this.gridFreeProductView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridFreeProductView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridFreeProductView.Location = new System.Drawing.Point(6, 8);
            this.gridFreeProductView.Name = "gridFreeProductView";
            this.gridFreeProductView.ReadOnly = true;
            this.gridFreeProductView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFreeProductView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridFreeProductView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFreeProductView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFreeProductView.Size = new System.Drawing.Size(435, 247);
            this.gridFreeProductView.TabIndex = 16;
            // 
            // stockNoDataGridViewTextBoxColumn1
            // 
            this.stockNoDataGridViewTextBoxColumn1.DataPropertyName = "stockNo";
            this.stockNoDataGridViewTextBoxColumn1.HeaderText = "Stock No";
            this.stockNoDataGridViewTextBoxColumn1.Name = "stockNoDataGridViewTextBoxColumn1";
            this.stockNoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fstockNoDataGridViewTextBoxColumn
            // 
            this.fstockNoDataGridViewTextBoxColumn.DataPropertyName = "FstockNo";
            this.fstockNoDataGridViewTextBoxColumn.HeaderText = "FstockNo";
            this.fstockNoDataGridViewTextBoxColumn.Name = "fstockNoDataGridViewTextBoxColumn";
            this.fstockNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fstockNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // brandDataGridViewTextBoxColumn1
            // 
            this.brandDataGridViewTextBoxColumn1.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn1.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn1.Name = "brandDataGridViewTextBoxColumn1";
            this.brandDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn1
            // 
            this.modelDataGridViewTextBoxColumn1.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn1.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn1.Name = "modelDataGridViewTextBoxColumn1";
            this.modelDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // serialNoDataGridViewTextBoxColumn1
            // 
            this.serialNoDataGridViewTextBoxColumn1.DataPropertyName = "serialNo";
            this.serialNoDataGridViewTextBoxColumn1.HeaderText = "Serial No";
            this.serialNoDataGridViewTextBoxColumn1.Name = "serialNoDataGridViewTextBoxColumn1";
            this.serialNoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freeProductViewBindingSource
            // 
            this.freeProductViewBindingSource.DataMember = "Free Product View";
            this.freeProductViewBindingSource.DataSource = this.citiAppDatabaseDataSet1;
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
            "Brand",
            "Arrival Number"});
            this.cBoxFilter.Location = new System.Drawing.Point(104, 87);
            this.cBoxFilter.Name = "cBoxFilter";
            this.cBoxFilter.Size = new System.Drawing.Size(159, 25);
            this.cBoxFilter.TabIndex = 24;
            this.cBoxFilter.UseSelectable = true;
            this.cBoxFilter.SelectedIndexChanged += new System.EventHandler(this.cBoxFilter_SelectedIndexChanged);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // freeProductBindingSource
            // 
            this.freeProductBindingSource.DataMember = "freeProduct";
            this.freeProductBindingSource.DataSource = this.citiAppDatabaseDataSet1;
            // 
            // freeProductTableAdapter
            // 
            this.freeProductTableAdapter.ClearBeforeFill = true;
            // 
            // free_Product_ViewTableAdapter
            // 
            this.free_Product_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // productsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 454);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFree);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.shapeContainer1);
            this.Movable = false;
            this.Name = "productsView";
            this.Resizable = false;
            this.Text = "Product List";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.productsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFreeProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeProductViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tboxSearch;
        private MetroFramework.Controls.MetroGrid gridProducts;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private citiAppDatabaseDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnFree;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private CachedcryLedger cachedcryLedger1;
        private MetroFramework.Controls.MetroGrid gridFreeProductView;
        private MetroFramework.Controls.MetroComboBox cBoxFilter;
        private System.Windows.Forms.BindingSource freeProductBindingSource;
        private citiAppDatabaseDataSetTableAdapters.freeProductTableAdapter freeProductTableAdapter;
        private System.Windows.Forms.BindingSource freeProductViewBindingSource;
        private citiAppDatabaseDataSetTableAdapters.Free_Product_ViewTableAdapter free_Product_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fstockNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn poDetailsIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}