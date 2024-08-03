using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class UserRoleBus
    {
        private readonly QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();
        public UserRoleBus(QlsanBongDaMiniContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public UserRoleBus()
        {
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        //Add UserRole
        public void Add(UserRole userRole)
        {
            _context.UserRoles.Add(userRole);
            _context.SaveChanges();
        }
        // Get By User Id
        public List<UserRole> GetByUserId(int userId)
        {
            List<UserRole> userRoles = _context.UserRoles.Where(x=>x.UserId == userId).ToList();
            return userRoles;
        }
    }
}
