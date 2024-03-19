using System;
using System.Collections.Generic;

namespace DAL.DALObjects;

public partial class Classification
{
    public int ClassificationId { get; set; }

    public string ClassDescription { get; set; }

    public virtual ICollection<Gmach> Gmaches { get; set; } = new List<Gmach>();
}
