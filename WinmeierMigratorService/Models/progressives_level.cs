using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("pgl_progressive_id", "pgl_level_id")]
public partial class progressives_level
{
    [Key]
    public long pgl_progressive_id { get; set; }

    [Key]
    public int pgl_level_id { get; set; }

    [StringLength(50)]
    public string? pgl_name { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal pgl_contribution_pct { get; set; }

    [Column(TypeName = "money")]
    public decimal pgl_amount { get; set; }
}
