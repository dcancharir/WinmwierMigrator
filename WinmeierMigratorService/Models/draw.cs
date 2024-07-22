using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("dr_status", "dr_starting_date", "dr_ending_date", Name = "IX_dr_status_date")]
public partial class draw
{
    [Key]
    public long dr_id { get; set; }

    [StringLength(50)]
    public string dr_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime dr_starting_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime dr_ending_date { get; set; }

    public long dr_last_number { get; set; }

    [Column(TypeName = "money")]
    public decimal dr_number_price { get; set; }

    public int dr_status { get; set; }

    public bool dr_limited { get; set; }

    public int dr_limit { get; set; }

    public int dr_limit_per_voucher { get; set; }

    public long dr_initial_number { get; set; }

    public long dr_max_number { get; set; }

    public int dr_credit_type { get; set; }

    public string? dr_header { get; set; }

    public string? dr_footer { get; set; }

    public string? dr_detail1 { get; set; }

    public string? dr_detail2 { get; set; }

    public string? dr_detail3 { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal? dr_min_played_pct { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal? dr_min_spent_pct { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_min_cash_in { get; set; }

    [Column(TypeName = "xml")]
    public string? dr_provider_list { get; set; }

    [Column(TypeName = "xml")]
    public string? dr_offer_list { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_number_points { get; set; }

    public int dr_gender_filter { get; set; }

    public int dr_limit_per_operation { get; set; }

    public bool dr_first_cash_in_constrained { get; set; }

    public bool dr_bingo_format { get; set; }

    public long? dr_small_resource_id { get; set; }

    public long? dr_large_resource_id { get; set; }

    public int dr_level_filter { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level2 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level3 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level4 { get; set; }

    public bool? dr_vip { get; set; }

    public bool dr_visible_on_promobox { get; set; }

    public bool dr_award_on_promobox { get; set; }

    [StringLength(50)]
    public string? dr_text_on_promobox { get; set; }

    public bool? dr_auto_print { get; set; }
}
