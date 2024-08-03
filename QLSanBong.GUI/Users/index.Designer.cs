namespace QLSanBong.GUI.Users
{
    partial class frm_User
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            tsmi_info = new ToolStripMenuItem();
            tsmi_Exit = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            đặtSânToolStripMenuItem = new ToolStripMenuItem();
            đặtĐồUốngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinĐặtSânToolStripMenuItem = new ToolStripMenuItem();
            thôngTinThanhToánToolStripMenuItem = new ToolStripMenuItem();
            đặtSânToolStripMenuItem1 = new ToolStripMenuItem();
            đặtĐồUốngToolStripMenuItem1 = new ToolStripMenuItem();
            panel_Show = new Panel();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.ActiveBorder;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem4, toolStripMenuItem5 });
            menuStrip1.Location = new Point(976, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(100, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tsmi_info, tsmi_Exit });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(87, 24);
            toolStripMenuItem1.Text = "Tài Khoản";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // tsmi_info
            // 
            tsmi_info.Name = "tsmi_info";
            tsmi_info.Size = new Size(224, 26);
            tsmi_info.Text = "Thông Tin Cá Nhân";
            // 
            // tsmi_Exit
            // 
            tsmi_Exit.Name = "tsmi_Exit";
            tsmi_Exit.Size = new Size(224, 26);
            tsmi_Exit.Text = "Thoát";
            tsmi_Exit.Click += tsmi_Exit_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(14, 24);
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(14, 24);
            // 
            // menuStrip2
            // 
            menuStrip2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = SystemColors.ActiveBorder;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.GripStyle = ToolStripGripStyle.Visible;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { đặtSânToolStripMenuItem, đặtĐồUốngToolStripMenuItem, thôngTinĐặtSânToolStripMenuItem, thôngTinThanhToánToolStripMenuItem });
            menuStrip2.Location = new Point(9, 9);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1067, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // đặtSânToolStripMenuItem
            // 
            đặtSânToolStripMenuItem.Name = "đặtSânToolStripMenuItem";
            đặtSânToolStripMenuItem.Size = new Size(86, 24);
            đặtSânToolStripMenuItem.Text = "Sân Bóng";
            // 
            // đặtĐồUốngToolStripMenuItem
            // 
            đặtĐồUốngToolStripMenuItem.Name = "đặtĐồUốngToolStripMenuItem";
            đặtĐồUốngToolStripMenuItem.Size = new Size(125, 24);
            đặtĐồUốngToolStripMenuItem.Text = "Nước Giải Khác";
            // 
            // thôngTinĐặtSânToolStripMenuItem
            // 
            thôngTinĐặtSânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đặtSânToolStripMenuItem1, đặtĐồUốngToolStripMenuItem1 });
            thôngTinĐặtSânToolStripMenuItem.Name = "thôngTinĐặtSânToolStripMenuItem";
            thôngTinĐặtSânToolStripMenuItem.Size = new Size(144, 24);
            thôngTinĐặtSânToolStripMenuItem.Text = "Thông Tin Dịch Vụ";
            // 
            // thôngTinThanhToánToolStripMenuItem
            // 
            thôngTinThanhToánToolStripMenuItem.Name = "thôngTinThanhToánToolStripMenuItem";
            thôngTinThanhToánToolStripMenuItem.Size = new Size(169, 24);
            thôngTinThanhToánToolStripMenuItem.Text = "Thông Tin Thanh Toán";
            // 
            // đặtSânToolStripMenuItem1
            // 
            đặtSânToolStripMenuItem1.Name = "đặtSânToolStripMenuItem1";
            đặtSânToolStripMenuItem1.Size = new Size(224, 26);
            đặtSânToolStripMenuItem1.Text = "Đặt Sân";
            // 
            // đặtĐồUốngToolStripMenuItem1
            // 
            đặtĐồUốngToolStripMenuItem1.Name = "đặtĐồUốngToolStripMenuItem1";
            đặtĐồUốngToolStripMenuItem1.Size = new Size(224, 26);
            đặtĐồUốngToolStripMenuItem1.Text = "Đặt Đồ Uống";
            // 
            // panel_Show
            // 
            panel_Show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_Show.Location = new Point(12, 40);
            panel_Show.Name = "panel_Show";
            panel_Show.Size = new Size(1061, 431);
            panel_Show.TabIndex = 3;
            // 
            // frm_User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 483);
            Controls.Add(panel_Show);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "frm_User";
            Text = "Màn Hình Chính";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tsmi_info;
        private ToolStripMenuItem tsmi_Exit;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem đặtSânToolStripMenuItem;
        private ToolStripMenuItem đặtĐồUốngToolStripMenuItem;
        private ToolStripMenuItem thôngTinĐặtSânToolStripMenuItem;
        private ToolStripMenuItem thôngTinThanhToánToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem đặtSânToolStripMenuItem1;
        private ToolStripMenuItem đặtĐồUốngToolStripMenuItem1;
        private Panel panel_Show;
    }
}