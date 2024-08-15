using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QLSanBong.BUS;
using QLSanBong.DAL.Models;
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
    public partial class frm_Pitch : Form
    {
        private readonly PricePerHourBus _pricePerHourBus = new PricePerHourBus();
        private readonly OrderPitchBus _orderPitchBus = new OrderPitchBus();
        private readonly UserBus _userBus = new UserBus();
        private readonly TypePitchBus _typePitchBus = new TypePitchBus();
        private readonly PitchBus _pitchBus = new PitchBus();
        private SessionBus _sessionBus;
        private ComboBox comboBoxDate;
        private int rowclick = -1;

        public frm_Pitch()
        {
            InitializeComponent();
            SetupControls();
        }

        public frm_Pitch(SessionBus se)
        {
            InitializeComponent();
            SetupControls();
            this._sessionBus = se;
        }

        private void SetupControls()
        {
            // Tạo ComboBox
            comboBoxDate = new ComboBox();
            comboBoxDate.Dock = DockStyle.Top;
            comboBoxDate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDate.SelectedIndexChanged += ComboBoxDate_SelectedIndexChanged;
            this.Controls.Add(comboBoxDate);

            // Thêm các cột vào DataGridView
            dgvPitch.Columns.Add("Column1", "Thời gian bắt đầu");
            dgvPitch.Columns.Add("Column2", "Thời gian kết thúc");
            dgvPitch.Columns.Add("Column3", "Sân 5");
            dgvPitch.Columns.Add("Column4", "Sân 7");

            // Điền dữ liệu vào ComboBox
            DateTime currentDate = DateTime.Now.Date;
            for (int i = 0; i < 7; i++)
            {
                DateTime date = currentDate.AddDays(i);
                comboBoxDate.Items.Add(date.ToString("dd/MM/yyyy"));
            }

            // Chọn ngày hiện tại trong ComboBoxs
            comboBoxDate.SelectedIndex = 0;
        }

        private void ComboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dgvPitch.Rows.Clear();
            List<TypePitch> getSan5 = _typePitchBus.GetByName("Sân 5");
            List<TypePitch> getSan7 = _typePitchBus.GetByName("Sân 7");
            List<Pitch> getByIdSan5 = _pitchBus.GetByPitchId(getSan5.FirstOrDefault().Id);
            List<Pitch> getByIdSan7 = _pitchBus.GetByPitchId(getSan7.FirstOrDefault().Id);
            string countSan5 = getByIdSan5.Count() == 0 ? "Hết" : (getSan5.Count()).ToString();
            string countSan7 = getByIdSan7.Count() == 0 ? "Hết" : (getSan7.Count()).ToString();

            if (comboBoxDate.SelectedItem == null) return;

            DateTime selectedDate = DateTime.ParseExact(comboBoxDate.SelectedItem.ToString(), "dd/MM/yyyy", null);
            DateTime currentTime = DateTime.Now;

            // Nếu ngày được chọn là ngày hiện tại, bắt đầu từ giờ hiện tại (làm tròn lên)
            DateTime startTime = (selectedDate.Date == currentTime.Date)
                ? currentTime.AddHours(1).Date.AddHours(currentTime.AddHours(1).Hour)
                : selectedDate.Date;

            DateTime endOfDay = selectedDate.Date.AddDays(1).AddSeconds(-1);

            while (startTime <= endOfDay)
            {
                DateTime time1 = startTime;
                DateTime time2 = time1.AddHours(1);

                if (time2 > endOfDay)
                {
                    time2 = endOfDay;
                }
                //List<OrderPitch> orderPitches = _orderPitchBus.GetByDateTime(startTime, time2);
                
                dgvPitch.Rows.Add(time1.ToString("HH:mm"), time2.ToString("HH:mm"), countSan5 , countSan7); /// bug hered

                startTime = startTime.AddHours(1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắn Muốn Đặt!", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(rb_san5.Checked || rb_san7.Checked)
                {
                    string typePitch = "Sân 7";
                    PricePerHour pricePitch = null;
                    if (rb_san5.Checked)
                    {
                        typePitch = "Sân 5";
                    }
                    DateTime getCbtime = DateTime.ParseExact(comboBoxDate.Text, "dd/MM/yyyy", null);
                    DateTime startTime = getCbtime.Date.Add(DateTime.ParseExact((string)dgvPitch.Rows[rowclick].Cells[columnName: "Column1"].Value, "HH:mm", null).TimeOfDay);
                    DateTime endTime = getCbtime.Date.Add(DateTime.ParseExact((string)dgvPitch.Rows[rowclick].Cells[columnName: "Column2"].Value, "HH:mm", null).TimeOfDay);
                    List<OrderPitch> orderPitches = _orderPitchBus.GetByDateTime(startTime, endTime);
                    List<TypePitch> getSan = _typePitchBus.GetByName(typePitch);
                    List<Pitch> getPitch = _pitchBus.GetByPitchId(getSan.FirstOrDefault().Id);
                    if (orderPitches.Count() == getPitch.Count())
                    {
                        MessageBox.Show("Đã Hết Sân " + typePitch + "!", "Thông báo");
                    } else
                    {
                        List<PricePerHour> pricePerHours = _pricePerHourBus.GetAll();
                        foreach (PricePerHour item in pricePerHours)
                        {
                            if ((item.TimeStart.ToTimeSpan() <= startTime.TimeOfDay) && (item.TimeEnd.ToTimeSpan() >= endTime.TimeOfDay))
                            {
                                MessageBox.Show(((item.TimeStart.ToTimeSpan() <= startTime.TimeOfDay) && (item.TimeEnd.ToTimeSpan() >= endTime.TimeOfDay)).ToString());
                                pricePitch = item;
                            }
                        }
                        User user = _userBus.GetByUsername(_sessionBus.GetSession().Name).FirstOrDefault();
                        OrderPitch newOrderPitch = new OrderPitch()
                        {
                            UserId = user.Id,
                            IsCheck = null,
                            IsPay = false,
                            TimeStart = startTime,
                            TimeEnd = endTime,
                            Price = getSan.FirstOrDefault().Price,
                            PricePerHourId = pricePitch.Id,
                            PitchId = getPitch[orderPitches.Count()].Id, /// bug here
                        };
                        _orderPitchBus.Add(newOrderPitch);
                    }
                } else
                {
                    MessageBox.Show("Vui lòng chọn sân!", "Thông báo");
                }
                
            }
        }

        private void dgvPitch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.rowclick = e.RowIndex;
        }
    }
}
