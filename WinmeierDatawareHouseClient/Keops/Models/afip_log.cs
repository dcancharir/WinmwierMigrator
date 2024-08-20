using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Table("afip_log")]
public partial class afip_log
{
    [Key]
    public long afl_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? afl_RequestDateTime { get; set; }

    [StringLength(100)]
    public string? afl_TerminalAFIP { get; set; }

    public int? afl_StatusRequestedTerminal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? afl_activation_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? afl_retirement_date { get; set; }

    public int? afl_terminal_status { get; set; }

    public int? afl_terminal_id { get; set; }

    public int? afl_exist_terminal_with_status_ok { get; set; }

    public int? afl_exist_active_session_in_time { get; set; }

    public int? afl_session_timeout { get; set; }

    [StringLength(100)]
    public string afl_step { get; set; } = null!;
}
