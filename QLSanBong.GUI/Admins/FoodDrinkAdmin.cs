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
    public partial class frm_FoodDrinkAdmin : Form
    {
        private readonly FoodDrinkBus _foodDrinkBus = new FoodDrinkBus();
        private readonly SessionBus _sessionBus;
        private int rowIndex = -1;
        public frm_FoodDrinkAdmin()
        {
            InitializeComponent();
        }

        public frm_FoodDrinkAdmin(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            AddColumnToDGV();
        }

        private void AddColumnToDGV()
        {
            dgvShowFoodDrink.Columns.Add("Column1", "Stt");
            dgvShowFoodDrink.Columns.Add("Column2", "Name");
            dgvShowFoodDrink.Columns.Add("Column3", "Count");
            dgvShowFoodDrink.Columns.Add("Column4", "Price");
            dgvShowFoodDrink.Columns.Add("Column5", "Image Url");
            UpdateDataInDGV();
        }

        private void UpdateDataInDGV()
        {
            List<FoodDrink> foodDrinks = _foodDrinkBus.GetAll();

            int i = 0;
            foreach (FoodDrink item in foodDrinks)
            {
                i++;
                string url = "null";
                if(item.UrlImg != null) url = item.UrlImg;
                dgvShowFoodDrink.Rows.Add(i, item.Name, item.Count, item.Price, url);
            }
        }

        private void dgvShowFoodDrink_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
            txtName.Text = dgvShowFoodDrink.Rows[rowIndex].Cells["Column2"].Value.ToString();
            txtCount.Text = dgvShowFoodDrink.Rows[rowIndex].Cells["Column3"].Value.ToString();
            txtPrice.Text = dgvShowFoodDrink.Rows[rowIndex].Cells["Column4"].Value.ToString();
            txtUrlImg.Text = dgvShowFoodDrink.Rows[rowIndex].Cells["Column5"].Value.ToString();
        }

        private string UploadImg()
        {
            try
            {
                // Tạo một OpenFileDialog
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Chọn một hình ảnh";
                openFileDialog.Filter = "Các tệp hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                
                // Hiển thị hộp thoại và kiểm tra nếu người dùng nhấp OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn của tệp đã chọn
                    string sourceFilePath = openFileDialog.FileName;

                    string defaultName = Path.GetFileName(sourceFilePath);
                    int lenPath = defaultName.Length;
                    string typeImg = defaultName.Substring(lenPath-3);
                    // Lấy tên file từ đường dẫn
                    string fileName = txtName.Text.ToLower() + "." + typeImg;

                    // Tạo đường dẫn đến thư mục Images trong dự án
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string targetDirectory = Path.Combine(projectDirectory, "C:\\Users\\Acer\\Desktop\\Winform\\DOAN\\QLSanBong\\QLSanBong.DAL\\Images\\");

                    // Tạo đường dẫn đến file đích trong thư mục Images
                    string targetFilePath = Path.Combine(targetDirectory, fileName);

                    // Sao chép tệp vào thư mục Images
                    File.Copy(sourceFilePath, targetFilePath, true);

                    // Tải hình ảnh vào PictureBox
                    //pictureBox1.Image = System.Drawing.Image.FromFile(targetFilePath);

                    // Hiển thị đường dẫn của hình ảnh trong Label
                    //lblImagePath.Text = "Hình ảnh đã lưu: " + targetFilePath;
                    return fileName;
                }
                return null;
            } catch (Exception ex)
            {
                return null;
            }
        }

        private bool DeleteImg()
        {
            try
            {
                // Lấy đường dẫn của hình ảnh từ Label (hoặc bất cứ nơi nào bạn lưu trữ đường dẫn)
                string imagePath = "C:\\Users\\Acer\\Desktop\\Winform\\DOAN\\QLSanBong\\QLSanBong.DAL\\Images\\" + txtUrlImg.Text;

                // Kiểm tra nếu tệp tồn tại trước khi xóa
                if (File.Exists(imagePath))
                {
                    // Xóa tệp
                    File.Delete(imagePath);
                }
                else
                {
                    MessageBox.Show("Tệp không tồn tại hoặc đã bị xóa.");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if(rowIndex != -1)
            {
                FoodDrink foodDrink = _foodDrinkBus.GetByName(txtName.Text).FirstOrDefault();
                if(!txtUrlImg.Text.Equals("null"))
                {
                    DialogResult result = MessageBox.Show("Đã tồn tại ảnh bạn chắc chăn muốn thay đổi ảnh hiện tại!", "Thông Báo", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        string fileName = UploadImg();
                        if(fileName != null && DeleteImg())
                        {
                            foodDrink.UrlImg = fileName;
                            _foodDrinkBus.Edit(foodDrink);
                            MessageBox.Show("Thay đổi ảnh thành công" , "Thông Báo");
                            dgvShowFoodDrink.Rows.Clear();
                            UpdateDataInDGV();
                            rowIndex = -1;
                        } else
                        {
                            MessageBox.Show("Tải ảnh lên thất bại", "Thông Báo");
                        }
                    }
                } else
                {
                    string fileName = UploadImg();
                    if (fileName != null)
                    {
                        foodDrink.UrlImg = fileName;
                        _foodDrinkBus.Edit(foodDrink);
                        MessageBox.Show("Thay đổi ảnh thành công", "Thông Báo");
                        dgvShowFoodDrink.Rows.Clear();
                        UpdateDataInDGV();
                        rowIndex = -1;
                    } else
                    {
                        MessageBox.Show("Tải ảnh lên thất bại", "Thông Báo");
                    }
                }
                rowIndex = -1;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn!", "Thông Báo");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn", "Thông Báo");
            } else
            {
                FoodDrink foodDrink = _foodDrinkBus.GetByName(dgvShowFoodDrink.Rows[rowIndex].Cells["Column2"].Value.ToString()).FirstOrDefault();
                if(txtName.Text.Equals(foodDrink.Name) && txtCount.Text.Equals(foodDrink.Count.ToString()) && txtPrice.Text.Equals(foodDrink.Price.ToString()))
                {
                    MessageBox.Show("Không có bất kì thay đổi nào", "Thông Báo");
                } else
                {
                    foodDrink.Name = txtName.Text;
                    foodDrink.Count = int.Parse(txtCount.Text);
                    foodDrink.Price = float.Parse(txtPrice.Text);
                    _foodDrinkBus.Edit(foodDrink);
                    MessageBox.Show("Thay đổi ảnh thành công", "Thông Báo");
                    dgvShowFoodDrink.Rows.Clear();
                    UpdateDataInDGV();
                    rowIndex = -1;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length == 0 || txtCount.Text.Length == 0 || txtPrice.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ trường dữ liệu", "Thông Báo");
            } else
            {
                FoodDrink checkName = _foodDrinkBus.GetByName(txtName.Text).FirstOrDefault();
                if(checkName != null)
                {
                    MessageBox.Show("Tên đã tồn tại", "Thông Báo");
                } else
                {
                    FoodDrink newFoodDrink = new FoodDrink()
                    {
                        Name = txtName.Text,
                        Count = int.Parse(txtCount.Text),
                        Price = float.Parse(txtPrice.Text),
                        UrlImg = null,
                    };
                    _foodDrinkBus.Add(newFoodDrink);
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    dgvShowFoodDrink.Rows.Clear();
                    UpdateDataInDGV();
                    rowIndex = -1;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(rowIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn", "Thông Báo");
            } else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        FoodDrink foodDrink = _foodDrinkBus.GetByName(dgvShowFoodDrink.Rows[rowIndex].Cells["Column2"].Value.ToString()).FirstOrDefault();
                        _foodDrinkBus.Remove(foodDrink);
                        MessageBox.Show("Xóa thành công", "Thông Báo");
                        dgvShowFoodDrink.Rows.Clear();
                        UpdateDataInDGV();
                        rowIndex = -1;
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Đồ ăn_Uống đanng được sử dựng không thể xóa", "Thông Báo");
                    }
                }
            }
        }
    }
}