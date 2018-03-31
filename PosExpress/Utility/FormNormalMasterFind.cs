using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosExpress.Utility
{
    public partial class FormNormalMasterFind : Form
    {
        public string tableName { get; set; }
        public bool showCode { get; set; }

        public FormNormalMasterFind(string title, string tableName, bool showCode)
        {
            this.tableName = tableName;
            this.showCode = showCode;
            InitializeComponent();
            dgvMain.Columns["code"].Visible = showCode;
            this.Text += " [" + title + "]";
        }

        private void FormFindMaster_Deactivate(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string forceName = "")
        {
            var sql = @" select id,code,name_1 " +
                      @" from " + this.tableName +
                      @" where 1=1 and name_1 like '%" + (string.IsNullOrEmpty(forceName)?txtFind.Text.Trim() : forceName) + "%' " + 
                                                         (this.showCode ? " and code like '%" + txtFind.Text.Trim() + "%' " : "") +
                      @" limit 100 ";
            if (!this.showCode)
            {
                sql = sql.Replace("code,", "");
            }
            var dtReturn = GlobalVar.GetData(sql);
            dgvMain.Rows.Clear();

            foreach (DataRow item in dtReturn.Rows)
            {
                dgvMain.Rows.Add(item["id"], this.showCode ? item["code"] : "", item["name_1"]);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            if (keyData == Keys.Up)
            {
                dgvMain.Focus();
            }
            if (keyData == Keys.Down)
            {
                dgvMain.Focus();
            }
            if (keyData == Keys.Enter)
            {
                if (dgvMain.SelectedRows.Count > 0)
                {
                    this.Close();
                }
            }
            if (keyData == Keys.F2)
            {
                txtFind.Focus();
                txtFind.SelectAll();
            }
            if (keyData == Keys.F3)
            {
                Add();
            }
            if (keyData == Keys.F4)
            {
                Edit();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Add()
        {
            var frm = new FormNormalMasterAdd(this.tableName, 0);
            frm.Show();
            if (frm.ok && string.IsNullOrEmpty(frm.txtName.Text.Trim()))
            {
                LoadData(frm.txtName.Text.Trim());
            }
        }

        private void Edit()
        {
            if (dgvMain.SelectedRows.Count > 0)
            {
                var frm = new FormNormalMasterAdd(this.tableName, Convert.ToInt32(dgvMain.SelectedRows[0].Cells["id"].Value));
                frm.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
