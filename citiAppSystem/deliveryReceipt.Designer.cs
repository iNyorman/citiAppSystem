namespace citiAppSystem
{
    partial class deliveryReceipt
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
            this.cboxAccountType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupCustomerDetails = new System.Windows.Forms.GroupBox();
            this.tboxSIDRNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.tboxSalesman = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tboxCIBy = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.tboxCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tboxIDnumber = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.gridDeliveryReceipt = new MetroFramework.Controls.MetroGrid();
            this.DR_Details_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDRDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnAddProduct = new MetroFramework.Controls.MetroButton();
            this.btnRemoveProduct = new MetroFramework.Controls.MetroButton();
            this.btnProceedDelivery = new MetroFramework.Controls.MetroButton();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxNetMonthly = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.tboxPN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tboxMonthlyRebate = new MetroFramework.Controls.MetroTextBox();
            this.tboxGRSMonthly = new MetroFramework.Controls.MetroTextBox();
            this.tboxTerms = new MetroFramework.Controls.MetroTextBox();
            this.tboxtotalRebate = new MetroFramework.Controls.MetroTextBox();
            this.tboxUDI = new MetroFramework.Controls.MetroTextBox();
            this.tboxTotalBalance = new MetroFramework.Controls.MetroTextBox();
            this.tboxTotalDown = new MetroFramework.Controls.MetroTextBox();
            this.tboxTotalLCP = new MetroFramework.Controls.MetroTextBox();
            this.tboxAccountNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupStep = new System.Windows.Forms.GroupBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.product_DR_DetailsTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.Product_DR_DetailsTableAdapter();
            this.groupCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliveryReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDRDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            this.groupOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(30, 135);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Account Type :";
            // 
            // cboxAccountType
            // 
            this.cboxAccountType.FormattingEnabled = true;
            this.cboxAccountType.ItemHeight = 23;
            this.cboxAccountType.Items.AddRange(new object[] {
            "Cash Sales Invoice",
            "Charge Sales Invoice",
            "Delivery Receipt"});
            this.cboxAccountType.Location = new System.Drawing.Point(135, 135);
            this.cboxAccountType.Name = "cboxAccountType";
            this.cboxAccountType.Size = new System.Drawing.Size(222, 29);
            this.cboxAccountType.TabIndex = 0;
            this.cboxAccountType.UseSelectable = true;
            this.cboxAccountType.SelectedIndexChanged += new System.EventHandler(this.cboxAccountType_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(46, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "ID Number :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // groupCustomerDetails
            // 
            this.groupCustomerDetails.BackColor = System.Drawing.Color.LimeGreen;
            this.groupCustomerDetails.Controls.Add(this.tboxSIDRNo);
            this.groupCustomerDetails.Controls.Add(this.metroLabel20);
            this.groupCustomerDetails.Controls.Add(this.tboxSalesman);
            this.groupCustomerDetails.Controls.Add(this.metroLabel6);
            this.groupCustomerDetails.Controls.Add(this.tboxCIBy);
            this.groupCustomerDetails.Controls.Add(this.metroLabel4);
            this.groupCustomerDetails.Controls.Add(this.btnSearch);
            this.groupCustomerDetails.Controls.Add(this.tboxCustomerName);
            this.groupCustomerDetails.Controls.Add(this.metroLabel3);
            this.groupCustomerDetails.Controls.Add(this.tboxIDnumber);
            this.groupCustomerDetails.Controls.Add(this.metroLabel2);
            this.groupCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCustomerDetails.Location = new System.Drawing.Point(30, 170);
            this.groupCustomerDetails.Name = "groupCustomerDetails";
            this.groupCustomerDetails.Size = new System.Drawing.Size(893, 116);
            this.groupCustomerDetails.TabIndex = 11;
            this.groupCustomerDetails.TabStop = false;
            this.groupCustomerDetails.Text = "Customer Details";
            // 
            // tboxSIDRNo
            // 
            this.tboxSIDRNo.Lines = new string[0];
            this.tboxSIDRNo.Location = new System.Drawing.Point(651, 12);
            this.tboxSIDRNo.MaxLength = 32767;
            this.tboxSIDRNo.Multiline = true;
            this.tboxSIDRNo.Name = "tboxSIDRNo";
            this.tboxSIDRNo.PasswordChar = '\0';
            this.tboxSIDRNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSIDRNo.SelectedText = "";
            this.tboxSIDRNo.Size = new System.Drawing.Size(231, 29);
            this.tboxSIDRNo.TabIndex = 1;
            this.tboxSIDRNo.UseSelectable = true;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel20.Location = new System.Drawing.Point(550, 22);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(71, 19);
            this.metroLabel20.TabIndex = 27;
            this.metroLabel20.Text = "SI/DR NO:";
            this.metroLabel20.UseCustomBackColor = true;
            // 
            // tboxSalesman
            // 
            this.tboxSalesman.Lines = new string[0];
            this.tboxSalesman.Location = new System.Drawing.Point(651, 80);
            this.tboxSalesman.MaxLength = 32767;
            this.tboxSalesman.Multiline = true;
            this.tboxSalesman.Name = "tboxSalesman";
            this.tboxSalesman.PasswordChar = '\0';
            this.tboxSalesman.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSalesman.SelectedText = "";
            this.tboxSalesman.Size = new System.Drawing.Size(231, 29);
            this.tboxSalesman.TabIndex = 3;
            this.tboxSalesman.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(548, 90);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Salesman :";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // tboxCIBy
            // 
            this.tboxCIBy.Lines = new string[0];
            this.tboxCIBy.Location = new System.Drawing.Point(651, 46);
            this.tboxCIBy.MaxLength = 32767;
            this.tboxCIBy.Multiline = true;
            this.tboxCIBy.Name = "tboxCIBy";
            this.tboxCIBy.PasswordChar = '\0';
            this.tboxCIBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxCIBy.SelectedText = "";
            this.tboxCIBy.Size = new System.Drawing.Size(231, 29);
            this.tboxCIBy.TabIndex = 2;
            this.tboxCIBy.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(573, 56);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "CI By :";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(423, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 26);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search Customer";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tboxCustomerName
            // 
            this.tboxCustomerName.Enabled = false;
            this.tboxCustomerName.Lines = new string[0];
            this.tboxCustomerName.Location = new System.Drawing.Point(186, 71);
            this.tboxCustomerName.MaxLength = 32767;
            this.tboxCustomerName.Multiline = true;
            this.tboxCustomerName.Name = "tboxCustomerName";
            this.tboxCustomerName.PasswordChar = '\0';
            this.tboxCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxCustomerName.SelectedText = "";
            this.tboxCustomerName.Size = new System.Drawing.Size(231, 29);
            this.tboxCustomerName.TabIndex = 19;
            this.tboxCustomerName.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(14, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(116, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Customer Name :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // tboxIDnumber
            // 
            this.tboxIDnumber.Enabled = false;
            this.tboxIDnumber.Lines = new string[0];
            this.tboxIDnumber.Location = new System.Drawing.Point(186, 29);
            this.tboxIDnumber.MaxLength = 32767;
            this.tboxIDnumber.Multiline = true;
            this.tboxIDnumber.Name = "tboxIDnumber";
            this.tboxIDnumber.PasswordChar = '\0';
            this.tboxIDnumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxIDnumber.SelectedText = "";
            this.tboxIDnumber.Size = new System.Drawing.Size(231, 29);
            this.tboxIDnumber.TabIndex = 17;
            this.tboxIDnumber.UseSelectable = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTime1.Location = new System.Drawing.Point(692, 139);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(4, 25);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(231, 25);
            this.metroDateTime1.TabIndex = 24;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(589, 141);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Delivery Date :";
            // 
            // gridDeliveryReceipt
            // 
            this.gridDeliveryReceipt.AllowUserToAddRows = false;
            this.gridDeliveryReceipt.AllowUserToDeleteRows = false;
            this.gridDeliveryReceipt.AllowUserToResizeRows = false;
            this.gridDeliveryReceipt.AutoGenerateColumns = false;
            this.gridDeliveryReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDeliveryReceipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDeliveryReceipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDeliveryReceipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDeliveryReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDeliveryReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDeliveryReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDeliveryReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DR_Details_ID,
            this.stockNoDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.qnty,
            this.lCPDataGridViewTextBoxColumn,
            this.description,
            this.pStatus});
            this.gridDeliveryReceipt.DataSource = this.productDRDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDeliveryReceipt.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDeliveryReceipt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridDeliveryReceipt.EnableHeadersVisualStyles = false;
            this.gridDeliveryReceipt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDeliveryReceipt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDeliveryReceipt.Location = new System.Drawing.Point(30, 292);
            this.gridDeliveryReceipt.Name = "gridDeliveryReceipt";
            this.gridDeliveryReceipt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDeliveryReceipt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDeliveryReceipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDeliveryReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDeliveryReceipt.Size = new System.Drawing.Size(893, 239);
            this.gridDeliveryReceipt.TabIndex = 12;
            this.gridDeliveryReceipt.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeliveryReceipt_CellEndEdit);
            this.gridDeliveryReceipt.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeliveryReceipt_CellLeave);
            this.gridDeliveryReceipt.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeliveryReceipt_CellValueChanged);
            // 
            // DR_Details_ID
            // 
            this.DR_Details_ID.DataPropertyName = "DR_Details_ID";
            this.DR_Details_ID.HeaderText = "DR_Details_ID";
            this.DR_Details_ID.Name = "DR_Details_ID";
            this.DR_Details_ID.ReadOnly = true;
            this.DR_Details_ID.Visible = false;
            // 
            // stockNoDataGridViewTextBoxColumn
            // 
            this.stockNoDataGridViewTextBoxColumn.DataPropertyName = "stockNo";
            this.stockNoDataGridViewTextBoxColumn.HeaderText = "stockNo";
            this.stockNoDataGridViewTextBoxColumn.Name = "stockNoDataGridViewTextBoxColumn";
            this.stockNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "serialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "serialNo";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // qnty
            // 
            this.qnty.DataPropertyName = "qnty";
            this.qnty.HeaderText = "qnty";
            this.qnty.Name = "qnty";
            this.qnty.ReadOnly = true;
            // 
            // lCPDataGridViewTextBoxColumn
            // 
            this.lCPDataGridViewTextBoxColumn.DataPropertyName = "LCP";
            this.lCPDataGridViewTextBoxColumn.HeaderText = "LCP";
            this.lCPDataGridViewTextBoxColumn.Name = "lCPDataGridViewTextBoxColumn";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Items.AddRange(new object[] {
            "LCP",
            "COD"});
            this.description.Name = "description";
            // 
            // pStatus
            // 
            this.pStatus.DataPropertyName = "pStatus";
            this.pStatus.HeaderText = "Product Status";
            this.pStatus.Name = "pStatus";
            this.pStatus.ReadOnly = true;
            // 
            // productDRDetailsBindingSource
            // 
            this.productDRDetailsBindingSource.DataMember = "Product_DR_Details";
            this.productDRDetailsBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(6, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 34);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddProduct.Location = new System.Drawing.Point(411, 29);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(147, 34);
            this.btnAddProduct.TabIndex = 14;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseSelectable = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRemoveProduct.Location = new System.Drawing.Point(573, 29);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(147, 34);
            this.btnRemoveProduct.TabIndex = 15;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseSelectable = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnProceedDelivery
            // 
            this.btnProceedDelivery.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnProceedDelivery.Location = new System.Drawing.Point(735, 29);
            this.btnProceedDelivery.Name = "btnProceedDelivery";
            this.btnProceedDelivery.Size = new System.Drawing.Size(147, 34);
            this.btnProceedDelivery.TabIndex = 16;
            this.btnProceedDelivery.Text = "Proceed Delivery";
            this.btnProceedDelivery.UseSelectable = true;
            this.btnProceedDelivery.Click += new System.EventHandler(this.btnProceedDelivery_Click);
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.btnAddProduct);
            this.groupOptions.Controls.Add(this.btnBack);
            this.groupOptions.Controls.Add(this.btnProceedDelivery);
            this.groupOptions.Controls.Add(this.btnRemoveProduct);
            this.groupOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupOptions.Location = new System.Drawing.Point(30, 538);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(893, 82);
            this.groupOptions.TabIndex = 17;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Options";
            this.groupOptions.Enter += new System.EventHandler(this.groupOptions_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tboxNetMonthly);
            this.panel1.Controls.Add(this.metroLabel17);
            this.panel1.Controls.Add(this.tboxPN);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.tboxMonthlyRebate);
            this.panel1.Controls.Add(this.tboxGRSMonthly);
            this.panel1.Controls.Add(this.tboxTerms);
            this.panel1.Controls.Add(this.tboxtotalRebate);
            this.panel1.Controls.Add(this.tboxUDI);
            this.panel1.Controls.Add(this.tboxTotalBalance);
            this.panel1.Controls.Add(this.tboxTotalDown);
            this.panel1.Controls.Add(this.tboxTotalLCP);
            this.panel1.Controls.Add(this.tboxAccountNo);
            this.panel1.Controls.Add(this.metroLabel16);
            this.panel1.Controls.Add(this.metroLabel15);
            this.panel1.Controls.Add(this.metroLabel14);
            this.panel1.Controls.Add(this.metroLabel13);
            this.panel1.Controls.Add(this.metroLabel12);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(974, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 491);
            this.panel1.TabIndex = 18;
            // 
            // tboxNetMonthly
            // 
            this.tboxNetMonthly.Lines = new string[] {
        "0.00"};
            this.tboxNetMonthly.Location = new System.Drawing.Point(132, 440);
            this.tboxNetMonthly.MaxLength = 32767;
            this.tboxNetMonthly.Multiline = true;
            this.tboxNetMonthly.Name = "tboxNetMonthly";
            this.tboxNetMonthly.PasswordChar = '\0';
            this.tboxNetMonthly.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxNetMonthly.SelectedText = "";
            this.tboxNetMonthly.Size = new System.Drawing.Size(231, 29);
            this.tboxNetMonthly.TabIndex = 48;
            this.tboxNetMonthly.Text = "0.00";
            this.tboxNetMonthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxNetMonthly.UseSelectable = true;
            this.tboxNetMonthly.TextChanged += new System.EventHandler(this.metroTextBox2_TextChanged);
            this.tboxNetMonthly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxNetMonthly_KeyPress);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(32, 450);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(94, 19);
            this.metroLabel17.TabIndex = 47;
            this.metroLabel17.Text = "Net Monthly :";
            this.metroLabel17.UseCustomBackColor = true;
            // 
            // tboxPN
            // 
            this.tboxPN.Enabled = false;
            this.tboxPN.Lines = new string[] {
        "0.00"};
            this.tboxPN.Location = new System.Drawing.Point(133, 283);
            this.tboxPN.MaxLength = 32767;
            this.tboxPN.Multiline = true;
            this.tboxPN.Name = "tboxPN";
            this.tboxPN.PasswordChar = '\0';
            this.tboxPN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxPN.SelectedText = "";
            this.tboxPN.Size = new System.Drawing.Size(231, 29);
            this.tboxPN.TabIndex = 46;
            this.tboxPN.Text = "0.00";
            this.tboxPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxPN.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(93, 293);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(34, 19);
            this.metroLabel7.TabIndex = 45;
            this.metroLabel7.Text = "PN :";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // tboxMonthlyRebate
            // 
            this.tboxMonthlyRebate.Enabled = false;
            this.tboxMonthlyRebate.Lines = new string[] {
        "0.00"};
            this.tboxMonthlyRebate.Location = new System.Drawing.Point(133, 406);
            this.tboxMonthlyRebate.MaxLength = 32767;
            this.tboxMonthlyRebate.Multiline = true;
            this.tboxMonthlyRebate.Name = "tboxMonthlyRebate";
            this.tboxMonthlyRebate.PasswordChar = '\0';
            this.tboxMonthlyRebate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxMonthlyRebate.SelectedText = "";
            this.tboxMonthlyRebate.Size = new System.Drawing.Size(231, 29);
            this.tboxMonthlyRebate.TabIndex = 44;
            this.tboxMonthlyRebate.Text = "0.00";
            this.tboxMonthlyRebate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxMonthlyRebate.UseSelectable = true;
            // 
            // tboxGRSMonthly
            // 
            this.tboxGRSMonthly.Enabled = false;
            this.tboxGRSMonthly.Lines = new string[] {
        "0.00"};
            this.tboxGRSMonthly.Location = new System.Drawing.Point(132, 371);
            this.tboxGRSMonthly.MaxLength = 32767;
            this.tboxGRSMonthly.Multiline = true;
            this.tboxGRSMonthly.Name = "tboxGRSMonthly";
            this.tboxGRSMonthly.PasswordChar = '\0';
            this.tboxGRSMonthly.ReadOnly = true;
            this.tboxGRSMonthly.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxGRSMonthly.SelectedText = "";
            this.tboxGRSMonthly.Size = new System.Drawing.Size(231, 29);
            this.tboxGRSMonthly.TabIndex = 43;
            this.tboxGRSMonthly.Text = "0.00";
            this.tboxGRSMonthly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxGRSMonthly.UseSelectable = true;
            this.tboxGRSMonthly.TextChanged += new System.EventHandler(this.tboxGRSMonthly_TextChanged);
            this.tboxGRSMonthly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxGRSMonthly_KeyPress);
            // 
            // tboxTerms
            // 
            this.tboxTerms.Lines = new string[] {
        "1"};
            this.tboxTerms.Location = new System.Drawing.Point(133, 248);
            this.tboxTerms.MaxLength = 32767;
            this.tboxTerms.Multiline = true;
            this.tboxTerms.Name = "tboxTerms";
            this.tboxTerms.PasswordChar = '\0';
            this.tboxTerms.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxTerms.SelectedText = "";
            this.tboxTerms.Size = new System.Drawing.Size(231, 29);
            this.tboxTerms.TabIndex = 42;
            this.tboxTerms.Text = "1";
            this.tboxTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxTerms.UseSelectable = true;
            this.tboxTerms.TextChanged += new System.EventHandler(this.tboxTerms_TextChanged);
            // 
            // tboxtotalRebate
            // 
            this.tboxtotalRebate.Enabled = false;
            this.tboxtotalRebate.Lines = new string[] {
        "0.00"};
            this.tboxtotalRebate.Location = new System.Drawing.Point(133, 213);
            this.tboxtotalRebate.MaxLength = 32767;
            this.tboxtotalRebate.Multiline = true;
            this.tboxtotalRebate.Name = "tboxtotalRebate";
            this.tboxtotalRebate.PasswordChar = '\0';
            this.tboxtotalRebate.ReadOnly = true;
            this.tboxtotalRebate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxtotalRebate.SelectedText = "";
            this.tboxtotalRebate.Size = new System.Drawing.Size(231, 29);
            this.tboxtotalRebate.TabIndex = 41;
            this.tboxtotalRebate.Text = "0.00";
            this.tboxtotalRebate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxtotalRebate.UseSelectable = true;
            this.tboxtotalRebate.TextChanged += new System.EventHandler(this.tboxRebate_TextChanged);
            this.tboxtotalRebate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxRebate_KeyPress);
            // 
            // tboxUDI
            // 
            this.tboxUDI.Enabled = false;
            this.tboxUDI.Lines = new string[] {
        "0.00"};
            this.tboxUDI.Location = new System.Drawing.Point(133, 178);
            this.tboxUDI.MaxLength = 32767;
            this.tboxUDI.Multiline = true;
            this.tboxUDI.Name = "tboxUDI";
            this.tboxUDI.PasswordChar = '\0';
            this.tboxUDI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxUDI.SelectedText = "";
            this.tboxUDI.Size = new System.Drawing.Size(231, 29);
            this.tboxUDI.TabIndex = 40;
            this.tboxUDI.Text = "0.00";
            this.tboxUDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxUDI.UseSelectable = true;
            // 
            // tboxTotalBalance
            // 
            this.tboxTotalBalance.Enabled = false;
            this.tboxTotalBalance.Lines = new string[] {
        "0.00"};
            this.tboxTotalBalance.Location = new System.Drawing.Point(134, 142);
            this.tboxTotalBalance.MaxLength = 32767;
            this.tboxTotalBalance.Multiline = true;
            this.tboxTotalBalance.Name = "tboxTotalBalance";
            this.tboxTotalBalance.PasswordChar = '\0';
            this.tboxTotalBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxTotalBalance.SelectedText = "";
            this.tboxTotalBalance.Size = new System.Drawing.Size(231, 29);
            this.tboxTotalBalance.TabIndex = 39;
            this.tboxTotalBalance.Text = "0.00";
            this.tboxTotalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxTotalBalance.UseSelectable = true;
            // 
            // tboxTotalDown
            // 
            this.tboxTotalDown.Lines = new string[] {
        "0.00"};
            this.tboxTotalDown.Location = new System.Drawing.Point(133, 105);
            this.tboxTotalDown.MaxLength = 32767;
            this.tboxTotalDown.Multiline = true;
            this.tboxTotalDown.Name = "tboxTotalDown";
            this.tboxTotalDown.PasswordChar = '\0';
            this.tboxTotalDown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxTotalDown.SelectedText = "";
            this.tboxTotalDown.Size = new System.Drawing.Size(231, 29);
            this.tboxTotalDown.TabIndex = 38;
            this.tboxTotalDown.Text = "0.00";
            this.tboxTotalDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxTotalDown.UseSelectable = true;
            this.tboxTotalDown.TextChanged += new System.EventHandler(this.tboxTotalDown_TextChanged);
            this.tboxTotalDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxTotalDown_KeyPress);
            this.tboxTotalDown.Leave += new System.EventHandler(this.tboxTotalDown_Leave);
            // 
            // tboxTotalLCP
            // 
            this.tboxTotalLCP.Enabled = false;
            this.tboxTotalLCP.Lines = new string[0];
            this.tboxTotalLCP.Location = new System.Drawing.Point(134, 47);
            this.tboxTotalLCP.MaxLength = 32767;
            this.tboxTotalLCP.Multiline = true;
            this.tboxTotalLCP.Name = "tboxTotalLCP";
            this.tboxTotalLCP.PasswordChar = '\0';
            this.tboxTotalLCP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxTotalLCP.SelectedText = "";
            this.tboxTotalLCP.Size = new System.Drawing.Size(231, 29);
            this.tboxTotalLCP.TabIndex = 37;
            this.tboxTotalLCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxTotalLCP.UseSelectable = true;
            this.tboxTotalLCP.TextChanged += new System.EventHandler(this.tboxTotalLCP_TextChanged);
            // 
            // tboxAccountNo
            // 
            this.tboxAccountNo.Lines = new string[0];
            this.tboxAccountNo.Location = new System.Drawing.Point(133, 12);
            this.tboxAccountNo.MaxLength = 32767;
            this.tboxAccountNo.Multiline = true;
            this.tboxAccountNo.Name = "tboxAccountNo";
            this.tboxAccountNo.PasswordChar = '\0';
            this.tboxAccountNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxAccountNo.SelectedText = "";
            this.tboxAccountNo.Size = new System.Drawing.Size(231, 29);
            this.tboxAccountNo.TabIndex = 4;
            this.tboxAccountNo.UseSelectable = true;
            this.tboxAccountNo.TextChanged += new System.EventHandler(this.tboxAccountNo_TextChanged);
            this.tboxAccountNo.Leave += new System.EventHandler(this.tboxAccountNo_Leave);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(19, 414);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(114, 19);
            this.metroLabel16.TabIndex = 35;
            this.metroLabel16.Text = "Monthly Rebate :";
            this.metroLabel16.UseCustomBackColor = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(36, 380);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(97, 19);
            this.metroLabel15.TabIndex = 34;
            this.metroLabel15.Text = "GRS Monthly :";
            this.metroLabel15.UseCustomBackColor = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(93, 186);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(40, 19);
            this.metroLabel14.TabIndex = 33;
            this.metroLabel14.Text = "UDI :";
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(80, 253);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(53, 19);
            this.metroLabel13.TabIndex = 32;
            this.metroLabel13.Text = "Terms :";
            this.metroLabel13.UseCustomBackColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(37, 223);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(92, 19);
            this.metroLabel12.TabIndex = 31;
            this.metroLabel12.Text = "Total Rebate :";
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(37, 151);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(96, 19);
            this.metroLabel11.TabIndex = 30;
            this.metroLabel11.Text = "Total Balance :";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(47, 114);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(86, 19);
            this.metroLabel10.TabIndex = 29;
            this.metroLabel10.Text = "Total Down :";
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(58, 57);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 19);
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Total LCP :";
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(11, 19);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(120, 19);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Account Number :";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(376, 489);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 8;
            this.lineShape2.X2 = 368;
            this.lineShape2.Y1 = 351;
            this.lineShape2.Y2 = 351;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 2;
            this.lineShape1.X2 = 363;
            this.lineShape1.Y1 = 92;
            this.lineShape1.Y2 = 92;
            // 
            // groupStep
            // 
            this.groupStep.Controls.Add(this.metroLabel18);
            this.groupStep.Controls.Add(this.metroLabel19);
            this.groupStep.Location = new System.Drawing.Point(36, 68);
            this.groupStep.Name = "groupStep";
            this.groupStep.Size = new System.Drawing.Size(1322, 46);
            this.groupStep.TabIndex = 19;
            this.groupStep.TabStop = false;
            this.groupStep.Text = "Steps";
            this.groupStep.Visible = false;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(198, 16);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(30, 19);
            this.metroLabel18.TabIndex = 8;
            this.metroLabel18.Text = "2/3";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(52, 16);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(127, 19);
            this.metroLabel19.TabIndex = 7;
            this.metroLabel19.Text = "CREATE DELIVERY :";
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -36;
            this.lineShape3.X2 = 1375;
            this.lineShape3.Y1 = 1;
            this.lineShape3.Y2 = 1;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(1330, 554);
            this.shapeContainer2.TabIndex = 25;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = -54;
            this.lineShape4.X2 = 1357;
            this.lineShape4.Y1 = 5;
            this.lineShape4.Y2 = 5;
            // 
            // product_DR_DetailsTableAdapter
            // 
            this.product_DR_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 634);
            this.Controls.Add(this.groupStep);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.gridDeliveryReceipt);
            this.Controls.Add(this.groupCustomerDetails);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cboxAccountType);
            this.Controls.Add(this.shapeContainer2);
            this.Movable = false;
            this.Name = "deliveryReceipt";
            this.Resizable = false;
            this.Text = "Delivery Receipt";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.deliveryReceipt_Load);
            this.groupCustomerDetails.ResumeLayout(false);
            this.groupCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeliveryReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDRDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            this.groupOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupStep.ResumeLayout(false);
            this.groupStep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboxAccountType;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupCustomerDetails;
        private MetroFramework.Controls.MetroTextBox tboxCustomerName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tboxIDnumber;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox tboxSalesman;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tboxCIBy;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid gridDeliveryReceipt;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnAddProduct;
        private MetroFramework.Controls.MetroButton btnRemoveProduct;
        private MetroFramework.Controls.MetroButton btnProceedDelivery;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MetroFramework.Controls.MetroTextBox tboxMonthlyRebate;
        private MetroFramework.Controls.MetroTextBox tboxGRSMonthly;
        private MetroFramework.Controls.MetroTextBox tboxTerms;
        private MetroFramework.Controls.MetroTextBox tboxtotalRebate;
        private MetroFramework.Controls.MetroTextBox tboxUDI;
        private MetroFramework.Controls.MetroTextBox tboxTotalBalance;
        private MetroFramework.Controls.MetroTextBox tboxTotalDown;
        private MetroFramework.Controls.MetroTextBox tboxTotalLCP;
        private MetroFramework.Controls.MetroTextBox tboxAccountNo;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource productDRDetailsBindingSource;
        private citiAppDatabaseDataSetTableAdapters.Product_DR_DetailsTableAdapter product_DR_DetailsTableAdapter;
        private MetroFramework.Controls.MetroTextBox tboxNetMonthly;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox tboxPN;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.GroupBox groupStep;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private MetroFramework.Controls.MetroTextBox tboxSIDRNo;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private System.Windows.Forms.DataGridViewTextBoxColumn DR_Details_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn pStatus;
    }
}