using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("gtwld_id", "gtwld_chip_id")]
[Table("gaming_tables_win_loss_detail")]
public partial class gaming_tables_win_loss_detail
{
    [Key]
    public long gtwld_id { get; set; }

    [Key]
    public long gtwld_chip_id { get; set; }

    [Column(TypeName = "money")]
    public decimal gtwld_denomination { get; set; }

    /// <summary>
    /// Do not use negative values to differentiate check or card. Use 1 for quantity and in denomination the value of the check or card. Amount per denomination must be the total.
    /// </summary>
    public int gtwld_quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? gtwld_win_loss_detail_amount { get; set; }
}
