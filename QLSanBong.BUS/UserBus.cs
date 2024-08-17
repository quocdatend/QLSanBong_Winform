using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class UserBus
    {
        private readonly QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();
        public UserBus(QlsanBongDaMiniContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public UserBus()
        {
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        //Add User
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        //Delele User
        public void Delele(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        
        // Find User by Username
        public List<User> GetByUsername(string username)
        {
            List<User> users = _context.Users.Where(x => x.Username.Equals(username)).ToList();
            return users;
        }

        // Find User by Id
        public List<User> GetById(int id)
        {
            List<User> users = _context.Users.Where(x => x.Id.Equals(id)).ToList();
            return users;
        }

        // Find User by Email
        public List<User> GetByEmail(string email)
        {
            List<User> users = _context.Users.Where(x => x.Email.Equals(email)).ToList();
            return users;
        }

        // Get All User
        public List<User> GetAll()
        {
            List<User> list = _context.Users.ToList();
            return list;
        }

        // Check User by Username
        public bool CheckByUsername(string name)
        {
            bool isTrue = _context.Users.Where(x => x.Username.Equals(name)).IsNullOrEmpty();
            return isTrue;
        }

        // Check User by Email
        public bool CheckByEmail(string email)
        {
            bool isTrue = _context.Users.Where(x => x.Email.Equals(email)).IsNullOrEmpty();
            return isTrue;
        }

        // Check User by id
        public bool CheckById(int id)
        {
            bool isTrue = _context.Users.Where(x => x.Id.Equals(id)).IsNullOrEmpty();
            return isTrue;
        }
        // Thay đổi mật khẩu bằng kiểm tra email
        public void ChangePasswordByEmail(string email, string password)
        {
            User user = _context.Users.Where(x => x.Email.Equals(email)).ToList()[0];
            user.Pass = password;
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }
        // Thay đổi thông tin tài khoản
        public void ChangeInfoByName(string name, string email, string phone, User user1)
        {
            User user = _context.Users.Where(x => x.Equals(user1)).ToList()[0];
            user.Username = name;
            user.Email = email;
            user.Phone = phone;
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
