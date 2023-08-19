using System;
using System.Collections.Generic;

namespace inventory_system_API.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string EMail { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int UserTypeId { get; set; }

    public string Password { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual UsersType UserType { get; set; } = null!;
}
