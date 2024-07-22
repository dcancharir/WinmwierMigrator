using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierMigratorService.Models;

[Table("reserved_terminal_transaction")]
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

    [ForeignKey("rtt_account_id")]
    [InverseProperty("reserved_terminal_transactions")]
    public virtual account rtt_account { get; set; } = null!;

    [ForeignKey("rtt_terminal_id")]
    [InverseProperty("reserved_terminal_transactions")]
    public virtual terminal rtt_terminal { get; set; } = null!;
}
