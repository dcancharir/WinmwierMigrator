using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("cgc_iso_code", "cgc_denomination", "cgc_cage_currency_type")]
public partial class cage_currency
{
    [Key]
    [StringLength(3)]
    public string cgc_iso_code { get; set; } = null!;

    [Key]
    [Column(TypeName = "money")]
    public decimal cgc_denomination { get; set; }

    [Key]
    public int cgc_cage_currency_type { get; set; }

    public bool cgc_allowed { get; set; }

    public bool? cgc_cage_visible { get; set; }
}
