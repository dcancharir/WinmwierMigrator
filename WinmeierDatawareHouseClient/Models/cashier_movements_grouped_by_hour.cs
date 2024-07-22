using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[PrimaryKey("CM_DATE", "CM_TYPE", "CM_SUB_TYPE", "CM_CURRENCY_ISO_CODE", "CM_CAGE_CURRENCY_TYPE", "CM_CURRENCY_DENOMINATION")]
[Table("cashier_movements_grouped_by_hour")]
[Index("CM_TYPE", "CM_SUB_TYPE", "CM_DATE", Name = "IX_cmgh_type_sub_type_date")]
[Index("cm_unique_id", Name = "IX_cmgh_unique_id", IsUnique = true)]
public partial class cashier_movements_grouped_by_hour
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime CM_DATE { get; set; }

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

    public byte[]? cm_timestamp { get; set; }

    public long cm_unique_id { get; set; }
}
