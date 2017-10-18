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
using DPBBL;
using Factory;

namespace DPAPL
{
    public partial class ContactsForm : DevExpress.XtraEditors.XtraForm
    {
        //ContactDAO ObjContact = (ContactDAO)FactoryProducer.getCust("Contact");
        ICrudDAO<Contact> ObjContact = (ICrudDAO<Contact>)FactoryProducer.GetDAOIMPObject("Contact");
        Contact Cot = new Contact();
        public ContactsForm()
        {
            InitializeComponent();
        }
        #region Load data
        private void LoadData()
        {
            gridControl1.DataSource = ObjContact.GetAllData();
            gridControl1.DataMember = "Cont";
        }
        #endregion
        #region clear
        private void clear()
        {
            ContactId_textbox.Text = "";
            ContactType_textbox.Text = "";
            CompanyName_textbox.Text ="";
            ContactName_textbox.Text = "";
            ContactTitle_textbox.Text ="";
            Address_textbox.Text = "";
            City_textbox.Text = "";
            Region_textbox.Text = "";
            PostalCode_textbox.Text = "";
            County_textbox.Text = "";
            Phone_textbox.Text = "";
            Extension_textbox.Text = "";
            Fax_textbox.Text = "";
            HomePage_textbox.Text = "";
            PhotoPathtextbox.Text = "";
            Pictue_imagebox.Image = null;
        }
        #endregion
        #region set filds
        private void setfilds()
        {
            Cot.ContactID = Convert.ToInt32(ContactId_textbox.Text);
            Cot.ContactType= ContactType_textbox.Text ;
            Cot.CompanyName=CompanyName_textbox.Text ;
            Cot.ContactName=ContactName_textbox.Text ;
            Cot.ContactTitle=ContactTitle_textbox.Text ;
            Cot.Address=Address_textbox.Text ;
            Cot.City=City_textbox.Text ;
            Cot.Region=Region_textbox.Text ;
            Cot.PostalCode= PostalCode_textbox.Text ;
            Cot.Country=County_textbox.Text ;
            Cot.Phone=Phone_textbox.Text ;
            Cot.Extension = Extension_textbox.Text;
            Cot.Fax=Fax_textbox.Text ;
            Cot.HomePage=HomePage_textbox.Text ;
            Cot.PhotoPath = PhotoPathtextbox.Text;
            try
            {
                Cot.Photo = ConvertImageToBytes(Pictue_imagebox.Image);
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
                inserted = ObjContact.CreateData(Cot);
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
                inserted = ObjContact.UpdateData(Cot);
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
                deleted = ObjContact.DeleteData(Cot);
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pictue_imagebox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        #endregion

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string [] Vals={"ContactID","ContactType","CompanyName","ContactName","ContactTitle","Address","City","Region","PostalCode","Country","Phone","Extension","Fax","HomePage","PhotoPath","Photo"};
            try
            {
                ContactId_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[0]));
                ContactType_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[1])); ;
                CompanyName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[2]));
                ContactName_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[3]));
                ContactTitle_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[4]));
                Address_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[5]));
                City_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[6]));
                Region_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[7]));
                PostalCode_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[8]));
                County_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[9]));
                Phone_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[10]));
                Extension_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[11]));
                Fax_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[12]));
                HomePage_textbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[13]));
                PhotoPathtextbox.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[14]));
                Pictue_imagebox.Image = Convert_byte_to_Image((byte[])gridView1.GetRowCellValue(gridView1.FocusedRowHandle, Vals[15]));
            }
            catch (Exception ex)
            {
               //store exeption and display 
                //XtraMessageBox.Show("please clik on the row properly");
            }
        }



    }
}