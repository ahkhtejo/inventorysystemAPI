using System;
using System.Collections.Generic;

namespace inventory_system_API.Models;

public partial class TransactionsType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
