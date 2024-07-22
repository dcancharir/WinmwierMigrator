using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class c2_jackpot_instance
{
    [Key]
    public int c2ji_index { get; set; }

    [StringLength(20)]
    public string? c2ji_name { get; set; }

    [Column(TypeName = "numeric(5, 2)")]
    public decimal c2ji_contribution_pct { get; set; }

    [Column(TypeName = "money")]
    public decimal c2ji_minimum_bet { get; set; }

    [Column(TypeName = "money")]
    public decimal c2ji_minimum { get; set; }

    [Column(TypeName = "money")]
    public decimal c2ji_maximum { get; set; }

    [Column(TypeName = "money")]
    public decimal c2ji_average { get; set; }

    public byte[] c2ji_timestamp { get; set; } = null!;

    [InverseProperty("c2jc_indexNavigation")]
    public virtual c2_jackpot_counter? c2_jackpot_counter { get; set; }
}
