using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[PrimaryKey("bul_bucket_id", "bul_level_id")]
public partial class bucket_level
{
    [Key]
    public long bul_bucket_id { get; set; }

    [Key]
    public long bul_level_id { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal bul_a_factor { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal bul_b_factor { get; set; }
}
