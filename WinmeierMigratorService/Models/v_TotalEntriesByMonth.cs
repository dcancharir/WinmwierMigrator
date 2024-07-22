using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class v_TotalEntriesByMonth
{
    public int SQL_COLUMN_GAMING_DAY { get; set; }

    public int? SQL_COLUMN_VISIT_NUMBER { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Col1 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Col2 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Col21 { get; set; } = null!;

    public int Col3 { get; set; }

    [Column(TypeName = "money")]
    public decimal? SQL_COLUMN_THEORICAL_BY_DAY { get; set; }

    [Column(TypeName = "money")]
    public decimal? SQL_COLUMN_REAL_BY_DAY { get; set; }

    [Column(TypeName = "money")]
    public decimal? SQL_COLUMN_DIFFERENCE_BY_DAY { get; set; }

    public int? SQL_COLUMN_TOTAL_ENTRIES { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Col22 { get; set; } = null!;
}
