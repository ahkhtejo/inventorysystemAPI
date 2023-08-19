using System;
using System.Collections.Generic;

namespace inventory_system_API.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CategoriesOfItem> CategoriesOfItems { get; set; } = new List<CategoriesOfItem>();
}
