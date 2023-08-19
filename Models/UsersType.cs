using System;
using System.Collections.Generic;

namespace inventory_system_API.Models;

public partial class UsersType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
