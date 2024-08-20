using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("player_notification_configuration")]
public partial class player_notification_configuration
{
    public long pnc_id { get; set; }

    [StringLength(100)]
    public string pnc_name { get; set; } = null!;

    [StringLength(700)]
    public string pnc_description { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime pnc_datetime { get; set; }

    public int pnc_severity { get; set; }

    public bool pnc_filter_period_active { get; set; }

    public int? pnc_schedule_time_from { get; set; }

    public int? pnc_schedule_time_to { get; set; }

    public bool pnc_active { get; set; }

    public bool pnc_active_mailing { get; set; }

    [StringLength(1000)]
    public string? pnc_address_list { get; set; }

    [StringLength(400)]
    public string? pnc_subject { get; set; }

    public int pnc_event_id { get; set; }

    public bool pnc_vip { get; set; }

    public int? pnc_filter_levels { get; set; }

    [Column(TypeName = "xml")]
    public string? pnc_filter_countries { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pnc_last_find { get; set; }

    public int? pnc_detections { get; set; }
}
