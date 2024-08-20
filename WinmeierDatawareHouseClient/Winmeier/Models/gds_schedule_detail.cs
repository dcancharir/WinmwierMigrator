using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Index("gsd_schedule_id", "gsd_step_index", "gsd_datetime", "gsd_terminal_id", Name = "IX_gds_schedule_details")]
public partial class gds_schedule_detail
{
    [Key]
    public long gsd_id { get; set; }

    public long gsd_schedule_id { get; set; }

    public int gsd_order { get; set; }

    public int gsd_step_index { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime gsd_datetime { get; set; }

    public int gsd_terminal_id { get; set; }

    public int gsd_action_type { get; set; }

    public long? gsd_action_data { get; set; }

    public int? gsd_lock_service_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? gsd_lock_datetime { get; set; }

    public int gsd_action_status { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal gsd_progress { get; set; }

    public string? gsd_txt { get; set; }

    public int? gsd_recurrence { get; set; }
}
