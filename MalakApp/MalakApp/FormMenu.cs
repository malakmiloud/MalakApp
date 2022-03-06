using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalakApp
{
    public partial class FormMenu : Form
    {
        private int childFormNumber = 0;
        

        public FormMenu()
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

        private void iNSERTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerInsert custInsert = new CustomerInsert();
            custInsert.MdiParent = this;
            custInsert.Show();
            
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerView custView = new CustomerView();
            custView.MdiParent = this;
            custView.Show();
            
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerUpdate custUpdate = new CustomerUpdate();
            custUpdate.MdiParent = this;
            custUpdate.Show();
            
        }

        private void dELETEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustomerDelete custDelete = new CustomerDelete();
            custDelete.MdiParent = this;
            custDelete.Show();
       
        }

        private void FormMenu_MdiChildActivate(object sender, EventArgs e)
        {
            
        }

        private void iNSERTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductInsert prodInsert = new ProductInsert();
            prodInsert.MdiParent = this;
            prodInsert.Show();
        }

        private void vIEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductView prodView = new ProductView();
            prodView.MdiParent = this;
            prodView.Show();
        }

        private void uPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductUpdate prodUpdate = new ProductUpdate();
            prodUpdate.MdiParent = this;
            prodUpdate.Show();
        }

        private void dELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductDelete prodDelete = new ProductDelete();
            prodDelete.MdiParent = this;
            prodDelete.Show();
        }

        private void iNSERTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VendorInsert vendorInsert = new VendorInsert();
            vendorInsert.MdiParent = this;
            vendorInsert.Show();
        }

        private void vIEWToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VendorView vendorView = new VendorView();
            vendorView.MdiParent = this;
            vendorView.Show();
        }

        private void uPDATEToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VendorUpdate vendorUpdate = new VendorUpdate();
            vendorUpdate.MdiParent = this;
            vendorUpdate.Show();
        }

        private void dELETEToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VendorDelete vendorDelete = new VendorDelete();
            vendorDelete.MdiParent = this;
            vendorDelete.Show();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
