namespace citiAppSystem.Modules.Views.DelAccView
{
    partial class frmDelAccView
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
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxAccountNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxDeleteBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDateTimeDeleted = new System.Windows.Forms.DateTimePicker();
            this.dGridDelAcc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridDelAcc)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBoxAccountNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBoxDeleteBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtDateTimeDeleted);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "AccountNo";
            // 
            // tBoxAccountNo
            // 
            this.tBoxAccountNo.Location = new System.Drawing.Point(334, 36);
            this.tBoxAccountNo.Name = "tBoxAccountNo";
            this.tBoxAccountNo.Size = new System.Drawing.Size(153, 20);
            this.tBoxAccountNo.TabIndex = 4;
            this.tBoxAccountNo.TextChanged += new System.EventHandler(this.tBoxAccountNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deleted By:";
            // 
            // tBoxDeleteBy
            // 
            this.tBoxDeleteBy.Location = new System.Drawing.Point(161, 36);
            this.tBoxDeleteBy.Name = "tBoxDeleteBy";
            this.tBoxDeleteBy.Size = new System.Drawing.Size(153, 20);
            this.tBoxDeleteBy.TabIndex = 2;
            this.tBoxDeleteBy.TextChanged += new System.EventHandler(this.tBoxDeleteBy_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // dtDateTimeDeleted
            // 
            this.dtDateTimeDeleted.Checked = false;
            this.dtDateTimeDeleted.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTimeDeleted.Location = new System.Drawing.Point(37, 36);
            this.dtDateTimeDeleted.Name = "dtDateTimeDeleted";
            this.dtDateTimeDeleted.ShowCheckBox = true;
            this.dtDateTimeDeleted.Size = new System.Drawing.Size(107, 20);
            this.dtDateTimeDeleted.TabIndex = 0;
            this.dtDateTimeDeleted.ValueChanged += new System.EventHandler(this.dtDateTimeDeleted_ValueChanged);
            // 
            // dGridDelAcc
            // 
            this.dGridDelAcc.AllowUserToAddRows = false;
            this.dGridDelAcc.AllowUserToDeleteRows = false;
            this.dGridDelAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridDelAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridDelAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGridDelAcc.Location = new System.Drawing.Point(12, 95);
            this.dGridDelAcc.Name = "dGridDelAcc";
            this.dGridDelAcc.ReadOnly = true;
            this.dGridDelAcc.Size = new System.Drawing.Size(739, 359);
            this.dGridDelAcc.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DelDateTime";
            this.Column1.HeaderText = "DateTime";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DelBy";
            this.Column2.HeaderText = "Deleted By";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UserId";
            this.Column3.HeaderText = "UserId";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "AccountNo";
            this.Column4.HeaderText = "AccountNo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELETEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.dELETEToolStripMenuItem.Text = "DELETE ACCOUNT";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // frmDelAccView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 466);
            this.Controls.Add(this.dGridDelAcc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDelAccView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleted Account View";
            this.Load += new System.EventHandler(this.frmDelAccView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridDelAcc)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGridDelAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDateTimeDeleted;
        private System.Windows.Forms.TextBox tBoxDeleteBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxAccountNo;
    }
}