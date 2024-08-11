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
        private Form activeForm = null;
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

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(childForm);
            panel_Show.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void smi_drinks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Drinks());
        }

        private void smi_Pitch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Pitch());
        }

        private void smi_orderPitch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_OrderPitch());
        }

        private void smi_orderDrinks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_OrderDrinks());
        }

        private void smi_Payment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Payments());
        }

        private void smi_info_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Account());
        }
    }
}
