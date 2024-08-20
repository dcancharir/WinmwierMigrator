using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class play_session
{
    public long ps_play_session_id { get; set; }

    public long? ps_account_id { get; set; }

    public int ps_terminal_id { get; set; }

    public int ps_type { get; set; }

    [Column(TypeName = "xml")]
    public string? ps_type_data { get; set; }

    public int ps_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ps_started { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_initial_balance { get; set; }

    public int ps_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_played_amount { get; set; }

    public int ps_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_cash_out { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ps_finished { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_final_balance { get; set; }

    public byte[]? ps_timestamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ps_locked { get; set; }

    public bool ps_stand_alone { get; set; }

    public bool ps_promo { get; set; }

    public long? ps_wcp_transaction_id { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_total_played { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_total_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_redeemable_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_redeemable_cash_out { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_redeemable_played { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_redeemable_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_non_redeemable_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_non_redeemable_cash_out { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_non_redeemable_played { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_non_redeemable_won { get; set; }

    public bool? ps_balance_mismatch { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_spent_used { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_spent_remaining { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_cancellable_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_reported_balance_mismatch { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_re_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_promo_re_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_re_cash_out { get; set; }

    [Column(TypeName = "money")]
    public decimal ps_promo_re_cash_out { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_computed_points { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_awarded_points { get; set; }

    public int? ps_awarded_points_status { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_re_ticket_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_promo_re_ticket_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_promo_nr_ticket_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_re_ticket_out { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_promo_nr_ticket_out { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_bills_in_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_redeemable_played_original { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_redeemable_won_original { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_non_redeemable_played_original { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_non_redeemable_won_original { get; set; }

    public int? ps_played_count_original { get; set; }

    public int? ps_won_count_original { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_aux_ft_re_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_aux_ft_nr_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_re_found_in_egm { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_nr_found_in_egm { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_re_remaining_in_egm { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_nr_remaining_in_egm { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_handpays_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_handpays_paid_amount { get; set; }

    public long? ps_sequence { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_handpays_cc_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_handpays_jkp_amount { get; set; }

    public bool? ps_is_new_session { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_nr_promo_available { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_theo_win { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_total_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_paid_from_hopper { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_bills_dispensed { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_total_drop { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_total_cancelled { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_cash_in_coins { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_cash_in_bills { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_total_cash_out { get; set; }

    public long? ps_original_account { get; set; }
}
