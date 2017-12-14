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
    public class EmployeesMediator
    {
        CRUD<Employee> ObjEmp = new CRUD<Employee>("Employee");
        Employee Emp = new Employee();
        
        private ToolStripButton Save_toolStripButton;
        private ToolStripButton Edit_toolStripButton;
        private ToolStripButton Delete_toolStripButton;
        private ToolStripButton Clear_toolStripButton;
        private TextEdit EmployeeId_textbox;
        private TextEdit Region_textbox;
        private TextEdit ReportsTo_text;
        private TextEdit Title_textbox;
        private RichTextBox Note_richTextBox;
        private PictureEdit photo_imagebox;
        private TextEdit City_textbox;
        private TextEdit PostalCode_textbox;
        private TextEdit HomePhone_textbox;
        private TextEdit Extension_textbox;
        private TextEdit LastName_textbox;
        private TextEdit FirstName_textbox;
        private TextEdit Address_textbox;
        private DateTimePicker HireDate_datetimepicker;
        private DateTimePicker BirthDate_datepicker;
        private TextEdit TitleOfCourtesy_textbox;
        private TextEdit County_textbox;
        private OpenFileDialog ImgFileDialog;
        private TextEdit Photopath_text;
        private GridControl gridControl1;
        private GridView gridView1;

        public void Register(PictureEdit obj)
        {
            photo_imagebox = obj;
        }
        public void Register(OpenFileDialog obj)
        {
            ImgFileDialog = obj;
        }
        public void Register(RichTextBox obj)
        {
            Note_richTextBox = obj;
        }
        public void Register(DateTimePicker obj)
        {
            if (obj.Name == "HireDate_datetimepicker")
            {
                HireDate_datetimepicker = obj;
            }
            else
            {
                BirthDate_datepicker = obj;
            }
        }
        public void Register(TextEdit obj)
        {
         
            if (obj.Name == "EmployeeId_textbox")
            {
               EmployeeId_textbox = obj;
            }
            else if (obj.Name == "Region_textbox")
            {
                Region_textbox = obj;
            }
            else if (obj.Name == "ReportsTo_text")
            {
               ReportsTo_text = obj;
            }
            else if (obj.Name == "Title_textbox")
            {
                Title_textbox = obj;
            }
      
            if (obj.Name == "City_textbox")
            {
                City_textbox = obj;
            }

            else if (obj.Name == "PostalCode_textbox")
            {
                PostalCode_textbox= obj;
            }
            else if (obj.Name == "HomePhone_textbox")
            {
                HomePhone_textbox= obj;
            }
            else if (obj.Name == "Extension_textbox")
            {
                Extension_textbox = obj;
            }
            else if(obj.Name=="LastName_textbox")
             {
                 LastName_textbox = obj;
             }
        else if (obj.Name == "FirstName_textbox")
            {
                FirstName_textbox = obj;
            }
            else if(obj.Name=="Address_textbox")
            {
                Address_textbox = obj;
            }
            else if(obj.Name=="TitleOfCourtesy_textbox")
            {
                TitleOfCourtesy_textbox = obj;
            }
            else if(obj.Name=="County_textbox")
            {
                County_textbox = obj;
            }
            else 
            {
                Photopath_text = obj;
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
                SetData();
                inserted = ObjEmp.Create(Emp);
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
                MessageBox.Show(ex.ToString());
            }
        }
        public void Editclick()
        {
            bool inserted;
            try
            {
                SetData();
                inserted = ObjEmp.Update(Emp);
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
                MessageBox.Show(ex.ToString());
            }
        }
        public void Deleteclick()
        {

            bool inserted;
            try
            {
                SetData();
                inserted = ObjEmp.Delete(Emp);
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
                //XtraMessageBox.Show(ex.ToString());
            }
        }
        public void ClearClick()
        {
            clear();
        }
        public void ImageClick()
        {
            if (ImgFileDialog.ShowDialog() == DialogResult.OK)
            {
                photo_imagebox.Image = Image.FromFile(ImgFileDialog.FileName);
            }
        }
        public void Gridview1Click()
        {
            string[] Vals = { "EmployeeID", "LastName", "FirstName", "Title", "TitleOfCourtesy", "BirthDate", "HireDate", "Address", "City", "Region", "PostalCode", "Country", "HomePhone", "Extension", "Photo", "Notes", "ReportsTo", "PhotoPath" };
            try
            {
                EmployeeId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                LastName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                FirstName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));
                Title_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[3]));
                TitleOfCourtesy_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[4]));
                BirthDate_datepicker.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[5]));
                HireDate_datetimepicker.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[6]));
                Address_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[7]));
                City_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[8]));
                Region_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[9]));
                PostalCode_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[10]));
                County_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[11]));
                HomePhone_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[12]));
                Extension_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[13]));
                photo_imagebox.Image = Convert_byte_to_Image((byte[])gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[14]));
                Note_richTextBox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[15]));
                ReportsTo_text.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[16]));
                Photopath_text.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[17]));
            }
            catch (Exception ex)
            {
                //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }



        #region Load Data
        public void LoadData()
        {

            gridControl1.DataSource = ObjEmp.GetAll();
            gridControl1.DataMember = "Emp";
        }
        #endregion
        #region Set data
        private void SetData()
        {
            Emp.EmployeeID = Convert.ToInt32(EmployeeId_textbox.Text);
            Emp.LastName = LastName_textbox.Text;
            Emp.FirstName = FirstName_textbox.Text;
            Emp.Title = Title_textbox.Text;
            Emp.TitleofCourtesy = TitleOfCourtesy_textbox.Text;
            Emp.BirthDate = BirthDate_datepicker.Value.Date;
            Emp.HirreDate = HireDate_datetimepicker.Value.Date;
            Emp.Address = Address_textbox.Text;
            Emp.City = City_textbox.Text;
            Emp.Region = Region_textbox.Text;
            Emp.PostalCode = PostalCode_textbox.Text;
            Emp.Country = County_textbox.Text;
            Emp.HomePhone = HomePhone_textbox.Text;
            Emp.Extension = Extension_textbox.Text;
            Emp.Notes = Note_richTextBox.Text;
            Emp.ReporstTo = Convert.ToInt16(ReportsTo_text.Text);

            Emp.PhotoPath = Photopath_text.Text;
            try
            {
                Emp.Photo = ConvertImageToBytes(photo_imagebox.Image);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Object reference not set to an instance of an object"))
                {
                    Emp.Photo = null;
                }

            }

        }
        #endregion
        #region Convert Image to Bytem Method
        public byte[] ConvertImageToBytes(Image InputImage)
        {
            Bitmap bmpimg = new Bitmap(InputImage);
            MemoryStream ms = new MemoryStream();

            bmpimg.Save(ms, ImageFormat.Jpeg);
            byte[] ImgAsBytes = ms.ToArray();

            return ImgAsBytes;

        }
        #endregion
        #region convert byte to image
        public Image Convert_byte_to_Image(byte[] inputbyte)
        {
            try
            {

                MemoryStream ms = new MemoryStream(inputbyte);
                return (Bitmap)Image.FromStream(ms);

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
        #endregion
        #region Clear
        public void clear()
        {
            EmployeeId_textbox.Text = "";
            LastName_textbox.Text = "";
            FirstName_textbox.Text = "";
            Title_textbox.Text = "";
            TitleOfCourtesy_textbox.Text = "";
            Address_textbox.Text = "";
            City_textbox.Text = "";
            Region_textbox.Text = "";
            PostalCode_textbox.Text = "";
            County_textbox.Text = "";
            HomePhone_textbox.Text = "";
            Extension_textbox.Text = "";
            photo_imagebox.Image = null;
            Note_richTextBox.Text = "";
            ReportsTo_text.Text = "";
            Photopath_text.Text = "";
        }
        #endregion

    }
}
