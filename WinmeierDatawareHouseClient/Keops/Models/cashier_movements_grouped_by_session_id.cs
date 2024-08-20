using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("CM_SESSION_ID", "CM_TYPE", "CM_SUB_TYPE", "CM_CURRENCY_ISO_CODE", "CM_CAGE_CURRENCY_TYPE", "CM_CURRENCY_DENOMINATION")]
[Table("cashier_movements_grouped_by_session_id")]
[Index("CM_TYPE", "CM_SUB_TYPE", "CM_SESSION_ID", Name = "IX_cmgs_type_sub_type_session_id")]
public partial class cashier_movements_grouped_by_session_id
{
    [Key]
    public long CM_SESSION_ID { get; set; }

    [Key]
    public int CM_TYPE { get; set; }

    [Key]
    public int CM_SUB_TYPE { get; set; }

    [Key]
    [StringLength(3)]
    public string CM_CURRENCY_ISO_CODE { get; set; } = null!;

    [Key]
    [Column(TypeName = "money")]
    public decimal CM_CURRENCY_DENOMINATION { get; set; }

    [Key]
    public int CM_CAGE_CURRENCY_TYPE { get; set; }

    public int CM_TYPE_COUNT { get; set; }

    [Column(TypeName = "money")]
    public decimal? CM_SUB_AMOUNT { get; set; }

    [Column(TypeName = "money")]
    public decimal? CM_ADD_AMOUNT { get; set; }

    [Column(TypeName = "money")]
    public decimal? CM_AUX_AMOUNT { get; set; }

    [Column(TypeName = "money")]
    public decimal? CM_INITIAL_BALANCE { get; set; }

    [Column(TypeName = "money")]
    public decimal? CM_FINAL_BALANCE { get; set; }
}
