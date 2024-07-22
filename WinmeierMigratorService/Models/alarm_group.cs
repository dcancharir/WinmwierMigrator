using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("alg_alarm_group_id", "alg_language_id")]
public partial class alarm_group
{
    [Key]
    public int alg_alarm_group_id { get; set; }

    [Key]
    public int alg_language_id { get; set; }

    public int alg_type { get; set; }

    [StringLength(50)]
    public string alg_name { get; set; } = null!;

    [StringLength(200)]
    public string? alg_description { get; set; }

    public int alg_visible { get; set; }
}
