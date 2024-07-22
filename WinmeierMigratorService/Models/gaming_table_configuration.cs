using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("gaming_table_configuration")]
public partial class gaming_table_configuration
{
    [Key]
    public int gtc_id { get; set; }

    [StringLength(5)]
    public string? gtc_iso_code { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal gtc_max_allowed_purchase { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal gtc_max_allowed_sales { get; set; }

    public bool gtc_status { get; set; }
}
