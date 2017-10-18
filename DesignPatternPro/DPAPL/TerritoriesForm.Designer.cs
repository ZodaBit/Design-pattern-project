namespace DPAPL
{
    partial class TerritoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerritoriesForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.RegionId_textbox = new DevExpress.XtraEditors.TextEdit();
            this.TerritoryId_textbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.EmployeeIDlabel = new DevExpress.XtraEditors.LabelControl();
            this.TerritoryDescription_textbox = new DevExpress.XtraEditors.TextEdit();
            this.FirstNamelabel = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Save_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Edit_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Delete_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Clear_toolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegionId_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerritoryId_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerritoryDescription_textbox.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Location = new System.Drawing.Point(8, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(643, 503);
            this.panelControl1.TabIndex = 8;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.toolStrip1);
            this.panelControl3.Location = new System.Drawing.Point(15, 17);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(609, 471);
            this.panelControl3.TabIndex = 28;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(16, 197);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(577, 269);
            this.gridControl1.TabIndex = 29;
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
            this.panelControl4.Controls.Add(this.RegionId_textbox);
            this.panelControl4.Controls.Add(this.TerritoryId_textbox);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.EmployeeIDlabel);
            this.panelControl4.Controls.Add(this.TerritoryDescription_textbox);
            this.panelControl4.Controls.Add(this.FirstNamelabel);
            this.panelControl4.Location = new System.Drawing.Point(16, 40);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(285, 127);
            this.panelControl4.TabIndex = 28;
            // 
            // RegionId_textbox
            // 
            this.RegionId_textbox.Location = new System.Drawing.Point(106, 80);
            this.RegionId_textbox.Name = "RegionId_textbox";
            this.RegionId_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.RegionId_textbox.Size = new System.Drawing.Size(162, 20);
            this.RegionId_textbox.TabIndex = 39;
            // 
            // TerritoryId_textbox
            // 
            this.TerritoryId_textbox.Location = new System.Drawing.Point(106, 14);
            this.TerritoryId_textbox.Name = "TerritoryId_textbox";
            this.TerritoryId_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.TerritoryId_textbox.Size = new System.Drawing.Size(162, 20);
            this.TerritoryId_textbox.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "RegionID";
            // 
            // EmployeeIDlabel
            // 
            this.EmployeeIDlabel.Location = new System.Drawing.Point(5, 17);
            this.EmployeeIDlabel.Name = "EmployeeIDlabel";
            this.EmployeeIDlabel.Size = new System.Drawing.Size(53, 13);
            this.EmployeeIDlabel.TabIndex = 0;
            this.EmployeeIDlabel.Text = "TerritoryID";
            // 
            // TerritoryDescription_textbox
            // 
            this.TerritoryDescription_textbox.Location = new System.Drawing.Point(106, 44);
            this.TerritoryDescription_textbox.Name = "TerritoryDescription_textbox";
            this.TerritoryDescription_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.TerritoryDescription_textbox.Size = new System.Drawing.Size(162, 20);
            this.TerritoryDescription_textbox.TabIndex = 37;
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.Location = new System.Drawing.Point(5, 47);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(95, 13);
            this.FirstNamelabel.TabIndex = 1;
            this.FirstNamelabel.Text = "TerritoryDescription";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_toolStripButton,
            this.Edit_toolStripButton,
            this.Delete_toolStripButton,
            this.Clear_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(605, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
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
            // Delete_toolStripButton
            // 
            this.Delete_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Delete_toolStripButton.Image")));
            this.Delete_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_toolStripButton.Name = "Delete_toolStripButton";
            this.Delete_toolStripButton.Size = new System.Drawing.Size(67, 22);
            this.Delete_toolStripButton.Text = "Deleted";
            this.Delete_toolStripButton.Click += new System.EventHandler(this.Delete_toolStripButton_Click);
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
            // TerritoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 542);
            this.Controls.Add(this.panelControl1);
            this.Name = "TerritoriesForm";
            this.Text = "TerritoriesForm";
            this.Load += new System.EventHandler(this.TerritoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegionId_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerritoryId_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerritoryDescription_textbox.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.TextEdit RegionId_textbox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TerritoryDescription_textbox;
        private DevExpress.XtraEditors.LabelControl FirstNamelabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Save_toolStripButton;
        private System.Windows.Forms.ToolStripButton Edit_toolStripButton;
        private System.Windows.Forms.ToolStripButton Delete_toolStripButton;
        private System.Windows.Forms.ToolStripButton Clear_toolStripButton;
        private DevExpress.XtraEditors.TextEdit TerritoryId_textbox;
        private DevExpress.XtraEditors.LabelControl EmployeeIDlabel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}