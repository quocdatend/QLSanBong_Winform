using QLSanBong.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong.BUS
{
    public class FoodDrinkBus
    {
        private QlsanBongDaMiniContext _context = new QlsanBongDaMiniContext();

        public FoodDrinkBus() { }

        // get All
        public List<FoodDrink> GetAll()
        {
            return _context.FoodDrinks.ToList();
        }

        // remove
        public void Remove(FoodDrink drink)
        {
            _context.FoodDrinks.Remove(drink);
            _context.SaveChanges();
        }

        // add
        public void Add(FoodDrink drink)
        {
            _context.FoodDrinks.Add(drink);
            _context.SaveChanges();
        }

        // get by name
        public List<FoodDrink> GetByName(string name)
        {
            List<FoodDrink> foodDrinks = _context.FoodDrinks.Where(x=>x.Name.Equals(name)).ToList();
            return foodDrinks;
        }
    }
}
