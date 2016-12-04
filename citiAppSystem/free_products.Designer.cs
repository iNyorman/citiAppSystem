namespace citiAppSystem
{
    partial class free_products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupMainProd = new System.Windows.Forms.GroupBox();
            this.tboxSerialNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tboxModel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tboxBrand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tboxStockNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupFree = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridFreeProducts = new MetroFramework.Controls.MetroGrid();
            this.stockNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAttachProduct = new MetroFramework.Controls.MetroButton();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.btnUpdate_Save = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.cBoxFilter = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.gridProductList = new System.Windows.Forms.DataGridView();
            this.stockNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poDetailsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.productsTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.productsTableAdapter();
            this.cboxBranch = new System.Windows.Forms.ComboBox();
            this.lblBranch = new MetroFramework.Controls.MetroLabel();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.branchTableAdapter();
            this.groupMainProd.SuspendLayout();
            this.groupFree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFreeProducts)).BeginInit();
            this.gboxOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupMainProd
            // 
            this.groupMainProd.Controls.Add(this.tboxSerialNo);
            this.groupMainProd.Controls.Add(this.metroLabel3);
            this.groupMainProd.Controls.Add(this.tboxModel);
            this.groupMainProd.Controls.Add(this.metroLabel2);
            this.groupMainProd.Controls.Add(this.tboxBrand);
            this.groupMainProd.Controls.Add(this.metroLabel1);
            this.groupMainProd.Controls.Add(this.tboxStockNo);
            this.groupMainProd.Controls.Add(this.metroLabel5);
            this.groupMainProd.Location = new System.Drawing.Point(4, 70);
            this.groupMainProd.Name = "groupMainProd";
            this.groupMainProd.Size = new System.Drawing.Size(1097, 71);
            this.groupMainProd.TabIndex = 0;
            this.groupMainProd.TabStop = false;
            this.groupMainProd.Text = "Main Product";
            // 
            // tboxSerialNo
            // 
            this.tboxSerialNo.Enabled = false;
            this.tboxSerialNo.Lines = new string[0];
            this.tboxSerialNo.Location = new System.Drawing.Point(814, 35);
            this.tboxSerialNo.MaxLength = 32767;
            this.tboxSerialNo.Name = "tboxSerialNo";
            this.tboxSerialNo.PasswordChar = '\0';
            this.tboxSerialNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSerialNo.SelectedText = "";
            this.tboxSerialNo.Size = new System.Drawing.Size(242, 28);
            this.tboxSerialNo.TabIndex = 23;
            this.tboxSerialNo.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(814, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Serial No :";
            // 
            // tboxModel
            // 
            this.tboxModel.Enabled = false;
            this.tboxModel.Lines = new string[0];
            this.tboxModel.Location = new System.Drawing.Point(549, 35);
            this.tboxModel.MaxLength = 32767;
            this.tboxModel.Name = "tboxModel";
            this.tboxModel.PasswordChar = '\0';
            this.tboxModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxModel.SelectedText = "";
            this.tboxModel.Size = new System.Drawing.Size(242, 28);
            this.tboxModel.TabIndex = 21;
            this.tboxModel.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(549, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Model :";
            // 
            // tboxBrand
            // 
            this.tboxBrand.Enabled = false;
            this.tboxBrand.Lines = new string[0];
            this.tboxBrand.Location = new System.Drawing.Point(288, 35);
            this.tboxBrand.MaxLength = 32767;
            this.tboxBrand.Name = "tboxBrand";
            this.tboxBrand.PasswordChar = '\0';
            this.tboxBrand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxBrand.SelectedText = "";
            this.tboxBrand.Size = new System.Drawing.Size(242, 28);
            this.tboxBrand.TabIndex = 19;
            this.tboxBrand.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(288, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Brand :";
            // 
            // tboxStockNo
            // 
            this.tboxStockNo.Lines = new string[0];
            this.tboxStockNo.Location = new System.Drawing.Point(27, 35);
            this.tboxStockNo.MaxLength = 32767;
            this.tboxStockNo.Name = "tboxStockNo";
            this.tboxStockNo.PasswordChar = '\0';
            this.tboxStockNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxStockNo.SelectedText = "";
            this.tboxStockNo.Size = new System.Drawing.Size(242, 28);
            this.tboxStockNo.TabIndex = 17;
            this.tboxStockNo.UseSelectable = true;
            this.tboxStockNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxStockNo_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(27, 14);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(103, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Stock Number :";
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -322;
            this.lineShape2.X2 = 1099;
            this.lineShape2.Y1 = 1;
            this.lineShape2.Y2 = 1;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -317;
            this.lineShape1.X2 = 1095;
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
            this.shapeContainer1.Size = new System.Drawing.Size(1083, 488);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // groupFree
            // 
            this.groupFree.Controls.Add(this.label1);
            this.groupFree.Controls.Add(this.gridFreeProducts);
            this.groupFree.Location = new System.Drawing.Point(4, 335);
            this.groupFree.Name = "groupFree";
            this.groupFree.Size = new System.Drawing.Size(1096, 150);
            this.groupFree.TabIndex = 2;
            this.groupFree.TabStop = false;
            this.groupFree.Text = "Free Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Selected Product Already ";
            this.label1.Visible = false;
            // 
            // gridFreeProducts
            // 
            this.gridFreeProducts.AllowUserToAddRows = false;
            this.gridFreeProducts.AllowUserToDeleteRows = false;
            this.gridFreeProducts.AllowUserToResizeRows = false;
            this.gridFreeProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFreeProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridFreeProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridFreeProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridFreeProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFreeProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridFreeProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFreeProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNo,
            this.brand,
            this.model,
            this.serialNo});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFreeProducts.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridFreeProducts.EnableHeadersVisualStyles = false;
            this.gridFreeProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridFreeProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridFreeProducts.Location = new System.Drawing.Point(6, 44);
            this.gridFreeProducts.Name = "gridFreeProducts";
            this.gridFreeProducts.ReadOnly = true;
            this.gridFreeProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFreeProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridFreeProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFreeProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFreeProducts.Size = new System.Drawing.Size(1084, 97);
            this.gridFreeProducts.TabIndex = 20;
            // 
            // stockNo
            // 
            this.stockNo.HeaderText = "Stock Number";
            this.stockNo.Name = "stockNo";
            this.stockNo.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "Serial Number";
            this.serialNo.Name = "serialNo";
            this.serialNo.ReadOnly = true;
            // 
            // btnAttachProduct
            // 
            this.btnAttachProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAttachProduct.Location = new System.Drawing.Point(549, 19);
            this.btnAttachProduct.Name = "btnAttachProduct";
            this.btnAttachProduct.Size = new System.Drawing.Size(147, 34);
            this.btnAttachProduct.TabIndex = 21;
            this.btnAttachProduct.Text = "Attach Free Product";
            this.btnAttachProduct.UseSelectable = true;
            this.btnAttachProduct.Click += new System.EventHandler(this.btnAttachProduct_Click);
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.btnUpdate_Save);
            this.gboxOptions.Controls.Add(this.btnAttachProduct);
            this.gboxOptions.Controls.Add(this.btnBack);
            this.gboxOptions.Controls.Add(this.btnClear);
            this.gboxOptions.Location = new System.Drawing.Point(4, 491);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(1096, 68);
            this.gboxOptions.TabIndex = 20;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Options";
            // 
            // btnUpdate_Save
            // 
            this.btnUpdate_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate_Save.Location = new System.Drawing.Point(943, 19);
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
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.Location = new System.Drawing.Point(793, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 34);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBranch);
            this.groupBox1.Controls.Add(this.cboxBranch);
            this.groupBox1.Controls.Add(this.tboxSearch);
            this.groupBox1.Controls.Add(this.cBoxFilter);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.gridProductList);
            this.groupBox1.Location = new System.Drawing.Point(4, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 182);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // tboxSearch
            // 
            this.tboxSearch.Lines = new string[0];
            this.tboxSearch.Location = new System.Drawing.Point(273, 16);
            this.tboxSearch.MaxLength = 32767;
            this.tboxSearch.Multiline = true;
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.PasswordChar = '\0';
            this.tboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSearch.SelectedText = "";
            this.tboxSearch.Size = new System.Drawing.Size(295, 29);
            this.tboxSearch.TabIndex = 27;
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
            this.cBoxFilter.Location = new System.Drawing.Point(108, 19);
            this.cBoxFilter.Name = "cBoxFilter";
            this.cBoxFilter.Size = new System.Drawing.Size(159, 25);
            this.cBoxFilter.TabIndex = 26;
            this.cBoxFilter.UseSelectable = true;
            this.cBoxFilter.SelectedIndexChanged += new System.EventHandler(this.cBoxFilter_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(26, 21);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "SEARCH:";
            // 
            // gridProductList
            // 
            this.gridProductList.AllowUserToAddRows = false;
            this.gridProductList.AllowUserToDeleteRows = false;
            this.gridProductList.AutoGenerateColumns = false;
            this.gridProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNoDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.poDetailsIDDataGridViewTextBoxColumn,
            this.prodStatusDataGridViewTextBoxColumn,
            this.deliveryNoDataGridViewTextBoxColumn,
            this.locFromDataGridViewTextBoxColumn,
            this.locToDataGridViewTextBoxColumn});
            this.gridProductList.DataSource = this.productsBindingSource;
            this.gridProductList.Location = new System.Drawing.Point(6, 52);
            this.gridProductList.Name = "gridProductList";
            this.gridProductList.ReadOnly = true;
            this.gridProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductList.Size = new System.Drawing.Size(1084, 124);
            this.gridProductList.TabIndex = 0;
            this.gridProductList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridProductList_MouseDoubleClick);
            // 
            // stockNoDataGridViewTextBoxColumn
            // 
            this.stockNoDataGridViewTextBoxColumn.DataPropertyName = "stockNo";
            this.stockNoDataGridViewTextBoxColumn.HeaderText = "Stock No";
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
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "Serial No";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poDetailsIDDataGridViewTextBoxColumn
            // 
            this.poDetailsIDDataGridViewTextBoxColumn.DataPropertyName = "poDetails_ID";
            this.poDetailsIDDataGridViewTextBoxColumn.HeaderText = "poDetails_ID";
            this.poDetailsIDDataGridViewTextBoxColumn.Name = "poDetailsIDDataGridViewTextBoxColumn";
            this.poDetailsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.poDetailsIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodStatusDataGridViewTextBoxColumn
            // 
            this.prodStatusDataGridViewTextBoxColumn.DataPropertyName = "prodStatus";
            this.prodStatusDataGridViewTextBoxColumn.HeaderText = "prodStatus";
            this.prodStatusDataGridViewTextBoxColumn.Name = "prodStatusDataGridViewTextBoxColumn";
            this.prodStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // deliveryNoDataGridViewTextBoxColumn
            // 
            this.deliveryNoDataGridViewTextBoxColumn.DataPropertyName = "deliveryNo";
            this.deliveryNoDataGridViewTextBoxColumn.HeaderText = "deliveryNo";
            this.deliveryNoDataGridViewTextBoxColumn.Name = "deliveryNoDataGridViewTextBoxColumn";
            this.deliveryNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // locFromDataGridViewTextBoxColumn
            // 
            this.locFromDataGridViewTextBoxColumn.DataPropertyName = "loc_From";
            this.locFromDataGridViewTextBoxColumn.HeaderText = "loc_From";
            this.locFromDataGridViewTextBoxColumn.Name = "locFromDataGridViewTextBoxColumn";
            this.locFromDataGridViewTextBoxColumn.ReadOnly = true;
            this.locFromDataGridViewTextBoxColumn.Visible = false;
            // 
            // locToDataGridViewTextBoxColumn
            // 
            this.locToDataGridViewTextBoxColumn.DataPropertyName = "loc_To";
            this.locToDataGridViewTextBoxColumn.HeaderText = "loc_To";
            this.locToDataGridViewTextBoxColumn.Name = "locToDataGridViewTextBoxColumn";
            this.locToDataGridViewTextBoxColumn.ReadOnly = true;
            this.locToDataGridViewTextBoxColumn.Visible = false;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // cboxBranch
            // 
            this.cboxBranch.DataSource = this.branchBindingSource;
            this.cboxBranch.DisplayMember = "branchName";
            this.cboxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBranch.FormattingEnabled = true;
            this.cboxBranch.Location = new System.Drawing.Point(876, 19);
            this.cboxBranch.Name = "cboxBranch";
            this.cboxBranch.Size = new System.Drawing.Size(214, 21);
            this.cboxBranch.TabIndex = 28;
            this.cboxBranch.ValueMember = "branchNo";
            this.cboxBranch.Visible = false;
            this.cboxBranch.SelectedIndexChanged += new System.EventHandler(this.cboxBranch_SelectedIndexChanged);
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBranch.Location = new System.Drawing.Point(818, 20);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(58, 19);
            this.lblBranch.TabIndex = 29;
            this.lblBranch.Text = "Branch :";
            this.lblBranch.Visible = false;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "branch";
            this.branchBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // free_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxOptions);
            this.Controls.Add(this.groupFree);
            this.Controls.Add(this.groupMainProd);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "free_products";
            this.Text = "Free Products";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.free_products_Load);
            this.groupMainProd.ResumeLayout(false);
            this.groupMainProd.PerformLayout();
            this.groupFree.ResumeLayout(false);
            this.groupFree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFreeProducts)).EndInit();
            this.gboxOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMainProd;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private MetroFramework.Controls.MetroTextBox tboxSerialNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tboxModel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tboxBrand;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tboxStockNo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupFree;
        private System.Windows.Forms.GroupBox gboxOptions;
        private MetroFramework.Controls.MetroButton btnUpdate_Save;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnAttachProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        public MetroFramework.Controls.MetroGrid gridFreeProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridProductList;
        private MetroFramework.Controls.MetroComboBox cBoxFilter;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private citiAppDatabaseDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private MetroFramework.Controls.MetroTextBox tboxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poDetailsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locToDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel lblBranch;
        private System.Windows.Forms.ComboBox cboxBranch;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchTableAdapter;
    }
}