using System;
using System.Collections.Generic;

namespace Server.DALObject;

public partial class Gmach
{
    public int GmachCode { get; set; }

    public string GmachName { get; set; } = null!;

    public int Classifications { get; set; }

    public string? OpeningHours { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string? WhatsApp { get; set; }

    public string? Email { get; set; }

    public string MaxTime { get; set; } = null!;

    public virtual Classification ClassificationsNavigation { get; set; } = null!;

    public virtual Location? Location { get; set; }
}
