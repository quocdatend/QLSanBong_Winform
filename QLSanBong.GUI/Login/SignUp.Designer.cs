namespace QLSanBong.GUI.Login
{
    partial class frm_SignUp
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
            lbl_SignUp = new Label();
            lbl_Username = new Label();
            txt_Username = new TextBox();
            lbl_Email = new Label();
            txt_Email = new TextBox();
            lbl_Phone = new Label();
            txt_Phone = new TextBox();
            lbl_Password = new Label();
            txt_Password = new TextBox();
            lbl_Confirm_Pass = new Label();
            txt_Confirm_Pass = new TextBox();
            btn_SignUp = new Button();
            SuspendLayout();
            // 
            // lbl_SignUp
            // 
            lbl_SignUp.AutoSize = true;
            lbl_SignUp.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_SignUp.Location = new Point(169, 31);
            lbl_SignUp.Name = "lbl_SignUp";
            lbl_SignUp.Size = new Size(127, 38);
            lbl_SignUp.TabIndex = 0;
            lbl_SignUp.Text = "Đăng Ký";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(61, 110);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(112, 20);
            lbl_Username.TabIndex = 1;
            lbl_Username.Text = "Tên Đăng Nhập";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(61, 133);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(337, 27);
            txt_Username.TabIndex = 2;
            txt_Username.Leave += txt_Username_Leave;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(58, 187);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(46, 20);
            lbl_Email.TabIndex = 3;
            lbl_Email.Text = "Email";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(58, 210);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(340, 27);
            txt_Email.TabIndex = 4;
            txt_Email.Leave += txt_Email_Leave;
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Location = new Point(58, 269);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(50, 20);
            lbl_Phone.TabIndex = 5;
            lbl_Phone.Text = "Phone";
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(58, 292);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(340, 27);
            txt_Phone.TabIndex = 6;
            txt_Phone.Leave += txt_Phone_Leave;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(58, 353);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(72, 20);
            lbl_Password.TabIndex = 7;
            lbl_Password.Text = "Mật Khẩu";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(58, 376);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(340, 27);
            txt_Password.TabIndex = 8;
            txt_Password.Leave += txt_Password_Leave;
            // 
            // lbl_Confirm_Pass
            // 
            lbl_Confirm_Pass.AutoSize = true;
            lbl_Confirm_Pass.Location = new Point(58, 435);
            lbl_Confirm_Pass.Name = "lbl_Confirm_Pass";
            lbl_Confirm_Pass.Size = new Size(135, 20);
            lbl_Confirm_Pass.TabIndex = 9;
            lbl_Confirm_Pass.Text = "Nhập Lại Mật Khẩu";
            // 
            // txt_Confirm_Pass
            // 
            txt_Confirm_Pass.Location = new Point(58, 458);
            txt_Confirm_Pass.Name = "txt_Confirm_Pass";
            txt_Confirm_Pass.PasswordChar = '*';
            txt_Confirm_Pass.Size = new Size(340, 27);
            txt_Confirm_Pass.TabIndex = 10;
            // 
            // btn_SignUp
            // 
            btn_SignUp.Location = new Point(162, 541);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(134, 39);
            btn_SignUp.TabIndex = 11;
            btn_SignUp.Text = "Đăng Ký";
            btn_SignUp.UseVisualStyleBackColor = true;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // frm_SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 655);
            Controls.Add(btn_SignUp);
            Controls.Add(txt_Confirm_Pass);
            Controls.Add(lbl_Confirm_Pass);
            Controls.Add(txt_Password);
            Controls.Add(lbl_Password);
            Controls.Add(txt_Phone);
            Controls.Add(lbl_Phone);
            Controls.Add(txt_Email);
            Controls.Add(lbl_Email);
            Controls.Add(txt_Username);
            Controls.Add(lbl_Username);
            Controls.Add(lbl_SignUp);
            Name = "frm_SignUp";
            Text = "SignUp Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_SignUp;
        private Label lbl_Username;
        private TextBox txt_Username;
        private Label lbl_Email;
        private TextBox txt_Email;
        private Label lbl_Phone;
        private TextBox txt_Phone;
        private Label lbl_Password;
        private TextBox txt_Password;
        private Label lbl_Confirm_Pass;
        private TextBox txt_Confirm_Pass;
        private Button btn_SignUp;
    }
}