using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class pinpad_cashier_terminal
{
    [Key]
    public int pct_id { get; set; }

    public int pct_cashier_id { get; set; }

    public int pct_type { get; set; }

    public int pct_port { get; set; }

    public bool pct_enabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pct_last_modified { get; set; }
}
