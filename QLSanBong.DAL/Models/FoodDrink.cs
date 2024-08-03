using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class FoodDrink
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Count { get; set; }

    public double Price { get; set; }

    public string? UrlImg { get; set; }

    public virtual ICollection<OrderFoodDrinkDetail> OrderFoodDrinkDetails { get; set; } = new List<OrderFoodDrinkDetail>();
}
