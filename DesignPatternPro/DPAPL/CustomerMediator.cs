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
    
    public class CustomerMediator
    {

        CRUD<Customer> objCust = new CRUD<Customer>("Customer");
        Customer cust = new Customer();

        private TextEdit County_textbox;
        private TextEdit Fax_textbox;
        private TextEdit Phone_textbox;
        private TextEdit Address_textbox;
        private TextEdit City_textbox;
        private TextEdit Region_textbox;
        private TextEdit PostalCode_textbox;
        private TextEdit ContactName_textbox;
        private TextEdit CustomerId_textbox;
        private TextEdit ContactTitle_textbox;
        private TextEdit CompanyName_textbox;
        private ToolStripButton Save_toolStripButton;
        private ToolStripButton Edit_toolStripButton;
        private ToolStripButton Delete_toolStripButton;
        private ToolStripButton Clear_toolStripButton;
        private GridControl gridControl1;
        private GridView gridView1;


        public void Register(TextEdit obj)
        {
            if (obj.Name == "County_textbox")
            {
                County_textbox= obj;
            }
            else if (obj.Name == "Fax_textbox")
            {
                Fax_textbox= obj;
            }
            else if (obj.Name == "Phone_textbox")
            {
                Phone_textbox = obj;
            }
            else if (obj.Name == "Address_textbox")
            {
                Address_textbox = obj;
            }
            if (obj.Name == "City_textbox")
            {
               City_textbox = obj;
            }

            else if (obj.Name == "Region_textbox")
            {
                Region_textbox = obj;
                
            }
            else if (obj.Name == "PostalCode_textbox")
            {
                PostalCode_textbox= obj;
            }
            else if (obj.Name == "ContactName_textbox")
            {
                ContactName_textbox = obj;
            }
            else if (obj.Name == "CustomerId_textbox")
            {
                CustomerId_textbox= obj;
            }
            else if (obj.Name == "ContactTitle_textbox")
            {
                ContactTitle_textbox= obj;
            }
            else
            {
                CompanyName_textbox = obj;
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
            else if (obj.Name == "Clear_toolStripButton")
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
                SetCustomer();
                inserted = objCust.Create(cust);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Saved Successfully");
                    LoadData();
                    clear();

                }
                else
                {
                    XtraMessageBox.Show("Note Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Editclick()
        {
            bool updated;
            try
            {
                SetCustomer();
                updated = objCust.Update(cust);
                if (updated == true)
                {
                    XtraMessageBox.Show("Updated Successfully");
                    LoadData();
                    clear();
                }
                else
                {
                    XtraMessageBox.Show("Note Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Deleteclick()
        {

            bool deleted;
            try
            {
                SetCustomer();
                deleted = objCust.Delete(cust);
                if (deleted == true)
                {
                    XtraMessageBox.Show("Deleted Successfully");
                    LoadData();
                    clear();
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
            clear();
        }

        public void Gridview1Click()
        {
            CustomerId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CustomerID"));
            CompanyName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CompanyName"));
            ContactName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ContactName"));
            ContactTitle_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ContactTitle"));
            Address_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Address"));
            City_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "City"));
            Region_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Region"));
            PostalCode_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PostalCode"));
            County_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Country"));
            Phone_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Phone"));
            Fax_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Fax"));
        }

        #region clear fild method
        private void clear()
        {
            CustomerId_textbox.Text = "";
            CompanyName_textbox.Text = "";
            ContactName_textbox.Text = "";
            ContactTitle_textbox.Text = "";
            Address_textbox.Text = "";
            City_textbox.Text = "";
            Region_textbox.Text = "";
            PostalCode_textbox.Text = "";
            County_textbox.Text = "";
            Phone_textbox.Text = "";
            Fax_textbox.Text = "";
        }
        #endregion
        #region Load data method
        public void LoadData()
        {
            gridControl1.DataSource = objCust.GetAll();
            gridControl1.DataMember = "cust";
        }
        #endregion

        #region Set text box method
        private void SetCustomer()
        {
            cust.CustomerID = CustomerId_textbox.Text;
            cust.CompanyName = CompanyName_textbox.Text;
            cust.ContactName = ContactName_textbox.Text;
            cust.ContactTitle = ContactTitle_textbox.Text;
            cust.Address = Address_textbox.Text;
            cust.City = City_textbox.Text;
            cust.Region = Region_textbox.Text;
            cust.PostalCode = PostalCode_textbox.Text;
            cust.Country = County_textbox.Text;
            cust.Phone = Phone_textbox.Text;
            cust.Fax = Fax_textbox.Text;
        }
        #endregion
       
    }
}
