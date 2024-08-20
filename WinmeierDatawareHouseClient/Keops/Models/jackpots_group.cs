using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("jackpots_group")]
public partial class jackpots_group
{
    public int jg_id { get; set; }

    [StringLength(50)]
    public string jg_name { get; set; } = null!;

    [StringLength(100)]
    public string? jg_description { get; set; }

    public int jg_jackpot_type { get; set; }

    public bool jg_enabled { get; set; }
}
