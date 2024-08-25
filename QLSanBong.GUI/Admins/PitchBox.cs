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
    public partial class frm_PitchBox : Form
    {
        private readonly PricePerHourBus _pricePerHourBus = new PricePerHourBus();
        private readonly OrderPitchBus _orderPitchBus = new OrderPitchBus();
        private readonly PitchBus _pitchBus = new PitchBus();
        private readonly PaymentHistory _paymentHistory;
        public frm_PitchBox()
        {
            InitializeComponent();
        }
        public frm_PitchBox(PaymentHistory pa)
        {
            InitializeComponent();
            _paymentHistory = pa;
            AddColumnToDGV();
        }

        private void AddColumnToDGV()
        {
            dgvShowPitch.Columns.Add("Column1", "Stt");
            dgvShowPitch.Columns.Add("Column2", "Time Start");
            dgvShowPitch.Columns.Add("Column3", "Time End");
            dgvShowPitch.Columns.Add("Column4", "Name Pitch");
            dgvShowPitch.Columns.Add("Column5", "Price Pitch");
            dgvShowPitch.Columns.Add("Column6", "Price Per Hour");
            UpdateDataInDGV();
        }

        private void UpdateDataInDGV()
        {
            List<OrderPitch> orderPitches = _orderPitchBus.GetById((int)_paymentHistory.OrderPitchId);
            int i = 0;
            foreach (OrderPitch item in orderPitches)
            {
                i++;
                Pitch pitch = _pitchBus.GetById(item.PitchId).FirstOrDefault();
                PricePerHour pricePerHour = _pricePerHourBus.GetById(item.PricePerHourId).FirstOrDefault();
                dgvShowPitch.Rows.Add(i, item.TimeStart, item.TimeEnd, pitch.Name, item.Price, pricePerHour.Price);
            }
        }
    }
}
