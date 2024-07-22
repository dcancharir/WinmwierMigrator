using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("eh_datetime", "eh_terminal_id", "eh_event_id")]
[Table("event_history")]
[Index("eh_timestamp", Name = "IX_event_timestamp")]
public partial class event_history
{
    [Key]
    public long eh_event_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime eh_reported { get; set; }

    [Key]
    public int eh_terminal_id { get; set; }

    public int? eh_session_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime eh_datetime { get; set; }

    public int eh_event_type { get; set; }

    [StringLength(50)]
    public string? eh_event_data { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? eh_ack_date { get; set; }

    [StringLength(50)]
    public string? eh_ack_user { get; set; }

    public byte[] eh_timestamp { get; set; } = null!;

    public int? eh_device_code { get; set; }

    public int? eh_device_status { get; set; }

    public int? eh_device_priority { get; set; }

    public int? eh_operation_code { get; set; }

    [Column(TypeName = "money")]
    public decimal? eh_operation_data { get; set; }

    [ForeignKey("eh_terminal_id")]
    [InverseProperty("event_histories")]
    public virtual terminal eh_terminal { get; set; } = null!;
}
