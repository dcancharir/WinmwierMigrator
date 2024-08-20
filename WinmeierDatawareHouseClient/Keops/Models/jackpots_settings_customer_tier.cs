using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("jackpots_settings_customer_tier")]
public partial class jackpots_settings_customer_tier
{
    public int jct_id { get; set; }

    public int jct_jackpot_id { get; set; }

    public bool jct_by_level_enabled { get; set; }

    public bool jct_level_1 { get; set; }

    public bool jct_level_2 { get; set; }

    public bool jct_level_3 { get; set; }

    public bool jct_level_4 { get; set; }

    public bool jct_anonymous { get; set; }

    public int jct_vip { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jct_last_update { get; set; }

    public int? jct_level_mask { get; set; }
}
