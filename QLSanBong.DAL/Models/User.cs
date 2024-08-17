using System;
using System.Collections.Generic;

namespace QLSanBong.DAL.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<OrderFoodDrink> OrderFoodDrinks { get; set; } = new List<OrderFoodDrink>();

    public virtual ICollection<OrderPitch> OrderPitches { get; set; } = new List<OrderPitch>();

    public virtual ICollection<PaymentHistory> PaymentHistories { get; set; } = new List<PaymentHistory>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
