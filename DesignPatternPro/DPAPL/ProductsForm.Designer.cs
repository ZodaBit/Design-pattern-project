namespace DPAPL
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.UnitPrice_textbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.QuantityPerUnit_textbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.UnitInStock_textbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.UnitsOnOrder_textbox = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.CatagoryId_textbox = new DevExpress.XtraEditors.TextEdit();
            this.ProductId_textbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SupplierId_textbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ProductName_textbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Discontinued_Combobox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.RecorderLevel_textbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip27 = new System.Windows.Forms.ToolStrip();
            this.Save_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Edit_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Deleted_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Clear_toolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPrice_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityPerUnit_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitInStock_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsOnOrder_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatagoryId_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductId_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierId_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductName_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discontinued_Combobox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecorderLevel_textbox.Properties)).BeginInit();
            this.toolStrip27.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.toolStrip27);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1014, 517);
            this.panelControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(14, 223);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(957, 276);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl5);
            this.panelControl4.Controls.Add(this.UnitPrice_textbox);
            this.panelControl4.Controls.Add(this.labelControl6);
            this.panelControl4.Controls.Add(this.QuantityPerUnit_textbox);
            this.panelControl4.Controls.Add(this.labelControl7);
            this.panelControl4.Controls.Add(this.UnitInStock_textbox);
            this.panelControl4.Controls.Add(this.labelControl8);
            this.panelControl4.Controls.Add(this.UnitsOnOrder_textbox);
            this.panelControl4.Location = new System.Drawing.Point(306, 42);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(271, 153);
            this.panelControl4.TabIndex = 29;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 21);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "QuantityPerUnit";
            // 
            // UnitPrice_textbox
            // 
            this.UnitPrice_textbox.Location = new System.Drawing.Point(102, 51);
            this.UnitPrice_textbox.Name = "UnitPrice_textbox";
            this.UnitPrice_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.UnitPrice_textbox.Size = new System.Drawing.Size(149, 20);
            this.UnitPrice_textbox.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 54);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "UnitPrice";
            // 
            // QuantityPerUnit_textbox
            // 
            this.QuantityPerUnit_textbox.Location = new System.Drawing.Point(102, 18);
            this.QuantityPerUnit_textbox.Name = "QuantityPerUnit_textbox";
            this.QuantityPerUnit_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.QuantityPerUnit_textbox.Size = new System.Drawing.Size(149, 20);
            this.QuantityPerUnit_textbox.TabIndex = 19;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 89);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "UnitsInStock";
            // 
            // UnitInStock_textbox
            // 
            this.UnitInStock_textbox.Location = new System.Drawing.Point(102, 82);
            this.UnitInStock_textbox.Name = "UnitInStock_textbox";
            this.UnitInStock_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.UnitInStock_textbox.Size = new System.Drawing.Size(149, 20);
            this.UnitInStock_textbox.TabIndex = 12;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(7, 124);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 13);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "UnitsOnOrder";
            // 
            // UnitsOnOrder_textbox
            // 
            this.UnitsOnOrder_textbox.Location = new System.Drawing.Point(102, 117);
            this.UnitsOnOrder_textbox.Name = "UnitsOnOrder_textbox";
            this.UnitsOnOrder_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.UnitsOnOrder_textbox.Size = new System.Drawing.Size(149, 20);
            this.UnitsOnOrder_textbox.TabIndex = 14;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.CatagoryId_textbox);
            this.panelControl3.Controls.Add(this.ProductId_textbox);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.SupplierId_textbox);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.ProductName_textbox);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Location = new System.Drawing.Point(14, 42);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(269, 153);
            this.panelControl3.TabIndex = 28;
            // 
            // CatagoryId_textbox
            // 
            this.CatagoryId_textbox.Location = new System.Drawing.Point(100, 117);
            this.CatagoryId_textbox.Name = "CatagoryId_textbox";
            this.CatagoryId_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.CatagoryId_textbox.Size = new System.Drawing.Size(149, 20);
            this.CatagoryId_textbox.TabIndex = 6;
            // 
            // ProductId_textbox
            // 
            this.ProductId_textbox.Location = new System.Drawing.Point(100, 18);
            this.ProductId_textbox.Name = "ProductId_textbox";
            this.ProductId_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.ProductId_textbox.Size = new System.Drawing.Size(149, 20);
            this.ProductId_textbox.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "CategoryID";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ProductID";
            // 
            // SupplierId_textbox
            // 
            this.SupplierId_textbox.Location = new System.Drawing.Point(100, 83);
            this.SupplierId_textbox.Name = "SupplierId_textbox";
            this.SupplierId_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.SupplierId_textbox.Size = new System.Drawing.Size(149, 20);
            this.SupplierId_textbox.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "SupplierID";
            // 
            // ProductName_textbox
            // 
            this.ProductName_textbox.Location = new System.Drawing.Point(100, 47);
            this.ProductName_textbox.Name = "ProductName_textbox";
            this.ProductName_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.ProductName_textbox.Size = new System.Drawing.Size(149, 20);
            this.ProductName_textbox.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "ProductName";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Discontinued_Combobox);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.RecorderLevel_textbox);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Location = new System.Drawing.Point(623, 42);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(262, 86);
            this.panelControl2.TabIndex = 27;
            // 
            // Discontinued_Combobox
            // 
            this.Discontinued_Combobox.Location = new System.Drawing.Point(100, 45);
            this.Discontinued_Combobox.Name = "Discontinued_Combobox";
            this.Discontinued_Combobox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Discontinued_Combobox.Properties.Items.AddRange(new object[] {
            "False",
            "True"});
            this.Discontinued_Combobox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.Discontinued_Combobox.Size = new System.Drawing.Size(151, 20);
            this.Discontinued_Combobox.TabIndex = 27;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(5, 20);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 13);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "ReorderLevel";
            // 
            // RecorderLevel_textbox
            // 
            this.RecorderLevel_textbox.Location = new System.Drawing.Point(100, 13);
            this.RecorderLevel_textbox.Name = "RecorderLevel_textbox";
            this.RecorderLevel_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.RecorderLevel_textbox.Size = new System.Drawing.Size(149, 20);
            this.RecorderLevel_textbox.TabIndex = 16;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(5, 52);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(61, 13);
            this.labelControl10.TabIndex = 17;
            this.labelControl10.Text = "Discontinued";
            // 
            // toolStrip27
            // 
            this.toolStrip27.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip27.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_toolStripButton,
            this.Edit_toolStripButton,
            this.Deleted_toolStripButton,
            this.Clear_toolStripButton});
            this.toolStrip27.Location = new System.Drawing.Point(2, 2);
            this.toolStrip27.Name = "toolStrip27";
            this.toolStrip27.Size = new System.Drawing.Size(1010, 25);
            this.toolStrip27.TabIndex = 26;
            this.toolStrip27.Text = "toolStrip27";
            // 
            // Save_toolStripButton
            // 
            this.Save_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Save_toolStripButton.Image")));
            this.Save_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_toolStripButton.Name = "Save_toolStripButton";
            this.Save_toolStripButton.Size = new System.Drawing.Size(51, 22);
            this.Save_toolStripButton.Text = "Save";
            this.Save_toolStripButton.Click += new System.EventHandler(this.Save_toolStripButton_Click);
            // 
            // Edit_toolStripButton
            // 
            this.Edit_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Edit_toolStripButton.Image")));
            this.Edit_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_toolStripButton.Name = "Edit_toolStripButton";
            this.Edit_toolStripButton.Size = new System.Drawing.Size(47, 22);
            this.Edit_toolStripButton.Text = "Edit";
            this.Edit_toolStripButton.Click += new System.EventHandler(this.Edit_toolStripButton_Click);
            // 
            // Deleted_toolStripButton
            // 
            this.Deleted_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Deleted_toolStripButton.Image")));
            this.Deleted_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Deleted_toolStripButton.Name = "Deleted_toolStripButton";
            this.Deleted_toolStripButton.Size = new System.Drawing.Size(67, 22);
            this.Deleted_toolStripButton.Text = "Deleted";
            this.Deleted_toolStripButton.Click += new System.EventHandler(this.Deleted_toolStripButton_Click);
            // 
            // Clear_toolStripButton
            // 
            this.Clear_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Clear_toolStripButton.Image")));
            this.Clear_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear_toolStripButton.Name = "Clear_toolStripButton";
            this.Clear_toolStripButton.Size = new System.Drawing.Size(54, 22);
            this.Clear_toolStripButton.Text = "Clear";
            this.Clear_toolStripButton.Click += new System.EventHandler(this.Clear_toolStripButton_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 552);
            this.Controls.Add(this.panelControl1);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitPrice_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityPerUnit_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitInStock_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsOnOrder_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatagoryId_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductId_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierId_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductName_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Discontinued_Combobox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecorderLevel_textbox.Properties)).EndInit();
            this.toolStrip27.ResumeLayout(false);
            this.toolStrip27.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit UnitPrice_textbox;
        private DevExpress.XtraEditors.TextEdit QuantityPerUnit_textbox;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit RecorderLevel_textbox;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit UnitsOnOrder_textbox;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit UnitInStock_textbox;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit CatagoryId_textbox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit SupplierId_textbox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit ProductName_textbox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit ProductId_textbox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip27;
        private System.Windows.Forms.ToolStripButton Save_toolStripButton;
        private System.Windows.Forms.ToolStripButton Edit_toolStripButton;
        private System.Windows.Forms.ToolStripButton Deleted_toolStripButton;
        private System.Windows.Forms.ToolStripButton Clear_toolStripButton;
        private DevExpress.XtraEditors.ComboBoxEdit Discontinued_Combobox;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

    }
}