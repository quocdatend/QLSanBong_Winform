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
    public partial class frm_Payments : Form
    {
        private readonly OrderFoodDrinkDetailBus _orderFoodDrinkDetailBus = new OrderFoodDrinkDetailBus();
        private readonly PaymentHistoryBus _paymentHistoryBus = new PaymentHistoryBus();
        private readonly PricePerHourBus _pricePerHourBus = new PricePerHourBus();
        private readonly OrderPitchBus _orderPitchBus = new OrderPitchBus();
        private readonly TypePitchBus _typePitchBus = new TypePitchBus();
        private readonly FoodDrinkBus _foodDrinkBus = new FoodDrinkBus();
        private readonly PitchBus _pitchBus = new PitchBus();
        private readonly UserBus _userBus = new UserBus();
        private readonly SessionBus _sessionBus;
        public frm_Payments()
        {
            InitializeComponent();
        }

        public frm_Payments(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            ShowPayments();
        }

        private void ShowPayments()
        {
            User user = _userBus.GetByUsername(_sessionBus.Session.Name).FirstOrDefault();
            List<PaymentHistory> paymentHistories = _paymentHistoryBus.GetByUserId(user.Id);

            dgv_Payments.Columns.Add("Column1", "Stt");
            dgv_Payments.Columns.Add("Column2", "Thời gian");
            dgv_Payments.Columns.Add("Column3", "Tổng Tiền");

            int i = 0;
            foreach (PaymentHistory item in paymentHistories)
            {
                i++;
                dgv_Payments.Rows.Add(i, item.Time, item.Price);
            }

            dgvShowPitch.Columns.Add("Column1", "Thời gian bắt đầu");
            dgvShowPitch.Columns.Add("Column2", "Thời gian kết thúc");
            dgvShowPitch.Columns.Add("Column3", "Loai Sân");
            dgvShowPitch.Columns.Add("Column4", "Giá tiền");
            dgvShowPitch.Columns.Add("Column5", "Trạng thái");
            dgvShowPitch.Columns.Add("Column6", "Thannh toán");

            dgvShowFoodDrink.Columns.Add("Column1", "Stt");
            dgvShowFoodDrink.Columns.Add("Column2", "Tên");
            dgvShowFoodDrink.Columns.Add("Column3", "Số lượng");
            dgvShowFoodDrink.Columns.Add("Column4", "Giá tiền");

        }

        private void ShowOrderPitch(int id)
        {
            List<OrderPitch> orderPitches = _orderPitchBus.GetById(id);


            foreach (OrderPitch item in orderPitches)
            {
                Pitch pitch = _pitchBus.GetById(item.PitchId).FirstOrDefault();
                TypePitch typePitch = _typePitchBus.GetById(pitch.TypePitchId).FirstOrDefault();
                PricePerHour price = _pricePerHourBus.GetById(item.PricePerHourId).FirstOrDefault();
                string isCheck = "Chưa Xác Nhận";
                if (item.IsCheck != null)
                {
                    isCheck = item.IsCheck is true ? "Xong" : "Hủy";
                }
                dgvShowPitch.Rows.Add(item.TimeStart, item.TimeEnd, typePitch.Name, item.Price + price.Price, isCheck, item.IsPay ? "Rồi" : "Chưa");
            }
        }

        private void ShowOrderDrinkFoods(int id)
        {
            dgvShowFoodDrink.Rows.Clear();
            List<OrderFoodDrinkDetail> orderFoodDrinkDetails = _orderFoodDrinkDetailBus.GetByOrderFoodDrinkId(id);
            List<FoodDrink> foodDrinks = _foodDrinkBus.GetAll();
            int i = 0;
            foreach (OrderFoodDrinkDetail item in orderFoodDrinkDetails)
            {
                string name = "null";
                i++;
                foreach (FoodDrink item1 in foodDrinks)
                {
                    if (item.FoodDrinkId == item1.Id) name = item1.Name;
                }
                dgvShowFoodDrink.Rows.Add(i, name, item.Count, item.Price);
            }

        }

        private void dgv_Payments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<PaymentHistory> paymentHistory = _paymentHistoryBus.GetByTime(DateTime.ParseExact(dgv_Payments.Rows[e.RowIndex].Cells[columnName: "Column2"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null));
            ShowOrderPitch(int.Parse(paymentHistory.FirstOrDefault().OrderPitchId.ToString()));

            ShowOrderDrinkFoods(int.Parse(paymentHistory.FirstOrDefault().OrderFoodDrinkId.ToString()));
        }
    }
}
