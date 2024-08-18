namespace QLSanBong.GUI.Users
{
    partial class frm_OrderPitch
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
            dgvOrderPitch = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderPitch).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderPitch
            // 
            dgvOrderPitch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderPitch.Location = new Point(12, 12);
            dgvOrderPitch.Name = "dgvOrderPitch";
            dgvOrderPitch.RowHeadersWidth = 51;
            dgvOrderPitch.Size = new Size(743, 426);
            dgvOrderPitch.TabIndex = 0;
            dgvOrderPitch.RowHeaderMouseClick += dgvOrderPitch_RowHeaderMouseClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(842, 205);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 37);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // frm_OrderPitch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(btnDelete);
            Controls.Add(dgvOrderPitch);
            Name = "frm_OrderPitch";
            Text = "Order Pitch";
            ((System.ComponentModel.ISupportInitialize)dgvOrderPitch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrderPitch;
        private Button btnDelete;
    }
}