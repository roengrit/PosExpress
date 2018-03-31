using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosExpress.Inventory
{
    public partial class FormInventoryAdd : Form
    {
       

        public FormInventoryAdd()
        {
            InitializeComponent();
        }

        private void FormInventoryAdd_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
        }

        private void btnFindCate_Click(object sender, EventArgs e)
        {
            Utility.FormNormalMasterFind findMaster = new Utility.FormNormalMasterFind( tableName:"",showCode:false);
            findMaster.ShowDialog();
        }

        private void txtFind_Enter(object sender, EventArgs e)
        {
         
        }

        private void btnFindUnit_Click(object sender, EventArgs e)
        {
            Utility.FormNormalMasterFind findMaster = new Utility.FormNormalMasterFind(tableName: "ic_unit", showCode: false);
            findMaster.ShowDialog();
        }
    }
}
