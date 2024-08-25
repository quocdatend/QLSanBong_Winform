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

namespace QLSanBong.GUI.Admins
{
    public partial class frm_FoodDrinkBox : Form
    {
        private readonly OrderFoodDrinkDetailBus _orderFoodDrinkDetailBus = new OrderFoodDrinkDetailBus();
        private readonly OrderFoodDrinkBus _orderFoodDrinkBus = new OrderFoodDrinkBus(); 
        private readonly FoodDrinkBus _foodDrinkBus = new FoodDrinkBus();
        private readonly PaymentHistory _paymentHistory;
        public frm_FoodDrinkBox(PaymentHistory pa)
        {
            InitializeComponent();
            _paymentHistory = pa;
            AddColumnToDGV();
        }

        private void AddColumnToDGV()
        {
            dgvShowFoodDrink.Columns.Add("Column1", "Stt");
            dgvShowFoodDrink.Columns.Add("Column2", "Name");
            dgvShowFoodDrink.Columns.Add("Column3", "Count");
            dgvShowFoodDrink.Columns.Add("Column4", "Price");
            UpdateDataInDGV();
        }

        private void UpdateDataInDGV()
        {
            OrderFoodDrink orderFoodDrink = _orderFoodDrinkBus.GetById((int)_paymentHistory.OrderFoodDrinkId).FirstOrDefault();
            List<OrderFoodDrinkDetail> orderFoodDrinkDetails = _orderFoodDrinkDetailBus.GetByOrderFoodDrinkId(orderFoodDrink.Id);
            int i = 0;
            foreach (OrderFoodDrinkDetail item in orderFoodDrinkDetails)
            {
                i++;
                FoodDrink foodDrink = _foodDrinkBus.GetById(item.FoodDrinkId).FirstOrDefault();
                dgvShowFoodDrink.Rows.Add(i, foodDrink.Name, foodDrink.Count, foodDrink.Price);
            }
        }
    }
}
