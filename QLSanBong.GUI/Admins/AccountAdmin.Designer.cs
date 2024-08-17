namespace QLSanBong.GUI.Admins
{
    partial class frm_AccountAdmin
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
            txtName = new TextBox();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            btnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            Email = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(445, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 27);
            txtName.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(445, 142);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.ReadOnly = true;
            txtPass.Size = new Size(248, 27);
            txtPass.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(445, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 27);
            txtEmail.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(527, 295);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(85, 31);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(445, 50);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 119);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(445, 190);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 6;
            Email.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 409);
            label3.Name = "label3";
            label3.Size = new Size(921, 20);
            label3.TabIndex = 7;
            label3.Text = "Note: Nếu bạn muốn thay đổi mật khẩu, vui lòng thoát ra ngoài để sử dụng tính năng \"Quên mật khẩu\" để chúng tôi có thể biết đó là bạn!";
            // 
            // frm_AccountAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 438);
            Controls.Add(label3);
            Controls.Add(Email);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(txtEmail);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Name = "frm_AccountAdmin";
            Text = "Tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPass;
        private TextBox txtEmail;
        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private Label Email;
        private Label label3;
    }
}