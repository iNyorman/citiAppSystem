namespace citiAppSystem
{
    partial class DirectAdd_products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridProducts = new MetroFramework.Controls.MetroGrid();
            this.stockNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnUpdate_Save = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tboxPrice = new MetroFramework.Controls.MetroTextBox();
            this.tBoxBranch = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tboxModel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tboxSerialNo = new MetroFramework.Controls.MetroTextBox();
            this.btnADd = new MetroFramework.Controls.MetroButton();
            this.tboxBrand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tboxStockNo = new MetroFramework.Controls.MetroTextBox();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.branchTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.branchTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.gboxOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockNo,
            this.serialNo,
            this.brand,
            this.model,
            this.prie});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridProducts.EnableHeadersVisualStyles = false;
            this.gridProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProducts.Location = new System.Drawing.Point(2, 15);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(964, 233);
            this.gridProducts.TabIndex = 4;
            // 
            // stockNo
            // 
            this.stockNo.DataPropertyName = "stockNo";
            this.stockNo.HeaderText = "STOCKNO";
            this.stockNo.Name = "stockNo";
            this.stockNo.ReadOnly = true;
            // 
            // serialNo
            // 
            this.serialNo.DataPropertyName = "Serial";
            this.serialNo.HeaderText = "SERIAL NO";
            this.serialNo.Name = "serialNo";
            this.serialNo.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "Brand";
            this.brand.HeaderText = "BRAND";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // model
            // 
            this.model.DataPropertyName = "Model";
            this.model.HeaderText = "MODEL";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // prie
            // 
            this.prie.DataPropertyName = "Price";
            this.prie.HeaderText = "PRICE";
            this.prie.Name = "prie";
            this.prie.ReadOnly = true;
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.btnRemove);
            this.gboxOptions.Controls.Add(this.btnUpdate_Save);
            this.gboxOptions.Controls.Add(this.btnBack);
            this.gboxOptions.Controls.Add(this.btnClear);
            this.gboxOptions.Location = new System.Drawing.Point(34, 487);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(974, 73);
            this.gboxOptions.TabIndex = 20;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Options";
            // 
            // btnRemove
            // 
            this.btnRemove.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRemove.Location = new System.Drawing.Point(496, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(147, 34);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate_Save
            // 
            this.btnUpdate_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate_Save.Location = new System.Drawing.Point(816, 19);
            this.btnUpdate_Save.Name = "btnUpdate_Save";
            this.btnUpdate_Save.Size = new System.Drawing.Size(147, 34);
            this.btnUpdate_Save.TabIndex = 7;
            this.btnUpdate_Save.Text = "Save";
            this.btnUpdate_Save.UseSelectable = true;
            this.btnUpdate_Save.Click += new System.EventHandler(this.btnUpdate_Save_Click);
            // 
            // btnBack
            // 
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(6, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 34);
            this.btnBack.TabIndex = 2;
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
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.tboxPrice);
            this.groupBox1.Controls.Add(this.tBoxBranch);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.tboxModel);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.tboxSerialNo);
            this.groupBox1.Controls.Add(this.btnADd);
            this.groupBox1.Controls.Add(this.tboxBrand);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tboxStockNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 152);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(524, 93);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Branch:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(290, 84);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Price :";
            // 
            // tboxPrice
            // 
            this.tboxPrice.Lines = new string[0];
            this.tboxPrice.Location = new System.Drawing.Point(293, 106);
            this.tboxPrice.MaxLength = 32767;
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.PasswordChar = '\0';
            this.tboxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxPrice.SelectedText = "";
            this.tboxPrice.Size = new System.Drawing.Size(128, 28);
            this.tboxPrice.TabIndex = 14;
            this.tboxPrice.UseSelectable = true;
            // 
            // tBoxBranch
            // 
            this.tBoxBranch.Enabled = false;
            this.tBoxBranch.Location = new System.Drawing.Point(524, 111);
            this.tBoxBranch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxBranch.Name = "tBoxBranch";
            this.tBoxBranch.Size = new System.Drawing.Size(167, 22);
            this.tBoxBranch.TabIndex = 16;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(524, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Model :";
            // 
            // tboxModel
            // 
            this.tboxModel.Lines = new string[0];
            this.tboxModel.Location = new System.Drawing.Point(524, 41);
            this.tboxModel.MaxLength = 32767;
            this.tboxModel.Name = "tboxModel";
            this.tboxModel.PasswordChar = '\0';
            this.tboxModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxModel.SelectedText = "";
            this.tboxModel.Size = new System.Drawing.Size(196, 28);
            this.tboxModel.TabIndex = 12;
            this.tboxModel.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(59, 84);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Serial No :";
            // 
            // tboxSerialNo
            // 
            this.tboxSerialNo.Lines = new string[0];
            this.tboxSerialNo.Location = new System.Drawing.Point(62, 106);
            this.tboxSerialNo.MaxLength = 32767;
            this.tboxSerialNo.Name = "tboxSerialNo";
            this.tboxSerialNo.PasswordChar = '\0';
            this.tboxSerialNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSerialNo.SelectedText = "";
            this.tboxSerialNo.Size = new System.Drawing.Size(194, 28);
            this.tboxSerialNo.TabIndex = 10;
            this.tboxSerialNo.UseSelectable = true;
            // 
            // btnADd
            // 
            this.btnADd.Location = new System.Drawing.Point(830, 106);
            this.btnADd.Name = "btnADd";
            this.btnADd.Size = new System.Drawing.Size(127, 40);
            this.btnADd.TabIndex = 6;
            this.btnADd.Text = "Add";
            this.btnADd.UseSelectable = true;
            this.btnADd.Click += new System.EventHandler(this.btnADd_Click);
            // 
            // tboxBrand
            // 
            this.tboxBrand.Lines = new string[0];
            this.tboxBrand.Location = new System.Drawing.Point(286, 41);
            this.tboxBrand.MaxLength = 32767;
            this.tboxBrand.Name = "tboxBrand";
            this.tboxBrand.PasswordChar = '\0';
            this.tboxBrand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxBrand.SelectedText = "";
            this.tboxBrand.Size = new System.Drawing.Size(202, 28);
            this.tboxBrand.TabIndex = 3;
            this.tboxBrand.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(286, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Brand :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(63, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Stock No :";
            // 
            // tboxStockNo
            // 
            this.tboxStockNo.Lines = new string[0];
            this.tboxStockNo.Location = new System.Drawing.Point(63, 41);
            this.tboxStockNo.MaxLength = 32767;
            this.tboxStockNo.Name = "tboxStockNo";
            this.tboxStockNo.PasswordChar = '\0';
            this.tboxStockNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxStockNo.SelectedText = "";
            this.tboxStockNo.Size = new System.Drawing.Size(193, 28);
            this.tboxStockNo.TabIndex = 2;
            this.tboxStockNo.UseSelectable = true;
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
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridProducts);
            this.groupBox2.Location = new System.Drawing.Point(40, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(968, 250);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main";
            // 
            // DirectAdd_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 569);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxOptions);
            this.Name = "DirectAdd_products";
            this.Text = "Direct Add Products";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DirectAdd_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.gboxOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridProducts;
        private System.Windows.Forms.GroupBox gboxOptions;
        private MetroFramework.Controls.MetroButton btnUpdate_Save;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnADd;
        private MetroFramework.Controls.MetroTextBox tboxBrand;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tboxStockNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tboxModel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tboxSerialNo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tboxPrice;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn prie;
        private System.Windows.Forms.TextBox tBoxBranch;
        private MetroFramework.Controls.MetroButton btnRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}