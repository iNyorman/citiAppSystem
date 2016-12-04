namespace citiAppSystem.Modules.Views.Management.Logs
{
    partial class frmChangesLogs
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtDateChange = new System.Windows.Forms.DateTimePicker();
            this.tBoxDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.changesLogDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeChange = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changesLogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.timeChange);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtDateChange);
            this.groupBox1.Controls.Add(this.tBoxDetails);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxType);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Change:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Details:";
            // 
            // dtDateChange
            // 
            this.dtDateChange.Checked = false;
            this.dtDateChange.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateChange.Location = new System.Drawing.Point(508, 78);
            this.dtDateChange.Name = "dtDateChange";
            this.dtDateChange.ShowCheckBox = true;
            this.dtDateChange.Size = new System.Drawing.Size(200, 22);
            this.dtDateChange.TabIndex = 3;
            this.dtDateChange.ValueChanged += new System.EventHandler(this.dtDateChange_ValueChanged);
            // 
            // tBoxDetails
            // 
            this.tBoxDetails.Location = new System.Drawing.Point(273, 76);
            this.tBoxDetails.Name = "tBoxDetails";
            this.tBoxDetails.Size = new System.Drawing.Size(210, 22);
            this.tBoxDetails.TabIndex = 2;
            this.tBoxDetails.TextChanged += new System.EventHandler(this.tBoxDetails_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Type:";
            // 
            // cBoxType
            // 
            this.cBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Items.AddRange(new object[] {
            "All",
            "AccountNo",
            "StockNo"});
            this.cBoxType.Location = new System.Drawing.Point(30, 76);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(211, 24);
            this.cBoxType.TabIndex = 0;
            this.cBoxType.SelectedValueChanged += new System.EventHandler(this.cBoxType_SelectedValueChanged);
            // 
            // changesLogDataGridView
            // 
            this.changesLogDataGridView.AllowUserToAddRows = false;
            this.changesLogDataGridView.AllowUserToDeleteRows = false;
            this.changesLogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.changesLogDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changesLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.changesLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.changesLogDataGridView.Location = new System.Drawing.Point(12, 160);
            this.changesLogDataGridView.MultiSelect = false;
            this.changesLogDataGridView.Name = "changesLogDataGridView";
            this.changesLogDataGridView.ReadOnly = true;
            this.changesLogDataGridView.RowTemplate.Height = 24;
            this.changesLogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.changesLogDataGridView.Size = new System.Drawing.Size(1180, 525);
            this.changesLogDataGridView.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "changeType";
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "ChangeType";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Details";
            this.Column2.HeaderText = "Details";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dateChange";
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // timeChange
            // 
            this.timeChange.Checked = false;
            this.timeChange.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeChange.Location = new System.Drawing.Point(737, 78);
            this.timeChange.Name = "timeChange";
            this.timeChange.ShowCheckBox = true;
            this.timeChange.Size = new System.Drawing.Size(200, 22);
            this.timeChange.TabIndex = 6;
            this.timeChange.ValueChanged += new System.EventHandler(this.timeChange_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time Change:";
            // 
            // frmChangesLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 697);
            this.Controls.Add(this.changesLogDataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangesLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangesLogs";
            this.Load += new System.EventHandler(this.frmChangesLogs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changesLogDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView changesLogDataGridView;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxDetails;
        private System.Windows.Forms.DateTimePicker dtDateChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timeChange;
    }
}