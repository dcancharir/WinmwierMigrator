using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("cud_iso_code", "cud_type", "cud_denomination")]
public partial class currency_denomination
{
    [Key]
    [StringLength(3)]
    public string cud_iso_code { get; set; } = null!;

    [Key]
    public int cud_type { get; set; }

    [Key]
    [Column(TypeName = "money")]
    public decimal cud_denomination { get; set; }

    public bool cud_rejected { get; set; }
}
