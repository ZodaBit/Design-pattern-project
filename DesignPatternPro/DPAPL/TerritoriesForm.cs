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
    public partial class TerritoriesForm : DevExpress.XtraEditors.XtraForm
    {
        CRUD<Territories> ObjTerr =new CRUD<Territories>("Territories");
        Territories Terr = new Territories();
        public TerritoriesForm()
        {
            InitializeComponent();
        }
        #region LoadData
        private void LoadData()
        {
            gridControl1.DataSource = ObjTerr.GetAll();
            gridControl1.DataMember = "Ter";
        }
        #endregion
        #region Clear filds
        private void clear()
        {
            TerritoryId_textbox.Text = "";
            TerritoryDescription_textbox.Text = "";
            RegionId_textbox.Text = "";
        }
        #endregion
        #region SetData
        private void SetData()
        {
            Terr.TerritoryID = TerritoryId_textbox.Text;
            Terr.TerritoryDescription = TerritoryDescription_textbox.Text;
            Terr.RegionID = Convert.ToInt32(RegionId_textbox.Text);
        }
#endregion
        private void Save_toolStripButton_Click(object sender, EventArgs e)
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

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
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

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
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

        private void TerritoriesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            string[] Vals = { "TerritoryID", "TerritoryDescription", "RegionID" };

            try
            {
                TerritoryId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                TerritoryDescription_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                RegionId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));

            }
            catch (Exception ex)
            {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        
    }
}