using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class migration_play_session
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
    public decimal? ps_total_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_total_cash_out { get; set; }

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
}
