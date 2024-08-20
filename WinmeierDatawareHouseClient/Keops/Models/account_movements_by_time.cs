using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("ambt_cashier_id", "ambt_account_id", "ambt_operation_id", "ambt_datetime")]
[Table("account_movements_by_time")]
public partial class account_movements_by_time
{
    [Key]
    public int ambt_cashier_id { get; set; }

    [Key]
    public long ambt_account_id { get; set; }

    [Key]
    public long ambt_operation_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ambt_datetime { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ambt_operation_code { get; set; }

    [Column(TypeName = "money")]
    public decimal? ambt_amount { get; set; }

    public bool? ambt_enabled { get; set; }
}
