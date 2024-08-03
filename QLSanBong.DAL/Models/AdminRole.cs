using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class AdminRole
{
    public int Id { get; set; }

    public int AdminId { get; set; }

    public int RoleId { get; set; }

    public virtual Admin Admin { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
