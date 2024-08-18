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
    }
}
