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

    public int? OrderFoodDrinkDetailId { get; set; }

    public virtual OrderFoodDrinkDetail? OrderFoodDrinkDetail { get; set; }

    public virtual OrderPitch? OrderPitch { get; set; }

    public virtual User User { get; set; } = null!;
}
