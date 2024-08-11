namespace QLSanBong.GUI.Users
{
    partial class frm_Account
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnSubmit = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 117);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 176);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(596, 117);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 176);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Email :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(266, 111);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(266, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(214, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(659, 114);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(214, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(659, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 27);
            txtEmail.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(467, 265);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 421);
            label5.Name = "label5";
            label5.Size = new Size(921, 20);
            label5.TabIndex = 9;
            label5.Text = "Note: Nếu bạn muốn thay đổi mật khẩu, vui lòng thoát ra ngoài để sử dụng tính năng \"Quên mật khẩu\" để chúng tôi có thể biết đó là bạn!";
            // 
            // frm_Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(label5);
            Controls.Add(btnSubmit);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_Account";
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnSubmit;
        private Label label5;
    }
}