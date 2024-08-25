using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("pc_category_id", "pc_language_id")]
public partial class promotion_category
{
    [Key]
    public int pc_category_id { get; set; }

    [Key]
    public int pc_language_id { get; set; }

    [StringLength(50)]
    public string pc_name { get; set; } = null!;

    [StringLength(250)]
    public string? pc_description { get; set; }
}
