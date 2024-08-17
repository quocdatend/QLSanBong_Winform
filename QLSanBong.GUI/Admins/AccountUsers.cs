using QLSanBong.BUS;
using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong.GUI.Admins
{
    public partial class frm_AccountUsers : Form
    {
        private readonly UserRoleBus _userRoleBus = new UserRoleBus();
        private readonly Encrypt _encrypt = new Encrypt();
        private readonly UserBus _userBus = new UserBus();
        private SessionBus _sessionBus;
        public frm_AccountUsers()
        {
            InitializeComponent();
        }

        public frm_AccountUsers(SessionBus se)
        {
            InitializeComponent();
            _sessionBus = se;
            ShowAccountUsers();
        }

        private void ShowAccountUsers()
        {
            dgvShowUsers.Columns.Add("Column1", "Stt");
            dgvShowUsers.Columns.Add("Column2", "Username");
            dgvShowUsers.Columns.Add("Column3", "Phone");
            dgvShowUsers.Columns.Add("Column4", "Email");

            List<User> users = _userBus.GetAll();
            int i = 0;
            foreach (User user in users)
            {
                i++;
                dgvShowUsers.Rows.Add(i, user.Username, user.Phone, user.Email);
            }
        }
        // Validation email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        // Validation phone
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return (phoneNumber.Length == 11 || phoneNumber.Length == 10) && long.TryParse(phoneNumber, out _);
        }
        // Validation Password
        private bool IsValidPassword(string username)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            return hasNumber.IsMatch(username) &&
                   hasUpperChar.IsMatch(username) &&
                   hasLowerChar.IsMatch(username) &&
                   hasSymbols.IsMatch(username);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check not null
            if(txtUsername.Text.Length == 0 || txtPass.Text.Length == 0 || txtPhone.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường dữ liệu!", "Thông Báo");
            } else
            {
                bool isOk = true;
                // Kiểm tra độ dài có nhỏ hơn 6 kí tự hay không
                if (txtUsername.Text.Length < 6)
                {
                    isOk = false;
                    MessageBox.Show("Độ dài tối thiểu 6 kí tự", "Thông Báo");
                }
                // dùng Validation kiểm tra tính hợp lệ của Email
                else if (!IsValidEmail(txtEmail.Text))
                {
                    isOk = false;
                    MessageBox.Show("Địa chỉ email không hợp lệ!", "Thông Báo");
                }
                // Kiểm tra độ dài phải là 11 kí tự và phải là chuỗi số
                else if (!IsValidPhoneNumber(txtPhone.Text))
                {
                    isOk = false;
                    MessageBox.Show("Độ dài tối thiểu 10 hay 11 kí tự và phải là chuỗi số", "Thông Báo");
                }
                // Kiểm tra độ dài có nhỏ hơn 8 kí tự hay không
                else if (txtPass.Text.Length < 8)
                {
                    isOk = false;
                    MessageBox.Show("Độ dài tối thiểu 8 kí tự", "Thông Báo");
                }// dùng Validation kiểm tra tính hợp lệ của Password
                else if (!IsValidPassword(txtPass.Text))
                {
                    isOk = false;
                    MessageBox.Show("Password phải chứa ít nhất một chữ hoa, một chữ thường, một số và một ký tự đặc biệt!", "Thông Báo");
                }
                if (isOk)
                {
                    // Tạo và thêm tài khoản User
                    User _user = new User()
                    {
                        Username = txtUsername.Text,
                        Email = txtEmail.Text,
                        Phone = txtPhone.Text,
                        Pass = _encrypt.GetSha256Hash(txtPass.Text)
                    };
                    _userBus.Add(_user);
                    // Gán quyền cho tài khoản
                    UserRole userRole = new UserRole()
                    {
                        RoleId = 2,
                        UserId = _user.Id
                    };
                    _userRoleBus.Add(userRole);
                    MessageBox.Show("Tạo tài khoản thành công!", "Thông Báo");
                }
            }
        }
    }
}
