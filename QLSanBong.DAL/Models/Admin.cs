using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class Admin
{
    public string Name { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Id { get; set; }

    public virtual ICollection<AdminRole> AdminRoles { get; set; } = new List<AdminRole>();
}
