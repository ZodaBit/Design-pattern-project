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
using DPBBL;
using Factory;
namespace DPAPL
{
    public partial class ProductsForm : DevExpress.XtraEditors.XtraForm
    {
        private ProductMedatior objMediator = new ProductMedatior();
        
        public ProductsForm()
        {
            InitializeComponent();
            objMediator.Register(Save_toolStripButton);
            objMediator.Register(Clear_toolStripButton);
            objMediator.Register(Edit_toolStripButton);
            objMediator.Register(Deleted_toolStripButton);
            objMediator.Register(gridControl1);
            objMediator.Register(gridView1);
           objMediator.Register(UnitPrice_textbox);
            objMediator.Register(QuantityPerUnit_textbox);
            objMediator.Register(RecorderLevel_textbox);
            objMediator.Register(UnitsOnOrder_textbox);
            objMediator.Register(UnitInStock_textbox);
            objMediator.Register(CatagoryId_textbox);
            objMediator.Register(SupplierId_textbox);
            objMediator.Register(ProductName_textbox);
            objMediator.Register(ProductId_textbox);
            objMediator.Register(Discontinued_Combobox);
        }
       
        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            objMediator.saveClick();

        }

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            objMediator.Editclick();
        }

        private void Deleted_toolStripButton_Click(object sender, EventArgs e)
        {
            objMediator.Deleteclick();
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            objMediator.ClearClick();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            objMediator.LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            objMediator.Gridview1Click();
        }

       
    }
}