﻿using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class PricePerHour
{
    public int Id { get; set; }

    public TimeOnly TimeStart { get; set; }

    public double Price { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<OrderPitch> OrderPitches { get; set; } = new List<OrderPitch>();
}
