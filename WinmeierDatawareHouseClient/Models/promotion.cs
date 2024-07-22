using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class promotion
{
    [Key]
    public long pm_promotion_id { get; set; }

    [StringLength(50)]
    public string? pm_name { get; set; }

    public bool pm_enabled { get; set; }

    public int pm_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pm_date_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime pm_date_finish { get; set; }

    public int pm_schedule_weekday { get; set; }

    public int pm_schedule1_time_from { get; set; }

    public int pm_schedule1_time_to { get; set; }

    public bool pm_schedule2_enabled { get; set; }

    public int? pm_schedule2_time_from { get; set; }

    public int? pm_schedule2_time_to { get; set; }

    public int pm_gender_filter { get; set; }

    public int pm_birthday_filter { get; set; }

    public int pm_expiration_type { get; set; }

    public int pm_expiration_value { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_min_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_min_cash_in_reward { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_cash_in_reward { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_won_lock { get; set; }

    public int pm_num_tokens { get; set; }

    [StringLength(50)]
    public string? pm_token_name { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_token_reward { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_daily_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_monthly_limit { get; set; }

    public int pm_level_filter { get; set; }

    public int pm_permission { get; set; }

    public int? pm_freq_filter_last_days { get; set; }

    public int? pm_freq_filter_min_days { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_freq_filter_min_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_min_spent { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_min_spent_reward { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_spent { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_spent_reward { get; set; }

    [Column(TypeName = "xml")]
    public string? pm_provider_list { get; set; }

    [Column(TypeName = "xml")]
    public string? pm_offer_list { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_global_daily_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_global_monthly_limit { get; set; }

    public long? pm_small_resource_id { get; set; }

    public long? pm_large_resource_id { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_min_played { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_min_played_reward { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_played { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_played_reward { get; set; }

    public bool pm_play_restricted_to_provider_list { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pm_last_executed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pm_next_execution { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_global_limit { get; set; }

    public int pm_credit_type { get; set; }

    public int pm_category_id { get; set; }

    [StringLength(250)]
    public string? pm_ticket_footer { get; set; }

    public bool pm_visible_on_promobox { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pm_expiration_limit { get; set; }

    [Column(TypeName = "xml")]
    public string? pm_restricted_to_terminal_list { get; set; }

    public long? pm_points_to_credits_id { get; set; }

    public int? pm_award_on_promobox { get; set; }

    [StringLength(50)]
    public string? pm_text_on_promobox { get; set; }

    public int? pm_ticket_quantity { get; set; }

    public int? pm_generated_tickets { get; set; }

    public bool? pm_vip { get; set; }

    public int? pm_created_account_filter { get; set; }

    public bool? pm_apply_tax { get; set; }
}
