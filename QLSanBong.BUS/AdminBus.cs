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
    public class AdminBus
    {
        private readonly QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();
        public AdminBus(QlsanBongDaMiniContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public AdminBus()
        {
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        //Add Admin
        public void Add(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }

        //Delele Admin
        public void Delele(Admin admin)
        {
            _context.Admins.Remove(admin);
            _context.SaveChanges();
        }

        // Find Admin by name
        public List<Admin> GetByName(string name)
        {
            List<Admin> admins = _context.Admins.Where(x => x.Name.Equals(name)).ToList();
            return admins;
        }

        // Find Admin by Id
        public List<Admin> GetById(int id)
        {
            List<Admin> admins = _context.Admins.Where(x => x.Id.Equals(id)).ToList();
            return admins;
        }

        // Find Admin by Email
        public List<Admin> GetByEmail(string email)
        {
            List<Admin> admins = _context.Admins.Where(x => x.Email.Equals(email)).ToList();
            return admins;
        }

        // Get All Admin
        public List<Admin> GetAll()
        {
            List<Admin> list = _context.Admins.ToList();
            return list;
        }

        // Check Admin by name
        public bool CheckByUsername(string name)
        {
            bool isTrue = _context.Admins.Where(x => x.Name.Equals(name)).IsNullOrEmpty();
            return isTrue;
        }

        // Check Admin by Email
        public bool CheckByEmail(string email)
        {
            bool isTrue = _context.Admins.Where(x => x.Email.Equals(email)).IsNullOrEmpty();
            return isTrue;
        }

        // Check Admin by Id
        public bool CheckById(int id)
        {
            bool isTrue = _context.Admins.Where(x => x.Id.Equals(id)).IsNullOrEmpty();
            return isTrue;
        }
        // Thay đổi mật khẩu bằng kiểm tra email
        public void ChangePasswordByEmail(string email, string password)
        {
            Admin admin = _context.Admins.Where(x => x.Email.Equals(email)).ToList()[0];
            admin.Pass = password;
            _context.Entry(admin).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
