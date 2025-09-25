﻿using System;
using System.Collections.Generic;

namespace ASM1.Repository.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }

    public decimal Amount { get; set; }

    public string Method { get; set; } = null!;

    public DateOnly? PaymentDate { get; set; }

    public virtual Order Order { get; set; } = null!;
}
