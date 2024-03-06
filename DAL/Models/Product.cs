﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Product
{
    public int GmachCode { get; set; }

    public int ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public string Amount { get; set; } = null!;

    public string LeftInStock { get; set; } = null!;

    public byte[]? ProductImage { get; set; }
}