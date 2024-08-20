using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tia_id", "tia_validation_number")]
[Table("tickets_audit_status_change")]
[Index("tia_collected_money_collection_moved", Name = "IDX_tia_collected_money_collection_moved")]
[Index("tia_insert_date", Name = "IDX_tia_insert_date")]
[Index("tia_ticket_id", Name = "IDX_ticket_id")]
public partial class tickets_audit_status_change
{
    [Key]
    public long tia_id { get; set; }

    [Key]
    public long tia_validation_number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tia_insert_date { get; set; }

    public long tia_ticket_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? tia_amount { get; set; }

    public int? tia_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tia_created_datetime { get; set; }

    public int? tia_created_terminal_id { get; set; }

    public long? tia_money_collection_id { get; set; }

    public long? tia_created_account_id { get; set; }

    public bool? tia_collected { get; set; }

    public int? tia_last_action_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tia_last_action_datetime { get; set; }

    public long? tia_last_action_account_id { get; set; }

    public int? tia_machine_number { get; set; }

    public long? tia_transaction_id { get; set; }

    public long? tia_created_play_session_id { get; set; }

    public long? tia_canceled_play_session_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tia_db_inserted { get; set; }

    [Column(TypeName = "money")]
    public decimal? tia_collected_money_collection { get; set; }

    public long? tia_cage_movement_id { get; set; }

    public int? tia_type_id { get; set; }

    public int? tia_created_terminal_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tia_expiration_datetime { get; set; }

    public long? tia_reject_reason_egm { get; set; }

    public long? tia_reject_reason_wcp { get; set; }

    public int? tia_old_status { get; set; }

    public long? tia_collected_money_collection_previous { get; set; }

    public bool? tia_collected_money_collection_moved { get; set; }

    public long? tia_last_action_user_id { get; set; }
}
