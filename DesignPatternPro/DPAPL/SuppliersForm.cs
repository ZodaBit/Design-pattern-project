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
using Factory;
using DPBBL;


namespace DPAPL
{
    public partial class SuppliersForm : DevExpress.XtraEditors.XtraForm
    {
        ICrudDAO<Supplier> ObjSup = (ICrudDAO<Supplier>)FactoryProducer.GetDAOIMPObject("Supplier");
        Supplier Sup = new Supplier();
        public SuppliersForm()
        {
            InitializeComponent();
        }

        #region Load Data
        private void LoadData()
        {
            gridControl1.DataSource = ObjSup.GetAllData();
            gridControl1.DataMember = "sup";
        }
        #endregion
        #region clear filds
        private void clear()
        {
            SupplierId_textbox.Text = "" ;
            CompanyName_textbox.Text="";
            ContactName_textbox.Text="";
            ContactTitle_textbox.Text="";
            Address_textbox.Text="";
            City_textbox.Text="";
            Region_textbox.Text="";
            PostalCode_textbox.Text="";
            Country_textbox.Text="";
            Phone_textbox.Text="";
            Fax_textbox.Text="";
            HomePage_textbox.Text="";
        }
        #endregion 

        #region Set filds
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
            Sup.Fax=Fax_textbox.Text;
            Sup.HomePage = HomePage_textbox.Text;
        }
        #endregion 
        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjSup.CreateData(Sup);
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

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjSup.UpdateData(Sup);
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

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
        {
            bool deleted;
            try
            {
                SetData();
                deleted = ObjSup.DeleteData(Sup);
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

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            string[] Vals = { "SupplierID", "CompanyName", "ContactName", "ContactTitle", "Address", "City", "Region", "PostalCode", "Country", "Phone", "Fax", "HomePage" };

            try
            {
                SupplierId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                CompanyName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                ContactName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));
                ContactTitle_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[3]));
                Address_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[4]));
                City_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[5]));
                Region_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[6]));
                PostalCode_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[7]));
                Country_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[8]));
                Phone_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[9]));
                Fax_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[10]));
                HomePage_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[11]));
                

            }
            catch (Exception ex)
            {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        

       
    }
}