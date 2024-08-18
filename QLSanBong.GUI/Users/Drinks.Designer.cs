namespace QLSanBong.GUI.Users
{
    partial class frm_Drinks
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
            dgvDrinkFood = new DataGridView();
            dgvOrder = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnOrder = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDrinkFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvDrinkFood
            // 
            dgvDrinkFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrinkFood.Location = new Point(12, 12);
            dgvDrinkFood.Name = "dgvDrinkFood";
            dgvDrinkFood.RowHeadersWidth = 51;
            dgvDrinkFood.Size = new Size(566, 426);
            dgvDrinkFood.TabIndex = 0;
            dgvDrinkFood.RowHeaderMouseClick += dgvDrinkFood_RowHeaderMouseClick;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(584, 12);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(447, 224);
            dgvOrder.TabIndex = 1;
            dgvOrder.RowHeaderMouseClick += dgvOrder_RowHeaderMouseClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(655, 253);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 33);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(851, 253);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 33);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(851, 315);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 32);
            btnClear.TabIndex = 4;
            btnClear.Text = "Xóa Hết";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(655, 313);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(112, 34);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(606, 389);
            label1.Name = "label1";
            label1.Size = new Size(299, 20);
            label1.TabIndex = 6;
            label1.Text = "*Note: Bạn có thể chỉnh cột Số lượng Order!";
            // 
            // frm_Drinks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(label1);
            Controls.Add(btnOrder);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvOrder);
            Controls.Add(dgvDrinkFood);
            Name = "frm_Drinks";
            Text = "Drinks";
            ((System.ComponentModel.ISupportInitialize)dgvDrinkFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDrinkFood;
        private DataGridView dgvOrder;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Button btnOrder;
        private Label label1;
    }
}