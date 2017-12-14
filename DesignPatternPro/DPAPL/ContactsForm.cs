using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
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
    public partial class ContactsForm : DevExpress.XtraEditors.XtraForm
    {

        CRUD<Contact> ObjContact = new CRUD<Contact>("Contact");
        Contact Cot = new Contact();
        public ContactsForm()
        {
            InitializeComponent();
        }
        #region Load data
        private void LoadData()
        {
            SIngltonClass.Myinstance.gridControl1.DataSource = ObjContact.GetAll();
            SIngltonClass.Myinstance.gridControl1.DataMember = "Cont";
        }
        #endregion
        #region clear
        private void clear()
        {
            SIngltonClass.Myinstance.ContactId_textbox.Text = "";
            SIngltonClass.Myinstance.ContactType_textbox.Text = "";
            SIngltonClass.Myinstance.CompanyName_textbox.Text = "";
            SIngltonClass.Myinstance.ContactName_textbox.Text = "";
            SIngltonClass.Myinstance.ContactTitle_textbox.Text = "";
            SIngltonClass.Myinstance.Address_textbox.Text = "";
            SIngltonClass.Myinstance.City_textbox.Text = "";
            SIngltonClass.Myinstance.Region_textbox.Text = "";
            SIngltonClass.Myinstance.PostalCode_textbox.Text = "";
            SIngltonClass.Myinstance.County_textbox.Text = "";
            SIngltonClass.Myinstance.Phone_textbox.Text = "";
            SIngltonClass.Myinstance.Extension_textbox.Text = "";
            SIngltonClass.Myinstance.Fax_textbox.Text = "";
            SIngltonClass.Myinstance.HomePage_textbox.Text = "";
            SIngltonClass.Myinstance.PhotoPathtextbox.Text = "";
            SIngltonClass.Myinstance.Pictue_imagebox.Image = null;
        }
        #endregion
        #region set filds
        private void setfilds()
        {
            Cot.ContactID = Convert.ToInt32(SIngltonClass.Myinstance.ContactId_textbox.Text);
            Cot.ContactType = SIngltonClass.Myinstance.ContactType_textbox.Text;
            Cot.CompanyName = SIngltonClass.Myinstance.CompanyName_textbox.Text;
            Cot.ContactName = SIngltonClass.Myinstance.ContactName_textbox.Text;
            Cot.ContactTitle = SIngltonClass.Myinstance.ContactTitle_textbox.Text;
            Cot.Address = SIngltonClass.Myinstance.Address_textbox.Text;
            Cot.City = SIngltonClass.Myinstance.City_textbox.Text;
            Cot.Region = SIngltonClass.Myinstance.Region_textbox.Text;
            Cot.PostalCode = SIngltonClass.Myinstance.PostalCode_textbox.Text;
            Cot.Country = SIngltonClass.Myinstance.County_textbox.Text;
            Cot.Phone = SIngltonClass.Myinstance.Phone_textbox.Text;
            Cot.Extension = SIngltonClass.Myinstance.Extension_textbox.Text;
            Cot.Fax = SIngltonClass.Myinstance.Fax_textbox.Text;
            Cot.HomePage = SIngltonClass.Myinstance.HomePage_textbox.Text;
            Cot.PhotoPath = SIngltonClass.Myinstance.PhotoPathtextbox.Text;
            try
            {
                Cot.Photo = ConvertImageToBytes(SIngltonClass.Myinstance.Pictue_imagebox.Image);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Object reference not set to an instance of an object"))
                {
                    Cot.Photo = null;
                }
                
            }
        }
        #endregion
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
        private void Save_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try{
                setfilds();
                inserted = ObjContact.Create(Cot);
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
            }catch(Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void Edit_toolStripButton_Click(object sender, EventArgs e)
        {
            bool inserted;
            try
            {
                setfilds();
                inserted = ObjContact.Update(Cot);
                if (inserted == true)
                {
                    XtraMessageBox.Show("Update Successfully");
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
                XtraMessageBox.Show("Note Updated Successfully please look up your inputs");
            }
        }

        private void Delete_toolStripButton_Click(object sender, EventArgs e)
        {
            bool deleted;
            try
            {
                setfilds();
                deleted = ObjContact.Delete(Cot);
                if (deleted == true)
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

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Clear_toolStripButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        #region  Load from the harddriva
        private void Pictue_imagebox_DoubleClick(object sender, EventArgs e)
        {
            if (SIngltonClass.Myinstance.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SIngltonClass.Myinstance.Pictue_imagebox.Image = Image.FromFile(SIngltonClass.Myinstance.openFileDialog1.FileName);
            }
        }
        #endregion

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string [] Vals={"ContactID","ContactType","CompanyName","ContactName","ContactTitle","Address","City","Region","PostalCode","Country","Phone","Extension","Fax","HomePage","PhotoPath","Photo"};
            try
            {
                SIngltonClass.Myinstance.ContactId_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[0]));
                SIngltonClass.Myinstance.ContactType_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[1])); ;
                SIngltonClass.Myinstance.CompanyName_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[2]));
                SIngltonClass.Myinstance.ContactName_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[3]));
                SIngltonClass.Myinstance.ContactTitle_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[4]));
                SIngltonClass.Myinstance.Address_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[5]));
                SIngltonClass.Myinstance.City_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[6]));
                SIngltonClass.Myinstance.Region_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[7]));
                SIngltonClass.Myinstance.PostalCode_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[8]));
                SIngltonClass.Myinstance.County_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[9]));
                SIngltonClass.Myinstance.Phone_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[10]));
                SIngltonClass.Myinstance.Extension_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[11]));
                SIngltonClass.Myinstance.Fax_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[12]));
                SIngltonClass.Myinstance.HomePage_textbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[13]));
                SIngltonClass.Myinstance.PhotoPathtextbox.Text = Convert.ToString(SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[14]));
                SIngltonClass.Myinstance.Pictue_imagebox.Image = Convert_byte_to_Image((byte[])SIngltonClass.Myinstance.gridView1.GetRowCellValue(SIngltonClass.Myinstance.gridView1.FocusedRowHandle, Vals[15]));
            }
            catch (Exception ex)
            {
               //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }



    }
}