using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class handpay
{
    public long hp_id { get; set; }

    public int? hp_terminal_id { get; set; }

    [StringLength(100)]
    public string? hp_game_base_name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hp_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? hp_previous_meters { get; set; }

    [Column(TypeName = "money")]
    public decimal hp_amount { get; set; }

    [StringLength(100)]
    public string? hp_te_name { get; set; }

    [StringLength(100)]
    public string? hp_te_provider_id { get; set; }

    public long? hp_movement_id { get; set; }

    public int hp_type { get; set; }

    public long? hp_play_session_id { get; set; }

    public int? hp_site_jackpot_index { get; set; }

    [StringLength(100)]
    public string? hp_site_jackpot_name { get; set; }

    public int? hp_site_jackpot_awarded_on_terminal_id { get; set; }

    public long? hp_site_jackpot_awarded_to_account_id { get; set; }

    public int? hp_status { get; set; }

    public bool hp_site_jackpot_notified { get; set; }

    public long? hp_ticket_id { get; set; }

    public long? hp_transaction_id { get; set; }

    public long? hp_candidate_play_session_id { get; set; }

    public long? hp_candidate_prev_play_session_id { get; set; }

    [Column(TypeName = "xml")]
    public string? hp_long_poll_1b_data { get; set; }

    public long? hp_progressive_id { get; set; }

    public int? hp_level { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? hp_status_changed { get; set; }

    [Column(TypeName = "money")]
    public decimal? hp_tax_base_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? hp_tax_amount { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? hp_tax_pct { get; set; }

    public byte[] HP_TIMESTAMP { get; set; } = null!;

    public int hp_payment_mode { get; set; }

    public int? hp_status_calculated { get; set; }

    public long? hp_operation_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? hp_amt0 { get; set; }

    [StringLength(6)]
    public string? hp_cur0 { get; set; }

    [Column(TypeName = "money")]
    public decimal? hp_amt1 { get; set; }

    [StringLength(6)]
    public string? hp_cur1 { get; set; }

    public int? hp_tax_apply_type { get; set; }

    [StringLength(512)]
    public string? hp_void_comments { get; set; }

    public long? hp_account_id { get; set; }

    public long? hp_operation_id_authorization { get; set; }

    [Column(TypeName = "money")]
    public decimal? hp_original_amount { get; set; }

    public int? hp_previous_status { get; set; }

    public bool? hp_in_candidate_ps { get; set; }

    public int? hp_rounding_mode { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? hp_rounding_tax_applied { get; set; }

    public int? hp_rounding_tax_amount { get; set; }

    public int? hp_rounding_amount { get; set; }

    public bool? hp_past_payment { get; set; }

    public int? hp_game_id { get; set; }

    public long? hp_play_transaction_id { get; set; }

    public long hp_voided_id { get; set; }

    [StringLength(100)]
    public string? hp_void_user { get; set; }

    [StringLength(100)]
    public string? hp_void_terminal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? hp_void_date { get; set; }
}
