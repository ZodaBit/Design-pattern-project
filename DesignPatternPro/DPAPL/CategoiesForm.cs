using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DPDAL;
using Factory;
using DPBBL;

namespace DPAPL
{
    public partial class CategoiesForm : DevExpress.XtraEditors.XtraForm
    {

        CategoryDAOIMP CatObj = (CategoryDAOIMP)FactoryProducer.GetDAOIMPObject("Category");
        Category cat = new Category();
        
        public CategoiesForm()
        {
            InitializeComponent();
        }
        private void Loadform()
        {
            gridControl1.DataSource = CatObj.GetAllData();
            gridControl1.DataMember = "allcat";
        }
        public void Setdata()
        {
            cat.CategoryID = Convert.ToInt32(CategoyId_textbox.Text);
            cat.CategoryName = CategoyName_textbox.Text;
            cat.Description = Desciption_textbox.Text;
            try
            {
                cat.Picture = ConvertImageToBytes(Pictue_imagebox.Image);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Object reference not set to an instance of an object"))
                {
                    cat.Picture = null;
                }

            }
        }
        // byte to image
        
        #region Convert Image To bytes 
        public byte[] ConvertImageToBytes(Image InputImage)
        {
            Bitmap bmpimg = new Bitmap(InputImage);
            MemoryStream ms = new MemoryStream();

            bmpimg.Save(ms, ImageFormat.Jpeg);
            byte[] ImgAsBytes = ms.ToArray();

            return ImgAsBytes;

        }
        #endregion
        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                Setdata();
                inserted = CatObj.CreateData(cat);
                if(inserted==true)
                {
                    XtraMessageBox.Show("Saved Successfully");
                    Loadform();
                    Clear();
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
                Setdata();
                inserted = CatObj.UpdateData(cat);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Updated Successfully");
                    Loadform();
                    Clear();
                }
                else
                {
                    XtraMessageBox.Show("Note Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("opps!!! somthing is happning");
            }
        }

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                Setdata();
                inserted = CatObj.DeleteData(cat);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Deleted  Successfully");
                    Loadform();
                    Clear();
                }
                else
                {
                    XtraMessageBox.Show("Note Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }


        #region  load picture from hardrive
        private void LoadPictue_btn_Click(object sender, EventArgs e)
        {
            if (ImgFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pictue_imagebox.Image= Image.FromFile(ImgFileDialog.FileName);
            }
        }
        #endregion
        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            Clear(); 
        }
        #region Clear filds
        private void Clear()
        {
            CategoyId_textbox.Text = "";
            CategoyName_textbox.Text = "";
            Pictue_imagebox.Image = null;
            Desciption_textbox.Text = "";
        }
        #endregion

        private void CategoiesForm_Load(object sender, EventArgs e)
        {
            Loadform();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            CategoyId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CategoryID"));
            CategoyName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CategoryName"));
            Desciption_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Description"));
            Pictue_imagebox.Image= Convert_byte_to_Image((byte[])gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Picture"));
           
        }
        #region convert byte to image
        public Image Convert_byte_to_Image(byte[] inputbyte)
        {
            try
            {
                MemoryStream ms = new MemoryStream(inputbyte);
                return Image.FromStream(ms);
            }catch(Exception ex){
                if (ex.Message.Contains("Parameter is not valid"))
                {
                    MemoryStream ms = new MemoryStream(inputbyte);
                    ms.Write(inputbyte, 78, inputbyte.Length - 78);
                    return (Bitmap)Image.FromStream(ms);
                }
            }
            return null;
        }
        #endregion
    }
}