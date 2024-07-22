using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Keyless]
public partial class terminals_last_changed
{
    public int TLC_MASTER_ID { get; set; }

    [StringLength(40)]
    public string TLC_BASE_NAME { get; set; } = null!;

    public int? TLC_CHANGE_ID { get; set; }

    public int? TLC_TERMINAL_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TLC_CREATED { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TLC_CHANGED { get; set; }
}
