using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
[Table("SAVED_EXPIRED_CREDITS_AM")]
public partial class SAVED_EXPIRED_CREDITS_AM
{
    public long am_movement_id { get; set; }

    public long? am_play_session_id { get; set; }

    public long am_account_id { get; set; }

    public int? am_terminal_id { get; set; }

    public long? am_wcp_sequence_id { get; set; }

    public long? am_wcp_transaction_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime am_datetime { get; set; }

    public int am_type { get; set; }

    [Column(TypeName = "money")]
    public decimal am_initial_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal am_sub_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal am_add_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal am_final_balance { get; set; }

    public int? am_cashier_id { get; set; }

    [StringLength(50)]
    public string? am_cashier_name { get; set; }

    [StringLength(50)]
    public string? am_terminal_name { get; set; }

    public long? am_operation_id { get; set; }

    [StringLength(256)]
    public string? am_details { get; set; }

    [StringLength(64)]
    public string? am_reasons { get; set; }

    public int? am_undo_status { get; set; }

    [StringLength(50)]
    public string? am_track_data { get; set; }
}
