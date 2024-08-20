using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

public partial class bonusing_game
{
    [Key]
    public long bg_bonusing_game_id { get; set; }

    [StringLength(50)]
    public string? bg_name { get; set; }

    [StringLength(250)]
    public string? bg_Description { get; set; }

    public int bg_status { get; set; }

    public int bg_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime bg_date_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime bg_date_finish { get; set; }

    public int bg_schedule_weekday { get; set; }

    public int bg_schedule1_time_from { get; set; }

    public int bg_schedule1_time_to { get; set; }

    public bool bg_schedule2_enabled { get; set; }

    public int? bg_schedule2_time_from { get; set; }

    public int? bg_schedule2_time_to { get; set; }

    [Column(TypeName = "money")]
    public decimal bg_min_points { get; set; }

    [Column(TypeName = "xml")]
    public string? bg_provider_list { get; set; }

    public int bg_gender_filter { get; set; }

    public int bg_level_filter { get; set; }

    [Column(TypeName = "money")]
    public decimal? bg_daily_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? bg_monthly_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal bg_bet_amount_1 { get; set; }

    [Column(TypeName = "money")]
    public decimal bg_bet_amount_2 { get; set; }

    [Column(TypeName = "money")]
    public decimal bg_bet_amount_3 { get; set; }

    [Column(TypeName = "money")]
    public decimal bg_bet_amount_4 { get; set; }

    [StringLength(250)]
    public string? bg_bet_message { get; set; }
}
