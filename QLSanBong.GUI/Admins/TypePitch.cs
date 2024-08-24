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
    public partial class frm_TypePitch : Form
    {
        private readonly TypePitchBus _typePitchBus = new TypePitchBus();
        private readonly SessionBus _sessionBus;
        private int rowIndex = -1;
        public frm_TypePitch()
        {
            InitializeComponent();
        }

        public frm_TypePitch(SessionBus _se)
        {
            InitializeComponent();
            _sessionBus = _se;
            AddColumnToDGV();
        }

        private void AddColumnToDGV()
        {
            dgvShowTypePitch.Columns.Add("Column1", "Stt");
            dgvShowTypePitch.Columns.Add("Column2", "Name");
            dgvShowTypePitch.Columns.Add("Column3", "Price");
            UpdateDataInDGV();
        }

        private void UpdateDataInDGV()
        {
            List<TypePitch> typePitches = _typePitchBus.GetAll();
            int i = 0;
            foreach (TypePitch item in typePitches)
            {
                i++;
                dgvShowTypePitch.Rows.Add(i, item.Name, item.Price);
            }
        }

        private void dgvShowTypePitch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
            txtName.Text = dgvShowTypePitch.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
            txtPrice.Text = dgvShowTypePitch.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtPrice.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ trường giá trị!", "Thông Báo");
            }
            else
            {
                TypePitch checkName = _typePitchBus.GetByName(txtName.Text).FirstOrDefault();
                if (checkName != null)
                {
                    MessageBox.Show("Đã tồn tại", "Thông Báo");
                }
                else
                {
                    TypePitch newTypePitch = new TypePitch()
                    {
                        Name = txtName.Text,
                        Price = float.Parse(txtPrice.Text),
                    };
                    _typePitchBus.Add(newTypePitch);
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    dgvShowTypePitch.Rows.Clear();
                    UpdateDataInDGV();

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn!", "Thông Báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        TypePitch typePitch = _typePitchBus.GetByName(dgvShowTypePitch.Rows[rowIndex].Cells["Column2"].Value.ToString()).FirstOrDefault();
                        _typePitchBus.Delete(typePitch);
                        MessageBox.Show("Xóa Thành công", "Thông Báo");
                        dgvShowTypePitch.Rows.Clear();
                        UpdateDataInDGV();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sân đang sử dụng không thể xóa", "Thông Báo");
                    }
                }
                rowIndex = -1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtPrice.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ trường giá trị!", "Thông Báo");
            }
            else
            {
                if (rowIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn!", "Thông Báo");
                }
                else
                {
                    TypePitch typePitch = _typePitchBus.GetByName(dgvShowTypePitch.Rows[rowIndex].Cells["Column2"].Value.ToString()).FirstOrDefault();

                    if (typePitch.Name.Equals(txtName.Text) && typePitch.Price == float.Parse(txtPrice.Text))
                    {
                        MessageBox.Show("Vui lòng thay đổi giá trị nếu muốn thay đổi!", "Thông Báo");
                    }
                    else if (!typePitch.Name.Equals(txtName.Text) || typePitch.Price != float.Parse(txtPrice.Text))
                    {
                        typePitch.Name = txtName.Text;
                        typePitch.Price = float.Parse(txtPrice.Text);
                        _typePitchBus.ChangeInfo(typePitch);
                        MessageBox.Show("Thay đổi thành công", "Thông Báo");
                        dgvShowTypePitch.Rows.Clear();
                        UpdateDataInDGV();
                        rowIndex = -1;
                    }
                }
            }
        }
    }
}
