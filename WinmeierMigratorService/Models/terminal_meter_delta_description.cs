using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("terminal_meter_delta_description")]
public partial class terminal_meter_delta_description
{
    [Key]
    public long tmdd_id { get; set; }

    [StringLength(100)]
    public string tmdd_field_name { get; set; } = null!;

    [StringLength(100)]
    public string tmdd_field_description { get; set; } = null!;

    public int tmdd_group { get; set; }

    public int tmdd_order { get; set; }
}
