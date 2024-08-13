using QLSanBong.BUS;
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
    public partial class frm_Drinks : Form
    {
        private readonly SessionBus _sessionBus = new SessionBus();
        public frm_Drinks()
        {
            InitializeComponent();
        }

        public frm_Drinks(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
        }

        private void ShowDrinkFoods()
        {

        }
    }
}
