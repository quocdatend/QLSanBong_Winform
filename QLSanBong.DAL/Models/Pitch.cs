using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class Pitch
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int TypePitchId { get; set; }

    public virtual ICollection<OrderPitch> OrderPitches { get; set; } = new List<OrderPitch>();

    public virtual TypePitch TypePitch { get; set; } = null!;
}
