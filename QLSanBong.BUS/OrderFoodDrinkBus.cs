using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class OrderFoodDrinkBus
    {
        private QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();
        public OrderFoodDrinkBus() { }
        
        // get All
        public List<OrderFoodDrink> GetAll()
        {
            return _context.OrderFoodDrinks.ToList();
        }

        // Get by User Id
        public List<OrderFoodDrink> GetByUserId(int userId)
        {
            List<OrderFoodDrink> orderFoodDrinks = _context.OrderFoodDrinks.Where(x=>x.UserId == userId).ToList();
            return orderFoodDrinks;
        }

        // Get by Time
        public List<OrderFoodDrink> GetByTime(DateTime time)
        {
            List<OrderFoodDrink> orderFoodDrinks = _context.OrderFoodDrinks.ToList();
            List<OrderFoodDrink> find = orderFoodDrinks.Where(x => DateTime.ParseExact(x.Time.ToString(), "dd/MM/yyyy h:mm:ss tt", null) ==  time).ToList();
            return find;
        }

        // add
        public void Add(OrderFoodDrink orderFoodDrink)
        {
            _context.OrderFoodDrinks.Add(orderFoodDrink);
            _context.SaveChanges();
        }
    }
}
