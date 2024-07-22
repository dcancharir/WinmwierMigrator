using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("mdsh_base_hour", "mdsh_terminal_id", "mdsh_denomination")]
[Table("machine_denom_stats_per_hour")]
public partial class machine_denom_stats_per_hour
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime mdsh_base_hour { get; set; }

    [Key]
    public int mdsh_terminal_id { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal mdsh_denomination { get; set; }

    [Column(TypeName = "money")]
    public decimal mdsh_played_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal mdsh_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? mdsh_jackpot_amount { get; set; }

    public long mdsh_played_count { get; set; }

    public long mdsh_won_count { get; set; }

    public byte[] mdsh_timestamp { get; set; } = null!;
}
