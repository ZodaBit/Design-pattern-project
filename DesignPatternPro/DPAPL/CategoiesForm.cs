using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DPDAL;
using Factory;
using DPDTO;
using DPBBL;

namespace DPAPL
{
    public partial class CategoiesForm : DevExpress.XtraEditors.XtraForm
    {

        CatagoyMediator Mediator = new CatagoyMediator();
           
        
        public CategoiesForm()
        {
            InitializeComponent();
            
        Mediator.Register(Desciption_textbox);
        Mediator.Register(CategoyName_textbox);
        Mediator.Register(CategoyId_textbox);
        Mediator.Register( Save_toolStripButton);
        Mediator.Register( Edit_toolStripButton);
        Mediator.Register( Delete_toolStripButton);
        Mediator.Register( Clear_toolStripButton);
        Mediator.Register( LoadPictue_btn);
        Mediator.Register( Pictue_imagebox);
        Mediator.Register( ImgFileDialog);
        Mediator.Register( gridControl1);
        Mediator.Register( gridView1);
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

        private void LoadPictue_btn_Click(object sender, EventArgs e)
        {
            Mediator.ImageClick();
        }
        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediator.ClearClick();
        }
        

        private void CategoiesForm_Load(object sender, EventArgs e)
        {
            Mediator.Loadform();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Mediator.Gridview1Click();
            
           
        }
       
    }
}