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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QLSanBong.GUI.Users
{
    public partial class frm_Drinks : Form
    {
        private readonly UserBus _userBus = new UserBus();
        private readonly SessionBus _sessionBus = new SessionBus();
        private readonly FoodDrinkBus _foodDrinkBus = new FoodDrinkBus();
        private readonly OrderFoodDrinkBus _orderFoodDrinkBus = new OrderFoodDrinkBus();
        private readonly OrderFoodDrinkDetailBus _orderFoodDrinkDetailBus = new OrderFoodDrinkDetailBus();
        private List<FoodDrink> _listOrder = new List<FoodDrink>();
        private int indexRowFD = -1;
        private int indexRowOrder = -1;
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
            imgColumn.HeaderText = "Ảnh";
            imgColumn.Name = "Column1";
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
            
            DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn();
            textBoxColumn.HeaderText = "Số lượng";
            textBoxColumn.Name = "Column4";
            textBoxColumn.ValueType = typeof(int);

            dgvOrder.Columns.Add("Column1", "Stt");
            dgvOrder.Columns.Add("Column2", "Tên");
            dgvOrder.Columns.Add("Column3", "Giá tiền");
            dgvOrder.Columns.Add(textBoxColumn);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (indexRowFD == -1)
            {
                MessageBox.Show("Vui lòng chọn", "Thông báo");
            }
            else
            {
                List<FoodDrink> foodDrinks = _listOrder.Where(x => x.Equals(_foodDrinkBus.GetByName(dgvDrinkFood.Rows[indexRowFD].Cells[columnName: "Column2"].Value.ToString()).First())).ToList();
                if(foodDrinks.Count > 0 )
                {
                    MessageBox.Show("Đã chọn", "Thông báo");
                } else
                {
                    dgvOrder.Rows.Clear();
                    List<FoodDrink> getFoodDrinks = _foodDrinkBus.GetByName(dgvDrinkFood.Rows[indexRowFD].Cells[columnName: "Column2"].Value.ToString());
                    _listOrder.Add(getFoodDrinks.First());
                    int i = 0;
                    //NumericUpDown num = new NumericUpDown();
                    foreach (FoodDrink item in _listOrder)
                    {
                        i++;
                        dgvOrder.Rows.Add(i, item.Name, item.Price, 1);
                    }
                }
            }
            indexRowFD = -1;
            dgvDrinkFood.Refresh();
        }

        private void dgvDrinkFood_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexRowFD = e.RowIndex;
        }

        private void dgvOrder_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexRowOrder = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (indexRowOrder == -1)
            {
                MessageBox.Show("Vui lòng chọn", "Thông báo");
            }
            else
            {
                List<FoodDrink> getFoodDrinks = _foodDrinkBus.GetByName(dgvOrder.Rows[indexRowOrder].Cells[columnName: "Column2"].Value.ToString());
                _listOrder.Remove(getFoodDrinks.First());
                dgvOrder.Rows.RemoveAt(indexRowOrder);
            }
            indexRowOrder = -1;
            dgvOrder.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _listOrder.Clear();
            dgvOrder.Rows.Clear();
            dgvOrder.Refresh();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool isTrue = true;
            bool checkFirst = true;
            // check count
            int countList = _listOrder.Count;
            for (int i = 0; i < countList; i++)
            {
                Console.WriteLine(dgvOrder.Rows[i].Cells[columnName: "Column4"].Value.ToString());
                if(dgvOrder.Rows[i].Cells[columnName: "Column4"].Value.ToString() == "")
                {
                    isTrue = false;
                    checkFirst = false;
                    MessageBox.Show("Không được để trống!", "Thông báo");
                    break;
                } else if( int.Parse(dgvOrder.Rows[i].Cells[columnName: "Column4"].Value.ToString()) <= 0)
                {
                    isTrue = false;
                    checkFirst = false;
                    MessageBox.Show("Giá trị không được nhỏ hơn hoặc bằng 0!", "Thông báo");
                    break;
                }
            }
            if(checkFirst)
            {
                for (int i = 0; i < countList; i++)
                {
                    FoodDrink foodDrink = _foodDrinkBus.GetByName(dgvOrder.Rows[i].Cells[columnName: "Column2"].Value.ToString()).First();
                    if (int.Parse(dgvOrder.Rows[i].Cells[columnName: "Column4"].Value.ToString()) > foodDrink.Count)
                    {
                        isTrue = false;
                        MessageBox.Show("Giá trị " + foodDrink.Name + " Không phù hợp!", "Thông báo");
                        break;
                    }
                }
            }
            
            if(isTrue)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắn Muốn Đặt!", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    DateTime dateTime = DateTime.Now;
                    OrderFoodDrink orderFoodDrink = new OrderFoodDrink()
                    {
                        UserId = _userBus.GetByUsername(_sessionBus.Session.Name).First().Id,
                        Time = dateTime,
                    };
                    _orderFoodDrinkBus.Add(orderFoodDrink);
                    OrderFoodDrink orderFoodDrink1 = _orderFoodDrinkBus.GetByTime(DateTime.ParseExact(dateTime.ToString(), "dd/MM/yyyy h:mm:ss tt", null)).First();
                    int i = 0;
                    foreach (FoodDrink item in _listOrder)
                    {
                        item.Count = int.Parse(dgvOrder.Rows[i].Cells[columnName: "Column4"].Value.ToString());
                        // add order food drink detail
                        OrderFoodDrinkDetail orderFoodDrinkDetail = new OrderFoodDrinkDetail()
                        {
                            Count = item.Count,
                            Price = item.Price,
                            FoodDrinkId = item.Id,
                            OrderFoodDrinkId = orderFoodDrink1.Id
                        };
                        _orderFoodDrinkDetailBus.Add(orderFoodDrinkDetail);
                        i++;
                    }

                }
            }
        }
    }
}
