using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("gt_area_id", Name = "IX_gaming_tables_gt_area_id")]
[Index("gt_cur_iso_code", Name = "IX_gaming_tables_gt_cur_iso_code")]
[Index("gt_enabled", "gt_name", "gt_cashier_id", "gt_gaming_table_id", "gt_code", Name = "IX_gamning_tables_combos")]
[Index("gt_cashier_id", Name = "IX_gt_cashier_id")]
[Index("gt_name", Name = "IX_gt_name")]
[Index("gt_type_id", "gt_name", Name = "IX_gt_type_id_gt_name")]
public partial class gaming_table
{
    [Key]
    public int gt_gaming_table_id { get; set; }

    [StringLength(20)]
    public string gt_code { get; set; } = null!;

    public int gt_type_id { get; set; }

    [StringLength(50)]
    public string gt_name { get; set; } = null!;

    [StringLength(512)]
    public string? gt_description { get; set; }

    public int? gt_area_id { get; set; }

    public int? gt_bank_id { get; set; }

    [StringLength(20)]
    public string? gt_floor_id { get; set; }

    [StringLength(3)]
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

    public int? gt_plays_count { get; set; }

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
}
