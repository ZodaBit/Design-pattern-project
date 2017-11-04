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
        Product pro = new Product();
        CRUD<Product> ObjCrud = new CRUD<Product>("Product");
        
        public ProductsForm()
        {
            InitializeComponent();
        }
        #region Load Data
        private void LoadData()
        {
            gridControl1.DataSource = ObjCrud.GetAll();
            gridControl1.DataMember ="pro";
        }
        #endregion

        #region Clear filds
        private void clear()
        {
            ProductId_textbox.Text = "";
            ProductName_textbox.Text = "";
            SupplierId_textbox.Text = "";
            CatagoryId_textbox.Text = "";
            QuantityPerUnit_textbox.Text = "";
            UnitPrice_textbox.Text = "";
            UnitInStock_textbox.Text = "";
            UnitsOnOrder_textbox.Text = "";
            RecorderLevel_textbox.Text ="";
            Discontinued_Combobox.Text = "";
        }
        #endregion

        #region Set Data
        private void SetData()
        {
           pro.ProductID=Convert.ToInt32(ProductId_textbox.Text);
           pro.ProductName = ProductName_textbox.Text;
            pro.SupplierID=Convert.ToInt32(SupplierId_textbox.Text );
            pro.CategoryID=Convert.ToInt32(CatagoryId_textbox.Text );
            pro.QuantityPerUnit=QuantityPerUnit_textbox.Text ;
            pro.UnitPrice=Convert.ToDecimal(UnitPrice_textbox.Text) ;
            pro.UnitsInStock=Convert.ToInt16(UnitInStock_textbox.Text );
            pro.UnitsOnOrder=Convert.ToInt16(UnitsOnOrder_textbox.Text) ;
            pro.RecorderLevel=Convert.ToInt16(RecorderLevel_textbox.Text) ;
            pro.Discontinued=Discontinued_Combobox.Text ;
        }
        #endregion 
        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjCrud.Create(pro);
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
                XtraMessageBox.Show(ex.ToString());
            }

        }

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjCrud.Update(pro);
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
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void Deleted_toolStripButton_Click(object sender, EventArgs e)
        {
            bool deleted;
            try
            {
                SetData();
                deleted = ObjCrud.Delete(pro);
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string[] Vals = { "ProductID", "ProductName", "SupplierID", "CategoryID", "QuantityPerUnit", "UnitPrice", "UnitsInStock", "UnitsOnOrder", "ReorderLevel", "Discontinued" };
             
            try
            {
                ProductId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                ProductName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                SupplierId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));
                CatagoryId_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[3]));
                QuantityPerUnit_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[4]));
                UnitPrice_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[5]));
                UnitInStock_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[6]));
                UnitsOnOrder_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[7]));
                RecorderLevel_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[8]));
                Discontinued_Combobox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[9]));

            }
            catch (Exception ex)
            {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }

       
    }
}