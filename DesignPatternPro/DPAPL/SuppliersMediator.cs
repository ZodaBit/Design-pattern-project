using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DPBBL;
using DPDTO;
using DPDAL;
using DPAPL;

namespace DPAPL
{
    public class SuppliersMediator
    {
        CRUD<Supplier> ObjSup = new CRUD<Supplier>("Supplier");
        Supplier Sup = new Supplier();

       
        private TextEdit Country_textbox;
        private TextEdit HomePage_textbox;
        private TextEdit Phone_textbox;
        private TextEdit Region_textbox;
        private TextEdit PostalCode_textbox;
        private TextEdit Fax_textbox;
        private TextEdit ContactName_textbox;
        private TextEdit ContactTitle_textbox;
        private TextEdit CompanyName_textbox;
        private TextEdit City_textbox;
        private TextEdit Address_textbox;
        private ToolStripButton Save_toolStripButton;
        private ToolStripButton Edit_toolStripButton;
        private ToolStripButton Delete_toolStripButton;
        private ToolStripButton Clear_toolStripButton;
 
        private TextEdit SupplierId_textbox;
        private GridControl gridControl1;
        private GridView gridView1;


        public void Register(TextEdit obj)
        {

            if (obj.Name == "Country_textbox")
            {
                Country_textbox= obj;
            }
            else if (obj.Name == "HomePage_textbox")
            {
                HomePage_textbox = obj;
            }
             else if (obj.Name == "Phone_textbox")
            {
                Phone_textbox = obj;
            }
             else if (obj.Name =="Region_textbox" )
            {
                Region_textbox= obj;
            }
            else if (obj.Name =="PostalCode_textbox" )
            {
                PostalCode_textbox = obj;
            }
            else if (obj.Name =="Fax_textbox" )
            {
                Fax_textbox = obj;
            }
            else if (obj.Name =="ContactName_textbox" )
            {
                ContactName_textbox= obj;
            }
             else if (obj.Name =="ContactTitle_textbox" )
            {
                ContactTitle_textbox = obj;
            }
             else if (obj.Name =="CompanyName_textbox" )
            {
                CompanyName_textbox= obj;
            }
             else if (obj.Name =="City_textbox" )
            {
               City_textbox = obj;
            }
             else if (obj.Name =="Address_textbox" )
            {
                Address_textbox= obj;
            }
            else
            {
                SupplierId_textbox = obj;
             }
        }
        public void Register(ToolStripButton obj)
        {
            if (obj.Name == "Save_toolStripButton")
            {
                Save_toolStripButton = obj;
            }
            else if (obj.Name == "Edit_toolStripButton")
            {
                Edit_toolStripButton = obj;
            }
            else if (obj.Name == "Deleted_toolStripButton")
            {
                Delete_toolStripButton = obj;
            }
            else
            {
                Clear_toolStripButton = obj;
            }

        }
        public void Register(GridControl obj)
        {
            gridControl1 = obj;
        }
        public void Register(GridView obj)
        {
            gridView1 = obj;
        }

        public void saveClick()
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjSup.Create(Sup);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Saved Successfully");
                    clear();
                    LoadData();
                }
                else
                {
                    XtraMessageBox.Show("Note Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show(ex.ToString());
            }
        }
        public void Editclick()
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjSup.Update(Sup);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Update Successfully");
                    clear();
                    LoadData();
                }
                else
                {
                    XtraMessageBox.Show("Note Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show(ex.ToString());
            }
        }
        public void Deleteclick()
        {
            bool deleted;
            try
            {
                SetData();
                deleted = ObjSup.Delete(Sup);
                if (deleted == true)
                {
                    XtraMessageBox.Show("Deleted Successfully");
                    clear();
                    LoadData();
                }
                else
                {
                    XtraMessageBox.Show("Note Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
        }
        public void ClearClick()
        {
            clear();
        }
        public void Gridview1Click()
        {
            string[] Vals = { "SupplierID", "CompanyName", "ContactName", "ContactTitle", "Address", "City", "Region", "PostalCode", "Country", "Phone", "Fax", "HomePage" };

           // try
            //{
                SupplierId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                CompanyName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                ContactName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));
                ContactTitle_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[3]));
                Address_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[4]));
                City_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[5]));
                Region_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[6]));
                PostalCode_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[7]));
                Country_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[8]));
                Phone_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[9]));
                Fax_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[10]));
                HomePage_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[11]));


//            }
  //          catch (Exception ex)
    //        {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
      //      }
        }



        public void LoadData()
        {
            gridControl1.DataSource = ObjSup.GetAll();
            gridControl1.DataMember = "sup";
        }
        private void clear()
        {
            SupplierId_textbox.Text = "";
            CompanyName_textbox.Text = "";
            ContactName_textbox.Text = "";
            ContactTitle_textbox.Text = "";
            Address_textbox.Text = "";
            City_textbox.Text = "";
            Region_textbox.Text = "";
            PostalCode_textbox.Text = "";
            Country_textbox.Text = "";
            Phone_textbox.Text = "";
            Fax_textbox.Text = "";
            HomePage_textbox.Text = "";
        }
        private void SetData()
        {
            Sup.SupplierID = Convert.ToInt32(SupplierId_textbox.Text);
            Sup.CompanyName = CompanyName_textbox.Text;
            Sup.ContactName = ContactName_textbox.Text;
            Sup.ContactTitle = ContactTitle_textbox.Text;
            Sup.Address = Address_textbox.Text;
            Sup.City = City_textbox.Text;
            Sup.Region = Region_textbox.Text;
            Sup.PostalCode = PostalCode_textbox.Text;
            Sup.Country = Country_textbox.Text;
            Sup.Phone = Phone_textbox.Text;
            Sup.Fax = Fax_textbox.Text;
            Sup.HomePage = HomePage_textbox.Text;
        }
    }
}
