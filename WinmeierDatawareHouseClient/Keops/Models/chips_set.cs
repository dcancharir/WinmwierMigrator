using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class chips_set
{
    public long chs_chip_set_id { get; set; }

    [StringLength(6)]
    public string chs_iso_code { get; set; } = null!;

    [StringLength(100)]
    public string chs_name { get; set; } = null!;

    public bool chs_allowed { get; set; }

    public int? chs_chip_type { get; set; }

    public int chs_allowed_operations_flags { get; set; }
}
