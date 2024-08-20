using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("gds_schedule_time")]
public partial class gds_schedule_time
{
    public long gst_schedule_id { get; set; }

    public int gst_order { get; set; }

    public bool gst_enabled { get; set; }

    public int gst_recurrence { get; set; }

    [StringLength(100)]
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
