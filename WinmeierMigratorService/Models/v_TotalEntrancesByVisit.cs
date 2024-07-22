using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class v_TotalEntrancesByVisit
{
    public int SQL_COLUMN_GAMING_DAY { get; set; }

    public int? SQL_COLUMN_VISIT_NUMBER { get; set; }

    [StringLength(50)]
    public string? SQL_COLUMN_NAME { get; set; }

    [StringLength(101)]
    public string? SQL_COLUMN_AC_HOLDER_LAST_NAME { get; set; }

    [StringLength(255)]
    public string? SQL_COLUMN_CARD_TRACK { get; set; }

    public int? SQL_COLUMN_ENTRIES { get; set; }

    [Column(TypeName = "money")]
    public decimal? SQL_COLUMN_THEORICAL_BY_DAY { get; set; }

    [Column(TypeName = "money")]
    public decimal? SQL_COLUMN_REAL_BY_DAY { get; set; }

    [Column(TypeName = "money")]
    public decimal? SQL_COLUMN_DIFFERENCE_BY_DAY { get; set; }

    [Column(TypeName = "money")]
    public decimal? SQL_COLUMN_THEORICAL_COLLECTION { get; set; }

    [Column(TypeName = "money")]
    public decimal? SQL_COLUMN_REAL_COLLECTION { get; set; }

    [Column(TypeName = "money")]
    public decimal? SQL_COLUMN_DIFFERENCE { get; set; }

    [StringLength(200)]
    public string? SQL_COLUMN_HOLDER_NAME { get; set; }

    public string? SQL_COLUMN_PRICE_DESCRIPTION { get; set; }
}
