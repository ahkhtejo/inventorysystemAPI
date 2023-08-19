using System;
using System.Collections.Generic;

namespace inventory_system_API.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public int ItemId { get; set; }

    public int TransactionTypeId { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<ItemsTransaction> ItemsTransactions { get; set; } = new List<ItemsTransaction>();

    public virtual TransactionsType TransactionType { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
