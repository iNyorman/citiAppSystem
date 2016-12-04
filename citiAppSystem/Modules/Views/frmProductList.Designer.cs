namespace citiAppSystem.Modules.Views
{
    partial class frmProductList
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
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.tBoxStockNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxBrandModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxBranches = new System.Windows.Forms.ComboBox();
            this.dGridProductDetails = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGridInventory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridInventory)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewAccount);
            this.groupBox1.Controls.Add(this.tBoxStockNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBoxBrandModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxBranches);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1166, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAccount.Location = new System.Drawing.Point(1009, 29);
            this.btnViewAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(126, 73);
            this.btnViewAccount.TabIndex = 6;
            this.btnViewAccount.Text = "Account Details";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Visible = false;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // tBoxStockNo
            // 
            this.tBoxStockNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxStockNo.Location = new System.Drawing.Point(460, 72);
            this.tBoxStockNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxStockNo.Name = "tBoxStockNo";
            this.tBoxStockNo.Size = new System.Drawing.Size(170, 26);
            this.tBoxStockNo.TabIndex = 5;
            this.tBoxStockNo.TextChanged += new System.EventHandler(this.tBoxStockNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brand/Model";
            // 
            // tBoxBrandModel
            // 
            this.tBoxBrandModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxBrandModel.Location = new System.Drawing.Point(261, 74);
            this.tBoxBrandModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxBrandModel.Name = "tBoxBrandModel";
            this.tBoxBrandModel.Size = new System.Drawing.Size(170, 26);
            this.tBoxBrandModel.TabIndex = 2;
            this.tBoxBrandModel.TextChanged += new System.EventHandler(this.tBoxBrandModel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch:";
            // 
            // cBoxBranches
            // 
            this.cBoxBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxBranches.FormattingEnabled = true;
            this.cBoxBranches.Location = new System.Drawing.Point(21, 72);
            this.cBoxBranches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxBranches.MaxDropDownItems = 5;
            this.cBoxBranches.Name = "cBoxBranches";
            this.cBoxBranches.Size = new System.Drawing.Size(209, 28);
            this.cBoxBranches.TabIndex = 0;
            this.cBoxBranches.SelectedIndexChanged += new System.EventHandler(this.cBoxBranches_SelectedIndexChanged);
            // 
            // dGridProductDetails
            // 
            this.dGridProductDetails.AllowUserToAddRows = false;
            this.dGridProductDetails.AllowUserToDeleteRows = false;
            this.dGridProductDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dGridProductDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridProductDetails.Location = new System.Drawing.Point(2, 15);
            this.dGridProductDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGridProductDetails.Name = "dGridProductDetails";
            this.dGridProductDetails.ReadOnly = true;
            this.dGridProductDetails.RowTemplate.Height = 24;
            this.dGridProductDetails.Size = new System.Drawing.Size(1140, 260);
            this.dGridProductDetails.TabIndex = 2;
            this.dGridProductDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridProductDetails_CellClick);
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
            this.Column6.DataPropertyName = "serialNo";
            this.Column6.HeaderText = "SerialNo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "status";
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "prodStatus";
            this.Column8.HeaderText = "ProdStatus";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "deliveryNo";
            this.Column9.HeaderText = "Delivery No";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "date_Received";
            this.Column10.HeaderText = "Date Recieved";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "price";
            this.Column11.HeaderText = "Price";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "fromBranch";
            this.Column12.HeaderText = "From";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "toBranch";
            this.Column13.HeaderText = "Current Branch";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // dGridInventory
            // 
            this.dGridInventory.AllowUserToAddRows = false;
            this.dGridInventory.AllowUserToDeleteRows = false;
            this.dGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGridInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridInventory.Location = new System.Drawing.Point(2, 15);
            this.dGridInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGridInventory.Name = "dGridInventory";
            this.dGridInventory.ReadOnly = true;
            this.dGridInventory.RowTemplate.Height = 24;
            this.dGridInventory.Size = new System.Drawing.Size(1138, 218);
            this.dGridInventory.TabIndex = 1;
            this.dGridInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridInventory_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "brand";
            this.Column1.HeaderText = "Brand";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "model";
            this.Column2.HeaderText = "Model";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "qnty";
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "branchName";
            this.Column4.HeaderText = "Branch Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dGridInventory);
            this.groupBox2.Location = new System.Drawing.Point(13, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(1142, 235);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock List";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dGridProductDetails);
            this.groupBox3.Location = new System.Drawing.Point(9, 388);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(1144, 277);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Details";
            // 
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 676);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductList";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridInventory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGridProductDetails;
        private System.Windows.Forms.DataGridView dGridInventory;
        private System.Windows.Forms.ComboBox cBoxBranches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxBrandModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxStockNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}