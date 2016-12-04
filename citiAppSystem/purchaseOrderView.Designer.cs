namespace citiAppSystem
{
    partial class purchaseOrderView
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
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.gridPurchaseOrder = new MetroFramework.Controls.MetroGrid();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.cboxSearchBy = new MetroFramework.Controls.MetroComboBox();
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.pOViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pO_ViewTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.PO_ViewTableAdapter();
            this.poID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supIDnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -247;
            this.lineShape1.X2 = 1153;
            this.lineShape1.Y1 = 6;
            this.lineShape1.Y2 = 6;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -180;
            this.lineShape3.X2 = 1149;
            this.lineShape3.Y1 = 2;
            this.lineShape3.Y2 = 3;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2,
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1123, 402);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = -139;
            this.lineShape4.X2 = 1261;
            this.lineShape4.Y1 = 348;
            this.lineShape4.Y2 = 348;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -72;
            this.lineShape2.X2 = 1257;
            this.lineShape2.Y1 = 344;
            this.lineShape2.Y2 = 345;
            // 
            // gridPurchaseOrder
            // 
            this.gridPurchaseOrder.AllowUserToAddRows = false;
            this.gridPurchaseOrder.AllowUserToDeleteRows = false;
            this.gridPurchaseOrder.AllowUserToResizeRows = false;
            this.gridPurchaseOrder.AutoGenerateColumns = false;
            this.gridPurchaseOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPurchaseOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPurchaseOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPurchaseOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPurchaseOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPurchaseOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poID,
            this.poDateDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.branchNoDataGridViewTextBoxColumn,
            this.approvedByDataGridViewTextBoxColumn,
            this.supIDnoDataGridViewTextBoxColumn});
            this.gridPurchaseOrder.DataSource = this.pOViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPurchaseOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPurchaseOrder.EnableHeadersVisualStyles = false;
            this.gridPurchaseOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPurchaseOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPurchaseOrder.Location = new System.Drawing.Point(21, 123);
            this.gridPurchaseOrder.Name = "gridPurchaseOrder";
            this.gridPurchaseOrder.ReadOnly = true;
            this.gridPurchaseOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPurchaseOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPurchaseOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPurchaseOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPurchaseOrder.Size = new System.Drawing.Size(1122, 258);
            this.gridPurchaseOrder.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(20, 432);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 32);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPrint.Location = new System.Drawing.Point(1018, 427);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(122, 32);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNew.Location = new System.Drawing.Point(873, 428);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(137, 32);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Add New";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(296, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "SEARCH:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(28, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "SEARCH BY:";
            // 
            // tboxSearch
            // 
            this.tboxSearch.Lines = new string[0];
            this.tboxSearch.Location = new System.Drawing.Point(367, 81);
            this.tboxSearch.MaxLength = 32767;
            this.tboxSearch.Multiline = true;
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.PasswordChar = '\0';
            this.tboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSearch.SelectedText = "";
            this.tboxSearch.Size = new System.Drawing.Size(324, 24);
            this.tboxSearch.TabIndex = 12;
            this.tboxSearch.UseSelectable = true;
            this.tboxSearch.TextChanged += new System.EventHandler(this.tboxSearch_TextChanged);
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
            this.cboxSearchBy.Location = new System.Drawing.Point(123, 81);
            this.cboxSearchBy.Name = "cboxSearchBy";
            this.cboxSearchBy.Size = new System.Drawing.Size(161, 25);
            this.cboxSearchBy.TabIndex = 11;
            this.cboxSearchBy.UseSelectable = true;
            this.cboxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cboxSearchBy_SelectedIndexChanged);
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOViewBindingSource
            // 
            this.pOViewBindingSource.DataMember = "PO_View";
            this.pOViewBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // pO_ViewTableAdapter
            // 
            this.pO_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // poID
            // 
            this.poID.DataPropertyName = "poID";
            this.poID.HeaderText = "PO Number";
            this.poID.Name = "poID";
            this.poID.ReadOnly = true;
            // 
            // poDateDataGridViewTextBoxColumn
            // 
            this.poDateDataGridViewTextBoxColumn.DataPropertyName = "poDate";
            this.poDateDataGridViewTextBoxColumn.HeaderText = "PO Date";
            this.poDateDataGridViewTextBoxColumn.Name = "poDateDataGridViewTextBoxColumn";
            this.poDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Delivery Date";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchNoDataGridViewTextBoxColumn
            // 
            this.branchNoDataGridViewTextBoxColumn.DataPropertyName = "branchNo";
            this.branchNoDataGridViewTextBoxColumn.HeaderText = "Branch Name";
            this.branchNoDataGridViewTextBoxColumn.Name = "branchNoDataGridViewTextBoxColumn";
            this.branchNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approvedByDataGridViewTextBoxColumn
            // 
            this.approvedByDataGridViewTextBoxColumn.DataPropertyName = "approvedBy";
            this.approvedByDataGridViewTextBoxColumn.HeaderText = "approvedBy";
            this.approvedByDataGridViewTextBoxColumn.Name = "approvedByDataGridViewTextBoxColumn";
            this.approvedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supIDnoDataGridViewTextBoxColumn
            // 
            this.supIDnoDataGridViewTextBoxColumn.DataPropertyName = "sup_IDno";
            this.supIDnoDataGridViewTextBoxColumn.HeaderText = "sup_IDno";
            this.supIDnoDataGridViewTextBoxColumn.Name = "supIDnoDataGridViewTextBoxColumn";
            this.supIDnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.supIDnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // purchaseOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 482);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.cboxSearchBy);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gridPurchaseOrder);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "purchaseOrderView";
            this.Text = "Purchase Order View";
            this.Load += new System.EventHandler(this.purchaseOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private MetroFramework.Controls.MetroGrid gridPurchaseOrder;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroButton btnNew;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tboxSearch;
        private MetroFramework.Controls.MetroComboBox cboxSearchBy;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource pOViewBindingSource;
        private citiAppDatabaseDataSetTableAdapters.PO_ViewTableAdapter pO_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn poID;
        private System.Windows.Forms.DataGridViewTextBoxColumn poDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supIDnoDataGridViewTextBoxColumn;
    }
}