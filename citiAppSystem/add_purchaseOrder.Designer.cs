namespace citiAppSystem
{
    partial class add_purchaseOrder
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tboxPONumber = new MetroFramework.Controls.MetroTextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tboxSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cboxBranch = new MetroFramework.Controls.MetroComboBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.POdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnUpdate_Save = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tboxTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cBoxBrand = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.btnAddProduct = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cBoxModel = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.branchTableAdapter();
            this.productListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productListTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.productListTableAdapter();
            this.brandTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.brandTableAdapter();
            this.modelTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.modelTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(535, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "PO Number :";
            // 
            // tboxPONumber
            // 
            this.tboxPONumber.Enabled = false;
            this.tboxPONumber.Lines = new string[0];
            this.tboxPONumber.Location = new System.Drawing.Point(630, 78);
            this.tboxPONumber.MaxLength = 32767;
            this.tboxPONumber.Name = "tboxPONumber";
            this.tboxPONumber.PasswordChar = '\0';
            this.tboxPONumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxPONumber.SelectedText = "";
            this.tboxPONumber.Size = new System.Drawing.Size(202, 28);
            this.tboxPONumber.TabIndex = 7;
            this.tboxPONumber.UseSelectable = true;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -225;
            this.lineShape1.X2 = 1045;
            this.lineShape1.Y1 = 1;
            this.lineShape1.Y2 = 1;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -226;
            this.lineShape2.X2 = 1044;
            this.lineShape2.Y1 = 4;
            this.lineShape2.Y2 = 4;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(817, 479);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Supplier Name :";
            // 
            // tboxSupplierName
            // 
            this.tboxSupplierName.Lines = new string[0];
            this.tboxSupplierName.Location = new System.Drawing.Point(134, 78);
            this.tboxSupplierName.MaxLength = 32767;
            this.tboxSupplierName.Name = "tboxSupplierName";
            this.tboxSupplierName.PasswordChar = '\0';
            this.tboxSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSupplierName.SelectedText = "";
            this.tboxSupplierName.Size = new System.Drawing.Size(183, 28);
            this.tboxSupplierName.TabIndex = 10;
            this.tboxSupplierName.UseSelectable = true;
            this.tboxSupplierName.TextChanged += new System.EventHandler(this.tboxSupplierName_TextChanged);
            this.tboxSupplierName.Leave += new System.EventHandler(this.tboxSupplierName_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(70, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Branch :";
            // 
            // cboxBranch
            // 
            this.cboxBranch.DropDownHeight = 100;
            this.cboxBranch.Enabled = false;
            this.cboxBranch.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboxBranch.FormattingEnabled = true;
            this.cboxBranch.IntegralHeight = false;
            this.cboxBranch.ItemHeight = 19;
            this.cboxBranch.Items.AddRange(new object[] {
            "ALDEGUER ILOILO CITY",
            "ROXAS CITY",
            "SAN JOSE ANTIQUE",
            "MAMBURAO, MINDORO",
            "SABLAYAN, MINDORO",
            "RXOM",
            "SJOM",
            "ROMBLON",
            "KALIBO, AKLAN",
            "CATICLAN, AKLAN",
            "PASSI CITY, ILOILO",
            "BRGY. BAYUYAN,ESTANCIA, ILOILO",
            "CUYO, PALAWAN",
            "TAYTAY, PALAWAN",
            "NARRA, PALAWAN",
            "CORON, PALAWAN",
            "RIO TUBA, PALAWAN",
            "PUERTO PRINCESA, PALAWAN"});
            this.cboxBranch.Location = new System.Drawing.Point(134, 118);
            this.cboxBranch.Name = "cboxBranch";
            this.cboxBranch.Size = new System.Drawing.Size(386, 25);
            this.cboxBranch.TabIndex = 13;
            this.cboxBranch.UseSelectable = true;
            this.cboxBranch.SelectedIndexChanged += new System.EventHandler(this.cboxBranch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearch.Location = new System.Drawing.Point(326, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 32);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(556, 123);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "PO Date :";
            // 
            // POdateTimePicker
            // 
            this.POdateTimePicker.Enabled = false;
            this.POdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.POdateTimePicker.Location = new System.Drawing.Point(632, 125);
            this.POdateTimePicker.Name = "POdateTimePicker";
            this.POdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.POdateTimePicker.TabIndex = 17;
            // 
            // DeliveryDateTimePicker
            // 
            this.DeliveryDateTimePicker.Enabled = false;
            this.DeliveryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DeliveryDateTimePicker.Location = new System.Drawing.Point(632, 161);
            this.DeliveryDateTimePicker.Name = "DeliveryDateTimePicker";
            this.DeliveryDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DeliveryDateTimePicker.TabIndex = 19;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(526, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Delivery Date :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnUpdate_Save);
            this.groupBox2.Location = new System.Drawing.Point(24, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 78);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Violet;
            this.btnRemove.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRemove.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnRemove.Location = new System.Drawing.Point(226, 22);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(184, 34);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Product";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Violet;
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.Location = new System.Drawing.Point(416, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Existing Price";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(15, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 34);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate_Save
            // 
            this.btnUpdate_Save.BackColor = System.Drawing.Color.Violet;
            this.btnUpdate_Save.Enabled = false;
            this.btnUpdate_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate_Save.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate_Save.Location = new System.Drawing.Point(608, 22);
            this.btnUpdate_Save.Name = "btnUpdate_Save";
            this.btnUpdate_Save.Size = new System.Drawing.Size(184, 34);
            this.btnUpdate_Save.TabIndex = 0;
            this.btnUpdate_Save.Text = "Save and Print";
            this.btnUpdate_Save.UseSelectable = true;
            this.btnUpdate_Save.Click += new System.EventHandler(this.btnUpdate_Save_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(578, 404);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 25;
            this.metroLabel7.Text = "Total :";
            // 
            // tboxTotal
            // 
            this.tboxTotal.Enabled = false;
            this.tboxTotal.Lines = new string[0];
            this.tboxTotal.Location = new System.Drawing.Point(630, 398);
            this.tboxTotal.MaxLength = 32767;
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.PasswordChar = '\0';
            this.tboxTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxTotal.SelectedText = "";
            this.tboxTotal.Size = new System.Drawing.Size(202, 28);
            this.tboxTotal.TabIndex = 24;
            this.tboxTotal.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(39, 150);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "Brand:";
            // 
            // cBoxBrand
            // 
            this.cBoxBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxBrand.DataSource = this.brandBindingSource;
            this.cBoxBrand.DisplayMember = "brandName";
            this.cBoxBrand.Enabled = false;
            this.cBoxBrand.FormattingEnabled = true;
            this.cBoxBrand.Location = new System.Drawing.Point(42, 172);
            this.cBoxBrand.Name = "cBoxBrand";
            this.cBoxBrand.Size = new System.Drawing.Size(144, 21);
            this.cBoxBrand.TabIndex = 27;
            this.cBoxBrand.ValueMember = "brandID";
            this.cBoxBrand.Leave += new System.EventHandler(this.cBoxBrand_Leave);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.Enabled = false;
            this.btnAddProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddProduct.Location = new System.Drawing.Point(365, 169);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(128, 24);
            this.btnAddProduct.TabIndex = 28;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseSelectable = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(192, 150);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.TabIndex = 29;
            this.metroLabel8.Text = "Model:";
            // 
            // cBoxModel
            // 
            this.cBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBoxModel.DataSource = this.modelBindingSource;
            this.cBoxModel.DisplayMember = "modelName";
            this.cBoxModel.FormattingEnabled = true;
            this.cBoxModel.Location = new System.Drawing.Point(196, 172);
            this.cBoxModel.Name = "cBoxModel";
            this.cBoxModel.Size = new System.Drawing.Size(163, 21);
            this.cBoxModel.TabIndex = 30;
            this.cBoxModel.ValueMember = "modelID";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "model";
            this.modelBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand,
            this.Model,
            this.OrderedQTY,
            this.freeQty,
            this.cost,
            this.Discount,
            this.total,
            this.brandID,
            this.modelID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(23, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 180);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPODetails_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPODetails_CellValueChanged);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridPODetails_DefaultValuesNeeded);
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // OrderedQTY
            // 
            this.OrderedQTY.HeaderText = "Ordered QTY";
            this.OrderedQTY.Name = "OrderedQTY";
            // 
            // freeQty
            // 
            this.freeQty.HeaderText = "Free QTY";
            this.freeQty.Name = "freeQty";
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // brandID
            // 
            this.brandID.HeaderText = "brandID";
            this.brandID.Name = "brandID";
            this.brandID.Visible = false;
            // 
            // modelID
            // 
            this.modelID.HeaderText = "modelID";
            this.modelID.Name = "modelID";
            this.modelID.Visible = false;
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
            // productListBindingSource
            // 
            this.productListBindingSource.DataMember = "productList";
            this.productListBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // productListTableAdapter
            // 
            this.productListTableAdapter.ClearBeforeFill = true;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // add_purchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 559);
            this.ControlBox = false;
            this.Controls.Add(this.cBoxModel);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.cBoxBrand);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tboxTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeliveryDateTimePicker);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.POdateTimePicker);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboxBranch);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tboxSupplierName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tboxPONumber);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "add_purchaseOrder";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.add_purchaseOrder_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tboxPONumber;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tboxSupplierName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cboxBranch;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchTableAdapter;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker POdateTimePicker;
        private System.Windows.Forms.DateTimePicker DeliveryDateTimePicker;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnUpdate_Save;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tboxTotal;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ComboBox cBoxBrand;
        private System.Windows.Forms.BindingSource productListBindingSource;
        private citiAppDatabaseDataSetTableAdapters.productListTableAdapter productListTableAdapter;
        private MetroFramework.Controls.MetroButton btnAddProduct;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ComboBox cBoxModel;
        public MetroFramework.Controls.MetroGrid dataGridView1;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private citiAppDatabaseDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private citiAppDatabaseDataSetTableAdapters.modelTableAdapter modelTableAdapter;
        private MetroFramework.Controls.MetroButton btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelID;
    }
}