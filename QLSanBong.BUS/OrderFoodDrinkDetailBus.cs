using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class OrderFoodDrinkDetailBus
    {
        private QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();
        public OrderFoodDrinkDetailBus() { }
        // get all
        public List<OrderFoodDrinkDetail> GetAll()
        {
            return _context.OrderFoodDrinkDetails.ToList();
        }

        // get by OrderFoodDrinkId
        public List<OrderFoodDrinkDetail> GetByOrderFoodDrinkId(int orderFoodDrinkId)
        {
            List<OrderFoodDrinkDetail> orderFoodDrinkDetails = _context.OrderFoodDrinkDetails.Where(x=>x.OrderFoodDrinkId == orderFoodDrinkId).ToList();
            return orderFoodDrinkDetails;
        }
    }
}
