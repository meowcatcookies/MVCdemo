﻿using System;
using System.Collections.Generic;

namespace mvcdemo8.Models;

public partial class NewsLetter
{
    public int Id { get; set; }

    public string? UserEmail { get; set; }

    public DateTime? SubscribeDate { get; set; }

    public string? Remark { get; set; }
}
