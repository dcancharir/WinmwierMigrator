using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class junkets_representative
{
    public long jr_id { get; set; }

    [StringLength(20)]
    public string jr_code { get; set; } = null!;

    [StringLength(100)]
    public string jr_name { get; set; } = null!;

    public bool? jr_internal { get; set; }

    public bool jr_status { get; set; }

    [Column(TypeName = "money")]
    public decimal jr_deposit_amount { get; set; }

    [StringLength(1024)]
    public string? jr_comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jr_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jr_update { get; set; }
}
