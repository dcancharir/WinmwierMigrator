using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
[Table("Resultado_fragment")]
public partial class Resultado_fragment
{
    [StringLength(128)]
    public string Table_name { get; set; } = null!;

    public int NumIdx { get; set; }

    [StringLength(128)]
    public string Indexes { get; set; } = null!;

    [StringLength(60)]
    public string? Clust { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? FRAG { get; set; }
}
