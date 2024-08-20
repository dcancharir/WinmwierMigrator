using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class promotion
{
    public long pm_promotion_id { get; set; }

    [StringLength(100)]
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

    [StringLength(100)]
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

    [StringLength(500)]
    public string? pm_ticket_footer { get; set; }

    public bool pm_visible_on_promobox { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pm_expiration_limit { get; set; }

    [Column(TypeName = "xml")]
    public string? pm_restricted_to_terminal_list { get; set; }

    public long? pm_points_to_credits_id { get; set; }

    public int? pm_award_on_promobox { get; set; }

    [StringLength(100)]
    public string? pm_text_on_promobox { get; set; }

    public int? pm_ticket_quantity { get; set; }

    public int? pm_generated_tickets { get; set; }

    public bool? pm_vip { get; set; }

    public int? pm_created_account_filter { get; set; }

    public bool? pm_apply_tax { get; set; }

    public long? pm_promogame_id { get; set; }

    public bool pm_journey_limit { get; set; }

    [Column(TypeName = "xml")]
    public string? pm_pyramidal_dist { get; set; }

    [Column(TypeName = "money")]
    public decimal? PM_PCT_BY_CHARGE { get; set; }

    public int PM_ORDER { get; set; }

    public bool pm_automatically_assign_sashost { get; set; }

    public bool pm_automatically_assign_cashier { get; set; }

    public bool pm_automatically_assign_promobox { get; set; }

    public bool pm_automatically_promotion { get; set; }

    public bool pm_spent_flags { get; set; }

    public int? pm_status { get; set; }

    public long? pm_ms_sequence_id { get; set; }

    public long? pm_ms_id { get; set; }

    [StringLength(1000)]
    public string? pm_enabled_sites { get; set; }

    public bool? pm_studyPeriod1_enabled { get; set; }

    public int? pm_studyPeriod1_time_from { get; set; }

    public int? pm_studyPeriod1_time_to { get; set; }

    public bool? pm_studyPeriod2_enabled { get; set; }

    public int? pm_studyPeriod2_time_from { get; set; }

    public int? pm_studyPeriod2_time_to { get; set; }

    public bool? pm_studyPeriodAccumulated_enabled { get; set; }

    [Column(TypeName = "xml")]
    public string? pm_gift_by_level { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_weekly_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_global_weekly_limit { get; set; }

    public bool? pm_decrease_spent_redeemable_gom { get; set; }

    public string? pm_notification_gom { get; set; }

    public bool pm_flag_require { get; set; }

    public bool pm_all_accounts { get; set; }

    [Column(TypeName = "xml")]
    public string? pm_coin_in { get; set; }

    [Column(TypeName = "xml")]
    public string? pm_country_list { get; set; }

    public bool? pm_include_prize_tax_form { get; set; }

    public int pm_lock_enabled { get; set; }

    public int? pm_lock_balance_factor { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_lock_balance_amount { get; set; }

    public int? pm_lock_coin_in_factor { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_lock_coin_in_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_lock_average_bet { get; set; }

    public int? pm_lock_plays { get; set; }

    public int pm_lock_max_payable_factor_enabled { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal? pm_lock_max_payable_factor { get; set; }

    public int pm_lock_max_payable_amount_enabled { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_lock_max_payable_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_patron_limit { get; set; }

    public int? pm_times_daily { get; set; }

    public int? pm_times_weekly { get; set; }

    public int? pm_times_monthly { get; set; }

    public int? pm_times_patron { get; set; }

    public int? pm_global_times_day { get; set; }

    public int? pm_global_times_week { get; set; }

    public int? pm_global_times_month { get; set; }

    public int? pm_global_times_global { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_cash_in_max_reward { get; set; }

    public int? pm_weights_id { get; set; }

    public bool pm_awarded_promotion_discounted { get; set; }

    [Column(TypeName = "money")]
    public decimal? pm_lock_min_payable_amount { get; set; }

    public bool pm_auto_conversion { get; set; }

    public int? pm_input_amount_type { get; set; }

    public bool? pm_is_automatic_transfer { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_min_coinin { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_min_coinin_reward { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_coinin { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_coinin_reward { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_min_points { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_min_points_reward { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_points { get; set; }

    [Column(TypeName = "money")]
    public decimal pm_points_reward { get; set; }

    [Column(TypeName = "xml")]
    public string? pm_coinin_to_terminal_list { get; set; }

    [Column(TypeName = "xml")]
    public string? pm_points_to_terminal_list { get; set; }

    public long? pm_small_resource_id_55 { get; set; }

    public bool pm_include_recharge { get; set; }

    public long? pm_parent_promotion_id { get; set; }

    public bool pm_has_schedule { get; set; }
}
