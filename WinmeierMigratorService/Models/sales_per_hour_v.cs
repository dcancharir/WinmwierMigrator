using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class sales_per_hour_v
{
    [Column(TypeName = "datetime")]
    public DateTime sph_base_hour { get; set; }

    public int sph_terminal_id { get; set; }

    [StringLength(50)]
    public string? sph_terminal_name { get; set; }

    public long sph_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal sph_played_amount { get; set; }

    public long sph_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal sph_won_amount { get; set; }

    public short sph_num_active_terminals { get; set; }

    public long sph_last_play_id { get; set; }

    [Column(TypeName = "money")]
    public decimal sph_theoretical_won_amount { get; set; }

    public int SPH_GAME_ID { get; set; }

    [StringLength(50)]
    public string SPH_GAME_NAME { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? sph_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? sph_progressive_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? sph_progressive_jackpot_amount_0 { get; set; }

    [Column(TypeName = "money")]
    public decimal? sph_progressive_provision_amount { get; set; }
}
