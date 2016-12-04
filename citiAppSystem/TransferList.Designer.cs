namespace citiAppSystem
{
    partial class TransferList
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
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.gridTransfer = new MetroFramework.Controls.MetroGrid();
            this.stIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatePassNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromlocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferlocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strequisitionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.btnTransfer = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.st_requisitionTableTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.st_requisitionTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strequisitionTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -237;
            this.lineShape1.X2 = 1232;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 0;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -238;
            this.lineShape2.X2 = 1231;
            this.lineShape2.Y1 = 3;
            this.lineShape2.Y2 = 3;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1227, 374);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(1116, 70);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(127, 29);
            this.metroButton1.TabIndex = 27;
            this.metroButton1.Text = "Print";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "SEARCH BY ST ID:";
            // 
            // tboxSearch
            // 
            this.tboxSearch.Lines = new string[0];
            this.tboxSearch.Location = new System.Drawing.Point(156, 70);
            this.tboxSearch.MaxLength = 32767;
            this.tboxSearch.Multiline = true;
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.PasswordChar = '\0';
            this.tboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSearch.SelectedText = "";
            this.tboxSearch.Size = new System.Drawing.Size(295, 29);
            this.tboxSearch.TabIndex = 25;
            this.tboxSearch.UseSelectable = true;
            this.tboxSearch.TextChanged += new System.EventHandler(this.tboxSearch_TextChanged);
            // 
            // gridTransfer
            // 
            this.gridTransfer.AllowUserToAddRows = false;
            this.gridTransfer.AllowUserToDeleteRows = false;
            this.gridTransfer.AllowUserToResizeRows = false;
            this.gridTransfer.AutoGenerateColumns = false;
            this.gridTransfer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTransfer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridTransfer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTransfer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridTransfer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTransfer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stIDDataGridViewTextBoxColumn,
            this.gatePassNoDataGridViewTextBoxColumn,
            this.receivedByDataGridViewTextBoxColumn,
            this.releasedByDataGridViewTextBoxColumn,
            this.fromlocationDataGridViewTextBoxColumn,
            this.transferlocationDataGridViewTextBoxColumn,
            this.dateTransactionDataGridViewTextBoxColumn});
            this.gridTransfer.DataSource = this.strequisitionTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTransfer.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTransfer.EnableHeadersVisualStyles = false;
            this.gridTransfer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridTransfer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridTransfer.Location = new System.Drawing.Point(23, 105);
            this.gridTransfer.Name = "gridTransfer";
            this.gridTransfer.ReadOnly = true;
            this.gridTransfer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTransfer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTransfer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransfer.Size = new System.Drawing.Size(1220, 253);
            this.gridTransfer.TabIndex = 28;
            // 
            // stIDDataGridViewTextBoxColumn
            // 
            this.stIDDataGridViewTextBoxColumn.DataPropertyName = "st_ID";
            this.stIDDataGridViewTextBoxColumn.HeaderText = "ST ID";
            this.stIDDataGridViewTextBoxColumn.Name = "stIDDataGridViewTextBoxColumn";
            this.stIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gatePassNoDataGridViewTextBoxColumn
            // 
            this.gatePassNoDataGridViewTextBoxColumn.DataPropertyName = "gatePassNo";
            this.gatePassNoDataGridViewTextBoxColumn.HeaderText = "Gate Pass No";
            this.gatePassNoDataGridViewTextBoxColumn.Name = "gatePassNoDataGridViewTextBoxColumn";
            this.gatePassNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivedByDataGridViewTextBoxColumn
            // 
            this.receivedByDataGridViewTextBoxColumn.DataPropertyName = "receivedBy";
            this.receivedByDataGridViewTextBoxColumn.HeaderText = "Received By";
            this.receivedByDataGridViewTextBoxColumn.Name = "receivedByDataGridViewTextBoxColumn";
            this.receivedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releasedByDataGridViewTextBoxColumn
            // 
            this.releasedByDataGridViewTextBoxColumn.DataPropertyName = "releasedBy";
            this.releasedByDataGridViewTextBoxColumn.HeaderText = "Released By";
            this.releasedByDataGridViewTextBoxColumn.Name = "releasedByDataGridViewTextBoxColumn";
            this.releasedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromlocationDataGridViewTextBoxColumn
            // 
            this.fromlocationDataGridViewTextBoxColumn.DataPropertyName = "from_location";
            this.fromlocationDataGridViewTextBoxColumn.HeaderText = "From Location";
            this.fromlocationDataGridViewTextBoxColumn.Name = "fromlocationDataGridViewTextBoxColumn";
            this.fromlocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transferlocationDataGridViewTextBoxColumn
            // 
            this.transferlocationDataGridViewTextBoxColumn.DataPropertyName = "transfer_location";
            this.transferlocationDataGridViewTextBoxColumn.HeaderText = "Transfer Location";
            this.transferlocationDataGridViewTextBoxColumn.Name = "transferlocationDataGridViewTextBoxColumn";
            this.transferlocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTransactionDataGridViewTextBoxColumn
            // 
            this.dateTransactionDataGridViewTextBoxColumn.DataPropertyName = "date_Transaction";
            this.dateTransactionDataGridViewTextBoxColumn.HeaderText = "Transaction Date";
            this.dateTransactionDataGridViewTextBoxColumn.Name = "dateTransactionDataGridViewTextBoxColumn";
            this.dateTransactionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strequisitionTableBindingSource
            // 
            this.strequisitionTableBindingSource.DataMember = "st_requisitionTable";
            this.strequisitionTableBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTransfer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTransfer.Location = new System.Drawing.Point(1116, 378);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(127, 32);
            this.btnTransfer.TabIndex = 30;
            this.btnTransfer.Text = "Transfer Product";
            this.btnTransfer.UseCustomBackColor = true;
            this.btnTransfer.UseSelectable = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(23, 378);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 32);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // st_requisitionTableTableAdapter
            // 
            this.st_requisitionTableTableAdapter.ClearBeforeFill = true;
            // 
            // TransferList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 454);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gridTransfer);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "TransferList";
            this.Text = "Transfer View";
            this.Load += new System.EventHandler(this.TransferList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strequisitionTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tboxSearch;
        private MetroFramework.Controls.MetroGrid gridTransfer;
        private MetroFramework.Controls.MetroButton btnTransfer;
        private MetroFramework.Controls.MetroButton btnBack;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource strequisitionTableBindingSource;
        private citiAppDatabaseDataSetTableAdapters.st_requisitionTableTableAdapter st_requisitionTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatePassNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromlocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferlocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTransactionDataGridViewTextBoxColumn;
    }
}