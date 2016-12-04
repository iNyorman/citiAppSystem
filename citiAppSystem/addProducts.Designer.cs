namespace citiAppSystem
{
    partial class addProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tBoxModel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rBtnManual = new System.Windows.Forms.RadioButton();
            this.cboxBranch = new System.Windows.Forms.ComboBox();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tboxWayBill = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tboxVia = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtReceived = new System.Windows.Forms.DateTimePicker();
            this.tboxPO = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tboxDeliveryNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.tboxQty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tboxBrand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tboxStockNo = new MetroFramework.Controls.MetroTextBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnUpdate_Save = new MetroFramework.Controls.MetroButton();
            this.gridProducts = new MetroFramework.Controls.MetroGrid();
            this.stockNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poDetails_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.currentProductCount = new MetroFramework.Controls.MetroLabel();
            this.Status = new System.Windows.Forms.Label();
            this.branchTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.branchTableAdapter();
            this.tBoxStockCode = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.gboxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBoxStockCode);
            this.groupBox1.Controls.Add(this.tboxSupplierName);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.tBoxModel);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rBtnManual);
            this.groupBox1.Controls.Add(this.cboxBranch);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.tboxWayBill);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.tboxVia);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.dtReceived);
            this.groupBox1.Controls.Add(this.tboxPO);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.tboxDeliveryNo);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.tboxQty);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.tboxBrand);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tboxStockNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tboxSupplierName
            // 
            this.tboxSupplierName.Lines = new string[0];
            this.tboxSupplierName.Location = new System.Drawing.Point(248, 73);
            this.tboxSupplierName.MaxLength = 32767;
            this.tboxSupplierName.Name = "tboxSupplierName";
            this.tboxSupplierName.PasswordChar = '\0';
            this.tboxSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSupplierName.SelectedText = "";
            this.tboxSupplierName.Size = new System.Drawing.Size(210, 28);
            this.tboxSupplierName.TabIndex = 2;
            this.tboxSupplierName.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(248, 51);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(105, 19);
            this.metroLabel12.TabIndex = 33;
            this.metroLabel12.Text = "Supplier Name :";
            // 
            // tBoxModel
            // 
            this.tBoxModel.Lines = new string[0];
            this.tBoxModel.Location = new System.Drawing.Point(436, 127);
            this.tBoxModel.MaxLength = 32767;
            this.tBoxModel.Name = "tBoxModel";
            this.tBoxModel.PasswordChar = '\0';
            this.tBoxModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBoxModel.SelectedText = "";
            this.tBoxModel.Size = new System.Drawing.Size(162, 28);
            this.tBoxModel.TabIndex = 6;
            this.tBoxModel.UseSelectable = true;
            this.tBoxModel.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(432, 104);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(51, 19);
            this.metroLabel11.TabIndex = 31;
            this.metroLabel11.Text = "Model:";
            this.metroLabel11.Visible = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(20, 18);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(77, 19);
            this.metroLabel10.TabIndex = 29;
            this.metroLabel10.Text = "Entry Type:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 20);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "From P.O";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rBtnManual
            // 
            this.rBtnManual.AutoSize = true;
            this.rBtnManual.Location = new System.Drawing.Point(204, 18);
            this.rBtnManual.Name = "rBtnManual";
            this.rBtnManual.Size = new System.Drawing.Size(106, 20);
            this.rBtnManual.TabIndex = 27;
            this.rBtnManual.TabStop = true;
            this.rBtnManual.Text = "Direct Entry";
            this.rBtnManual.UseVisualStyleBackColor = true;
            this.rBtnManual.CheckedChanged += new System.EventHandler(this.rBtnManual_CheckedChanged);
            this.rBtnManual.Click += new System.EventHandler(this.rBtnManual_Click);
            // 
            // cboxBranch
            // 
            this.cboxBranch.DataSource = this.branchBindingSource;
            this.cboxBranch.DisplayMember = "branchName";
            this.cboxBranch.Enabled = false;
            this.cboxBranch.FormattingEnabled = true;
            this.cboxBranch.Location = new System.Drawing.Point(660, 90);
            this.cboxBranch.Name = "cboxBranch";
            this.cboxBranch.Size = new System.Drawing.Size(249, 24);
            this.cboxBranch.TabIndex = 9;
            this.cboxBranch.ValueMember = "branchNo";
            this.cboxBranch.SelectedValueChanged += new System.EventHandler(this.cboxBranch_SelectedValueChanged);
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "branch";
            this.branchBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(660, 68);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 25;
            this.metroLabel9.Text = "Branch :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(229, 172);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(72, 19);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "WAY BILL:";
            // 
            // tboxWayBill
            // 
            this.tboxWayBill.Lines = new string[0];
            this.tboxWayBill.Location = new System.Drawing.Point(306, 171);
            this.tboxWayBill.MaxLength = 32767;
            this.tboxWayBill.Name = "tboxWayBill";
            this.tboxWayBill.PasswordChar = '\0';
            this.tboxWayBill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxWayBill.SelectedText = "";
            this.tboxWayBill.Size = new System.Drawing.Size(150, 28);
            this.tboxWayBill.TabIndex = 23;
            this.tboxWayBill.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(21, 173);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(34, 19);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = "VIA:";
            // 
            // tboxVia
            // 
            this.tboxVia.Lines = new string[0];
            this.tboxVia.Location = new System.Drawing.Point(61, 172);
            this.tboxVia.MaxLength = 32767;
            this.tboxVia.Name = "tboxVia";
            this.tboxVia.PasswordChar = '\0';
            this.tboxVia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxVia.SelectedText = "";
            this.tboxVia.Size = new System.Drawing.Size(150, 28);
            this.tboxVia.TabIndex = 8;
            this.tboxVia.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(660, 121);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Date Received:";
            // 
            // dtReceived
            // 
            this.dtReceived.Location = new System.Drawing.Point(660, 141);
            this.dtReceived.Name = "dtReceived";
            this.dtReceived.Size = new System.Drawing.Size(270, 22);
            this.dtReceived.TabIndex = 10;
            // 
            // tboxPO
            // 
            this.tboxPO.Lines = new string[0];
            this.tboxPO.Location = new System.Drawing.Point(660, 36);
            this.tboxPO.MaxLength = 32767;
            this.tboxPO.Name = "tboxPO";
            this.tboxPO.PasswordChar = '\0';
            this.tboxPO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxPO.SelectedText = "";
            this.tboxPO.Size = new System.Drawing.Size(190, 28);
            this.tboxPO.TabIndex = 556;
            this.tboxPO.UseSelectable = true;
            this.tboxPO.TextChanged += new System.EventHandler(this.tboxPO_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(660, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Purchase Order :";
            // 
            // tboxDeliveryNo
            // 
            this.tboxDeliveryNo.Lines = new string[0];
            this.tboxDeliveryNo.Location = new System.Drawing.Point(26, 73);
            this.tboxDeliveryNo.MaxLength = 32767;
            this.tboxDeliveryNo.Name = "tboxDeliveryNo";
            this.tboxDeliveryNo.PasswordChar = '\0';
            this.tboxDeliveryNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxDeliveryNo.SelectedText = "";
            this.tboxDeliveryNo.Size = new System.Drawing.Size(210, 28);
            this.tboxDeliveryNo.TabIndex = 1;
            this.tboxDeliveryNo.UseSelectable = true;
            this.tboxDeliveryNo.TextChanged += new System.EventHandler(this.tboxDeliveryNo_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(26, 51);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(109, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Arrival Number :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(861, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 5552;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(885, 171);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(69, 27);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tboxQty
            // 
            this.tboxQty.Lines = new string[0];
            this.tboxQty.Location = new System.Drawing.Point(797, 171);
            this.tboxQty.MaxLength = 32767;
            this.tboxQty.Name = "tboxQty";
            this.tboxQty.PasswordChar = '\0';
            this.tboxQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxQty.SelectedText = "";
            this.tboxQty.Size = new System.Drawing.Size(82, 28);
            this.tboxQty.TabIndex = 11;
            this.tboxQty.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(651, 178);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(140, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Number of Products :";
            // 
            // tboxBrand
            // 
            this.tboxBrand.Enabled = false;
            this.tboxBrand.Lines = new string[0];
            this.tboxBrand.Location = new System.Drawing.Point(264, 127);
            this.tboxBrand.MaxLength = 32767;
            this.tboxBrand.Name = "tboxBrand";
            this.tboxBrand.PasswordChar = '\0';
            this.tboxBrand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxBrand.SelectedText = "";
            this.tboxBrand.Size = new System.Drawing.Size(162, 28);
            this.tboxBrand.TabIndex = 5;
            this.tboxBrand.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(260, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Brand :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(49, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Stock No :";
            // 
            // tboxStockNo
            // 
            this.tboxStockNo.Lines = new string[0];
            this.tboxStockNo.Location = new System.Drawing.Point(103, 127);
            this.tboxStockNo.MaxLength = 32767;
            this.tboxStockNo.Name = "tboxStockNo";
            this.tboxStockNo.PasswordChar = '\0';
            this.tboxStockNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxStockNo.SelectedText = "";
            this.tboxStockNo.Size = new System.Drawing.Size(155, 28);
            this.tboxStockNo.TabIndex = 4;
            this.tboxStockNo.UseSelectable = true;
            // 
            // btnBack
            // 
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(6, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 34);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.Location = new System.Drawing.Point(661, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 34);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate_Save
            // 
            this.btnUpdate_Save.Enabled = false;
            this.btnUpdate_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate_Save.Location = new System.Drawing.Point(816, 19);
            this.btnUpdate_Save.Name = "btnUpdate_Save";
            this.btnUpdate_Save.Size = new System.Drawing.Size(147, 34);
            this.btnUpdate_Save.TabIndex = 14;
            this.btnUpdate_Save.Text = "Save and Print";
            this.btnUpdate_Save.UseSelectable = true;
            this.btnUpdate_Save.Click += new System.EventHandler(this.btnUpdate_Save_Click);
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNo,
            this.serialNo,
            this.brand,
            this.model,
            this.poDetails_ID,
            this.price});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProducts.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridProducts.EnableHeadersVisualStyles = false;
            this.gridProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProducts.Location = new System.Drawing.Point(20, 293);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(971, 259);
            this.gridProducts.TabIndex = 44;
            // 
            // stockNo
            // 
            this.stockNo.HeaderText = "STOCKNO";
            this.stockNo.Name = "stockNo";
            this.stockNo.ReadOnly = true;
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "SERIAL NO";
            this.serialNo.Name = "serialNo";
            // 
            // brand
            // 
            this.brand.HeaderText = "BRAND";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Visible = false;
            // 
            // model
            // 
            this.model.HeaderText = "MODEL";
            this.model.Name = "model";
            // 
            // poDetails_ID
            // 
            this.poDetails_ID.HeaderText = "podetailsID";
            this.poDetails_ID.Name = "poDetails_ID";
            this.poDetails_ID.Visible = false;
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.Name = "price";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -98;
            this.lineShape1.X2 = 1172;
            this.lineShape1.Y1 = 1;
            this.lineShape1.Y2 = 1;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(966, 561);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -78;
            this.lineShape2.X2 = 1192;
            this.lineShape2.Y1 = 5;
            this.lineShape2.Y2 = 5;
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.btnUpdate_Save);
            this.gboxOptions.Controls.Add(this.btnBack);
            this.gboxOptions.Controls.Add(this.btnClear);
            this.gboxOptions.Location = new System.Drawing.Point(20, 555);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(974, 73);
            this.gboxOptions.TabIndex = 19;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Options";
            this.gboxOptions.Enter += new System.EventHandler(this.gboxOptions_Enter);
            // 
            // currentProductCount
            // 
            this.currentProductCount.AutoSize = true;
            this.currentProductCount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.currentProductCount.Location = new System.Drawing.Point(935, 31);
            this.currentProductCount.Name = "currentProductCount";
            this.currentProductCount.Size = new System.Drawing.Size(38, 19);
            this.currentProductCount.TabIndex = 21;
            this.currentProductCount.Text = "0/25";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(779, 35);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(150, 15);
            this.Status.TabIndex = 22;
            this.Status.Text = "Total Product Count:";
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // tBoxStockCode
            // 
            this.tBoxStockCode.Lines = new string[0];
            this.tBoxStockCode.Location = new System.Drawing.Point(49, 127);
            this.tBoxStockCode.MaxLength = 32767;
            this.tBoxStockCode.Name = "tBoxStockCode";
            this.tBoxStockCode.PasswordChar = '\0';
            this.tBoxStockCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBoxStockCode.SelectedText = "";
            this.tBoxStockCode.Size = new System.Drawing.Size(48, 28);
            this.tBoxStockCode.TabIndex = 3;
            this.tBoxStockCode.UseSelectable = true;
            // 
            // addProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 641);
            this.ControlBox = false;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.currentProductCount);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxOptions);
            this.Controls.Add(this.shapeContainer1);
            this.Movable = false;
            this.Name = "addProducts";
            this.Resizable = false;
            this.Text = "Products";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.add_UpdateProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.gboxOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tboxBrand;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tboxStockNo;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnUpdate_Save;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroTextBox tboxQty;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid gridProducts;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.GroupBox gboxOptions;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox tboxDeliveryNo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tboxPO;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel currentProductCount;
        private System.Windows.Forms.Label Status;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker dtReceived;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox tboxWayBill;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tboxVia;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ComboBox cboxBranch;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn poDetails_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rBtnManual;
        private MetroFramework.Controls.MetroTextBox tBoxModel;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox tboxSupplierName;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox tBoxStockCode;
    }
}