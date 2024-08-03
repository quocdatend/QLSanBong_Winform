using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class OrderPitch
{
    public int Id { get; set; }

    public int PitchId { get; set; }

    public int UserId { get; set; }

    public TimeOnly TimeStart { get; set; }

    public TimeOnly TimeEnd { get; set; }

    public double Price { get; set; }

    public bool IsCheck { get; set; }

    public int PricePerHourId { get; set; }

    public bool IsPay { get; set; }

    public virtual ICollection<PaymentHistory> PaymentHistories { get; set; } = new List<PaymentHistory>();

    public virtual Pitch Pitch { get; set; } = null!;

    public virtual PricePerHour PricePerHour { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
