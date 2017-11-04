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
using DPDTO;
using DPBBL;

namespace DPAPL
{
    public partial class EmployeesForm : DevExpress.XtraEditors.XtraForm
    {

        public EmployeesForm()
        {
            InitializeComponent();
        }

        CRUD<Employee>  ObjEmp  = new CRUD<Employee>("Employee");
        Employee Emp = new Employee();

        #region Load Data
        private void LoadData()
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
            try{
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
             catch(Exception ex)
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
        private void clear()
        {
            EmployeeId_textbox.Text="";
            LastName_textbox.Text="";
            FirstName_textbox.Text="";
            Title_textbox.Text="";
            TitleOfCourtesy_textbox.Text="";
           Address_textbox.Text="";
           City_textbox.Text="";
           Region_textbox.Text="";
           PostalCode_textbox.Text="";
           County_textbox.Text="";
           HomePhone_textbox.Text="";
           Extension_textbox.Text="";
           photo_imagebox.Image=null;
           Note_richTextBox.Text="";
           ReportsTo_text.Text="";
           Photopath_text.Text="";
        }
        #endregion
        private void Save_toolStripButton_Click(object sender, EventArgs e)
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
       
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
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

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
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

        #region Load image from hard disk
        private void photo_imagebox_DoubleClick(object sender, EventArgs e)
        {
            if (ImgFileDialog.ShowDialog() == DialogResult.OK)
            {
                photo_imagebox.Image = Image.FromFile(ImgFileDialog.FileName);
            }
        }
        #endregion

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string[] Vals = { "EmployeeID","LastName","FirstName","Title", "TitleOfCourtesy", "BirthDate", "HireDate","Address","City","Region","PostalCode","Country","HomePhone","Extension","Photo","Notes", "ReportsTo", "PhotoPath" };
            try
            {
                EmployeeId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                LastName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                FirstName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));
                Title_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[3]));
                TitleOfCourtesy_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[4]));
                BirthDate_datepicker.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[5]));
                HireDate_datetimepicker.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[6]));
                Address_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[7]));
                City_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[8]));
                Region_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[9]));
                PostalCode_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[10]));
                County_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[11]));
                HomePhone_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[12]));
                Extension_textbox.Text= Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[13]));
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

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            clear();
        }
       

    }
}