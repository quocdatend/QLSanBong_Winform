namespace QLSanBong.GUI.Login
{
    partial class frm_CheckCode
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
            lbl_CheckCode = new Label();
            txt_Code = new TextBox();
            btn_CheckCode = new Button();
            SuspendLayout();
            // 
            // lbl_CheckCode
            // 
            lbl_CheckCode.AutoSize = true;
            lbl_CheckCode.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CheckCode.Location = new Point(71, 36);
            lbl_CheckCode.Name = "lbl_CheckCode";
            lbl_CheckCode.Size = new Size(167, 31);
            lbl_CheckCode.TabIndex = 0;
            lbl_CheckCode.Text = "Kiểm Tra Code";
            // 
            // txt_Code
            // 
            txt_Code.Location = new Point(71, 121);
            txt_Code.MaxLength = 5;
            txt_Code.Name = "txt_Code";
            txt_Code.Size = new Size(167, 27);
            txt_Code.TabIndex = 1;
            txt_Code.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_CheckCode
            // 
            btn_CheckCode.Location = new Point(98, 194);
            btn_CheckCode.Name = "btn_CheckCode";
            btn_CheckCode.Size = new Size(112, 40);
            btn_CheckCode.TabIndex = 2;
            btn_CheckCode.Text = "Kiểm Tra";
            btn_CheckCode.UseVisualStyleBackColor = true;
            btn_CheckCode.Click += btn_CheckCode_Click;
            // 
            // frm_CheckCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 293);
            Controls.Add(btn_CheckCode);
            Controls.Add(txt_Code);
            Controls.Add(lbl_CheckCode);
            Name = "frm_CheckCode";
            Text = "Check Code Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_CheckCode;
        private TextBox txt_Code;
        private Button btn_CheckCode;
    }
}