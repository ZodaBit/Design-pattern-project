using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DPDAL;
using DPDTO;
using Factory;
using DPBBL;

namespace DPAPL
{
    public partial class TerritoriesForm : DevExpress.XtraEditors.XtraForm
    {
        TerritoriesMediator Mediatorr = new TerritoriesMediator();

          
        public TerritoriesForm()
        {
            InitializeComponent();

            Mediatorr.Register(SIngltonClass.Myinstance.RegionId_textbox);
            Mediatorr.Register(SIngltonClass.Myinstance.TerritoryId_textbox);
            Mediatorr.Register(SIngltonClass.Myinstance.TerritoryDescription_textbox);
            Mediatorr.Register(SIngltonClass.Myinstance.Save_toolStripButton);
            Mediatorr.Register(SIngltonClass.Myinstance.Edit_toolStripButton);
            Mediatorr.Register(SIngltonClass.Myinstance.Delete_toolStripButton);
            Mediatorr.Register(SIngltonClass.Myinstance.Clear_toolStripButton);
            Mediatorr.Register(SIngltonClass.Myinstance.gridControl1);
            Mediatorr.Register(SIngltonClass.Myinstance.gridView1);
        }

        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediatorr.saveClick();
        }

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediatorr.Editclick();
        }

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediatorr.Deleteclick();
        }

        private void TerritoriesForm_Load(object sender, EventArgs e)
        {
           Mediatorr.LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Mediatorr.Gridview1Click();
            
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediatorr.ClearClick();
        }

        
    }
}