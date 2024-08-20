using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("tcd_terminal_currency_id", "tcd_iso_code", "tcd_denomination", "tcd_currency_type")]
public partial class terminal_currency_detail
{
    [Key]
    public int tcd_terminal_currency_id { get; set; }

    [Key]
    [StringLength(3)]
    public string tcd_iso_code { get; set; } = null!;

    [Key]
    [Column(TypeName = "money")]
    public decimal tcd_denomination { get; set; }

    [Key]
    public int tcd_currency_type { get; set; }

    public int tcd_direction { get; set; }
}
