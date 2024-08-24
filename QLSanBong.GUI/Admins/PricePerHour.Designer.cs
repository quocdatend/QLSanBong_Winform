namespace QLSanBong.GUI.Admins
{
    partial class frm_PricePerHour
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
            dgvShowPricePerHour = new DataGridView();
            cbTimeStart = new ComboBox();
            cbTimeEnd = new ComboBox();
            txtPrice = new TextBox();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShowPricePerHour).BeginInit();
            SuspendLayout();
            // 
            // dgvShowPricePerHour
            // 
            dgvShowPricePerHour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowPricePerHour.Location = new Point(12, 12);
            dgvShowPricePerHour.Name = "dgvShowPricePerHour";
            dgvShowPricePerHour.RowHeadersWidth = 51;
            dgvShowPricePerHour.Size = new Size(620, 414);
            dgvShowPricePerHour.TabIndex = 0;
            dgvShowPricePerHour.RowHeaderMouseClick += dgvShowPricePerHour_RowHeaderMouseClick;
            // 
            // cbTimeStart
            // 
            cbTimeStart.FormattingEnabled = true;
            cbTimeStart.Location = new Point(797, 57);
            cbTimeStart.Name = "cbTimeStart";
            cbTimeStart.Size = new Size(196, 28);
            cbTimeStart.TabIndex = 1;
            // 
            // cbTimeEnd
            // 
            cbTimeEnd.FormattingEnabled = true;
            cbTimeEnd.Location = new Point(797, 137);
            cbTimeEnd.Name = "cbTimeEnd";
            cbTimeEnd.Size = new Size(196, 28);
            cbTimeEnd.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(797, 219);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(196, 27);
            txtPrice.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(686, 310);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(848, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1022, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(697, 65);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 7;
            label1.Text = "Time Start:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(703, 145);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 8;
            label2.Text = "Time End:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(733, 222);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 9;
            label3.Text = "Price:";
            // 
            // frm_PricePerHour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 438);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(txtPrice);
            Controls.Add(cbTimeEnd);
            Controls.Add(cbTimeStart);
            Controls.Add(dgvShowPricePerHour);
            Name = "frm_PricePerHour";
            Text = "Giá Theo Giờ";
            ((System.ComponentModel.ISupportInitialize)dgvShowPricePerHour).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShowPricePerHour;
        private ComboBox cbTimeStart;
        private ComboBox cbTimeEnd;
        private TextBox txtPrice;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}