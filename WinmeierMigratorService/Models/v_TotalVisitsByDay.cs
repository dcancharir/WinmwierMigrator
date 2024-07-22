using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class v_TotalVisitsByDay
{
    public int SQL_COLUMN_GAMING_DAY { get; set; }

    public int? TotalByDay { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Colum1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Colum2 { get; set; } = null!;

    public int Column3 { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalTeoricByDay { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalRealByDay { get; set; }

    [Column(TypeName = "money")]
    public decimal? SQL_COLUMN_DIFFERENCE_ACCUMULATE { get; set; }

    public int? TotalEntries { get; set; }
}
