namespace QLSanBong.GUI.Admins
{
    partial class frm_Admin
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
            usersToolStripMenuItem = new ToolStripMenuItem();
            giáTheoGiờToolStripMenuItem = new ToolStripMenuItem();
            OrderPitchToolStripMenuItem = new ToolStripMenuItem();
            TypePitchToolStripMenuItem = new ToolStripMenuItem();
            PricePerHourToolStripMenuItem1 = new ToolStripMenuItem();
            đồĂnUốngToolStripMenuItem = new ToolStripMenuItem();
            OrderFoodDrinkToolStripMenuItem = new ToolStripMenuItem();
            FoodDrinksToolStripMenuItem = new ToolStripMenuItem();
            PaymentToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            AccountToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            panel_show = new Panel();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, giáTheoGiờToolStripMenuItem, đồĂnUốngToolStripMenuItem, PaymentToolStripMenuItem });
            menuStrip1.Location = new Point(9, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(484, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(124, 24);
            usersToolStripMenuItem.Text = "Tài khoản Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // giáTheoGiờToolStripMenuItem
            // 
            giáTheoGiờToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OrderPitchToolStripMenuItem, TypePitchToolStripMenuItem, PricePerHourToolStripMenuItem1 });
            giáTheoGiờToolStripMenuItem.Name = "giáTheoGiờToolStripMenuItem";
            giáTheoGiờToolStripMenuItem.Size = new Size(86, 24);
            giáTheoGiờToolStripMenuItem.Text = "Sân Bóng";
            // 
            // OrderPitchToolStripMenuItem
            // 
            OrderPitchToolStripMenuItem.Name = "OrderPitchToolStripMenuItem";
            OrderPitchToolStripMenuItem.Size = new Size(174, 26);
            OrderPitchToolStripMenuItem.Text = "Đặt Sân";
            OrderPitchToolStripMenuItem.Click += OrderPitchToolStripMenuItem_Click;
            // 
            // TypePitchToolStripMenuItem
            // 
            TypePitchToolStripMenuItem.Name = "TypePitchToolStripMenuItem";
            TypePitchToolStripMenuItem.Size = new Size(174, 26);
            TypePitchToolStripMenuItem.Text = "Loại Sân";
            TypePitchToolStripMenuItem.Click += TypePitchToolStripMenuItem_Click;
            // 
            // PricePerHourToolStripMenuItem1
            // 
            PricePerHourToolStripMenuItem1.Name = "PricePerHourToolStripMenuItem1";
            PricePerHourToolStripMenuItem1.Size = new Size(174, 26);
            PricePerHourToolStripMenuItem1.Text = "Giá theo giờ";
            PricePerHourToolStripMenuItem1.Click += PricePerHourToolStripMenuItem1_Click;
            // 
            // đồĂnUốngToolStripMenuItem
            // 
            đồĂnUốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OrderFoodDrinkToolStripMenuItem, FoodDrinksToolStripMenuItem });
            đồĂnUốngToolStripMenuItem.Name = "đồĂnUốngToolStripMenuItem";
            đồĂnUốngToolStripMenuItem.Size = new Size(105, 24);
            đồĂnUốngToolStripMenuItem.Text = "Đồ ăn & uống";
            // 
            // OrderFoodDrinkToolStripMenuItem
            // 
            OrderFoodDrinkToolStripMenuItem.Name = "OrderFoodDrinkToolStripMenuItem";
            OrderFoodDrinkToolStripMenuItem.Size = new Size(239, 26);
            OrderFoodDrinkToolStripMenuItem.Text = "Đặt đồ ăn & uống";
            OrderFoodDrinkToolStripMenuItem.Click += OrderFoodDrinkToolStripMenuItem_Click;
            // 
            // FoodDrinksToolStripMenuItem
            // 
            FoodDrinksToolStripMenuItem.Name = "FoodDrinksToolStripMenuItem";
            FoodDrinksToolStripMenuItem.Size = new Size(239, 26);
            FoodDrinksToolStripMenuItem.Text = "Thông tin đồ ăn & uống";
            FoodDrinksToolStripMenuItem.Click += FoodDrinksToolStripMenuItem_Click;
            // 
            // PaymentToolStripMenuItem
            // 
            PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem";
            PaymentToolStripMenuItem.Size = new Size(161, 24);
            PaymentToolStripMenuItem.Text = "Thông tin thanh toán";
            PaymentToolStripMenuItem.Click += PaymentToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip2.Location = new Point(1005, 9);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.RenderMode = ToolStripRenderMode.System;
            menuStrip2.RightToLeft = RightToLeft.Yes;
            menuStrip2.Size = new Size(159, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AccountToolStripMenuItem, ExitToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // AccountToolStripMenuItem
            // 
            AccountToolStripMenuItem.Name = "AccountToolStripMenuItem";
            AccountToolStripMenuItem.Size = new Size(224, 26);
            AccountToolStripMenuItem.Text = "Tài khoản";
            AccountToolStripMenuItem.Click += AccountToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(224, 26);
            ExitToolStripMenuItem.Text = "Thoát";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // panel_show
            // 
            panel_show.Location = new Point(9, 40);
            panel_show.Name = "panel_show";
            panel_show.Size = new Size(1152, 485);
            panel_show.TabIndex = 2;
            // 
            // frm_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 537);
            Controls.Add(panel_show);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "frm_Admin";
            Text = "Quản lý";
            FormClosing += frm_Admin_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem giáTheoGiờToolStripMenuItem;
        private ToolStripMenuItem OrderPitchToolStripMenuItem;
        private ToolStripMenuItem TypePitchToolStripMenuItem;
        private ToolStripMenuItem PricePerHourToolStripMenuItem1;
        private ToolStripMenuItem đồĂnUốngToolStripMenuItem;
        private ToolStripMenuItem OrderFoodDrinkToolStripMenuItem;
        private ToolStripMenuItem FoodDrinksToolStripMenuItem;
        private ToolStripMenuItem PaymentToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem AccountToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private Panel panel_show;
    }
}