using System;
using System.Collections.Generic;

namespace inventory_system_API.Models;

public partial class ItemsTransaction
{
    public int Id { get; set; }

    public int? ItemsId { get; set; }

    public int? TransactionsId { get; set; }

    public virtual Item? Items { get; set; }

    public virtual Transaction? Transactions { get; set; }
}
