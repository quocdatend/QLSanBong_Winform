using QLSanBong.BUS;
using QLSanBong.DAL;
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
    public partial class frm_OrderPitch : Form
    {
        private readonly PitchBus _pitchBus = new PitchBus();
        private readonly PricePerHourBus _pricePerHourBus = new PricePerHourBus();
        private readonly TypePitchBus _typePitchBus = new TypePitchBus();
        private readonly OrderPitchBus _orderPitchBus = new OrderPitchBus();
        private readonly SessionBus _sessionBus;
        private int rowIndex = -1;
        public frm_OrderPitch()
        {
            InitializeComponent();
        }

        public frm_OrderPitch(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            ShowDataGridView();
        }

        private void ShowDataGridView()
        {
            List<OrderPitch> orderPitches = _orderPitchBus.GetAll();

            dgvOrderPitch.Columns.Add("Column1", "Thời gian bắt đầu");
            dgvOrderPitch.Columns.Add("Column2", "Thời gian kết thúc");
            dgvOrderPitch.Columns.Add("Column3", "Loai Sân");
            dgvOrderPitch.Columns.Add("Column4", "Giá tiền");
            dgvOrderPitch.Columns.Add("Column5", "Trạng thái");
            dgvOrderPitch.Columns.Add("Column6", "Thannh toán");

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
                dgvOrderPitch.Rows.Add(item.TimeStart, item.TimeEnd, typePitch.Name, item.Price + price.Price, isCheck, item.IsPay ? "Rồi" : "Chưa");
            }
        }

        private void dgvOrderPitch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if(rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn", "Thông Báo");
            } else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    List<OrderPitch> orderPitches = _orderPitchBus.GetByDateTime(DateTime.ParseExact(dgvOrderPitch.Rows[rowIndex].Cells[columnName: "Column1"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null), DateTime.ParseExact(dgvOrderPitch.Rows[rowIndex].Cells[columnName: "Column2"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null));
                    _orderPitchBus.Delete(orderPitches.FirstOrDefault());
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                rowIndex = -1;
            }
        }
    }
}
