using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("cm_date", "cm_type", Name = "IX_cm_date_type")]
[Index("cm_operation_id", Name = "IX_cm_operation_id")]
[Index("cm_session_id", Name = "IX_cm_session_id")]
public partial class cashier_movement
{
    [Key]
    public long cm_movement_id { get; set; }

    public long cm_session_id { get; set; }

    public int cm_cashier_id { get; set; }

    public int cm_user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime cm_date { get; set; }

    public int cm_type { get; set; }

    public int cm_money_type { get; set; }

    public long? cm_account_movement_id { get; set; }

    [Column(TypeName = "money")]
    public decimal cm_initial_balance { get; set; }

    [Column(TypeName = "money")]
    public decimal cm_sub_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal cm_add_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal cm_final_balance { get; set; }

    [StringLength(50)]
    public string? cm_user_name { get; set; }

    [StringLength(50)]
    public string? cm_cashier_name { get; set; }

    [StringLength(50)]
    public string? cm_card_track_data { get; set; }

    public long? cm_account_id { get; set; }

    public long? cm_operation_id { get; set; }

    [StringLength(256)]
    public string? cm_details { get; set; }

    [StringLength(3)]
    public string? cm_currency_iso_code { get; set; }

    [Column(TypeName = "money")]
    public decimal? cm_aux_amount { get; set; }

    public int? cm_undo_status { get; set; }

    [Column(TypeName = "money")]
    public decimal? cm_currency_denomination { get; set; }

    public long? cm_gaming_table_session_id { get; set; }

    public long? cm_chip_id { get; set; }

    public int cm_cage_currency_type { get; set; }

    public int? cm_chips_sale_denomination { get; set; }

    public long? cm_related_id { get; set; }
}
