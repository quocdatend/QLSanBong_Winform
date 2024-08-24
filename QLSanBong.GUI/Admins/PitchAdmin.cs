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
    public partial class frm_PitchAdmin : Form
    {
        private readonly TypePitchBus _typePitchBus = new TypePitchBus();
        private readonly PitchBus _pitchBus = new PitchBus();
        private readonly SessionBus _sessionBus;
        private int rowIndex = -1;
        public frm_PitchAdmin()
        {
            InitializeComponent();
        }

        public frm_PitchAdmin(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            AddColumnToDGV();
            LoadDataCB();
        }

        private void LoadDataCB()
        {
            List<TypePitch> typePitches = _typePitchBus.GetAll();
            cbTypePitch.Text = typePitches.First().Name;
            foreach (var item in typePitches)
            {
                cbTypePitch.Items.Add(item.Name);
            }
        }

        private void AddColumnToDGV()
        {
            dgvShowPitch.Columns.Add("Column1", "Stt");
            dgvShowPitch.Columns.Add("Column2", "Name");
            dgvShowPitch.Columns.Add("Column3", "Type Pitch");
            UpdateDataInDGV();
        }

        private void UpdateDataInDGV()
        {
            List<Pitch> pitchBuses = _pitchBus.GetAll();
            int i = 0;
            foreach (Pitch item in pitchBuses)
            {
                i++;
                TypePitch typePitch = _typePitchBus.GetById(item.TypePitchId).FirstOrDefault();
                dgvShowPitch.Rows.Add(i, item.Name, typePitch.Name);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
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
                    Pitch pitch = _pitchBus.GetByName(dgvShowPitch.Rows[rowIndex].Cells["Column2"].Value.ToString()).FirstOrDefault();
                    TypePitch typePitch = _typePitchBus.GetByName(cbTypePitch.Text).FirstOrDefault();
                    if (pitch.Name.Equals(txtName.Text) && typePitch.Id == pitch.TypePitchId)
                    {
                        MessageBox.Show("Vui lòng thay đổi giá trị nếu muốn thay đổi!", "Thông Báo");
                    }
                    else
                    {
                        pitch.Name = txtName.Text;
                        pitch.TypePitchId = typePitch.Id;
                        _pitchBus.Edit(pitch);
                        MessageBox.Show("Thay đổi thành công", "Thông Báo");
                        dgvShowPitch.Rows.Clear();
                        UpdateDataInDGV();
                        rowIndex = -1;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 00)
            {
                MessageBox.Show("Vui lòng nhập đủ trường giá trị!", "Thông Báo");
            }
            else
            {
                Pitch checkName = _pitchBus.GetByName(txtName.Text).FirstOrDefault();
                TypePitch typePitch = _typePitchBus.GetByName(cbTypePitch.Text).FirstOrDefault();
                if (checkName != null)
                {
                    MessageBox.Show("Đã tồn tại", "Thông Báo");
                }
                else
                {
                    Pitch newPitch = new Pitch()
                    {
                        Name = txtName.Text,
                        TypePitchId = typePitch.Id,
                    };
                    _pitchBus.Add(newPitch);
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    dgvShowPitch.Rows.Clear();
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
                        Pitch pitch = _pitchBus.GetByName(dgvShowPitch.Rows[rowIndex].Cells["Column2"].Value.ToString()).FirstOrDefault();
                        _pitchBus.Delete(pitch);
                        MessageBox.Show("Xóa Thành công", "Thông Báo");
                        dgvShowPitch.Rows.Clear();
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

        private void dgvShowPitch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
            try
            {
                txtName.Text = dgvShowPitch.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                cbTypePitch.Text = _typePitchBus.GetByName(dgvShowPitch.Rows[e.RowIndex].Cells["Column3"].Value.ToString()).FirstOrDefault().Name;
            } catch (NullReferenceException)
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo");
            }
        }
    }
}
