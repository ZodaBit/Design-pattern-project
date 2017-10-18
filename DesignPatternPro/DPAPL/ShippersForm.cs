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
    public partial class ShippersForm : DevExpress.XtraEditors.XtraForm
    {

        ICrudDAO<Shipper> ObjShipper = (ICrudDAO<Shipper>)FactoryProducer.GetDAOIMPObject("Shipper");
        Shipper _Ship = new Shipper();
        public ShippersForm()
        {
            InitializeComponent();
        }
        #region Load Data
        private void LoadData()
        {
            gridControl1.DataSource = ObjShipper.GetAllData();
            gridControl1.DataMember = "ship";
        }
        #endregion
        #region clear filds
        private void clear()
        {
            ShipperId_textbox.Text = "";
            CompanyName_textbox.Text = "";
            Phone_textbox.Text = "";
        }
        #endregion
        #region Set data
        private void SetData()
        {
            _Ship.ShipperID = Convert.ToInt32(ShipperId_textbox.Text);
            _Ship.CompanyName = CompanyName_textbox.Text;
            _Ship.Phone = Phone_textbox.Text;
        }
        #endregion
        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjShipper.CreateData(_Ship);
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

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjShipper.UpdateData(_Ship);
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

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjShipper.DeleteData(_Ship);
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

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string[] Vals = { "ShipperID","CompanyName", "Phone" };

            try
            {
                ShipperId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                CompanyName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                Phone_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));

            }
            catch (Exception ex)
            {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }

        private void ShippersForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        

    }
}