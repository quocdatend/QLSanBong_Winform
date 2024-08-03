using Microsoft.Web.WebView2.Core;
using QLSanBong.BUS;
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
    public partial class frm_ChangePassword : Form
    {
        private readonly AdminBus _adminBus = new AdminBus();
        private readonly UserBus _userBus = new UserBus();
        private readonly Encrypt _encrypt = new Encrypt();
        private string email;
        private bool isAdmin;
        public frm_ChangePassword()
        {
            InitializeComponent();
        }
        public frm_ChangePassword(string e, bool isa)
        {
            InitializeComponent();
            email = e;
            isAdmin = isa;
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
        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            // logic change email
            if (txt_Password.Text.Equals(txt_ConfirmPass.Text) && txt_Password.Text.Length != 0)
            {
                // Kiểm tra là admin hay user muốn đổi mật khẩu
                if (isAdmin)
                {
                    _adminBus.ChangePasswordByEmail(email, _encrypt.GetSha256Hash(txt_Password.Text));
                }
                else
                {
                    _userBus.ChangePasswordByEmail(email, _encrypt.GetSha256Hash(txt_Password.Text));
                }
                MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu Không trùng khớp, vui lòng nhập lại!", "Thông báo!");
            }
        }

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
