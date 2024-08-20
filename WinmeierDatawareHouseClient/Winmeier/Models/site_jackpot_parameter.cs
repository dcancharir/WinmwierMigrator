using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
public partial class site_jackpot_parameter
{
    public bool sjp_enabled { get; set; }

    [Column(TypeName = "numeric(7, 4)")]
    public decimal sjp_contribution_pct { get; set; }

    public int sjp_awarding_days { get; set; }

    public int sjp_awarding_start { get; set; }

    public int sjp_awarding_end { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal sjp_awarding_min_occupation_pct { get; set; }

    public bool sjp_awarding_exclude_promotions { get; set; }

    public bool sjp_awarding_exclude_anonymous { get; set; }

    public int sjp_animation_interval { get; set; }

    public int sjp_recent_interval { get; set; }

    public string? sjp_promo_message1 { get; set; }

    public string? sjp_promo_message2 { get; set; }

    public string? sjp_promo_message3 { get; set; }

    [Column(TypeName = "numeric(20, 8)")]
    public decimal sjp_to_compensate { get; set; }

    public bool sjp_only_redeemable { get; set; }

    public int sjp_average_interval_hours { get; set; }

    [Column(TypeName = "numeric(20, 8)")]
    public decimal sjp_played { get; set; }

    public int sjp_animation_interval2 { get; set; }

    public bool sjp_show_winner_name { get; set; }

    public bool sjp_show_terminal_name { get; set; }

    public int sjp_award_mode { get; set; }

    [Column(TypeName = "xml")]
    public string? sjp_terminal_list { get; set; }

    public bool SJP_EXCEED_MAXIMUM_ALLOWED { get; set; }

    [Column(TypeName = "money")]
    public decimal SJP_CURRENT_COMPENSATION_PCT { get; set; }

    public bool sjp_contribution_fix { get; set; }

    [Column(TypeName = "numeric(7, 4)")]
    public decimal sjp_contribution_pct0 { get; set; }

    [Column(TypeName = "numeric(7, 4)")]
    public decimal sjp_contribution_pct1 { get; set; }

    [Column(TypeName = "numeric(7, 4)")]
    public decimal sjp_contribution_pct2 { get; set; }

    [Column(TypeName = "numeric(7, 4)")]
    public decimal sjp_contribution_pct3 { get; set; }

    [Column(TypeName = "numeric(7, 4)")]
    public decimal sjp_contribution_pct4 { get; set; }

    [Column(TypeName = "numeric(7, 4)")]
    public decimal sjp_contribution_pct5 { get; set; }

    [Column(TypeName = "numeric(7, 4)")]
    public decimal sjp_contribution_pct6 { get; set; }
}
