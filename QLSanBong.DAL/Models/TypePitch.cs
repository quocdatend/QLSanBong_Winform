using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class TypePitch
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pitch> Pitches { get; set; } = new List<Pitch>();
}
