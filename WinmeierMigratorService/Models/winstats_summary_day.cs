using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("wsd_date", "wsd_provider", "wsd_terminal")]
[Table("winstats_summary_day")]
public partial class winstats_summary_day
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime wsd_date { get; set; }

    [Key]
    public int wsd_provider { get; set; }

    [Key]
    public int wsd_terminal { get; set; }

    public int wsd_area { get; set; }

    [Column(TypeName = "money")]
    public decimal wsd_netwin { get; set; }

    [Column(TypeName = "money")]
    public decimal wsd_coinin { get; set; }

    public long wsd_occupancy { get; set; }

    [Column(TypeName = "money")]
    public decimal? wsd_theoretical_payout { get; set; }
}
