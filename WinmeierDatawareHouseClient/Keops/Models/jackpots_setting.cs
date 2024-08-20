using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class jackpots_setting
{
    public int js_jackpot_id { get; set; }

    [StringLength(100)]
    public string js_name { get; set; } = null!;

    public bool js_enabled { get; set; }

    public int? js_type { get; set; }

    [StringLength(6)]
    public string js_iso_code { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? js_minimum { get; set; }

    [Column(TypeName = "money")]
    public decimal? js_maximum { get; set; }

    [Column(TypeName = "money")]
    public decimal? js_average { get; set; }

    public int js_payout_mode { get; set; }

    public int js_credit_prize_type { get; set; }

    public bool js_adv_notification_enabled { get; set; }

    public int js_adv_notification_time { get; set; }

    public bool? js_adv_notification_flag { get; set; }

    public int? js_num_pending { get; set; }

    public int? js_max_num_pending { get; set; }

    public bool? js_probability_with_max { get; set; }

    public int? js_compensation_type { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? js_compensation_fixed_pct { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? js_prize_sharing_pct { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? js_hidden_pct { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? js_happy_hour_pct { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? js_last_update { get; set; }

    public int js_jackpot_type { get; set; }

    public int js_min_time_between_hits { get; set; }
}
