using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class PaymentHistoryBus
    {
        private QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();

        public PaymentHistoryBus() { }

        // get All
        public List<PaymentHistory> GetAll()
        {
            List<PaymentHistory> paymentHistories = _context.PaymentHistories.ToList();
            return paymentHistories;
        }

        // get by user id
        public List<PaymentHistory> GetByUserId(int userId)
        {
            List<PaymentHistory> paymentHistories = _context.PaymentHistories.Where(x=>x.UserId == userId).ToList();
            return paymentHistories;
        }

        // get by time
        public List<PaymentHistory> GetByTime(DateTime dateTime)
        {
            List<PaymentHistory> GetAll = _context.PaymentHistories.ToList();
            List<PaymentHistory> paymentHistories = GetAll.Where(x=>DateTime.ParseExact(x.Time.ToString(), "dd/MM/yyyy h:mm:ss tt", null)==dateTime).ToList();
            return paymentHistories;
        }

        // Get by day
        public List<PaymentHistory> GetByDay(DateTime dateTime)
        {
            List<PaymentHistory> getAll = _context.PaymentHistories.ToList();
            List<PaymentHistory> find = getAll.Where(x => DateTime.ParseExact(x.Time.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null) == dateTime).ToList();
            return find;
        }

        // Add
        public void Add(PaymentHistory paymentHistory)
        {
            _context.PaymentHistories.Add(paymentHistory);
            _context.SaveChanges();
        }

        // update check pay and price
        public void Update(PaymentHistory paymentHistory)
        {
            _context.Entry(paymentHistory).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
