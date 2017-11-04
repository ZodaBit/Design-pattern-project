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
using Factory;
using DPBBL;

namespace DPAPL
{
    public partial class OrdersForm : DevExpress.XtraEditors.XtraForm
    {

        CRUD<Order> ObjOrder = new CRUD<Order>("Order");
        Order Ord= new Order();
        public OrdersForm()
        {
            InitializeComponent();
        }
        #region LoadData
        private void LoadData()
        {
            gridControl1.DataSource = ObjOrder.GetAll();
            gridControl1.DataMember = "ord";
        }
        #endregion
        #region Clear
        private void clear()
        {
            CustomerId_textbox.Text = "";
            EmployeeId_textbox.Text = "";
            OrderDate_Datetimepicker.Text ="";
            RequiredDate_datetime.Text = "";
            ShippedDate_dateTime.Text = "";
            Shipvia_textbox.Text = "";
            Freight_textbox.Text = "";
            ShipName_textbox.Text = "";
            ShipAdress_textbox.Text = "";
            ShipCity_textbox.Text = "";
            ShipRegion_textbox.Text = "";
            ShipPostalCodee_textbox.Text = "";
            ShipCounty_textbox.Text = "";
            OrderId_textbox.Text="";
        }
        #endregion
        #region Set Data
        private void SetData()
        {   
            Ord.OrderID=Convert.ToInt32(OrderId_textbox.Text );
            Ord.CustomerID=CustomerId_textbox.Text;
            Ord.EmployeeID = Convert.ToInt32(EmployeeId_textbox.Text);
            Ord.OrderDate=OrderDate_Datetimepicker.Value.Date;
            Ord.RequiredDate=RequiredDate_datetime.Value.Date ;
            Ord.ShippedDate=ShippedDate_dateTime.Value.Date ;
            Ord.ShipVia=Convert.ToInt32(Shipvia_textbox.Text) ;
            Ord.Freight=Freight_textbox.Text ;
            Ord.ShipName=ShipName_textbox.Text ;
            Ord.ShipAddress=ShipAdress_textbox.Text ;
            Ord.ShipCity=ShipCity_textbox.Text ;
            Ord.ShipRegion=ShipRegion_textbox.Text ;
            Ord.ShipPostalCode=ShipPostalCodee_textbox.Text ;
            Ord.ShipCountry=ShipCounty_textbox.Text ;
            
        }
        #endregion
        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {

            bool inserted;
            try
            {
                SetData();
                inserted = ObjOrder.Create(Ord);
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
                
            }
        }

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjOrder.Update(Ord);
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
                
            }
        }

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
        {
            bool deleted;
            try
            {
                SetData();
                deleted = ObjOrder.Delete(Ord);
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
                //MessageBox.Show(ex.ToString());
            }
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string[] Vals = { "OrderID", "CustomerID", "EmployeeID", "OrderDate", "RequiredDate", "ShippedDate", "ShipVia", "Freight", "ShipName", "ShipAddress", "ShipCity", "ShipRegion", "ShipPostalCode", "ShipCountry" };
           
            try
            {
                OrderId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                CustomerId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                EmployeeId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));
                OrderDate_Datetimepicker.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[3]));
                RequiredDate_datetime.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[4]));
                ShippedDate_dateTime.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[5]));
                Shipvia_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[6]));
                Freight_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[7]));
                ShipName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[8]));
                ShipAdress_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[9]));
                ShipCity_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[10]));
                ShipRegion_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[11]));
                ShipPostalCodee_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[12]));
                ShipCounty_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[13]));
               
            }
            catch (Exception ex)
            {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }
    }
}