using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class PricePerHour
{
    public int Id { get; set; }

    public TimeOnly TimeStart { get; set; }

    public TimeOnly TimeEnd { get; set; }

    public double Price { get; set; }

    public virtual ICollection<OrderPitch> OrderPitches { get; set; } = new List<OrderPitch>();
}
