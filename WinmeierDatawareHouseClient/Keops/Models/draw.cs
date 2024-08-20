using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class draw
{
    public long dr_id { get; set; }

    [StringLength(100)]
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

    [StringLength(100)]
    public string? dr_text_on_promobox { get; set; }

    public int dr_auto_print { get; set; }

    public bool? dr_use_first_price { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_number_first_price { get; set; }

    [Column(TypeName = "xml")]
    public string? dr_entry_levels_points { get; set; }

    public string? dr_observations { get; set; }

    [StringLength(10)]
    public string? dr_type_document { get; set; }

    public bool? dr_first_document { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level5 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level6 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level7 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level8 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level9 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level10 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level11 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level12 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level13 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level14 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level15 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level16 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level17 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level18 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level19 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level20 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level21 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level22 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level23 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level24 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level25 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level26 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level27 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level28 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level29 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level30 { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_points_level31 { get; set; }

    [Column(TypeName = "xml")]
    public string? dr_offer_cash_in_condition { get; set; }

    [Column(TypeName = "money")]
    public decimal? dr_amount_prize_tax_form { get; set; }

    public bool? dr_include_prize_tax_form { get; set; }

    public int DR_BIRTHDAY_FILTER { get; set; }

    public bool dr_all_accounts { get; set; }

    [Column(TypeName = "xml")]
    public string? dr_nationality_list { get; set; }

    public int? dr_created_account_filter { get; set; }

    public bool dr_flag_require { get; set; }

    public bool dr_flag_require_type { get; set; }

    public byte dr_show_status { get; set; }

    public long? dr_small_resource_id_55 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dr_show_status_last_update { get; set; }

    public bool dr_has_schedule { get; set; }

    public bool dr_flag_assign_require { get; set; }

    public byte[]? dr_timestamp { get; set; }
}
