using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("gaming_table_bet")]
public partial class gaming_table_bet
{
    public int gtb_id { get; set; }

    public int gtb_gaming_table_id { get; set; }

    [StringLength(10)]
    public string gtb_iso_code { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal gtb_min_bet { get; set; }

    [Column(TypeName = "money")]
    public decimal gtb_max_bet { get; set; }

    public bool gtb_status { get; set; }
}
