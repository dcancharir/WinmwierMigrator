using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("gmc_gamingtable_id", "gmc_gaming_day")]
[Table("gaming_tables_connected")]
public partial class gaming_tables_connected
{
    [Key]
    public int gmc_gamingtable_id { get; set; }

    [Key]
    public int gmc_gaming_day { get; set; }

    public bool gmc_enabled { get; set; }

    public bool gmc_used { get; set; }
}
