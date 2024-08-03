namespace QLSanBong.GUI.Login
{
    partial class frm_Login
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
            lbl_Login = new Label();
            label2 = new Label();
            txt_Username = new TextBox();
            label3 = new Label();
            txt_Password = new TextBox();
            btn_Login = new Button();
            lnklb_ForgetPass = new LinkLabel();
            lnklb_SignUp = new LinkLabel();
            SuspendLayout();
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Login.Location = new Point(110, 53);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(166, 38);
            lbl_Login.TabIndex = 0;
            lbl_Login.Text = "Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 150);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Đăng Nhập";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(68, 173);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(241, 27);
            txt_Username.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 243);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật Khẩu";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(68, 266);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(241, 27);
            txt_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(132, 333);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(111, 44);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Đăng Nhập";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // lnklb_ForgetPass
            // 
            lnklb_ForgetPass.AutoSize = true;
            lnklb_ForgetPass.Location = new Point(62, 413);
            lnklb_ForgetPass.Name = "lnklb_ForgetPass";
            lnklb_ForgetPass.Size = new Size(118, 20);
            lnklb_ForgetPass.TabIndex = 6;
            lnklb_ForgetPass.TabStop = true;
            lnklb_ForgetPass.Text = "Quên Mật Khẩu?";
            lnklb_ForgetPass.LinkClicked += lnklb_ForgetPass_LinkClicked;
            // 
            // lnklb_SignUp
            // 
            lnklb_SignUp.AutoSize = true;
            lnklb_SignUp.Location = new Point(241, 413);
            lnklb_SignUp.Name = "lnklb_SignUp";
            lnklb_SignUp.Size = new Size(68, 20);
            lnklb_SignUp.TabIndex = 7;
            lnklb_SignUp.TabStop = true;
            lnklb_SignUp.Text = "Đăng Ký!";
            lnklb_SignUp.LinkClicked += lnklb_SignUp_LinkClicked;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 498);
            Controls.Add(lnklb_SignUp);
            Controls.Add(lnklb_ForgetPass);
            Controls.Add(btn_Login);
            Controls.Add(txt_Password);
            Controls.Add(label3);
            Controls.Add(txt_Username);
            Controls.Add(label2);
            Controls.Add(lbl_Login);
            Name = "frm_Login";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Login;
        private Label label2;
        private TextBox txt_Username;
        private Label label3;
        private TextBox txt_Password;
        private Button btn_Login;
        private LinkLabel lnklb_ForgetPass;
        private LinkLabel lnklb_SignUp;
    }
}