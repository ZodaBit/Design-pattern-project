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
using DPBBL;
using Factory;

namespace DPAPL
{
    public partial class CustomersForm : DevExpress.XtraEditors.XtraForm
    {

       // CustomerDAO objCust =(CustomerDAO) FactoryProducer.getCust("Customer");
        ICrudDAO<Customer> objCust = (ICrudDAO<Customer>)FactoryProducer.GetDAOIMPObject("Customer");
        Customer cust = new Customer();

        public CustomersForm()
        {
            InitializeComponent();
           
        }
        #region clear fild method
        private void clear()
        {
             CustomerId_textbox.Text="";
             CompanyName_textbox.Text="";
            ContactName_textbox.Text="";
            ContactTitle_textbox.Text="";
            Address_textbox.Text="";
            City_textbox.Text="";
            Region_textbox.Text="";
           PostalCode_textbox.Text="";
           County_textbox.Text="";
           Phone_textbox.Text="";
           Fax_textbox.Text="";
        }
        #endregion
        #region Load data method
        private void LoadData()
        {
            gridControl1.DataSource = objCust.GetAllData();
            gridControl1.DataMember = "cust";
        }
        #endregion
        private void CustomersForm_Load(object sender, EventArgs e)
        {

            LoadData(); 

        }
        #region Set text box method
        private void SetCustomer()
        {
            cust.CustomerID=CustomerId_textbox.Text;
            cust.CompanyName=CompanyName_textbox.Text;
            cust.ContactName=ContactName_textbox.Text;
            cust.ContactTitle=ContactTitle_textbox.Text;
            cust.Address=Address_textbox.Text;
            cust.City=City_textbox.Text;
            cust.Region=Region_textbox.Text;
            cust.PostalCode=PostalCode_textbox.Text; 
            cust.Country=County_textbox.Text;
            cust.Phone=Phone_textbox.Text;
            cust.Fax = Fax_textbox.Text;
        }
        #endregion

        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                SetCustomer();
                inserted = objCust.CreateData(cust);
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

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            bool updated;
            try
            {
                SetCustomer();
                updated = objCust.UpdateData(cust);
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

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
        {
            bool deleted;
            try
            {
                SetCustomer();
                deleted = objCust.DeleteData(cust);
                if (deleted== true)
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

       


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
                CustomerId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CustomerID"));
                CompanyName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CompanyName"));
                ContactName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ContactName"));
                ContactTitle_textbox.Text =Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ContactTitle"));
                Address_textbox.Text =Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Address"));
                City_textbox.Text =Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "City"));
                Region_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Region"));
                PostalCode_textbox.Text=Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PostalCode"));
               County_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Country"));
                Phone_textbox.Text =Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Phone"));
                Fax_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Fax"));
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            clear();
        }

       
    }
}