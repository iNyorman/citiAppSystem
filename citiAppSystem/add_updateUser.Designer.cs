namespace citiAppSystem
{
    partial class add_updateUser
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
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tboxBranchNo = new MetroFramework.Controls.MetroTextBox();
            this.cBoxRole = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tboxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tboxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tboxLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tboxFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tboxUserID = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnUpdate_Save = new MetroFramework.Controls.MetroButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.tboxBranchNo);
            this.groupBox1.Controls.Add(this.cBoxRole);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.tboxPassword);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.tboxUsername);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.tboxLastName);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.tboxFirstName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.tboxUserID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(955, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearch.Location = new System.Drawing.Point(724, 338);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(196, 42);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(119, 341);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 20);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Branch Code :";
            // 
            // tboxBranchNo
            // 
            this.tboxBranchNo.Enabled = false;
            this.tboxBranchNo.Lines = new string[0];
            this.tboxBranchNo.Location = new System.Drawing.Point(273, 341);
            this.tboxBranchNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxBranchNo.MaxLength = 32767;
            this.tboxBranchNo.Name = "tboxBranchNo";
            this.tboxBranchNo.PasswordChar = '\0';
            this.tboxBranchNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxBranchNo.SelectedText = "";
            this.tboxBranchNo.Size = new System.Drawing.Size(443, 34);
            this.tboxBranchNo.TabIndex = 19;
            this.tboxBranchNo.UseSelectable = true;
            // 
            // cBoxRole
            // 
            this.cBoxRole.FormattingEnabled = true;
            this.cBoxRole.ItemHeight = 24;
            this.cBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Audit",
            "Assistan Audit",
            "Marketing",
            "Cashier",
            "Stocks",
            "Encoder",
            "C&C"});
            this.cBoxRole.Location = new System.Drawing.Point(273, 193);
            this.cBoxRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxRole.Name = "cBoxRole";
            this.cBoxRole.Size = new System.Drawing.Size(441, 30);
            this.cBoxRole.TabIndex = 3;
            this.cBoxRole.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(188, 202);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 20);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Role :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(149, 297);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 20);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Password :";
            // 
            // tboxPassword
            // 
            this.tboxPassword.Lines = new string[0];
            this.tboxPassword.Location = new System.Drawing.Point(273, 290);
            this.tboxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxPassword.MaxLength = 32767;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '\0';
            this.tboxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxPassword.SelectedText = "";
            this.tboxPassword.Size = new System.Drawing.Size(443, 34);
            this.tboxPassword.TabIndex = 5;
            this.tboxPassword.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(147, 254);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 20);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Username :";
            // 
            // tboxUsername
            // 
            this.tboxUsername.Lines = new string[0];
            this.tboxUsername.Location = new System.Drawing.Point(273, 242);
            this.tboxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxUsername.MaxLength = 32767;
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.PasswordChar = '\0';
            this.tboxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxUsername.SelectedText = "";
            this.tboxUsername.Size = new System.Drawing.Size(443, 34);
            this.tboxUsername.TabIndex = 4;
            this.tboxUsername.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(136, 153);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 20);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Last Name :";
            // 
            // tboxLastName
            // 
            this.tboxLastName.Lines = new string[0];
            this.tboxLastName.Location = new System.Drawing.Point(273, 145);
            this.tboxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxLastName.MaxLength = 32767;
            this.tboxLastName.Name = "tboxLastName";
            this.tboxLastName.PasswordChar = '\0';
            this.tboxLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxLastName.SelectedText = "";
            this.tboxLastName.Size = new System.Drawing.Size(443, 34);
            this.tboxLastName.TabIndex = 2;
            this.tboxLastName.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(136, 100);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 20);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "First Name :";
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.Lines = new string[0];
            this.tboxFirstName.Location = new System.Drawing.Point(273, 95);
            this.tboxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxFirstName.MaxLength = 32767;
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.PasswordChar = '\0';
            this.tboxFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxFirstName.SelectedText = "";
            this.tboxFirstName.Size = new System.Drawing.Size(443, 34);
            this.tboxFirstName.TabIndex = 1;
            this.tboxFirstName.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(164, 53);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "User ID :";
            // 
            // tboxUserID
            // 
            this.tboxUserID.Lines = new string[0];
            this.tboxUserID.Location = new System.Drawing.Point(273, 46);
            this.tboxUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxUserID.MaxLength = 32767;
            this.tboxUserID.Name = "tboxUserID";
            this.tboxUserID.PasswordChar = '\0';
            this.tboxUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxUserID.SelectedText = "";
            this.tboxUserID.Size = new System.Drawing.Size(443, 34);
            this.tboxUserID.TabIndex = 0;
            this.tboxUserID.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate_Save);
            this.groupBox2.Location = new System.Drawing.Point(31, 555);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(955, 96);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBack.Location = new System.Drawing.Point(20, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(196, 42);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.Location = new System.Drawing.Point(491, 23);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(196, 42);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseCustomBackColor = true;
            this.btnClear.UseSelectable = true;
            // 
            // btnUpdate_Save
            // 
            this.btnUpdate_Save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdate_Save.Location = new System.Drawing.Point(724, 23);
            this.btnUpdate_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate_Save.Name = "btnUpdate_Save";
            this.btnUpdate_Save.Size = new System.Drawing.Size(196, 42);
            this.btnUpdate_Save.TabIndex = 7;
            this.btnUpdate_Save.Text = "Save";
            this.btnUpdate_Save.UseCustomBackColor = true;
            this.btnUpdate_Save.UseSelectable = true;
            this.btnUpdate_Save.Click += new System.EventHandler(this.btnUpdate_Save_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(27, 74);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1005, 595);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -35;
            this.lineShape2.X2 = 757;
            this.lineShape2.Y1 = 6;
            this.lineShape2.Y2 = 6;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -18;
            this.lineShape1.X2 = 774;
            this.lineShape1.Y1 = 2;
            this.lineShape1.Y2 = 2;
            // 
            // add_updateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "add_updateUser";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "User";
            this.Load += new System.EventHandler(this.add_updateUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cBoxRole;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tboxPassword;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tboxUsername;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tboxLastName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tboxFirstName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tboxUserID;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnUpdate_Save;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tboxBranchNo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}