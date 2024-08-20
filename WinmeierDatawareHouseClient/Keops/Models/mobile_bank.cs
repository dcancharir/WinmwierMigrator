using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class mobile_bank
{
    public long mb_account_id { get; set; }

    public short mb_account_type { get; set; }

    [StringLength(100)]
    public string? mb_holder_name { get; set; }

    public bool mb_blocked { get; set; }

    [StringLength(100)]
    public string? mb_track_data { get; set; }

    [Column(TypeName = "money")]
    public decimal mb_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal mb_initial_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal mb_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal mb_deposit { get; set; }

    [Column(TypeName = "money")]
    public decimal mb_extension { get; set; }

    [Column(TypeName = "money")]
    public decimal mb_pending_cash { get; set; }

    [StringLength(24)]
    public string mb_pin { get; set; } = null!;

    public long? mb_cashier_session_id { get; set; }

    public short mb_failed_login_attempts { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mb_last_activity { get; set; }

    public int? mb_last_terminal_id { get; set; }

    [StringLength(100)]
    public string? mb_last_terminal_name { get; set; }

    public byte[]? mb_timestamp { get; set; }

    public long? mb_track_number { get; set; }

    public int? mb_terminal_id { get; set; }

    [Column(TypeName = "money")]
    public decimal mb_over_cash { get; set; }

    [Column(TypeName = "money")]
    public decimal? mb_total_limit { get; set; }

    [Column(TypeName = "money")]
    public decimal? mb_recharge_limit { get; set; }

    public int? mb_number_of_recharges_limit { get; set; }

    public int? mb_actual_number_of_recharges { get; set; }

    [StringLength(80)]
    public string? mb_employee_code { get; set; }

    [Column(TypeName = "money")]
    public decimal mb_shortfall_cash { get; set; }

    [Column(TypeName = "money")]
    public decimal mb_over_cash_session { get; set; }

    [Column(TypeName = "money")]
    public decimal mb_shortfall_cash_session { get; set; }

    public short mb_session_status { get; set; }

    public int? mb_user_id { get; set; }

    public bool mb_lock { get; set; }
}
