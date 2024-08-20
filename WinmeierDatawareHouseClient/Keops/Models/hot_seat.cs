using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class hot_seat
{
    public long hs_id { get; set; }

    [StringLength(100)]
    public string hs_name { get; set; } = null!;

    public bool hs_enabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hs_start_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hs_end_date { get; set; }

    [StringLength(6)]
    public string hs_iso_code { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string? hs_terminals { get; set; }

    public int? hs_by_gender { get; set; }

    public int? hs_by_date_of_birth { get; set; }

    public int? hs_by_level { get; set; }

    public int? hs_vip { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? hs_last_update { get; set; }

    [StringLength(512)]
    public string? hs_displays_notification_message { get; set; }

    public int? hs_displays_notification_message_duration { get; set; }

    public bool hs_displays_winner_notify_enabled { get; set; }

    [StringLength(512)]
    public string? hs_displays_winner_message_line1 { get; set; }

    public int? hs_displays_winner_message_duration { get; set; }

    [StringLength(512)]
    public string? hs_displays_winner_message_line2 { get; set; }
}
