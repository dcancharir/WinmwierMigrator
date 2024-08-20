using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class junkets_commission
{
    public long jc_id { get; set; }

    public long jc_junket_id { get; set; }

    public int jc_type { get; set; }

    [Column(TypeName = "money")]
    public decimal jc_fixed_value { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal jc_variable_value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jc_date_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jc_date_to { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jc_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jc_update { get; set; }
}
