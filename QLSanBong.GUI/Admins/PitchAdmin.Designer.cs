namespace QLSanBong.GUI.Admins
{
    partial class frm_PitchAdmin
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
            dgvShowPitch = new DataGridView();
            txtName = new TextBox();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            cbTypePitch = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvShowPitch).BeginInit();
            SuspendLayout();
            // 
            // dgvShowPitch
            // 
            dgvShowPitch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowPitch.Location = new Point(12, 12);
            dgvShowPitch.Name = "dgvShowPitch";
            dgvShowPitch.RowHeadersWidth = 51;
            dgvShowPitch.Size = new Size(572, 414);
            dgvShowPitch.TabIndex = 0;
            dgvShowPitch.RowHeaderMouseClick += dgvShowPitch_RowHeaderMouseClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(724, 80);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(280, 27);
            txtName.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(682, 286);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(829, 286);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(971, 286);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbTypePitch
            // 
            cbTypePitch.FormattingEnabled = true;
            cbTypePitch.Location = new Point(724, 159);
            cbTypePitch.Name = "cbTypePitch";
            cbTypePitch.Size = new Size(280, 28);
            cbTypePitch.TabIndex = 5;
            // 
            // frm_PitchAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 438);
            Controls.Add(cbTypePitch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(txtName);
            Controls.Add(dgvShowPitch);
            Name = "frm_PitchAdmin";
            Text = "PitchAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvShowPitch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowPitch;
        private TextBox txtName;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
        private ComboBox cbTypePitch;
    }
}