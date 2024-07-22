using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("wtx_terminal_id", "wtx_sequence_id", "wtx_requested_by_terminal")]
[Index("wtx_terminal_id", Name = "IX_wcp_transactions")]
public partial class wcp_transaction
{
    [Key]
    public int wtx_terminal_id { get; set; }

    [Key]
    public long wtx_sequence_id { get; set; }

    [Key]
    public bool wtx_requested_by_terminal { get; set; }

    public long wtx_session_id { get; set; }

    /// <summary>
    /// 0 - Running, 1 - Finished
    /// </summary>
    public int wtx_status { get; set; }

    public long? wtx_request_msg_id { get; set; }

    public long? wtx_response_msg_id { get; set; }

    [ForeignKey("wtx_session_id")]
    [InverseProperty("wcp_transactions")]
    public virtual wcp_session wtx_session { get; set; } = null!;

    [ForeignKey("wtx_terminal_id")]
    [InverseProperty("wcp_transactions")]
    public virtual terminal wtx_terminal { get; set; } = null!;
}
