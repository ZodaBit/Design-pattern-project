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
    public partial class EmployeesForm : DevExpress.XtraEditors.XtraForm
    {
        EmployeesMediator Mediator = new EmployeesMediator();
        public EmployeesForm()
        {
            InitializeComponent();
            
        Mediator.Register( Save_toolStripButton);
        Mediator.Register( Edit_toolStripButton);
        Mediator.Register( Delete_toolStripButton);
        Mediator.Register( Clear_toolStripButton);
        Mediator.Register( EmployeeId_textbox);
        Mediator.Register( Region_textbox);
        Mediator.Register( ReportsTo_text);
        Mediator.Register( Title_textbox);
        Mediator.Register( Note_richTextBox);
        Mediator.Register( photo_imagebox);
        Mediator.Register( City_textbox);
        Mediator.Register( PostalCode_textbox);
        Mediator.Register( HomePhone_textbox);
        Mediator.Register( Extension_textbox);
        Mediator.Register( LastName_textbox);
        Mediator.Register( FirstName_textbox);
        Mediator.Register( Address_textbox);
        Mediator.Register( HireDate_datetimepicker);
        Mediator.Register( BirthDate_datepicker);
        Mediator.Register( TitleOfCourtesy_textbox);
        Mediator.Register( County_textbox);
        Mediator.Register( ImgFileDialog);
        Mediator.Register( Photopath_text);
        Mediator.Register( gridControl1);
        Mediator.Register( gridView1);

        }

        

       
        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediator.saveClick();
        }
       
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            try
            {
              Mediator.LoadData();
            }
            catch (Exception ex)
            {
            }
        }

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediator.Editclick();
        }

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediator.Deleteclick();  
        }

        private void photo_imagebox_DoubleClick(object sender, EventArgs e)
        {
            Mediator.ImageClick();   
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Mediator.Gridview1Click();
          
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            Mediator.clear();
        }
       

    }
}