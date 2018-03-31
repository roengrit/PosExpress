namespace PosExpress
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.mn_expend = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_po = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_rv = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_ret = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_income = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_qt = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_iv = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_db = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_inventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_inventory_list = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_forward = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_count_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_movement = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_member = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_store = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_branch = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_other = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_expend,
            this.mn_income,
            this.mn_inventory,
            this.mn_member,
            this.mn_employee,
            this.mn_setting,
            this.mn_other});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(1247, 24);
            this.main_menu.TabIndex = 0;
            this.main_menu.Text = "menuStrip1";
            // 
            // mn_expend
            // 
            this.mn_expend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_po,
            this.mn_rv,
            this.mn_ret});
            this.mn_expend.Name = "mn_expend";
            this.mn_expend.Size = new System.Drawing.Size(34, 20);
            this.mn_expend.Text = "ซื้อ";
            // 
            // mn_po
            // 
            this.mn_po.Name = "mn_po";
            this.mn_po.Size = new System.Drawing.Size(114, 22);
            this.mn_po.Text = "สั่งซื้อ";
            // 
            // mn_rv
            // 
            this.mn_rv.Name = "mn_rv";
            this.mn_rv.Size = new System.Drawing.Size(114, 22);
            this.mn_rv.Text = "รับสินค้า";
            // 
            // mn_ret
            // 
            this.mn_ret.Name = "mn_ret";
            this.mn_ret.Size = new System.Drawing.Size(114, 22);
            this.mn_ret.Text = "ส่งคืน";
            // 
            // mn_income
            // 
            this.mn_income.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_qt,
            this.mn_iv,
            this.mn_db});
            this.mn_income.Name = "mn_income";
            this.mn_income.Size = new System.Drawing.Size(39, 20);
            this.mn_income.Text = "ขาย";
            // 
            // mn_qt
            // 
            this.mn_qt.Name = "mn_qt";
            this.mn_qt.Size = new System.Drawing.Size(123, 22);
            this.mn_qt.Text = "เสนอราคา";
            // 
            // mn_iv
            // 
            this.mn_iv.Name = "mn_iv";
            this.mn_iv.Size = new System.Drawing.Size(123, 22);
            this.mn_iv.Text = "ขาย";
            // 
            // mn_db
            // 
            this.mn_db.Name = "mn_db";
            this.mn_db.Size = new System.Drawing.Size(123, 22);
            this.mn_db.Text = "รับคืน";
            // 
            // mn_inventory
            // 
            this.mn_inventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_inventory_list,
            this.mn_forward,
            this.mn_count_stock,
            this.mn_movement});
            this.mn_inventory.Name = "mn_inventory";
            this.mn_inventory.Size = new System.Drawing.Size(46, 20);
            this.mn_inventory.Text = "สินค้า";
            // 
            // mn_inventory_list
            // 
            this.mn_inventory_list.Name = "mn_inventory_list";
            this.mn_inventory_list.Size = new System.Drawing.Size(152, 22);
            this.mn_inventory_list.Text = "รายการสินค้า";
            this.mn_inventory_list.Click += new System.EventHandler(this.mn_inventory_list_Click);
            // 
            // mn_forward
            // 
            this.mn_forward.Name = "mn_forward";
            this.mn_forward.Size = new System.Drawing.Size(152, 22);
            this.mn_forward.Text = "ยอดยกมา";
            // 
            // mn_count_stock
            // 
            this.mn_count_stock.Name = "mn_count_stock";
            this.mn_count_stock.Size = new System.Drawing.Size(152, 22);
            this.mn_count_stock.Text = "นับสต๊อค";
            // 
            // mn_movement
            // 
            this.mn_movement.Name = "mn_movement";
            this.mn_movement.Size = new System.Drawing.Size(152, 22);
            this.mn_movement.Text = "ความเคลื่อนไหว";
            // 
            // mn_member
            // 
            this.mn_member.Name = "mn_member";
            this.mn_member.Size = new System.Drawing.Size(71, 20);
            this.mn_member.Text = "ลูกค้า/คู่ค้า";
            // 
            // mn_employee
            // 
            this.mn_employee.Name = "mn_employee";
            this.mn_employee.Size = new System.Drawing.Size(59, 20);
            this.mn_employee.Text = "พนักงาน";
            // 
            // mn_setting
            // 
            this.mn_setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_store,
            this.mn_branch});
            this.mn_setting.Name = "mn_setting";
            this.mn_setting.Size = new System.Drawing.Size(45, 20);
            this.mn_setting.Text = "ตั้งค่า";
            // 
            // mn_store
            // 
            this.mn_store.Name = "mn_store";
            this.mn_store.Size = new System.Drawing.Size(106, 22);
            this.mn_store.Text = "กิจการ";
            // 
            // mn_branch
            // 
            this.mn_branch.Name = "mn_branch";
            this.mn_branch.Size = new System.Drawing.Size(106, 22);
            this.mn_branch.Text = "สาขา";
            // 
            // mn_other
            // 
            this.mn_other.Name = "mn_other";
            this.mn_other.Size = new System.Drawing.Size(39, 20);
            this.mn_other.Text = "อื่นๆ";
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.AllowEndUserDocking = false;
            this.dockPanel.AllowEndUserNestedDocking = false;
            this.dockPanel.AutoSize = true;
            this.dockPanel.BackColor = System.Drawing.Color.Transparent;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBottomPortion = 150D;
            this.dockPanel.DockLeftPortion = 200D;
            this.dockPanel.DockRightPortion = 200D;
            this.dockPanel.DockTopPortion = 150D;
            this.dockPanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.dockPanel.Location = new System.Drawing.Point(0, 24);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.Size = new System.Drawing.Size(1247, 633);
            this.dockPanel.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 657);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.main_menu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.main_menu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "หน้าจอหลัก";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem mn_income;
        private System.Windows.Forms.ToolStripMenuItem mn_expend;
        private System.Windows.Forms.ToolStripMenuItem mn_inventory;
        private System.Windows.Forms.ToolStripMenuItem mn_inventory_list;
        private System.Windows.Forms.ToolStripMenuItem mn_member;
        private System.Windows.Forms.ToolStripMenuItem mn_employee;
        private System.Windows.Forms.ToolStripMenuItem mn_setting;
        private System.Windows.Forms.ToolStripMenuItem mn_store;
        private System.Windows.Forms.ToolStripMenuItem mn_other;
        private System.Windows.Forms.ToolStripMenuItem mn_po;
        private System.Windows.Forms.ToolStripMenuItem mn_rv;
        private System.Windows.Forms.ToolStripMenuItem mn_ret;
        private System.Windows.Forms.ToolStripMenuItem mn_qt;
        private System.Windows.Forms.ToolStripMenuItem mn_iv;
        private System.Windows.Forms.ToolStripMenuItem mn_db;
        private System.Windows.Forms.ToolStripMenuItem mn_forward;
        private System.Windows.Forms.ToolStripMenuItem mn_count_stock;
        private System.Windows.Forms.ToolStripMenuItem mn_movement;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripMenuItem mn_branch;
    }
}

