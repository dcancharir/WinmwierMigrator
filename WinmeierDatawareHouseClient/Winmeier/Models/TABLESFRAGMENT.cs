using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Keyless]
[Table("TABLESFRAGMENT")]
public partial class TABLESFRAGMENT
{
    [StringLength(128)]
    public string Table_name { get; set; } = null!;

    public int NumIdx { get; set; }

    [StringLength(128)]
    public string Indexes { get; set; } = null!;

    [StringLength(60)]
    public string? Clust { get; set; }

    public double? Fragm { get; set; }
}
