using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("TEMP_buckets_multiplier_to_apply_TIER_LEVEL")]
public partial class TEMP_buckets_multiplier_to_apply_TIER_LEVEL
{
    public long bma_Bucket_ID { get; set; }

    public int bma_Terminal_ID { get; set; }

    public int bma_Level { get; set; }

    [Column(TypeName = "decimal(3, 2)")]
    public decimal? bma_Multiplier { get; set; }
}
