using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class junket
{
    public long ju_id { get; set; }

    public long ju_representative_id { get; set; }

    [StringLength(20)]
    public string ju_code { get; set; } = null!;

    [StringLength(100)]
    public string ju_name { get; set; } = null!;

    [StringLength(1024)]
    public string? ju_comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ju_date_from { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ju_date_to { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ju_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ju_update { get; set; }
}
