using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("ticket_exception_audit")]
public partial class ticket_exception_audit
{
    public long tea_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tea_datetime { get; set; }

    public long tea_group { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tea_working_day { get; set; }

    public int tea_action { get; set; }

    [StringLength(100)]
    public string? tea_egm_provider_id { get; set; }

    [StringLength(100)]
    public string? tea_egm_machine_id { get; set; }

    [StringLength(100)]
    public string? tea_egm_machine_name { get; set; }

    [StringLength(40)]
    public string? tea_egm_floor_id { get; set; }

    public long? tea_egm_stacker_id { get; set; }

    public int? tea_egm_area_id { get; set; }

    public int? tea_egm_bank_id { get; set; }

    public int? tea_egm_position { get; set; }

    public int tea_exception_type { get; set; }

    public long tea_user_id { get; set; }

    public long tea_ticket_id { get; set; }

    public long tea_ticket_validation_number { get; set; }

    public int tea_ticket_status { get; set; }

    [Column(TypeName = "money")]
    public decimal tea_ticket_amount { get; set; }

    public int tea_ticket_type_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime tea_ticket_creation_datetime { get; set; }

    public int? tea_ticket_last_action_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tea_ticket_last_action_datetime { get; set; }

    public long? tea_ticket_expected_collection_id { get; set; }

    public long? tea_ticket_expected_collection_stacker_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tea_ticket_expected_collection_datetime { get; set; }

    public long? tea_ticket_expected_collection_cashier_session_id { get; set; }

    public long? tea_ticket_actual_collection_id { get; set; }

    public long? tea_ticket_actual_collection_stacker_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? tea_ticket_actual_collection_datetime { get; set; }

    public long? tea_ticket_actual_collection_cashier_session_id { get; set; }
}
