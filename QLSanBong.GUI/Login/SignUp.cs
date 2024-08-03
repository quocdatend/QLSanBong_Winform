using QLSanBong.BUS;
using QLSanBong.DAL;
using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong.GUI.Login
{
    public partial class frm_SignUp : Form
    {
        private readonly UserBus _userBus = new UserBus();
        private readonly AdminBus _adminBus = new AdminBus();
        private readonly UserRoleBus _userRoleBus = new UserRoleBus();
        private readonly Encrypt _encrypt = new Encrypt();
        private UserRole _userRole;
        public frm_SignUp()
        {
            InitializeComponent();
        }
        // Validation Username

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
        // Sự kiện đăng kí
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường có null không
            if (txt_Username.Text.Length == 0 || txt_Email.Text.Length == 0 || txt_Phone.Text.Length == 0 || txt_Password.Text.Length == 0 || txt_Confirm_Pass.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ các trường dữ liệu!", "Thông Báo");
            }// Kiểm tra username đã có trong User hay Admin chưa
            else if (!_userBus.CheckByUsername(txt_Username.Text) || !_adminBus.CheckByUsername(txt_Username.Text))
            {
                MessageBox.Show("Username đã tồn tại, vui lòng thử lại!", "Thông Báo");
            }// Kiểm tra email đã có trong User hay Admin chưa
            else if (!_userBus.CheckByEmail(txt_Email.Text) || !_adminBus.CheckByEmail(txt_Email.Text))
            {
                MessageBox.Show("Email đã tồn tại, vui lòng thử lại!", "Thông Báo");
            }// Kiểm tra nhập pass có trùng khớp với confirm pass hay không
            else if (!txt_Password.Text.Equals(txt_Confirm_Pass.Text))
            {
                MessageBox.Show("Mật Khẩu Không Trùng Khớp", "Thông Báo");
            }
            else
            {
                // Tạo và thêm tài khoản User
                User _user = new User()
                {
                    Username = txt_Username.Text,
                    Email = txt_Email.Text,
                    Phone = txt_Phone.Text,
                    Pass = _encrypt.GetSha256Hash(txt_Password.Text)
                };
                _userBus.Add(_user);
                // Gán quyền cho tài khoản
                _userRole = new UserRole()
                {
                    RoleId = 2,
                    UserId = _user.Id
                };
                _userRoleBus.Add(_userRole);
                MessageBox.Show("Tạo tài khoản thành công!", "Thông Báo");
                this.Close();
            }
        }
        // sự kiện rời chuột
        private void txt_Username_Leave(object sender, EventArgs e)
        {
            // Kiểm tra độ dài có nhỏ hơn 6 kí tự hay không
            if (txt_Username.Text.Length < 6)
            {
                MessageBox.Show("Độ dài tối thiểu 6 kí tự", "Thông Báo");
            }
        }
        // sự kiện rời chuột
        private void txt_Email_Leave(object sender, EventArgs e)
        {
            // dùng Validation kiểm tra tính hợp lệ của Email
            if (!IsValidEmail(txt_Email.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!", "Thông Báo");
            }
        }
        // sự kiện rời chuột
        private void txt_Phone_Leave(object sender, EventArgs e)
        {
            // Kiểm tra độ dài phải là 11 kí tự và phải là chuỗi số
            if (!IsValidPhoneNumber(txt_Phone.Text))
            {
                MessageBox.Show("Độ dài tối thiểu 10 hay 11 kí tự và phải là chuỗi số", "Thông Báo");
            }
        }
        // sự kiện rời chuột
        private void txt_Password_Leave(object sender, EventArgs e)
        {
            // Kiểm tra độ dài có nhỏ hơn 8 kí tự hay không
            if (txt_Password.Text.Length < 8)
            {
                MessageBox.Show("Độ dài tối thiểu 8 kí tự", "Thông Báo");
            }// dùng Validation kiểm tra tính hợp lệ của Password
            else if (!IsValidPassword(txt_Password.Text))
            {
                MessageBox.Show("Password phải chứa ít nhất một chữ hoa, một chữ thường, một số và một ký tự đặc biệt!", "Thông Báo");
            }
        }
    }
}
