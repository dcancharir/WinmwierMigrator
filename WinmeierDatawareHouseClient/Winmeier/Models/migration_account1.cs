using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
[Table("migration_accounts")]
public partial class migration_account1
{
    public long ac_account_id { get; set; }

    public int ac_type { get; set; }

    [StringLength(50)]
    public string? ac_holder_name { get; set; }

    public bool ac_blocked { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_not_valid_before { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_not_valid_after { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_cash_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_not_redeemable { get; set; }

    public byte[]? ac_timestamp { get; set; }

    [StringLength(50)]
    public string? ac_track_data { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_total_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_total_cash_out { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_initial_cash_in { get; set; }

    public bool ac_activated { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_deposit { get; set; }

    public int? ac_current_terminal_id { get; set; }

    [StringLength(50)]
    public string? ac_current_terminal_name { get; set; }

    public long? ac_current_play_session_id { get; set; }

    public int? ac_last_terminal_id { get; set; }

    [StringLength(50)]
    public string? ac_last_terminal_name { get; set; }

    public long? ac_last_play_session_id { get; set; }

    public int? ac_user_type { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_points { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_initial_not_redeemable { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_created { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_promo_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_promo_limit { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_promo_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_promo_expiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ac_last_activity { get; set; }

    [StringLength(20)]
    public string? ac_holder_id { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_01 { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_02 { get; set; }

    [StringLength(50)]
    public string? ac_holder_address_03 { get; set; }

    [StringLength(50)]
    public string? ac_holder_city { get; set; }

    [StringLength(10)]
    public string? ac_holder_zip { get; set; }

    [StringLength(50)]
    public string? ac_holder_email_01 { get; set; }

    [StringLength(50)]
    public string? ac_holder_email_02 { get; set; }

    [StringLength(20)]
    public string? ac_holder_phone_number_01 { get; set; }

    [StringLength(20)]
    public string? ac_holder_phone_number_02 { get; set; }

    [StringLength(100)]
    public string? ac_holder_comments { get; set; }

    public int? ac_holder_gender { get; set; }

    public int? ac_holder_marital_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_holder_birth_date { get; set; }

    public long ac_draw_last_play_session_id { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_draw_last_play_session_remainder { get; set; }

    [StringLength(20)]
    public string? ac_holder_id_indexed { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_nr_won_lock { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_nr_expiration { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_cashin_while_playing { get; set; }

    public int ac_holder_level { get; set; }

    public bool ac_card_paid { get; set; }

    public long? ac_cancellable_operation_id { get; set; }

    public long? ac_current_promotion_id { get; set; }

    public int ac_block_reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_holder_level_expiration { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_holder_level_entered { get; set; }

    public int? ac_holder_level_notify { get; set; }

    [StringLength(12)]
    public string? ac_pin { get; set; }

    public int? ac_pin_failures { get; set; }

    [StringLength(50)]
    public string? ac_holder_name1 { get; set; }

    [StringLength(50)]
    public string? ac_holder_name2 { get; set; }

    [StringLength(50)]
    public string? ac_holder_name3 { get; set; }

    [StringLength(20)]
    public string? ac_holder_id1 { get; set; }

    [StringLength(20)]
    public string? ac_holder_id2 { get; set; }

    public long? ac_holder_document_id1 { get; set; }

    public long? ac_holder_document_id2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_nr2_expiration { get; set; }

    public long? ac_recommended_by { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_re_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_promo_re_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_promo_nr_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_played { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_re_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_nr_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_to_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_re_to_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_nr_to_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_from_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_re_from_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_nr_from_gm { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_played { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_nr_played { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_nr_won { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_re_cancellable { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_re_cancellable { get; set; }

    [Column(TypeName = "money")]
    public decimal ac_in_session_promo_nr_cancellable { get; set; }

    public long ac_in_session_cancellable_transaction_id { get; set; }
}
