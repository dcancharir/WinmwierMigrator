using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

public partial class currency
{
    [Key]
    [StringLength(3)]
    public string cur_iso_code { get; set; } = null!;

    public bool cur_allowed { get; set; }

    [StringLength(50)]
    public string? cur_name { get; set; }

    [StringLength(3)]
    public string? cur_alias1 { get; set; }

    [StringLength(3)]
    public string? cur_alias2 { get; set; }
}
