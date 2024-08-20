using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("msh_base_hour", "msh_terminal_id")]
[Table("machine_stats_per_hour")]
public partial class machine_stats_per_hour
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime msh_base_hour { get; set; }

    [Key]
    public int msh_terminal_id { get; set; }

    public long msh_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal msh_played_amount { get; set; }

    public long msh_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal msh_won_amount { get; set; }

    public long msh_to_gm_count { get; set; }

    [Column(TypeName = "money")]
    public decimal msh_to_gm_amount { get; set; }

    public long msh_from_gm_count { get; set; }

    [Column(TypeName = "money")]
    public decimal msh_from_gm_amount { get; set; }

    public byte[] msh_timestamp { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? msh_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? msh_progressive_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? msh_progressive_jackpot_amount_0 { get; set; }

    [Column(TypeName = "money")]
    public decimal? msh_progressive_provision_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? msh_hpc_handpays_amount { get; set; }
}
