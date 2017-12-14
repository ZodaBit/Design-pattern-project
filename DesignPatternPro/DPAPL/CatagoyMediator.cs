using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
    public class CatagoyMediator
    {
        Category cat = new Category();
        CRUD<Category> CatObj = new CRUD<Category>("Category");
        
        private TextEdit Desciption_textbox;
        private TextEdit CategoyName_textbox;
        private TextEdit CategoyId_textbox;
        private ToolStripButton Save_toolStripButton;
        private ToolStripButton Edit_toolStripButton;
        private ToolStripButton Delete_toolStripButton;
        private ToolStripButton Clear_toolStripButton;
        private SimpleButton LoadPictue_btn;
        private PictureEdit Pictue_imagebox;
        private OpenFileDialog ImgFileDialog;
        private GridControl gridControl1;
        private GridView gridView1;


        public void Register(PictureEdit obj)
        {
            Pictue_imagebox = obj;
        }
        public void Register(OpenFileDialog obj)
        {
            ImgFileDialog = obj;
        }
        public void Register(TextEdit obj)
        {

            if (obj.Name == "Desciption_textbox")
            {
                Desciption_textbox= obj;
            }
            else if (obj.Name == "CategoyName_textbox")
            {
                CategoyName_textbox = obj;
            }
            else 
            {
                CategoyId_textbox= obj;
            }
            
        }
        public void Register(SimpleButton obj)
        {
            LoadPictue_btn = obj;
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
            else
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
                Setdata();
                inserted = CatObj.Create(cat);
                if (inserted == true)
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
        public void Editclick()
        {
            bool inserted;
            try
            {
                Setdata();
                inserted = CatObj.Update(cat);
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
        public void Deleteclick()
        {

            bool inserted;
            try
            {
                Setdata();
                inserted = CatObj.Delete(cat);
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
        public void ClearClick()
        {
            Clear();
        }
        public void ImageClick()
        {
            if (ImgFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pictue_imagebox.Image = Image.FromFile(ImgFileDialog.FileName);
            }
        }
        public void Gridview1Click()
        {
            try
            {
                CategoyId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CategoryID"));
                CategoyName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CategoryName"));
                Desciption_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Description"));
                Pictue_imagebox.Image = Convert_byte_to_Image((byte[])gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Picture")); 
            }
            catch (Exception ex)
            {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }


        public void Loadform()
        {
            gridControl1.DataSource = CatObj.GetAll();
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
        private void Clear()
        {
            CategoyId_textbox.Text = "";
            CategoyName_textbox.Text = "";
            Pictue_imagebox.Image = null;
            Desciption_textbox.Text = "";
        }
        public byte[] ConvertImageToBytes(Image InputImage)
        {
            Bitmap bmpimg = new Bitmap(InputImage);
            MemoryStream ms = new MemoryStream();

            bmpimg.Save(ms, ImageFormat.Jpeg);
            byte[] ImgAsBytes = ms.ToArray();

            return ImgAsBytes;

        }
        public Image Convert_byte_to_Image(byte[] inputbyte)
        {
            try
            {
                MemoryStream ms = new MemoryStream(inputbyte);
                return Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Parameter is not valid"))
                {
                    MemoryStream ms = new MemoryStream(inputbyte);
                    ms.Write(inputbyte, 78, inputbyte.Length - 78);
                    return (Bitmap)Image.FromStream(ms);
                }
            }
            return null;
        }
    }
}
