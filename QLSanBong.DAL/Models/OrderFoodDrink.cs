using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class OrderFoodDrink
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime Time { get; set; }

    public virtual ICollection<OrderFoodDrinkDetail> OrderFoodDrinkDetails { get; set; } = new List<OrderFoodDrinkDetail>();

    public virtual ICollection<PaymentHistory> PaymentHistories { get; set; } = new List<PaymentHistory>();

    public virtual User User { get; set; } = null!;
}
