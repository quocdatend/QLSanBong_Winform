namespace QLSanBong.GUI.Admins
{
    partial class frm_TypePitch
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
            dgvShowTypePitch = new DataGridView();
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShowTypePitch).BeginInit();
            SuspendLayout();
            // 
            // dgvShowTypePitch
            // 
            dgvShowTypePitch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowTypePitch.Location = new Point(12, 12);
            dgvShowTypePitch.Name = "dgvShowTypePitch";
            dgvShowTypePitch.RowHeadersWidth = 51;
            dgvShowTypePitch.Size = new Size(640, 414);
            dgvShowTypePitch.TabIndex = 0;
            dgvShowTypePitch.RowHeaderMouseClick += dgvShowTypePitch_RowHeaderMouseClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(753, 107);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(277, 27);
            txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(753, 208);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(277, 27);
            txtPrice.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(707, 342);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(860, 342);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1005, 342);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frm_TypePitch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 438);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(dgvShowTypePitch);
            Name = "frm_TypePitch";
            Text = "TypePitch";
            ((System.ComponentModel.ISupportInitialize)dgvShowTypePitch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowTypePitch;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
    }
}