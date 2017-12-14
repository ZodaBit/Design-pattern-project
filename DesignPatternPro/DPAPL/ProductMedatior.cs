using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class ProductMedatior
    {
        Product pro = new Product();
        CRUD<Product> ObjCrud = new CRUD<Product>("Product");

        private ToolStripButton Obj_Save_toolStripButton;
        private ToolStripButton Obj_Edit_toolStripButton;
        private ToolStripButton Obj_Deleted_toolStripButton;
        private ToolStripButton Obj_Clear_toolStripButton;
        private GridControl Obj_gridControl1;
        private GridView Obj_gridView1;
        private TextEdit Obj_UnitPrice_textbox;
        private TextEdit Obj_QuantityPerUnit_textbox;
        private TextEdit Obj_RecorderLevel_textbox;
        private TextEdit Obj_UnitsOnOrder_textbox;
        private TextEdit Obj_UnitInStock_textbox;
        private TextEdit Obj_CatagoryId_textbox;
        private TextEdit Obj_SupplierId_textbox;
        private TextEdit Obj_ProductName_textbox;
        private TextEdit Obj_ProductId_textbox;
        private ComboBoxEdit Obj_Discontinued_Combobox;

        public void Register(ComboBoxEdit obj)
        {
            Obj_Discontinued_Combobox = obj;
        }
        public void Register(TextEdit obj)
        {
            if (obj.Name == "UnitPrice_textbox")
            {
                Obj_UnitPrice_textbox = obj;
            }
            else if (obj.Name == "QuantityPerUnit_textbox")
            {
                Obj_QuantityPerUnit_textbox = obj;
            }
            else if (obj.Name == "RecorderLevel_textbox")
            {
                Obj_RecorderLevel_textbox = obj;
            }
            else if (obj.Name == "UnitsOnOrder_textbox")
            {
                Obj_UnitsOnOrder_textbox = obj;
            }
            if (obj.Name == "UnitInStock_textbox")
            {
                Obj_UnitInStock_textbox = obj;
            }

            else if (obj.Name == "CatagoryId_textbox")
            {
                Obj_CatagoryId_textbox = obj;
            }
            else if (obj.Name=="SupplierId_textbox")
           {
            Obj_SupplierId_textbox = obj;
           }
            else if (obj.Name == "ProductName_textbox")
            {
                Obj_ProductName_textbox = obj;
            }
            else
            {
                Obj_ProductId_textbox = obj;
            }
        }

        public void Register(ToolStripButton obj)
        {
            if (obj.Name == "Save_toolStripButton")
            {
               Obj_Save_toolStripButton = obj;
            }
            else if (obj.Name =="Edit_toolStripButton")
            {
                Obj_Edit_toolStripButton = obj;
            }
            else if (obj.Name =="Deleted_toolStripButton")
            {
                Obj_Deleted_toolStripButton = obj;
            }
            else {
            Obj_Clear_toolStripButton=obj;}
            
        }
        public void Register(GridControl obj)
        {
            Obj_gridControl1 = obj;
        }
        public void Register(GridView obj)
        {
            Obj_gridView1 = obj;
        }

        public void LoadData()
        {
            Obj_gridControl1.DataSource = ObjCrud.GetAll();
            Obj_gridControl1.DataMember= "pro";
            
        }
        public void saveClick()
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjCrud.Create(pro);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Saved Successfully");
                   // Clear();
                    LoadData();
                }
                else
                {
                    XtraMessageBox.Show("Note Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        public void Editclick()
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjCrud.Update(pro);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Update Successfully");
                    Clear();
                    LoadData();
                }
                else
                {
                    XtraMessageBox.Show("Note Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }
        public void Deleteclick()
        {

            bool deleted;
            try
            {
                SetData();
                deleted = ObjCrud.Delete(pro);
                if (deleted == true)
                {
                    XtraMessageBox.Show("Deleted Successfully");
                    Clear();
                    LoadData();
                }
                else
                {
                    XtraMessageBox.Show("Note Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ClearClick()
        {
            Clear();
        }

        public void Clear()
        {
            Obj_ProductId_textbox.Text = " ";
            Obj_ProductName_textbox.Text = "";
            Obj_SupplierId_textbox.Text = "";
            Obj_CatagoryId_textbox.Text = "";
            Obj_QuantityPerUnit_textbox.Text = "";
            Obj_UnitPrice_textbox.Text = "";
            Obj_UnitInStock_textbox.Text = "";
            Obj_UnitsOnOrder_textbox.Text = "";
            Obj_RecorderLevel_textbox.Text = "";
            Obj_Discontinued_Combobox.Text = "";
        }

        private void SetData()
        {
            pro.ProductID = Convert.ToInt32(Obj_ProductId_textbox.Text);
            pro.ProductName = Obj_ProductName_textbox.Text;
            pro.SupplierID = Convert.ToInt32(Obj_SupplierId_textbox.Text);
            pro.CategoryID = Convert.ToInt32(Obj_CatagoryId_textbox.Text);
            pro.QuantityPerUnit = Obj_QuantityPerUnit_textbox.Text;
            pro.UnitPrice = Convert.ToDecimal(Obj_UnitPrice_textbox.Text);
            pro.UnitsInStock = Convert.ToInt16(Obj_UnitInStock_textbox.Text);
            pro.UnitsOnOrder = Convert.ToInt16(Obj_UnitsOnOrder_textbox.Text);
            pro.RecorderLevel = Convert.ToInt16(Obj_RecorderLevel_textbox.Text);
            pro.Discontinued = Obj_Discontinued_Combobox.Text;
        }

        public void Gridview1Click()
        {
            string[] Vals = { "ProductID", "ProductName", "SupplierID", "CategoryID", "QuantityPerUnit", "UnitPrice", "UnitsInStock", "UnitsOnOrder", "ReorderLevel", "Discontinued" };

            try
            {
                Obj_ProductId_textbox.Text = Convert.ToString(Obj_gridView1.GetRowCellValue(Obj_gridView1.FocusedRowHandle, Vals[0]));
                Obj_ProductName_textbox.Text = Convert.ToString(Obj_gridView1.GetRowCellValue(Obj_gridView1.FocusedRowHandle, Vals[1])); ;
                Obj_SupplierId_textbox.Text = Convert.ToString(Obj_gridView1.GetRowCellValue(Obj_gridView1.FocusedRowHandle, Vals[2]));
                Obj_CatagoryId_textbox.Text = Convert.ToString(Obj_gridView1.GetRowCellValue(Obj_gridView1.FocusedRowHandle, Vals[3]));
                Obj_QuantityPerUnit_textbox.Text = Convert.ToString(Obj_gridView1.GetRowCellValue(Obj_gridView1.FocusedRowHandle, Vals[4]));
                Obj_UnitPrice_textbox.Text = Convert.ToString(Obj_gridView1.GetRowCellValue(Obj_gridView1.FocusedRowHandle, Vals[5]));
                Obj_UnitInStock_textbox.Text = Convert.ToString(Obj_gridView1.GetRowCellValue(Obj_gridView1.FocusedRowHandle, Vals[6]));
                Obj_UnitsOnOrder_textbox.Text = Convert.ToString(Obj_gridView1.GetRowCellValue(Obj_gridView1.FocusedRowHandle, Vals[7]));
                Obj_RecorderLevel_textbox.Text = Convert.ToString(Obj_gridView1.GetRowCellValue(Obj_gridView1.FocusedRowHandle, Vals[8]));
                Obj_Discontinued_Combobox.Text = Convert.ToString(Obj_gridView1.GetRowCellValue(Obj_gridView1.FocusedRowHandle, Vals[9]));
                
            }
            catch (Exception ex)
            {
                //store exeption and display 
                XtraMessageBox.Show(ex.ToString());
            }
        }

    }
}
