using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<AdminRole> AdminRoles { get; set; } = new List<AdminRole>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
