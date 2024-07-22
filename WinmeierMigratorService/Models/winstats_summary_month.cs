using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("wsm_date", "wsm_provider", "wsm_terminal")]
[Table("winstats_summary_month")]
public partial class winstats_summary_month
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime wsm_date { get; set; }

    [Key]
    public int wsm_provider { get; set; }

    [Key]
    public int wsm_terminal { get; set; }

    public int wsm_area { get; set; }

    [Column(TypeName = "money")]
    public decimal wsm_netwin { get; set; }

    [Column(TypeName = "money")]
    public decimal wsm_coinin { get; set; }

    public long wsm_occupancy { get; set; }

    [Column(TypeName = "money")]
    public decimal? wsm_theoretical_payout { get; set; }
}
