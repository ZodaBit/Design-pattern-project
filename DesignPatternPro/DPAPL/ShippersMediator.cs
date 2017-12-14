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
    class ShippersMediator
    {

        CRUD<Shipper> ObjShipper = new CRUD<Shipper>("Shipper");
        Shipper _Ship = new Shipper();

        private TextEdit Phone_textbox;
        private TextEdit CompanyName_textbox;
        private TextEdit ShipperId_textbox;
        private ToolStripButton Save_toolStripButton;
        private ToolStripButton Edit_toolStripButton;
        private ToolStripButton Delete_toolStripButton;
        private ToolStripButton Clear_toolStripButton;
        private GridControl gridControl1;
        private GridView gridView1;



        public void Register(TextEdit obj)
        {

            if (obj.Name == "Phone_textbox")
            {
                Phone_textbox = obj;
            }
            else if (obj.Name =="CompanyName_textbox")
            {
                CompanyName_textbox = obj;
            }
            else
            {
                ShipperId_textbox = obj;
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
                inserted = ObjShipper.Create(_Ship);
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
                // XtraMessageBox.Show(ex.ToString());
            }
        }
        public void Editclick()
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjShipper.Update(_Ship);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Updated Successfully");
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
                // MessageBox.Show("opps!!! somthing is happning");
            }
        }
        public void Deleteclick()
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjShipper.Delete(_Ship);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Deleted  Successfully");
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
                //MessageBox.Show("opps somthing is going on !!!");
            }
        }
        public void ClearClick()
        {
            clear();
        }
        public void Gridview1Click()
        {
            string[] Vals = { "ShipperID", "CompanyName", "Phone" };

            try
            {
                ShipperId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                CompanyName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                Phone_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));

            }
            catch (Exception ex)
            {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }


        public void LoadData()
        {
            gridControl1.DataSource = ObjShipper.GetAll();
            gridControl1.DataMember = "ship";
        }
        private void clear()
        {
            ShipperId_textbox.Text = "";
            CompanyName_textbox.Text = "";
            Phone_textbox.Text = "";
        }
        private void SetData()
        {
            _Ship.ShipperID = Convert.ToInt32(ShipperId_textbox.Text);
            _Ship.CompanyName = CompanyName_textbox.Text;
            _Ship.Phone = Phone_textbox.Text;
        }

    }
}
