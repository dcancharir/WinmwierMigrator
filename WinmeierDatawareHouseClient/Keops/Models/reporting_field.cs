using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class reporting_field
{
    public int rf_id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string rf_name { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal rf_default_value { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? rf_nls_id { get; set; }
}
