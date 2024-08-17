using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class OrderFoodDrinkDetail
{
    public int Id { get; set; }

    public int FoodDrinkId { get; set; }

    public int OrderFoodDrinkId { get; set; }

    public int Count { get; set; }

    public double Price { get; set; }

    public virtual FoodDrink FoodDrink { get; set; } = null!;

    public virtual OrderFoodDrink OrderFoodDrink { get; set; } = null!;
}
