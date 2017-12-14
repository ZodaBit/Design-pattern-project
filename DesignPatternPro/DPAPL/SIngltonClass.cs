using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace DPAPL
{
   public class SIngltonClass
   {
       private static SIngltonClass instance = null;
       private SIngltonClass() { }
       public static SIngltonClass Myinstance
       {
           get
           {
               if (instance == null)
                   instance = new SIngltonClass();
               return instance;
           }
       }

 

       public TextEdit RegionId_textbox;

       public TextEdit TerritoryDescription_textbox;
       public TextEdit TerritoryId_textbox;
       public PanelControl panelControl1;
       public PanelControl panelControl3;
       public PanelControl panelControl5;
       public TextEdit HomePage_textbox;
       public LabelControl labelControl7;
       public TextEdit Fax_textbox;
       public LabelControl labelControl2;
       public TextEdit County_textbox;
       public TextEdit Phone_textbox;
       public TextEdit PostalCode_textbox;
       public TextEdit Extension_textbox;
       public LabelControl labelControl13;
       public LabelControl labelControl12;
       public LabelControl labelControl11;
       public LabelControl labelControl10;
       public PanelControl panelControl4;
       public TextEdit ContactType_textbox;
       public LabelControl labelControl1;
       public TextEdit ContactName_textbox;
       public TextEdit ContactTitle_textbox;
       public TextEdit Region_textbox;
       public TextEdit CompanyName_textbox;
       public TextEdit City_textbox;
       public TextEdit Address_textbox;
       public LabelControl FirstNamelabel;
       public LabelControl labelControl3;
       public LabelControl labelControl4;
       public LabelControl labelControl8;
       public LabelControl labelControl6;
       public LabelControl labelControl5;
       public ToolStrip toolStrip1;
       public ToolStripButton Save_toolStripButton;
       public ToolStripButton Edit_toolStripButton;
       public ToolStripButton Delete_toolStripButton;
       public ToolStripButton Clear_toolStripButton;
       public TextEdit ContactId_textbox;
       public LabelControl EmployeeIDlabel;
       public GroupBox groupBox2;
       public GroupBox groupBox1;
       public GridControl gridControl1;
       public GridView gridView1;
       public TextEdit PhotoPathtextbox;
       public LabelControl labelControl9;
       public PictureEdit Pictue_imagebox;
       public OpenFileDialog openFileDialog1;

   }
}
