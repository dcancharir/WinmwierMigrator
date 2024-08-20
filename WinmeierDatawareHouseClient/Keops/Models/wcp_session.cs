using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class wcp_session
{
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

    public int ws_status { get; set; }

    public byte[]? ws_timestamp { get; set; }

    [StringLength(100)]
    public string? ws_server_name { get; set; }
}
