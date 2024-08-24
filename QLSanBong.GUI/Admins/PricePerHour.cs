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
    public partial class frm_PricePerHour : Form
    {
        private readonly PricePerHourBus _pricePerHourBus = new PricePerHourBus();
        private readonly SessionBus _sessionBus;
        private int rowIndex = -1;
        public frm_PricePerHour()
        {
            InitializeComponent();
        }

        public frm_PricePerHour(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            AddDataToDGV();
            LoadDataInCB();
        }

        private void LoadDataInCB()
        {
            DateTime dateTime = new DateTime();
            cbTimeStart.Text = dateTime.ToString("HH:mm");
            cbTimeEnd.Text = dateTime.ToString("HH:mm");
            for (int i = 0; i < 23; i++)
            {
                cbTimeStart.Items.Add(dateTime.ToString("HH:mm"));
                cbTimeEnd.Items.Add(dateTime.ToString("HH:mm"));
                dateTime = dateTime.AddHours(1);
            }
            cbTimeStart.Items.Add(dateTime.ToString("23:59"));
            cbTimeEnd.Items.Add(dateTime.ToString("23:59"));
        }

        private void AddDataToDGV()
        {
            dgvShowPricePerHour.Columns.Add("Column1", "Stt");
            dgvShowPricePerHour.Columns.Add("Column2", "Time Start");
            dgvShowPricePerHour.Columns.Add("Column3", "Time End");
            dgvShowPricePerHour.Columns.Add("Column4", "Price");
            UpdateDataInDGV();
        }

        private void UpdateDataInDGV()
        {
            List<PricePerHour> pricePerHours = _pricePerHourBus.GetAll();

            int i = 0;
            foreach (PricePerHour item in pricePerHours)
            {
                i++;

                dgvShowPricePerHour.Rows.Add(i, item.TimeStart.ToString("HH:mm"), item.TimeEnd.ToString("HH:mm"), item.Price);
            }
        }

        private void dgvShowPricePerHour_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
            cbTimeStart.Text = dgvShowPricePerHour.Rows[rowIndex].Cells["Column2"].Value.ToString();
            cbTimeEnd.Text = dgvShowPricePerHour.Rows[rowIndex].Cells["Column3"].Value.ToString();
            txtPrice.Text = dgvShowPricePerHour.Rows[rowIndex].Cells["Column4"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtPrice.Text.Length == 0 || cbTimeStart.Text.Length == 0 || cbTimeEnd.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ trường dữ liệu!", "Thông Báo");
            } else
            {
                if(DateTime.ParseExact(cbTimeStart.Text, "HH:mm", null).TimeOfDay >= DateTime.ParseExact(cbTimeEnd.Text, "HH:mm", null).TimeOfDay)
                {
                    MessageBox.Show("Time Start phải nhỏ hơn Time End", "Thông Báo");
                } else
                {
                    PricePerHour checkTime = _pricePerHourBus.GetByTime(DateTime.ParseExact(cbTimeStart.Text, "HH:mm", null), DateTime.ParseExact(cbTimeEnd.Text, "HH:mm", null)).FirstOrDefault();
                    if(checkTime != null)
                    {
                        MessageBox.Show("Đã tồn tại khung thời gian trên", "Thông Báo");
                    } else
                    {
                        PricePerHour pricePerHour = _pricePerHourBus.GetByTime(DateTime.ParseExact(dgvShowPricePerHour.Rows[rowIndex].Cells["Column2"].Value.ToString(), "HH:mm", null), DateTime.ParseExact(dgvShowPricePerHour.Rows[rowIndex].Cells["Column3"].Value.ToString(), "HH:mm", null)).FirstOrDefault();
                        pricePerHour.TimeStart = TimeOnly.ParseExact(cbTimeStart.Text, "HH:mm", null);
                        pricePerHour.TimeEnd = TimeOnly.ParseExact(cbTimeEnd.Text, "HH:mm", null);
                        pricePerHour.Price = float.Parse(txtPrice.Text);
                        _pricePerHourBus.Edit(pricePerHour);
                        MessageBox.Show("Thay đổi thành công", "Thông Báo");
                        dgvShowPricePerHour.Rows.Clear();
                        UpdateDataInDGV();
                        rowIndex = -1;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ trường dữ liệu!", "Thông Báo");
            } else
            {
                if (DateTime.ParseExact(cbTimeStart.Text, "HH:mm", null).TimeOfDay >= DateTime.ParseExact(cbTimeEnd.Text, "HH:mm", null).TimeOfDay)
                {
                    MessageBox.Show("Time Start phải nhỏ hơn Time End", "Thông Báo");
                }
                else
                {
                    PricePerHour checkTime = _pricePerHourBus.GetByTime(DateTime.ParseExact(cbTimeStart.Text, "HH:mm", null), DateTime.ParseExact(cbTimeEnd.Text, "HH:mm", null)).FirstOrDefault();
                    if (checkTime != null)
                    {
                        MessageBox.Show("Đã tồn tại khung thời gian trên", "Thông Báo");
                    }
                    else
                    {
                        PricePerHour newPricePerHour = new PricePerHour() {
                            TimeStart = TimeOnly.ParseExact(cbTimeStart.Text, "HH:mm", null),
                            TimeEnd = TimeOnly.ParseExact(cbTimeEnd.Text, "HH:mm", null),
                            Price = float.Parse(txtPrice.Text),
                        };
                        _pricePerHourBus.Add(newPricePerHour);
                        MessageBox.Show("Thêm thành công", "Thông Báo");
                        dgvShowPricePerHour.Rows.Clear();
                        UpdateDataInDGV();
                        rowIndex = -1;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn!", "Thông Báo");
            } else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        PricePerHour pricePerHour = _pricePerHourBus.GetByTime(DateTime.ParseExact(dgvShowPricePerHour.Rows[rowIndex].Cells["Column2"].Value.ToString(), "HH:mm", null), DateTime.ParseExact(dgvShowPricePerHour.Rows[rowIndex].Cells["Column3"].Value.ToString(), "HH:mm", null)).FirstOrDefault();
                        _pricePerHourBus.Delete(pricePerHour);
                        MessageBox.Show("Xóa Thành công", "Thông Báo");
                        dgvShowPricePerHour.Rows.Clear();
                        UpdateDataInDGV();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thông tin đang được sử dụng, không thể xóa!", "Thông Báo");
                    }
                }
                rowIndex = -1;
            }
        }
    }
}
