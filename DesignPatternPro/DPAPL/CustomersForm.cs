﻿using System;
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
    public partial class CustomersForm : DevExpress.XtraEditors.XtraForm
    {
        CustomerMediator Mediator = new CustomerMediator();

        public CustomersForm()
        {
            InitializeComponent();
           
         Mediator.Register( County_textbox);
         Mediator.Register( Fax_textbox);
         Mediator.Register( Phone_textbox);
         Mediator.Register( Address_textbox);
         Mediator.Register( City_textbox);
         Mediator.Register( Region_textbox);
         Mediator.Register( PostalCode_textbox);
         Mediator.Register( ContactName_textbox);
         Mediator.Register( CustomerId_textbox);
         Mediator.Register( ContactTitle_textbox);
         Mediator.Register( CompanyName_textbox);
         Mediator.Register(Save_toolStripButton);
         Mediator.Register(Edit_toolStripButton);
         Mediator.Register(Delete_toolStripButton);
         Mediator.Register(Clear_toolStripButton);
         Mediator.Register(gridControl1);
         Mediator.Register(gridView1);
           
        }
        
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            Mediator.LoadData();
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

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Mediator.Gridview1Click();
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediator.ClearClick();
        }

       
    }
}