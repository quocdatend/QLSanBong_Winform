using Microsoft.IdentityModel.Tokens;
using QLSanBong.BUS;
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
    public partial class frm_CheckEmail : Form
    {
        private readonly AdminBus _adminBus = new AdminBus();
        private readonly UserBus _userBus = new UserBus();
        private readonly EmailBus _emailBus = new EmailBus();
        
        private string code = null;
        public frm_CheckEmail()
        {
            InitializeComponent();
        }
        // random code
        public string GenerateRandomCode()
        {
            Random random = new Random();
            StringBuilder code = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                int digit = random.Next(1, 10); // Generates a number between 1 and 9
                code.Append(digit);
            }

            return code.ToString();
        }
        // sự kiện check email
        private void btn_CheckEmail_Click(object sender, EventArgs e)
        {
            // tạo các biến
            bool isTrue = true, isAdmin = false;
            string email = txt_Email.Text;
            // gán random code
            this.code = GenerateRandomCode();
            string copyCode = code;
            // tạo biến cho email
            string subject = "Thay đổi mật khẩu";
            string body = "Chúng tôi đã nhận được yêu cầu thay đổi mật khẩu từ bạn. Để hoàn tất quá trình này, vui lòng sử dụng mã xác thực dưới đây:\n" +
                " \n" +
                "Mã xác thực của bạn: " + copyCode + "\n" +
                " \n" +
                "Vui lòng làm theo các bước sau để thay đổi mật khẩu của bạn:\n" +
                " \n" +
                "Truy cập trang thay đổi mật khẩu: Thay đổi mật khẩu (liên kết này sẽ đưa bạn đến trang thay đổi mật khẩu của chúng tôi).\n" +
                "Nhập mã xác thực: Vui lòng nhập mã xác thực mà bạn nhận được vào ô yêu cầu.\n" +
                "Tạo mật khẩu mới: Sau khi nhập mã xác thực, bạn sẽ được yêu cầu tạo một mật khẩu mới. Hãy chắc chắn rằng mật khẩu mới của bạn an toàn và dễ nhớ.\n" +
                "Nếu bạn gặp bất kỳ khó khăn nào trong quá trình này, vui lòng liên hệ với bộ phận hỗ trợ khách hàng của chúng tôi tại địa chỉ [hngdat2003@gmail.com] hoặc số điện thoại [0934897354].\n" +
                " \n" +
                "Chúng tôi xin lỗi vì sự bất tiện này và rất mong sớm giải quyết được vấn đề của bạn.\n" +
                " \n" +
                "Trân trọng,\n" +
                " \n" +
                 "Quoc Dat." + "\n";
            // check loại tài khoản theo email
            if (!_userBus.CheckByEmail(txt_Email.Text))
            {
                subject += " Người dùng!";
                isTrue = false;
            } else if (!_adminBus.CheckByEmail(txt_Email.Text))
            {
                subject += " Admin!";
                isTrue = false;
                isAdmin = true;
            }
            // thực hiện gửi email hoặc thông báo lỗi
            if (isTrue)
            {
                MessageBox.Show("Email chưa được đăng kí, vui lòng thử lại!", "Thông Báo");
            } else
            {
                _emailBus.SendEmailAsync(email, subject, body);
                MessageBox.Show("Đã gửi đến email: " + email, "Thông Báo");
                Form frm_CheckCode = new frm_CheckCode(email, isAdmin, copyCode);
                frm_CheckCode.ShowDialog();
                this.Close();
            }
        }
    }
}
