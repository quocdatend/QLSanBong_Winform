namespace QLSanBong.GUI.Admins
{
    partial class frm_PaymentAdmin
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
            dgvShowPayment = new DataGridView();
            cbTime = new ComboBox();
            btnPitch = new Button();
            btnFoodDrink = new Button();
            btnCheck = new Button();
            btnUpdatePrice = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShowPayment).BeginInit();
            SuspendLayout();
            // 
            // dgvShowPayment
            // 
            dgvShowPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowPayment.Location = new Point(12, 46);
            dgvShowPayment.Name = "dgvShowPayment";
            dgvShowPayment.RowHeadersWidth = 51;
            dgvShowPayment.Size = new Size(697, 380);
            dgvShowPayment.TabIndex = 0;
            dgvShowPayment.RowHeaderMouseClick += dgvShowPayment_RowHeaderMouseClick_1;
            // 
            // cbTime
            // 
            cbTime.FormattingEnabled = true;
            cbTime.Location = new Point(12, 12);
            cbTime.Name = "cbTime";
            cbTime.Size = new Size(1110, 28);
            cbTime.TabIndex = 1;
            cbTime.SelectedIndexChanged += cbTime_SelectedIndexChanged;
            // 
            // btnPitch
            // 
            btnPitch.Location = new Point(778, 148);
            btnPitch.Name = "btnPitch";
            btnPitch.Size = new Size(97, 33);
            btnPitch.TabIndex = 2;
            btnPitch.Text = "Pitch";
            btnPitch.UseVisualStyleBackColor = true;
            btnPitch.Click += btnPitch_Click;
            // 
            // btnFoodDrink
            // 
            btnFoodDrink.Location = new Point(968, 148);
            btnFoodDrink.Name = "btnFoodDrink";
            btnFoodDrink.Size = new Size(97, 36);
            btnFoodDrink.TabIndex = 3;
            btnFoodDrink.Text = "Food_Drink";
            btnFoodDrink.UseVisualStyleBackColor = true;
            btnFoodDrink.Click += btnFoodDrink_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(778, 258);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(97, 33);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnUpdatePrice
            // 
            btnUpdatePrice.Location = new Point(968, 258);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new Size(97, 33);
            btnUpdatePrice.TabIndex = 5;
            btnUpdatePrice.Text = "Update";
            btnUpdatePrice.UseVisualStyleBackColor = true;
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            // 
            // frm_PaymentAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 438);
            Controls.Add(btnUpdatePrice);
            Controls.Add(btnCheck);
            Controls.Add(btnFoodDrink);
            Controls.Add(btnPitch);
            Controls.Add(cbTime);
            Controls.Add(dgvShowPayment);
            Name = "frm_PaymentAdmin";
            Text = "Thông tin thanh toán";
            ((System.ComponentModel.ISupportInitialize)dgvShowPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvShowPayment;
        private ComboBox cbTime;
        private Button btnPitch;
        private Button btnFoodDrink;
        private Button btnCheck;
        private Button btnUpdatePrice;
    }
}