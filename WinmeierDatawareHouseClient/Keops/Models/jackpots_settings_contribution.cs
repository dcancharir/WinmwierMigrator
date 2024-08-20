using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("jackpots_settings_contribution")]
public partial class jackpots_settings_contribution
{
    public int jsc_id { get; set; }

    public int jsc_jackpot_id { get; set; }

    [StringLength(100)]
    public string jsc_name { get; set; } = null!;

    public int jsc_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? jsc_fixed_contribution { get; set; }

    [Column(TypeName = "money")]
    public decimal? jsc_monday { get; set; }

    [Column(TypeName = "money")]
    public decimal? jsc_tuesday { get; set; }

    [Column(TypeName = "money")]
    public decimal? jsc_wednesday { get; set; }

    [Column(TypeName = "money")]
    public decimal? jsc_thursday { get; set; }

    [Column(TypeName = "money")]
    public decimal? jsc_friday { get; set; }

    [Column(TypeName = "money")]
    public decimal? jsc_saturday { get; set; }

    [Column(TypeName = "money")]
    public decimal? jsc_sunday { get; set; }

    [Column(TypeName = "xml")]
    public string? jsc_terminals { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jsc_last_update { get; set; }
}
