using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class customer_entrances_price
{
    public long cuep_price_id { get; set; }

    public string cuep_description { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal cuep_price { get; set; }

    public int? cuep_customer_level { get; set; }

    public bool cuep_default { get; set; }

    public int cuep_valid_gaming_days { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? cuep_accounting_price { get; set; }
}
