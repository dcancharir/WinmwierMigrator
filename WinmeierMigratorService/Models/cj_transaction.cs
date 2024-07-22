using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("ctx_sequence_number", "ctx_queue_id")]
[Index("ctx_terminal_id", "ctx_transaction_id", "ctx_sequence_id", "ctx_session_id", Name = "IX_cj_transactions")]
public partial class cj_transaction
{
    [Key]
    public long ctx_queue_id { get; set; }

    [Key]
    public int ctx_sequence_number { get; set; }

    public int ctx_terminal_id { get; set; }

    public long ctx_session_id { get; set; }

    public long ctx_sequence_id { get; set; }

    public long ctx_transaction_id { get; set; }

    /// <summary>
    /// 0 - Running, 1 - Finished
    /// </summary>
    public int ctx_status { get; set; }

    public long? ctx_request_msg_id { get; set; }

    public long? ctx_response_msg_id { get; set; }

    [ForeignKey("ctx_queue_id")]
    [InverseProperty("cj_transactions")]
    public virtual cj_queue ctx_queue { get; set; } = null!;

    [ForeignKey("ctx_session_id")]
    [InverseProperty("cj_transactions")]
    public virtual wcp_session ctx_session { get; set; } = null!;

    [ForeignKey("ctx_terminal_id")]
    [InverseProperty("cj_transactions")]
    public virtual terminal ctx_terminal { get; set; } = null!;
}
