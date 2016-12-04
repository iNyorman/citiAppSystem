namespace citiAppSystem.Modules.Views.Cashiers
{
    partial class frmCashierView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBoxRemarks = new System.Windows.Forms.TextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtDateTransaction = new System.Windows.Forms.DateTimePicker();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tBoxAccountName = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TBoxAccountNo = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.cboxTransactionType = new System.Windows.Forms.ComboBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.CBoxBranches = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxNetAmt = new System.Windows.Forms.TextBox();
            this.tBoxDiscount = new System.Windows.Forms.TextBox();
            this.tBoxInterest = new System.Windows.Forms.TextBox();
            this.tBoxRebate = new System.Windows.Forms.TextBox();
            this.tBoxGrsAmt = new System.Windows.Forms.TextBox();
            this.tBoxOr = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBoxChange = new System.Windows.Forms.TextBox();
            this.tBoxAmt = new System.Windows.Forms.TextBox();
            this.tBoxDetails = new System.Windows.Forms.TextBox();
            this.tBoxBank = new System.Windows.Forms.TextBox();
            this.cboxPayType = new System.Windows.Forms.ComboBox();
            this.lblChequeNo = new MetroFramework.Controls.MetroLabel();
            this.lblChange = new MetroFramework.Controls.MetroLabel();
            this.lblBank = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.citiAppDatabaseDataSet = new citiAppSystem.citiAppDatabaseDataSet();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchTableAdapter = new citiAppSystem.citiAppDatabaseDataSetTableAdapters.branchTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.tBoxRemarks);
            this.groupBox1.Controls.Add(this.metroLabel17);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.dtDateTransaction);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.tBoxAccountName);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.TBoxAccountNo);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.cboxTransactionType);
            this.groupBox1.Controls.Add(this.metroLabel18);
            this.groupBox1.Controls.Add(this.CBoxBranches);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tBoxRemarks
            // 
            this.tBoxRemarks.Location = new System.Drawing.Point(156, 162);
            this.tBoxRemarks.Name = "tBoxRemarks";
            this.tBoxRemarks.Size = new System.Drawing.Size(212, 20);
            this.tBoxRemarks.TabIndex = 55;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(74, 162);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(76, 19);
            this.metroLabel17.TabIndex = 54;
            this.metroLabel17.Text = "REMARKS :";
            this.metroLabel17.UseCustomBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(671, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 16);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Account List";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(548, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 53;
            this.metroLabel2.Text = "Date :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // dtDateTransaction
            // 
            this.dtDateTransaction.CustomFormat = "";
            this.dtDateTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTransaction.Location = new System.Drawing.Point(610, 55);
            this.dtDateTransaction.Name = "dtDateTransaction";
            this.dtDateTransaction.Size = new System.Drawing.Size(169, 20);
            this.dtDateTransaction.TabIndex = 52;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(156, 140);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(137, 19);
            this.metroLabel6.TabIndex = 51;
            this.metroLabel6.Text = "(LAST,FIRST,MIDDLE)";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // tBoxAccountName
            // 
            this.tBoxAccountName.Location = new System.Drawing.Point(156, 117);
            this.tBoxAccountName.Name = "tBoxAccountName";
            this.tBoxAccountName.Size = new System.Drawing.Size(475, 20);
            this.tBoxAccountName.TabIndex = 50;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(57, 117);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 49;
            this.metroLabel4.Text = "ACCT NAME :";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // TBoxAccountNo
            // 
            this.TBoxAccountNo.Location = new System.Drawing.Point(156, 89);
            this.TBoxAccountNo.Name = "TBoxAccountNo";
            this.TBoxAccountNo.Size = new System.Drawing.Size(212, 20);
            this.TBoxAccountNo.TabIndex = 48;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(88, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "ACCT # :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(9, 57);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(141, 19);
            this.metroLabel14.TabIndex = 46;
            this.metroLabel14.Text = "TRANSACTION TYPE :";
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // cboxTransactionType
            // 
            this.cboxTransactionType.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "DOWN",
            "INSTALLMENT",
            "MISC",
            "COD"});
            this.cboxTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTransactionType.FormattingEnabled = true;
            this.cboxTransactionType.Items.AddRange(new object[] {
            "",
            "DOWN",
            "INSTALLMENT",
            "MISC",
            "COD"});
            this.cboxTransactionType.Location = new System.Drawing.Point(156, 55);
            this.cboxTransactionType.Name = "cboxTransactionType";
            this.cboxTransactionType.Size = new System.Drawing.Size(212, 21);
            this.cboxTransactionType.TabIndex = 45;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel18.Location = new System.Drawing.Point(80, 19);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(70, 19);
            this.metroLabel18.TabIndex = 44;
            this.metroLabel18.Text = "BRANCH :";
            this.metroLabel18.UseCustomBackColor = true;
            // 
            // CBoxBranches
            // 
            this.CBoxBranches.DataSource = this.branchBindingSource;
            this.CBoxBranches.DisplayMember = "branchName";
            this.CBoxBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxBranches.FormattingEnabled = true;
            this.CBoxBranches.Location = new System.Drawing.Point(156, 19);
            this.CBoxBranches.Name = "CBoxBranches";
            this.CBoxBranches.Size = new System.Drawing.Size(212, 21);
            this.CBoxBranches.TabIndex = 0;
            this.CBoxBranches.ValueMember = "branchNo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Blue;
            this.groupBox2.Controls.Add(this.tBoxNetAmt);
            this.groupBox2.Controls.Add(this.tBoxDiscount);
            this.groupBox2.Controls.Add(this.tBoxInterest);
            this.groupBox2.Controls.Add(this.tBoxRebate);
            this.groupBox2.Controls.Add(this.tBoxGrsAmt);
            this.groupBox2.Controls.Add(this.tBoxOr);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tBoxNetAmt
            // 
            this.tBoxNetAmt.Location = new System.Drawing.Point(156, 212);
            this.tBoxNetAmt.Name = "tBoxNetAmt";
            this.tBoxNetAmt.Size = new System.Drawing.Size(181, 20);
            this.tBoxNetAmt.TabIndex = 61;
            // 
            // tBoxDiscount
            // 
            this.tBoxDiscount.Location = new System.Drawing.Point(156, 181);
            this.tBoxDiscount.Name = "tBoxDiscount";
            this.tBoxDiscount.Size = new System.Drawing.Size(181, 20);
            this.tBoxDiscount.TabIndex = 60;
            // 
            // tBoxInterest
            // 
            this.tBoxInterest.Location = new System.Drawing.Point(156, 151);
            this.tBoxInterest.Name = "tBoxInterest";
            this.tBoxInterest.Size = new System.Drawing.Size(181, 20);
            this.tBoxInterest.TabIndex = 59;
            // 
            // tBoxRebate
            // 
            this.tBoxRebate.Location = new System.Drawing.Point(156, 120);
            this.tBoxRebate.Name = "tBoxRebate";
            this.tBoxRebate.Size = new System.Drawing.Size(181, 20);
            this.tBoxRebate.TabIndex = 58;
            // 
            // tBoxGrsAmt
            // 
            this.tBoxGrsAmt.Location = new System.Drawing.Point(156, 90);
            this.tBoxGrsAmt.Name = "tBoxGrsAmt";
            this.tBoxGrsAmt.Size = new System.Drawing.Size(181, 20);
            this.tBoxGrsAmt.TabIndex = 57;
            // 
            // tBoxOr
            // 
            this.tBoxOr.Location = new System.Drawing.Point(156, 46);
            this.tBoxOr.Name = "tBoxOr";
            this.tBoxOr.Size = new System.Drawing.Size(181, 20);
            this.tBoxOr.TabIndex = 56;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(74, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "OR # :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.ForeColor = System.Drawing.Color.White;
            this.metroLabel13.Location = new System.Drawing.Point(15, 213);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(110, 19);
            this.metroLabel13.TabIndex = 44;
            this.metroLabel13.Text = "NET AMOUNT :";
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.ForeColor = System.Drawing.Color.White;
            this.metroLabel12.Location = new System.Drawing.Point(73, 181);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(48, 19);
            this.metroLabel12.TabIndex = 43;
            this.metroLabel12.Text = "DISC :";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.Color.White;
            this.metroLabel11.Location = new System.Drawing.Point(45, 151);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(79, 19);
            this.metroLabel11.TabIndex = 42;
            this.metroLabel11.Text = "INTEREST :";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.White;
            this.metroLabel10.Location = new System.Drawing.Point(56, 120);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(66, 19);
            this.metroLabel10.TabIndex = 41;
            this.metroLabel10.Text = "REBATE :";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.White;
            this.metroLabel9.Location = new System.Drawing.Point(44, 90);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(79, 19);
            this.metroLabel9.TabIndex = 40;
            this.metroLabel9.Text = "GRS AMT :";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Blue;
            this.groupBox3.Controls.Add(this.tBoxChange);
            this.groupBox3.Controls.Add(this.tBoxAmt);
            this.groupBox3.Controls.Add(this.tBoxDetails);
            this.groupBox3.Controls.Add(this.tBoxBank);
            this.groupBox3.Controls.Add(this.cboxPayType);
            this.groupBox3.Controls.Add(this.lblChequeNo);
            this.groupBox3.Controls.Add(this.lblChange);
            this.groupBox3.Controls.Add(this.lblBank);
            this.groupBox3.Controls.Add(this.metroLabel16);
            this.groupBox3.Controls.Add(this.metroLabel15);
            this.groupBox3.Location = new System.Drawing.Point(396, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 273);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tBoxChange
            // 
            this.tBoxChange.Location = new System.Drawing.Point(226, 220);
            this.tBoxChange.Name = "tBoxChange";
            this.tBoxChange.Size = new System.Drawing.Size(172, 20);
            this.tBoxChange.TabIndex = 65;
            // 
            // tBoxAmt
            // 
            this.tBoxAmt.Location = new System.Drawing.Point(226, 189);
            this.tBoxAmt.Name = "tBoxAmt";
            this.tBoxAmt.Size = new System.Drawing.Size(172, 20);
            this.tBoxAmt.TabIndex = 64;
            // 
            // tBoxDetails
            // 
            this.tBoxDetails.Location = new System.Drawing.Point(226, 159);
            this.tBoxDetails.Name = "tBoxDetails";
            this.tBoxDetails.Size = new System.Drawing.Size(172, 20);
            this.tBoxDetails.TabIndex = 63;
            // 
            // tBoxBank
            // 
            this.tBoxBank.Location = new System.Drawing.Point(226, 128);
            this.tBoxBank.Name = "tBoxBank";
            this.tBoxBank.Size = new System.Drawing.Size(172, 20);
            this.tBoxBank.TabIndex = 62;
            // 
            // cboxPayType
            // 
            this.cboxPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPayType.FormattingEnabled = true;
            this.cboxPayType.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Credit Card"});
            this.cboxPayType.Location = new System.Drawing.Point(226, 90);
            this.cboxPayType.Name = "cboxPayType";
            this.cboxPayType.Size = new System.Drawing.Size(172, 21);
            this.cboxPayType.TabIndex = 43;
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblChequeNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblChequeNo.ForeColor = System.Drawing.Color.White;
            this.lblChequeNo.Location = new System.Drawing.Point(11, 152);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(197, 19);
            this.lblChequeNo.TabIndex = 42;
            this.lblChequeNo.Text = "CHEQUE/CARD/TRANS NO. :";
            this.lblChequeNo.UseCustomBackColor = true;
            this.lblChequeNo.UseCustomForeColor = true;
            this.lblChequeNo.Visible = false;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblChange.ForeColor = System.Drawing.Color.White;
            this.lblChange.Location = new System.Drawing.Point(129, 213);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(75, 19);
            this.lblChange.TabIndex = 41;
            this.lblChange.Text = "CHANGE :";
            this.lblChange.UseCustomBackColor = true;
            this.lblChange.UseCustomForeColor = true;
            this.lblChange.Visible = false;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.BackColor = System.Drawing.Color.Transparent;
            this.lblBank.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBank.ForeColor = System.Drawing.Color.White;
            this.lblBank.Location = new System.Drawing.Point(153, 128);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(56, 19);
            this.lblBank.TabIndex = 40;
            this.lblBank.Text = "BANK :";
            this.lblBank.UseCustomBackColor = true;
            this.lblBank.UseCustomForeColor = true;
            this.lblBank.Visible = false;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.ForeColor = System.Drawing.Color.White;
            this.metroLabel16.Location = new System.Drawing.Point(92, 90);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(115, 19);
            this.metroLabel16.TabIndex = 39;
            this.metroLabel16.Text = "PAYMENT TYPE:";
            this.metroLabel16.UseCustomBackColor = true;
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.ForeColor = System.Drawing.Color.White;
            this.metroLabel15.Location = new System.Drawing.Point(129, 182);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(80, 19);
            this.metroLabel15.TabIndex = 38;
            this.metroLabel15.Text = "AMOUNT :";
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(645, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save [F2]";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 507);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close [ESC]";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // citiAppDatabaseDataSet
            // 
            this.citiAppDatabaseDataSet.DataSetName = "citiAppDatabaseDataSet";
            this.citiAppDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "branch";
            this.branchBindingSource.DataSource = this.citiAppDatabaseDataSet;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // frmCashierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCashierView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCashierView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiAppDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CBoxBranches;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.ComboBox cboxTransactionType;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox TBoxAccountNo;
        private System.Windows.Forms.TextBox tBoxAccountName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dtDateTransaction;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tBoxRemarks;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TextBox tBoxNetAmt;
        private System.Windows.Forms.TextBox tBoxDiscount;
        private System.Windows.Forms.TextBox tBoxInterest;
        private System.Windows.Forms.TextBox tBoxRebate;
        private System.Windows.Forms.TextBox tBoxGrsAmt;
        private System.Windows.Forms.TextBox tBoxOr;
        private MetroFramework.Controls.MetroLabel lblChequeNo;
        private MetroFramework.Controls.MetroLabel lblChange;
        private MetroFramework.Controls.MetroLabel lblBank;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.TextBox tBoxChange;
        private System.Windows.Forms.TextBox tBoxAmt;
        private System.Windows.Forms.TextBox tBoxDetails;
        private System.Windows.Forms.TextBox tBoxBank;
        private System.Windows.Forms.ComboBox cboxPayType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private citiAppDatabaseDataSet citiAppDatabaseDataSet;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private citiAppDatabaseDataSetTableAdapters.branchTableAdapter branchTableAdapter;
    }
}