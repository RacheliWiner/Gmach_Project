using System;
using System.Collections.Generic;

namespace DAL.DALObject;

public partial class OwnerPassword
{
    public int GmachCode { get; set; }

    public string OwnerPassword1 { get; set; }

    public virtual Gmach GmachCodeNavigation { get; set; }
}
