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
    public class OrderMediator
    {
        CRUD<Order> ObjOrder = new CRUD<Order>("Order");
        Order Ord = new Order();

        private TextEdit ShipAdress_textbox;
        private TextEdit Shipvia_textbox;
        private TextEdit ShipCity_textbox;
        private TextEdit ShipPostalCodee_textbox;
        private TextEdit EmployeeId_textbox;
        private TextEdit CustomerId_textbox;  
        private TextEdit ShipRegion_textbox;
        private TextEdit ShipName_textbox;
        private TextEdit Freight_textbox;
        private TextEdit OrderId_textbox;
        private TextEdit ShipCounty_textbox;
        private DateTimePicker ShippedDate_dateTime;
        private DateTimePicker RequiredDate_datetime;
        private DateTimePicker OrderDate_Datetimepicker;
        private ToolStripButton Save_toolStripButton;
        private ToolStripButton Edit_toolStripButton;
        private ToolStripButton Delete_toolStripButton;
        private ToolStripButton Clear_toolStripButton;
        private GridControl gridControl1;
        private GridView gridView1;



        public void Register(DateTimePicker obj)
        {
            if (obj.Name =="ShippedDate_dateTime")
            {
                ShippedDate_dateTime = obj;
            }
            else if (obj.Name =="RequiredDate_datetime")
            {
                RequiredDate_datetime = obj;
            }
            else
            {
                OrderDate_Datetimepicker = obj;
            }
        }
        public void Register(TextEdit obj)
        {
            if (obj.Name == "ShipAdress_textbox")
            {
                ShipAdress_textbox= obj;
            }
            else if (obj.Name == "Shipvia_textbox")
            {
                Shipvia_textbox = obj;
            }
            else if (obj.Name == "ShipCity_textbox")
            {
                ShipCity_textbox = obj;
            }
            else if (obj.Name == "ShipPostalCodee_textbox")
            {
                ShipPostalCodee_textbox = obj;
            }
            if (obj.Name == "EmployeeId_textbox")
            {
                EmployeeId_textbox = obj;
            }

            else if (obj.Name == "CustomerId_textbox")
            {
                CustomerId_textbox= obj;
            }
            else if (obj.Name == "ShipRegion_textbox")
            {
                ShipRegion_textbox = obj;
            }
            else if (obj.Name == "ShipName_textbox")
            {
                ShipName_textbox = obj;
            }
            else if (obj.Name == "Freight_textbox")
            {
                Freight_textbox = obj;
            }
            else if(obj.Name=="ShipCounty_textbox")
            {
                ShipCounty_textbox=obj;
            }
            else
            {
                OrderId_textbox = obj;
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
            else if (obj.Name =="Clear_toolStripButton")
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

        public void LoadData()
        {
            gridControl1.DataSource = ObjOrder.GetAll();
            gridControl1.DataMember = "ord";

        }
        public void saveClick()
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjOrder.Create(Ord);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Saved Successfully");
                    Clear();
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

        public void Editclick()
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjOrder.Update(Ord);
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

            }
        }
        public void Deleteclick()
        {

            bool deleted;
            try
            {
                SetData();
                deleted = ObjOrder.Delete(Ord);
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
                //MessageBox.Show(ex.ToString());
            }
        }
        public void ClearClick()
        {
            Clear();
        }

        private void Clear()
        {
            CustomerId_textbox.Text = "";
            EmployeeId_textbox.Text = "";
            OrderDate_Datetimepicker.Text = "";
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
            OrderId_textbox.Text = "";
        }

        private void SetData()
        {
            Ord.OrderID = Convert.ToInt32(OrderId_textbox.Text);
            Ord.CustomerID = CustomerId_textbox.Text;
            Ord.EmployeeID = Convert.ToInt32(EmployeeId_textbox.Text);
            Ord.OrderDate = OrderDate_Datetimepicker.Value.Date;
            Ord.RequiredDate = RequiredDate_datetime.Value.Date;
            Ord.ShippedDate = ShippedDate_dateTime.Value.Date;
            Ord.ShipVia = Convert.ToInt32(Shipvia_textbox.Text);
            Ord.Freight = Freight_textbox.Text;
            Ord.ShipName = ShipName_textbox.Text;
            Ord.ShipAddress = ShipAdress_textbox.Text;
            Ord.ShipCity = ShipCity_textbox.Text;
            Ord.ShipRegion = ShipRegion_textbox.Text;
            Ord.ShipPostalCode = ShipPostalCodee_textbox.Text;
            Ord.ShipCountry = ShipCounty_textbox.Text;

        }

        public void Gridview1Click()
        {
            string[] Vals = { "OrderID", "CustomerID", "EmployeeID", "OrderDate", "RequiredDate", "ShippedDate", "ShipVia", "Freight", "ShipName", "ShipAddress", "ShipCity", "ShipRegion", "ShipPostalCode", "ShipCountry" };

            try
            {
                OrderId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                CustomerId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                EmployeeId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));
                OrderDate_Datetimepicker.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[3]));
                RequiredDate_datetime.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[4]));
                ShippedDate_dateTime.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[5]));
                Shipvia_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[6]));
                Freight_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[7]));
                ShipName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[8]));
                ShipAdress_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[9]));
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
