using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Location
{
    public string Zip { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? Neighborhood { get; set; }

    public string Street { get; set; } = null!;

    public string HouseNumber { get; set; } = null!;
}
