using QLSanBong.BUS;
using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong.GUI.Admins
{
    public partial class frm_PaymentAdmin : Form
    {
        private readonly OrderFoodDrinkDetailBus _orderFoodDrinkDetailBus = new OrderFoodDrinkDetailBus();
        private readonly OrderFoodDrinkBus _orderFoodDrinkBus = new OrderFoodDrinkBus();
        private readonly PaymentHistoryBus _paymentHistoryBus = new PaymentHistoryBus();
        private readonly UserBus _userBus = new UserBus();
        private readonly SessionBus _sessionBus;
        private int rowIndex = -1;
        public frm_PaymentAdmin()
        {
            InitializeComponent();
        }

        public frm_PaymentAdmin(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            AddColumnToDGV();
            LoadDataInCB();
        }

        private void LoadDataInCB()
        {
            DateTime currenTime = DateTime.Now;
            DateTime previous_week = currenTime.AddDays(-7);
            for (int i = 0; i < 14; i++)
            {
                cbTime.Items.Add(previous_week.AddDays(i).ToString("dd/MM/yyyy"));
            }
            cbTime.SelectedIndex = 7;
        }

        private void AddColumnToDGV()
        {
            dgvShowPayment.Columns.Add("Column1", "Stt");
            dgvShowPayment.Columns.Add("Column2", "Username");
            dgvShowPayment.Columns.Add("Column3", "Time");
            dgvShowPayment.Columns.Add("Column4", "Price");
            dgvShowPayment.Columns.Add("Column5", "Check");
            UpdateDataInDGV();
        }

        private void UpdateDataInDGV()
        {
            List<PaymentHistory> paymentHistories = _paymentHistoryBus.GetAll();
            int i = 0;
            foreach (PaymentHistory item in paymentHistories)
            {
                i++;
                User user = _userBus.GetById(item.UserId).FirstOrDefault();
                string check = "Chưa Thanh toán";
                if (item.IsCheck != null && item.IsCheck is true) check = "Đã Thanh Toán";
                dgvShowPayment.Rows.Add(i, user.Username, item.Time, item.Price, check);
            }
        }

        private void btnPitch_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn", "Thông Báo");
            }
            else
            {
                PaymentHistory paymentHistory = _paymentHistoryBus.GetByTime(DateTime.ParseExact(dgvShowPayment.Rows[rowIndex].Cells["Column3"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null)).FirstOrDefault();
                frm_PitchBox frm = new frm_PitchBox(paymentHistory);
                frm.ShowDialog();
            }
        }

        private void btnFoodDrink_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn", "Thông Báo");
            }
            else
            {
                PaymentHistory paymentHistory = _paymentHistoryBus.GetByTime(DateTime.ParseExact(dgvShowPayment.Rows[rowIndex].Cells["Column3"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null)).FirstOrDefault();
                frm_FoodDrinkBox frm = new frm_FoodDrinkBox(paymentHistory);
                frm.ShowDialog();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn", "Thông Báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Chắc chắn xác nhận!", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    PaymentHistory paymentHistory = _paymentHistoryBus.GetByTime(DateTime.ParseExact(dgvShowPayment.Rows[rowIndex].Cells["Column3"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null)).FirstOrDefault();
                    paymentHistory.IsCheck = true;
                    _paymentHistoryBus.Update(paymentHistory);
                    MessageBox.Show("Thay đổi thành công", "Thông Báo");
                    dgvShowPayment.Rows.Clear();
                    UpdateDataInDGV();
                    rowIndex = -1;
                }
            }
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvShowPayment.Rows.Clear();

            List<PaymentHistory> paymentHistories = _paymentHistoryBus.GetAll();
            int i = 0;
            foreach (PaymentHistory item in paymentHistories)
            {
                i++;
                User user = _userBus.GetById(item.UserId).FirstOrDefault();
                string check = "Chưa Thanh toán";
                if (item.IsCheck != null && item.IsCheck is true) check = "Đã Thanh Toán";
                dgvShowPayment.Rows.Add(i, user.Username, item.Time, item.Price, check);
            }
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn", "Thông Báo");
            }
            else
            {
                PaymentHistory paymentHistory = _paymentHistoryBus.GetByTime(DateTime.ParseExact(dgvShowPayment.Rows[rowIndex].Cells["Column3"].Value.ToString(), "dd/MM/yyyy h:mm:s tt", null)).FirstOrDefault();
                List<OrderFoodDrink> orderFoodDrinks = _orderFoodDrinkBus.GetByUserId(paymentHistory.UserId);
                OrderFoodDrink orderFoodDrink = orderFoodDrinks.Where(x => DateTime.ParseExact(x.Time.ToString("hh/MM/yyyy"), "hh/MM/yyyy", null) == DateTime.ParseExact(DateTime.Now.ToString("hh/MM/yyyy"), "hh/MM/yyyy", null)).LastOrDefault();
                List<OrderFoodDrinkDetail> orderFoodDrinkDetail = null;
                if (orderFoodDrink != null)
                {
                    orderFoodDrinkDetail = _orderFoodDrinkDetailBus.GetByOrderFoodDrinkId(orderFoodDrink.Id);
                    foreach (OrderFoodDrinkDetail item in orderFoodDrinkDetail)
                    {
                        paymentHistory.Price += (float)item.Price * (int)item.Count;
                    }
                }
                _paymentHistoryBus.Update(paymentHistory);
                MessageBox.Show("Cập nhật thành công", "Thông Báo");
                rowIndex = -1;
            }
        }

        private void dgvShowPayment_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}
