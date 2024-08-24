using Microsoft.EntityFrameworkCore;
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

        // add
        public void Add(PricePerHour pricePerHour)
        {
            _context.PricePerHours.Add(pricePerHour);
            _context.SaveChanges();
        }

        // Edit
        public void Edit(PricePerHour pricePerHour)
        {
            _context.Entry(pricePerHour).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Delete
        public void Delete(PricePerHour pricePerHour)
        {
            _context.PricePerHours.Remove(pricePerHour);
            _context.SaveChanges();
        }

        // get by time start, end
        public List<PricePerHour> GetByTime(DateTime start , DateTime end)
        {
            List<PricePerHour> getAll = _context.PricePerHours.ToList();
            List<PricePerHour> pricePerHours = getAll.Where(x => DateTime.ParseExact(x.TimeStart.ToString("HH:mm"), "HH:mm", null).TimeOfDay == DateTime.ParseExact(start.ToString("HH:mm"), "HH:mm", null).TimeOfDay
                                                                && DateTime.ParseExact(x.TimeEnd.ToString("HH:mm"), "HH:mm", null).TimeOfDay == DateTime.ParseExact(end.ToString("HH:mm"), "HH:mm", null).TimeOfDay).ToList();
            return pricePerHours;
        }
    }
}
