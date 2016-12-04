namespace citiAppSystem
{
    partial class updateProductDetails
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxPrice = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxSerialNo = new MetroFramework.Controls.MetroTextBox();
            this.tBoxModel = new MetroFramework.Controls.MetroTextBox();
            this.tBoxBrand = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStockNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(449, 513);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(168, 43);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Update";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 513);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 43);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tBoxSerialNo);
            this.groupBox1.Controls.Add(this.tBoxModel);
            this.groupBox1.Controls.Add(this.tBoxBrand);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(587, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // tboxPrice
            // 
            this.tboxPrice.Lines = new string[0];
            this.tboxPrice.Location = new System.Drawing.Point(196, 263);
            this.tboxPrice.MaxLength = 32767;
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.PasswordChar = '\0';
            this.tboxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxPrice.SelectedText = "";
            this.tboxPrice.Size = new System.Drawing.Size(273, 26);
            this.tboxPrice.TabIndex = 11;
            this.tboxPrice.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "PRICE:";
            // 
            // tBoxSerialNo
            // 
            this.tBoxSerialNo.Lines = new string[0];
            this.tBoxSerialNo.Location = new System.Drawing.Point(196, 209);
            this.tBoxSerialNo.MaxLength = 32767;
            this.tBoxSerialNo.Name = "tBoxSerialNo";
            this.tBoxSerialNo.PasswordChar = '\0';
            this.tBoxSerialNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBoxSerialNo.SelectedText = "";
            this.tBoxSerialNo.Size = new System.Drawing.Size(273, 26);
            this.tBoxSerialNo.TabIndex = 9;
            this.tBoxSerialNo.UseSelectable = true;
            // 
            // tBoxModel
            // 
            this.tBoxModel.Lines = new string[0];
            this.tBoxModel.Location = new System.Drawing.Point(196, 147);
            this.tBoxModel.MaxLength = 32767;
            this.tBoxModel.Name = "tBoxModel";
            this.tBoxModel.PasswordChar = '\0';
            this.tBoxModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBoxModel.SelectedText = "";
            this.tBoxModel.Size = new System.Drawing.Size(273, 26);
            this.tBoxModel.TabIndex = 8;
            this.tBoxModel.UseSelectable = true;
            // 
            // tBoxBrand
            // 
            this.tBoxBrand.Lines = new string[0];
            this.tBoxBrand.Location = new System.Drawing.Point(196, 80);
            this.tBoxBrand.MaxLength = 32767;
            this.tBoxBrand.Name = "tBoxBrand";
            this.tBoxBrand.PasswordChar = '\0';
            this.tBoxBrand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBoxBrand.SelectedText = "";
            this.tBoxBrand.Size = new System.Drawing.Size(273, 26);
            this.tBoxBrand.TabIndex = 7;
            this.tBoxBrand.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SERIAL NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "MODEL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "BRAND:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "STOCK NO:";
            // 
            // labelStockNo
            // 
            this.labelStockNo.AutoSize = true;
            this.labelStockNo.ForeColor = System.Drawing.Color.DarkRed;
            this.labelStockNo.Location = new System.Drawing.Point(136, 103);
            this.labelStockNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockNo.Name = "labelStockNo";
            this.labelStockNo.Size = new System.Drawing.Size(76, 15);
            this.labelStockNo.TabIndex = 4;
            this.labelStockNo.Text = "<StockNo>";
            // 
            // updateProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 583);
            this.ControlBox = false;
            this.Controls.Add(this.labelStockNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.metroButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Movable = false;
            this.Name = "updateProductDetails";
            this.Padding = new System.Windows.Forms.Padding(27, 69, 27, 23);
            this.Resizable = false;
            this.Text = "Update Product Details";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.updateProductDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox tBoxSerialNo;
        private MetroFramework.Controls.MetroTextBox tBoxModel;
        private MetroFramework.Controls.MetroTextBox tBoxBrand;
        private System.Windows.Forms.Label labelStockNo;
        private MetroFramework.Controls.MetroTextBox tboxPrice;
        private System.Windows.Forms.Label label5;
    }
}