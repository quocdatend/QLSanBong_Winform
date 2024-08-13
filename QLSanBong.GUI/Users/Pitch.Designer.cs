namespace QLSanBong.GUI.Users
{
    partial class frm_Pitch
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
            dgvPitch = new DataGridView();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            rb_san7 = new RadioButton();
            rb_san5 = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvPitch).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPitch
            // 
            dgvPitch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dgvPitch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPitch.Location = new Point(12, 46);
            dgvPitch.Name = "dgvPitch";
            dgvPitch.RowHeadersWidth = 51;
            dgvPitch.Size = new Size(704, 392);
            dgvPitch.TabIndex = 0;
            dgvPitch.RowHeaderMouseClick += dgvPitch_RowHeaderMouseClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(839, 146);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_san7);
            groupBox1.Controls.Add(rb_san5);
            groupBox1.Location = new Point(772, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 102);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // rb_san7
            // 
            rb_san7.AutoSize = true;
            rb_san7.Location = new Point(124, 40);
            rb_san7.Name = "rb_san7";
            rb_san7.Size = new Size(66, 24);
            rb_san7.TabIndex = 1;
            rb_san7.TabStop = true;
            rb_san7.Text = "Sân 7";
            rb_san7.UseVisualStyleBackColor = true;
            // 
            // rb_san5
            // 
            rb_san5.AutoSize = true;
            rb_san5.Location = new Point(35, 40);
            rb_san5.Name = "rb_san5";
            rb_san5.Size = new Size(66, 24);
            rb_san5.TabIndex = 0;
            rb_san5.TabStop = true;
            rb_san5.Text = "Sân 5";
            rb_san5.UseVisualStyleBackColor = true;
            // 
            // frm_Pitch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Controls.Add(dgvPitch);
            Name = "frm_Pitch";
            Text = "Pitch";
            ((System.ComponentModel.ISupportInitialize)dgvPitch).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPitch;
        private Button btnAdd;
        private GroupBox groupBox1;
        private RadioButton rb_san7;
        private RadioButton rb_san5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}