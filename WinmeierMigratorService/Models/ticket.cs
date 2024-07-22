using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("ti_cage_movement_id", Name = "IX_ti_cage_movement_id")]
[Index("ti_canceled_play_session_id", "ti_type_id", Name = "IX_ti_canceled_play_session_id_type_id")]
[Index("ti_collected_money_collection", Name = "IX_ti_collected_money_collection")]
[Index("ti_created_terminal_type", "ti_status", "ti_created_datetime", "ti_created_terminal_id", Name = "IX_ti_created_terminal_id_terminal_type_datetime_status")]
[Index("ti_last_action_datetime", Name = "IX_ti_last_action_datetime")]
[Index("ti_money_collection_id", Name = "IX_ti_money_collection_id")]
[Index("ti_status", "ti_expiration_datetime", Name = "IX_ti_status_expiration_datetime")]
[Index("ti_transaction_id", "ti_created_terminal_id", "ti_validation_number", Name = "IX_ti_transaction_id_terminal_id_validation_number", IsUnique = true)]
[Index("ti_validation_number", "ti_status", "ti_computed_id", Name = "IX_ti_validation_number_status", IsUnique = true)]
public partial class ticket
{
    [Key]
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

    [StringLength(3)]
    public string? ti_cur0 { get; set; }

    [Column(TypeName = "money")]
    public decimal? ti_amt1 { get; set; }

    [StringLength(3)]
    public string? ti_cur1 { get; set; }

    public long? ti_reject_reason_egm { get; set; }

    public long? ti_reject_reason_wcp { get; set; }
}
