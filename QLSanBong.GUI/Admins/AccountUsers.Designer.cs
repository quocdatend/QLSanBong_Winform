namespace QLSanBong.GUI.Admins
{
    partial class frm_AccountUsers
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
            dgvShowUsers = new DataGridView();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShowUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvShowUsers
            // 
            dgvShowUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowUsers.Location = new Point(12, 12);
            dgvShowUsers.Name = "dgvShowUsers";
            dgvShowUsers.RowHeadersWidth = 51;
            dgvShowUsers.Size = new Size(755, 414);
            dgvShowUsers.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(807, 67);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(289, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(807, 135);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Password";
            txtPass.Size = new Size(289, 27);
            txtPass.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(807, 203);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(288, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(807, 278);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(289, 27);
            txtEmail.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(891, 350);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 38);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frm_AccountUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 438);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(dgvShowUsers);
            Name = "frm_AccountUsers";
            Text = "Tài Khoản Users";
            ((System.ComponentModel.ISupportInitialize)dgvShowUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowUsers;
        private TextBox txtUsername;
        private TextBox txtPass;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnAdd;
    }
}