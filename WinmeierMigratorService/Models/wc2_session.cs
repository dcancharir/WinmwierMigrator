using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Index("w2s_terminal_id", "w2s_started", Name = "IX_wc2_sessions")]
[Index("w2s_status", "w2s_terminal_id", "w2s_session_id", Name = "IX_wc2_status")]
public partial class wc2_session
{
    [Key]
    public long w2s_session_id { get; set; }

    public int w2s_terminal_id { get; set; }

    public long w2s_last_sequence_id { get; set; }

    public long w2s_last_transaction_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? w2s_last_rcvd_msg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime w2s_started { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? w2s_finished { get; set; }

    /// <summary>
    /// 0 - Opened, 1 - Closed, 2 - Abandoned, 3 - Timeout
    /// </summary>
    public int w2s_status { get; set; }

    public byte[]? w2s_timestamp { get; set; }

    [StringLength(50)]
    public string? w2s_server_name { get; set; }
}
