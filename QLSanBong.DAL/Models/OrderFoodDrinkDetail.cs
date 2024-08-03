using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class OrderFoodDrinkDetail
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int FoodDrinkId { get; set; }

    public int Count { get; set; }

    public double TotalPrice { get; set; }

    public virtual FoodDrink FoodDrink { get; set; } = null!;

    public virtual ICollection<PaymentHistory> PaymentHistories { get; set; } = new List<PaymentHistory>();

    public virtual User User { get; set; } = null!;
}
