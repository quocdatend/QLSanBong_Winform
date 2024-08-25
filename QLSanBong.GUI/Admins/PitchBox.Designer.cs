namespace QLSanBong.GUI.Admins
{
    partial class frm_PitchBox
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
            ((System.ComponentModel.ISupportInitialize)dgvShowPitch).BeginInit();
            SuspendLayout();
            // 
            // dgvShowPitch
            // 
            dgvShowPitch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowPitch.Location = new Point(12, 12);
            dgvShowPitch.Name = "dgvShowPitch";
            dgvShowPitch.RowHeadersWidth = 51;
            dgvShowPitch.Size = new Size(776, 426);
            dgvShowPitch.TabIndex = 0;
            // 
            // frm_PitchBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvShowPitch);
            Name = "frm_PitchBox";
            Text = "Thông tin sân đặt";
            ((System.ComponentModel.ISupportInitialize)dgvShowPitch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvShowPitch;
    }
}