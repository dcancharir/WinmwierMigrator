using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class gaming_table
{
    public int gt_gaming_table_id { get; set; }

    [StringLength(40)]
    public string gt_code { get; set; } = null!;

    public int gt_type_id { get; set; }

    [StringLength(100)]
    public string gt_name { get; set; } = null!;

    [StringLength(1024)]
    public string? gt_description { get; set; }

    public int? gt_area_id { get; set; }

    public int? gt_bank_id { get; set; }

    [StringLength(40)]
    public string? gt_floor_id { get; set; }

    [StringLength(6)]
    public string? gt_cur_iso_code { get; set; }

    public bool gt_enabled { get; set; }

    public bool gt_has_integrated_cashier { get; set; }

    public int? gt_cashier_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gt_created { get; set; }

    public int? gt_num_seats { get; set; }

    [Column(TypeName = "money")]
    public decimal? gt_bet_min { get; set; }

    [Column(TypeName = "money")]
    public decimal? gt_bet_max { get; set; }

    [Column(TypeName = "xml")]
    public string? gt_design_xml { get; set; }

    public int? gt_provider_id { get; set; }

    public int? gt_table_speed_slow { get; set; }

    public int? gt_table_speed_fast { get; set; }

    public int? gt_table_speed_normal { get; set; }

    public int? gt_table_speed_selected { get; set; }

    public long? gt_plays_count { get; set; }

    public int? gt_last_tick_plays_count { get; set; }

    public bool gt_player_tracking_pause { get; set; }

    public byte[] gt_timestamp { get; set; } = null!;

    public int? gt_table_idle_plays { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gt_last_tick_date { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? gt_theoric_hold { get; set; }

    public bool gt_dropbox_enabled { get; set; }

    [Column(TypeName = "money")]
    public decimal? gt_bet_min_curr_2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? gt_bet_max_curr_2 { get; set; }

    public bool gt_processing { get; set; }

    public int? gt_linked_cashier_id { get; set; }

    public int? gt_playstoautopause { get; set; }

    public int? gt_playstoautoexcluded { get; set; }

    public int gt_max_players_allowed { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? GT_STACKER_SERIAL_NUMBER { get; set; }

    public bool? gt_tips_enabled { get; set; }

    public bool? gt_tax_enabled { get; set; }
}
