using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("tbc_country_id", "tbc_tax_type")]
[Table("tax_by_country")]
public partial class tax_by_country
{
    [Key]
    public int tbc_country_id { get; set; }

    [Key]
    public int tbc_tax_type { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? tbc_tax1_percentage { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? tbc_tax2_percentage { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? tbc_tax3_percentage { get; set; }
}
