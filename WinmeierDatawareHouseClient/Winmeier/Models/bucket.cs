using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class bucket
{
    [Key]
    public long bu_bucket_id { get; set; }

    [StringLength(100)]
    public string bu_name { get; set; } = null!;

    public bool? bu_enabled { get; set; }

    public int? bu_system_type { get; set; }

    public int? bu_bucket_type { get; set; }

    public long? bu_visible_flags { get; set; }

    public int? bu_order_on_reports { get; set; }

    public int? bu_expiration_days { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? bu_expiration_date { get; set; }

    public bool bu_level_flags { get; set; }

    public bool? bu_k_factor { get; set; }

    public byte[] bu_timestamp { get; set; } = null!;

    public long? bu_master_sequence_id { get; set; }

    public bool bu_multiplier_enabled { get; set; }
}
