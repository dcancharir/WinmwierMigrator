using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("gds_schedule_time")]
[Index("gst_order", Name = "idx_gst_order")]
public partial class gds_schedule_time
{
    [Key]
    public long gst_schedule_id { get; set; }

    public int gst_order { get; set; }

    public bool gst_enabled { get; set; }

    /// <summary>
    /// 0 - One time; 1 - Daily; 2 - Week Days; 3 - Weekends; 4 - Weekly
    /// </summary>
    public int gst_recurrence { get; set; }

    [StringLength(50)]
    public string? gst_description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gst_next_run { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gst_last_run { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gst_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gst_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gst_end { get; set; }

    public int? gst_lock_service_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gst_lock_datetime { get; set; }
}
