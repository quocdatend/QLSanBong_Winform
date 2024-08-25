namespace QLSanBong.GUI.Admins
{
    partial class frm_OrderFoodDrinkAdmin
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
            dgvShowOrderFoodDrink = new DataGridView();
            dgvShowDetailOrderFoodDrink = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvShowOrderFoodDrink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowDetailOrderFoodDrink).BeginInit();
            SuspendLayout();
            // 
            // cbTime
            // 
            cbTime.FormattingEnabled = true;
            cbTime.Location = new Point(12, 12);
            cbTime.Name = "cbTime";
            cbTime.Size = new Size(1110, 28);
            cbTime.TabIndex = 0;
            cbTime.SelectedIndexChanged += cbTime_SelectedIndexChanged;
            // 
            // dgvShowOrderFoodDrink
            // 
            dgvShowOrderFoodDrink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowOrderFoodDrink.Location = new Point(12, 46);
            dgvShowOrderFoodDrink.Name = "dgvShowOrderFoodDrink";
            dgvShowOrderFoodDrink.RowHeadersWidth = 51;
            dgvShowOrderFoodDrink.Size = new Size(398, 380);
            dgvShowOrderFoodDrink.TabIndex = 1;
            dgvShowOrderFoodDrink.RowHeaderMouseClick += dgvShowOrderFoodDrink_RowHeaderMouseClick;
            // 
            // dgvShowDetailOrderFoodDrink
            // 
            dgvShowDetailOrderFoodDrink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowDetailOrderFoodDrink.Location = new Point(416, 46);
            dgvShowDetailOrderFoodDrink.Name = "dgvShowDetailOrderFoodDrink";
            dgvShowDetailOrderFoodDrink.RowHeadersWidth = 51;
            dgvShowDetailOrderFoodDrink.Size = new Size(706, 380);
            dgvShowDetailOrderFoodDrink.TabIndex = 2;
            // 
            // frm_OrderFoodDrinkAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 438);
            Controls.Add(dgvShowDetailOrderFoodDrink);
            Controls.Add(dgvShowOrderFoodDrink);
            Controls.Add(cbTime);
            Name = "frm_OrderFoodDrinkAdmin";
            Text = "Thông tin Đặt đồ Ăn_Uống";
            ((System.ComponentModel.ISupportInitialize)dgvShowOrderFoodDrink).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowDetailOrderFoodDrink).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbTime;
        private DataGridView dgvShowOrderFoodDrink;
        private DataGridView dgvShowDetailOrderFoodDrink;
    }
}