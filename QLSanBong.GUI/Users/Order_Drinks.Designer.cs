namespace QLSanBong.GUI.Users
{
    partial class frm_OrderDrinks
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
            dgvShowTimeOrder = new DataGridView();
            dgvShowOrderDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvShowTimeOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvShowTimeOrder
            // 
            dgvShowTimeOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowTimeOrder.Location = new Point(12, 12);
            dgvShowTimeOrder.Name = "dgvShowTimeOrder";
            dgvShowTimeOrder.RowHeadersWidth = 51;
            dgvShowTimeOrder.Size = new Size(351, 426);
            dgvShowTimeOrder.TabIndex = 0;
            dgvShowTimeOrder.RowHeaderMouseClick += dgvShowTimeOrder_RowHeaderMouseClick;
            // 
            // dgvShowOrderDetail
            // 
            dgvShowOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowOrderDetail.Location = new Point(369, 12);
            dgvShowOrderDetail.Name = "dgvShowOrderDetail";
            dgvShowOrderDetail.RowHeadersWidth = 51;
            dgvShowOrderDetail.Size = new Size(662, 426);
            dgvShowOrderDetail.TabIndex = 1;
            // 
            // frm_OrderDrinks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(dgvShowOrderDetail);
            Controls.Add(dgvShowTimeOrder);
            Name = "frm_OrderDrinks";
            Text = "Order Drinks";
            ((System.ComponentModel.ISupportInitialize)dgvShowTimeOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvShowTimeOrder;
        private DataGridView dgvShowOrderDetail;
    }
}