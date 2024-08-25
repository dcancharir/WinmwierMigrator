using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("fl_type", "fl_status", Name = "IX_fl_type_status")]
public partial class flag
{
    [Key]
    public long fl_flag_id { get; set; }

    public int fl_type { get; set; }

    public int fl_status { get; set; }

    public int fl_expiration_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? fl_expiration_date { get; set; }

    public int? fl_expiration_interval { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime fl_created { get; set; }

    [StringLength(50)]
    public string fl_name { get; set; } = null!;

    [StringLength(250)]
    public string? fl_description { get; set; }

    public int fl_color { get; set; }
}
