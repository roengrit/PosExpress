using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosExpress.Utility
{
    public partial class FormNormalMasterAdd : Form
    {
        public string tableName { get; set; }
        public int id { get; set; }
        public bool ok { get; set; }
        private string err { get; set; }
        public FormNormalMasterAdd(string title,string tableName,int id)
        {
            this.tableName = tableName;
            this.id = id;
            InitializeComponent();
            if (id != 0)
            {
               var ret = GlobalVar.GetData("select name_1 from " + this.Name + " where id = " + id);
                if (ret.Rows.Count>0)
                {
                    txtName.Text = ret.Rows[0]["name_1"].ToString();
                }
            }
            this.Text += " [" + title + "]";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (id == 0)
            {
                var ret = GlobalVar.InserData(new List<string> { string.Format("insert into " + this.tableName + " (name_1) values('{0}')", txtName.Text.Trim()) });
                this.ok = ret.ok;
                err = ret.err;
                if (ret.ok)
                {
                    this.Close();
                }
            }
            else
            {
                var ret = GlobalVar.InserData(new List<string> { string.Format("update " + this.tableName + " set name_1 = '{0}' ", txtName.Text.Trim()) });
                this.ok = ret.ok;
                err = ret.err;
                if (ret.ok)
                {
                    this.Close();
                }
            }
            if (!this.ok)
            {
                Message
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            
            if (keyData == Keys.F12)
            {
                Save();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormNormalMasterAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
