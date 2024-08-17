using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class PaymentHistory
{
    public int Id { get; set; }

    public double Price { get; set; }

    public DateTime Time { get; set; }

    public int UserId { get; set; }

    public int? OrderPitchId { get; set; }

    public int? OrderFoodDrinkId { get; set; }

    public virtual OrderFoodDrink? OrderFoodDrink { get; set; }

    public virtual OrderPitch? OrderPitch { get; set; }

    public virtual User User { get; set; } = null!;
}
