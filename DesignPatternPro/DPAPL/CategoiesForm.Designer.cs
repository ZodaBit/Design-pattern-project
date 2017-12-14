namespace DPAPL
{
    partial class CategoiesForm
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoiesForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.CategoyId_textbox = new DevExpress.XtraEditors.TextEdit();
            this.EmployeeIDlabel = new DevExpress.XtraEditors.LabelControl();
            this.Desciption_textbox = new DevExpress.XtraEditors.TextEdit();
            this.CategoyName_textbox = new DevExpress.XtraEditors.TextEdit();
            this.FirstNamelabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Save_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Edit_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Delete_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Clear_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Pictue_imagebox = new DevExpress.XtraEditors.PictureEdit();
            this.LoadPictue_btn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ImgFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoyId_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desciption_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoyName_textbox.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pictue_imagebox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(624, 527);
            this.panelControl1.TabIndex = 5;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.toolStrip1);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Location = new System.Drawing.Point(5, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(595, 507);
            this.panelControl3.TabIndex = 28;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(16, 196);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(550, 293);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.ColumnFilterButton.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.CategoyId_textbox);
            this.panelControl4.Controls.Add(this.EmployeeIDlabel);
            this.panelControl4.Controls.Add(this.Desciption_textbox);
            this.panelControl4.Controls.Add(this.CategoyName_textbox);
            this.panelControl4.Controls.Add(this.FirstNamelabel);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Location = new System.Drawing.Point(16, 40);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(279, 133);
            this.panelControl4.TabIndex = 28;
            // 
            // CategoyId_textbox
            // 
            this.CategoyId_textbox.Location = new System.Drawing.Point(100, 14);
            this.CategoyId_textbox.Name = "CategoyId_textbox";
            this.CategoyId_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.CategoyId_textbox.Size = new System.Drawing.Size(149, 20);
            this.CategoyId_textbox.TabIndex = 1;
            // 
            // EmployeeIDlabel
            // 
            this.EmployeeIDlabel.Location = new System.Drawing.Point(5, 17);
            this.EmployeeIDlabel.Name = "EmployeeIDlabel";
            this.EmployeeIDlabel.Size = new System.Drawing.Size(56, 13);
            this.EmployeeIDlabel.TabIndex = 0;
            this.EmployeeIDlabel.Text = "CategoryID";
            // 
            // Desciption_textbox
            // 
            this.Desciption_textbox.Location = new System.Drawing.Point(100, 79);
            this.Desciption_textbox.Name = "Desciption_textbox";
            this.Desciption_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.Desciption_textbox.Size = new System.Drawing.Size(149, 20);
            this.Desciption_textbox.TabIndex = 39;
            // 
            // CategoyName_textbox
            // 
            this.CategoyName_textbox.Location = new System.Drawing.Point(100, 44);
            this.CategoyName_textbox.Name = "CategoyName_textbox";
            this.CategoyName_textbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.CategoyName_textbox.Size = new System.Drawing.Size(149, 20);
            this.CategoyName_textbox.TabIndex = 37;
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.Location = new System.Drawing.Point(5, 47);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(72, 13);
            this.FirstNamelabel.TabIndex = 1;
            this.FirstNamelabel.Text = "CategoryName";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Description";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Green;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_toolStripButton,
            this.Edit_toolStripButton,
            this.Delete_toolStripButton,
            this.Clear_toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(591, 25);
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Pictue_imagebox);
            this.panelControl2.Controls.Add(this.LoadPictue_btn);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Location = new System.Drawing.Point(341, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(225, 133);
            this.panelControl2.TabIndex = 27;
            // 
            // Pictue_imagebox
            // 
            this.Pictue_imagebox.Location = new System.Drawing.Point(63, 5);
            this.Pictue_imagebox.Name = "Pictue_imagebox";
            this.Pictue_imagebox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.Pictue_imagebox.Size = new System.Drawing.Size(123, 96);
            this.Pictue_imagebox.TabIndex = 40;
            // 
            // LoadPictue_btn
            // 
            this.LoadPictue_btn.Location = new System.Drawing.Point(63, 107);
            this.LoadPictue_btn.Name = "LoadPictue_btn";
            this.LoadPictue_btn.Size = new System.Drawing.Size(123, 23);
            this.LoadPictue_btn.TabIndex = 41;
            this.LoadPictue_btn.Text = "Load Pictue";
            this.LoadPictue_btn.Click += new System.EventHandler(this.LoadPictue_btn_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 16);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Picture";
            // 
            // ImgFileDialog
            // 
            this.ImgFileDialog.FileName = "ImgFileDialogOpen";
            // 
            // CategoiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 561);
            this.Controls.Add(this.panelControl1);
            this.Name = "CategoiesForm";
            this.Text = "CategoiesForm";
            this.Load += new System.EventHandler(this.CategoiesForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.CategoyId_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Desciption_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoyName_textbox.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pictue_imagebox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.TextEdit Desciption_textbox;
        private DevExpress.XtraEditors.TextEdit CategoyName_textbox;
        private DevExpress.XtraEditors.LabelControl FirstNamelabel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Save_toolStripButton;
        private System.Windows.Forms.ToolStripButton Edit_toolStripButton;
        private System.Windows.Forms.ToolStripButton Delete_toolStripButton;
        private System.Windows.Forms.ToolStripButton Clear_toolStripButton;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit CategoyId_textbox;
        private DevExpress.XtraEditors.LabelControl EmployeeIDlabel;
        private DevExpress.XtraEditors.PictureEdit Pictue_imagebox;
        private DevExpress.XtraEditors.SimpleButton LoadPictue_btn;
        private System.Windows.Forms.OpenFileDialog ImgFileDialog;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}