using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("play_safe.terminal_pending")]
[Index("pstp_terminal_id", "pstp_id", Name = "IX_pstp_tid_id")]
public partial class play_safe_terminal_pending
{
    [Key]
    public long pstp_id { get; set; }

    public int pstp_terminal_id { get; set; }

    public int pstp_reason { get; set; }

    public long? pstp_data { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pstp_inserted { get; set; }

    [StringLength(50)]
    public string? pstp_text { get; set; }
}
