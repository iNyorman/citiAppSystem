namespace citiAppSystem.Modules.Views.Management.Account
{
    partial class frmManageUpdateStock
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
            System.Windows.Forms.Label accountNoLabel;
            System.Windows.Forms.Label stockNoLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label serialNoLabel;
            System.Windows.Forms.Label brandLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUpdateStock));
            this.tBoxAccountNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brandLabel1 = new System.Windows.Forms.Label();
            this.dR_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryReceiptDatasets = new citiAppSystem.Modules.Datasets.DeliveryReceiptDatasets();
            this.serialNoLabel1 = new System.Windows.Forms.Label();
            this.modelLabel1 = new System.Windows.Forms.Label();
            this.stockNoLabel1 = new System.Windows.Forms.Label();
            this.accountNoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dR_detailsTableAdapter = new citiAppSystem.Modules.Datasets.DeliveryReceiptDatasetsTableAdapters.DR_detailsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxNewStockNo = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productStatus = new System.Windows.Forms.Label();
            accountNoLabel = new System.Windows.Forms.Label();
            stockNoLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            serialNoLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dR_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryReceiptDatasets)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNoLabel
            // 
            accountNoLabel.AutoSize = true;
            accountNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            accountNoLabel.Location = new System.Drawing.Point(55, 28);
            accountNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            accountNoLabel.Name = "accountNoLabel";
            accountNoLabel.Size = new System.Drawing.Size(107, 20);
            accountNoLabel.TabIndex = 4;
            accountNoLabel.Text = "Account No:";
            // 
            // stockNoLabel
            // 
            stockNoLabel.AutoSize = true;
            stockNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockNoLabel.Location = new System.Drawing.Point(76, 59);
            stockNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            stockNoLabel.Name = "stockNoLabel";
            stockNoLabel.Size = new System.Drawing.Size(84, 20);
            stockNoLabel.TabIndex = 5;
            stockNoLabel.Text = "stock No:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelLabel.Location = new System.Drawing.Point(95, 94);
            modelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(62, 20);
            modelLabel.TabIndex = 6;
            modelLabel.Text = "model:";
            // 
            // serialNoLabel
            // 
            serialNoLabel.AutoSize = true;
            serialNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serialNoLabel.Location = new System.Drawing.Point(75, 132);
            serialNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            serialNoLabel.Name = "serialNoLabel";
            serialNoLabel.Size = new System.Drawing.Size(84, 20);
            serialNoLabel.TabIndex = 7;
            serialNoLabel.Text = "serial No:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            brandLabel.Location = new System.Drawing.Point(98, 168);
            brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(60, 20);
            brandLabel.TabIndex = 8;
            brandLabel.Text = "brand:";
            // 
            // tBoxAccountNo
            // 
            this.tBoxAccountNo.Location = new System.Drawing.Point(22, 32);
            this.tBoxAccountNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxAccountNo.Name = "tBoxAccountNo";
            this.tBoxAccountNo.Size = new System.Drawing.Size(138, 20);
            this.tBoxAccountNo.TabIndex = 0;
            this.tBoxAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxAccountNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(brandLabel);
            this.groupBox1.Controls.Add(this.brandLabel1);
            this.groupBox1.Controls.Add(serialNoLabel);
            this.groupBox1.Controls.Add(this.serialNoLabel1);
            this.groupBox1.Controls.Add(modelLabel);
            this.groupBox1.Controls.Add(this.modelLabel1);
            this.groupBox1.Controls.Add(stockNoLabel);
            this.groupBox1.Controls.Add(this.stockNoLabel1);
            this.groupBox1.Controls.Add(accountNoLabel);
            this.groupBox1.Controls.Add(this.accountNoLinkLabel);
            this.groupBox1.Location = new System.Drawing.Point(9, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(437, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // brandLabel1
            // 
            this.brandLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dR_detailsBindingSource, "brand", true));
            this.brandLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel1.Location = new System.Drawing.Point(165, 168);
            this.brandLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel1.Name = "brandLabel1";
            this.brandLabel1.Size = new System.Drawing.Size(250, 19);
            this.brandLabel1.TabIndex = 9;
            this.brandLabel1.Text = "{{}}";
            // 
            // dR_detailsBindingSource
            // 
            this.dR_detailsBindingSource.DataMember = "DR_details";
            this.dR_detailsBindingSource.DataSource = this.deliveryReceiptDatasets;
            // 
            // deliveryReceiptDatasets
            // 
            this.deliveryReceiptDatasets.DataSetName = "DeliveryReceiptDatasets";
            this.deliveryReceiptDatasets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serialNoLabel1
            // 
            this.serialNoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dR_detailsBindingSource, "serialNo", true));
            this.serialNoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNoLabel1.Location = new System.Drawing.Point(165, 132);
            this.serialNoLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serialNoLabel1.Name = "serialNoLabel1";
            this.serialNoLabel1.Size = new System.Drawing.Size(250, 19);
            this.serialNoLabel1.TabIndex = 8;
            this.serialNoLabel1.Text = "{{}}";
            // 
            // modelLabel1
            // 
            this.modelLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dR_detailsBindingSource, "model", true));
            this.modelLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel1.Location = new System.Drawing.Point(165, 94);
            this.modelLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modelLabel1.Name = "modelLabel1";
            this.modelLabel1.Size = new System.Drawing.Size(250, 19);
            this.modelLabel1.TabIndex = 7;
            this.modelLabel1.Text = "{{}}";
            // 
            // stockNoLabel1
            // 
            this.stockNoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dR_detailsBindingSource, "stockNo", true));
            this.stockNoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNoLabel1.Location = new System.Drawing.Point(165, 59);
            this.stockNoLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockNoLabel1.Name = "stockNoLabel1";
            this.stockNoLabel1.Size = new System.Drawing.Size(250, 19);
            this.stockNoLabel1.TabIndex = 6;
            this.stockNoLabel1.Text = "{{}}";
            // 
            // accountNoLinkLabel
            // 
            this.accountNoLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dR_detailsBindingSource, "AccountNo", true));
            this.accountNoLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNoLinkLabel.Location = new System.Drawing.Point(165, 28);
            this.accountNoLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountNoLinkLabel.Name = "accountNoLinkLabel";
            this.accountNoLinkLabel.Size = new System.Drawing.Size(239, 19);
            this.accountNoLinkLabel.TabIndex = 5;
            this.accountNoLinkLabel.TabStop = true;
            this.accountNoLinkLabel.Text = "{{}}";
            this.accountNoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accountNoLinkLabel_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(9, 288);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(437, 65);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(329, 17);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dR_detailsTableAdapter
            // 
            this.dR_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "New StockNo:";
            // 
            // tBoxNewStockNo
            // 
            this.tBoxNewStockNo.Location = new System.Drawing.Point(287, 32);
            this.tBoxNewStockNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxNewStockNo.Name = "tBoxNewStockNo";
            this.tBoxNewStockNo.Size = new System.Drawing.Size(138, 20);
            this.tBoxNewStockNo.TabIndex = 5;
            this.tBoxNewStockNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tBoxNewStockNo_KeyUp);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.Control;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(53, 202);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(50, 6);
            // 
            // productStatus
            // 
            this.productStatus.AutoSize = true;
            this.productStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productStatus.Location = new System.Drawing.Point(285, 54);
            this.productStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productStatus.Name = "productStatus";
            this.productStatus.Size = new System.Drawing.Size(11, 13);
            this.productStatus.TabIndex = 7;
            this.productStatus.Text = "-";
            this.productStatus.Visible = false;
            // 
            // frmManageUpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 366);
            this.Controls.Add(this.productStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxNewStockNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxAccountNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmManageUpdateStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Stock No:";
            this.Load += new System.EventHandler(this.frmManageUpdateStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dR_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryReceiptDatasets)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxAccountNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Datasets.DeliveryReceiptDatasets deliveryReceiptDatasets;
        private System.Windows.Forms.BindingSource dR_detailsBindingSource;
        private Datasets.DeliveryReceiptDatasetsTableAdapters.DR_detailsTableAdapter dR_detailsTableAdapter;
        private System.Windows.Forms.Label stockNoLabel1;
        private System.Windows.Forms.LinkLabel accountNoLinkLabel;
        private System.Windows.Forms.Label brandLabel1;
        private System.Windows.Forms.Label serialNoLabel1;
        private System.Windows.Forms.Label modelLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxNewStockNo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label productStatus;
    }
}