using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Index("msg_enabled", "msg_schedule_start", Name = "IX_msg_enabled_start")]
public partial class lcd_message
{
    [Key]
    public long msg_unique_id { get; set; }

    public int msg_type { get; set; }

    [Column(TypeName = "xml")]
    public string? msg_site_list { get; set; }

    [Column(TypeName = "xml")]
    public string? msg_terminal_list { get; set; }

    [Column(TypeName = "xml")]
    public string? msg_account_list { get; set; }

    public bool msg_enabled { get; set; }

    public int msg_order { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime msg_schedule_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? msg_schedule_end { get; set; }

    public int msg_schedule_weekday { get; set; }

    public int msg_schedule1_time_from { get; set; }

    public int msg_schedule1_time_to { get; set; }

    public bool msg_schedule2_enabled { get; set; }

    public int? msg_schedule2_time_from { get; set; }

    public int? msg_schedule2_time_to { get; set; }

    [Column(TypeName = "xml")]
    public string msg_message { get; set; } = null!;

    public long msg_resource_id { get; set; }

    public byte[]? msg_timestamp { get; set; }

    public long? msg_master_sequence_id { get; set; }

    public int? msg_computed_order { get; set; }
}
