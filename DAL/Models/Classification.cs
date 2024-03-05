using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Classification
{
    public string Classifications { get; set; } = null!;

    public int? Amount { get; set; }
}
