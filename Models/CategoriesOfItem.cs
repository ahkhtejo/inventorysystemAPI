using System;
using System.Collections.Generic;

namespace inventory_system_API.Models;

public partial class CategoriesOfItem
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;
}
