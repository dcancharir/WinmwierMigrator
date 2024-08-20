using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("buckets_multiplier_schedule")]
public partial class buckets_multiplier_schedule
{
    [Key]
    public long bm_bucket_id { get; set; }

    [StringLength(250)]
    public string bm_bucket_description { get; set; } = null!;

    public long bm_bucket_afected_id { get; set; }

    [Column(TypeName = "decimal(4, 2)")]
    public decimal bm_bucket_multiplier { get; set; }

    [Column(TypeName = "xml")]
    public string? bm_bucket_terminals_list { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime bm_bucket_schedule_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? bm_bucket_schedule_end { get; set; }

    public int bm_bucket_schedule_weekday { get; set; }

    public int bm_bucket_schedule1_time_from { get; set; }

    public int bm_bucket_schedule1_time_to { get; set; }

    public int? bm_bucket_schedule2_time_from { get; set; }

    public int? bm_bucket_schedule2_time_to { get; set; }

    public bool bm_bucket_schedule2_enabled { get; set; }

    public int? bm_bucket_order { get; set; }

    public bool bm_bucket_enabled { get; set; }

    public long? bm_bucket_master_sequence_id { get; set; }

    public int? bm_bucket_computed_order { get; set; }

    public int? bm_level { get; set; }
}
