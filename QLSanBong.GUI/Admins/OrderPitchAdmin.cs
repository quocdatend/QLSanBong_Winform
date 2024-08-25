using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class frm_OrderPitchAdmin : Form
    {
        private readonly OrderFoodDrinkDetailBus _orderFoodDrinkDetailBus = new OrderFoodDrinkDetailBus();
        private readonly OrderFoodDrinkBus _orderFoodDrinkBus = new OrderFoodDrinkBus();
        private readonly PaymentHistoryBus _paymentHistoryBus = new PaymentHistoryBus();
        private readonly PricePerHourBus _pricePerHourBus = new PricePerHourBus();
        private readonly OrderPitchBus _orderPitchBus = new OrderPitchBus();
        private readonly TypePitchBus _typePitchBus = new TypePitchBus();
        private readonly UserBus _userBus = new UserBus();
        private readonly PitchBus _pitchBus = new PitchBus();
        private readonly SessionBus _sessionBus;
        private int rowIndex = -1;
        public frm_OrderPitchAdmin()
        {
            InitializeComponent();
        }

        public frm_OrderPitchAdmin(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            AddColumnToDGV();
            LoadDataToCB();
        }

        private void AddColumnToDGV()
        {
            dgvShowOrderPitch.Columns.Add("Column1", "Stt");
            dgvShowOrderPitch.Columns.Add("Column2", "Username");
            dgvShowOrderPitch.Columns.Add("Column3", "Name Pitch");
            dgvShowOrderPitch.Columns.Add("Column4", "Type Pitch");
            dgvShowOrderPitch.Columns.Add("Column5", "Price Pitch");
            dgvShowOrderPitch.Columns.Add("Column6", "Time Start");
            dgvShowOrderPitch.Columns.Add("Column7", "Time End");
            dgvShowOrderPitch.Columns.Add("Column8", "Price Per Time");
            dgvShowOrderPitch.Columns.Add("Column9", "Check");
        }

        private void LoaDataToDGV()
        {
            dgvShowOrderPitch.Rows.Clear();
            UpdateDataGridView();
        }

        private void LoadDataToCB()
        {
            // Điền dữ liệu vào ComboBox
            DateTime currentDate = DateTime.Now.Date;
            for (int i = 0; i < 7; i++)
            {
                DateTime date = currentDate.AddDays(i);
                cbTime.Items.Add(date.ToString("dd/MM/yyyy"));
            }

            // Chọn ngày hiện tại trong ComboBoxs
            cbTime.SelectedIndex = 0;
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
            rowIndex = -1;
        }

        private void UpdateDataGridView()
        {
            dgvShowOrderPitch.Rows.Clear();

            DateTime currentTime = DateTime.ParseExact(cbTime.SelectedItem.ToString(), "dd/MM/yyyy", null);
            List<OrderPitch> orders = _orderPitchBus.GetByDay(currentTime);
            orders = orders.Where(x => x.IsCancel is false).ToList();
            int i = 0;
            foreach (OrderPitch order in orders)
            {
                i++;
                User user = _userBus.GetById(order.UserId).FirstOrDefault();
                Pitch pitch = _pitchBus.GetById(order.PitchId).FirstOrDefault();
                TypePitch typePitch = _typePitchBus.GetById(pitch.TypePitchId).FirstOrDefault();
                PricePerHour pricePerHour = _pricePerHourBus.GetById(order.PricePerHourId).FirstOrDefault();
                string check = "Chưa xác nhận";
                if (order.IsCheck != null && order.IsCheck is true)
                {
                    check = "Đã xác nhận";
                }
                dgvShowOrderPitch.Rows.Add(i, user.Username, pitch.Name, typePitch.Name, typePitch.Price, order.TimeStart, order.TimeEnd, pricePerHour.Price, check);
            }

        }

        private void dgvShowOrderPitch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thay đổi", "Thông Báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    DateTime timeStart = DateTime.ParseExact(dgvShowOrderPitch.Rows[rowIndex].Cells["Column6"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null);
                    DateTime timeEnd = DateTime.ParseExact(dgvShowOrderPitch.Rows[rowIndex].Cells["Column7"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null);
                    OrderPitch orderPitch = _orderPitchBus.GetByDateTime(timeStart, timeEnd).FirstOrDefault();
                    orderPitch.IsCheck = true;
                    _orderPitchBus.ChangeCheck(orderPitch);
                    DateTime currentTime = DateTime.Now;
                    PricePerHour pricePerHour = _pricePerHourBus.GetById(orderPitch.PricePerHourId).FirstOrDefault();
                    User user = _userBus.GetById(orderPitch.UserId).FirstOrDefault();
                    List<OrderFoodDrink> orderFoodDrinks = _orderFoodDrinkBus.GetByUserId(user.Id);
                    OrderFoodDrink orderFoodDrink = orderFoodDrinks.Where(x => DateTime.ParseExact(x.Time.ToString("hh/MM/yyyy"), "hh/MM/yyyy", null) == DateTime.ParseExact(DateTime.Now.ToString("hh/MM/yyyy"), "hh/MM/yyyy", null)).LastOrDefault();
                    List<OrderFoodDrinkDetail> orderFoodDrinkDetail = null;
                    float totalPrice = (float)orderPitch.Price + (float)pricePerHour.Price;
                    if (orderFoodDrink != null)
                    {
                        orderFoodDrinkDetail = _orderFoodDrinkDetailBus.GetByOrderFoodDrinkId(orderFoodDrink.Id);
                        foreach (OrderFoodDrinkDetail item in orderFoodDrinkDetail)
                        {
                            totalPrice += (float)item.Price * (int)item.Count;
                        }
                    }
                    PaymentHistory paymentHistory = new PaymentHistory()
                    {
                        UserId = user.Id,
                        Time = currentTime,
                        OrderPitchId = orderPitch.Id,
                        OrderFoodDrinkId = null,
                        IsCheck = false,
                        Price = totalPrice,
                    };
                    _paymentHistoryBus.Add(paymentHistory);
                    MessageBox.Show("Thay đổi thành công", "Thông Báo");
                    LoaDataToDGV();
                }
                rowIndex = -1;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thay đổi", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DateTime timeStart = DateTime.ParseExact(dgvShowOrderPitch.Rows[rowIndex].Cells["Column6"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null);
                    DateTime timeEnd = DateTime.ParseExact(dgvShowOrderPitch.Rows[rowIndex].Cells["Column7"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null);
                    OrderPitch orderPitch = _orderPitchBus.GetByDateTime(timeStart, timeEnd).FirstOrDefault();
                    orderPitch.IsCancel = true;
                    _orderPitchBus.ChangeCancel(orderPitch);
                    MessageBox.Show("Thay đổi thành công", "Thông Báo");
                    LoaDataToDGV();
                }
                rowIndex = -1;
            }
        }
    }
}
