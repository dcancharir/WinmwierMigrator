using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class machine_weight
{
    public int mw_weights_id { get; set; }

    [StringLength(100)]
    public string mw_weights_name { get; set; } = null!;

    [StringLength(500)]
    public string? mw_weights_description { get; set; }

    public int mw_weights_status { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal mw_default_value { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal mw_min_value { get; set; }

    [Column(TypeName = "decimal(19, 4)")]
    public decimal mw_max_value { get; set; }
}
