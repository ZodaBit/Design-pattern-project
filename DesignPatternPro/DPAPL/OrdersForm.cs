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
    public partial class OrdersForm : DevExpress.XtraEditors.XtraForm
    {
      
        OrderMediator mediator = new OrderMediator();

        public OrdersForm()
        {
            InitializeComponent();
            mediator.Register(ShipAdress_textbox);
            mediator.Register(Shipvia_textbox);
            mediator.Register(ShipCity_textbox);
            mediator.Register(ShipPostalCodee_textbox);
            mediator.Register(EmployeeId_textbox);
            mediator.Register(CustomerId_textbox);
            mediator.Register(ShipRegion_textbox);
            mediator.Register(ShipName_textbox);
            mediator.Register(Freight_textbox);
            mediator.Register(OrderId_textbox);
            mediator.Register(ShipCounty_textbox);
            mediator.Register(ShippedDate_dateTime);
            mediator.Register(RequiredDate_datetime);
            mediator.Register(OrderDate_Datetimepicker);
            mediator.Register(Save_toolStripButton);
            mediator.Register(Edit_toolStripButton);
            mediator.Register(Delete_toolStripButton);
            mediator.Register(Clear_toolStripButton);
            mediator.Register(gridControl1);
            mediator.Register(gridView1);
        }
        
        
        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            mediator.saveClick();
          
        }

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            mediator.Editclick();
        }

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
        {
            mediator.Deleteclick();
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            mediator.ClearClick();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            mediator.LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            mediator.Gridview1Click();  
        }
    }
}