namespace citiAppSystem
{
    partial class CustomerCenter
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
            this.tboxStockNo = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridDR = new System.Windows.Forms.DataGridView();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryViewTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRINAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rebateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acctBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedbalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expecteddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectiondetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.deliveryView_TableTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.DeliveryView_TableTableAdapter();
            this.collection_detailsTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryViewTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectiondetailsBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxStockNo
            // 
            this.tboxStockNo.Lines = new string[0];
            this.tboxStockNo.Location = new System.Drawing.Point(939, 18);
            this.tboxStockNo.MaxLength = 32767;
            this.tboxStockNo.Name = "tboxStockNo";
            this.tboxStockNo.PasswordChar = '\0';
            this.tboxStockNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxStockNo.SelectedText = "";
            this.tboxStockNo.Size = new System.Drawing.Size(214, 28);
            this.tboxStockNo.TabIndex = 19;
            this.tboxStockNo.UseSelectable = true;
            this.tboxStockNo.TextChanged += new System.EventHandler(this.tboxStockNo_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridDR);
            this.groupBox2.Location = new System.Drawing.Point(23, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1183, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deliveries";
            // 
            // gridDR
            // 
            this.gridDR.AllowUserToAddRows = false;
            this.gridDR.AllowUserToDeleteRows = false;
            this.gridDR.AutoGenerateColumns = false;
            this.gridDR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.midNameDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.collectionIDDataGridViewTextBoxColumn,
            this.accountNoDataGridViewTextBoxColumn,
            this.ID_Number});
            this.gridDR.DataSource = this.deliveryViewTableBindingSource;
            this.gridDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDR.Location = new System.Drawing.Point(3, 16);
            this.gridDR.Name = "gridDR";
            this.gridDR.ReadOnly = true;
            this.gridDR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDR.Size = new System.Drawing.Size(1177, 154);
            this.gridDR.TabIndex = 0;
            this.gridDR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDR_CellContentClick);
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // midNameDataGridViewTextBoxColumn
            // 
            this.midNameDataGridViewTextBoxColumn.DataPropertyName = "mid_Name";
            this.midNameDataGridViewTextBoxColumn.HeaderText = "mid_Name";
            this.midNameDataGridViewTextBoxColumn.Name = "midNameDataGridViewTextBoxColumn";
            this.midNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "f_Name";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "f_Name";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "Account_Type";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "Account_Type";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "Delivery_Date";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Delivery_Date";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collectionIDDataGridViewTextBoxColumn
            // 
            this.collectionIDDataGridViewTextBoxColumn.DataPropertyName = "Collection_ID";
            this.collectionIDDataGridViewTextBoxColumn.HeaderText = "Collection_ID";
            this.collectionIDDataGridViewTextBoxColumn.Name = "collectionIDDataGridViewTextBoxColumn";
            this.collectionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNoDataGridViewTextBoxColumn
            // 
            this.accountNoDataGridViewTextBoxColumn.DataPropertyName = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.HeaderText = "AccountNo";
            this.accountNoDataGridViewTextBoxColumn.Name = "accountNoDataGridViewTextBoxColumn";
            this.accountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ID_Number
            // 
            this.ID_Number.DataPropertyName = "ID_Number";
            this.ID_Number.HeaderText = "ID_Number";
            this.ID_Number.Name = "ID_Number";
            this.ID_Number.ReadOnly = true;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(23, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1183, 263);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transactions";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.oRNumberDataGridViewTextBoxColumn,
            this.pRINAmountDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.penaltyDataGridViewTextBoxColumn,
            this.rebateDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.acctBalanceDataGridViewTextBoxColumn,
            this.expectedbalanceDataGridViewTextBoxColumn,
            this.expecteddateDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.collectiondetailsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1177, 244);
            this.dataGridView2.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRNumberDataGridViewTextBoxColumn
            // 
            this.oRNumberDataGridViewTextBoxColumn.DataPropertyName = "OR_Number";
            this.oRNumberDataGridViewTextBoxColumn.HeaderText = "OR_Number";
            this.oRNumberDataGridViewTextBoxColumn.Name = "oRNumberDataGridViewTextBoxColumn";
            this.oRNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRINAmountDataGridViewTextBoxColumn
            // 
            this.pRINAmountDataGridViewTextBoxColumn.DataPropertyName = "PRIN_Amount";
            this.pRINAmountDataGridViewTextBoxColumn.HeaderText = "PRIN_Amount";
            this.pRINAmountDataGridViewTextBoxColumn.Name = "pRINAmountDataGridViewTextBoxColumn";
            this.pRINAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // penaltyDataGridViewTextBoxColumn
            // 
            this.penaltyDataGridViewTextBoxColumn.DataPropertyName = "Penalty";
            this.penaltyDataGridViewTextBoxColumn.HeaderText = "Penalty";
            this.penaltyDataGridViewTextBoxColumn.Name = "penaltyDataGridViewTextBoxColumn";
            this.penaltyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rebateDataGridViewTextBoxColumn
            // 
            this.rebateDataGridViewTextBoxColumn.DataPropertyName = "Rebate";
            this.rebateDataGridViewTextBoxColumn.HeaderText = "Rebate";
            this.rebateDataGridViewTextBoxColumn.Name = "rebateDataGridViewTextBoxColumn";
            this.rebateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acctBalanceDataGridViewTextBoxColumn
            // 
            this.acctBalanceDataGridViewTextBoxColumn.DataPropertyName = "Acct_Balance";
            this.acctBalanceDataGridViewTextBoxColumn.HeaderText = "Acct_Balance";
            this.acctBalanceDataGridViewTextBoxColumn.Name = "acctBalanceDataGridViewTextBoxColumn";
            this.acctBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expectedbalanceDataGridViewTextBoxColumn
            // 
            this.expectedbalanceDataGridViewTextBoxColumn.DataPropertyName = "expected_balance";
            this.expectedbalanceDataGridViewTextBoxColumn.HeaderText = "expected_balance";
            this.expectedbalanceDataGridViewTextBoxColumn.Name = "expectedbalanceDataGridViewTextBoxColumn";
            this.expectedbalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expecteddateDataGridViewTextBoxColumn
            // 
            this.expecteddateDataGridViewTextBoxColumn.DataPropertyName = "expected_date";
            this.expecteddateDataGridViewTextBoxColumn.HeaderText = "expected_date";
            this.expecteddateDataGridViewTextBoxColumn.Name = "expecteddateDataGridViewTextBoxColumn";
            this.expecteddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "paymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "paymentType";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collectiondetailsBindingSource
            // 
            this.collectiondetailsBindingSource.DataMember = "collection_details";
            this.collectiondetailsBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.metroButton1);
            this.groupBox4.Controls.Add(this.tboxStockNo);
            this.groupBox4.Location = new System.Drawing.Point(28, 509);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1175, 57);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(9, 18);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(154, 28);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Close";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // deliveryView_TableTableAdapter
            // 
            this.deliveryView_TableTableAdapter.ClearBeforeFill = true;
            // 
            // collection_detailsTableAdapter
            // 
            this.collection_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "SEARCH:";
            // 
            // CustomerCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1229, 603);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "CustomerCenter";
            this.Resizable = false;
            this.Text = "Customer Center";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomerCenter_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryViewTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectiondetailsBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tboxStockNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridDR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource deliveryViewTableBindingSource;
        private citiAppDatabaseDataSetTableAdapters.DeliveryView_TableTableAdapter deliveryView_TableTableAdapter;
        private System.Windows.Forms.BindingSource collectiondetailsBindingSource;
        private citiAppDatabaseDataSetTableAdapters.collection_detailsTableAdapter collection_detailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRINAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rebateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acctBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedbalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expecteddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Number;
        private System.Windows.Forms.Label label1;
    }
}