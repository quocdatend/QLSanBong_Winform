using QLSanBong.BUS;
using QLSanBong.DAL;
using QLSanBong.DAL.Models;
using QLSanBong.GUI.Login;
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

namespace QLSanBong.GUI.Users
{
    public partial class frm_Account : Form
    {
        private readonly SessionBus _sessionBus;
        private readonly UserBus _userBus = new UserBus();
        private readonly AdminBus _adminBus = new AdminBus();
        private frm_User frm_User = null;
        private frm_Login frm_Login = null;
        public frm_Account()
        {
            InitializeComponent();
        }

        public frm_Account(SessionBus se, frm_User frm, frm_Login frm_l)
        {
            InitializeComponent();
            _sessionBus = se;
            fieldDatatoTxt();
            this.frm_User = frm;
            this.frm_Login = frm_l;
        }

        private void fieldDatatoTxt()
        {
            Session se = _sessionBus.GetSession();
            User user = _userBus.GetByUsername(se.Name).FirstOrDefault();
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Pass;
            txtEmail.Text = user.Email;
            txtPhone.Text = user.Phone;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thay đổi thông tin hay không!", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // check null
                if (txtUsername.Text.Length == 0 || txtPhone.Text.Length == 0 || txtEmail.Text.Length == 0)
                {
                    MessageBox.Show("Không được để trống!", "Thông báo");
                }
                else
                {
                    // Kiểm tra độ dài có nhỏ hơn 6 kí tự hay không
                    if (txtUsername.Text.Length < 6)
                    {
                        MessageBox.Show("Độ dài tối thiểu 6 kí tự", "Thông Báo");
                    }
                    // Kiểm tra độ dài phải là 11 kí tự và phải là chuỗi số
                    else if (!IsValidPhoneNumber(txtPhone.Text))
                    {
                        MessageBox.Show("Độ dài tối thiểu 10 hay 11 kí tự và phải là chuỗi số", "Thông Báo");
                    }
                    // dùng Validation kiểm tra tính hợp lệ của Email
                    else if (!IsValidEmail(txtEmail.Text))
                    {
                        MessageBox.Show("Địa chỉ email không hợp lệ!", "Thông Báo");
                    }
                    else
                    {
                        Session se = _sessionBus.GetSession();
                        User user = _userBus.GetByUsername(se.Name).FirstOrDefault();
                        if (txtUsername.Text != user.Username || txtPhone.Text != user.Phone || txtEmail.Text != user.Email)
                        { 
                            // Kiểm tra username đã có trong User hay Admin chưa
                            if (txtUsername.Text != user.Username && (!_userBus.CheckByUsername(txtUsername.Text) || !_adminBus.CheckByUsername(txtUsername.Text)))
                            {
                                MessageBox.Show("Username đã tồn tại, vui lòng thử lại!", "Thông Báo");
                            }// Kiểm tra email đã có trong User hay Admin chưa
                            else if (txtEmail.Text != user.Email && (!_userBus.CheckByEmail(txtEmail.Text) || !_adminBus.CheckByEmail(txtEmail.Text)))
                            {
                                MessageBox.Show("Email đã tồn tại, vui lòng thử lại!", "Thông Báo");
                            } else
                            {
                                _userBus.ChangeInfoByName(txtUsername.Text, txtEmail.Text, txtPhone.Text);
                                MessageBox.Show("thay đổi thành công!\nĐăng nhập lại để tiếp tục!", "Thông Báo");
                                this.frm_Login.Show();
                                this.frm_User.Close();
                            }
                        } else
                        {
                            MessageBox.Show("Vui lòng thay đổi thông tin nếu muốn thay đổi!", "Thông Báo");
                        }
                    }
                }
            }
            
        }
    }
}
