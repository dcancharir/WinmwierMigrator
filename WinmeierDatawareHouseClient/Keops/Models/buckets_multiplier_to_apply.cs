using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("bma_Bucket_ID", "bma_Terminal_ID", "bma_Level")]
[Table("buckets_multiplier_to_apply")]
public partial class buckets_multiplier_to_apply
{
    [Key]
    public long bma_Bucket_ID { get; set; }

    [Key]
    public int bma_Terminal_ID { get; set; }

    [Key]
    public int bma_Level { get; set; }

    [Column(TypeName = "decimal(3, 2)")]
    public decimal? bma_Multiplier { get; set; }
}
