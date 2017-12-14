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
            SIngltonClass.Myinstance.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            SIngltonClass.Myinstance.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            SIngltonClass.Myinstance.gridControl1 = new DevExpress.XtraGrid.GridControl();
            SIngltonClass.Myinstance.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            SIngltonClass.Myinstance.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            SIngltonClass.Myinstance.RegionId_textbox = new DevExpress.XtraEditors.TextEdit();
            SIngltonClass.Myinstance.TerritoryId_textbox = new DevExpress.XtraEditors.TextEdit();
            SIngltonClass.Myinstance.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            SIngltonClass.Myinstance.EmployeeIDlabel = new DevExpress.XtraEditors.LabelControl();
            SIngltonClass.Myinstance.TerritoryDescription_textbox = new DevExpress.XtraEditors.TextEdit();
            SIngltonClass.Myinstance.FirstNamelabel = new DevExpress.XtraEditors.LabelControl();
            SIngltonClass.Myinstance.toolStrip1 = new System.Windows.Forms.ToolStrip();
            SIngltonClass.Myinstance.Save_toolStripButton = new System.Windows.Forms.ToolStripButton();
            SIngltonClass.Myinstance.Edit_toolStripButton = new System.Windows.Forms.ToolStripButton();
            SIngltonClass.Myinstance.Delete_toolStripButton = new System.Windows.Forms.ToolStripButton();
            SIngltonClass.Myinstance.Clear_toolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.panelControl1)).BeginInit();
            SIngltonClass.Myinstance.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.panelControl3)).BeginInit();
            SIngltonClass.Myinstance.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.panelControl4)).BeginInit();
            SIngltonClass.Myinstance.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.RegionId_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.TerritoryId_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.TerritoryDescription_textbox.Properties)).BeginInit();
            SIngltonClass.Myinstance.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            SIngltonClass.Myinstance.panelControl1.Controls.Add(SIngltonClass.Myinstance.panelControl3);
            SIngltonClass.Myinstance.panelControl1.Location = new System.Drawing.Point(8, 12);
            SIngltonClass.Myinstance.panelControl1.Name = "panelControl1";
            SIngltonClass.Myinstance.panelControl1.Size = new System.Drawing.Size(643, 503);
            SIngltonClass.Myinstance.panelControl1.TabIndex = 8;
            // 
            // panelControl3
            // 
            SIngltonClass.Myinstance.panelControl3.Controls.Add(SIngltonClass.Myinstance.gridControl1);
            SIngltonClass.Myinstance.panelControl3.Controls.Add(SIngltonClass.Myinstance.panelControl4);
            SIngltonClass.Myinstance.panelControl3.Controls.Add(SIngltonClass.Myinstance.toolStrip1);
            SIngltonClass.Myinstance.panelControl3.Location = new System.Drawing.Point(15, 17);
            SIngltonClass.Myinstance.panelControl3.Name = "panelControl3";
            SIngltonClass.Myinstance.panelControl3.Size = new System.Drawing.Size(609, 471);
            SIngltonClass.Myinstance.panelControl3.TabIndex = 28;
            // 
            // gridControl1
            // 
            SIngltonClass.Myinstance.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            SIngltonClass.Myinstance.gridControl1.Location = new System.Drawing.Point(16, 197);
            SIngltonClass.Myinstance.gridControl1.MainView = SIngltonClass.Myinstance.gridView1;
            SIngltonClass.Myinstance.gridControl1.Name = "gridControl1";
            SIngltonClass.Myinstance.gridControl1.Size = new System.Drawing.Size(577, 269);
            SIngltonClass.Myinstance.gridControl1.TabIndex = 29;
            SIngltonClass.Myinstance.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            SIngltonClass.Myinstance.gridView1});
            // 
            // gridView1
            // 
            SIngltonClass.Myinstance.gridView1.GridControl = SIngltonClass.Myinstance.gridControl1;
            SIngltonClass.Myinstance.gridView1.Name = "gridView1";
            SIngltonClass.Myinstance.gridView1.OptionsBehavior.Editable = false;
            SIngltonClass.Myinstance.gridView1.OptionsFind.AlwaysVisible = true;
            SIngltonClass.Myinstance.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // panelControl4
            // 
            SIngltonClass.Myinstance.panelControl4.Controls.Add(SIngltonClass.Myinstance.RegionId_textbox);
            SIngltonClass.Myinstance.panelControl4.Controls.Add(SIngltonClass.Myinstance.TerritoryId_textbox);
            SIngltonClass.Myinstance.panelControl4.Controls.Add(SIngltonClass.Myinstance.labelControl1);
            SIngltonClass.Myinstance.panelControl4.Controls.Add(SIngltonClass.Myinstance.EmployeeIDlabel);
            SIngltonClass.Myinstance.panelControl4.Controls.Add(SIngltonClass.Myinstance.TerritoryDescription_textbox);
            SIngltonClass.Myinstance.panelControl4.Controls.Add(SIngltonClass.Myinstance.FirstNamelabel);
            SIngltonClass.Myinstance.panelControl4.Location = new System.Drawing.Point(16, 40);
            SIngltonClass.Myinstance.panelControl4.Name = "panelControl4";
            SIngltonClass.Myinstance.panelControl4.Size = new System.Drawing.Size(285, 127);
            SIngltonClass.Myinstance.panelControl4.TabIndex = 28;
            // 
            // RegionId_textbox
            // 
            SIngltonClass.Myinstance.RegionId_textbox.Location = new System.Drawing.Point(106, 80);
            SIngltonClass.Myinstance.RegionId_textbox.Name = "RegionId_textbox";
            SIngltonClass.Myinstance.RegionId_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            SIngltonClass.Myinstance.RegionId_textbox.Size = new System.Drawing.Size(162, 20);
            SIngltonClass.Myinstance.RegionId_textbox.TabIndex = 39;
            // 
            // TerritoryId_textbox
            // 
            SIngltonClass.Myinstance.TerritoryId_textbox.Location = new System.Drawing.Point(106, 14);
            SIngltonClass.Myinstance.TerritoryId_textbox.Name = "TerritoryId_textbox";
            SIngltonClass.Myinstance.TerritoryId_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            SIngltonClass.Myinstance.TerritoryId_textbox.Size = new System.Drawing.Size(162, 20);
            SIngltonClass.Myinstance.TerritoryId_textbox.TabIndex = 1;
            // 
            // labelControl1
            // 
            SIngltonClass.Myinstance.labelControl1.Location = new System.Drawing.Point(5, 83);
            SIngltonClass.Myinstance.labelControl1.Name = "labelControl1";
            SIngltonClass.Myinstance.labelControl1.Size = new System.Drawing.Size(44, 13);
            SIngltonClass.Myinstance.labelControl1.TabIndex = 38;
            SIngltonClass.Myinstance.labelControl1.Text = "RegionID";
            // 
            // EmployeeIDlabel
            // 
            SIngltonClass.Myinstance.EmployeeIDlabel.Location = new System.Drawing.Point(5, 17);
            SIngltonClass.Myinstance.EmployeeIDlabel.Name = "EmployeeIDlabel";
            SIngltonClass.Myinstance.EmployeeIDlabel.Size = new System.Drawing.Size(53, 13);
            SIngltonClass.Myinstance.EmployeeIDlabel.TabIndex = 0;
            SIngltonClass.Myinstance.EmployeeIDlabel.Text = "TerritoryID";
            // 
            // TerritoryDescription_textbox
            // 
            SIngltonClass.Myinstance.TerritoryDescription_textbox.Location = new System.Drawing.Point(106, 44);
            SIngltonClass.Myinstance.TerritoryDescription_textbox.Name = "TerritoryDescription_textbox";
            SIngltonClass.Myinstance.TerritoryDescription_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            SIngltonClass.Myinstance.TerritoryDescription_textbox.Size = new System.Drawing.Size(162, 20);
            SIngltonClass.Myinstance.TerritoryDescription_textbox.TabIndex = 37;
            // 
            // FirstNamelabel
            // 
            SIngltonClass.Myinstance.FirstNamelabel.Location = new System.Drawing.Point(5, 47);
            SIngltonClass.Myinstance.FirstNamelabel.Name = "FirstNamelabel";
            SIngltonClass.Myinstance.FirstNamelabel.Size = new System.Drawing.Size(95, 13);
            SIngltonClass.Myinstance.FirstNamelabel.TabIndex = 1;
            SIngltonClass.Myinstance.FirstNamelabel.Text = "TerritoryDescription";
            // 
            // toolStrip1
            // 
            SIngltonClass.Myinstance.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            SIngltonClass.Myinstance.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            SIngltonClass.Myinstance.Save_toolStripButton,
            SIngltonClass.Myinstance.Edit_toolStripButton,
            SIngltonClass.Myinstance.Delete_toolStripButton,
            SIngltonClass.Myinstance.Clear_toolStripButton});
            SIngltonClass.Myinstance.toolStrip1.Location = new System.Drawing.Point(2, 2);
            SIngltonClass.Myinstance.toolStrip1.Name = "toolStrip1";
            SIngltonClass.Myinstance.toolStrip1.Size = new System.Drawing.Size(605, 25);
            SIngltonClass.Myinstance.toolStrip1.TabIndex = 27;
            SIngltonClass.Myinstance.toolStrip1.Text = "toolStrip1";
            // 
            // Save_toolStripButton
            // 
            SIngltonClass.Myinstance.Save_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Save_toolStripButton.Image")));
            SIngltonClass.Myinstance.Save_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SIngltonClass.Myinstance.Save_toolStripButton.Name = "Save_toolStripButton";
            SIngltonClass.Myinstance.Save_toolStripButton.Size = new System.Drawing.Size(51, 22);
            SIngltonClass.Myinstance.Save_toolStripButton.Text = "Save";
            SIngltonClass.Myinstance.Save_toolStripButton.Click += new System.EventHandler(this.Save_toolStripButton_Click);
            // 
            // Edit_toolStripButton
            // 
            SIngltonClass.Myinstance.Edit_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Edit_toolStripButton.Image")));
            SIngltonClass.Myinstance.Edit_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SIngltonClass.Myinstance.Edit_toolStripButton.Name = "Edit_toolStripButton";
            SIngltonClass.Myinstance.Edit_toolStripButton.Size = new System.Drawing.Size(47, 22);
            SIngltonClass.Myinstance.Edit_toolStripButton.Text = "Edit";
            SIngltonClass.Myinstance.Edit_toolStripButton.Click += new System.EventHandler(this.Edit_toolStripButton_Click);
            // 
            // Delete_toolStripButton
            // 
            SIngltonClass.Myinstance.Delete_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Delete_toolStripButton.Image")));
            SIngltonClass.Myinstance.Delete_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SIngltonClass.Myinstance.Delete_toolStripButton.Name = "Delete_toolStripButton";
            SIngltonClass.Myinstance.Delete_toolStripButton.Size = new System.Drawing.Size(67, 22);
            SIngltonClass.Myinstance.Delete_toolStripButton.Text = "Deleted";
            SIngltonClass.Myinstance.Delete_toolStripButton.Click += new System.EventHandler(this.Delete_toolStripButton_Click);
            // 
            // Clear_toolStripButton
            // 
            SIngltonClass.Myinstance.Clear_toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Clear_toolStripButton.Image")));
            SIngltonClass.Myinstance.Clear_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SIngltonClass.Myinstance.Clear_toolStripButton.Name = "Clear_toolStripButton";
            SIngltonClass.Myinstance.Clear_toolStripButton.Size = new System.Drawing.Size(54, 22);
            SIngltonClass.Myinstance.Clear_toolStripButton.Text = "Clear";
            SIngltonClass.Myinstance.Clear_toolStripButton.Click += new System.EventHandler(this.Clear_toolStripButton_Click);
            // 
            // TerritoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 542);
            this.Controls.Add(SIngltonClass.Myinstance.panelControl1);
            this.Name = "TerritoriesForm";
            this.Text = "TerritoriesForm";
            this.Load += new System.EventHandler(this.TerritoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.panelControl1)).EndInit();
            SIngltonClass.Myinstance.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.panelControl3)).EndInit();
            SIngltonClass.Myinstance.panelControl3.ResumeLayout(false);
            SIngltonClass.Myinstance.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.panelControl4)).EndInit();
            SIngltonClass.Myinstance.panelControl4.ResumeLayout(false);
            SIngltonClass.Myinstance.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.RegionId_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.TerritoryId_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(SIngltonClass.Myinstance.TerritoryDescription_textbox.Properties)).EndInit();
            SIngltonClass.Myinstance.toolStrip1.ResumeLayout(false);
            SIngltonClass.Myinstance.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion



    }
}