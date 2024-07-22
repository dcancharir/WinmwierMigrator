using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("al_datetime", "al_severity", "al_source_code", "al_source_id", Name = "IX_alarms_datetime_severity_source", IsDescending = new[] { true, true, false, false })]
[Index("al_timestamp", Name = "IX_alarms_timestamp")]
public partial class alarm
{
    [Key]
    public long al_alarm_id { get; set; }

    public int al_source_code { get; set; }

    public long al_source_id { get; set; }

    [StringLength(100)]
    public string al_source_name { get; set; } = null!;

    public int al_alarm_code { get; set; }

    [StringLength(50)]
    public string al_alarm_name { get; set; } = null!;

    public string? al_alarm_description { get; set; }

    public int al_severity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime al_reported { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime al_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? al_ack_datetime { get; set; }

    public int? al_ack_user_id { get; set; }

    [StringLength(50)]
    public string? al_ack_user_name { get; set; }

    public byte[] al_timestamp { get; set; } = null!;

    public int? al_technician_id { get; set; }
}
