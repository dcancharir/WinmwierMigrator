using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[PrimaryKey("w2tx_terminal_id", "w2tx_sequence_id", "w2tx_requested_by_terminal")]
[Index("w2tx_terminal_id", Name = "IX_wc2_transactions")]
public partial class wc2_transaction
{
    [Key]
    public int w2tx_terminal_id { get; set; }

    [Key]
    public long w2tx_sequence_id { get; set; }

    [Key]
    public bool w2tx_requested_by_terminal { get; set; }

    public long w2tx_session_id { get; set; }

    /// <summary>
    /// 0 - Running, 1 - Finished
    /// </summary>
    public int w2tx_status { get; set; }

    public long? w2tx_request_msg_id { get; set; }

    public long? w2tx_response_msg_id { get; set; }

    [ForeignKey("w2tx_session_id")]
    [InverseProperty("wc2_transactions")]
    public virtual wc2_session w2tx_session { get; set; } = null!;

    [ForeignKey("w2tx_terminal_id")]
    [InverseProperty("wc2_transactions")]
    public virtual terminal w2tx_terminal { get; set; } = null!;
}
