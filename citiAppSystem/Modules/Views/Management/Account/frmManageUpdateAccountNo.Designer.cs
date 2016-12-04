namespace citiAppSystem.Modules.Views.Management.Account
{
    partial class frmManageUpdateAccountNo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBoxAccountNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgridDeliveryReceipt = new System.Windows.Forms.DataGridView();
            this.drDetailsGrid = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgridCollections = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNewAcount = new System.Windows.Forms.Label();
            this.tBoxNewAccountNo = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDeliveryReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCollections)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNewAcount);
            this.groupBox1.Controls.Add(this.tBoxNewAccountNo);
            this.groupBox1.Controls.Add(this.btnUpdateAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBoxAccountNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // tBoxAccountNo
            // 
            this.tBoxAccountNo.Location = new System.Drawing.Point(33, 52);
            this.tBoxAccountNo.Name = "tBoxAccountNo";
            this.tBoxAccountNo.Size = new System.Drawing.Size(214, 22);
            this.tBoxAccountNo.TabIndex = 0;
            this.tBoxAccountNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tBoxAccountNo_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old AccountNo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(955, 740);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Enabled = false;
            this.btnUpdateAccount.Location = new System.Drawing.Point(832, 32);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(113, 53);
            this.btnUpdateAccount.TabIndex = 2;
            this.btnUpdateAccount.Text = "Update AccountNo";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 713);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.drDetailsGrid);
            this.tabPage1.Controls.Add(this.dgridDeliveryReceipt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DeliveryReceipt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgridCollections);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 684);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Collection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgridDeliveryReceipt
            // 
            this.dgridDeliveryReceipt.AllowUserToAddRows = false;
            this.dgridDeliveryReceipt.AllowUserToDeleteRows = false;
            this.dgridDeliveryReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridDeliveryReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDeliveryReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column2});
            this.dgridDeliveryReceipt.Location = new System.Drawing.Point(6, 6);
            this.dgridDeliveryReceipt.Name = "dgridDeliveryReceipt";
            this.dgridDeliveryReceipt.ReadOnly = true;
            this.dgridDeliveryReceipt.RowTemplate.Height = 24;
            this.dgridDeliveryReceipt.Size = new System.Drawing.Size(923, 179);
            this.dgridDeliveryReceipt.TabIndex = 0;
            // 
            // drDetailsGrid
            // 
            this.drDetailsGrid.AllowUserToAddRows = false;
            this.drDetailsGrid.AllowUserToDeleteRows = false;
            this.drDetailsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drDetailsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.drDetailsGrid.Location = new System.Drawing.Point(6, 204);
            this.drDetailsGrid.Name = "drDetailsGrid";
            this.drDetailsGrid.ReadOnly = true;
            this.drDetailsGrid.RowTemplate.Height = 24;
            this.drDetailsGrid.Size = new System.Drawing.Size(923, 474);
            this.drDetailsGrid.TabIndex = 1;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "stockNo";
            this.Column5.HeaderText = "StockNo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "model";
            this.Column6.HeaderText = "Model";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "brand";
            this.Column7.HeaderText = "Brand";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "serialN";
            this.Column8.HeaderText = "SerialNo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // dgridCollections
            // 
            this.dgridCollections.AllowUserToAddRows = false;
            this.dgridCollections.AllowUserToDeleteRows = false;
            this.dgridCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridCollections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20});
            this.dgridCollections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridCollections.Location = new System.Drawing.Point(3, 3);
            this.dgridCollections.Name = "dgridCollections";
            this.dgridCollections.ReadOnly = true;
            this.dgridCollections.RowTemplate.Height = 24;
            this.dgridCollections.Size = new System.Drawing.Size(929, 678);
            this.dgridCollections.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Date";
            this.Column9.HeaderText = "Date";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "OR_Number";
            this.Column10.HeaderText = "OR Number";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "PRIN_Amount";
            this.Column11.HeaderText = "PRIN_AMOUNT";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Total_Amount";
            this.Column12.HeaderText = "Total_Amount";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Penalty";
            this.Column13.HeaderText = "Penalty";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "Rebate";
            this.Column14.HeaderText = "Rebate";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Discount";
            this.Column15.HeaderText = "Discount";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Acct_Balance";
            this.Column16.HeaderText = "Balance";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "paymentType";
            this.Column17.HeaderText = "Payment Type";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "NO";
            this.Column18.HeaderText = "NO";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "expected_date";
            this.Column19.HeaderText = "Expected Date";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "expected_balance";
            this.Column20.HeaderText = "Expected Balance";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // lblNewAcount
            // 
            this.lblNewAcount.AutoSize = true;
            this.lblNewAcount.Location = new System.Drawing.Point(598, 32);
            this.lblNewAcount.Name = "lblNewAcount";
            this.lblNewAcount.Size = new System.Drawing.Size(112, 17);
            this.lblNewAcount.TabIndex = 4;
            this.lblNewAcount.Text = "New AccountNo:";
            this.lblNewAcount.Visible = false;
            // 
            // tBoxNewAccountNo
            // 
            this.tBoxNewAccountNo.Location = new System.Drawing.Point(601, 52);
            this.tBoxNewAccountNo.Name = "tBoxNewAccountNo";
            this.tBoxNewAccountNo.Size = new System.Drawing.Size(214, 22);
            this.tBoxNewAccountNo.TabIndex = 3;
            this.tBoxNewAccountNo.Visible = false;
            this.tBoxNewAccountNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tBoxNewAccountNo_KeyUp);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "AccountNo";
            this.Column1.HeaderText = "AccountNo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "fullName";
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Account_Type";
            this.Column3.FillWeight = 60F;
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Delivery_Date";
            this.Column2.HeaderText = "DeliveryDate";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmManageUpdateAccountNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 865);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageUpdateAccountNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update AccountNo Util";
            this.Load += new System.EventHandler(this.frmManageUpdateAccountNo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDeliveryReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCollections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBoxAccountNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView drDetailsGrid;
        private System.Windows.Forms.DataGridView dgridDeliveryReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridView dgridCollections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.Label lblNewAcount;
        private System.Windows.Forms.TextBox tBoxNewAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}