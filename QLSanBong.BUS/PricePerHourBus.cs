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

        // get 
    }
}
