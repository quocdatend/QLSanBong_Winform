namespace QLSanBong.GUI.Login
{
    partial class frm_CheckEmail
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
            lbl_CheckEmail = new Label();
            txt_Email = new TextBox();
            btn_CheckEmail = new Button();
            SuspendLayout();
            // 
            // lbl_CheckEmail
            // 
            lbl_CheckEmail.AutoSize = true;
            lbl_CheckEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CheckEmail.Location = new Point(132, 35);
            lbl_CheckEmail.Name = "lbl_CheckEmail";
            lbl_CheckEmail.Size = new Size(172, 31);
            lbl_CheckEmail.TabIndex = 0;
            lbl_CheckEmail.Text = "Kiểm Tra Email";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(96, 108);
            txt_Email.Name = "txt_Email";
            txt_Email.PlaceholderText = "Email";
            txt_Email.Size = new Size(261, 27);
            txt_Email.TabIndex = 1;
            // 
            // btn_CheckEmail
            // 
            btn_CheckEmail.Location = new Point(161, 165);
            btn_CheckEmail.Name = "btn_CheckEmail";
            btn_CheckEmail.Size = new Size(111, 42);
            btn_CheckEmail.TabIndex = 2;
            btn_CheckEmail.Text = "Kiểm Tra";
            btn_CheckEmail.UseVisualStyleBackColor = true;
            btn_CheckEmail.Click += btn_CheckEmail_Click;
            // 
            // frm_CheckEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 267);
            Controls.Add(btn_CheckEmail);
            Controls.Add(txt_Email);
            Controls.Add(lbl_CheckEmail);
            Name = "frm_CheckEmail";
            Text = "Check Email Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_CheckEmail;
        private TextBox txt_Email;
        private Button btn_CheckEmail;
    }
}