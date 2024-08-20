using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gaming_tables_tournament
{
    public long gtt_tournament_id { get; set; }

    public int gtt_tournament_status { get; set; }

    [StringLength(200)]
    public string gtt_tournament_name { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal gtt_fixed_prize_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtt_increment_prize_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtt_total_prize_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal gtt_admission_amount { get; set; }

    public int gtt_rebuy { get; set; }

    [Column(TypeName = "money")]
    public decimal gtt_rebuy_amount { get; set; }

    [Column(TypeName = "numeric(7, 4)")]
    public decimal gtt_rebuy_pctj_contribution { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gtt_event_start_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gtt_event_finish_date { get; set; }

    public int gtt_game_rounds { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gtt_inscription_start_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gtt_inscription_finish_date { get; set; }

    public int gtt_game_type { get; set; }

    [StringLength(2048)]
    public string gtt_rules { get; set; } = null!;

    public int gtt_capacity { get; set; }

    public int gtt_seats { get; set; }

    public bool gtt_enabled { get; set; }

    [Column(TypeName = "xml")]
    public string? gtt_available_tables { get; set; }
}
