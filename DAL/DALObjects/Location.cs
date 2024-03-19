using System;
using System.Collections.Generic;

namespace DAL.DALObjects;

public partial class Location
{
    public int GmachCode { get; set; }

    public string Zip { get; set; }

    public string City { get; set; }

    public string Neighborhood { get; set; }

    public string Street { get; set; }

    public string HouseNumber { get; set; }

    public virtual Gmach GmachCodeNavigation { get; set; }
}
