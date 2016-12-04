namespace citiAppSystem
{
    partial class purchaseOrderDetailsVIEW
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
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.cboxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.gridPODetails = new MetroFramework.Controls.MetroGrid();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.poDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.poDetailsTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poDetailsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holderQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPODetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -232;
            this.lineShape3.X2 = 1097;
            this.lineShape3.Y1 = 2;
            this.lineShape3.Y2 = 3;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -299;
            this.lineShape1.X2 = 1101;
            this.lineShape1.Y1 = 6;
            this.lineShape1.Y2 = 6;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2,
            this.lineShape1,
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(1123, 402);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = -139;
            this.lineShape4.X2 = 1261;
            this.lineShape4.Y1 = 325;
            this.lineShape4.Y2 = 325;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -72;
            this.lineShape2.X2 = 1257;
            this.lineShape2.Y1 = 321;
            this.lineShape2.Y2 = 322;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(299, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "SEARCH:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(31, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "SEARCH BY:";
            // 
            // tboxSearch
            // 
            this.tboxSearch.Lines = new string[0];
            this.tboxSearch.Location = new System.Drawing.Point(370, 81);
            this.tboxSearch.MaxLength = 32767;
            this.tboxSearch.Multiline = true;
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.PasswordChar = '\0';
            this.tboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSearch.SelectedText = "";
            this.tboxSearch.Size = new System.Drawing.Size(324, 24);
            this.tboxSearch.TabIndex = 16;
            this.tboxSearch.UseSelectable = true;
            // 
            // cboxSearchBy
            // 
            this.cboxSearchBy.DropDownHeight = 100;
            this.cboxSearchBy.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboxSearchBy.FormattingEnabled = true;
            this.cboxSearchBy.IntegralHeight = false;
            this.cboxSearchBy.ItemHeight = 19;
            this.cboxSearchBy.Items.AddRange(new object[] {
            "PO Number",
            "Supplier Name"});
            this.cboxSearchBy.Location = new System.Drawing.Point(126, 81);
            this.cboxSearchBy.Name = "cboxSearchBy";
            this.cboxSearchBy.Size = new System.Drawing.Size(161, 25);
            this.cboxSearchBy.TabIndex = 15;
            this.cboxSearchBy.UseSelectable = true;
            // 
            // gridPODetails
            // 
            this.gridPODetails.AllowUserToAddRows = false;
            this.gridPODetails.AllowUserToDeleteRows = false;
            this.gridPODetails.AllowUserToResizeRows = false;
            this.gridPODetails.AutoGenerateColumns = false;
            this.gridPODetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPODetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPODetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPODetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPODetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPODetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPODetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPODetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.orderedQTYDataGridViewTextBoxColumn,
            this.freeQTYDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.totalQtyDataGridViewTextBoxColumn,
            this.poDetailsIDDataGridViewTextBoxColumn,
            this.poIDDataGridViewTextBoxColumn,
            this.remainingQTY,
            this.holderQTY});
            this.gridPODetails.DataSource = this.poDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPODetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPODetails.EnableHeadersVisualStyles = false;
            this.gridPODetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPODetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPODetails.Location = new System.Drawing.Point(21, 112);
            this.gridPODetails.Name = "gridPODetails";
            this.gridPODetails.ReadOnly = true;
            this.gridPODetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPODetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPODetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPODetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPODetails.Size = new System.Drawing.Size(1122, 258);
            this.gridPODetails.TabIndex = 19;
            this.gridPODetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridCustomer_MouseDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(19, 416);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 32);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // poDetailsBindingSource
            // 
            this.poDetailsBindingSource.DataMember = "poDetails";
            this.poDetailsBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poDetailsTableAdapter
            // 
            this.poDetailsTableAdapter.ClearBeforeFill = true;
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
            // orderedQTYDataGridViewTextBoxColumn
            // 
            this.orderedQTYDataGridViewTextBoxColumn.DataPropertyName = "orderedQTY";
            this.orderedQTYDataGridViewTextBoxColumn.HeaderText = "orderedQTY";
            this.orderedQTYDataGridViewTextBoxColumn.Name = "orderedQTYDataGridViewTextBoxColumn";
            this.orderedQTYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freeQTYDataGridViewTextBoxColumn
            // 
            this.freeQTYDataGridViewTextBoxColumn.DataPropertyName = "freeQTY";
            this.freeQTYDataGridViewTextBoxColumn.HeaderText = "freeQTY";
            this.freeQTYDataGridViewTextBoxColumn.Name = "freeQTYDataGridViewTextBoxColumn";
            this.freeQTYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalQtyDataGridViewTextBoxColumn
            // 
            this.totalQtyDataGridViewTextBoxColumn.DataPropertyName = "totalQty";
            this.totalQtyDataGridViewTextBoxColumn.HeaderText = "totalQty";
            this.totalQtyDataGridViewTextBoxColumn.Name = "totalQtyDataGridViewTextBoxColumn";
            this.totalQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalQtyDataGridViewTextBoxColumn.Visible = false;
            // 
            // poDetailsIDDataGridViewTextBoxColumn
            // 
            this.poDetailsIDDataGridViewTextBoxColumn.DataPropertyName = "poDetails_ID";
            this.poDetailsIDDataGridViewTextBoxColumn.HeaderText = "poDetails_ID";
            this.poDetailsIDDataGridViewTextBoxColumn.Name = "poDetailsIDDataGridViewTextBoxColumn";
            this.poDetailsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.poDetailsIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // poIDDataGridViewTextBoxColumn
            // 
            this.poIDDataGridViewTextBoxColumn.DataPropertyName = "poID";
            this.poIDDataGridViewTextBoxColumn.HeaderText = "poID";
            this.poIDDataGridViewTextBoxColumn.Name = "poIDDataGridViewTextBoxColumn";
            this.poIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.poIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // remainingQTY
            // 
            this.remainingQTY.DataPropertyName = "remainingQTY";
            this.remainingQTY.HeaderText = "remainingQTY";
            this.remainingQTY.Name = "remainingQTY";
            this.remainingQTY.ReadOnly = true;
            // 
            // holderQTY
            // 
            this.holderQTY.DataPropertyName = "holderQTY";
            this.holderQTY.HeaderText = "holderQTY";
            this.holderQTY.Name = "holderQTY";
            this.holderQTY.ReadOnly = true;
            this.holderQTY.Visible = false;
            // 
            // purchaseOrderDetailsVIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 482);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gridPODetails);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.cboxSearchBy);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "purchaseOrderDetailsVIEW";
            this.Text = "Purchase Order Details View";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.purchaseOrderDetailsVIEW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPODetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tboxSearch;
        private MetroFramework.Controls.MetroComboBox cboxSearchBy;
        private MetroFramework.Controls.MetroGrid gridPODetails;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private MetroFramework.Controls.MetroButton btnBack;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource poDetailsBindingSource;
        private citiAppDatabaseDataSetTableAdapters.poDetailsTableAdapter poDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poDetailsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn holderQTY;
    }
}