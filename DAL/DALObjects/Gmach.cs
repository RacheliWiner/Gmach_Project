﻿using System;
using System.Collections.Generic;

namespace DAL.DALObjects;

public partial class Gmach
{
    public int GmachCode { get; set; }

    public string GmachName { get; set; }

    public int Classifications { get; set; }

    public string OpeningHours { get; set; }

    public string PhoneNumber { get; set; }

    public string WhatsApp { get; set; }

    public string Email { get; set; }

    public string MaxTime { get; set; }

    public virtual Classification ClassificationsNavigation { get; set; }

    public virtual Location Location { get; set; }
}
