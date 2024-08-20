using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("cgs_iso_code", "cgs_denomination", "cgs_cage_currency_type", "cgs_vault_id")]
[Table("cage_stock")]
public partial class cage_stock
{
    [Key]
    [StringLength(3)]
    public string cgs_iso_code { get; set; } = null!;

    [Key]
    [Column(TypeName = "money")]
    public decimal cgs_denomination { get; set; }

    [Key]
    public int cgs_cage_currency_type { get; set; }

    [Key]
    public int cgs_vault_id { get; set; }

    [Column(TypeName = "money")]
    public decimal cgs_quantity { get; set; }
}
