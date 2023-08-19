using System;
using System.Collections.Generic;

namespace inventory_system_API.Models;

public partial class Item
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Quantity { get; set; }

    public virtual ICollection<CategoriesOfItem> CategoriesOfItems { get; set; } = new List<CategoriesOfItem>();

    public virtual ICollection<ItemsTransaction> ItemsTransactions { get; set; } = new List<ItemsTransaction>();
}
