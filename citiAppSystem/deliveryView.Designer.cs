namespace citiAppSystem
{
    partial class deliveryView
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
            this.gridDR = new MetroFramework.Controls.MetroGrid();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryViewTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnUpdateDelivery = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.tboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.labelStart = new MetroFramework.Controls.MetroLabel();
            this.metroDateStart = new MetroFramework.Controls.MetroDateTime();
            this.labelEnd = new MetroFramework.Controls.MetroLabel();
            this.metroDateEnd = new MetroFramework.Controls.MetroDateTime();
            this.labelSearch = new MetroFramework.Controls.MetroLabel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cboxStatus = new System.Windows.Forms.ComboBox();
            this.deliveryView_TableTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.DeliveryView_TableTableAdapter();
            this.btnViewDetails = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryViewTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDR
            // 
            this.gridDR.AllowUserToAddRows = false;
            this.gridDR.AllowUserToDeleteRows = false;
            this.gridDR.AllowUserToResizeRows = false;
            this.gridDR.AutoGenerateColumns = false;
            this.gridDR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountNoDataGridViewTextBoxColumn,
            this.iDNumberDataGridViewTextBoxColumn,
            this.collectionIDDataGridViewTextBoxColumn,
            this.fullName,
            this.accountTypeDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.gridDR.DataSource = this.deliveryViewTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDR.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDR.EnableHeadersVisualStyles = false;
            this.gridDR.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDR.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDR.Location = new System.Drawing.Point(20, 129);
            this.gridDR.Name = "gridDR";
            this.gridDR.ReadOnly = true;
            this.gridDR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDR.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDR.Size = new System.Drawing.Size(986, 249);
            this.gridDR.TabIndex = 0;
            this.gridDR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDR_CellClick);
            this.gridDR.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDR_CellDoubleClick);
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDNumberDataGridViewTextBoxColumn
            // 
            this.iDNumberDataGridViewTextBoxColumn.DataPropertyName = "ID_Number";
            this.iDNumberDataGridViewTextBoxColumn.HeaderText = "ID_Number";
            this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
            this.iDNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // collectionIDDataGridViewTextBoxColumn
            // 
            this.collectionIDDataGridViewTextBoxColumn.DataPropertyName = "Collection_ID";
            this.collectionIDDataGridViewTextBoxColumn.HeaderText = "Collection_ID";
            this.collectionIDDataGridViewTextBoxColumn.Name = "collectionIDDataGridViewTextBoxColumn";
            this.collectionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.collectionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "Customer Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "Account_Type";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "Account_Type";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "Delivery_Date";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Delivery_Date";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryViewTableBindingSource
            // 
            this.deliveryViewTableBindingSource.DataMember = "DeliveryView_Table";
            this.deliveryViewTableBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(20, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 31);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdateDelivery
            // 
            this.btnUpdateDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDelivery.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateDelivery.Location = new System.Drawing.Point(825, 400);
            this.btnUpdateDelivery.Name = "btnUpdateDelivery";
            this.btnUpdateDelivery.Size = new System.Drawing.Size(181, 31);
            this.btnUpdateDelivery.TabIndex = 7;
            this.btnUpdateDelivery.Text = "DELIVERY";
            this.btnUpdateDelivery.UseSelectable = true;
            this.btnUpdateDelivery.Click += new System.EventHandler(this.btnNewDelivery_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(28, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "SEARCH BY:";
            // 
            // cboxSearchBy
            // 
            this.cboxSearchBy.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboxSearchBy.FormattingEnabled = true;
            this.cboxSearchBy.ItemHeight = 19;
            this.cboxSearchBy.Items.AddRange(new object[] {
            "AccountNo",
            "Account Type",
            "Status",
            "Name",
            "Date"});
            this.cboxSearchBy.Location = new System.Drawing.Point(28, 98);
            this.cboxSearchBy.Name = "cboxSearchBy";
            this.cboxSearchBy.Size = new System.Drawing.Size(214, 25);
            this.cboxSearchBy.TabIndex = 13;
            this.cboxSearchBy.UseSelectable = true;
            this.cboxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cboxSearchBy_SelectedIndexChanged);
            // 
            // tboxSearch
            // 
            this.tboxSearch.Lines = new string[0];
            this.tboxSearch.Location = new System.Drawing.Point(248, 98);
            this.tboxSearch.MaxLength = 32767;
            this.tboxSearch.Multiline = true;
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.PasswordChar = '\0';
            this.tboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSearch.SelectedText = "";
            this.tboxSearch.Size = new System.Drawing.Size(432, 25);
            this.tboxSearch.TabIndex = 11;
            this.tboxSearch.UseSelectable = true;
            this.tboxSearch.TextChanged += new System.EventHandler(this.tboxSearch_TextChanged);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelStart.Location = new System.Drawing.Point(246, 76);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(41, 19);
            this.labelStart.TabIndex = 16;
            this.labelStart.Text = "Start";
            // 
            // metroDateStart
            // 
            this.metroDateStart.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateStart.Location = new System.Drawing.Point(248, 98);
            this.metroDateStart.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateStart.Name = "metroDateStart";
            this.metroDateStart.Size = new System.Drawing.Size(214, 25);
            this.metroDateStart.TabIndex = 15;
            this.metroDateStart.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelEnd.Location = new System.Drawing.Point(466, 76);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(33, 19);
            this.labelEnd.TabIndex = 18;
            this.labelEnd.Text = "End";
            // 
            // metroDateEnd
            // 
            this.metroDateEnd.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateEnd.Location = new System.Drawing.Point(466, 98);
            this.metroDateEnd.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateEnd.Name = "metroDateEnd";
            this.metroDateEnd.Size = new System.Drawing.Size(214, 25);
            this.metroDateEnd.TabIndex = 17;
            this.metroDateEnd.ValueChanged += new System.EventHandler(this.metroDateEnd_ValueChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelSearch.Location = new System.Drawing.Point(248, 76);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(58, 19);
            this.labelSearch.TabIndex = 19;
            this.labelSearch.Text = "Search:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(989, 371);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = -5;
            this.lineShape4.X2 = 1166;
            this.lineShape4.Y1 = 332;
            this.lineShape4.Y2 = 332;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -15;
            this.lineShape3.X2 = 1156;
            this.lineShape3.Y1 = 327;
            this.lineShape3.Y2 = 327;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 7;
            this.lineShape2.X2 = 1178;
            this.lineShape2.Y1 = 5;
            this.lineShape2.Y2 = 5;
            this.lineShape2.Click += new System.EventHandler(this.lineShape2_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 1178;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 0;
            // 
            // cboxStatus
            // 
            this.cboxStatus.FormattingEnabled = true;
            this.cboxStatus.Items.AddRange(new object[] {
            "Paid",
            "Pending"});
            this.cboxStatus.Location = new System.Drawing.Point(248, 98);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Size = new System.Drawing.Size(164, 21);
            this.cboxStatus.TabIndex = 22;
            this.cboxStatus.Visible = false;
            this.cboxStatus.SelectedIndexChanged += new System.EventHandler(this.cboxStatus_SelectedIndexChanged);
            // 
            // deliveryView_TableTableAdapter
            // 
            this.deliveryView_TableTableAdapter.ClearBeforeFill = true;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDetails.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnViewDetails.Location = new System.Drawing.Point(815, 92);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(181, 31);
            this.btnViewDetails.TabIndex = 23;
            this.btnViewDetails.Text = "VIEW DETAILS";
            this.btnViewDetails.UseSelectable = true;
            this.btnViewDetails.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // deliveryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 451);
            this.ControlBox = false;
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.cboxStatus);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.metroDateEnd);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroDateStart);
            this.Controls.Add(this.cboxSearchBy);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.btnUpdateDelivery);
            this.Controls.Add(this.gridDR);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "deliveryView";
            this.Resizable = false;
            this.Text = "Delivery Receipt List";
            this.Load += new System.EventHandler(this.deliveryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryViewTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridDR;
        private MetroFramework.Controls.MetroButton btnBack;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource deliveryViewTableBindingSource;
        private citiAppDatabaseDataSetTableAdapters.DeliveryView_TableTableAdapter deliveryView_TableTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboxSearchBy;
        private MetroFramework.Controls.MetroTextBox tboxSearch;
        private MetroFramework.Controls.MetroLabel labelStart;
        private MetroFramework.Controls.MetroDateTime metroDateStart;
        private MetroFramework.Controls.MetroLabel labelEnd;
        private MetroFramework.Controls.MetroDateTime metroDateEnd;
        private MetroFramework.Controls.MetroLabel labelSearch;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.ComboBox cboxStatus;
        private MetroFramework.Controls.MetroButton btnViewDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        public MetroFramework.Controls.MetroButton btnUpdateDelivery;
    }
}