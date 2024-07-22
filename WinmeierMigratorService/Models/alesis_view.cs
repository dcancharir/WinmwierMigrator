using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class alesis_view
{
    public int te_terminal_id { get; set; }

    public int te_type { get; set; }

    public int? te_server_id { get; set; }

    [StringLength(50)]
    public string? te_name { get; set; }

    [StringLength(40)]
    public string? te_external_id { get; set; }

    public bool te_blocked { get; set; }

    public byte[]? te_timestamp { get; set; }

    public bool te_active { get; set; }

    [StringLength(50)]
    public string? te_provider_id { get; set; }

    public short? te_client_id { get; set; }

    public short? te_build_id { get; set; }

    public long? ps_play_session_id { get; set; }

    public long? ps_account_id { get; set; }

    public int? ps_terminal_id { get; set; }

    public int? ps_type { get; set; }

    [Column(TypeName = "xml")]
    public string? ps_type_data { get; set; }

    public int? ps_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ps_started { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_initial_balance { get; set; }

    public int? ps_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_played_amount { get; set; }

    public int? ps_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_cash_out { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ps_finished { get; set; }

    [Column(TypeName = "money")]
    public decimal? ps_final_balance { get; set; }

    public byte[]? ps_timestamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ps_locked { get; set; }

    public long? ac_account_id { get; set; }

    public int? ac_type { get; set; }

    [StringLength(50)]
    public string? ac_holder_name { get; set; }

    public bool? ac_blocked { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_not_valid_before { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ac_not_valid_after { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_cash_won { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_not_redeemable { get; set; }

    public byte[]? ac_timestamp { get; set; }

    [StringLength(50)]
    public string? ac_track_data { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_total_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_total_cash_out { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_initial_cash_in { get; set; }

    public bool? ac_activated { get; set; }

    [Column(TypeName = "money")]
    public decimal? ac_deposit { get; set; }

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
    public decimal? ac_initial_not_redeemable { get; set; }

    public int? at_terminal_id { get; set; }

    public int? at_machine_id { get; set; }

    public int? at_status { get; set; }

    public long? at_session_id { get; set; }

    [StringLength(50)]
    public string? ap_sql_server_ip_address { get; set; }

    [StringLength(50)]
    public string? ap_sql_database_name { get; set; }

    [StringLength(50)]
    public string? ap_sql_user { get; set; }

    [StringLength(50)]
    public string? ap_sql_user_password { get; set; }

    [StringLength(50)]
    public string? ap_vendor_id { get; set; }
}
