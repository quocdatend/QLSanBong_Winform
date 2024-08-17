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

namespace QLSanBong.GUI.Users
{
    public partial class frm_OrderDrinks : Form
    {
        private readonly FoodDrinkBus _foodDrinkBus = new FoodDrinkBus();
        private readonly OrderFoodDrinkDetailBus _orderFoodDrinkDetailBus = new OrderFoodDrinkDetailBus();
        private readonly OrderFoodDrinkBus _orderFoodDrinkBus = new OrderFoodDrinkBus();
        private readonly SessionBus _sessionBus;
        public frm_OrderDrinks()
        {
            InitializeComponent();
        }

        public frm_OrderDrinks(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            ShowOrderDrinkFoods();
        }

        private void ShowOrderDrinkFoods()
        {
            dgvShowTimeOrder.Columns.Add("Column1", "Stt");
            dgvShowTimeOrder.Columns.Add("Column2", "Thời gian");

            List<OrderFoodDrink> orderFoodDrinks = _orderFoodDrinkBus.GetByUserId(_sessionBus.Session.Id);
            int i = 0;
            foreach (OrderFoodDrink item in orderFoodDrinks)
            {
                i++;
                dgvShowTimeOrder.Rows.Add(i, item.Time);
            }

            dgvShowOrderDetail.Columns.Add("Column1", "Stt");
            dgvShowOrderDetail.Columns.Add("Column2", "Tên");
            dgvShowOrderDetail.Columns.Add("Column3", "Số lượng");
            dgvShowOrderDetail.Columns.Add("Column4", "Giá tiền");

        }

        private void dgvShowTimeOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DateTime time = DateTime.ParseExact((string)dgvShowTimeOrder.Rows[e.RowIndex].Cells[columnName: "Column2"].Value, "dd/MM/yyyy HH:mm", null);
            List<OrderFoodDrink> orderFoodDrinks = _orderFoodDrinkBus.GetByTime(time);
            List<OrderFoodDrinkDetail> orderFoodDrinkDetails = _orderFoodDrinkDetailBus.GetByOrderFoodDrinkId(orderFoodDrinks.FirstOrDefault().Id);
            List<FoodDrink> foodDrinks = _foodDrinkBus.GetAll();
            int i = 0;
            foreach (OrderFoodDrinkDetail item in orderFoodDrinkDetails)
            {
                string name = "null";
                i++;
                foreach (FoodDrink item1 in foodDrinks)
                {
                    if(item.FoodDrinkId == item1.Id) name = item1.Name;
                }
                dgvShowOrderDetail.Rows.Add(i, name, item.Count, item.Price);
            }
        }
    }
}
