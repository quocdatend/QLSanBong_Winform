namespace QLSanBong.GUI.Admins
{
    partial class frm_OrderPitchAdmin
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
            cbTime = new ComboBox();
            dgvShowOrderPitch = new DataGridView();
            btnCancel = new Button();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShowOrderPitch).BeginInit();
            SuspendLayout();
            // 
            // cbTime
            // 
            cbTime.FormattingEnabled = true;
            cbTime.Location = new Point(12, 12);
            cbTime.Name = "cbTime";
            cbTime.Size = new Size(1110, 28);
            cbTime.TabIndex = 0;
            // 
            // dgvShowOrderPitch
            // 
            dgvShowOrderPitch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowOrderPitch.Location = new Point(12, 46);
            dgvShowOrderPitch.Name = "dgvShowOrderPitch";
            dgvShowOrderPitch.RowHeadersWidth = 51;
            dgvShowOrderPitch.Size = new Size(841, 380);
            dgvShowOrderPitch.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(945, 261);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 35);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(945, 154);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(93, 35);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Đồng Ý";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frm_OrderPitchAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 438);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(dgvShowOrderPitch);
            Controls.Add(cbTime);
            Name = "frm_OrderPitchAdmin";
            Text = "Thông tin đặt sân";
            ((System.ComponentModel.ISupportInitialize)dgvShowOrderPitch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbTime;
        private DataGridView dgvShowOrderPitch;
        private Button btnCancel;
        private Button btnSubmit;
    }
}