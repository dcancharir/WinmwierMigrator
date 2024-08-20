using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("reserved_terminal_transaction")]
public partial class reserved_terminal_transaction
{
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

    public int? rtt_type { get; set; }

    public int? rtt_minutes_reserve { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? rtt_created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RTT_EXPIRES { get; set; }
}
