using QLSanBong.BUS;
using QLSanBong.DAL.Models;
using QLSanBong.DAL;
using QLSanBong.GUI.Admins;
using QLSanBong.GUI.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong.GUI.Login
{
    public partial class frm_Login : Form
    {
        private readonly AdminBus _adminBus = new AdminBus();
        private readonly UserBus _userBus = new UserBus();
        private readonly SessionBus _sessionBus = new SessionBus();
        private readonly Encrypt _encrypt = new Encrypt();
        private readonly UserRoleBus _userRoleBus = new UserRoleBus();
        private readonly AdminRoleBus _adminRoleBus = new AdminRoleBus();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void lnklb_ForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Chuyển hướng đến form Check Email
            Form frm_CheckEmail = new frm_CheckEmail();
            frm_CheckEmail.ShowDialog();
        }

        private void lnklb_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Chuyển hướng đến form Đăng kí
            Form frm_SignUp = new frm_SignUp();
            frm_SignUp.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường đã nhập đủ chưa
            if(txt_Username.Text.Length == 0 || txt_Password.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ trường dữ liệu!", "Thông Báo");
            } else
            {
                // Mã hóa mật khẩu nhập vào
                string hashCode = _encrypt.GetSha256Hash(txt_Password.Text);
                // Tìm tài khoản theo tên với Admin hay User
                User user = _userBus.GetByUsername(txt_Username.Text).FirstOrDefault();
                Admin admin = _adminBus.GetByName(txt_Username.Text).FirstOrDefault();
                // Không tìm được tài khoản
                if(user == null && admin == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại, vui lòng thử lại!", "Thông Báo");
                }
                // Là Admin
                else if(user == null && admin != null)
                {
                    // So sánh mật khẩu
                    if (!hashCode.Equals(admin.Pass))
                    {
                        MessageBox.Show("Mật khẩu không đúng, vui lòng thử lại!", "Thông Báo");
                    }
                    else
                    {
                        // Lấy quyền theo id và gán vào phiên hiện tại
                        AdminRole adminRole = _adminRoleBus.GetByUserId(admin.Id).ToList()[0];
                        Session session = new Session()
                        {
                            Name = admin.Name,
                            Role = adminRole.RoleId,
                        };
                        _sessionBus.Add(session);
                        MessageBox.Show("Đăng nhập thành công!", "Thông Báo");
                        frm_Admin frmAdmin = new frm_Admin(this, _sessionBus);
                        frmAdmin.Show();
                        this.Hide();
                    }
                }
                // Là User
                else if (user != null && admin == null)
                {
                    // So sánh mật khẩu
                    if (!hashCode.Equals(user.Pass))
                    {
                        MessageBox.Show("Mật khẩu không đúng, vui lòng thử lại!", "Thông Báo");
                    }
                    else
                    {
                        // Lấy quyền theo id và gán vào phiên hiện tại
                        UserRole userRole = _userRoleBus.GetByUserId(user.Id).ToList()[0];
                        Session session = new Session()
                        {
                            Name = user.Username,
                            Role = userRole.RoleId,
                        };
                        _sessionBus.Add(session);
                        MessageBox.Show("Đăng nhập thành công!", "Thông Báo");
                        frm_User frmUser = new frm_User(this, _sessionBus);
                        frmUser.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
