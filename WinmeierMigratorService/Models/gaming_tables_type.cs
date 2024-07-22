using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("gtt_enabled", "gtt_gaming_table_type_id", "gtt_name", Name = "IX_gtt_enabled")]
public partial class gaming_tables_type
{
    [Key]
    public int gtt_gaming_table_type_id { get; set; }

    [StringLength(50)]
    public string gtt_name { get; set; } = null!;

    public bool gtt_enabled { get; set; }

    public int? gtt_report_type_id { get; set; }

    [InverseProperty("gt_type")]
    public virtual ICollection<gaming_table> gaming_tables { get; set; } = new List<gaming_table>();
}
