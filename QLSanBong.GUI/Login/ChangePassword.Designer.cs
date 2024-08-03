namespace QLSanBong.GUI.Login
{
    partial class frm_ChangePassword
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
            lbl_Title = new Label();
            lbl_Password = new Label();
            txt_Password = new TextBox();
            lbl_ConfirmPass = new Label();
            txt_ConfirmPass = new TextBox();
            btn_ChangePass = new Button();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.Location = new Point(107, 19);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(219, 31);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Thay Đổi Mật Khẩu";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(75, 102);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(72, 20);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Mật Khẩu";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(75, 125);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(277, 27);
            txt_Password.TabIndex = 2;
            txt_Password.Leave += txt_Password_Leave;
            // 
            // lbl_ConfirmPass
            // 
            lbl_ConfirmPass.AutoSize = true;
            lbl_ConfirmPass.Location = new Point(75, 187);
            lbl_ConfirmPass.Name = "lbl_ConfirmPass";
            lbl_ConfirmPass.Size = new Size(135, 20);
            lbl_ConfirmPass.TabIndex = 3;
            lbl_ConfirmPass.Text = "Nhập Lại Mật Khẩu";
            // 
            // txt_ConfirmPass
            // 
            txt_ConfirmPass.Location = new Point(75, 210);
            txt_ConfirmPass.Name = "txt_ConfirmPass";
            txt_ConfirmPass.PasswordChar = '*';
            txt_ConfirmPass.Size = new Size(277, 27);
            txt_ConfirmPass.TabIndex = 4;
            // 
            // btn_ChangePass
            // 
            btn_ChangePass.Location = new Point(159, 268);
            btn_ChangePass.Name = "btn_ChangePass";
            btn_ChangePass.Size = new Size(103, 44);
            btn_ChangePass.TabIndex = 5;
            btn_ChangePass.Text = "Đồng Ý";
            btn_ChangePass.UseVisualStyleBackColor = true;
            btn_ChangePass.Click += btn_ChangePass_Click;
            // 
            // frm_ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 345);
            Controls.Add(btn_ChangePass);
            Controls.Add(txt_ConfirmPass);
            Controls.Add(lbl_ConfirmPass);
            Controls.Add(txt_Password);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Title);
            Name = "frm_ChangePassword";
            Text = "Change Password Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private Label lbl_Password;
        private TextBox txt_Password;
        private Label lbl_ConfirmPass;
        private TextBox txt_ConfirmPass;
        private Button btn_ChangePass;
    }
}