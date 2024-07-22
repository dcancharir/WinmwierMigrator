using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("reserved_terminal_transaction")]
[Index("rtt_account_id", Name = "IX_reserved_terminal_transaction_rtt_account_id")]
[Index("rtt_terminal_id", Name = "IX_reserved_terminal_transaction_rtt_terminal_id")]
public partial class reserved_terminal_transaction
{
    [Key]
    public long rtt_transaction_id { get; set; }

    public long rtt_account_id { get; set; }

    public int rtt_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime rtt_start_reserved { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? rtt_end_reserved { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime rtt_start_utc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? rtt_end_utc { get; set; }

    public int rtt_max_minutes { get; set; }

    public int? rtt_total_minutes { get; set; }

    public int rtt_status { get; set; }
}
