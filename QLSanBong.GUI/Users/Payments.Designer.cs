namespace QLSanBong.GUI.Users
{
    partial class frm_Payments
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
            dgv_Payments = new DataGridView();
            dgvShowPitch = new DataGridView();
            dgvShowFoodDrink = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Payments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowPitch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowFoodDrink).BeginInit();
            SuspendLayout();
            // 
            // dgv_Payments
            // 
            dgv_Payments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Payments.Location = new Point(12, 12);
            dgv_Payments.Name = "dgv_Payments";
            dgv_Payments.RowHeadersWidth = 51;
            dgv_Payments.Size = new Size(306, 426);
            dgv_Payments.TabIndex = 0;
            dgv_Payments.RowHeaderMouseClick += dgv_Payments_RowHeaderMouseClick;
            // 
            // dgvShowPitch
            // 
            dgvShowPitch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowPitch.Location = new Point(324, 12);
            dgvShowPitch.Name = "dgvShowPitch";
            dgvShowPitch.RowHeadersWidth = 51;
            dgvShowPitch.Size = new Size(707, 168);
            dgvShowPitch.TabIndex = 1;
            // 
            // dgvShowFoodDrink
            // 
            dgvShowFoodDrink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowFoodDrink.Location = new Point(324, 186);
            dgvShowFoodDrink.Name = "dgvShowFoodDrink";
            dgvShowFoodDrink.RowHeadersWidth = 51;
            dgvShowFoodDrink.Size = new Size(707, 252);
            dgvShowFoodDrink.TabIndex = 2;
            // 
            // frm_Payments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(dgvShowFoodDrink);
            Controls.Add(dgvShowPitch);
            Controls.Add(dgv_Payments);
            Name = "frm_Payments";
            Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)dgv_Payments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowPitch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowFoodDrink).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Payments;
        private DataGridView dgvShowPitch;
        private DataGridView dgvShowFoodDrink;
    }
}