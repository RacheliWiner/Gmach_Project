using System;
using System.Collections.Generic;

namespace Server.DALObject;

public partial class Location
{
    public int GmachCode { get; set; }

    public string Zip { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? Neighborhood { get; set; }

    public string Street { get; set; } = null!;

    public string HouseNumber { get; set; } = null!;

    public virtual Gmach GmachCodeNavigation { get; set; } = null!;
}
