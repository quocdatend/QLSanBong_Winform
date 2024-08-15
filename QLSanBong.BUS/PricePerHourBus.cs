using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class PricePerHourBus
    {
        private readonly QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();
        public PricePerHourBus() { }

        // get all
        public List<PricePerHour> GetAll()
        {
            return _context.PricePerHours.ToList();
        }

        // get  by Id
        public List<PricePerHour> GetById(int id)
        {
            List<PricePerHour> list = _context.PricePerHours.Where(x => x.Id == id).ToList();
            return list;
        }
    }
}
