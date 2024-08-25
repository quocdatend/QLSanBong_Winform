namespace QLSanBong.GUI.Admins
{
    partial class frm_FoodDrinkAdmin
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
            txtName = new TextBox();
            txtCount = new TextBox();
            txtPrice = new TextBox();
            txtUrlImg = new TextBox();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpload = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShowFoodDrink).BeginInit();
            SuspendLayout();
            // 
            // dgvShowFoodDrink
            // 
            dgvShowFoodDrink.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowFoodDrink.Location = new Point(12, 12);
            dgvShowFoodDrink.Name = "dgvShowFoodDrink";
            dgvShowFoodDrink.RowHeadersWidth = 51;
            dgvShowFoodDrink.Size = new Size(671, 414);
            dgvShowFoodDrink.TabIndex = 0;
            dgvShowFoodDrink.RowHeaderMouseClick += dgvShowFoodDrink_RowHeaderMouseClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(747, 55);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(317, 27);
            txtName.TabIndex = 1;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(747, 124);
            txtCount.Name = "txtCount";
            txtCount.PlaceholderText = "Count";
            txtCount.Size = new Size(317, 27);
            txtCount.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(747, 198);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(317, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtUrlImg
            // 
            txtUrlImg.Location = new Point(856, 272);
            txtUrlImg.Name = "txtUrlImg";
            txtUrlImg.ReadOnly = true;
            txtUrlImg.Size = new Size(208, 27);
            txtUrlImg.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(715, 359);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(856, 359);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 31);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(998, 361);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(747, 272);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(91, 27);
            btnUpload.TabIndex = 8;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // frm_FoodDrinkAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 438);
            Controls.Add(btnUpload);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(txtUrlImg);
            Controls.Add(txtPrice);
            Controls.Add(txtCount);
            Controls.Add(txtName);
            Controls.Add(dgvShowFoodDrink);
            Name = "frm_FoodDrinkAdmin";
            Text = "Thông tin Đồ Ăn_Uống";
            ((System.ComponentModel.ISupportInitialize)dgvShowFoodDrink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowFoodDrink;
        private TextBox txtName;
        private TextBox txtCount;
        private TextBox txtPrice;
        private TextBox txtUrlImg;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpload;
    }
}