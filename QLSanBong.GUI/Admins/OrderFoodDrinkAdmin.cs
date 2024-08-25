using QLSanBong.BUS;
using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QLSanBong.GUI.Admins
{
    public partial class frm_OrderFoodDrinkAdmin : Form
    {
        private readonly OrderFoodDrinkDetailBus _orderFoodDrinkDetailBus = new OrderFoodDrinkDetailBus();
        private readonly OrderFoodDrinkBus _orderFoodDrinkBus = new OrderFoodDrinkBus();
        private readonly FoodDrinkBus _foodDrinkBus = new FoodDrinkBus();
        private readonly UserBus _userBus = new UserBus();
        private readonly SessionBus _sessionBus;
        public frm_OrderFoodDrinkAdmin()
        {
            InitializeComponent();
        }

        public frm_OrderFoodDrinkAdmin(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            AddColumnToDGV();
            LoadDataInCB();
        }



        private void AddColumnToDGV()
        {
            dgvShowOrderFoodDrink.Columns.Add("Column1", "Stt");
            dgvShowOrderFoodDrink.Columns.Add("Column2", "Username");
            dgvShowOrderFoodDrink.Columns.Add("Column3", "Time");
            UpdateDataToDGV1();

            dgvShowDetailOrderFoodDrink.Columns.Add("Column1", "Stt");
            dgvShowDetailOrderFoodDrink.Columns.Add("Column2", "Name");
            dgvShowDetailOrderFoodDrink.Columns.Add("Column3", "Count");
            dgvShowDetailOrderFoodDrink.Columns.Add("Column4", "Price");

        }

        private void UpdateDataToDGV1()
        {
            List<OrderFoodDrink> orderFoodDrinks = _orderFoodDrinkBus.GetAll();
            int i = 0;
            foreach (OrderFoodDrink item in orderFoodDrinks)
            {
                i++;
                User user = _userBus.GetById(item.UserId).FirstOrDefault();
                dgvShowOrderFoodDrink.Rows.Add(i, user.Username, item.Time);
            }
        }

        private void LoadDataInCB()
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;

            // Subtract 7 days
            DateTime sevenDaysBefore = currentDate.AddDays(-7);
            for (int i = 0; i < 14; i++)
            {
                DateTime date = sevenDaysBefore.AddDays(i);
                cbTime.Items.Add(date.ToString("dd/MM/yyyy"));
            }
            cbTime.SelectedIndex = 7;
        }

        private void dgvShowOrderFoodDrink_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvShowDetailOrderFoodDrink.Rows.Clear();
            OrderFoodDrink orderFoodDrink = _orderFoodDrinkBus.GetByTime(DateTime.ParseExact(dgvShowOrderFoodDrink.Rows[e.RowIndex].Cells["Column3"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null)).FirstOrDefault();
            List<OrderFoodDrinkDetail> orderFoodDrinkDetails = _orderFoodDrinkDetailBus.GetByOrderFoodDrinkId(orderFoodDrink.Id);

            int i = 0;
            foreach (OrderFoodDrinkDetail item in orderFoodDrinkDetails)
            {
                i++;
                FoodDrink foodDrink = _foodDrinkBus.GetById(item.Id).FirstOrDefault();
                dgvShowDetailOrderFoodDrink.Rows.Add(i, foodDrink.Name, item.Count, item.Count);
            }
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvShowOrderFoodDrink.Rows.Clear();
            dgvShowDetailOrderFoodDrink.Rows.Clear();

            List<OrderFoodDrink> orderFoodDrink = _orderFoodDrinkBus.GetByDay(DateTime.ParseExact(cbTime.Text.ToString(), "dd/MM/yyyy", null));
            int i = 0;
            foreach (OrderFoodDrink item in orderFoodDrink)
            {
                i++;
                User user = _userBus.GetById(item.UserId).FirstOrDefault();
                dgvShowOrderFoodDrink.Rows.Add(i, user.Username, item.Time);
            }
        }
    }
}
