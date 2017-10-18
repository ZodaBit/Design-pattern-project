using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPAPL
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CategoiesForm categoriesForm = new CategoiesForm();
            categoriesForm.MdiParent = this;
            categoriesForm.Show();
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactsForm confrm = new ContactsForm();
            confrm.MdiParent = this;
            confrm.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm cusfrm = new CustomersForm();
            cusfrm.MdiParent = this;
            cusfrm.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesForm empfrm = new EmployeesForm();
            empfrm.MdiParent = this;
            empfrm.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm orfrm = new OrdersForm();
            orfrm.MdiParent = this;
            orfrm.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm profrm = new ProductsForm();
            profrm.MdiParent = this;
            profrm.Show();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegionForm regfrm = new RegionForm();
            regfrm.MdiParent = this;
            regfrm.Show();
        }

        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShippersForm shfrm = new ShippersForm();
            shfrm.MdiParent = this;
            shfrm.Show();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuppliersForm frm = new SuppliersForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void territoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerritoriesForm frms = new TerritoriesForm();
            frms.MdiParent = this;
            frms.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
        }
    }
}
