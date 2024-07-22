using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class chip
{
    [Key]
    public long ch_chip_id { get; set; }

    [StringLength(3)]
    public string ch_iso_code { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? ch_denomination { get; set; }

    public bool ch_allowed { get; set; }

    public int? ch_color { get; set; }

    [StringLength(50)]
    public string? ch_name { get; set; }

    [StringLength(50)]
    public string? ch_drawing { get; set; }

    public int? ch_chip_type { get; set; }
}
