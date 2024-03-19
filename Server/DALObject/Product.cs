using System;
using System.Collections.Generic;

namespace Server.DALObject;

public partial class Product
{
    public int GmachCode { get; set; }

    public int ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public string Amount { get; set; } = null!;

    public int? Price { get; set; }

    public string LeftInStock { get; set; } = null!;

    public virtual Gmach GmachCodeNavigation { get; set; } = null!;
}
