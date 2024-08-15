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
using System.Windows.Forms.VisualStyles;

namespace QLSanBong.GUI.Users
{
    public partial class frm_Drinks : Form
    {
        private readonly SessionBus _sessionBus = new SessionBus();
        private readonly FoodDrinkBus _foodDrinkBus = new FoodDrinkBus();
        public frm_Drinks()
        {
            InitializeComponent();
        }

        public frm_Drinks(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            ShowFoodDrinks();
        }

        private void ShowFoodDrinks()
        {
            List<FoodDrink> foodDrinks = _foodDrinkBus.GetAll();

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.HeaderText = "Column1";
            imgColumn.Name = "Ảnh";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chọn cách hiển thị hình ảnh

            // Thêm các cột vào DataGridView
            dgvDrinkFood.Columns.Add(imgColumn);
            dgvDrinkFood.Columns.Add("Column2", "Tên");
            dgvDrinkFood.Columns.Add("Column3", "Số Lượng");
            dgvDrinkFood.Columns.Add("Column4", "Giá Tiền");

            foreach (var item in foodDrinks)
            {
                dgvDrinkFood.Rows.Add(Image.FromFile("C:\\Users\\Acer\\Desktop\\Winform\\DOAN\\QLSanBong\\QLSanBong.DAL\\Images\\" + item.UrlImg), item.Name, item.Count, item.Price);
            }
        }
    }
}
