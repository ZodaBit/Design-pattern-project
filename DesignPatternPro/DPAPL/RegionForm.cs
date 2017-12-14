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
    public partial class RegionForm : DevExpress.XtraEditors.XtraForm
    {
        RegionMediator Mediator = new RegionMediator();  
        public RegionForm()
        {
            InitializeComponent();
            
        Mediator.Register( Save_toolStripButton);
        Mediator.Register( Edit_toolStripButton);
        Mediator.Register( Delete_toolStripButton);
        Mediator.Register( Clear_toolStripButton);
        Mediator.Register( RegionId_textbox);
        Mediator.Register( RegionDescription_textbox);
        Mediator.Register( gridControl1);
        Mediator.Register(gridView1);
        }
       

        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediator.saveClick();
        }

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediator.Editclick();
        }

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediator.Deleteclick();
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediator.ClearClick();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Mediator.Gridview1Click();
        }

        private void RegionForm_Load(object sender, EventArgs e)
        {
            Mediator.LoadData();
        }
    }
}