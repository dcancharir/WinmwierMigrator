using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("reserved_terminals_by_tier_configuration")]
public partial class reserved_terminals_by_tier_configuration
{
    public long rttc_configuration_id { get; set; }

    [StringLength(100)]
    public string rttc_name { get; set; } = null!;

    public bool rttc_enabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime rttc_date_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime rttc_date_to { get; set; }

    [Column(TypeName = "xml")]
    public string? rttc_group_list { get; set; }

    public short rttc_format_type { get; set; }

    public int rttc_level_mask { get; set; }

    [MaxLength(1)]
    public byte[] rttc_schedule { get; set; } = null!;

    public short rttc_holiday_like_day { get; set; }
}
