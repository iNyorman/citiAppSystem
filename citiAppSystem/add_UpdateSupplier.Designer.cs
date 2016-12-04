namespace citiAppSystem
{
    partial class add_UpdateSupplier
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnUpdate_Save = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tboxAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tboxContact = new MetroFramework.Controls.MetroTextBox();
            this.tboxSupplier = new MetroFramework.Controls.MetroTextBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate_Save);
            this.groupBox2.Location = new System.Drawing.Point(33, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // btnBack
            // 
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(15, 19);
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
            this.btnClear.Location = new System.Drawing.Point(358, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 34);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate_Save
            // 
            this.btnUpdate_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate_Save.Location = new System.Drawing.Point(511, 19);
            this.btnUpdate_Save.Name = "btnUpdate_Save";
            this.btnUpdate_Save.Size = new System.Drawing.Size(147, 34);
            this.btnUpdate_Save.TabIndex = 0;
            this.btnUpdate_Save.Text = "Save";
            this.btnUpdate_Save.UseSelectable = true;
            this.btnUpdate_Save.Click += new System.EventHandler(this.btnUpdate_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.tboxAddress);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tboxContact);
            this.groupBox1.Controls.Add(this.tboxSupplier);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Details";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(144, 80);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(65, 19);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "Address :";
            // 
            // tboxAddress
            // 
            this.tboxAddress.Lines = new string[0];
            this.tboxAddress.Location = new System.Drawing.Point(234, 76);
            this.tboxAddress.MaxLength = 32767;
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.PasswordChar = '\0';
            this.tboxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxAddress.SelectedText = "";
            this.tboxAddress.Size = new System.Drawing.Size(332, 28);
            this.tboxAddress.TabIndex = 12;
            this.tboxAddress.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(145, 118);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Contact :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(104, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Supplier Name :";
            // 
            // tboxContact
            // 
            this.tboxContact.Lines = new string[0];
            this.tboxContact.Location = new System.Drawing.Point(234, 110);
            this.tboxContact.MaxLength = 32767;
            this.tboxContact.Name = "tboxContact";
            this.tboxContact.PasswordChar = '\0';
            this.tboxContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxContact.SelectedText = "";
            this.tboxContact.Size = new System.Drawing.Size(332, 28);
            this.tboxContact.TabIndex = 3;
            this.tboxContact.UseSelectable = true;
            // 
            // tboxSupplier
            // 
            this.tboxSupplier.Lines = new string[0];
            this.tboxSupplier.Location = new System.Drawing.Point(234, 28);
            this.tboxSupplier.MaxLength = 32767;
            this.tboxSupplier.Name = "tboxSupplier";
            this.tboxSupplier.PasswordChar = '\0';
            this.tboxSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxSupplier.SelectedText = "";
            this.tboxSupplier.Size = new System.Drawing.Size(332, 28);
            this.tboxSupplier.TabIndex = 0;
            this.tboxSupplier.UseSelectable = true;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -277;
            this.lineShape2.X2 = 993;
            this.lineShape2.Y1 = 3;
            this.lineShape2.Y2 = 3;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -276;
            this.lineShape1.X2 = 994;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(720, 332);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // add_UpdateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 412);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "add_UpdateSupplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.add_UpdateSupplier_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnUpdate_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox tboxAddress;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tboxContact;
        private MetroFramework.Controls.MetroTextBox tboxSupplier;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}