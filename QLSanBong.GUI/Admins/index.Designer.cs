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
            indexd = new Label();
            SuspendLayout();
            // 
            // indexd
            // 
            indexd.AutoSize = true;
            indexd.Location = new Point(334, 200);
            indexd.Name = "indexd";
            indexd.Size = new Size(97, 20);
            indexd.TabIndex = 0;
            indexd.Text = "This is Admin";
            // 
            // frm_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(indexd);
            Name = "frm_Admin";
            Text = "index";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label indexd;
    }
}