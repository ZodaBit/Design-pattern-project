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
    public partial class RegionForm : DevExpress.XtraEditors.XtraForm
    {
        ICrudDAO<MyRegion> ObjRegi = (ICrudDAO<MyRegion>)FactoryProducer.GetDAOIMPObject("Region");
        MyRegion _re = new MyRegion();
        public RegionForm()
        {
            InitializeComponent();
        }
        #region Load Data
        private void LoadData()
        {
            gridControl1.DataSource = ObjRegi.GetAllData();
            gridControl1.DataMember = "reg";
        }
        #endregion
        #region clear filds
        private void clear()
        {
            RegionId_textbox.Text = "";
            RegionDescription_textbox.Text = "";
        }
        #endregion

        #region Set data
        private void SetData()
        {
            _re.RegionID = Convert.ToInt32(RegionId_textbox.Text);
            _re.RegionDescription = RegionDescription_textbox.Text;
        }
        #endregion

        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                SetData();
                inserted =ObjRegi.CreateData(_re);
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
                inserted =ObjRegi.UpdateData(_re);
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
                inserted =ObjRegi.DeleteData(_re);
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

        private void RegionForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}