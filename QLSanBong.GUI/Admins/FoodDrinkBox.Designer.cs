namespace QLSanBong.GUI.Admins
{
    partial class frm_FoodDrinkBox
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
            dgvShowFoodDrink = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvShowFoodDrink).BeginInit();
            SuspendLayout();
            // 
            // dgvShowFoodDrink
            // 
            dgvShowFoodDrink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowFoodDrink.Location = new Point(12, 12);
            dgvShowFoodDrink.Name = "dgvShowFoodDrink";
            dgvShowFoodDrink.RowHeadersWidth = 51;
            dgvShowFoodDrink.Size = new Size(776, 426);
            dgvShowFoodDrink.TabIndex = 0;
            // 
            // frm_FoodDrinkBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvShowFoodDrink);
            Name = "frm_FoodDrinkBox";
            Text = "Thông tin đồ ăn_Uống đặt";
            ((System.ComponentModel.ISupportInitialize)dgvShowFoodDrink).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvShowFoodDrink;
    }
}