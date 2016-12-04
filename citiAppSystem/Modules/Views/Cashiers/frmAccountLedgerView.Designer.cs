namespace citiAppSystem.Modules.Views.Cashiers
{
    partial class frmAccountLedgerView
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
            this.dgridProductDetails = new System.Windows.Forms.DataGridView();
            this.dgridCollectionDetails = new System.Windows.Forms.DataGridView();
            this.dRdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ornumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectiondetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRINAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rebateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acctBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expecteddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedbalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxAccountNo = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCollectionDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectiondetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridProductDetails
            // 
            this.dgridProductDetails.AllowUserToAddRows = false;
            this.dgridProductDetails.AllowUserToDeleteRows = false;
            this.dgridProductDetails.AutoGenerateColumns = false;
            this.dgridProductDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNo,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.ornumberDataGridViewTextBoxColumn,
            this.orAmtDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn});
            this.dgridProductDetails.DataSource = this.dRdetailsBindingSource;
            this.dgridProductDetails.Location = new System.Drawing.Point(12, 67);
            this.dgridProductDetails.Name = "dgridProductDetails";
            this.dgridProductDetails.ReadOnly = true;
            this.dgridProductDetails.Size = new System.Drawing.Size(843, 144);
            this.dgridProductDetails.TabIndex = 0;
            // 
            // dgridCollectionDetails
            // 
            this.dgridCollectionDetails.AllowUserToAddRows = false;
            this.dgridCollectionDetails.AllowUserToDeleteRows = false;
            this.dgridCollectionDetails.AutoGenerateColumns = false;
            this.dgridCollectionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridCollectionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.oRNumberDataGridViewTextBoxColumn1,
            this.pRINAmountDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.penaltyDataGridViewTextBoxColumn,
            this.rebateDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.acctBalanceDataGridViewTextBoxColumn,
            this.nODataGridViewTextBoxColumn,
            this.expecteddateDataGridViewTextBoxColumn,
            this.expectedbalanceDataGridViewTextBoxColumn});
            this.dgridCollectionDetails.DataSource = this.collectiondetailsBindingSource;
            this.dgridCollectionDetails.Location = new System.Drawing.Point(12, 217);
            this.dgridCollectionDetails.Name = "dgridCollectionDetails";
            this.dgridCollectionDetails.ReadOnly = true;
            this.dgridCollectionDetails.Size = new System.Drawing.Size(843, 417);
            this.dgridCollectionDetails.TabIndex = 1;
            // 
            // dRdetailsBindingSource
            // 
            this.dRdetailsBindingSource.DataSource = typeof(citiAppSystem.Modules.Models.EF.DR_details);
            // 
            // stockNo
            // 
            this.stockNo.DataPropertyName = "stockNo";
            this.stockNo.HeaderText = "stockNo";
            this.stockNo.Name = "stockNo";
            this.stockNo.ReadOnly = true;
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
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "serialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "serialNo";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ornumberDataGridViewTextBoxColumn
            // 
            this.ornumberDataGridViewTextBoxColumn.DataPropertyName = "or_number";
            this.ornumberDataGridViewTextBoxColumn.HeaderText = "or_number";
            this.ornumberDataGridViewTextBoxColumn.Name = "ornumberDataGridViewTextBoxColumn";
            this.ornumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orAmtDataGridViewTextBoxColumn
            // 
            this.orAmtDataGridViewTextBoxColumn.DataPropertyName = "orAmt";
            this.orAmtDataGridViewTextBoxColumn.HeaderText = "orAmt";
            this.orAmtDataGridViewTextBoxColumn.Name = "orAmtDataGridViewTextBoxColumn";
            this.orAmtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "paymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "paymentType";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collectiondetailsBindingSource
            // 
            this.collectiondetailsBindingSource.DataSource = typeof(citiAppSystem.Modules.Models.EF.collection_details);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRNumberDataGridViewTextBoxColumn1
            // 
            this.oRNumberDataGridViewTextBoxColumn1.DataPropertyName = "OR_Number";
            this.oRNumberDataGridViewTextBoxColumn1.HeaderText = "OR_Number";
            this.oRNumberDataGridViewTextBoxColumn1.Name = "oRNumberDataGridViewTextBoxColumn1";
            this.oRNumberDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // nODataGridViewTextBoxColumn
            // 
            this.nODataGridViewTextBoxColumn.DataPropertyName = "NO";
            this.nODataGridViewTextBoxColumn.HeaderText = "NO";
            this.nODataGridViewTextBoxColumn.Name = "nODataGridViewTextBoxColumn";
            this.nODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expecteddateDataGridViewTextBoxColumn
            // 
            this.expecteddateDataGridViewTextBoxColumn.DataPropertyName = "expected_date";
            this.expecteddateDataGridViewTextBoxColumn.HeaderText = "expected_date";
            this.expecteddateDataGridViewTextBoxColumn.Name = "expecteddateDataGridViewTextBoxColumn";
            this.expecteddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expectedbalanceDataGridViewTextBoxColumn
            // 
            this.expectedbalanceDataGridViewTextBoxColumn.DataPropertyName = "expected_balance";
            this.expectedbalanceDataGridViewTextBoxColumn.HeaderText = "expected_balance";
            this.expectedbalanceDataGridViewTextBoxColumn.Name = "expectedbalanceDataGridViewTextBoxColumn";
            this.expectedbalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ACOUNT NO:";
            // 
            // tBoxAccountNo
            // 
            this.tBoxAccountNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAccountNo.Location = new System.Drawing.Point(129, 29);
            this.tBoxAccountNo.Name = "tBoxAccountNo";
            this.tBoxAccountNo.ReadOnly = true;
            this.tBoxAccountNo.Size = new System.Drawing.Size(242, 24);
            this.tBoxAccountNo.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(692, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(163, 34);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print Ledger";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(692, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Without Data";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmAccountLedgerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 646);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tBoxAccountNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgridCollectionDetails);
            this.Controls.Add(this.dgridProductDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountLedgerView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Preview";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgridProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCollectionDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectiondetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridProductDetails;
        private System.Windows.Forms.DataGridView dgridCollectionDetails;
        private System.Windows.Forms.BindingSource dRdetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ornumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource collectiondetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRINAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rebateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acctBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expecteddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedbalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxAccountNo;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}