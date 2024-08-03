using QLSanBong.GUI.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong.GUI.Users
{
    public partial class frm_User : Form
    {
        private readonly frm_Login frm_Login;
        public frm_User()
        {
            InitializeComponent();
        }
        public frm_User(frm_Login frm)
        {
            InitializeComponent();
            this.frm_Login = frm;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Thoát Không!", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                frm_Login.Show();
                this.Close();
            }
        }
    }
}
