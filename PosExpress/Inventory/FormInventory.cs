using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PosExpress.Inventory
{
    public partial class FormInventory : DockContent
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2)
            {
                txtFind.Focus();
                txtFind.SelectAll();
            }
            if (keyData == Keys.F3)
            {
                New();
            }
            if (keyData == Keys.F4)
            {
                Delete();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void New()
        {
            var frm = new FormInventoryAdd();
            frm.ShowDialog();
        }

        private void Delete()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
