using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("alc_category_id", "alc_language_id")]
public partial class alarm_category
{
    [Key]
    public int alc_category_id { get; set; }

    [Key]
    public int alc_language_id { get; set; }

    public int alc_alarm_group_id { get; set; }

    public int alc_type { get; set; }

    [StringLength(50)]
    public string alc_name { get; set; } = null!;

    [StringLength(200)]
    public string? alc_description { get; set; }

    public int alc_visible { get; set; }
}
