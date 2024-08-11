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
            smi_info = new ToolStripMenuItem();
            tsmi_Exit = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            smi_Pitch = new ToolStripMenuItem();
            smi_drinks = new ToolStripMenuItem();
            thôngTinĐặtSânToolStripMenuItem = new ToolStripMenuItem();
            smi_orderPitch = new ToolStripMenuItem();
            smi_orderDrinks = new ToolStripMenuItem();
            smi_Payment = new ToolStripMenuItem();
            panel_Show = new Panel();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.ActiveCaption;
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
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { smi_info, tsmi_Exit });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(87, 24);
            toolStripMenuItem1.Text = "Tài Khoản";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // smi_info
            // 
            smi_info.Name = "smi_info";
            smi_info.Size = new Size(224, 26);
            smi_info.Text = "Thông Tin Cá Nhân";
            smi_info.Click += smi_info_Click;
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
            menuStrip2.BackColor = SystemColors.ActiveCaption;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.GripStyle = ToolStripGripStyle.Visible;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { smi_Pitch, smi_drinks, thôngTinĐặtSânToolStripMenuItem, smi_Payment });
            menuStrip2.Location = new Point(9, 9);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1067, 28);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // smi_Pitch
            // 
            smi_Pitch.Name = "smi_Pitch";
            smi_Pitch.Size = new Size(86, 24);
            smi_Pitch.Text = "Sân Bóng";
            smi_Pitch.Click += smi_Pitch_Click;
            // 
            // smi_drinks
            // 
            smi_drinks.Name = "smi_drinks";
            smi_drinks.Size = new Size(125, 24);
            smi_drinks.Text = "Nước Giải Khác";
            smi_drinks.Click += smi_drinks_Click;
            // 
            // thôngTinĐặtSânToolStripMenuItem
            // 
            thôngTinĐặtSânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smi_orderPitch, smi_orderDrinks });
            thôngTinĐặtSânToolStripMenuItem.Name = "thôngTinĐặtSânToolStripMenuItem";
            thôngTinĐặtSânToolStripMenuItem.Size = new Size(144, 24);
            thôngTinĐặtSânToolStripMenuItem.Text = "Thông Tin Dịch Vụ";
            // 
            // smi_orderPitch
            // 
            smi_orderPitch.Name = "smi_orderPitch";
            smi_orderPitch.Size = new Size(180, 26);
            smi_orderPitch.Text = "Đặt Sân";
            smi_orderPitch.Click += smi_orderPitch_Click;
            // 
            // smi_orderDrinks
            // 
            smi_orderDrinks.Name = "smi_orderDrinks";
            smi_orderDrinks.Size = new Size(180, 26);
            smi_orderDrinks.Text = "Đặt Đồ Uống";
            smi_orderDrinks.Click += smi_orderDrinks_Click;
            // 
            // smi_Payment
            // 
            smi_Payment.Name = "smi_Payment";
            smi_Payment.Size = new Size(169, 24);
            smi_Payment.Text = "Thông Tin Thanh Toán";
            smi_Payment.Click += smi_Payment_Click;
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
        private ToolStripMenuItem smi_info;
        private ToolStripMenuItem tsmi_Exit;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem smi_Pitch;
        private ToolStripMenuItem smi_drinks;
        private ToolStripMenuItem thôngTinĐặtSânToolStripMenuItem;
        private ToolStripMenuItem smi_Payment;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem smi_orderPitch;
        private ToolStripMenuItem smi_orderDrinks;
        private Panel panel_Show;
    }
}