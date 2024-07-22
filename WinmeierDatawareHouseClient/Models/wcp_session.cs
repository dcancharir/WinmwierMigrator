using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Index("ws_terminal_id", "ws_started", Name = "IX_wcp_sessions")]
[Index("ws_status", "ws_terminal_id", "ws_session_id", Name = "IX_wcp_status")]
public partial class wcp_session
{
    [Key]
    public long ws_session_id { get; set; }

    public int ws_terminal_id { get; set; }

    public long ws_last_sequence_id { get; set; }

    public long ws_last_transaction_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ws_last_rcvd_msg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ws_started { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ws_finished { get; set; }

    /// <summary>
    /// 0 - Opened, 1 - Closed, 2 - Abandoned, 3 - Timeout
    /// </summary>
    public int ws_status { get; set; }

    public byte[]? ws_timestamp { get; set; }

    [StringLength(50)]
    public string? ws_server_name { get; set; }
}
