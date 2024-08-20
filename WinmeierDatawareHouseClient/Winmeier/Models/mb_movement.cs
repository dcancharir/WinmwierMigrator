using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Index("mbm_cashier_session_id", "mbm_datetime", "mbm_movement_id", Name = "IX_mb_movements")]
[Index("mbm_datetime", "mbm_type", Name = "IX_mbm_datetime_type")]
public partial class mb_movement
{
    [Key]
    public long mbm_movement_id { get; set; }

    public int mbm_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime mbm_datetime { get; set; }

    public long mbm_cashier_session_id { get; set; }

    public long mbm_mb_id { get; set; }

    public int? mbm_terminal_id { get; set; }

    [StringLength(50)]
    public string? mbm_terminal_name { get; set; }

    public long? mbm_player_acct_id { get; set; }

    [StringLength(50)]
    public string? mbm_player_trackdata { get; set; }

    public long? mbm_wcp_sequence_id { get; set; }

    public long? mbm_wcp_transaction_id { get; set; }

    public long? mbm_acct_movement_id { get; set; }

    public int? mbm_cashier_id { get; set; }

    [StringLength(50)]
    public string? mbm_cashier_name { get; set; }

    [Column(TypeName = "money")]
    public decimal mbm_initial_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal mbm_add_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal mbm_sub_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal mbm_final_balance { get; set; }

    public long? mbm_operation_id { get; set; }

    [Column(TypeName = "money")]
    public decimal? mbm_amount_01 { get; set; }

    [Column(TypeName = "money")]
    public decimal? mbm_amount_02 { get; set; }

    public int? mbm_undo_status { get; set; }
}
