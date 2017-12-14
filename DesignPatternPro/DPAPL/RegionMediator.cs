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
    public class RegionMediator
    {
        CRUD<MyRegion> ObjRegi = new CRUD<MyRegion>("Region");
        MyRegion _re = new MyRegion();

        private ToolStripButton Save_toolStripButton;
        private ToolStripButton Edit_toolStripButton;
        private ToolStripButton Delete_toolStripButton;
        private ToolStripButton Clear_toolStripButton;
        private TextEdit RegionId_textbox;
        private TextEdit RegionDescription_textbox;
        private GridControl gridControl1;
        private GridView gridView1;

        public void Register(TextEdit obj)
        {

            if (obj.Name == "RegionId_textbox")
            {
               RegionId_textbox = obj;
            }
            else 
            {
                RegionDescription_textbox = obj;
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
                inserted = ObjRegi.Create(_re);
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
                inserted = ObjRegi.Update(_re);
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
                inserted = ObjRegi.Delete(_re);
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
            string[] Vals = { "RegionID", "RegionDescription" };

            try
            {
                RegionId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                RegionDescription_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;

            }
            catch (Exception ex)
            {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }

       
        public void LoadData()
        {
            gridControl1.DataSource = ObjRegi.GetAll();
            gridControl1.DataMember = "reg";
        }
        private void clear()
        {
            RegionId_textbox.Text = "";
            RegionDescription_textbox.Text = "";
        }
        private void SetData()
        {
            _re.RegionID = Convert.ToInt32(RegionId_textbox.Text);
            _re.RegionDescription = RegionDescription_textbox.Text;
        }

    }
}
