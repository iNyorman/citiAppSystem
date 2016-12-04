namespace citiAppSystem
{
    partial class DirectAddProduct
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
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.STOCKNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRAND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxBrand = new System.Windows.Forms.TextBox();
            this.tboxModel = new System.Windows.Forms.TextBox();
            this.tboxSerial = new System.Windows.Forms.TextBox();
            this.tboxStocks = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STOCKNO,
            this.SERIAL,
            this.MODEL,
            this.BRAND});
            this.gridProducts.Location = new System.Drawing.Point(23, 197);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.Size = new System.Drawing.Size(710, 204);
            this.gridProducts.TabIndex = 0;
            // 
            // STOCKNO
            // 
            this.STOCKNO.HeaderText = "STOCKNO";
            this.STOCKNO.Name = "STOCKNO";
            this.STOCKNO.ReadOnly = true;
            // 
            // SERIAL
            // 
            this.SERIAL.HeaderText = "SERIAL";
            this.SERIAL.Name = "SERIAL";
            this.SERIAL.ReadOnly = true;
            // 
            // MODEL
            // 
            this.MODEL.HeaderText = "MODEL";
            this.MODEL.Name = "MODEL";
            this.MODEL.ReadOnly = true;
            // 
            // BRAND
            // 
            this.BRAND.HeaderText = "BRAND";
            this.BRAND.Name = "BRAND";
            this.BRAND.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxBrand);
            this.groupBox1.Controls.Add(this.tboxModel);
            this.groupBox1.Controls.Add(this.tboxSerial);
            this.groupBox1.Controls.Add(this.tboxStocks);
            this.groupBox1.Location = new System.Drawing.Point(23, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "BRAND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MODEL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SERIAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "STOCK NO:";
            // 
            // tboxBrand
            // 
            this.tboxBrand.Location = new System.Drawing.Point(319, 58);
            this.tboxBrand.Multiline = true;
            this.tboxBrand.Name = "tboxBrand";
            this.tboxBrand.Size = new System.Drawing.Size(152, 20);
            this.tboxBrand.TabIndex = 3;
            // 
            // tboxModel
            // 
            this.tboxModel.Location = new System.Drawing.Point(319, 28);
            this.tboxModel.Multiline = true;
            this.tboxModel.Name = "tboxModel";
            this.tboxModel.Size = new System.Drawing.Size(152, 20);
            this.tboxModel.TabIndex = 2;
            // 
            // tboxSerial
            // 
            this.tboxSerial.Location = new System.Drawing.Point(94, 64);
            this.tboxSerial.Multiline = true;
            this.tboxSerial.Name = "tboxSerial";
            this.tboxSerial.Size = new System.Drawing.Size(152, 20);
            this.tboxSerial.TabIndex = 1;
            // 
            // tboxStocks
            // 
            this.tboxStocks.Location = new System.Drawing.Point(94, 28);
            this.tboxStocks.Multiline = true;
            this.tboxStocks.Name = "tboxStocks";
            this.tboxStocks.Size = new System.Drawing.Size(152, 20);
            this.tboxStocks.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Remove Product";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(610, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "Save Product";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DirectAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 512);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridProducts);
            this.Name = "DirectAddProduct";
            this.Text = "Add Products";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DirectAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCKNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRAND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxBrand;
        private System.Windows.Forms.TextBox tboxModel;
        private System.Windows.Forms.TextBox tboxSerial;
        private System.Windows.Forms.TextBox tboxStocks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}