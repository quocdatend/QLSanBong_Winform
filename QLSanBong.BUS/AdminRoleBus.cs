using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class AdminRoleBus
    {
        private readonly QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();
        public AdminRoleBus(QlsanBongDaMiniContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public AdminRoleBus()
        {
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        //Add AdminRole
        public void Add(AdminRole adminRole)
        {
            _context.AdminRoles.Add(adminRole);
            _context.SaveChanges();
        }
        // Get By Admin Id
        public List<AdminRole> GetByUserId(int id)
        {
            List<AdminRole> adminRoles = _context.AdminRoles.Where(x => x.AdminId == id).ToList();
            return adminRoles;
        }
    }
}
