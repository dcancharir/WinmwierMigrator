using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("Site", "Term", "Date")]
public partial class daily_meter
{
    [Key]
    public int Site { get; set; }

    [Key]
    public int Term { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    public int? Games { get; set; }

    public int? Won { get; set; }

    public int? Bills { get; set; }

    public int? Tickets { get; set; }

    public int? Cards { get; set; }

    [Column(TypeName = "money")]
    public decimal? Bets { get; set; }

    [Column(TypeName = "money")]
    public decimal? Payments { get; set; }

    [Column(TypeName = "money")]
    public decimal? Jackpots { get; set; }

    [Column(TypeName = "money")]
    public decimal? Benefit { get; set; }
}
