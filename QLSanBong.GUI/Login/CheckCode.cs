using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong.GUI.Login
{
    public partial class frm_CheckCode : Form
    {
        private string email, code;
        private bool isAdmin;
        public frm_CheckCode()
        {
            InitializeComponent();
        }
        public frm_CheckCode(string e, bool isa, string c)
        {
            InitializeComponent();
            email = e;
            code = c;
            isAdmin = isa;
        }

        private void btn_CheckCode_Click(object sender, EventArgs e)
        {
            // so sánh code
            if(!txt_Code.Text.Equals(code))
            {
                MessageBox.Show("Code không đúng, vui lòng nhập lại!", "Thông Báo");
            } else
            {
                Form frm_ChangePass = new frm_ChangePassword(email, isAdmin);
                frm_ChangePass.ShowDialog();
                this.Close();
            }
        }
    }
}
