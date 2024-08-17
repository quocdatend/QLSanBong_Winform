﻿using QLSanBong.BUS;
using QLSanBong.GUI.Login;
using QLSanBong.GUI.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong.GUI.Admins
{
    public partial class frm_Admin : Form
    {
        private SessionBus _sessionBus;
        private frm_Login frm_Login;
        private Form activeForm = null;
        public frm_Admin()
        {
            InitializeComponent();
        }

        public frm_Admin(frm_Login frm, SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            frm_Login = frm;
            OpenChildForm(new frm_AccountUsers(_sessionBus));
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
            panel_show.Controls.Add(childForm);
            panel_show.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AccountUsers(_sessionBus));
        }

        private void OrderPitchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TypePitchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PricePerHourToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void OrderFoodDrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FoodDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AccontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
