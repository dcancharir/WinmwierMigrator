using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("gaming_tables_tournament_prizes_breakdown")]
public partial class gaming_tables_tournament_prizes_breakdown
{
    public long gttpb_tournament_id { get; set; }

    public int gttpb_ranking { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal gttpb_prize_percentage { get; set; }
}
