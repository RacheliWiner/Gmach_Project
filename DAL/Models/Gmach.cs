using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Gmach
{
    public int GmachCode { get; set; }

    public string GmachName { get; set; } = null!;

    public string Classifications { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string? OpeningHours { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string? WhatsApp { get; set; }

    public string? Email { get; set; }

    public int Price { get; set; }

    public string MaxTime { get; set; } = null!;

    public virtual Classification ClassificationsNavigation { get; set; } = null!;

    public virtual Product GmachCodeNavigation { get; set; } = null!;

    public virtual Location ZipNavigation { get; set; } = null!;
}
