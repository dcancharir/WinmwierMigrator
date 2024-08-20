using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("gm_terminal_id", "gm_game_base_name")]
public partial class game_meter
{
    [Key]
    public int gm_terminal_id { get; set; }

    [Key]
    [StringLength(50)]
    public string gm_game_base_name { get; set; } = null!;

    public long gm_wcp_sequence_id { get; set; }

    [Column(TypeName = "money")]
    public decimal gm_denomination { get; set; }

    public long gm_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal gm_played_amount { get; set; }

    public long gm_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal gm_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gm_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gm_handpays_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gm_last_reported { get; set; }

    [StringLength(50)]
    public string? gm_delta_game_name { get; set; }

    public long? gm_delta_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? gm_delta_played_amount { get; set; }

    public long? gm_delta_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? gm_delta_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gm_delta_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gm_delta_handpays_amount { get; set; }

    public bool? gm_delta_updating { get; set; }

    public long? gm_max_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? gm_max_played_amount { get; set; }

    public long? gm_max_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? gm_max_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gm_max_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gm_progressive_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gm_delta_progressive_jackpot_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? gm_max_progressive_jackpot_amount { get; set; }
}
