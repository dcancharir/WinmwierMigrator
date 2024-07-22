using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("me_terminal_id", Name = "IX_Terminals")]
public partial class meter
{
    [Key]
    public long me_meter_id { get; set; }

    public int me_terminal_id { get; set; }

    public int me_played_count { get; set; }

    [Column(TypeName = "money")]
    public decimal me_played_amount { get; set; }

    public int me_won_count { get; set; }

    [Column(TypeName = "money")]
    public decimal me_won_amount { get; set; }

    [Column(TypeName = "money")]
    public decimal me_cash_in { get; set; }

    [Column(TypeName = "money")]
    public decimal me_cash_out { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime me_last_reported { get; set; }

    public byte[]? me_timestamp { get; set; }

    [ForeignKey("me_terminal_id")]
    [InverseProperty("meters")]
    public virtual terminal me_terminal { get; set; } = null!;

    [InverseProperty("mm_meter")]
    public virtual ICollection<money_meter> money_meters { get; set; } = new List<money_meter>();
}
