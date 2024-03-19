using System;
using System.Collections.Generic;

namespace Server.DALObject;

public partial class Classification
{
    public int ClassificationId { get; set; }

    public string ClassDescription { get; set; } = null!;

    public virtual ICollection<Gmach> Gmaches { get; set; } = new List<Gmach>();
}
