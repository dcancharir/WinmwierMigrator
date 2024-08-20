using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class ticket
{
    public long ti_ticket_id { get; set; }

    public long ti_validation_number { get; set; }

    [Column(TypeName = "money")]
    public decimal ti_amount { get; set; }

    public int ti_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ti_created_datetime { get; set; }

    public int ti_created_terminal_id { get; set; }

    public int ti_created_terminal_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ti_expiration_datetime { get; set; }

    public long? ti_money_collection_id { get; set; }

    public long? ti_created_account_id { get; set; }

    public long? ti_promotion_id { get; set; }

    public bool? ti_collected { get; set; }

    public int? ti_validation_type { get; set; }

    public int ti_type_id { get; set; }

    public int? ti_last_action_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ti_last_action_datetime { get; set; }

    public long? ti_last_action_account_id { get; set; }

    public int? ti_last_action_terminal_type { get; set; }

    public int? ti_machine_number { get; set; }

    public long? ti_transaction_id { get; set; }

    public long? ti_created_play_session_id { get; set; }

    public long? ti_canceled_play_session_id { get; set; }

    public long ti_computed_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ti_db_inserted { get; set; }

    public long? ti_collected_money_collection { get; set; }

    public long? ti_cage_movement_id { get; set; }

    public long? ti_account_promotion { get; set; }

    [Column(TypeName = "money")]
    public decimal? ti_amt0 { get; set; }

    [StringLength(6)]
    public string? ti_cur0 { get; set; }

    [Column(TypeName = "money")]
    public decimal? ti_amt1 { get; set; }

    [StringLength(6)]
    public string? ti_cur1 { get; set; }

    public long? ti_reject_reason_egm { get; set; }

    public long? ti_reject_reason_wcp { get; set; }

    public long? ti_last_action_user_id { get; set; }

    public long? ti_account_operation_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? ti_prize_tax_amount { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? ti_prize_tax_pct { get; set; }

    public int? ti_prize_tax_apply_type { get; set; }

    public int? ti_partial_ticket_number { get; set; }

    public long? ti_saved_money_collection_id { get; set; }

    public bool? ti_tax_applied { get; set; }

    [StringLength(510)]
    public string? ti_formatted_ticket_number { get; set; }

    public bool? ti_hidden_row { get; set; }

    public long? ti_reissued_from_ticket_id { get; set; }

    public long? ti_reissue_approval_user_id { get; set; }

    public long? ti_reissued_to_account_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ti_reissue_date { get; set; }

    public int? ti_reissued_from_terminal_id { get; set; }

    public int? ti_extended_status { get; set; }

    public long? ti_meter_before_print { get; set; }

    public long? ti_meter_after_print { get; set; }

    public bool? ti_manually_changed { get; set; }
}
