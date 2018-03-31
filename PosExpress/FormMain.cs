using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosExpress
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mn_inventory_list_Click(object sender, EventArgs e)
        {
            var frm = new Inventory.FormInventory();
            frm.Show(dockPanel);
        }
    }
}
