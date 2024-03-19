using System;
using System.Collections.Generic;

namespace Server.DALObject;

public partial class OwnerPassword
{
    public int GmachCode { get; set; }

    public string OwnerPassword1 { get; set; } = null!;

    public virtual Gmach GmachCodeNavigation { get; set; } = null!;
}
