using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("gaming_table_configuration")]
public partial class gaming_table_configuration
{
    public int gtc_id { get; set; }

    [StringLength(10)]
    public string? gtc_iso_code { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal gtc_max_allowed_purchase { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal gtc_max_allowed_sales { get; set; }

    public bool gtc_status { get; set; }
}
