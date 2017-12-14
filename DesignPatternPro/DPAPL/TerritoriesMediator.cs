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
    public class TerritoriesMediator
    {
        CRUD<Territories> ObjTerr = new CRUD<Territories>("Territories");
         
        Territories Terr = new Territories();
     
        private TextEdit RegionId_textbox;
        private TextEdit TerritoryId_textbox;
        private TextEdit TerritoryDescription_textbox;
        private ToolStripButton Save_toolStripButton;
        private ToolStripButton Edit_toolStripButton;
        private ToolStripButton Delete_toolStripButton;
        private ToolStripButton Clear_toolStripButton;
        private GridControl gridControl1;
        private GridView gridView1;


        public void Register(TextEdit obj)
        {  

            if (obj.Name == "RegionId_textbox")
            {
                RegionId_textbox = obj;
            }
            else if (obj.Name == "TerritoryId_textbox")
            {
                TerritoryId_textbox = obj;
            }
            else
            {
                TerritoryDescription_textbox = obj;
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
                inserted = ObjTerr.Create(Terr);
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
                inserted = ObjTerr.Update(Terr);
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
                inserted = ObjTerr.Delete(Terr);
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
            string[] Vals = { "TerritoryID", "TerritoryDescription", "RegionID" };

            try
            {
                SIngltonClass.Myinstance.TerritoryId_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[0]));
                SIngltonClass.Myinstance.TerritoryDescription_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[1])); ;
                SIngltonClass.Myinstance.RegionId_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[2]));

            }
            catch (Exception ex)
            {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }


    
        public void LoadData()
        {
            SIngltonClass.Myinstance.gridControl1.DataSource = ObjTerr.GetAll();
            SIngltonClass.Myinstance.gridControl1.DataMember = "Ter";
        }
        private void clear()
        {
            SIngltonClass.Myinstance.TerritoryId_textbox.Text = "";
            SIngltonClass.Myinstance.TerritoryDescription_textbox.Text = "";
            SIngltonClass.Myinstance.RegionId_textbox.Text = "";
        }
        private void SetData()
        {
            Terr.TerritoryID = SIngltonClass.Myinstance.TerritoryId_textbox.Text;
            Terr.TerritoryDescription = SIngltonClass.Myinstance.TerritoryDescription_textbox.Text;
            Terr.RegionID = Convert.ToInt32(SIngltonClass.Myinstance.RegionId_textbox.Text);
        }
       
    }
}
